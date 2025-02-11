// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.SWAS_OPEN20200601.Models;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("swas-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Shares a custom image with other Alibaba Cloud accounts in the same region to quickly deploy the same environment configurations for multiple simple application servers at a time. This improves deployment efficiency.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you share a custom image, make sure that all sensitive data and files are removed from the image.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of the Alibaba Cloud accounts with which you want to share the image is obtained. Move the pointer over the profile in the upper-right corner of the Simple Application Server console. In the card that appears, if Main Account is displayed, the showed account ID is the Alibaba Cloud account ID.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCustomImageShareAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomImageShareAccountResponse
        /// </returns>
        public AddCustomImageShareAccountResponse AddCustomImageShareAccountWithOptions(AddCustomImageShareAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "AddCustomImageShareAccount",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCustomImageShareAccountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCustomImageShareAccountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares a custom image with other Alibaba Cloud accounts in the same region to quickly deploy the same environment configurations for multiple simple application servers at a time. This improves deployment efficiency.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you share a custom image, make sure that all sensitive data and files are removed from the image.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of the Alibaba Cloud accounts with which you want to share the image is obtained. Move the pointer over the profile in the upper-right corner of the Simple Application Server console. In the card that appears, if Main Account is displayed, the showed account ID is the Alibaba Cloud account ID.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCustomImageShareAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomImageShareAccountResponse
        /// </returns>
        public async Task<AddCustomImageShareAccountResponse> AddCustomImageShareAccountWithOptionsAsync(AddCustomImageShareAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "AddCustomImageShareAccount",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AddCustomImageShareAccountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AddCustomImageShareAccountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares a custom image with other Alibaba Cloud accounts in the same region to quickly deploy the same environment configurations for multiple simple application servers at a time. This improves deployment efficiency.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you share a custom image, make sure that all sensitive data and files are removed from the image.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of the Alibaba Cloud accounts with which you want to share the image is obtained. Move the pointer over the profile in the upper-right corner of the Simple Application Server console. In the card that appears, if Main Account is displayed, the showed account ID is the Alibaba Cloud account ID.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCustomImageShareAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomImageShareAccountResponse
        /// </returns>
        public AddCustomImageShareAccountResponse AddCustomImageShareAccount(AddCustomImageShareAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomImageShareAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares a custom image with other Alibaba Cloud accounts in the same region to quickly deploy the same environment configurations for multiple simple application servers at a time. This improves deployment efficiency.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you share a custom image, make sure that all sensitive data and files are removed from the image.</para>
        /// <list type="bullet">
        /// <item><description>The IDs of the Alibaba Cloud accounts with which you want to share the image is obtained. Move the pointer over the profile in the upper-right corner of the Simple Application Server console. In the card that appears, if Main Account is displayed, the showed account ID is the Alibaba Cloud account ID.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AddCustomImageShareAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomImageShareAccountResponse
        /// </returns>
        public async Task<AddCustomImageShareAccountResponse> AddCustomImageShareAccountAsync(AddCustomImageShareAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomImageShareAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, no public endpoints are assigned to Simple Database Service instances. If you want to access the databases of a Simple Database Service instance over the Internet by using Simple Container Service or Data Management (DMS), you must apply for a public endpoint for the Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AllocatePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocatePublicConnectionResponse
        /// </returns>
        public AllocatePublicConnectionResponse AllocatePublicConnectionWithOptions(AllocatePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "AllocatePublicConnection",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AllocatePublicConnectionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AllocatePublicConnectionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, no public endpoints are assigned to Simple Database Service instances. If you want to access the databases of a Simple Database Service instance over the Internet by using Simple Container Service or Data Management (DMS), you must apply for a public endpoint for the Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AllocatePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AllocatePublicConnectionResponse
        /// </returns>
        public async Task<AllocatePublicConnectionResponse> AllocatePublicConnectionWithOptionsAsync(AllocatePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "AllocatePublicConnection",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AllocatePublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AllocatePublicConnectionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, no public endpoints are assigned to Simple Database Service instances. If you want to access the databases of a Simple Database Service instance over the Internet by using Simple Container Service or Data Management (DMS), you must apply for a public endpoint for the Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AllocatePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocatePublicConnectionResponse
        /// </returns>
        public AllocatePublicConnectionResponse AllocatePublicConnection(AllocatePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllocatePublicConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Applies for a public endpoint for a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, no public endpoints are assigned to Simple Database Service instances. If you want to access the databases of a Simple Database Service instance over the Internet by using Simple Container Service or Data Management (DMS), you must apply for a public endpoint for the Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AllocatePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// AllocatePublicConnectionResponse
        /// </returns>
        public async Task<AllocatePublicConnectionResponse> AllocatePublicConnectionAsync(AllocatePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllocatePublicConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a firewall template to apply firewall rules to multiple simple application servers at a time. This improves your efficiency of setting firewall rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the port range, protocol, and source IP address of a firewall rule in a firewall template are the same as the port range, protocol, and source IP address of an existing rule, the new rule overwrites the existing rule regardless of whether the existing rule is enabled or disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFirewallTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyFirewallTemplateResponse
        /// </returns>
        public ApplyFirewallTemplateResponse ApplyFirewallTemplateWithOptions(ApplyFirewallTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "ApplyFirewallTemplate",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ApplyFirewallTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ApplyFirewallTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a firewall template to apply firewall rules to multiple simple application servers at a time. This improves your efficiency of setting firewall rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the port range, protocol, and source IP address of a firewall rule in a firewall template are the same as the port range, protocol, and source IP address of an existing rule, the new rule overwrites the existing rule regardless of whether the existing rule is enabled or disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFirewallTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyFirewallTemplateResponse
        /// </returns>
        public async Task<ApplyFirewallTemplateResponse> ApplyFirewallTemplateWithOptionsAsync(ApplyFirewallTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "ApplyFirewallTemplate",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ApplyFirewallTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ApplyFirewallTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a firewall template to apply firewall rules to multiple simple application servers at a time. This improves your efficiency of setting firewall rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the port range, protocol, and source IP address of a firewall rule in a firewall template are the same as the port range, protocol, and source IP address of an existing rule, the new rule overwrites the existing rule regardless of whether the existing rule is enabled or disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFirewallTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyFirewallTemplateResponse
        /// </returns>
        public ApplyFirewallTemplateResponse ApplyFirewallTemplate(ApplyFirewallTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyFirewallTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uses a firewall template to apply firewall rules to multiple simple application servers at a time. This improves your efficiency of setting firewall rules.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the port range, protocol, and source IP address of a firewall rule in a firewall template are the same as the port range, protocol, and source IP address of an existing rule, the new rule overwrites the existing rule regardless of whether the existing rule is enabled or disabled.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyFirewallTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyFirewallTemplateResponse
        /// </returns>
        public async Task<ApplyFirewallTemplateResponse> ApplyFirewallTemplateAsync(ApplyFirewallTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyFirewallTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a key pair to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can bind only one key pair to a simple application server in the Simple Application Server console. If a simple application server has a key pair bound, the new key pair overwrites the original key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public AttachKeyPairResponse AttachKeyPairWithOptions(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "AttachKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AttachKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AttachKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a key pair to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can bind only one key pair to a simple application server in the Simple Application Server console. If a simple application server has a key pair bound, the new key pair overwrites the original key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public async Task<AttachKeyPairResponse> AttachKeyPairWithOptionsAsync(AttachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "AttachKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<AttachKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AttachKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a key pair to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can bind only one key pair to a simple application server in the Simple Application Server console. If a simple application server has a key pair bound, the new key pair overwrites the original key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public AttachKeyPairResponse AttachKeyPair(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a key pair to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can bind only one key pair to a simple application server in the Simple Application Server console. If a simple application server has a key pair bound, the new key pair overwrites the original key pair.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachKeyPairResponse
        /// </returns>
        public async Task<AttachKeyPairResponse> AttachKeyPairAsync(AttachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCommandResponse
        /// </returns>
        public CreateCommandResponse CreateCommandWithOptions(CreateCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableParameter))
            {
                query["EnableParameter"] = request.EnableParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingDir))
            {
                query["WorkingDir"] = request.WorkingDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateCommandResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateCommandResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCommandResponse
        /// </returns>
        public async Task<CreateCommandResponse> CreateCommandWithOptionsAsync(CreateCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableParameter))
            {
                query["EnableParameter"] = request.EnableParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingDir))
            {
                query["WorkingDir"] = request.WorkingDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateCommandResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateCommandResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCommandResponse
        /// </returns>
        public CreateCommandResponse CreateCommand(CreateCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCommandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCommandResponse
        /// </returns>
        public async Task<CreateCommandResponse> CreateCommandAsync(CreateCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image based on a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A custom image is created from a snapshot of a simple application server. You can use a custom image to create multiple simple application servers that have the same configurations. You can also share custom images to ECS and use the shared images to create ECS instances or replace the OSs of existing ECS instances. For more information about custom images, see <a href="https://help.aliyun.com/document_detail/199375.html">Overview of custom images</a>.
        /// You must create a system disk snapshot of a simple application server before you create a custom image based on the snapshot. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.</para>
        /// <remarks>
        /// <para> If you need the data on the data disk of a simple application server when you create a custom image, create a snapshot for the data disk first.
        /// Before you create a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The custom image and the corresponding simple application server must reside in the same region.</description></item>
        /// <item><description>The maximum number of custom images that you can create is 3 times the number of simple application servers that you have, but cannot exceed 15.</description></item>
        /// <item><description>You can directly create a custom image only based on the system disk snapshot of a simple application server. If you want a custom image to contain the data on the data disk of the simple application server, you must select a data disk snapshot in addition to a system disk snapshot when you create the custom image.</description></item>
        /// <item><description>If a simple application server is released due to expiration or refunds, the custom images that are created based on the server are also released.</description></item>
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public CreateCustomImageResponse CreateCustomImageWithOptions(CreateCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSnapshotId))
            {
                query["DataSnapshotId"] = request.DataSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemSnapshotId))
            {
                query["SystemSnapshotId"] = request.SystemSnapshotId;
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
                Action = "CreateCustomImage",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateCustomImageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateCustomImageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image based on a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A custom image is created from a snapshot of a simple application server. You can use a custom image to create multiple simple application servers that have the same configurations. You can also share custom images to ECS and use the shared images to create ECS instances or replace the OSs of existing ECS instances. For more information about custom images, see <a href="https://help.aliyun.com/document_detail/199375.html">Overview of custom images</a>.
        /// You must create a system disk snapshot of a simple application server before you create a custom image based on the snapshot. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.</para>
        /// <remarks>
        /// <para> If you need the data on the data disk of a simple application server when you create a custom image, create a snapshot for the data disk first.
        /// Before you create a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The custom image and the corresponding simple application server must reside in the same region.</description></item>
        /// <item><description>The maximum number of custom images that you can create is 3 times the number of simple application servers that you have, but cannot exceed 15.</description></item>
        /// <item><description>You can directly create a custom image only based on the system disk snapshot of a simple application server. If you want a custom image to contain the data on the data disk of the simple application server, you must select a data disk snapshot in addition to a system disk snapshot when you create the custom image.</description></item>
        /// <item><description>If a simple application server is released due to expiration or refunds, the custom images that are created based on the server are also released.</description></item>
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public async Task<CreateCustomImageResponse> CreateCustomImageWithOptionsAsync(CreateCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSnapshotId))
            {
                query["DataSnapshotId"] = request.DataSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageName))
            {
                query["ImageName"] = request.ImageName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemSnapshotId))
            {
                query["SystemSnapshotId"] = request.SystemSnapshotId;
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
                Action = "CreateCustomImage",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateCustomImageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateCustomImageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image based on a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A custom image is created from a snapshot of a simple application server. You can use a custom image to create multiple simple application servers that have the same configurations. You can also share custom images to ECS and use the shared images to create ECS instances or replace the OSs of existing ECS instances. For more information about custom images, see <a href="https://help.aliyun.com/document_detail/199375.html">Overview of custom images</a>.
        /// You must create a system disk snapshot of a simple application server before you create a custom image based on the snapshot. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.</para>
        /// <remarks>
        /// <para> If you need the data on the data disk of a simple application server when you create a custom image, create a snapshot for the data disk first.
        /// Before you create a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The custom image and the corresponding simple application server must reside in the same region.</description></item>
        /// <item><description>The maximum number of custom images that you can create is 3 times the number of simple application servers that you have, but cannot exceed 15.</description></item>
        /// <item><description>You can directly create a custom image only based on the system disk snapshot of a simple application server. If you want a custom image to contain the data on the data disk of the simple application server, you must select a data disk snapshot in addition to a system disk snapshot when you create the custom image.</description></item>
        /// <item><description>If a simple application server is released due to expiration or refunds, the custom images that are created based on the server are also released.</description></item>
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public CreateCustomImageResponse CreateCustomImage(CreateCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom image based on a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A custom image is created from a snapshot of a simple application server. You can use a custom image to create multiple simple application servers that have the same configurations. You can also share custom images to ECS and use the shared images to create ECS instances or replace the OSs of existing ECS instances. For more information about custom images, see <a href="https://help.aliyun.com/document_detail/199375.html">Overview of custom images</a>.
        /// You must create a system disk snapshot of a simple application server before you create a custom image based on the snapshot. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.</para>
        /// <remarks>
        /// <para> If you need the data on the data disk of a simple application server when you create a custom image, create a snapshot for the data disk first.
        /// Before you create a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>The custom image and the corresponding simple application server must reside in the same region.</description></item>
        /// <item><description>The maximum number of custom images that you can create is 3 times the number of simple application servers that you have, but cannot exceed 15.</description></item>
        /// <item><description>You can directly create a custom image only based on the system disk snapshot of a simple application server. If you want a custom image to contain the data on the data disk of the simple application server, you must select a data disk snapshot in addition to a system disk snapshot when you create the custom image.</description></item>
        /// <item><description>If a simple application server is released due to expiration or refunds, the custom images that are created based on the server are also released.</description></item>
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateCustomImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomImageResponse
        /// </returns>
        public async Task<CreateCustomImageResponse> CreateCustomImageAsync(CreateCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRuleResponse
        /// </returns>
        public CreateFirewallRuleResponse CreateFirewallRuleWithOptions(CreateFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleProtocol))
            {
                query["RuleProtocol"] = request.RuleProtocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRuleResponse
        /// </returns>
        public async Task<CreateFirewallRuleResponse> CreateFirewallRuleWithOptionsAsync(CreateFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleProtocol))
            {
                query["RuleProtocol"] = request.RuleProtocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRuleResponse
        /// </returns>
        public CreateFirewallRuleResponse CreateFirewallRule(CreateFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFirewallRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRuleResponse
        /// </returns>
        public async Task<CreateFirewallRuleResponse> CreateFirewallRuleAsync(CreateFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFirewallRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple firewall rules for a simple application server at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateFirewallRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRulesResponse
        /// </returns>
        public CreateFirewallRulesResponse CreateFirewallRulesWithOptions(CreateFirewallRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFirewallRulesShrinkRequest request = new CreateFirewallRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FirewallRules))
            {
                request.FirewallRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FirewallRules, "FirewallRules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRulesShrink))
            {
                query["FirewallRules"] = request.FirewallRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "CreateFirewallRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple firewall rules for a simple application server at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateFirewallRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRulesResponse
        /// </returns>
        public async Task<CreateFirewallRulesResponse> CreateFirewallRulesWithOptionsAsync(CreateFirewallRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateFirewallRulesShrinkRequest request = new CreateFirewallRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FirewallRules))
            {
                request.FirewallRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FirewallRules, "FirewallRules", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRulesShrink))
            {
                query["FirewallRules"] = request.FirewallRulesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "CreateFirewallRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple firewall rules for a simple application server at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRulesResponse
        /// </returns>
        public CreateFirewallRulesResponse CreateFirewallRules(CreateFirewallRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFirewallRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates multiple firewall rules for a simple application server at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Firewalls serve to control network access to simple application servers and isolate security domains in the cloud. By default, SSH port 22, HTTP port 80, and HTTPS port 443 are enabled for simple application servers. Other ports are disabled. You can add firewall rules to enable more ports.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallRulesResponse
        /// </returns>
        public async Task<CreateFirewallRulesResponse> CreateFirewallRulesAsync(CreateFirewallRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFirewallRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Simple Application Server supports the firewall template feature that provides multiple firewall rules. You can use a template to add a group of firewall rules to one or more simple application servers at a time. This improves the efficiency of setting firewall rules.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateResponse
        /// </returns>
        public CreateFirewallTemplateResponse CreateFirewallTemplateWithOptions(CreateFirewallTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRule))
            {
                query["FirewallRule"] = request.FirewallRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateFirewallTemplate",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Simple Application Server supports the firewall template feature that provides multiple firewall rules. You can use a template to add a group of firewall rules to one or more simple application servers at a time. This improves the efficiency of setting firewall rules.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateResponse
        /// </returns>
        public async Task<CreateFirewallTemplateResponse> CreateFirewallTemplateWithOptionsAsync(CreateFirewallTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRule))
            {
                query["FirewallRule"] = request.FirewallRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "CreateFirewallTemplate",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Simple Application Server supports the firewall template feature that provides multiple firewall rules. You can use a template to add a group of firewall rules to one or more simple application servers at a time. This improves the efficiency of setting firewall rules.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateResponse
        /// </returns>
        public CreateFirewallTemplateResponse CreateFirewallTemplate(CreateFirewallTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFirewallTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a firewall template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Simple Application Server supports the firewall template feature that provides multiple firewall rules. You can use a template to add a group of firewall rules to one or more simple application servers at a time. This improves the efficiency of setting firewall rules.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateResponse
        /// </returns>
        public async Task<CreateFirewallTemplateResponse> CreateFirewallTemplateAsync(CreateFirewallTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFirewallTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds firewall rules to a firewall template based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adding firewall rules to a firewall template does not affect the firewall rules that have been applied to simple application servers..</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateRulesResponse
        /// </returns>
        public CreateFirewallTemplateRulesResponse CreateFirewallTemplateRulesWithOptions(CreateFirewallTemplateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRule))
            {
                query["FirewallRule"] = request.FirewallRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
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
                Action = "CreateFirewallTemplateRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallTemplateRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallTemplateRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds firewall rules to a firewall template based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adding firewall rules to a firewall template does not affect the firewall rules that have been applied to simple application servers..</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateRulesResponse
        /// </returns>
        public async Task<CreateFirewallTemplateRulesResponse> CreateFirewallTemplateRulesWithOptionsAsync(CreateFirewallTemplateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRule))
            {
                query["FirewallRule"] = request.FirewallRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
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
                Action = "CreateFirewallTemplateRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateFirewallTemplateRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFirewallTemplateRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds firewall rules to a firewall template based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adding firewall rules to a firewall template does not affect the firewall rules that have been applied to simple application servers..</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateRulesResponse
        /// </returns>
        public CreateFirewallTemplateRulesResponse CreateFirewallTemplateRules(CreateFirewallTemplateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFirewallTemplateRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds firewall rules to a firewall template based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adding firewall rules to a firewall template does not affect the firewall rules that have been applied to simple application servers..</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateFirewallTemplateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFirewallTemplateRulesResponse
        /// </returns>
        public async Task<CreateFirewallTemplateRulesResponse> CreateFirewallTemplateRulesAsync(CreateFirewallTemplateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFirewallTemplateRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceKeyPairResponse
        /// </returns>
        public CreateInstanceKeyPairResponse CreateInstanceKeyPairWithOptions(CreateInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "CreateInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateInstanceKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateInstanceKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceKeyPairResponse
        /// </returns>
        public async Task<CreateInstanceKeyPairResponse> CreateInstanceKeyPairWithOptionsAsync(CreateInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "CreateInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateInstanceKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateInstanceKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceKeyPairResponse
        /// </returns>
        public CreateInstanceKeyPairResponse CreateInstanceKeyPair(CreateInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceKeyPairResponse
        /// </returns>
        public async Task<CreateInstanceKeyPairResponse> CreateInstanceKeyPairAsync(CreateInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates subscription simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing rules of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <remarks>
        /// <para> If you have coupons in your Alibaba Cloud account, the coupons are preferentially used to pay for the simple application servers.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 50 simple application servers in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>When you call this operation to create simple application servers, make sure that the balance in your account is sufficient to pay for the servers. If the balance in your account is insufficient, the servers cannot be created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstancesResponse
        /// </returns>
        public CreateInstancesResponse CreateInstancesWithOptions(CreateInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDiskSize))
            {
                query["DataDiskSize"] = request.DataDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
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
                Action = "CreateInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates subscription simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing rules of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <remarks>
        /// <para> If you have coupons in your Alibaba Cloud account, the coupons are preferentially used to pay for the simple application servers.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 50 simple application servers in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>When you call this operation to create simple application servers, make sure that the balance in your account is sufficient to pay for the servers. If the balance in your account is insufficient, the servers cannot be created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstancesResponse
        /// </returns>
        public async Task<CreateInstancesResponse> CreateInstancesWithOptionsAsync(CreateInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Amount))
            {
                query["Amount"] = request.Amount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataDiskSize))
            {
                query["DataDiskSize"] = request.DataDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
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
                Action = "CreateInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates subscription simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing rules of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <remarks>
        /// <para> If you have coupons in your Alibaba Cloud account, the coupons are preferentially used to pay for the simple application servers.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 50 simple application servers in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>When you call this operation to create simple application servers, make sure that the balance in your account is sufficient to pay for the servers. If the balance in your account is insufficient, the servers cannot be created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstancesResponse
        /// </returns>
        public CreateInstancesResponse CreateInstances(CreateInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates subscription simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing rules of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <remarks>
        /// <para> If you have coupons in your Alibaba Cloud account, the coupons are preferentially used to pay for the simple application servers.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You can create a maximum of 50 simple application servers in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>When you call this operation to create simple application servers, make sure that the balance in your account is sufficient to pay for the servers. If the balance in your account is insufficient, the servers cannot be created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstancesResponse
        /// </returns>
        public async Task<CreateInstancesResponse> CreateInstancesAsync(CreateInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud SSH key pairs offer a secure and efficient logon authentication mechanism, facilitating both verification and encrypted communication within the SSH protocol framework. An SSH key pair is essentially constituted by a public key and a private key. Tailored for Linux-based simple application servers, this security measure enhances security and convenience, effectively addressing your heightened security requirements.</para>
        /// <list type="bullet">
        /// <item><description>The key pair logon method is only valid for Linux-based simple application servers.</description></item>
        /// <item><description>A maximum of 10 key pairs can be created in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>Only RSA 2048-bit key pairs can be created in the Simple Application Server console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public CreateKeyPairResponse CreateKeyPairWithOptions(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "CreateKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud SSH key pairs offer a secure and efficient logon authentication mechanism, facilitating both verification and encrypted communication within the SSH protocol framework. An SSH key pair is essentially constituted by a public key and a private key. Tailored for Linux-based simple application servers, this security measure enhances security and convenience, effectively addressing your heightened security requirements.</para>
        /// <list type="bullet">
        /// <item><description>The key pair logon method is only valid for Linux-based simple application servers.</description></item>
        /// <item><description>A maximum of 10 key pairs can be created in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>Only RSA 2048-bit key pairs can be created in the Simple Application Server console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public async Task<CreateKeyPairResponse> CreateKeyPairWithOptionsAsync(CreateKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "CreateKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud SSH key pairs offer a secure and efficient logon authentication mechanism, facilitating both verification and encrypted communication within the SSH protocol framework. An SSH key pair is essentially constituted by a public key and a private key. Tailored for Linux-based simple application servers, this security measure enhances security and convenience, effectively addressing your heightened security requirements.</para>
        /// <list type="bullet">
        /// <item><description>The key pair logon method is only valid for Linux-based simple application servers.</description></item>
        /// <item><description>A maximum of 10 key pairs can be created in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>Only RSA 2048-bit key pairs can be created in the Simple Application Server console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a key pair.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Alibaba Cloud SSH key pairs offer a secure and efficient logon authentication mechanism, facilitating both verification and encrypted communication within the SSH protocol framework. An SSH key pair is essentially constituted by a public key and a private key. Tailored for Linux-based simple application servers, this security measure enhances security and convenience, effectively addressing your heightened security requirements.</para>
        /// <list type="bullet">
        /// <item><description>The key pair logon method is only valid for Linux-based simple application servers.</description></item>
        /// <item><description>A maximum of 10 key pairs can be created in a region for an Alibaba Cloud account.</description></item>
        /// <item><description>Only RSA 2048-bit key pairs can be created in the Simple Application Server console.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateKeyPairResponse
        /// </returns>
        public async Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot for a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A snapshot is a point-in-time backup of a disk. Snapshots can be used to back up data, recover data after misoperations on servers, recover data after network attacks, and create custom images.</para>
        /// <remarks>
        /// <para> You are not charged for creating snapshots in Simple Application Server.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>You can create up to three snapshots for each simple application server.</description></item>
        /// <item><description>The maximum number of snapshots that you create per Alibaba Cloud account is triple of the number of simple application servers that are created. The value cannot be greater than 15.</description></item>
        /// <item><description>If a simple application server is automatically released due to expiration, the snapshots created for the server are deleted.</description></item>
        /// <item><description>If you reset a simple application server after you create a snapshot for the server, the snapshot is retained but cannot be used to restore the disks of the server.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public CreateSnapshotResponse CreateSnapshotWithOptions(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
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
                Action = "CreateSnapshot",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateSnapshotResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSnapshotResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot for a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A snapshot is a point-in-time backup of a disk. Snapshots can be used to back up data, recover data after misoperations on servers, recover data after network attacks, and create custom images.</para>
        /// <remarks>
        /// <para> You are not charged for creating snapshots in Simple Application Server.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>You can create up to three snapshots for each simple application server.</description></item>
        /// <item><description>The maximum number of snapshots that you create per Alibaba Cloud account is triple of the number of simple application servers that are created. The value cannot be greater than 15.</description></item>
        /// <item><description>If a simple application server is automatically released due to expiration, the snapshots created for the server are deleted.</description></item>
        /// <item><description>If you reset a simple application server after you create a snapshot for the server, the snapshot is retained but cannot be used to restore the disks of the server.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public async Task<CreateSnapshotResponse> CreateSnapshotWithOptionsAsync(CreateSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotName))
            {
                query["SnapshotName"] = request.SnapshotName;
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
                Action = "CreateSnapshot",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<CreateSnapshotResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSnapshotResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot for a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A snapshot is a point-in-time backup of a disk. Snapshots can be used to back up data, recover data after misoperations on servers, recover data after network attacks, and create custom images.</para>
        /// <remarks>
        /// <para> You are not charged for creating snapshots in Simple Application Server.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>You can create up to three snapshots for each simple application server.</description></item>
        /// <item><description>The maximum number of snapshots that you create per Alibaba Cloud account is triple of the number of simple application servers that are created. The value cannot be greater than 15.</description></item>
        /// <item><description>If a simple application server is automatically released due to expiration, the snapshots created for the server are deleted.</description></item>
        /// <item><description>If you reset a simple application server after you create a snapshot for the server, the snapshot is retained but cannot be used to restore the disks of the server.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSnapshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a snapshot for a disk.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A snapshot is a point-in-time backup of a disk. Snapshots can be used to back up data, recover data after misoperations on servers, recover data after network attacks, and create custom images.</para>
        /// <remarks>
        /// <para> You are not charged for creating snapshots in Simple Application Server.</para>
        /// </remarks>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>You can create up to three snapshots for each simple application server.</description></item>
        /// <item><description>The maximum number of snapshots that you create per Alibaba Cloud account is triple of the number of simple application servers that are created. The value cannot be greater than 15.</description></item>
        /// <item><description>If a simple application server is automatically released due to expiration, the snapshots created for the server are deleted.</description></item>
        /// <item><description>If you reset a simple application server after you create a snapshot for the server, the snapshot is retained but cannot be used to restore the disks of the server.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSnapshotResponse
        /// </returns>
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Command Assistant command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete commands that are being run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCommandResponse
        /// </returns>
        public DeleteCommandResponse DeleteCommandWithOptions(DeleteCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
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
                Action = "DeleteCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCommandResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCommandResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Command Assistant command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete commands that are being run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCommandResponse
        /// </returns>
        public async Task<DeleteCommandResponse> DeleteCommandWithOptionsAsync(DeleteCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
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
                Action = "DeleteCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCommandResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCommandResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Command Assistant command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete commands that are being run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCommandResponse
        /// </returns>
        public DeleteCommandResponse DeleteCommand(DeleteCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCommandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Command Assistant command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot delete commands that are being run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCommandResponse
        /// </returns>
        public async Task<DeleteCommandResponse> DeleteCommandAsync(DeleteCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a custom image that you no longer need. After the custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// <remarks>
        /// <para> To delete a shared image, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or API. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a shared image of a simple application server in the ECS console</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImageResponse
        /// </returns>
        public DeleteCustomImageResponse DeleteCustomImageWithOptions(DeleteCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "DeleteCustomImage",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCustomImageResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCustomImageResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a custom image that you no longer need. After the custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// <remarks>
        /// <para> To delete a shared image, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or API. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a shared image of a simple application server in the ECS console</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImageResponse
        /// </returns>
        public async Task<DeleteCustomImageResponse> DeleteCustomImageWithOptionsAsync(DeleteCustomImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "DeleteCustomImage",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCustomImageResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCustomImageResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a custom image that you no longer need. After the custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// <remarks>
        /// <para> To delete a shared image, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or API. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a shared image of a simple application server in the ECS console</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImageResponse
        /// </returns>
        public DeleteCustomImageResponse DeleteCustomImage(DeleteCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a custom image that you no longer need. After the custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// <remarks>
        /// <para> To delete a shared image, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or API. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a shared image of a simple application server in the ECS console</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImageResponse
        /// </returns>
        public async Task<DeleteCustomImageResponse> DeleteCustomImageAsync(DeleteCustomImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes custom images. If you no longer require a custom image, you can call this operation to delete the custom image. You can also call this operation to delete multiple custom images at the same time. After a custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a custom image is shared, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or by calling an ECS API operation. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a custom image</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImagesResponse
        /// </returns>
        public DeleteCustomImagesResponse DeleteCustomImagesWithOptions(DeleteCustomImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
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
                Action = "DeleteCustomImages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCustomImagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCustomImagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes custom images. If you no longer require a custom image, you can call this operation to delete the custom image. You can also call this operation to delete multiple custom images at the same time. After a custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a custom image is shared, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or by calling an ECS API operation. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a custom image</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImagesResponse
        /// </returns>
        public async Task<DeleteCustomImagesResponse> DeleteCustomImagesWithOptionsAsync(DeleteCustomImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
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
                Action = "DeleteCustomImages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteCustomImagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteCustomImagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes custom images. If you no longer require a custom image, you can call this operation to delete the custom image. You can also call this operation to delete multiple custom images at the same time. After a custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a custom image is shared, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or by calling an ECS API operation. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a custom image</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImagesResponse
        /// </returns>
        public DeleteCustomImagesResponse DeleteCustomImages(DeleteCustomImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes custom images. If you no longer require a custom image, you can call this operation to delete the custom image. You can also call this operation to delete multiple custom images at the same time. After a custom image is deleted, you cannot use the custom image to reset the simple application servers that were created based on the custom image.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If a custom image is shared, you must unshare the image before you can delete it. After a custom image is unshared, you cannot query the custom image by using the Elastic Compute Service (ECS) console or by calling an ECS API operation. If you want to use a custom image to create ECS instances, we recommend that you copy the custom image before you delete it. For more information, see <a href="https://help.aliyun.com/document_detail/199378.html">Copy a custom image</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteCustomImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomImagesResponse
        /// </returns>
        public async Task<DeleteCustomImagesResponse> DeleteCustomImagesAsync(DeleteCustomImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRuleResponse
        /// </returns>
        public DeleteFirewallRuleResponse DeleteFirewallRuleWithOptions(DeleteFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DeleteFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRuleResponse
        /// </returns>
        public async Task<DeleteFirewallRuleResponse> DeleteFirewallRuleWithOptionsAsync(DeleteFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DeleteFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRuleResponse
        /// </returns>
        public DeleteFirewallRuleResponse DeleteFirewallRule(DeleteFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFirewallRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRuleResponse
        /// </returns>
        public async Task<DeleteFirewallRuleResponse> DeleteFirewallRuleAsync(DeleteFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFirewallRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteFirewallRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRulesResponse
        /// </returns>
        public DeleteFirewallRulesResponse DeleteFirewallRulesWithOptions(DeleteFirewallRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteFirewallRulesShrinkRequest request = new DeleteFirewallRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuleIds))
            {
                request.RuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuleIds, "RuleIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdsShrink))
            {
                query["RuleIds"] = request.RuleIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFirewallRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteFirewallRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRulesResponse
        /// </returns>
        public async Task<DeleteFirewallRulesResponse> DeleteFirewallRulesWithOptionsAsync(DeleteFirewallRulesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteFirewallRulesShrinkRequest request = new DeleteFirewallRulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RuleIds))
            {
                request.RuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RuleIds, "RuleIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleIdsShrink))
            {
                query["RuleIds"] = request.RuleIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFirewallRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRulesResponse
        /// </returns>
        public DeleteFirewallRulesResponse DeleteFirewallRules(DeleteFirewallRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFirewallRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes multiple firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a firewall rule is deleted, your business deployed on the simple application server may become inaccessible. Before you delete a firewall rule, make sure that the firewall rule is no longer needed by the simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallRulesResponse
        /// </returns>
        public async Task<DeleteFirewallRulesResponse> DeleteFirewallRulesAsync(DeleteFirewallRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFirewallRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall rules from a firewall template based on your requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletion of firewall rules does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplateRulesResponse
        /// </returns>
        public DeleteFirewallTemplateRulesResponse DeleteFirewallTemplateRulesWithOptions(DeleteFirewallTemplateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateRuleId))
            {
                query["FirewallTemplateRuleId"] = request.FirewallTemplateRuleId;
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
                Action = "DeleteFirewallTemplateRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallTemplateRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallTemplateRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall rules from a firewall template based on your requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletion of firewall rules does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplateRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplateRulesResponse
        /// </returns>
        public async Task<DeleteFirewallTemplateRulesResponse> DeleteFirewallTemplateRulesWithOptionsAsync(DeleteFirewallTemplateRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateRuleId))
            {
                query["FirewallTemplateRuleId"] = request.FirewallTemplateRuleId;
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
                Action = "DeleteFirewallTemplateRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallTemplateRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallTemplateRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall rules from a firewall template based on your requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletion of firewall rules does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplateRulesResponse
        /// </returns>
        public DeleteFirewallTemplateRulesResponse DeleteFirewallTemplateRules(DeleteFirewallTemplateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFirewallTemplateRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall rules from a firewall template based on your requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletion of firewall rules does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplateRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplateRulesResponse
        /// </returns>
        public async Task<DeleteFirewallTemplateRulesResponse> DeleteFirewallTemplateRulesAsync(DeleteFirewallTemplateRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFirewallTemplateRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall templates from a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a firewall template does not affect the firewall rules that have been applied to simple application servers. You can delete firewall templates that you no longer need.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplatesResponse
        /// </returns>
        public DeleteFirewallTemplatesResponse DeleteFirewallTemplatesWithOptions(DeleteFirewallTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
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
                Action = "DeleteFirewallTemplates",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallTemplatesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallTemplatesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall templates from a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a firewall template does not affect the firewall rules that have been applied to simple application servers. You can delete firewall templates that you no longer need.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplatesResponse
        /// </returns>
        public async Task<DeleteFirewallTemplatesResponse> DeleteFirewallTemplatesWithOptionsAsync(DeleteFirewallTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
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
                Action = "DeleteFirewallTemplates",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteFirewallTemplatesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFirewallTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall templates from a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a firewall template does not affect the firewall rules that have been applied to simple application servers. You can delete firewall templates that you no longer need.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplatesResponse
        /// </returns>
        public DeleteFirewallTemplatesResponse DeleteFirewallTemplates(DeleteFirewallTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFirewallTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes firewall templates from a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deleting a firewall template does not affect the firewall rules that have been applied to simple application servers. You can delete firewall templates that you no longer need.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteFirewallTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFirewallTemplatesResponse
        /// </returns>
        public async Task<DeleteFirewallTemplatesResponse> DeleteFirewallTemplatesAsync(DeleteFirewallTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFirewallTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceKeyPairResponse
        /// </returns>
        public DeleteInstanceKeyPairResponse DeleteInstanceKeyPairWithOptions(DeleteInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteInstanceKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteInstanceKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceKeyPairResponse
        /// </returns>
        public async Task<DeleteInstanceKeyPairResponse> DeleteInstanceKeyPairWithOptionsAsync(DeleteInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteInstanceKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteInstanceKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceKeyPairResponse
        /// </returns>
        public DeleteInstanceKeyPairResponse DeleteInstanceKeyPair(DeleteInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstanceKeyPairResponse
        /// </returns>
        public async Task<DeleteInstanceKeyPairResponse> DeleteInstanceKeyPairAsync(DeleteInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the SSH key pairs of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must unbind SSH key pairs that you no longer use from simple application servers before you delete the SSH key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public DeleteKeyPairsResponse DeleteKeyPairsWithOptions(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairNames))
            {
                query["KeyPairNames"] = request.KeyPairNames;
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
                Action = "DeleteKeyPairs",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteKeyPairsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteKeyPairsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the SSH key pairs of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must unbind SSH key pairs that you no longer use from simple application servers before you delete the SSH key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsWithOptionsAsync(DeleteKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairNames))
            {
                query["KeyPairNames"] = request.KeyPairNames;
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
                Action = "DeleteKeyPairs",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteKeyPairsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteKeyPairsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the SSH key pairs of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must unbind SSH key pairs that you no longer use from simple application servers before you delete the SSH key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public DeleteKeyPairsResponse DeleteKeyPairs(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteKeyPairsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the SSH key pairs of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must unbind SSH key pairs that you no longer use from simple application servers before you delete the SSH key pairs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteKeyPairsResponse
        /// </returns>
        public async Task<DeleteKeyPairsResponse> DeleteKeyPairsAsync(DeleteKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteKeyPairsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a snapshot if you no longer need it.</para>
        /// <remarks>
        /// <para> If a custom image was created from the snapshot, delete the custom image before you delete the snapshot.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteSnapshotResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSnapshotResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a snapshot if you no longer need it.</para>
        /// <remarks>
        /// <para> If a custom image was created from the snapshot, delete the custom image before you delete the snapshot.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteSnapshotResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSnapshotResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a snapshot if you no longer need it.</para>
        /// <remarks>
        /// <para> If a custom image was created from the snapshot, delete the custom image before you delete the snapshot.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a snapshot if you no longer need it.</para>
        /// <remarks>
        /// <para> If a custom image was created from the snapshot, delete the custom image before you delete the snapshot.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes snapshots of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotsResponse
        /// </returns>
        public DeleteSnapshotsResponse DeleteSnapshotsWithOptions(DeleteSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshots",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteSnapshotsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSnapshotsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes snapshots of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotsResponse
        /// </returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshotsWithOptionsAsync(DeleteSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshots",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DeleteSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSnapshotsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes snapshots of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotsResponse
        /// </returns>
        public DeleteSnapshotsResponse DeleteSnapshots(DeleteSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes snapshots of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotsResponse
        /// </returns>
        public async Task<DeleteSnapshotsResponse> DeleteSnapshotsAsync(DeleteSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Command Assistant information of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudAssistantAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantAttributesResponse
        /// </returns>
        public DescribeCloudAssistantAttributesResponse DescribeCloudAssistantAttributesWithOptions(DescribeCloudAssistantAttributesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudAssistantAttributesShrinkRequest request = new DescribeCloudAssistantAttributesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudAssistantAttributes",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCloudAssistantAttributesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCloudAssistantAttributesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Command Assistant information of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudAssistantAttributesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantAttributesResponse
        /// </returns>
        public async Task<DescribeCloudAssistantAttributesResponse> DescribeCloudAssistantAttributesWithOptionsAsync(DescribeCloudAssistantAttributesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudAssistantAttributesShrinkRequest request = new DescribeCloudAssistantAttributesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudAssistantAttributes",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCloudAssistantAttributesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCloudAssistantAttributesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Command Assistant information of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudAssistantAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantAttributesResponse
        /// </returns>
        public DescribeCloudAssistantAttributesResponse DescribeCloudAssistantAttributes(DescribeCloudAssistantAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudAssistantAttributesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Command Assistant information of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudAssistantAttributesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantAttributesResponse
        /// </returns>
        public async Task<DescribeCloudAssistantAttributesResponse> DescribeCloudAssistantAttributesAsync(DescribeCloudAssistantAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudAssistantAttributesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the Cloud Assistant client is installed on simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall the client. Otherwise, you cannot run commands on the servers.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudAssistantStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantStatusResponse
        /// </returns>
        public DescribeCloudAssistantStatusResponse DescribeCloudAssistantStatusWithOptions(DescribeCloudAssistantStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudAssistantStatusShrinkRequest request = new DescribeCloudAssistantStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudAssistantStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCloudAssistantStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCloudAssistantStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the Cloud Assistant client is installed on simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall the client. Otherwise, you cannot run commands on the servers.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeCloudAssistantStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantStatusResponse
        /// </returns>
        public async Task<DescribeCloudAssistantStatusResponse> DescribeCloudAssistantStatusWithOptionsAsync(DescribeCloudAssistantStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeCloudAssistantStatusShrinkRequest request = new DescribeCloudAssistantStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCloudAssistantStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCloudAssistantStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCloudAssistantStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the Cloud Assistant client is installed on simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall the client. Otherwise, you cannot run commands on the servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudAssistantStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantStatusResponse
        /// </returns>
        public DescribeCloudAssistantStatusResponse DescribeCloudAssistantStatus(DescribeCloudAssistantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudAssistantStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether the Cloud Assistant client is installed on simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall the client. Otherwise, you cannot run commands on the servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCloudAssistantStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudAssistantStatusResponse
        /// </returns>
        public async Task<DescribeCloudAssistantStatusResponse> DescribeCloudAssistantStatusAsync(DescribeCloudAssistantStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudAssistantStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the CloudMonitor agent on simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudMonitorAgentStatusesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudMonitorAgentStatusesResponse
        /// </returns>
        public DescribeCloudMonitorAgentStatusesResponse DescribeCloudMonitorAgentStatusesWithOptions(DescribeCloudMonitorAgentStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "DescribeCloudMonitorAgentStatuses",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCloudMonitorAgentStatusesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCloudMonitorAgentStatusesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the CloudMonitor agent on simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudMonitorAgentStatusesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudMonitorAgentStatusesResponse
        /// </returns>
        public async Task<DescribeCloudMonitorAgentStatusesResponse> DescribeCloudMonitorAgentStatusesWithOptionsAsync(DescribeCloudMonitorAgentStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "DescribeCloudMonitorAgentStatuses",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCloudMonitorAgentStatusesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCloudMonitorAgentStatusesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the CloudMonitor agent on simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudMonitorAgentStatusesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudMonitorAgentStatusesResponse
        /// </returns>
        public DescribeCloudMonitorAgentStatusesResponse DescribeCloudMonitorAgentStatuses(DescribeCloudMonitorAgentStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCloudMonitorAgentStatusesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the CloudMonitor agent on simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCloudMonitorAgentStatusesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCloudMonitorAgentStatusesResponse
        /// </returns>
        public async Task<DescribeCloudMonitorAgentStatusesResponse> DescribeCloudMonitorAgentStatusesAsync(DescribeCloudMonitorAgentStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCloudMonitorAgentStatusesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the executions and execution status of a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandInvocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandInvocationsResponse
        /// </returns>
        public DescribeCommandInvocationsResponse DescribeCommandInvocationsWithOptions(DescribeCommandInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandName))
            {
                query["CommandName"] = request.CommandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandType))
            {
                query["CommandType"] = request.CommandType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationStatus))
            {
                query["InvocationStatus"] = request.InvocationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommandInvocations",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCommandInvocationsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCommandInvocationsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the executions and execution status of a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandInvocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandInvocationsResponse
        /// </returns>
        public async Task<DescribeCommandInvocationsResponse> DescribeCommandInvocationsWithOptionsAsync(DescribeCommandInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandName))
            {
                query["CommandName"] = request.CommandName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandType))
            {
                query["CommandType"] = request.CommandType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvocationStatus))
            {
                query["InvocationStatus"] = request.InvocationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommandInvocations",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCommandInvocationsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCommandInvocationsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the executions and execution status of a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandInvocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandInvocationsResponse
        /// </returns>
        public DescribeCommandInvocationsResponse DescribeCommandInvocations(DescribeCommandInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommandInvocationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the executions and execution status of a Cloud Assistant command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandInvocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandInvocationsResponse
        /// </returns>
        public async Task<DescribeCommandInvocationsResponse> DescribeCommandInvocationsAsync(DescribeCommandInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommandInvocationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that you created or the common commands that Alibaba Cloud provides.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandsResponse
        /// </returns>
        public DescribeCommandsResponse DescribeCommandsWithOptions(DescribeCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommands",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCommandsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCommandsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that you created or the common commands that Alibaba Cloud provides.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandsResponse
        /// </returns>
        public async Task<DescribeCommandsResponse> DescribeCommandsWithOptionsAsync(DescribeCommandsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommands",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeCommandsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeCommandsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that you created or the common commands that Alibaba Cloud provides.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandsResponse
        /// </returns>
        public DescribeCommandsResponse DescribeCommands(DescribeCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommandsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the commands that you created or the common commands that Alibaba Cloud provides.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommandsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommandsResponse
        /// </returns>
        public async Task<DescribeCommandsResponse> DescribeCommandsAsync(DescribeCommandsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommandsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries error logs of databases in a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the error logs of databases in a Simple Database Service instance and locate faults based on the error logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseErrorLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseErrorLogsResponse
        /// </returns>
        public DescribeDatabaseErrorLogsResponse DescribeDatabaseErrorLogsWithOptions(DescribeDatabaseErrorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDatabaseErrorLogs",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseErrorLogsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseErrorLogsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries error logs of databases in a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the error logs of databases in a Simple Database Service instance and locate faults based on the error logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseErrorLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseErrorLogsResponse
        /// </returns>
        public async Task<DescribeDatabaseErrorLogsResponse> DescribeDatabaseErrorLogsWithOptionsAsync(DescribeDatabaseErrorLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDatabaseErrorLogs",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseErrorLogsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseErrorLogsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries error logs of databases in a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the error logs of databases in a Simple Database Service instance and locate faults based on the error logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseErrorLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseErrorLogsResponse
        /// </returns>
        public DescribeDatabaseErrorLogsResponse DescribeDatabaseErrorLogs(DescribeDatabaseErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabaseErrorLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries error logs of databases in a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the error logs of databases in a Simple Database Service instance and locate faults based on the error logs.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseErrorLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseErrorLogsResponse
        /// </returns>
        public async Task<DescribeDatabaseErrorLogsResponse> DescribeDatabaseErrorLogsAsync(DescribeDatabaseErrorLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabaseErrorLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can query the details about the instance, including CPU, memory, and disk usage, storage IOPS, and total number of connections.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceMetricDataResponse
        /// </returns>
        public DescribeDatabaseInstanceMetricDataResponse DescribeDatabaseInstanceMetricDataWithOptions(DescribeDatabaseInstanceMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDatabaseInstanceMetricData",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceMetricDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceMetricDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can query the details about the instance, including CPU, memory, and disk usage, storage IOPS, and total number of connections.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceMetricDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceMetricDataResponse
        /// </returns>
        public async Task<DescribeDatabaseInstanceMetricDataResponse> DescribeDatabaseInstanceMetricDataWithOptionsAsync(DescribeDatabaseInstanceMetricDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeDatabaseInstanceMetricData",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceMetricDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceMetricDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can query the details about the instance, including CPU, memory, and disk usage, storage IOPS, and total number of connections.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceMetricDataResponse
        /// </returns>
        public DescribeDatabaseInstanceMetricDataResponse DescribeDatabaseInstanceMetricData(DescribeDatabaseInstanceMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabaseInstanceMetricDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can query the details about the instance, including CPU, memory, and disk usage, storage IOPS, and total number of connections.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceMetricDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceMetricDataResponse
        /// </returns>
        public async Task<DescribeDatabaseInstanceMetricDataResponse> DescribeDatabaseInstanceMetricDataAsync(DescribeDatabaseInstanceMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabaseInstanceMetricDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the information about parameters of a Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceParametersResponse
        /// </returns>
        public DescribeDatabaseInstanceParametersResponse DescribeDatabaseInstanceParametersWithOptions(DescribeDatabaseInstanceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "DescribeDatabaseInstanceParameters",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceParametersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceParametersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the information about parameters of a Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceParametersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceParametersResponse
        /// </returns>
        public async Task<DescribeDatabaseInstanceParametersResponse> DescribeDatabaseInstanceParametersWithOptionsAsync(DescribeDatabaseInstanceParametersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "DescribeDatabaseInstanceParameters",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceParametersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseInstanceParametersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the information about parameters of a Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceParametersResponse
        /// </returns>
        public DescribeDatabaseInstanceParametersResponse DescribeDatabaseInstanceParameters(DescribeDatabaseInstanceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabaseInstanceParametersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the parameters of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the information about parameters of a Simple Database Service instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstanceParametersRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstanceParametersResponse
        /// </returns>
        public async Task<DescribeDatabaseInstanceParametersResponse> DescribeDatabaseInstanceParametersAsync(DescribeDatabaseInstanceParametersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabaseInstanceParametersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Simple Database Service instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of Simple Database Service instances in a region, including the IDs, names, plans, database versions, public endpoints, internal endpoints, creation time, and expiration time of the instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstancesResponse
        /// </returns>
        public DescribeDatabaseInstancesResponse DescribeDatabaseInstancesWithOptions(DescribeDatabaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceIds))
            {
                query["DatabaseInstanceIds"] = request.DatabaseInstanceIds;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDatabaseInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Simple Database Service instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of Simple Database Service instances in a region, including the IDs, names, plans, database versions, public endpoints, internal endpoints, creation time, and expiration time of the instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstancesResponse
        /// </returns>
        public async Task<DescribeDatabaseInstancesResponse> DescribeDatabaseInstancesWithOptionsAsync(DescribeDatabaseInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceIds))
            {
                query["DatabaseInstanceIds"] = request.DatabaseInstanceIds;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDatabaseInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Simple Database Service instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of Simple Database Service instances in a region, including the IDs, names, plans, database versions, public endpoints, internal endpoints, creation time, and expiration time of the instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstancesResponse
        /// </returns>
        public DescribeDatabaseInstancesResponse DescribeDatabaseInstances(DescribeDatabaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabaseInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Simple Database Service instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of Simple Database Service instances in a region, including the IDs, names, plans, database versions, public endpoints, internal endpoints, creation time, and expiration time of the instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseInstancesResponse
        /// </returns>
        public async Task<DescribeDatabaseInstancesResponse> DescribeDatabaseInstancesAsync(DescribeDatabaseInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabaseInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the slow query log details of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the slow query log details of a Simple Database Service instance and locate faults based on the log details.</para>
        /// <remarks>
        /// <para> Slow query log details are retained for 7 days.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseSlowLogRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseSlowLogRecordsResponse
        /// </returns>
        public DescribeDatabaseSlowLogRecordsResponse DescribeDatabaseSlowLogRecordsWithOptions(DescribeDatabaseSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDatabaseSlowLogRecords",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseSlowLogRecordsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseSlowLogRecordsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the slow query log details of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the slow query log details of a Simple Database Service instance and locate faults based on the log details.</para>
        /// <remarks>
        /// <para> Slow query log details are retained for 7 days.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseSlowLogRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseSlowLogRecordsResponse
        /// </returns>
        public async Task<DescribeDatabaseSlowLogRecordsResponse> DescribeDatabaseSlowLogRecordsWithOptionsAsync(DescribeDatabaseSlowLogRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
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
                Action = "DescribeDatabaseSlowLogRecords",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeDatabaseSlowLogRecordsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeDatabaseSlowLogRecordsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the slow query log details of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the slow query log details of a Simple Database Service instance and locate faults based on the log details.</para>
        /// <remarks>
        /// <para> Slow query log details are retained for 7 days.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseSlowLogRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseSlowLogRecordsResponse
        /// </returns>
        public DescribeDatabaseSlowLogRecordsResponse DescribeDatabaseSlowLogRecords(DescribeDatabaseSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDatabaseSlowLogRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the slow query log details of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the slow query log details of a Simple Database Service instance and locate faults based on the log details.</para>
        /// <remarks>
        /// <para> Slow query log details are retained for 7 days.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDatabaseSlowLogRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDatabaseSlowLogRecordsResponse
        /// </returns>
        public async Task<DescribeDatabaseSlowLogRecordsResponse> DescribeDatabaseSlowLogRecordsAsync(DescribeDatabaseSlowLogRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDatabaseSlowLogRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateApplyResultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateApplyResultsResponse
        /// </returns>
        public DescribeFirewallTemplateApplyResultsResponse DescribeFirewallTemplateApplyResultsWithOptions(DescribeFirewallTemplateApplyResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
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
                Action = "DescribeFirewallTemplateApplyResults",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeFirewallTemplateApplyResultsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeFirewallTemplateApplyResultsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateApplyResultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateApplyResultsResponse
        /// </returns>
        public async Task<DescribeFirewallTemplateApplyResultsResponse> DescribeFirewallTemplateApplyResultsWithOptionsAsync(DescribeFirewallTemplateApplyResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
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
                Action = "DescribeFirewallTemplateApplyResults",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeFirewallTemplateApplyResultsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeFirewallTemplateApplyResultsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateApplyResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateApplyResultsResponse
        /// </returns>
        public DescribeFirewallTemplateApplyResultsResponse DescribeFirewallTemplateApplyResults(DescribeFirewallTemplateApplyResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFirewallTemplateApplyResultsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateApplyResultsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateApplyResultsResponse
        /// </returns>
        public async Task<DescribeFirewallTemplateApplyResultsResponse> DescribeFirewallTemplateApplyResultsAsync(DescribeFirewallTemplateApplyResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFirewallTemplateApplyResultsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateRulesApplyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateRulesApplyResultResponse
        /// </returns>
        public DescribeFirewallTemplateRulesApplyResultResponse DescribeFirewallTemplateRulesApplyResultWithOptions(DescribeFirewallTemplateRulesApplyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeFirewallTemplateRulesApplyResult",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeFirewallTemplateRulesApplyResultResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeFirewallTemplateRulesApplyResultResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateRulesApplyResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateRulesApplyResultResponse
        /// </returns>
        public async Task<DescribeFirewallTemplateRulesApplyResultResponse> DescribeFirewallTemplateRulesApplyResultWithOptionsAsync(DescribeFirewallTemplateRulesApplyResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeFirewallTemplateRulesApplyResult",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeFirewallTemplateRulesApplyResultResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeFirewallTemplateRulesApplyResultResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateRulesApplyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateRulesApplyResultResponse
        /// </returns>
        public DescribeFirewallTemplateRulesApplyResultResponse DescribeFirewallTemplateRulesApplyResult(DescribeFirewallTemplateRulesApplyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFirewallTemplateRulesApplyResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the result of applying a firewall template rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplateRulesApplyResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplateRulesApplyResultResponse
        /// </returns>
        public async Task<DescribeFirewallTemplateRulesApplyResultResponse> DescribeFirewallTemplateRulesApplyResultAsync(DescribeFirewallTemplateRulesApplyResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFirewallTemplateRulesApplyResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about firewall templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplatesResponse
        /// </returns>
        public DescribeFirewallTemplatesResponse DescribeFirewallTemplatesWithOptions(DescribeFirewallTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFirewallTemplates",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeFirewallTemplatesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeFirewallTemplatesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about firewall templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplatesResponse
        /// </returns>
        public async Task<DescribeFirewallTemplatesResponse> DescribeFirewallTemplatesWithOptionsAsync(DescribeFirewallTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFirewallTemplates",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeFirewallTemplatesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeFirewallTemplatesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about firewall templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplatesResponse
        /// </returns>
        public DescribeFirewallTemplatesResponse DescribeFirewallTemplates(DescribeFirewallTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFirewallTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about firewall templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFirewallTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFirewallTemplatesResponse
        /// </returns>
        public async Task<DescribeFirewallTemplatesResponse> DescribeFirewallTemplatesAsync(DescribeFirewallTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFirewallTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceKeyPairResponse
        /// </returns>
        public DescribeInstanceKeyPairResponse DescribeInstanceKeyPairWithOptions(DescribeInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceKeyPairResponse
        /// </returns>
        public async Task<DescribeInstanceKeyPairResponse> DescribeInstanceKeyPairWithOptionsAsync(DescribeInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceKeyPairResponse
        /// </returns>
        public DescribeInstanceKeyPairResponse DescribeInstanceKeyPair(DescribeInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the key pair of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceKeyPairResponse
        /// </returns>
        public async Task<DescribeInstanceKeyPairResponse> DescribeInstanceKeyPairAsync(DescribeInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a password is set for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancePasswordsSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancePasswordsSettingResponse
        /// </returns>
        public DescribeInstancePasswordsSettingResponse DescribeInstancePasswordsSettingWithOptions(DescribeInstancePasswordsSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeInstancePasswordsSetting",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstancePasswordsSettingResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstancePasswordsSettingResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a password is set for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancePasswordsSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancePasswordsSettingResponse
        /// </returns>
        public async Task<DescribeInstancePasswordsSettingResponse> DescribeInstancePasswordsSettingWithOptionsAsync(DescribeInstancePasswordsSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeInstancePasswordsSetting",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstancePasswordsSettingResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstancePasswordsSettingResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a password is set for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancePasswordsSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancePasswordsSettingResponse
        /// </returns>
        public DescribeInstancePasswordsSettingResponse DescribeInstancePasswordsSetting(DescribeInstancePasswordsSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstancePasswordsSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether a password is set for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstancePasswordsSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstancePasswordsSettingResponse
        /// </returns>
        public async Task<DescribeInstancePasswordsSettingResponse> DescribeInstancePasswordsSettingAsync(DescribeInstancePasswordsSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstancePasswordsSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the VNC connection address of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceVncUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceVncUrlResponse
        /// </returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrlWithOptions(DescribeInstanceVncUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeInstanceVncUrl",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the VNC connection address of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceVncUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceVncUrlResponse
        /// </returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrlWithOptionsAsync(DescribeInstanceVncUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeInstanceVncUrl",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInstanceVncUrlResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the VNC connection address of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceVncUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceVncUrlResponse
        /// </returns>
        public DescribeInstanceVncUrlResponse DescribeInstanceVncUrl(DescribeInstanceVncUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceVncUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the VNC connection address of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceVncUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceVncUrlResponse
        /// </returns>
        public async Task<DescribeInstanceVncUrlResponse> DescribeInstanceVncUrlAsync(DescribeInstanceVncUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceVncUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution result of a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the execution result of a command.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. A maximum of 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationResultResponse
        /// </returns>
        public DescribeInvocationResultResponse DescribeInvocationResultWithOptions(DescribeInvocationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
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
                Action = "DescribeInvocationResult",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInvocationResultResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInvocationResultResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution result of a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the execution result of a command.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. A maximum of 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationResultResponse
        /// </returns>
        public async Task<DescribeInvocationResultResponse> DescribeInvocationResultWithOptionsAsync(DescribeInvocationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeId))
            {
                query["InvokeId"] = request.InvokeId;
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
                Action = "DescribeInvocationResult",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInvocationResultResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInvocationResultResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution result of a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the execution result of a command.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. A maximum of 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationResultResponse
        /// </returns>
        public DescribeInvocationResultResponse DescribeInvocationResult(DescribeInvocationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the execution result of a command.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the execution result of a command.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. A maximum of 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationResultResponse
        /// </returns>
        public async Task<DescribeInvocationResultResponse> DescribeInvocationResultAsync(DescribeInvocationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about command execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the actual execution results.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. Up to 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public DescribeInvocationsResponse DescribeInvocationsWithOptions(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeStatus))
            {
                query["InvokeStatus"] = request.InvokeStatus;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvocations",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInvocationsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInvocationsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about command execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the actual execution results.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. Up to 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public async Task<DescribeInvocationsResponse> DescribeInvocationsWithOptionsAsync(DescribeInvocationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InvokeStatus))
            {
                query["InvokeStatus"] = request.InvokeStatus;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInvocations",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeInvocationsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeInvocationsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about command execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the actual execution results.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. Up to 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public DescribeInvocationsResponse DescribeInvocations(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInvocationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about command execution.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After you execute a command, the command may not succeed or return the expected results. You can call this operation to query the actual execution results.</para>
        /// <list type="bullet">
        /// <item><description>You can query the execution results that were generated within the last two weeks. Up to 100,000 entries of execution results can be retained.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInvocationsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInvocationsResponse
        /// </returns>
        public async Task<DescribeInvocationsResponse> DescribeInvocationsAsync(DescribeInvocationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInvocationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about vCPUs, memory, disk IOPS, and traffic of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMonitorDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public DescribeMonitorDataResponse DescribeMonitorDataWithOptions(DescribeMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeMonitorData",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeMonitorDataResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeMonitorDataResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about vCPUs, memory, disk IOPS, and traffic of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMonitorDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public async Task<DescribeMonitorDataResponse> DescribeMonitorDataWithOptionsAsync(DescribeMonitorDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Length))
            {
                query["Length"] = request.Length;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricName))
            {
                query["MetricName"] = request.MetricName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeMonitorData",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeMonitorDataResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeMonitorDataResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about vCPUs, memory, disk IOPS, and traffic of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMonitorDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public DescribeMonitorDataResponse DescribeMonitorData(DescribeMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring information about vCPUs, memory, disk IOPS, and traffic of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMonitorDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public async Task<DescribeMonitorDataResponse> DescribeMonitorDataAsync(DescribeMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Security Center agent on a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityAgentStatusResponse
        /// </returns>
        public DescribeSecurityAgentStatusResponse DescribeSecurityAgentStatusWithOptions(DescribeSecurityAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeSecurityAgentStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSecurityAgentStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSecurityAgentStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Security Center agent on a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityAgentStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityAgentStatusResponse
        /// </returns>
        public async Task<DescribeSecurityAgentStatusResponse> DescribeSecurityAgentStatusWithOptionsAsync(DescribeSecurityAgentStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeSecurityAgentStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DescribeSecurityAgentStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DescribeSecurityAgentStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Security Center agent on a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityAgentStatusResponse
        /// </returns>
        public DescribeSecurityAgentStatusResponse DescribeSecurityAgentStatus(DescribeSecurityAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSecurityAgentStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Security Center agent on a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecurityAgentStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecurityAgentStatusResponse
        /// </returns>
        public async Task<DescribeSecurityAgentStatusResponse> DescribeSecurityAgentStatusAsync(DescribeSecurityAgentStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSecurityAgentStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds key pairs from simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to change the SSH key pairs that are bound to your simple application servers or your end user no longer needs to access a specific simple application server, you can unbind the SSH key pairs from simple application servers to improve the security of the simple application servers or restrict access to the specific simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public DetachKeyPairResponse DetachKeyPairWithOptions(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "DetachKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DetachKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DetachKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds key pairs from simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to change the SSH key pairs that are bound to your simple application servers or your end user no longer needs to access a specific simple application server, you can unbind the SSH key pairs from simple application servers to improve the security of the simple application servers or restrict access to the specific simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public async Task<DetachKeyPairResponse> DetachKeyPairWithOptionsAsync(DetachKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
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
                Action = "DetachKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DetachKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DetachKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds key pairs from simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to change the SSH key pairs that are bound to your simple application servers or your end user no longer needs to access a specific simple application server, you can unbind the SSH key pairs from simple application servers to improve the security of the simple application servers or restrict access to the specific simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public DetachKeyPairResponse DetachKeyPair(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds key pairs from simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to change the SSH key pairs that are bound to your simple application servers or your end user no longer needs to access a specific simple application server, you can unbind the SSH key pairs from simple application servers to improve the security of the simple application servers or restrict access to the specific simple application server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachKeyPairResponse
        /// </returns>
        public async Task<DetachKeyPairResponse> DetachKeyPairAsync(DetachKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableFirewallRuleResponse
        /// </returns>
        public DisableFirewallRuleResponse DisableFirewallRuleWithOptions(DisableFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "DisableFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableFirewallRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableFirewallRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableFirewallRuleResponse
        /// </returns>
        public async Task<DisableFirewallRuleResponse> DisableFirewallRuleWithOptionsAsync(DisableFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "DisableFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<DisableFirewallRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableFirewallRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableFirewallRuleResponse
        /// </returns>
        public DisableFirewallRuleResponse DisableFirewallRule(DisableFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableFirewallRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableFirewallRuleResponse
        /// </returns>
        public async Task<DisableFirewallRuleResponse> DisableFirewallRuleAsync(DisableFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableFirewallRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableFirewallRuleResponse
        /// </returns>
        public EnableFirewallRuleResponse EnableFirewallRuleWithOptions(EnableFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableFirewallRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableFirewallRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableFirewallRuleResponse
        /// </returns>
        public async Task<EnableFirewallRuleResponse> EnableFirewallRuleWithOptionsAsync(EnableFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<EnableFirewallRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableFirewallRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableFirewallRuleResponse
        /// </returns>
        public EnableFirewallRuleResponse EnableFirewallRule(EnableFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableFirewallRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a firewall rule for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableFirewallRuleResponse
        /// </returns>
        public async Task<EnableFirewallRuleResponse> EnableFirewallRuleAsync(EnableFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableFirewallRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports an existing key pair to the Simple Application Server console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to import an existing key pair to the Simple Application Server console. This way, you can use the key pair to log on to simple application servers. The existing key pair that you want to import must use a supported encryption method. For more information, see <a href="https://help.aliyun.com/document_detail/59085.html">Q2: Which encryption methods must be used by key pairs when I import existing key pairs to the Simple Application Server console?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public ImportKeyPairResponse ImportKeyPairWithOptions(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBody))
            {
                query["PublicKeyBody"] = request.PublicKeyBody;
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
                Action = "ImportKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports an existing key pair to the Simple Application Server console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to import an existing key pair to the Simple Application Server console. This way, you can use the key pair to log on to simple application servers. The existing key pair that you want to import must use a supported encryption method. For more information, see <a href="https://help.aliyun.com/document_detail/59085.html">Q2: Which encryption methods must be used by key pairs when I import existing key pairs to the Simple Application Server console?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public async Task<ImportKeyPairResponse> ImportKeyPairWithOptionsAsync(ImportKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKeyBody))
            {
                query["PublicKeyBody"] = request.PublicKeyBody;
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
                Action = "ImportKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ImportKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ImportKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports an existing key pair to the Simple Application Server console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to import an existing key pair to the Simple Application Server console. This way, you can use the key pair to log on to simple application servers. The existing key pair that you want to import must use a supported encryption method. For more information, see <a href="https://help.aliyun.com/document_detail/59085.html">Q2: Which encryption methods must be used by key pairs when I import existing key pairs to the Simple Application Server console?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports an existing key pair to the Simple Application Server console.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to import an existing key pair to the Simple Application Server console. This way, you can use the key pair to log on to simple application servers. The existing key pair that you want to import must use a supported encryption method. For more information, see <a href="https://help.aliyun.com/document_detail/59085.html">Q2: Which encryption methods must be used by key pairs when I import existing key pairs to the Simple Application Server console?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ImportKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// ImportKeyPairResponse
        /// </returns>
        public async Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportKeyPairWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the Cloud Assistant client on simple application servers at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To run commands on your simple application servers, you must install the Cloud Assistant client on your servers. You can call the <a href="https://help.aliyun.com/document_detail/439512.html">DescribeCloudAssistantStatus</a> operation to check whether the Cloud Assistant client is installed on your simple application servers. If you have not installed the Cloud Assistant client, you can call the InstallCloudAssistant operation to install the client. Then, you can call the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation to restart the servers to allow the client to take effect.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallCloudAssistantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudAssistantResponse
        /// </returns>
        public InstallCloudAssistantResponse InstallCloudAssistantWithOptions(InstallCloudAssistantRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallCloudAssistantShrinkRequest request = new InstallCloudAssistantShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
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
                Action = "InstallCloudAssistant",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InstallCloudAssistantResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InstallCloudAssistantResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the Cloud Assistant client on simple application servers at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To run commands on your simple application servers, you must install the Cloud Assistant client on your servers. You can call the <a href="https://help.aliyun.com/document_detail/439512.html">DescribeCloudAssistantStatus</a> operation to check whether the Cloud Assistant client is installed on your simple application servers. If you have not installed the Cloud Assistant client, you can call the InstallCloudAssistant operation to install the client. Then, you can call the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation to restart the servers to allow the client to take effect.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallCloudAssistantRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudAssistantResponse
        /// </returns>
        public async Task<InstallCloudAssistantResponse> InstallCloudAssistantWithOptionsAsync(InstallCloudAssistantRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallCloudAssistantShrinkRequest request = new InstallCloudAssistantShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
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
                Action = "InstallCloudAssistant",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InstallCloudAssistantResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InstallCloudAssistantResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the Cloud Assistant client on simple application servers at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To run commands on your simple application servers, you must install the Cloud Assistant client on your servers. You can call the <a href="https://help.aliyun.com/document_detail/439512.html">DescribeCloudAssistantStatus</a> operation to check whether the Cloud Assistant client is installed on your simple application servers. If you have not installed the Cloud Assistant client, you can call the InstallCloudAssistant operation to install the client. Then, you can call the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation to restart the servers to allow the client to take effect.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallCloudAssistantRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudAssistantResponse
        /// </returns>
        public InstallCloudAssistantResponse InstallCloudAssistant(InstallCloudAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallCloudAssistantWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the Cloud Assistant client on simple application servers at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To run commands on your simple application servers, you must install the Cloud Assistant client on your servers. You can call the <a href="https://help.aliyun.com/document_detail/439512.html">DescribeCloudAssistantStatus</a> operation to check whether the Cloud Assistant client is installed on your simple application servers. If you have not installed the Cloud Assistant client, you can call the InstallCloudAssistant operation to install the client. Then, you can call the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation to restart the servers to allow the client to take effect.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallCloudAssistantRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudAssistantResponse
        /// </returns>
        public async Task<InstallCloudAssistantResponse> InstallCloudAssistantAsync(InstallCloudAssistantRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallCloudAssistantWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the CloudMonitor agent for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCloudMonitorAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudMonitorAgentResponse
        /// </returns>
        public InstallCloudMonitorAgentResponse InstallCloudMonitorAgentWithOptions(InstallCloudMonitorAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "InstallCloudMonitorAgent",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InstallCloudMonitorAgentResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InstallCloudMonitorAgentResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the CloudMonitor agent for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCloudMonitorAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudMonitorAgentResponse
        /// </returns>
        public async Task<InstallCloudMonitorAgentResponse> InstallCloudMonitorAgentWithOptionsAsync(InstallCloudMonitorAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "InstallCloudMonitorAgent",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InstallCloudMonitorAgentResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InstallCloudMonitorAgentResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the CloudMonitor agent for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCloudMonitorAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudMonitorAgentResponse
        /// </returns>
        public InstallCloudMonitorAgentResponse InstallCloudMonitorAgent(InstallCloudMonitorAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallCloudMonitorAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs the CloudMonitor agent for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// InstallCloudMonitorAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallCloudMonitorAgentResponse
        /// </returns>
        public async Task<InstallCloudMonitorAgentResponse> InstallCloudMonitorAgentAsync(InstallCloudMonitorAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallCloudMonitorAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a Command Assistant command for one or more simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The simple application servers for which you want to call the operation must meet the following conditions. If a simple application server cannot meet the conditions, you must call this operation again.
        ///     *   The simple application servers are in the <c>Running</c> state. You can call the <a href="https://help.aliyun.com/document_detail/2361065.html">ListInstances</a> operation to query the status of simple application servers.
        ///     *   Cloud Assistant Agent is installed on the simple application servers. For more information, see <a href="https://help.aliyun.com/document_detail/2361030.html">InstallCloudAssistant</a>.
        ///     *   If you run a PowerShell command, make sure that the PowerShell module is configured for the simple application servers.</para>
        /// <list type="bullet">
        /// <item><description>The command may fail to be run due to the abnormal states of simple application servers, network exceptions, or exceptions in Cloud Assistant Agent. If the command fails to be run, no execution information is generated.</description></item>
        /// <item><description>If you enable the custom parameter feature when you create a command, you must set the <c>Parameters</c> parameter to specify custom parameters when you run the command.</description></item>
        /// <item><description>When you call this operation, you can select only one common command or a custom command that you have created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InvokeCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeCommandResponse
        /// </returns>
        public InvokeCommandResponse InvokeCommandWithOptions(InvokeCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvokeCommandShrinkRequest request = new InvokeCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InvokeCommandResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InvokeCommandResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a Command Assistant command for one or more simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The simple application servers for which you want to call the operation must meet the following conditions. If a simple application server cannot meet the conditions, you must call this operation again.
        ///     *   The simple application servers are in the <c>Running</c> state. You can call the <a href="https://help.aliyun.com/document_detail/2361065.html">ListInstances</a> operation to query the status of simple application servers.
        ///     *   Cloud Assistant Agent is installed on the simple application servers. For more information, see <a href="https://help.aliyun.com/document_detail/2361030.html">InstallCloudAssistant</a>.
        ///     *   If you run a PowerShell command, make sure that the PowerShell module is configured for the simple application servers.</para>
        /// <list type="bullet">
        /// <item><description>The command may fail to be run due to the abnormal states of simple application servers, network exceptions, or exceptions in Cloud Assistant Agent. If the command fails to be run, no execution information is generated.</description></item>
        /// <item><description>If you enable the custom parameter feature when you create a command, you must set the <c>Parameters</c> parameter to specify custom parameters when you run the command.</description></item>
        /// <item><description>When you call this operation, you can select only one common command or a custom command that you have created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InvokeCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InvokeCommandResponse
        /// </returns>
        public async Task<InvokeCommandResponse> InvokeCommandWithOptionsAsync(InvokeCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InvokeCommandShrinkRequest request = new InvokeCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InvokeCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<InvokeCommandResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<InvokeCommandResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a Command Assistant command for one or more simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The simple application servers for which you want to call the operation must meet the following conditions. If a simple application server cannot meet the conditions, you must call this operation again.
        ///     *   The simple application servers are in the <c>Running</c> state. You can call the <a href="https://help.aliyun.com/document_detail/2361065.html">ListInstances</a> operation to query the status of simple application servers.
        ///     *   Cloud Assistant Agent is installed on the simple application servers. For more information, see <a href="https://help.aliyun.com/document_detail/2361030.html">InstallCloudAssistant</a>.
        ///     *   If you run a PowerShell command, make sure that the PowerShell module is configured for the simple application servers.</para>
        /// <list type="bullet">
        /// <item><description>The command may fail to be run due to the abnormal states of simple application servers, network exceptions, or exceptions in Cloud Assistant Agent. If the command fails to be run, no execution information is generated.</description></item>
        /// <item><description>If you enable the custom parameter feature when you create a command, you must set the <c>Parameters</c> parameter to specify custom parameters when you run the command.</description></item>
        /// <item><description>When you call this operation, you can select only one common command or a custom command that you have created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeCommandResponse
        /// </returns>
        public InvokeCommandResponse InvokeCommand(InvokeCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeCommandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs a Command Assistant command for one or more simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The simple application servers for which you want to call the operation must meet the following conditions. If a simple application server cannot meet the conditions, you must call this operation again.
        ///     *   The simple application servers are in the <c>Running</c> state. You can call the <a href="https://help.aliyun.com/document_detail/2361065.html">ListInstances</a> operation to query the status of simple application servers.
        ///     *   Cloud Assistant Agent is installed on the simple application servers. For more information, see <a href="https://help.aliyun.com/document_detail/2361030.html">InstallCloudAssistant</a>.
        ///     *   If you run a PowerShell command, make sure that the PowerShell module is configured for the simple application servers.</para>
        /// <list type="bullet">
        /// <item><description>The command may fail to be run due to the abnormal states of simple application servers, network exceptions, or exceptions in Cloud Assistant Agent. If the command fails to be run, no execution information is generated.</description></item>
        /// <item><description>If you enable the custom parameter feature when you create a command, you must set the <c>Parameters</c> parameter to specify custom parameters when you run the command.</description></item>
        /// <item><description>When you call this operation, you can select only one common command or a custom command that you have created.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InvokeCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// InvokeCommandResponse
        /// </returns>
        public async Task<InvokeCommandResponse> InvokeCommandAsync(InvokeCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about custom images that are shared across Alibaba Cloud accounts in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImageShareAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImageShareAccountsResponse
        /// </returns>
        public ListCustomImageShareAccountsResponse ListCustomImageShareAccountsWithOptions(ListCustomImageShareAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomImageShareAccounts",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCustomImageShareAccountsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCustomImageShareAccountsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about custom images that are shared across Alibaba Cloud accounts in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImageShareAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImageShareAccountsResponse
        /// </returns>
        public async Task<ListCustomImageShareAccountsResponse> ListCustomImageShareAccountsWithOptionsAsync(ListCustomImageShareAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomImageShareAccounts",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCustomImageShareAccountsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCustomImageShareAccountsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about custom images that are shared across Alibaba Cloud accounts in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImageShareAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImageShareAccountsResponse
        /// </returns>
        public ListCustomImageShareAccountsResponse ListCustomImageShareAccounts(ListCustomImageShareAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomImageShareAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about custom images that are shared across Alibaba Cloud accounts in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImageShareAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImageShareAccountsResponse
        /// </returns>
        public async Task<ListCustomImageShareAccountsResponse> ListCustomImageShareAccountsAsync(ListCustomImageShareAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomImageShareAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom images in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImagesResponse
        /// </returns>
        public ListCustomImagesResponse ListCustomImagesWithOptions(ListCustomImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSnapshotId))
            {
                query["DataSnapshotId"] = request.DataSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNames))
            {
                query["ImageNames"] = request.ImageNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Share))
            {
                query["Share"] = request.Share;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemSnapshotId))
            {
                query["SystemSnapshotId"] = request.SystemSnapshotId;
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
                Action = "ListCustomImages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCustomImagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCustomImagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom images in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImagesResponse
        /// </returns>
        public async Task<ListCustomImagesResponse> ListCustomImagesWithOptionsAsync(ListCustomImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSnapshotId))
            {
                query["DataSnapshotId"] = request.DataSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageNames))
            {
                query["ImageNames"] = request.ImageNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Share))
            {
                query["Share"] = request.Share;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemSnapshotId))
            {
                query["SystemSnapshotId"] = request.SystemSnapshotId;
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
                Action = "ListCustomImages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListCustomImagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListCustomImagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom images in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImagesResponse
        /// </returns>
        public ListCustomImagesResponse ListCustomImages(ListCustomImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about custom images in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomImagesResponse
        /// </returns>
        public async Task<ListCustomImagesResponse> ListCustomImagesAsync(ListCustomImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about disks in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter disks that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDisksResponse
        /// </returns>
        public ListDisksResponse ListDisksWithOptions(ListDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListDisks",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListDisksResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListDisksResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about disks in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter disks that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDisksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDisksResponse
        /// </returns>
        public async Task<ListDisksResponse> ListDisksWithOptionsAsync(ListDisksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskIds))
            {
                query["DiskIds"] = request.DiskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListDisks",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListDisksResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListDisksResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about disks in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter disks that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDisksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDisksResponse
        /// </returns>
        public ListDisksResponse ListDisks(ListDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDisksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about disks in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter disks that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListDisksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDisksResponse
        /// </returns>
        public async Task<ListDisksResponse> ListDisksAsync(ListDisksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDisksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ListFirewallRules operation to query the firewall rule details of a simple application server, including the port range, firewall rule ID, and transport layer protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFirewallRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFirewallRulesResponse
        /// </returns>
        public ListFirewallRulesResponse ListFirewallRulesWithOptions(ListFirewallRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRuleId))
            {
                query["FirewallRuleId"] = request.FirewallRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListFirewallRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListFirewallRulesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFirewallRulesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ListFirewallRules operation to query the firewall rule details of a simple application server, including the port range, firewall rule ID, and transport layer protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFirewallRulesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFirewallRulesResponse
        /// </returns>
        public async Task<ListFirewallRulesResponse> ListFirewallRulesWithOptionsAsync(ListFirewallRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallRuleId))
            {
                query["FirewallRuleId"] = request.FirewallRuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListFirewallRules",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListFirewallRulesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFirewallRulesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ListFirewallRules operation to query the firewall rule details of a simple application server, including the port range, firewall rule ID, and transport layer protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFirewallRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFirewallRulesResponse
        /// </returns>
        public ListFirewallRulesResponse ListFirewallRules(ListFirewallRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFirewallRulesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the firewall rules of a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the ListFirewallRules operation to query the firewall rule details of a simple application server, including the port range, firewall rule ID, and transport layer protocol.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListFirewallRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFirewallRulesResponse
        /// </returns>
        public async Task<ListFirewallRulesResponse> ListFirewallRulesAsync(ListFirewallRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFirewallRulesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about images in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query details about one or more images in a specified region, including the IDs, names, and types of the images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public ListImagesResponse ListImagesWithOptions(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
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
                Action = "ListImages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListImagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListImagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about images in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query details about one or more images in a specified region, including the IDs, names, and types of the images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public async Task<ListImagesResponse> ListImagesWithOptionsAsync(ListImagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageIds))
            {
                query["ImageIds"] = request.ImageIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                query["ImageType"] = request.ImageType;
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
                Action = "ListImages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListImagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListImagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about images in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query details about one or more images in a specified region, including the IDs, names, and types of the images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public ListImagesResponse ListImages(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about images in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query details about one or more images in a specified region, including the IDs, names, and types of the images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListImagesResponse
        /// </returns>
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plans to which you can upgrade your simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the plan of your simple application server does not meet your business requirements, you can call the ListInstancePlansModification operation to obtain a list of plans that can be upgraded for your simple application server. Then, you can call the <a href="https://help.aliyun.com/document_detail/190445.html">UpgradeInstance</a> operation to upgrade the plan.</para>
        /// <remarks>
        /// <para> We recommend that you create snapshots for the disks of your simple application server to back up data before you upgrade the plan. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.
        /// For the precautions about plan upgrade, see <a href="https://help.aliyun.com/document_detail/61433.html">Upgrade a simple application server</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancePlansModificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePlansModificationResponse
        /// </returns>
        public ListInstancePlansModificationResponse ListInstancePlansModificationWithOptions(ListInstancePlansModificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListInstancePlansModification",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstancePlansModificationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstancePlansModificationResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plans to which you can upgrade your simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the plan of your simple application server does not meet your business requirements, you can call the ListInstancePlansModification operation to obtain a list of plans that can be upgraded for your simple application server. Then, you can call the <a href="https://help.aliyun.com/document_detail/190445.html">UpgradeInstance</a> operation to upgrade the plan.</para>
        /// <remarks>
        /// <para> We recommend that you create snapshots for the disks of your simple application server to back up data before you upgrade the plan. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.
        /// For the precautions about plan upgrade, see <a href="https://help.aliyun.com/document_detail/61433.html">Upgrade a simple application server</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancePlansModificationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePlansModificationResponse
        /// </returns>
        public async Task<ListInstancePlansModificationResponse> ListInstancePlansModificationWithOptionsAsync(ListInstancePlansModificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListInstancePlansModification",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstancePlansModificationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstancePlansModificationResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plans to which you can upgrade your simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the plan of your simple application server does not meet your business requirements, you can call the ListInstancePlansModification operation to obtain a list of plans that can be upgraded for your simple application server. Then, you can call the <a href="https://help.aliyun.com/document_detail/190445.html">UpgradeInstance</a> operation to upgrade the plan.</para>
        /// <remarks>
        /// <para> We recommend that you create snapshots for the disks of your simple application server to back up data before you upgrade the plan. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.
        /// For the precautions about plan upgrade, see <a href="https://help.aliyun.com/document_detail/61433.html">Upgrade a simple application server</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancePlansModificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePlansModificationResponse
        /// </returns>
        public ListInstancePlansModificationResponse ListInstancePlansModification(ListInstancePlansModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancePlansModificationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the plans to which you can upgrade your simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the plan of your simple application server does not meet your business requirements, you can call the ListInstancePlansModification operation to obtain a list of plans that can be upgraded for your simple application server. Then, you can call the <a href="https://help.aliyun.com/document_detail/190445.html">UpgradeInstance</a> operation to upgrade the plan.</para>
        /// <remarks>
        /// <para> We recommend that you create snapshots for the disks of your simple application server to back up data before you upgrade the plan. For more information, see <a href="https://help.aliyun.com/document_detail/190452.html">CreateSnapshot</a>.
        /// For the precautions about plan upgrade, see <a href="https://help.aliyun.com/document_detail/61433.html">Upgrade a simple application server</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancePlansModificationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancePlansModificationResponse
        /// </returns>
        public async Task<ListInstancePlansModificationResponse> ListInstancePlansModificationAsync(ListInstancePlansModificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancePlansModificationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public ListInstanceStatusResponse ListInstanceStatusWithOptions(ListInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstanceStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstanceStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public async Task<ListInstanceStatusResponse> ListInstanceStatusWithOptionsAsync(ListInstanceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstanceStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstanceStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public ListInstanceStatusResponse ListInstanceStatus(ListInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceStatusResponse
        /// </returns>
        public async Task<ListInstanceStatusResponse> ListInstanceStatusAsync(ListInstanceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about simple application servers in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of simple application servers in a specified region, including the names, public IP addresses, internal IP addresses, creation time, and expiration time of the servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIpAddresses))
            {
                query["PublicIpAddresses"] = request.PublicIpAddresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about simple application servers in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of simple application servers in a specified region, including the names, public IP addresses, internal IP addresses, creation time, and expiration time of the servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIpAddresses))
            {
                query["PublicIpAddresses"] = request.PublicIpAddresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about simple application servers in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of simple application servers in a specified region, including the names, public IP addresses, internal IP addresses, creation time, and expiration time of the servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about simple application servers in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the details of simple application servers in a specified region, including the names, public IP addresses, internal IP addresses, creation time, and expiration time of the servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about data transfer plans of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of data transfer plans of simple application servers, including the total quota, used quota, unused quota, and excess data transfers in the current month.
        /// Simple Application Server provides data transfer plans that can be used to offset data transfer fees. You are charged for excess data transfers. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Only outbound data transfers of simple application servers over the Internet are calculated. Outbound data transfers include the data transfer quota and the excess data transfers beyond the quota. Inbound data transfers of simple application servers over the Internet are not calculated.</description></item>
        /// <item><description>Outbound data transfers from simple application servers to other Alibaba Cloud services over the Internet first consume data transfer quotas. If the quotas are exhausted, you are charged for excess data transfers.</description></item>
        /// <item><description>You are not charged for data transfers between simple application servers within the same virtual private cloud (VPC).
        /// For more information, see <a href="https://help.aliyun.com/document_detail/86281.html">Quotas and billing of data transfers</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesTrafficPackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesTrafficPackagesResponse
        /// </returns>
        public ListInstancesTrafficPackagesResponse ListInstancesTrafficPackagesWithOptions(ListInstancesTrafficPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "ListInstancesTrafficPackages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstancesTrafficPackagesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstancesTrafficPackagesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about data transfer plans of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of data transfer plans of simple application servers, including the total quota, used quota, unused quota, and excess data transfers in the current month.
        /// Simple Application Server provides data transfer plans that can be used to offset data transfer fees. You are charged for excess data transfers. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Only outbound data transfers of simple application servers over the Internet are calculated. Outbound data transfers include the data transfer quota and the excess data transfers beyond the quota. Inbound data transfers of simple application servers over the Internet are not calculated.</description></item>
        /// <item><description>Outbound data transfers from simple application servers to other Alibaba Cloud services over the Internet first consume data transfer quotas. If the quotas are exhausted, you are charged for excess data transfers.</description></item>
        /// <item><description>You are not charged for data transfers between simple application servers within the same virtual private cloud (VPC).
        /// For more information, see <a href="https://help.aliyun.com/document_detail/86281.html">Quotas and billing of data transfers</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesTrafficPackagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesTrafficPackagesResponse
        /// </returns>
        public async Task<ListInstancesTrafficPackagesResponse> ListInstancesTrafficPackagesWithOptionsAsync(ListInstancesTrafficPackagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "ListInstancesTrafficPackages",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListInstancesTrafficPackagesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListInstancesTrafficPackagesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about data transfer plans of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of data transfer plans of simple application servers, including the total quota, used quota, unused quota, and excess data transfers in the current month.
        /// Simple Application Server provides data transfer plans that can be used to offset data transfer fees. You are charged for excess data transfers. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Only outbound data transfers of simple application servers over the Internet are calculated. Outbound data transfers include the data transfer quota and the excess data transfers beyond the quota. Inbound data transfers of simple application servers over the Internet are not calculated.</description></item>
        /// <item><description>Outbound data transfers from simple application servers to other Alibaba Cloud services over the Internet first consume data transfer quotas. If the quotas are exhausted, you are charged for excess data transfers.</description></item>
        /// <item><description>You are not charged for data transfers between simple application servers within the same virtual private cloud (VPC).
        /// For more information, see <a href="https://help.aliyun.com/document_detail/86281.html">Quotas and billing of data transfers</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesTrafficPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesTrafficPackagesResponse
        /// </returns>
        public ListInstancesTrafficPackagesResponse ListInstancesTrafficPackages(ListInstancesTrafficPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesTrafficPackagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about data transfer plans of simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of data transfer plans of simple application servers, including the total quota, used quota, unused quota, and excess data transfers in the current month.
        /// Simple Application Server provides data transfer plans that can be used to offset data transfer fees. You are charged for excess data transfers. Take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>Only outbound data transfers of simple application servers over the Internet are calculated. Outbound data transfers include the data transfer quota and the excess data transfers beyond the quota. Inbound data transfers of simple application servers over the Internet are not calculated.</description></item>
        /// <item><description>Outbound data transfers from simple application servers to other Alibaba Cloud services over the Internet first consume data transfer quotas. If the quotas are exhausted, you are charged for excess data transfers.</description></item>
        /// <item><description>You are not charged for data transfers between simple application servers within the same virtual private cloud (VPC).
        /// For more information, see <a href="https://help.aliyun.com/document_detail/86281.html">Quotas and billing of data transfers</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListInstancesTrafficPackagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesTrafficPackagesResponse
        /// </returns>
        public async Task<ListInstancesTrafficPackagesResponse> ListInstancesTrafficPackagesAsync(ListInstancesTrafficPackagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesTrafficPackagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs that are bound to simple application servers in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKeyPairsResponse
        /// </returns>
        public ListKeyPairsResponse ListKeyPairsWithOptions(ListKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKeyPairs",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListKeyPairsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKeyPairsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs that are bound to simple application servers in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyPairsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListKeyPairsResponse
        /// </returns>
        public async Task<ListKeyPairsResponse> ListKeyPairsWithOptionsAsync(ListKeyPairsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListKeyPairs",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListKeyPairsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListKeyPairsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs that are bound to simple application servers in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKeyPairsResponse
        /// </returns>
        public ListKeyPairsResponse ListKeyPairs(ListKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListKeyPairsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the AccessKey pairs that are bound to simple application servers in a specific region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListKeyPairsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListKeyPairsResponse
        /// </returns>
        public async Task<ListKeyPairsResponse> ListKeyPairsAsync(ListKeyPairsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListKeyPairsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all plans provided by Simple Application Server in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of all plans provided by Simple Application Server in a region, including the IDs, prices, disk sizes, and disk categories of the plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlansResponse
        /// </returns>
        public ListPlansResponse ListPlansWithOptions(ListPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListPlans",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPlansResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPlansResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all plans provided by Simple Application Server in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of all plans provided by Simple Application Server in a region, including the IDs, prices, disk sizes, and disk categories of the plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPlansResponse
        /// </returns>
        public async Task<ListPlansResponse> ListPlansWithOptionsAsync(ListPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListPlans",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListPlansResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListPlansResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all plans provided by Simple Application Server in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of all plans provided by Simple Application Server in a region, including the IDs, prices, disk sizes, and disk categories of the plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlansResponse
        /// </returns>
        public ListPlansResponse ListPlans(ListPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPlansWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all plans provided by Simple Application Server in a region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can query the details of all plans provided by Simple Application Server in a region, including the IDs, prices, disk sizes, and disk categories of the plans.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPlansResponse
        /// </returns>
        public async Task<ListPlansResponse> ListPlansAsync(ListPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPlansWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all regions in which Simple Application Server is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results include all the Alibaba Cloud regions where Simple Application Server is supported on the international site (alibabacloud.com) and the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListRegions",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListRegionsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all regions in which Simple Application Server is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results include all the Alibaba Cloud regions where Simple Application Server is supported on the international site (alibabacloud.com) and the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListRegions",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListRegionsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all regions in which Simple Application Server is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results include all the Alibaba Cloud regions where Simple Application Server is supported on the international site (alibabacloud.com) and the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all regions in which Simple Application Server is supported.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The query results include all the Alibaba Cloud regions where Simple Application Server is supported on the international site (alibabacloud.com) and the China site (aliyun.com).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about snapshots that are created for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskId</c>, <c>SnapshotIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter snapshots that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public ListSnapshotsResponse ListSnapshotsWithOptions(ListSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDiskType))
            {
                query["SourceDiskType"] = request.SourceDiskType;
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
                Action = "ListSnapshots",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSnapshotsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSnapshotsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about snapshots that are created for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskId</c>, <c>SnapshotIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter snapshots that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public async Task<ListSnapshotsResponse> ListSnapshotsWithOptionsAsync(ListSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                query["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceDiskType))
            {
                query["SourceDiskType"] = request.SourceDiskType;
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
                Action = "ListSnapshots",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSnapshotsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about snapshots that are created for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskId</c>, <c>SnapshotIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter snapshots that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about snapshots that are created for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The <c>InstanceId</c>, <c>DiskId</c>, <c>SnapshotIds</c>, and <c>ResourceGroupId</c> parameters are optional. However, you can specify them as filter conditions and combine them with the logical AND operator to filter snapshots that you want to query.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSnapshotsResponse
        /// </returns>
        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to simple resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to simple resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to simple resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
        /// <para>Queries the tags that are added to simple resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
        /// <para>Logs on to a simple application server on Workbench.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a simple application server, you can log on to the simple application server to build environments and applications on the server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoginInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoginInstanceResponse
        /// </returns>
        public LoginInstanceResponse LoginInstanceWithOptions(LoginInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<LoginInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<LoginInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs on to a simple application server on Workbench.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a simple application server, you can log on to the simple application server to build environments and applications on the server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoginInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LoginInstanceResponse
        /// </returns>
        public async Task<LoginInstanceResponse> LoginInstanceWithOptionsAsync(LoginInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LoginInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<LoginInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<LoginInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs on to a simple application server on Workbench.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a simple application server, you can log on to the simple application server to build environments and applications on the server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoginInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// LoginInstanceResponse
        /// </returns>
        public LoginInstanceResponse LoginInstance(LoginInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LoginInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Logs on to a simple application server on Workbench.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a simple application server, you can log on to the simple application server to build environments and applications on the server.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// LoginInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// LoginInstanceResponse
        /// </returns>
        public async Task<LoginInstanceResponse> LoginInstanceAsync(LoginInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LoginInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the description of a Simple Database Service instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceDescriptionResponse
        /// </returns>
        public ModifyDatabaseInstanceDescriptionResponse ModifyDatabaseInstanceDescriptionWithOptions(ModifyDatabaseInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceDescription))
            {
                query["DatabaseInstanceDescription"] = request.DatabaseInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "ModifyDatabaseInstanceDescription",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceDescriptionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceDescriptionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the description of a Simple Database Service instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceDescriptionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceDescriptionResponse
        /// </returns>
        public async Task<ModifyDatabaseInstanceDescriptionResponse> ModifyDatabaseInstanceDescriptionWithOptionsAsync(ModifyDatabaseInstanceDescriptionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceDescription))
            {
                query["DatabaseInstanceDescription"] = request.DatabaseInstanceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "ModifyDatabaseInstanceDescription",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceDescriptionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceDescriptionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the description of a Simple Database Service instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceDescriptionResponse
        /// </returns>
        public ModifyDatabaseInstanceDescriptionResponse ModifyDatabaseInstanceDescription(ModifyDatabaseInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDatabaseInstanceDescriptionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the description of a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to modify the description of a Simple Database Service instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceDescriptionResponse
        /// </returns>
        public async Task<ModifyDatabaseInstanceDescriptionResponse> ModifyDatabaseInstanceDescriptionAsync(ModifyDatabaseInstanceDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDatabaseInstanceDescriptionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceParameterResponse
        /// </returns>
        public ModifyDatabaseInstanceParameterResponse ModifyDatabaseInstanceParameterWithOptions(ModifyDatabaseInstanceParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceRestart))
            {
                query["ForceRestart"] = request.ForceRestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
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
                Action = "ModifyDatabaseInstanceParameter",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceParameterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceParameterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceParameterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceParameterResponse
        /// </returns>
        public async Task<ModifyDatabaseInstanceParameterResponse> ModifyDatabaseInstanceParameterWithOptionsAsync(ModifyDatabaseInstanceParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceRestart))
            {
                query["ForceRestart"] = request.ForceRestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                query["Parameters"] = request.Parameters;
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
                Action = "ModifyDatabaseInstanceParameter",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceParameterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyDatabaseInstanceParameterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceParameterResponse
        /// </returns>
        public ModifyDatabaseInstanceParameterResponse ModifyDatabaseInstanceParameter(ModifyDatabaseInstanceParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDatabaseInstanceParameterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you create a Simple Database Service instance, you can view the parameters of the instance or modify the parameters of the instance based on your business requirements.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDatabaseInstanceParameterRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDatabaseInstanceParameterResponse
        /// </returns>
        public async Task<ModifyDatabaseInstanceParameterResponse> ModifyDatabaseInstanceParameterAsync(ModifyDatabaseInstanceParameterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDatabaseInstanceParameterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallRuleResponse
        /// </returns>
        public ModifyFirewallRuleResponse ModifyFirewallRuleWithOptions(ModifyFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleProtocol))
            {
                query["RuleProtocol"] = request.RuleProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyFirewallRuleResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyFirewallRuleResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallRuleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallRuleResponse
        /// </returns>
        public async Task<ModifyFirewallRuleResponse> ModifyFirewallRuleWithOptionsAsync(ModifyFirewallRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleProtocol))
            {
                query["RuleProtocol"] = request.RuleProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceCidrIp))
            {
                query["SourceCidrIp"] = request.SourceCidrIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyFirewallRule",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyFirewallRuleResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyFirewallRuleResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallRuleResponse
        /// </returns>
        public ModifyFirewallRuleResponse ModifyFirewallRule(ModifyFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFirewallRuleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyFirewallRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallRuleResponse
        /// </returns>
        public async Task<ModifyFirewallRuleResponse> ModifyFirewallRuleAsync(ModifyFirewallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFirewallRuleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule in a firewall template. You can apply the new firewall rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifying a firewall template does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFirewallTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallTemplateResponse
        /// </returns>
        public ModifyFirewallTemplateResponse ModifyFirewallTemplateWithOptions(ModifyFirewallTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateRule))
            {
                query["FirewallTemplateRule"] = request.FirewallTemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "ModifyFirewallTemplate",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyFirewallTemplateResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyFirewallTemplateResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule in a firewall template. You can apply the new firewall rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifying a firewall template does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFirewallTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallTemplateResponse
        /// </returns>
        public async Task<ModifyFirewallTemplateResponse> ModifyFirewallTemplateWithOptionsAsync(ModifyFirewallTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateId))
            {
                query["FirewallTemplateId"] = request.FirewallTemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirewallTemplateRule))
            {
                query["FirewallTemplateRule"] = request.FirewallTemplateRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
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
                Action = "ModifyFirewallTemplate",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyFirewallTemplateResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyFirewallTemplateResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule in a firewall template. You can apply the new firewall rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifying a firewall template does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFirewallTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallTemplateResponse
        /// </returns>
        public ModifyFirewallTemplateResponse ModifyFirewallTemplate(ModifyFirewallTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyFirewallTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the firewall rule in a firewall template. You can apply the new firewall rule to simple application servers.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifying a firewall template does not affect the firewall rules that have been applied to simple application servers.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyFirewallTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyFirewallTemplateResponse
        /// </returns>
        public async Task<ModifyFirewallTemplateResponse> ModifyFirewallTemplateAsync(ModifyFirewallTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyFirewallTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a custom image to Elastic Compute Service (ECS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Custom images can be shared to ECS. If the configurations of your simple application server cannot meet your business requirements, or you want to deploy your business on ECS instances, you can share your custom image to ECS to transfer your business from Simple Application Server to ECS.</para>
        /// <remarks>
        /// <para> The region in which the shared image resides in ECS is the same as the region in which the custom image resides in Simple Application Server.
        /// You can unshare a custom image based on your business requirements or when you want to delete the custom image. After you unshare a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You cannot query or use the custom image by using the ECS console or API.</description></item>
        /// <item><description>You cannot re-initialize the disks of the ECS instances that were created based on the shared image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyImageShareStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyImageShareStatusResponse
        /// </returns>
        public ModifyImageShareStatusResponse ModifyImageShareStatusWithOptions(ModifyImageShareStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
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
                Action = "ModifyImageShareStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyImageShareStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyImageShareStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a custom image to Elastic Compute Service (ECS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Custom images can be shared to ECS. If the configurations of your simple application server cannot meet your business requirements, or you want to deploy your business on ECS instances, you can share your custom image to ECS to transfer your business from Simple Application Server to ECS.</para>
        /// <remarks>
        /// <para> The region in which the shared image resides in ECS is the same as the region in which the custom image resides in Simple Application Server.
        /// You can unshare a custom image based on your business requirements or when you want to delete the custom image. After you unshare a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You cannot query or use the custom image by using the ECS console or API.</description></item>
        /// <item><description>You cannot re-initialize the disks of the ECS instances that were created based on the shared image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyImageShareStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyImageShareStatusResponse
        /// </returns>
        public async Task<ModifyImageShareStatusResponse> ModifyImageShareStatusWithOptionsAsync(ModifyImageShareStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operation))
            {
                query["Operation"] = request.Operation;
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
                Action = "ModifyImageShareStatus",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyImageShareStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyImageShareStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a custom image to Elastic Compute Service (ECS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Custom images can be shared to ECS. If the configurations of your simple application server cannot meet your business requirements, or you want to deploy your business on ECS instances, you can share your custom image to ECS to transfer your business from Simple Application Server to ECS.</para>
        /// <remarks>
        /// <para> The region in which the shared image resides in ECS is the same as the region in which the custom image resides in Simple Application Server.
        /// You can unshare a custom image based on your business requirements or when you want to delete the custom image. After you unshare a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You cannot query or use the custom image by using the ECS console or API.</description></item>
        /// <item><description>You cannot re-initialize the disks of the ECS instances that were created based on the shared image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyImageShareStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyImageShareStatusResponse
        /// </returns>
        public ModifyImageShareStatusResponse ModifyImageShareStatus(ModifyImageShareStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyImageShareStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Shares or unshares a custom image to Elastic Compute Service (ECS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Custom images can be shared to ECS. If the configurations of your simple application server cannot meet your business requirements, or you want to deploy your business on ECS instances, you can share your custom image to ECS to transfer your business from Simple Application Server to ECS.</para>
        /// <remarks>
        /// <para> The region in which the shared image resides in ECS is the same as the region in which the custom image resides in Simple Application Server.
        /// You can unshare a custom image based on your business requirements or when you want to delete the custom image. After you unshare a custom image, take note of the following items:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You cannot query or use the custom image by using the ECS console or API.</description></item>
        /// <item><description>You cannot re-initialize the disks of the ECS instances that were created based on the shared image.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyImageShareStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyImageShareStatusResponse
        /// </returns>
        public async Task<ModifyImageShareStatusResponse> ModifyImageShareStatusAsync(ModifyImageShareStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyImageShareStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the VNC password of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceVncPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVncPasswordResponse
        /// </returns>
        public ModifyInstanceVncPasswordResponse ModifyInstanceVncPasswordWithOptions(ModifyInstanceVncPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VncPassword))
            {
                query["VncPassword"] = request.VncPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceVncPassword",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyInstanceVncPasswordResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyInstanceVncPasswordResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the VNC password of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceVncPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVncPasswordResponse
        /// </returns>
        public async Task<ModifyInstanceVncPasswordResponse> ModifyInstanceVncPasswordWithOptionsAsync(ModifyInstanceVncPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VncPassword))
            {
                query["VncPassword"] = request.VncPassword;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceVncPassword",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ModifyInstanceVncPasswordResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ModifyInstanceVncPasswordResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the VNC password of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceVncPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVncPasswordResponse
        /// </returns>
        public ModifyInstanceVncPasswordResponse ModifyInstanceVncPassword(ModifyInstanceVncPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceVncPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the VNC password of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceVncPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceVncPasswordResponse
        /// </returns>
        public async Task<ModifyInstanceVncPasswordResponse> ModifyInstanceVncPasswordAsync(ModifyInstanceVncPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceVncPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only simple application servers that are in the Running state can be restarted.</para>
        /// <list type="bullet">
        /// <item><description>After you restart a simple application server, it enters the Starting state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootInstanceResponse
        /// </returns>
        public RebootInstanceResponse RebootInstanceWithOptions(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "RebootInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RebootInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RebootInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only simple application servers that are in the Running state can be restarted.</para>
        /// <list type="bullet">
        /// <item><description>After you restart a simple application server, it enters the Starting state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootInstanceResponse
        /// </returns>
        public async Task<RebootInstanceResponse> RebootInstanceWithOptionsAsync(RebootInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "RebootInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RebootInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RebootInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only simple application servers that are in the Running state can be restarted.</para>
        /// <list type="bullet">
        /// <item><description>After you restart a simple application server, it enters the Starting state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootInstanceResponse
        /// </returns>
        public RebootInstanceResponse RebootInstance(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only simple application servers that are in the Running state can be restarted.</para>
        /// <list type="bullet">
        /// <item><description>After you restart a simple application server, it enters the Starting state.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RebootInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootInstanceResponse
        /// </returns>
        public async Task<RebootInstanceResponse> RebootInstanceAsync(RebootInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootInstancesResponse
        /// </returns>
        public RebootInstancesResponse RebootInstancesWithOptions(RebootInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceReboot))
            {
                query["ForceReboot"] = request.ForceReboot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "RebootInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RebootInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RebootInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RebootInstancesResponse
        /// </returns>
        public async Task<RebootInstancesResponse> RebootInstancesWithOptionsAsync(RebootInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceReboot))
            {
                query["ForceReboot"] = request.ForceReboot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "RebootInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RebootInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RebootInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootInstancesResponse
        /// </returns>
        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RebootInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RebootInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// RebootInstancesResponse
        /// </returns>
        public async Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RebootInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleasePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleasePublicConnectionResponse
        /// </returns>
        public ReleasePublicConnectionResponse ReleasePublicConnectionWithOptions(ReleasePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "ReleasePublicConnection",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleasePublicConnectionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleasePublicConnectionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleasePublicConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleasePublicConnectionResponse
        /// </returns>
        public async Task<ReleasePublicConnectionResponse> ReleasePublicConnectionWithOptionsAsync(ReleasePublicConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "ReleasePublicConnection",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ReleasePublicConnectionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ReleasePublicConnectionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleasePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleasePublicConnectionResponse
        /// </returns>
        public ReleasePublicConnectionResponse ReleasePublicConnection(ReleasePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleasePublicConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you no longer need to use a public endpoint to access a Simple Database Service instance, you can release the public endpoint.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ReleasePublicConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleasePublicConnectionResponse
        /// </returns>
        public async Task<ReleasePublicConnectionResponse> ReleasePublicConnectionAsync(ReleasePublicConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleasePublicConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unshares a custom image that is shared across Alibaba Cloud accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveCustomImageShareAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveCustomImageShareAccountResponse
        /// </returns>
        public RemoveCustomImageShareAccountResponse RemoveCustomImageShareAccountWithOptions(RemoveCustomImageShareAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "RemoveCustomImageShareAccount",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveCustomImageShareAccountResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveCustomImageShareAccountResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unshares a custom image that is shared across Alibaba Cloud accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveCustomImageShareAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveCustomImageShareAccountResponse
        /// </returns>
        public async Task<RemoveCustomImageShareAccountResponse> RemoveCustomImageShareAccountWithOptionsAsync(RemoveCustomImageShareAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Account))
            {
                query["Account"] = request.Account;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
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
                Action = "RemoveCustomImageShareAccount",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RemoveCustomImageShareAccountResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RemoveCustomImageShareAccountResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unshares a custom image that is shared across Alibaba Cloud accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveCustomImageShareAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveCustomImageShareAccountResponse
        /// </returns>
        public RemoveCustomImageShareAccountResponse RemoveCustomImageShareAccount(RemoveCustomImageShareAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveCustomImageShareAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unshares a custom image that is shared across Alibaba Cloud accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveCustomImageShareAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveCustomImageShareAccountResponse
        /// </returns>
        public async Task<RemoveCustomImageShareAccountResponse> RemoveCustomImageShareAccountAsync(RemoveCustomImageShareAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveCustomImageShareAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the renewal fails.</description></item>
        /// </list>
        /// </description>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "RenewInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenewInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenewInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the renewal fails.</description></item>
        /// </list>
        /// </description>
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
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
                Action = "RenewInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RenewInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RenewInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renews a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the renewal fails.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Renews a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Before you call this operation, we recommend that you understand the billing of Simple Application Server. For more information, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the renewal fails.</description></item>
        /// </list>
        /// </description>
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
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDatabaseAccountPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetDatabaseAccountPasswordResponse
        /// </returns>
        public ResetDatabaseAccountPasswordResponse ResetDatabaseAccountPasswordWithOptions(ResetDatabaseAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "ResetDatabaseAccountPassword",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetDatabaseAccountPasswordResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetDatabaseAccountPasswordResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDatabaseAccountPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetDatabaseAccountPasswordResponse
        /// </returns>
        public async Task<ResetDatabaseAccountPasswordResponse> ResetDatabaseAccountPasswordWithOptionsAsync(ResetDatabaseAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountPassword))
            {
                query["AccountPassword"] = request.AccountPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "ResetDatabaseAccountPassword",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetDatabaseAccountPasswordResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetDatabaseAccountPasswordResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDatabaseAccountPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetDatabaseAccountPasswordResponse
        /// </returns>
        public ResetDatabaseAccountPasswordResponse ResetDatabaseAccountPassword(ResetDatabaseAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDatabaseAccountPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If the password of your Simple Database Service instance is not strong, you can call this operation to change the password of the administrator account of the instance. To ensure security of the instance, we recommend that you regularly change the password of the instance.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDatabaseAccountPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetDatabaseAccountPasswordResponse
        /// </returns>
        public async Task<ResetDatabaseAccountPasswordResponse> ResetDatabaseAccountPasswordAsync(ResetDatabaseAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDatabaseAccountPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a disk based on a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only if the associated simple application server is in the Stopped state.</para>
        /// <list type="bullet">
        /// <item><description>If you restore a disk from a snapshot, the incremental data after the snapshot is created is lost. We recommend that you back up the data before you perform this operation.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>Resetting the system or changing the image of a simple application server clears the disk data on the server. Snapshots created before the reset or change are retained but cannot be used to restore disks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetDiskResponse
        /// </returns>
        public ResetDiskResponse ResetDiskWithOptions(ResetDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetDisk",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetDiskResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetDiskResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a disk based on a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only if the associated simple application server is in the Stopped state.</para>
        /// <list type="bullet">
        /// <item><description>If you restore a disk from a snapshot, the incremental data after the snapshot is created is lost. We recommend that you back up the data before you perform this operation.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>Resetting the system or changing the image of a simple application server clears the disk data on the server. Snapshots created before the reset or change are retained but cannot be used to restore disks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetDiskResponse
        /// </returns>
        public async Task<ResetDiskResponse> ResetDiskWithOptionsAsync(ResetDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetDisk",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetDiskResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetDiskResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a disk based on a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only if the associated simple application server is in the Stopped state.</para>
        /// <list type="bullet">
        /// <item><description>If you restore a disk from a snapshot, the incremental data after the snapshot is created is lost. We recommend that you back up the data before you perform this operation.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>Resetting the system or changing the image of a simple application server clears the disk data on the server. Snapshots created before the reset or change are retained but cannot be used to restore disks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDiskRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetDiskResponse
        /// </returns>
        public ResetDiskResponse ResetDisk(ResetDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetDiskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back a disk based on a snapshot.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can call this operation only if the associated simple application server is in the Stopped state.</para>
        /// <list type="bullet">
        /// <item><description>If you restore a disk from a snapshot, the incremental data after the snapshot is created is lost. We recommend that you back up the data before you perform this operation.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <para>Resetting the system or changing the image of a simple application server clears the disk data on the server. Snapshots created before the reset or change are retained but cannot be used to restore disks.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetDiskRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetDiskResponse
        /// </returns>
        public async Task<ResetDiskResponse> ResetDiskAsync(ResetDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetDiskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can reset a simple application server to re-install its applications or operating system and re-initialize the server. You can reset a simple application server by resetting the current system or changing the image.</para>
        /// <list type="bullet">
        /// <item><description>Reset the current system: You can re-install the operating system without changing the image.</description></item>
        /// <item><description>Change the image: You can select another Alibaba Cloud image or a custom image to re-install the operating system.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// <item><description>After you reset a simple application server, monitoring may fail. In this case, you can use one of the following methods to install the CloudMonitor agent on the server:<list type="bullet">
        /// <item><description>Connect to the server: For more information, see <a href="https://help.aliyun.com/document_detail/183482.html">Manually install the CloudMonitor agent for C++ on an ECS instance</a>.</description></item>
        /// <item><description>Use Command Assistant: For more information, see <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a>. You can obtain the command that can be used to install CloudMonitor from the &quot;Common commands&quot; section of the <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a> topic.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Snapshots that are created before the reset are retained, but the snapshots cannot be used to restore the disks of the server.</description></item>
        /// <item><description>You cannot reset simple application servers that were created from custom images that contain data of data disks.</description></item>
        /// <item><description>If you reset a simple application server by replacing the existing image with a custom image, the following limits apply:<list type="bullet">
        /// <item><description>The custom image must reside in the same region as the current server.</description></item>
        /// <item><description>The custom image cannot be created based on the current server. If you want to restore the data on the server, you can use a snapshot of the server to restore disk data.</description></item>
        /// <item><description>If your simple application server resides in a region outside the Chinese mainland, you cannot switch the operating system of the server between Windows Server and Linux. You cannot use a Windows Server custom image to reset a Linux simple application server. Similarly, you cannot use a Linux custom image to reset a Windows Server simple application server. You can switch the operating systems of simple application servers only between Windows Server versions or between Linux distributions.</description></item>
        /// <item><description>The following limits apply to the disks attached to the simple application server:<list type="bullet">
        /// <item><description>If the custom image contains a system disk and a data disk but only a system disk is attached to the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// <item><description>If the system disk size of the custom image is greater than the system disk size of the simple application server, you cannot directly use the custom image to reset the simple application server.</description></item>
        /// <item><description>Only if the system disk size of the simple application server is greater than or equal to the system disk size of the custom image, you can use the custom image to reset the simple application server. To increase the system disk size of your server, you can upgrade the server configuration. For more information, see Upgrade a simple application server.</description></item>
        /// <item><description>If the data disk size of the custom image is greater than the data disk size of the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetSystemResponse
        /// </returns>
        public ResetSystemResponse ResetSystemWithOptions(ResetSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginCredentials))
            {
                query["LoginCredentials"] = request.LoginCredentials;
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
                Action = "ResetSystem",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetSystemResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetSystemResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can reset a simple application server to re-install its applications or operating system and re-initialize the server. You can reset a simple application server by resetting the current system or changing the image.</para>
        /// <list type="bullet">
        /// <item><description>Reset the current system: You can re-install the operating system without changing the image.</description></item>
        /// <item><description>Change the image: You can select another Alibaba Cloud image or a custom image to re-install the operating system.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// <item><description>After you reset a simple application server, monitoring may fail. In this case, you can use one of the following methods to install the CloudMonitor agent on the server:<list type="bullet">
        /// <item><description>Connect to the server: For more information, see <a href="https://help.aliyun.com/document_detail/183482.html">Manually install the CloudMonitor agent for C++ on an ECS instance</a>.</description></item>
        /// <item><description>Use Command Assistant: For more information, see <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a>. You can obtain the command that can be used to install CloudMonitor from the &quot;Common commands&quot; section of the <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a> topic.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Snapshots that are created before the reset are retained, but the snapshots cannot be used to restore the disks of the server.</description></item>
        /// <item><description>You cannot reset simple application servers that were created from custom images that contain data of data disks.</description></item>
        /// <item><description>If you reset a simple application server by replacing the existing image with a custom image, the following limits apply:<list type="bullet">
        /// <item><description>The custom image must reside in the same region as the current server.</description></item>
        /// <item><description>The custom image cannot be created based on the current server. If you want to restore the data on the server, you can use a snapshot of the server to restore disk data.</description></item>
        /// <item><description>If your simple application server resides in a region outside the Chinese mainland, you cannot switch the operating system of the server between Windows Server and Linux. You cannot use a Windows Server custom image to reset a Linux simple application server. Similarly, you cannot use a Linux custom image to reset a Windows Server simple application server. You can switch the operating systems of simple application servers only between Windows Server versions or between Linux distributions.</description></item>
        /// <item><description>The following limits apply to the disks attached to the simple application server:<list type="bullet">
        /// <item><description>If the custom image contains a system disk and a data disk but only a system disk is attached to the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// <item><description>If the system disk size of the custom image is greater than the system disk size of the simple application server, you cannot directly use the custom image to reset the simple application server.</description></item>
        /// <item><description>Only if the system disk size of the simple application server is greater than or equal to the system disk size of the custom image, you can use the custom image to reset the simple application server. To increase the system disk size of your server, you can upgrade the server configuration. For more information, see Upgrade a simple application server.</description></item>
        /// <item><description>If the data disk size of the custom image is greater than the data disk size of the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetSystemResponse
        /// </returns>
        public async Task<ResetSystemResponse> ResetSystemWithOptionsAsync(ResetSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                query["ImageId"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginCredentials))
            {
                query["LoginCredentials"] = request.LoginCredentials;
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
                Action = "ResetSystem",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<ResetSystemResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ResetSystemResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can reset a simple application server to re-install its applications or operating system and re-initialize the server. You can reset a simple application server by resetting the current system or changing the image.</para>
        /// <list type="bullet">
        /// <item><description>Reset the current system: You can re-install the operating system without changing the image.</description></item>
        /// <item><description>Change the image: You can select another Alibaba Cloud image or a custom image to re-install the operating system.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// <item><description>After you reset a simple application server, monitoring may fail. In this case, you can use one of the following methods to install the CloudMonitor agent on the server:<list type="bullet">
        /// <item><description>Connect to the server: For more information, see <a href="https://help.aliyun.com/document_detail/183482.html">Manually install the CloudMonitor agent for C++ on an ECS instance</a>.</description></item>
        /// <item><description>Use Command Assistant: For more information, see <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a>. You can obtain the command that can be used to install CloudMonitor from the &quot;Common commands&quot; section of the <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a> topic.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Snapshots that are created before the reset are retained, but the snapshots cannot be used to restore the disks of the server.</description></item>
        /// <item><description>You cannot reset simple application servers that were created from custom images that contain data of data disks.</description></item>
        /// <item><description>If you reset a simple application server by replacing the existing image with a custom image, the following limits apply:<list type="bullet">
        /// <item><description>The custom image must reside in the same region as the current server.</description></item>
        /// <item><description>The custom image cannot be created based on the current server. If you want to restore the data on the server, you can use a snapshot of the server to restore disk data.</description></item>
        /// <item><description>If your simple application server resides in a region outside the Chinese mainland, you cannot switch the operating system of the server between Windows Server and Linux. You cannot use a Windows Server custom image to reset a Linux simple application server. Similarly, you cannot use a Linux custom image to reset a Windows Server simple application server. You can switch the operating systems of simple application servers only between Windows Server versions or between Linux distributions.</description></item>
        /// <item><description>The following limits apply to the disks attached to the simple application server:<list type="bullet">
        /// <item><description>If the custom image contains a system disk and a data disk but only a system disk is attached to the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// <item><description>If the system disk size of the custom image is greater than the system disk size of the simple application server, you cannot directly use the custom image to reset the simple application server.</description></item>
        /// <item><description>Only if the system disk size of the simple application server is greater than or equal to the system disk size of the custom image, you can use the custom image to reset the simple application server. To increase the system disk size of your server, you can upgrade the server configuration. For more information, see Upgrade a simple application server.</description></item>
        /// <item><description>If the data disk size of the custom image is greater than the data disk size of the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetSystemResponse
        /// </returns>
        public ResetSystemResponse ResetSystem(ResetSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can reset a simple application server to re-install its applications or operating system and re-initialize the server. You can reset a simple application server by resetting the current system or changing the image.</para>
        /// <list type="bullet">
        /// <item><description>Reset the current system: You can re-install the operating system without changing the image.</description></item>
        /// <item><description>Change the image: You can select another Alibaba Cloud image or a custom image to re-install the operating system.</description></item>
        /// </list>
        /// <h3><a href="#"></a>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Resetting the system or changing the image of a simple application server clears the disk data on the server. Back up the data as needed.</description></item>
        /// <item><description>After you reset a simple application server, monitoring may fail. In this case, you can use one of the following methods to install the CloudMonitor agent on the server:<list type="bullet">
        /// <item><description>Connect to the server: For more information, see <a href="https://help.aliyun.com/document_detail/183482.html">Manually install the CloudMonitor agent for C++ on an ECS instance</a>.</description></item>
        /// <item><description>Use Command Assistant: For more information, see <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a>. You can obtain the command that can be used to install CloudMonitor from the &quot;Common commands&quot; section of the <a href="https://help.aliyun.com/document_detail/438681.html">Use Command Assistant</a> topic.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <h3><a href="#"></a>Limits</h3>
        /// <list type="bullet">
        /// <item><description>Snapshots that are created before the reset are retained, but the snapshots cannot be used to restore the disks of the server.</description></item>
        /// <item><description>You cannot reset simple application servers that were created from custom images that contain data of data disks.</description></item>
        /// <item><description>If you reset a simple application server by replacing the existing image with a custom image, the following limits apply:<list type="bullet">
        /// <item><description>The custom image must reside in the same region as the current server.</description></item>
        /// <item><description>The custom image cannot be created based on the current server. If you want to restore the data on the server, you can use a snapshot of the server to restore disk data.</description></item>
        /// <item><description>If your simple application server resides in a region outside the Chinese mainland, you cannot switch the operating system of the server between Windows Server and Linux. You cannot use a Windows Server custom image to reset a Linux simple application server. Similarly, you cannot use a Linux custom image to reset a Windows Server simple application server. You can switch the operating systems of simple application servers only between Windows Server versions or between Linux distributions.</description></item>
        /// <item><description>The following limits apply to the disks attached to the simple application server:<list type="bullet">
        /// <item><description>If the custom image contains a system disk and a data disk but only a system disk is attached to the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// <item><description>If the system disk size of the custom image is greater than the system disk size of the simple application server, you cannot directly use the custom image to reset the simple application server.</description></item>
        /// <item><description>Only if the system disk size of the simple application server is greater than or equal to the system disk size of the custom image, you can use the custom image to reset the simple application server. To increase the system disk size of your server, you can upgrade the server configuration. For more information, see Upgrade a simple application server.</description></item>
        /// <item><description>If the data disk size of the custom image is greater than the data disk size of the simple application server, you cannot use the custom image to reset the simple application server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetSystemResponse
        /// </returns>
        public async Task<ResetSystemResponse> ResetSystemAsync(ResetSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetSystemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartDatabaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartDatabaseInstanceResponse
        /// </returns>
        public RestartDatabaseInstanceResponse RestartDatabaseInstanceWithOptions(RestartDatabaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "RestartDatabaseInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RestartDatabaseInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RestartDatabaseInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartDatabaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartDatabaseInstanceResponse
        /// </returns>
        public async Task<RestartDatabaseInstanceResponse> RestartDatabaseInstanceWithOptionsAsync(RestartDatabaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "RestartDatabaseInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RestartDatabaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RestartDatabaseInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartDatabaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartDatabaseInstanceResponse
        /// </returns>
        public RestartDatabaseInstanceResponse RestartDatabaseInstance(RestartDatabaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartDatabaseInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to restart a Simple Database Service instance that is in the Running state.</para>
        /// <h3>QPS limit</h3>
        /// <para>You can call this API operation up to 10 times per minute per account. Requests that exceed this limit are dropped and you may experience service interruptions. We recommend that you take note of this limit when you call this operation. For more information, see <a href="https://help.aliyun.com/document_detail/347607.html">QPS limits</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartDatabaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartDatabaseInstanceResponse
        /// </returns>
        public async Task<RestartDatabaseInstanceResponse> RestartDatabaseInstanceAsync(RestartDatabaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartDatabaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands on a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Command Assistant is an automated O\&amp;M tool for Simple Application Server. You can maintain simple application servers by running shell, PowerShell, and batch commands in the Simple Application Server console without remotely logging on to the servers.
        /// Before you use Command Assistant, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The simple application server must be in the Running state.</description></item>
        /// <item><description>The Cloud Assistant client is installed on the server. By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall it. For more information, see <a href="https://help.aliyun.com/document_detail/64921.html">Install the Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RunCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public RunCommandResponse RunCommandWithOptions(RunCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCommandShrinkRequest request = new RunCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableParameter))
            {
                query["EnableParameter"] = request.EnableParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WindowsPasswordName))
            {
                query["WindowsPasswordName"] = request.WindowsPasswordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingDir))
            {
                query["WorkingDir"] = request.WorkingDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingUser))
            {
                query["WorkingUser"] = request.WorkingUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RunCommandResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RunCommandResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands on a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Command Assistant is an automated O\&amp;M tool for Simple Application Server. You can maintain simple application servers by running shell, PowerShell, and batch commands in the Simple Application Server console without remotely logging on to the servers.
        /// Before you use Command Assistant, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The simple application server must be in the Running state.</description></item>
        /// <item><description>The Cloud Assistant client is installed on the server. By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall it. For more information, see <a href="https://help.aliyun.com/document_detail/64921.html">Install the Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// RunCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public async Task<RunCommandResponse> RunCommandWithOptionsAsync(RunCommandRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RunCommandShrinkRequest request = new RunCommandShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Parameters))
            {
                request.ParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Parameters, "Parameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandContent))
            {
                query["CommandContent"] = request.CommandContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableParameter))
            {
                query["EnableParameter"] = request.EnableParameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParametersShrink))
            {
                query["Parameters"] = request.ParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WindowsPasswordName))
            {
                query["WindowsPasswordName"] = request.WindowsPasswordName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingDir))
            {
                query["WorkingDir"] = request.WorkingDir;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingUser))
            {
                query["WorkingUser"] = request.WorkingUser;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunCommand",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<RunCommandResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<RunCommandResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands on a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Command Assistant is an automated O\&amp;M tool for Simple Application Server. You can maintain simple application servers by running shell, PowerShell, and batch commands in the Simple Application Server console without remotely logging on to the servers.
        /// Before you use Command Assistant, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The simple application server must be in the Running state.</description></item>
        /// <item><description>The Cloud Assistant client is installed on the server. By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall it. For more information, see <a href="https://help.aliyun.com/document_detail/64921.html">Install the Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RunCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public RunCommandResponse RunCommand(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCommandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands on a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Command Assistant is an automated O\&amp;M tool for Simple Application Server. You can maintain simple application servers by running shell, PowerShell, and batch commands in the Simple Application Server console without remotely logging on to the servers.
        /// Before you use Command Assistant, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The simple application server must be in the Running state.</description></item>
        /// <item><description>The Cloud Assistant client is installed on the server. By default, the Cloud Assistant client is installed on simple application servers. If you have manually uninstalled the client, you must reinstall it. For more information, see <a href="https://help.aliyun.com/document_detail/64921.html">Install the Cloud Assistant Agent</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RunCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// RunCommandResponse
        /// </returns>
        public async Task<RunCommandResponse> RunCommandAsync(RunCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a Simple Database Service instance that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDatabaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDatabaseInstanceResponse
        /// </returns>
        public StartDatabaseInstanceResponse StartDatabaseInstanceWithOptions(StartDatabaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "StartDatabaseInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartDatabaseInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartDatabaseInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a Simple Database Service instance that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDatabaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartDatabaseInstanceResponse
        /// </returns>
        public async Task<StartDatabaseInstanceResponse> StartDatabaseInstanceWithOptionsAsync(StartDatabaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "StartDatabaseInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartDatabaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartDatabaseInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a Simple Database Service instance that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDatabaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDatabaseInstanceResponse
        /// </returns>
        public StartDatabaseInstanceResponse StartDatabaseInstance(StartDatabaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDatabaseInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a Simple Database Service instance that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartDatabaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartDatabaseInstanceResponse
        /// </returns>
        public async Task<StartDatabaseInstanceResponse> StartDatabaseInstanceAsync(StartDatabaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDatabaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a simple application server that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StartInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a simple application server that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StartInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a simple application server that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to start a simple application server that is in the Stopped state.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstancesResponse
        /// </returns>
        public StartInstancesResponse StartInstancesWithOptions(StartInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "StartInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstancesResponse
        /// </returns>
        public async Task<StartInstancesResponse> StartInstancesWithOptionsAsync(StartInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "StartInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstancesResponse
        /// </returns>
        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstancesResponse
        /// </returns>
        public async Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTerminalSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTerminalSessionResponse
        /// </returns>
        public StartTerminalSessionResponse StartTerminalSessionWithOptions(StartTerminalSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StartTerminalSession",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartTerminalSessionResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartTerminalSessionResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTerminalSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartTerminalSessionResponse
        /// </returns>
        public async Task<StartTerminalSessionResponse> StartTerminalSessionWithOptionsAsync(StartTerminalSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StartTerminalSession",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StartTerminalSessionResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StartTerminalSessionResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTerminalSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTerminalSessionResponse
        /// </returns>
        public StartTerminalSessionResponse StartTerminalSession(StartTerminalSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTerminalSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartTerminalSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// StartTerminalSessionResponse
        /// </returns>
        public async Task<StartTerminalSessionResponse> StartTerminalSessionAsync(StartTerminalSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTerminalSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to stop a Simple Database Service instance that is in the Running state. After the instance is stopped, you cannot log on to or access the instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDatabaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDatabaseInstanceResponse
        /// </returns>
        public StopDatabaseInstanceResponse StopDatabaseInstanceWithOptions(StopDatabaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "StopDatabaseInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StopDatabaseInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StopDatabaseInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to stop a Simple Database Service instance that is in the Running state. After the instance is stopped, you cannot log on to or access the instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDatabaseInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopDatabaseInstanceResponse
        /// </returns>
        public async Task<StopDatabaseInstanceResponse> StopDatabaseInstanceWithOptionsAsync(StopDatabaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseInstanceId))
            {
                query["DatabaseInstanceId"] = request.DatabaseInstanceId;
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
                Action = "StopDatabaseInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StopDatabaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StopDatabaseInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to stop a Simple Database Service instance that is in the Running state. After the instance is stopped, you cannot log on to or access the instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDatabaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDatabaseInstanceResponse
        /// </returns>
        public StopDatabaseInstanceResponse StopDatabaseInstance(StopDatabaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDatabaseInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a Simple Database Service instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to stop a Simple Database Service instance that is in the Running state. After the instance is stopped, you cannot log on to or access the instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopDatabaseInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopDatabaseInstanceResponse
        /// </returns>
        public async Task<StopDatabaseInstanceResponse> StopDatabaseInstanceAsync(StopDatabaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDatabaseInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can stop a simple application server that you do not use for the time being.</para>
        /// <remarks>
        /// <para> Stopping a simple application server may interrupt your business. We recommend that you perform this operation during off-peak hours.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StopInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can stop a simple application server that you do not use for the time being.</para>
        /// <remarks>
        /// <para> Stopping a simple application server may interrupt your business. We recommend that you perform this operation during off-peak hours.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StopInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can stop a simple application server that you do not use for the time being.</para>
        /// <remarks>
        /// <para> Stopping a simple application server may interrupt your business. We recommend that you perform this operation during off-peak hours.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can stop a simple application server that you do not use for the time being.</para>
        /// <remarks>
        /// <para> Stopping a simple application server may interrupt your business. We recommend that you perform this operation during off-peak hours.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstancesResponse
        /// </returns>
        public StopInstancesResponse StopInstancesWithOptions(StopInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "StopInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StopInstancesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StopInstancesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstancesResponse
        /// </returns>
        public async Task<StopInstancesResponse> StopInstancesWithOptionsAsync(StopInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceStop))
            {
                query["ForceStop"] = request.ForceStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
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
                Action = "StopInstances",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<StopInstancesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<StopInstancesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstancesResponse
        /// </returns>
        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops simple application servers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstancesResponse
        /// </returns>
        public async Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to simple application servers, snapshots, custom images, commands, firewall rules, and disks to facilitate the viewing and management of the preceding resources.</para>
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
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to simple application servers, snapshots, custom images, commands, firewall rules, and disks to facilitate the viewing and management of the preceding resources.</para>
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
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<TagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to simple application servers, snapshots, custom images, commands, firewall rules, and disks to facilitate the viewing and management of the preceding resources.</para>
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
        /// <para>Adds tags to simple application servers, snapshots, custom images, commands, firewall rules, and disks to facilitate the viewing and management of the preceding resources.</para>
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
        /// <para>Unbinds and deletes tags from specified lightweight resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
                Action = "UntagResources",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds and deletes tags from specified lightweight resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
                Action = "UntagResources",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UntagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds and deletes tags from specified lightweight resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
        /// <para>Unbinds and deletes tags from specified lightweight resources, such as instances, snapshots, disks, images, commands, and firewall rules.</para>
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
        /// <para>Modifys the parameter of a command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCommandAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCommandAttributeResponse
        /// </returns>
        public UpdateCommandAttributeResponse UpdateCommandAttributeWithOptions(UpdateCommandAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingDir))
            {
                query["WorkingDir"] = request.WorkingDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCommandAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateCommandAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateCommandAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifys the parameter of a command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCommandAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCommandAttributeResponse
        /// </returns>
        public async Task<UpdateCommandAttributeResponse> UpdateCommandAttributeWithOptionsAsync(UpdateCommandAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandId))
            {
                query["CommandId"] = request.CommandId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkingDir))
            {
                query["WorkingDir"] = request.WorkingDir;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCommandAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateCommandAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateCommandAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifys the parameter of a command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCommandAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCommandAttributeResponse
        /// </returns>
        public UpdateCommandAttributeResponse UpdateCommandAttribute(UpdateCommandAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCommandAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifys the parameter of a command.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCommandAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCommandAttributeResponse
        /// </returns>
        public async Task<UpdateCommandAttributeResponse> UpdateCommandAttributeAsync(UpdateCommandAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCommandAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks for the data disk that is attached to a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDiskAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDiskAttributeResponse
        /// </returns>
        public UpdateDiskAttributeResponse UpdateDiskAttributeWithOptions(UpdateDiskAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDiskAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateDiskAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateDiskAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks for the data disk that is attached to a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDiskAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDiskAttributeResponse
        /// </returns>
        public async Task<UpdateDiskAttributeResponse> UpdateDiskAttributeWithOptionsAsync(UpdateDiskAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDiskAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateDiskAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateDiskAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks for the data disk that is attached to a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDiskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDiskAttributeResponse
        /// </returns>
        public UpdateDiskAttributeResponse UpdateDiskAttribute(UpdateDiskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDiskAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks for the data disk that is attached to a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDiskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDiskAttributeResponse
        /// </returns>
        public async Task<UpdateDiskAttributeResponse> UpdateDiskAttributeAsync(UpdateDiskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDiskAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a simple application server, including the server name and the password that you use to log on to the server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you change the password of a simple application server, you must restart the server by calling the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation for the new password to take effect.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAttributeResponse
        /// </returns>
        public UpdateInstanceAttributeResponse UpdateInstanceAttributeWithOptions(UpdateInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "UpdateInstanceAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateInstanceAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateInstanceAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a simple application server, including the server name and the password that you use to log on to the server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you change the password of a simple application server, you must restart the server by calling the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation for the new password to take effect.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAttributeResponse
        /// </returns>
        public async Task<UpdateInstanceAttributeResponse> UpdateInstanceAttributeWithOptionsAsync(UpdateInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "UpdateInstanceAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateInstanceAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a simple application server, including the server name and the password that you use to log on to the server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you change the password of a simple application server, you must restart the server by calling the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation for the new password to take effect.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAttributeResponse
        /// </returns>
        public UpdateInstanceAttributeResponse UpdateInstanceAttribute(UpdateInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the information of a simple application server, including the server name and the password that you use to log on to the server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>After you change the password of a simple application server, you must restart the server by calling the <a href="https://help.aliyun.com/document_detail/190443.html">RebootInstance</a> operation for the new password to take effect.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceAttributeResponse
        /// </returns>
        public async Task<UpdateInstanceAttributeResponse> UpdateInstanceAttributeAsync(UpdateInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks of a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSnapshotAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSnapshotAttributeResponse
        /// </returns>
        public UpdateSnapshotAttributeResponse UpdateSnapshotAttributeWithOptions(UpdateSnapshotAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSnapshotAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateSnapshotAttributeResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSnapshotAttributeResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks of a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSnapshotAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSnapshotAttributeResponse
        /// </returns>
        public async Task<UpdateSnapshotAttributeResponse> UpdateSnapshotAttributeWithOptionsAsync(UpdateSnapshotAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSnapshotAttribute",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpdateSnapshotAttributeResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSnapshotAttributeResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks of a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSnapshotAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSnapshotAttributeResponse
        /// </returns>
        public UpdateSnapshotAttributeResponse UpdateSnapshotAttribute(UpdateSnapshotAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSnapshotAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the remarks of a snapshot of a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSnapshotAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSnapshotAttributeResponse
        /// </returns>
        public async Task<UpdateSnapshotAttributeResponse> UpdateSnapshotAttributeAsync(UpdateSnapshotAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSnapshotAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the plan for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The plan of a simple application server can only be upgraded. For more information about plans, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the upgrade fails.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public UpgradeInstanceResponse UpgradeInstanceWithOptions(UpgradeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
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
                Action = "UpgradeInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpgradeInstanceResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpgradeInstanceResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the plan for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The plan of a simple application server can only be upgraded. For more information about plans, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the upgrade fails.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstanceWithOptionsAsync(UpgradeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
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
                Action = "UpgradeInstance",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UpgradeInstanceResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpgradeInstanceResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the plan for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The plan of a simple application server can only be upgraded. For more information about plans, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the upgrade fails.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public UpgradeInstanceResponse UpgradeInstance(UpgradeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the plan for a simple application server.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  The plan of a simple application server can only be upgraded. For more information about plans, see <a href="https://help.aliyun.com/document_detail/58623.html">Billable items</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you call this operation, make sure that the balance in your account is sufficient. If the balance in your account is insufficient, the upgrade fails.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeInstanceResponse
        /// </returns>
        public async Task<UpgradeInstanceResponse> UpgradeInstanceAsync(UpgradeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadInstanceKeyPairResponse
        /// </returns>
        public UploadInstanceKeyPairResponse UploadInstanceKeyPairWithOptions(UploadInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKey))
            {
                query["PublicKey"] = request.PublicKey;
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
                Action = "UploadInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UploadInstanceKeyPairResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UploadInstanceKeyPairResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadInstanceKeyPairRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UploadInstanceKeyPairResponse
        /// </returns>
        public async Task<UploadInstanceKeyPairResponse> UploadInstanceKeyPairWithOptionsAsync(UploadInstanceKeyPairRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPairName))
            {
                query["KeyPairName"] = request.KeyPairName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicKey))
            {
                query["PublicKey"] = request.PublicKey;
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
                Action = "UploadInstanceKeyPair",
                Version = "2020-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            if (AlibabaCloud.TeaUtil.Common.IsUnset(_signatureVersion) || !AlibabaCloud.TeaUtil.Common.EqualString(_signatureVersion, "v4"))
            {
                return TeaModel.ToObject<UploadInstanceKeyPairResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UploadInstanceKeyPairResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadInstanceKeyPairResponse
        /// </returns>
        public UploadInstanceKeyPairResponse UploadInstanceKeyPair(UploadInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadInstanceKeyPairWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Imports a key pair for a simple application server.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UploadInstanceKeyPairRequest
        /// </param>
        /// 
        /// <returns>
        /// UploadInstanceKeyPairResponse
        /// </returns>
        public async Task<UploadInstanceKeyPairResponse> UploadInstanceKeyPairAsync(UploadInstanceKeyPairRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadInstanceKeyPairWithOptionsAsync(request, runtime);
        }

    }
}
