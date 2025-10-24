// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eas20210701.Models;

namespace AlibabaCloud.SDK.Eas20210701
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "pai-eas.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "pai-eas.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "pai-eas.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "pai-eas.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "pai-eas.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "pai-eas.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "pai-eas.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "pai-eas.ap-southeast-5.aliyuncs.com"},
                {"us-east-1", "pai-eas.us-east-1.aliyuncs.com"},
                {"us-west-1", "pai-eas.us-west-1.aliyuncs.com"},
                {"eu-central-1", "pai-eas.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "pai-eas.ap-south-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "pai-eas.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-north-2-gov-1", "pai-eas.cn-north-2-gov-1.aliyuncs.com"},
                {"cn-chengdu", "pai-eas.cn-chengdu.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("eas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Binds a custom domain name to a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AttachGatewayDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachGatewayDomainResponse
        /// </returns>
        public AttachGatewayDomainResponse AttachGatewayDomainWithOptions(string ClusterId, string GatewayId, AttachGatewayDomainRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachGatewayDomainShrinkRequest request = new AttachGatewayDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomDomain))
            {
                request.CustomDomainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomDomain, "CustomDomain", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainShrink))
            {
                query["CustomDomain"] = request.CustomDomainShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachGatewayDomain",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/domain/attach",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachGatewayDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a custom domain name to a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AttachGatewayDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachGatewayDomainResponse
        /// </returns>
        public async Task<AttachGatewayDomainResponse> AttachGatewayDomainWithOptionsAsync(string ClusterId, string GatewayId, AttachGatewayDomainRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachGatewayDomainShrinkRequest request = new AttachGatewayDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomDomain))
            {
                request.CustomDomainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomDomain, "CustomDomain", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainShrink))
            {
                query["CustomDomain"] = request.CustomDomainShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachGatewayDomain",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/domain/attach",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachGatewayDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a custom domain name to a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachGatewayDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachGatewayDomainResponse
        /// </returns>
        public AttachGatewayDomainResponse AttachGatewayDomain(string ClusterId, string GatewayId, AttachGatewayDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachGatewayDomainWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds a custom domain name to a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachGatewayDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachGatewayDomainResponse
        /// </returns>
        public async Task<AttachGatewayDomainResponse> AttachGatewayDomainAsync(string ClusterId, string GatewayId, AttachGatewayDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachGatewayDomainWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a service.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloneServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneServiceResponse
        /// </returns>
        public CloneServiceResponse CloneServiceWithOptions(string ClusterId, string ServiceName, CloneServiceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloneServiceShrinkRequest request = new CloneServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a service.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CloneServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneServiceResponse
        /// </returns>
        public async Task<CloneServiceResponse> CloneServiceWithOptionsAsync(string ClusterId, string ServiceName, CloneServiceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CloneServiceShrinkRequest request = new CloneServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneServiceResponse
        /// </returns>
        public CloneServiceResponse CloneService(string ClusterId, string ServiceName, CloneServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Clones a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneServiceResponse
        /// </returns>
        public async Task<CloneServiceResponse> CloneServiceAsync(string ClusterId, string ServiceName, CloneServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Commits the Worker0 container in the custom container service and deploys the container as a new image.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitServiceResponse
        /// </returns>
        public CommitServiceResponse CommitServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/commit",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Commits the Worker0 container in the custom container service and deploys the container as a new image.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitServiceResponse
        /// </returns>
        public async Task<CommitServiceResponse> CommitServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/commit",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Commits the Worker0 container in the custom container service and deploys the container as a new image.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CommitServiceResponse
        /// </returns>
        public CommitServiceResponse CommitService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CommitServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Commits the Worker0 container in the custom container service and deploys the container as a new image.</para>
        /// </summary>
        /// 
        /// <returns>
        /// CommitServiceResponse
        /// </returns>
        public async Task<CommitServiceResponse> CommitServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CommitServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) for a private gateway. The IP CIDR blocks added to the ACL can access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAclPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclPolicyResponse
        /// </returns>
        public CreateAclPolicyResponse CreateAclPolicyWithOptions(string ClusterId, string GatewayId, CreateAclPolicyRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAclPolicyShrinkRequest request = new CreateAclPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AclPolicyList))
            {
                request.AclPolicyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AclPolicyList, "AclPolicyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPolicyListShrink))
            {
                query["AclPolicyList"] = request.AclPolicyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAclPolicy",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/acl_policy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) for a private gateway. The IP CIDR blocks added to the ACL can access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateAclPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAclPolicyResponse
        /// </returns>
        public async Task<CreateAclPolicyResponse> CreateAclPolicyWithOptionsAsync(string ClusterId, string GatewayId, CreateAclPolicyRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAclPolicyShrinkRequest request = new CreateAclPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AclPolicyList))
            {
                request.AclPolicyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AclPolicyList, "AclPolicyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPolicyListShrink))
            {
                query["AclPolicyList"] = request.AclPolicyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAclPolicy",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/acl_policy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) for a private gateway. The IP CIDR blocks added to the ACL can access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclPolicyResponse
        /// </returns>
        public CreateAclPolicyResponse CreateAclPolicy(string ClusterId, string GatewayId, CreateAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAclPolicyWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an access control list (ACL) for a private gateway. The IP CIDR blocks added to the ACL can access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAclPolicyResponse
        /// </returns>
        public async Task<CreateAclPolicyResponse> CreateAclPolicyAsync(string ClusterId, string GatewayId, CreateAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAclPolicyWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application service to obtain the inference capabilities of large models.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppServiceResponse
        /// </returns>
        public CreateAppServiceResponse CreateAppServiceWithOptions(CreateAppServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSpec))
            {
                body["ServiceSpec"] = request.ServiceSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/app_services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application service to obtain the inference capabilities of large models.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppServiceResponse
        /// </returns>
        public async Task<CreateAppServiceResponse> CreateAppServiceWithOptionsAsync(CreateAppServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                body["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSpec))
            {
                body["ServiceSpec"] = request.ServiceSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/app_services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application service to obtain the inference capabilities of large models.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppServiceResponse
        /// </returns>
        public CreateAppServiceResponse CreateAppService(CreateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAppServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an application service to obtain the inference capabilities of large models.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAppServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppServiceResponse
        /// </returns>
        public async Task<CreateAppServiceResponse> CreateAppServiceAsync(CreateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAppServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBenchmarkTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBenchmarkTaskResponse
        /// </returns>
        public CreateBenchmarkTaskResponse CreateBenchmarkTaskWithOptions(CreateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBenchmarkTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBenchmarkTaskResponse
        /// </returns>
        public async Task<CreateBenchmarkTaskResponse> CreateBenchmarkTaskWithOptionsAsync(CreateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBenchmarkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBenchmarkTaskResponse
        /// </returns>
        public CreateBenchmarkTaskResponse CreateBenchmarkTask(CreateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBenchmarkTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBenchmarkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBenchmarkTaskResponse
        /// </returns>
        public async Task<CreateBenchmarkTaskResponse> CreateBenchmarkTaskAsync(CreateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBenchmarkTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public CreateGatewayResponse CreateGatewayWithOptions(CreateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInternet))
            {
                body["EnableInternet"] = request.EnableInternet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIntranet))
            {
                body["EnableIntranet"] = request.EnableIntranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public async Task<CreateGatewayResponse> CreateGatewayWithOptionsAsync(CreateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInternet))
            {
                body["EnableInternet"] = request.EnableInternet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIntranet))
            {
                body["EnableIntranet"] = request.EnableIntranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                body["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayResponse
        /// </returns>
        public async Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an internal endpoint of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayIntranetLinkedVpcRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcResponse
        /// </returns>
        public CreateGatewayIntranetLinkedVpcResponse CreateGatewayIntranetLinkedVpcWithOptions(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthoritativeDns))
            {
                query["EnableAuthoritativeDns"] = request.EnableAuthoritativeDns;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayIntranetLinkedVpc",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayIntranetLinkedVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an internal endpoint of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayIntranetLinkedVpcRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcResponse
        /// </returns>
        public async Task<CreateGatewayIntranetLinkedVpcResponse> CreateGatewayIntranetLinkedVpcWithOptionsAsync(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAuthoritativeDns))
            {
                query["EnableAuthoritativeDns"] = request.EnableAuthoritativeDns;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayIntranetLinkedVpc",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayIntranetLinkedVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an internal endpoint of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayIntranetLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcResponse
        /// </returns>
        public CreateGatewayIntranetLinkedVpcResponse CreateGatewayIntranetLinkedVpc(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayIntranetLinkedVpcWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an internal endpoint of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayIntranetLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcResponse
        /// </returns>
        public async Task<CreateGatewayIntranetLinkedVpcResponse> CreateGatewayIntranetLinkedVpcAsync(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayIntranetLinkedVpcWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection on an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public CreateGatewayIntranetLinkedVpcPeerResponse CreateGatewayIntranetLinkedVpcPeerWithOptions(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcPeerRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateGatewayIntranetLinkedVpcPeerShrinkRequest request = new CreateGatewayIntranetLinkedVpcPeerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PeerVpcs))
            {
                request.PeerVpcsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PeerVpcs, "PeerVpcs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcsShrink))
            {
                query["PeerVpcs"] = request.PeerVpcsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayIntranetLinkedVpcPeer",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc_peer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayIntranetLinkedVpcPeerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection on an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public async Task<CreateGatewayIntranetLinkedVpcPeerResponse> CreateGatewayIntranetLinkedVpcPeerWithOptionsAsync(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcPeerRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateGatewayIntranetLinkedVpcPeerShrinkRequest request = new CreateGatewayIntranetLinkedVpcPeerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PeerVpcs))
            {
                request.PeerVpcsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PeerVpcs, "PeerVpcs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcsShrink))
            {
                query["PeerVpcs"] = request.PeerVpcsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGatewayIntranetLinkedVpcPeer",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc_peer",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGatewayIntranetLinkedVpcPeerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection on an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public CreateGatewayIntranetLinkedVpcPeerResponse CreateGatewayIntranetLinkedVpcPeer(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayIntranetLinkedVpcPeerWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VPC peering connection on an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public async Task<CreateGatewayIntranetLinkedVpcPeerResponse> CreateGatewayIntranetLinkedVpcPeerAsync(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayIntranetLinkedVpcPeerWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
        public CreateResourceResponse CreateResourceWithOptions(CreateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfManagedResourceOptions))
            {
                body["SelfManagedResourceOptions"] = request.SelfManagedResourceOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskSize))
            {
                body["SystemDiskSize"] = request.SystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["Zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
        public async Task<CreateResourceResponse> CreateResourceWithOptionsAsync(CreateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfManagedResourceOptions))
            {
                body["SelfManagedResourceOptions"] = request.SelfManagedResourceOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskSize))
            {
                body["SystemDiskSize"] = request.SystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["Zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
        public CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a resource group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceResponse
        /// </returns>
        public async Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceInstancesResponse
        /// </returns>
        public CreateResourceInstancesResponse CreateResourceInstancesWithOptions(string ClusterId, string ResourceId, CreateResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskSize))
            {
                body["SystemDiskSize"] = request.SystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["Zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceInstancesResponse
        /// </returns>
        public async Task<CreateResourceInstancesResponse> CreateResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, CreateResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewal))
            {
                body["AutoRenewal"] = request.AutoRenewal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceCount))
            {
                body["EcsInstanceCount"] = request.EcsInstanceCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceType))
            {
                body["EcsInstanceType"] = request.EcsInstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemDiskSize))
            {
                body["SystemDiskSize"] = request.SystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["UserData"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Zone))
            {
                body["Zone"] = request.Zone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceInstancesResponse
        /// </returns>
        public CreateResourceInstancesResponse CreateResourceInstances(string ClusterId, string ResourceId, CreateResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceInstancesResponse
        /// </returns>
        public async Task<CreateResourceInstancesResponse> CreateResourceInstancesAsync(string ClusterId, string ResourceId, CreateResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the LogShipper feature of Log Service for a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceLogResponse
        /// </returns>
        public CreateResourceLogResponse CreateResourceLogWithOptions(string ClusterId, string ResourceId, CreateResourceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                body["LogStore"] = request.LogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the LogShipper feature of Log Service for a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceLogResponse
        /// </returns>
        public async Task<CreateResourceLogResponse> CreateResourceLogWithOptionsAsync(string ClusterId, string ResourceId, CreateResourceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogStore))
            {
                body["LogStore"] = request.LogStore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/log",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the LogShipper feature of Log Service for a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceLogResponse
        /// </returns>
        public CreateResourceLogResponse CreateResourceLog(string ClusterId, string ResourceId, CreateResourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceLogWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the LogShipper feature of Log Service for a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceLogResponse
        /// </returns>
        public async Task<CreateResourceLogResponse> CreateResourceLogAsync(string ClusterId, string ResourceId, CreateResourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceLogWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service in Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateServiceWithOptions(CreateServiceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceShrinkRequest request = new CreateServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Develop))
            {
                query["Develop"] = request.Develop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service in Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceWithOptionsAsync(CreateServiceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateServiceShrinkRequest request = new CreateServiceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Labels))
            {
                request.LabelsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Labels, "Labels", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Develop))
            {
                query["Develop"] = request.Develop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelsShrink))
            {
                query["Labels"] = request.LabelsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service in Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a model service in Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/144261.html">billing</a> of Elastic Algorithm Service (EAS).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceResponse
        /// </returns>
        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Autoscaler feature and creates an Autoscaler controller for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceAutoScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceAutoScalerResponse
        /// </returns>
        public CreateServiceAutoScalerResponse CreateServiceAutoScalerWithOptions(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Behavior))
            {
                body["behavior"] = request.Behavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleStrategies))
            {
                body["scaleStrategies"] = request.ScaleStrategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Autoscaler feature and creates an Autoscaler controller for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceAutoScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceAutoScalerResponse
        /// </returns>
        public async Task<CreateServiceAutoScalerResponse> CreateServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Behavior))
            {
                body["behavior"] = request.Behavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleStrategies))
            {
                body["scaleStrategies"] = request.ScaleStrategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Autoscaler feature and creates an Autoscaler controller for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceAutoScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceAutoScalerResponse
        /// </returns>
        public CreateServiceAutoScalerResponse CreateServiceAutoScaler(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceAutoScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Autoscaler feature and creates an Autoscaler controller for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceAutoScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceAutoScalerResponse
        /// </returns>
        public async Task<CreateServiceAutoScalerResponse> CreateServiceAutoScalerAsync(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceCronScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceCronScalerResponse
        /// </returns>
        public CreateServiceCronScalerResponse CreateServiceCronScalerWithOptions(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceCronScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceCronScalerResponse
        /// </returns>
        public async Task<CreateServiceCronScalerResponse> CreateServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceCronScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceCronScalerResponse
        /// </returns>
        public CreateServiceCronScalerResponse CreateServiceCronScaler(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceCronScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceCronScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceCronScalerResponse
        /// </returns>
        public async Task<CreateServiceCronScalerResponse> CreateServiceCronScalerAsync(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceMirrorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceMirrorResponse
        /// </returns>
        public CreateServiceMirrorResponse CreateServiceMirrorWithOptions(string ClusterId, string ServiceName, CreateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceMirrorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceMirrorResponse
        /// </returns>
        public async Task<CreateServiceMirrorResponse> CreateServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, CreateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceMirrorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceMirrorResponse
        /// </returns>
        public CreateServiceMirrorResponse CreateServiceMirror(string ClusterId, string ServiceName, CreateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceMirrorWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateServiceMirrorRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateServiceMirrorResponse
        /// </returns>
        public async Task<CreateServiceMirrorResponse> CreateServiceMirrorAsync(string ClusterId, string ServiceName, CreateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceMirrorWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualResourceResponse
        /// </returns>
        public CreateVirtualResourceResponse CreateVirtualResourceWithOptions(CreateVirtualResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSpotProtectionPeriod))
            {
                body["DisableSpotProtectionPeriod"] = request.DisableSpotProtectionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceName))
            {
                body["VirtualResourceName"] = request.VirtualResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualResourceResponse
        /// </returns>
        public async Task<CreateVirtualResourceResponse> CreateVirtualResourceWithOptionsAsync(CreateVirtualResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSpotProtectionPeriod))
            {
                body["DisableSpotProtectionPeriod"] = request.DisableSpotProtectionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceName))
            {
                body["VirtualResourceName"] = request.VirtualResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualResourceResponse
        /// </returns>
        public CreateVirtualResourceResponse CreateVirtualResource(CreateVirtualResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVirtualResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualResourceResponse
        /// </returns>
        public async Task<CreateVirtualResourceResponse> CreateVirtualResourceAsync(CreateVirtualResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVirtualResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL) for a private gateway. The IP CIDR block that is deleted from the ACL cannot access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAclPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclPolicyResponse
        /// </returns>
        public DeleteAclPolicyResponse DeleteAclPolicyWithOptions(string ClusterId, string GatewayId, DeleteAclPolicyRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAclPolicyShrinkRequest request = new DeleteAclPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AclPolicyList))
            {
                request.AclPolicyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AclPolicyList, "AclPolicyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPolicyListShrink))
            {
                query["AclPolicyList"] = request.AclPolicyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAclPolicy",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/acl_policy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL) for a private gateway. The IP CIDR block that is deleted from the ACL cannot access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAclPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclPolicyResponse
        /// </returns>
        public async Task<DeleteAclPolicyResponse> DeleteAclPolicyWithOptionsAsync(string ClusterId, string GatewayId, DeleteAclPolicyRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAclPolicyShrinkRequest request = new DeleteAclPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AclPolicyList))
            {
                request.AclPolicyListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AclPolicyList, "AclPolicyList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPolicyListShrink))
            {
                query["AclPolicyList"] = request.AclPolicyListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAclPolicy",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/acl_policy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL) for a private gateway. The IP CIDR block that is deleted from the ACL cannot access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclPolicyResponse
        /// </returns>
        public DeleteAclPolicyResponse DeleteAclPolicy(string ClusterId, string GatewayId, DeleteAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAclPolicyWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an access control list (ACL) for a private gateway. The IP CIDR block that is deleted from the ACL cannot access the private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAclPolicyResponse
        /// </returns>
        public async Task<DeleteAclPolicyResponse> DeleteAclPolicyAsync(string ClusterId, string GatewayId, DeleteAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAclPolicyWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBenchmarkTaskResponse
        /// </returns>
        public DeleteBenchmarkTaskResponse DeleteBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBenchmarkTaskResponse
        /// </returns>
        public async Task<DeleteBenchmarkTaskResponse> DeleteBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteBenchmarkTaskResponse
        /// </returns>
        public DeleteBenchmarkTaskResponse DeleteBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteBenchmarkTaskResponse
        /// </returns>
        public async Task<DeleteBenchmarkTaskResponse> DeleteBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public DeleteGatewayResponse DeleteGatewayWithOptions(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public async Task<DeleteGatewayResponse> DeleteGatewayWithOptionsAsync(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public DeleteGatewayResponse DeleteGateway(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGatewayResponse
        /// </returns>
        public async Task<DeleteGatewayResponse> DeleteGatewayAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关内网访问端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayIntranetLinkedVpcRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcResponse
        /// </returns>
        public DeleteGatewayIntranetLinkedVpcResponse DeleteGatewayIntranetLinkedVpcWithOptions(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayIntranetLinkedVpc",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayIntranetLinkedVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关内网访问端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayIntranetLinkedVpcRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcResponse
        /// </returns>
        public async Task<DeleteGatewayIntranetLinkedVpcResponse> DeleteGatewayIntranetLinkedVpcWithOptionsAsync(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayIntranetLinkedVpc",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayIntranetLinkedVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关内网访问端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayIntranetLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcResponse
        /// </returns>
        public DeleteGatewayIntranetLinkedVpcResponse DeleteGatewayIntranetLinkedVpc(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayIntranetLinkedVpcWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除网关内网访问端点</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayIntranetLinkedVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcResponse
        /// </returns>
        public async Task<DeleteGatewayIntranetLinkedVpcResponse> DeleteGatewayIntranetLinkedVpcAsync(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayIntranetLinkedVpcWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection from an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public DeleteGatewayIntranetLinkedVpcPeerResponse DeleteGatewayIntranetLinkedVpcPeerWithOptions(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcPeerRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteGatewayIntranetLinkedVpcPeerShrinkRequest request = new DeleteGatewayIntranetLinkedVpcPeerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PeerVpcs))
            {
                request.PeerVpcsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PeerVpcs, "PeerVpcs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcsShrink))
            {
                query["PeerVpcs"] = request.PeerVpcsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayIntranetLinkedVpcPeer",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc_peer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayIntranetLinkedVpcPeerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection from an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public async Task<DeleteGatewayIntranetLinkedVpcPeerResponse> DeleteGatewayIntranetLinkedVpcPeerWithOptionsAsync(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcPeerRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteGatewayIntranetLinkedVpcPeerShrinkRequest request = new DeleteGatewayIntranetLinkedVpcPeerShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PeerVpcs))
            {
                request.PeerVpcsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PeerVpcs, "PeerVpcs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeerVpcsShrink))
            {
                query["PeerVpcs"] = request.PeerVpcsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGatewayIntranetLinkedVpcPeer",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc_peer",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGatewayIntranetLinkedVpcPeerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection from an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public DeleteGatewayIntranetLinkedVpcPeerResponse DeleteGatewayIntranetLinkedVpcPeer(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayIntranetLinkedVpcPeerWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a VPC peering connection from an internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public async Task<DeleteGatewayIntranetLinkedVpcPeerResponse> DeleteGatewayIntranetLinkedVpcPeerAsync(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayIntranetLinkedVpcPeerWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public DeleteResourceResponse DeleteResourceWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public async Task<DeleteResourceResponse> DeleteResourceWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public DeleteResourceResponse DeleteResource(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceResponse
        /// </returns>
        public async Task<DeleteResourceResponse> DeleteResourceAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceDLinkResponse
        /// </returns>
        public DeleteResourceDLinkResponse DeleteResourceDLinkWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/dlink",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceDLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceDLinkResponse
        /// </returns>
        public async Task<DeleteResourceDLinkResponse> DeleteResourceDLinkWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/dlink",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceDLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceDLinkResponse
        /// </returns>
        public DeleteResourceDLinkResponse DeleteResourceDLink(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceDLinkWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceDLinkResponse
        /// </returns>
        public async Task<DeleteResourceDLinkResponse> DeleteResourceDLinkAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceDLinkWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the tags of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteResourceInstanceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstanceLabelResponse
        /// </returns>
        public DeleteResourceInstanceLabelResponse DeleteResourceInstanceLabelWithOptions(string ClusterId, string ResourceId, DeleteResourceInstanceLabelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteResourceInstanceLabelShrinkRequest request = new DeleteResourceInstanceLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllInstances))
            {
                query["AllInstances"] = request.AllInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceInstanceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/label",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceInstanceLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the tags of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteResourceInstanceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstanceLabelResponse
        /// </returns>
        public async Task<DeleteResourceInstanceLabelResponse> DeleteResourceInstanceLabelWithOptionsAsync(string ClusterId, string ResourceId, DeleteResourceInstanceLabelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteResourceInstanceLabelShrinkRequest request = new DeleteResourceInstanceLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllInstances))
            {
                query["AllInstances"] = request.AllInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceInstanceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/label",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceInstanceLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the tags of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceInstanceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstanceLabelResponse
        /// </returns>
        public DeleteResourceInstanceLabelResponse DeleteResourceInstanceLabel(string ClusterId, string ResourceId, DeleteResourceInstanceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceInstanceLabelWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the tags of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceInstanceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstanceLabelResponse
        /// </returns>
        public async Task<DeleteResourceInstanceLabelResponse> DeleteResourceInstanceLabelAsync(string ClusterId, string ResourceId, DeleteResourceInstanceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceInstanceLabelWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstancesResponse
        /// </returns>
        public DeleteResourceInstancesResponse DeleteResourceInstancesWithOptions(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllFailed))
            {
                query["AllFailed"] = request.AllFailed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstancesResponse
        /// </returns>
        public async Task<DeleteResourceInstancesResponse> DeleteResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllFailed))
            {
                query["AllFailed"] = request.AllFailed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstancesResponse
        /// </returns>
        public DeleteResourceInstancesResponse DeleteResourceInstances(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteResourceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceInstancesResponse
        /// </returns>
        public async Task<DeleteResourceInstancesResponse> DeleteResourceInstancesAsync(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the LogShipper feature of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceLogResponse
        /// </returns>
        public DeleteResourceLogResponse DeleteResourceLogWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/log",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the LogShipper feature of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceLogResponse
        /// </returns>
        public async Task<DeleteResourceLogResponse> DeleteResourceLogWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/log",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the LogShipper feature of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceLogResponse
        /// </returns>
        public DeleteResourceLogResponse DeleteResourceLog(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceLogWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the LogShipper feature of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceLogResponse
        /// </returns>
        public async Task<DeleteResourceLogResponse> DeleteResourceLogAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceLogWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public DeleteServiceResponse DeleteService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceResponse
        /// </returns>
        public async Task<DeleteServiceResponse> DeleteServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceAutoScalerResponse
        /// </returns>
        public DeleteServiceAutoScalerResponse DeleteServiceAutoScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceAutoScalerResponse
        /// </returns>
        public async Task<DeleteServiceAutoScalerResponse> DeleteServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceAutoScalerResponse
        /// </returns>
        public DeleteServiceAutoScalerResponse DeleteServiceAutoScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceAutoScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceAutoScalerResponse
        /// </returns>
        public async Task<DeleteServiceAutoScalerResponse> DeleteServiceAutoScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the Cronscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceCronScalerResponse
        /// </returns>
        public DeleteServiceCronScalerResponse DeleteServiceCronScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the Cronscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceCronScalerResponse
        /// </returns>
        public async Task<DeleteServiceCronScalerResponse> DeleteServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the Cronscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceCronScalerResponse
        /// </returns>
        public DeleteServiceCronScalerResponse DeleteServiceCronScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceCronScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the Cronscaler feature for a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceCronScalerResponse
        /// </returns>
        public async Task<DeleteServiceCronScalerResponse> DeleteServiceCronScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceInstancesResponse
        /// </returns>
        public DeleteServiceInstancesResponse DeleteServiceInstancesWithOptions(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Container))
            {
                query["Container"] = request.Container;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftRestart))
            {
                query["SoftRestart"] = request.SoftRestart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceInstancesResponse
        /// </returns>
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesWithOptionsAsync(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Container))
            {
                query["Container"] = request.Container;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceList))
            {
                query["InstanceList"] = request.InstanceList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SoftRestart))
            {
                query["SoftRestart"] = request.SoftRestart;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceInstancesResponse
        /// </returns>
        public DeleteServiceInstancesResponse DeleteServiceInstances(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceInstancesWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts the instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceInstancesResponse
        /// </returns>
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesAsync(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceInstancesWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteServiceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceLabelResponse
        /// </returns>
        public DeleteServiceLabelResponse DeleteServiceLabelWithOptions(string ClusterId, string ServiceName, DeleteServiceLabelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteServiceLabelShrinkRequest request = new DeleteServiceLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/label",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteServiceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceLabelResponse
        /// </returns>
        public async Task<DeleteServiceLabelResponse> DeleteServiceLabelWithOptionsAsync(string ClusterId, string ServiceName, DeleteServiceLabelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteServiceLabelShrinkRequest request = new DeleteServiceLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/label",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceLabelResponse
        /// </returns>
        public DeleteServiceLabelResponse DeleteServiceLabel(string ClusterId, string ServiceName, DeleteServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceLabelWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteServiceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceLabelResponse
        /// </returns>
        public async Task<DeleteServiceLabelResponse> DeleteServiceLabelAsync(string ClusterId, string ServiceName, DeleteServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceLabelWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the traffic mirroring feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceMirrorResponse
        /// </returns>
        public DeleteServiceMirrorResponse DeleteServiceMirrorWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the traffic mirroring feature for a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteServiceMirrorResponse
        /// </returns>
        public async Task<DeleteServiceMirrorResponse> DeleteServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the traffic mirroring feature for a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceMirrorResponse
        /// </returns>
        public DeleteServiceMirrorResponse DeleteServiceMirror(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceMirrorWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the traffic mirroring feature for a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteServiceMirrorResponse
        /// </returns>
        public async Task<DeleteServiceMirrorResponse> DeleteServiceMirrorAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceMirrorWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualResourceResponse
        /// </returns>
        public DeleteVirtualResourceResponse DeleteVirtualResourceWithOptions(string ClusterId, string VirtualResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VirtualResourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualResourceResponse
        /// </returns>
        public async Task<DeleteVirtualResourceResponse> DeleteVirtualResourceWithOptionsAsync(string ClusterId, string VirtualResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VirtualResourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteVirtualResourceResponse
        /// </returns>
        public DeleteVirtualResourceResponse DeleteVirtualResource(string ClusterId, string VirtualResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVirtualResourceWithOptions(ClusterId, VirtualResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual resource group that contains no resources or instances.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteVirtualResourceResponse
        /// </returns>
        public async Task<DeleteVirtualResourceResponse> DeleteVirtualResourceAsync(string ClusterId, string VirtualResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVirtualResourceWithOptionsAsync(ClusterId, VirtualResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskResponse
        /// </returns>
        public DescribeBenchmarkTaskResponse DescribeBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskResponse
        /// </returns>
        public async Task<DescribeBenchmarkTaskResponse> DescribeBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskResponse
        /// </returns>
        public DescribeBenchmarkTaskResponse DescribeBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the configurations of a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskResponse
        /// </returns>
        public async Task<DescribeBenchmarkTaskResponse> DescribeBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the report of a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBenchmarkTaskReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskReportResponse
        /// </returns>
        public DescribeBenchmarkTaskReportResponse DescribeBenchmarkTaskReportWithOptions(string ClusterId, string TaskName, DescribeBenchmarkTaskReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTaskReport",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName) + "/report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the report of a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBenchmarkTaskReportRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskReportResponse
        /// </returns>
        public async Task<DescribeBenchmarkTaskReportResponse> DescribeBenchmarkTaskReportWithOptionsAsync(string ClusterId, string TaskName, DescribeBenchmarkTaskReportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBenchmarkTaskReport",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName) + "/report",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBenchmarkTaskReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the report of a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBenchmarkTaskReportRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskReportResponse
        /// </returns>
        public DescribeBenchmarkTaskReportResponse DescribeBenchmarkTaskReport(string ClusterId, string TaskName, DescribeBenchmarkTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBenchmarkTaskReportWithOptions(ClusterId, TaskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the report of a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBenchmarkTaskReportRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBenchmarkTaskReportResponse
        /// </returns>
        public async Task<DescribeBenchmarkTaskReportResponse> DescribeBenchmarkTaskReportAsync(string ClusterId, string TaskName, DescribeBenchmarkTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBenchmarkTaskReportWithOptionsAsync(ClusterId, TaskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGatewayResponse
        /// </returns>
        public DescribeGatewayResponse DescribeGatewayWithOptions(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGatewayResponse
        /// </returns>
        public async Task<DescribeGatewayResponse> DescribeGatewayWithOptionsAsync(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeGatewayResponse
        /// </returns>
        public DescribeGatewayResponse DescribeGateway(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGatewayWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeGatewayResponse
        /// </returns>
        public async Task<DescribeGatewayResponse> DescribeGatewayAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGatewayWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a service group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupResponse
        /// </returns>
        public DescribeGroupResponse DescribeGroupWithOptions(string ClusterId, string GroupName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroup",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a service group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupResponse
        /// </returns>
        public async Task<DescribeGroupResponse> DescribeGroupWithOptionsAsync(string ClusterId, string GroupName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroup",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a service group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeGroupResponse
        /// </returns>
        public DescribeGroupResponse DescribeGroup(string ClusterId, string GroupName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGroupWithOptions(ClusterId, GroupName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a service group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeGroupResponse
        /// </returns>
        public async Task<DescribeGroupResponse> DescribeGroupAsync(string ClusterId, string GroupName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGroupWithOptionsAsync(ClusterId, GroupName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of endpoints of service groups.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupEndpointsResponse
        /// </returns>
        public DescribeGroupEndpointsResponse DescribeGroupEndpointsWithOptions(string ClusterId, string GroupName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroupEndpoints",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupName) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of endpoints of service groups.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGroupEndpointsResponse
        /// </returns>
        public async Task<DescribeGroupEndpointsResponse> DescribeGroupEndpointsWithOptionsAsync(string ClusterId, string GroupName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGroupEndpoints",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupName) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGroupEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of endpoints of service groups.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeGroupEndpointsResponse
        /// </returns>
        public DescribeGroupEndpointsResponse DescribeGroupEndpoints(string ClusterId, string GroupName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGroupEndpointsWithOptions(ClusterId, GroupName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of endpoints of service groups.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeGroupEndpointsResponse
        /// </returns>
        public async Task<DescribeGroupEndpointsResponse> DescribeGroupEndpointsAsync(string ClusterId, string GroupName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGroupEndpointsWithOptionsAsync(ClusterId, GroupName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instance types for an available instance in a shared resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeMachineSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMachineSpecResponse
        /// </returns>
        public DescribeMachineSpecResponse DescribeMachineSpecWithOptions(DescribeMachineSpecRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMachineSpecShrinkRequest request = new DescribeMachineSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceTypes))
            {
                request.InstanceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceTypes, "InstanceTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypesShrink))
            {
                query["InstanceTypes"] = request.InstanceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMachineSpec",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/public/instance_types",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMachineSpecResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instance types for an available instance in a shared resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeMachineSpecRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMachineSpecResponse
        /// </returns>
        public async Task<DescribeMachineSpecResponse> DescribeMachineSpecWithOptionsAsync(DescribeMachineSpecRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMachineSpecShrinkRequest request = new DescribeMachineSpecShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceTypes))
            {
                request.InstanceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceTypes, "InstanceTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceTypesShrink))
            {
                query["InstanceTypes"] = request.InstanceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMachineSpec",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/public/instance_types",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMachineSpecResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instance types for an available instance in a shared resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMachineSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMachineSpecResponse
        /// </returns>
        public DescribeMachineSpecResponse DescribeMachineSpec(DescribeMachineSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeMachineSpecWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instance types for an available instance in a shared resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeMachineSpecRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMachineSpecResponse
        /// </returns>
        public async Task<DescribeMachineSpecResponse> DescribeMachineSpecAsync(DescribeMachineSpecRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeMachineSpecWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceResponse
        /// </returns>
        public DescribeResourceResponse DescribeResourceWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceResponse
        /// </returns>
        public async Task<DescribeResourceResponse> DescribeResourceWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeResourceResponse
        /// </returns>
        public DescribeResourceResponse DescribeResource(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeResourceResponse
        /// </returns>
        public async Task<DescribeResourceResponse> DescribeResourceAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceDLinkResponse
        /// </returns>
        public DescribeResourceDLinkResponse DescribeResourceDLinkWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/dlink",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceDLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceDLinkResponse
        /// </returns>
        public async Task<DescribeResourceDLinkResponse> DescribeResourceDLinkWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/dlink",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceDLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeResourceDLinkResponse
        /// </returns>
        public DescribeResourceDLinkResponse DescribeResourceDLink(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceDLinkWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeResourceDLinkResponse
        /// </returns>
        public async Task<DescribeResourceDLinkResponse> DescribeResourceDLinkAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceDLinkWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceLogResponse
        /// </returns>
        public DescribeResourceLogResponse DescribeResourceLogWithOptions(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeResourceLogResponse
        /// </returns>
        public async Task<DescribeResourceLogResponse> DescribeResourceLogWithOptionsAsync(string ClusterId, string ResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeResourceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeResourceLogResponse
        /// </returns>
        public DescribeResourceLogResponse DescribeResourceLog(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceLogWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeResourceLogResponse
        /// </returns>
        public async Task<DescribeResourceLogResponse> DescribeResourceLogAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceLogWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceResponse
        /// </returns>
        public DescribeServiceResponse DescribeServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceResponse
        /// </returns>
        public async Task<DescribeServiceResponse> DescribeServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceResponse
        /// </returns>
        public DescribeServiceResponse DescribeService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceResponse
        /// </returns>
        public async Task<DescribeServiceResponse> DescribeServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceAutoScalerResponse
        /// </returns>
        public DescribeServiceAutoScalerResponse DescribeServiceAutoScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceAutoScalerResponse
        /// </returns>
        public async Task<DescribeServiceAutoScalerResponse> DescribeServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceAutoScalerResponse
        /// </returns>
        public DescribeServiceAutoScalerResponse DescribeServiceAutoScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceAutoScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceAutoScalerResponse
        /// </returns>
        public async Task<DescribeServiceAutoScalerResponse> DescribeServiceAutoScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceCronScalerResponse
        /// </returns>
        public DescribeServiceCronScalerResponse DescribeServiceCronScalerWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceCronScalerResponse
        /// </returns>
        public async Task<DescribeServiceCronScalerResponse> DescribeServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceCronScalerResponse
        /// </returns>
        public DescribeServiceCronScalerResponse DescribeServiceCronScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceCronScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceCronScalerResponse
        /// </returns>
        public async Task<DescribeServiceCronScalerResponse> DescribeServiceCronScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceDiagnosisResponse
        /// </returns>
        public DescribeServiceDiagnosisResponse DescribeServiceDiagnosisWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceDiagnosis",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/diagnosis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceDiagnosisResponse
        /// </returns>
        public async Task<DescribeServiceDiagnosisResponse> DescribeServiceDiagnosisWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceDiagnosis",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/diagnosis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceDiagnosisResponse
        /// </returns>
        public DescribeServiceDiagnosisResponse DescribeServiceDiagnosis(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceDiagnosisWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceDiagnosisResponse
        /// </returns>
        public async Task<DescribeServiceDiagnosisResponse> DescribeServiceDiagnosisAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceDiagnosisWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of service endpoints.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceEndpointsResponse
        /// </returns>
        public DescribeServiceEndpointsResponse DescribeServiceEndpointsWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceEndpoints",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of service endpoints.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceEndpointsResponse
        /// </returns>
        public async Task<DescribeServiceEndpointsResponse> DescribeServiceEndpointsWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceEndpoints",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/endpoints",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of service endpoints.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceEndpointsResponse
        /// </returns>
        public DescribeServiceEndpointsResponse DescribeServiceEndpoints(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceEndpointsWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of service endpoints.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceEndpointsResponse
        /// </returns>
        public async Task<DescribeServiceEndpointsResponse> DescribeServiceEndpointsAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceEndpointsWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about recent service deployment events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceEventRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceEventResponse
        /// </returns>
        public DescribeServiceEventResponse DescribeServiceEventWithOptions(string ClusterId, string ServiceName, DescribeServiceEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceEvent",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about recent service deployment events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceEventRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceEventResponse
        /// </returns>
        public async Task<DescribeServiceEventResponse> DescribeServiceEventWithOptionsAsync(string ClusterId, string ServiceName, DescribeServiceEventRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceEvent",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about recent service deployment events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceEventResponse
        /// </returns>
        public DescribeServiceEventResponse DescribeServiceEvent(string ClusterId, string ServiceName, DescribeServiceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceEventWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about recent service deployment events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceEventRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceEventResponse
        /// </returns>
        public async Task<DescribeServiceEventResponse> DescribeServiceEventAsync(string ClusterId, string ServiceName, DescribeServiceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceEventWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceInstanceDiagnosisResponse
        /// </returns>
        public DescribeServiceInstanceDiagnosisResponse DescribeServiceInstanceDiagnosisWithOptions(string ClusterId, string ServiceName, string InstanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceInstanceDiagnosis",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName) + "/diagnosis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceInstanceDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceInstanceDiagnosisResponse
        /// </returns>
        public async Task<DescribeServiceInstanceDiagnosisResponse> DescribeServiceInstanceDiagnosisWithOptionsAsync(string ClusterId, string ServiceName, string InstanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceInstanceDiagnosis",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName) + "/diagnosis",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceInstanceDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceInstanceDiagnosisResponse
        /// </returns>
        public DescribeServiceInstanceDiagnosisResponse DescribeServiceInstanceDiagnosis(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceInstanceDiagnosisWithOptions(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceInstanceDiagnosisResponse
        /// </returns>
        public async Task<DescribeServiceInstanceDiagnosisResponse> DescribeServiceInstanceDiagnosisAsync(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceInstanceDiagnosisWithOptionsAsync(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the logs of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLogResponse
        /// </returns>
        public DescribeServiceLogResponse DescribeServiceLogWithOptions(string ClusterId, string ServiceName, DescribeServiceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Previous))
            {
                query["Previous"] = request.Previous;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the logs of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLogResponse
        /// </returns>
        public async Task<DescribeServiceLogResponse> DescribeServiceLogWithOptionsAsync(string ClusterId, string ServiceName, DescribeServiceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["Keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Previous))
            {
                query["Previous"] = request.Previous;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceLog",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the logs of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLogResponse
        /// </returns>
        public DescribeServiceLogResponse DescribeServiceLog(string ClusterId, string ServiceName, DescribeServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceLogWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the logs of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceLogResponse
        /// </returns>
        public async Task<DescribeServiceLogResponse> DescribeServiceLogAsync(string ClusterId, string ServiceName, DescribeServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceLogWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the traffic mirroring settings of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceMirrorResponse
        /// </returns>
        public DescribeServiceMirrorResponse DescribeServiceMirrorWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the traffic mirroring settings of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceMirrorResponse
        /// </returns>
        public async Task<DescribeServiceMirrorResponse> DescribeServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the traffic mirroring settings of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceMirrorResponse
        /// </returns>
        public DescribeServiceMirrorResponse DescribeServiceMirror(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceMirrorWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries details about the traffic mirroring settings of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeServiceMirrorResponse
        /// </returns>
        public async Task<DescribeServiceMirrorResponse> DescribeServiceMirrorAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceMirrorWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the logon-free URL of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceSignedUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceSignedUrlResponse
        /// </returns>
        public DescribeServiceSignedUrlResponse DescribeServiceSignedUrlWithOptions(string ClusterId, string ServiceName, DescribeServiceSignedUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expire))
            {
                query["Expire"] = request.Expire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internal))
            {
                query["Internal"] = request.Internal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceSignedUrl",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/signed_url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceSignedUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the logon-free URL of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceSignedUrlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceSignedUrlResponse
        /// </returns>
        public async Task<DescribeServiceSignedUrlResponse> DescribeServiceSignedUrlWithOptionsAsync(string ClusterId, string ServiceName, DescribeServiceSignedUrlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expire))
            {
                query["Expire"] = request.Expire;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internal))
            {
                query["Internal"] = request.Internal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeServiceSignedUrl",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/signed_url",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeServiceSignedUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the logon-free URL of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceSignedUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceSignedUrlResponse
        /// </returns>
        public DescribeServiceSignedUrlResponse DescribeServiceSignedUrl(string ClusterId, string ServiceName, DescribeServiceSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceSignedUrlWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the logon-free URL of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeServiceSignedUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeServiceSignedUrlResponse
        /// </returns>
        public async Task<DescribeServiceSignedUrlResponse> DescribeServiceSignedUrlAsync(string ClusterId, string ServiceName, DescribeServiceSignedUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceSignedUrlWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpotDiscountHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpotDiscountHistoryResponse
        /// </returns>
        public DescribeSpotDiscountHistoryResponse DescribeSpotDiscountHistoryWithOptions(DescribeSpotDiscountHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProtect))
            {
                query["IsProtect"] = request.IsProtect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSpotDiscountHistory",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/public/spot_discount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSpotDiscountHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpotDiscountHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpotDiscountHistoryResponse
        /// </returns>
        public async Task<DescribeSpotDiscountHistoryResponse> DescribeSpotDiscountHistoryWithOptionsAsync(DescribeSpotDiscountHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsProtect))
            {
                query["IsProtect"] = request.IsProtect;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSpotDiscountHistory",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/public/spot_discount",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSpotDiscountHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpotDiscountHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpotDiscountHistoryResponse
        /// </returns>
        public DescribeSpotDiscountHistoryResponse DescribeSpotDiscountHistory(DescribeSpotDiscountHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSpotDiscountHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSpotDiscountHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSpotDiscountHistoryResponse
        /// </returns>
        public async Task<DescribeSpotDiscountHistoryResponse> DescribeSpotDiscountHistoryAsync(DescribeSpotDiscountHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSpotDiscountHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the details of a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVirtualResourceResponse
        /// </returns>
        public DescribeVirtualResourceResponse DescribeVirtualResourceWithOptions(string ClusterId, string VirtualResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VirtualResourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVirtualResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the details of a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVirtualResourceResponse
        /// </returns>
        public async Task<DescribeVirtualResourceResponse> DescribeVirtualResourceWithOptionsAsync(string ClusterId, string VirtualResourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VirtualResourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVirtualResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the details of a virtual resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeVirtualResourceResponse
        /// </returns>
        public DescribeVirtualResourceResponse DescribeVirtualResource(string ClusterId, string VirtualResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeVirtualResourceWithOptions(ClusterId, VirtualResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the details of a virtual resource group.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeVirtualResourceResponse
        /// </returns>
        public async Task<DescribeVirtualResourceResponse> DescribeVirtualResourceAsync(string ClusterId, string VirtualResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeVirtualResourceWithOptionsAsync(ClusterId, VirtualResourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a custom domain name from a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetachGatewayDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachGatewayDomainResponse
        /// </returns>
        public DetachGatewayDomainResponse DetachGatewayDomainWithOptions(string ClusterId, string GatewayId, DetachGatewayDomainRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachGatewayDomainShrinkRequest request = new DetachGatewayDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomDomain))
            {
                request.CustomDomainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomDomain, "CustomDomain", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainShrink))
            {
                query["CustomDomain"] = request.CustomDomainShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachGatewayDomain",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/domain/detach",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachGatewayDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a custom domain name from a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetachGatewayDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachGatewayDomainResponse
        /// </returns>
        public async Task<DetachGatewayDomainResponse> DetachGatewayDomainWithOptionsAsync(string ClusterId, string GatewayId, DetachGatewayDomainRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachGatewayDomainShrinkRequest request = new DetachGatewayDomainShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CustomDomain))
            {
                request.CustomDomainShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CustomDomain, "CustomDomain", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomDomainShrink))
            {
                query["CustomDomain"] = request.CustomDomainShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachGatewayDomain",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/domain/detach",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachGatewayDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a custom domain name from a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachGatewayDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachGatewayDomainResponse
        /// </returns>
        public DetachGatewayDomainResponse DetachGatewayDomain(string ClusterId, string GatewayId, DetachGatewayDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DetachGatewayDomainWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unbinds a custom domain name from a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachGatewayDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachGatewayDomainResponse
        /// </returns>
        public async Task<DetachGatewayDomainResponse> DetachGatewayDomainAsync(string ClusterId, string GatewayId, DetachGatewayDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DetachGatewayDomainWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches a container service to development mode or exits development mode.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DevelopServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DevelopServiceResponse
        /// </returns>
        public DevelopServiceResponse DevelopServiceWithOptions(string ClusterId, string ServiceName, DevelopServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exit))
            {
                query["Exit"] = request.Exit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DevelopService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/develop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DevelopServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches a container service to development mode or exits development mode.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DevelopServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DevelopServiceResponse
        /// </returns>
        public async Task<DevelopServiceResponse> DevelopServiceWithOptionsAsync(string ClusterId, string ServiceName, DevelopServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exit))
            {
                query["Exit"] = request.Exit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DevelopService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/develop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DevelopServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches a container service to development mode or exits development mode.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DevelopServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DevelopServiceResponse
        /// </returns>
        public DevelopServiceResponse DevelopService(string ClusterId, string ServiceName, DevelopServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DevelopServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switches a container service to development mode or exits development mode.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DevelopServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DevelopServiceResponse
        /// </returns>
        public async Task<DevelopServiceResponse> DevelopServiceAsync(string ClusterId, string ServiceName, DevelopServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DevelopServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs) created for a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclPolicyResponse
        /// </returns>
        public ListAclPolicyResponse ListAclPolicyWithOptions(string ClusterId, string GatewayId, ListAclPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAclPolicy",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/acl_policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs) created for a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAclPolicyResponse
        /// </returns>
        public async Task<ListAclPolicyResponse> ListAclPolicyWithOptionsAsync(string ClusterId, string GatewayId, ListAclPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAclPolicy",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/acl_policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAclPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs) created for a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclPolicyResponse
        /// </returns>
        public ListAclPolicyResponse ListAclPolicy(string ClusterId, string GatewayId, ListAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAclPolicyWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries access control lists (ACLs) created for a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAclPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAclPolicyResponse
        /// </returns>
        public async Task<ListAclPolicyResponse> ListAclPolicyAsync(string ClusterId, string GatewayId, ListAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAclPolicyWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of stress testing tasks that are created by the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenchmarkTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBenchmarkTaskResponse
        /// </returns>
        public ListBenchmarkTaskResponse ListBenchmarkTaskWithOptions(ListBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestMethod))
            {
                query["RequestMethod"] = request.RequestMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of stress testing tasks that are created by the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenchmarkTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBenchmarkTaskResponse
        /// </returns>
        public async Task<ListBenchmarkTaskResponse> ListBenchmarkTaskWithOptionsAsync(ListBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelId))
            {
                query["ModelId"] = request.ModelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestMethod))
            {
                query["RequestMethod"] = request.RequestMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of stress testing tasks that are created by the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenchmarkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBenchmarkTaskResponse
        /// </returns>
        public ListBenchmarkTaskResponse ListBenchmarkTask(ListBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBenchmarkTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of stress testing tasks that are created by the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBenchmarkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBenchmarkTaskResponse
        /// </returns>
        public async Task<ListBenchmarkTaskResponse> ListBenchmarkTaskAsync(ListBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBenchmarkTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public ListGatewayResponse ListGatewayWithOptions(ListGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetEnabled))
            {
                query["InternetEnabled"] = request.InternetEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public async Task<ListGatewayResponse> ListGatewayWithOptionsAsync(ListGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayType))
            {
                query["GatewayType"] = request.GatewayType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetEnabled))
            {
                query["InternetEnabled"] = request.InternetEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public ListGatewayResponse ListGateway(ListGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of private gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayResponse
        /// </returns>
        public async Task<ListGatewayResponse> ListGatewayAsync(ListGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of custom domain names of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayDomainsResponse
        /// </returns>
        public ListGatewayDomainsResponse ListGatewayDomainsWithOptions(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayDomains",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of custom domain names of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayDomainsResponse
        /// </returns>
        public async Task<ListGatewayDomainsResponse> ListGatewayDomainsWithOptionsAsync(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayDomains",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of custom domain names of a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayDomainsResponse
        /// </returns>
        public ListGatewayDomainsResponse ListGatewayDomains(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayDomainsWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of custom domain names of a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayDomainsResponse
        /// </returns>
        public async Task<ListGatewayDomainsResponse> ListGatewayDomainsAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayDomainsWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the internal endpoints of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcResponse
        /// </returns>
        public ListGatewayIntranetLinkedVpcResponse ListGatewayIntranetLinkedVpcWithOptions(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayIntranetLinkedVpc",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayIntranetLinkedVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the internal endpoints of a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcResponse
        /// </returns>
        public async Task<ListGatewayIntranetLinkedVpcResponse> ListGatewayIntranetLinkedVpcWithOptionsAsync(string ClusterId, string GatewayId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayIntranetLinkedVpc",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayIntranetLinkedVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the internal endpoints of a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcResponse
        /// </returns>
        public ListGatewayIntranetLinkedVpcResponse ListGatewayIntranetLinkedVpc(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayIntranetLinkedVpcWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of the internal endpoints of a private gateway.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcResponse
        /// </returns>
        public async Task<ListGatewayIntranetLinkedVpcResponse> ListGatewayIntranetLinkedVpcAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayIntranetLinkedVpcWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of all VPC peering connections on internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public ListGatewayIntranetLinkedVpcPeerResponse ListGatewayIntranetLinkedVpcPeerWithOptions(string ClusterId, string GatewayId, ListGatewayIntranetLinkedVpcPeerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayIntranetLinkedVpcPeer",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc_peer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayIntranetLinkedVpcPeerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of all VPC peering connections on internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public async Task<ListGatewayIntranetLinkedVpcPeerResponse> ListGatewayIntranetLinkedVpcPeerWithOptionsAsync(string ClusterId, string GatewayId, ListGatewayIntranetLinkedVpcPeerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayIntranetLinkedVpcPeer",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_endpoint_linked_vpc_peer",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayIntranetLinkedVpcPeerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of all VPC peering connections on internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public ListGatewayIntranetLinkedVpcPeerResponse ListGatewayIntranetLinkedVpcPeer(string ClusterId, string GatewayId, ListGatewayIntranetLinkedVpcPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayIntranetLinkedVpcPeerWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains a list of all VPC peering connections on internal endpoint of a gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGatewayIntranetLinkedVpcPeerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetLinkedVpcPeerResponse
        /// </returns>
        public async Task<ListGatewayIntranetLinkedVpcPeerResponse> ListGatewayIntranetLinkedVpcPeerAsync(string ClusterId, string GatewayId, ListGatewayIntranetLinkedVpcPeerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayIntranetLinkedVpcPeerWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the zones supported by a gateway within an intranet.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetSupportedZoneResponse
        /// </returns>
        public ListGatewayIntranetSupportedZoneResponse ListGatewayIntranetSupportedZoneWithOptions(string GatewayId, string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayIntranetSupportedZone",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_supported_zone",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayIntranetSupportedZoneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the zones supported by a gateway within an intranet.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGatewayIntranetSupportedZoneResponse
        /// </returns>
        public async Task<ListGatewayIntranetSupportedZoneResponse> ListGatewayIntranetSupportedZoneWithOptionsAsync(string GatewayId, string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGatewayIntranetSupportedZone",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId) + "/intranet_supported_zone",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGatewayIntranetSupportedZoneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the zones supported by a gateway within an intranet.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayIntranetSupportedZoneResponse
        /// </returns>
        public ListGatewayIntranetSupportedZoneResponse ListGatewayIntranetSupportedZone(string GatewayId, string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayIntranetSupportedZoneWithOptions(GatewayId, ClusterId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the zones supported by a gateway within an intranet.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListGatewayIntranetSupportedZoneResponse
        /// </returns>
        public async Task<ListGatewayIntranetSupportedZoneResponse> ListGatewayIntranetSupportedZoneAsync(string GatewayId, string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayIntranetSupportedZoneWithOptionsAsync(GatewayId, ClusterId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created service groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                query["TrafficMode"] = request.TrafficMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created service groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                query["TrafficMode"] = request.TrafficMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroups",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created service groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries created service groups.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupsResponse
        /// </returns>
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workers in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceInstanceWorkerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstanceWorkerResponse
        /// </returns>
        public ListResourceInstanceWorkerResponse ListResourceInstanceWorkerWithOptions(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ready))
            {
                query["Ready"] = request.Ready;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerName))
            {
                query["WorkerName"] = request.WorkerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstanceWorker",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instance/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName) + "/workers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstanceWorkerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workers in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceInstanceWorkerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstanceWorkerResponse
        /// </returns>
        public async Task<ListResourceInstanceWorkerResponse> ListResourceInstanceWorkerWithOptionsAsync(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ready))
            {
                query["Ready"] = request.Ready;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerName))
            {
                query["WorkerName"] = request.WorkerName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstanceWorker",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instance/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName) + "/workers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstanceWorkerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workers in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceInstanceWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstanceWorkerResponse
        /// </returns>
        public ListResourceInstanceWorkerResponse ListResourceInstanceWorker(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceInstanceWorkerWithOptions(ClusterId, ResourceId, InstanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of workers in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceInstanceWorkerRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstanceWorkerResponse
        /// </returns>
        public async Task<ListResourceInstanceWorkerResponse> ListResourceInstanceWorkerAsync(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceInstanceWorkerWithOptionsAsync(ClusterId, ResourceId, InstanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListResourceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstancesResponse
        /// </returns>
        public ListResourceInstancesResponse ListResourceInstancesWithOptions(string ClusterId, string ResourceId, ListResourceInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourceInstancesShrinkRequest request = new ListResourceInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Label))
            {
                request.LabelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Label, "Label", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIP))
            {
                query["InstanceIP"] = request.InstanceIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelShrink))
            {
                query["Label"] = request.LabelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListResourceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstancesResponse
        /// </returns>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, ListResourceInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListResourceInstancesShrinkRequest request = new ListResourceInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Label))
            {
                request.LabelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Label, "Label", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                query["ChargeType"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIP))
            {
                query["InstanceIP"] = request.InstanceIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelShrink))
            {
                query["Label"] = request.LabelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstancesResponse
        /// </returns>
        public ListResourceInstancesResponse ListResourceInstances(string ClusterId, string ResourceId, ListResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of instances in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceInstancesResponse
        /// </returns>
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(string ClusterId, string ResourceId, ListResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListResourceServices is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services that are deployed in the dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceServicesResponse
        /// </returns>
        [Obsolete("OpenAPI ListResourceServices is deprecated")]
        // Deprecated
        public ListResourceServicesResponse ListResourceServicesWithOptions(string ClusterId, string ResourceId, ListResourceServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListResourceServices is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services that are deployed in the dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceServicesResponse
        /// </returns>
        [Obsolete("OpenAPI ListResourceServices is deprecated")]
        // Deprecated
        public async Task<ListResourceServicesResponse> ListResourceServicesWithOptionsAsync(string ClusterId, string ResourceId, ListResourceServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListResourceServices is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services that are deployed in the dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceServicesResponse
        /// </returns>
        [Obsolete("OpenAPI ListResourceServices is deprecated")]
        // Deprecated
        public ListResourceServicesResponse ListResourceServices(string ClusterId, string ResourceId, ListResourceServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceServicesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListResourceServices is deprecated
        /// 
        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of services that are deployed in the dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceServicesResponse
        /// </returns>
        [Obsolete("OpenAPI ListResourceServices is deprecated")]
        // Deprecated
        public async Task<ListResourceServicesResponse> ListResourceServicesAsync(string ClusterId, string ResourceId, ListResourceServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceServicesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dedicated resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public ListResourcesResponse ListResourcesWithOptions(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceStatus))
            {
                query["ResourceStatus"] = request.ResourceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dedicated resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceStatus))
            {
                query["ResourceStatus"] = request.ResourceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dedicated resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of dedicated resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the containers of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceContainersResponse
        /// </returns>
        public ListServiceContainersResponse ListServiceContainersWithOptions(string ClusterId, string ServiceName, string InstanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceContainers",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName) + "/containers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceContainersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the containers of a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceContainersResponse
        /// </returns>
        public async Task<ListServiceContainersResponse> ListServiceContainersWithOptionsAsync(string ClusterId, string ServiceName, string InstanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceContainers",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName) + "/containers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceContainersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the containers of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListServiceContainersResponse
        /// </returns>
        public ListServiceContainersResponse ListServiceContainers(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceContainersWithOptions(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the containers of a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListServiceContainersResponse
        /// </returns>
        public async Task<ListServiceContainersResponse> ListServiceContainersAsync(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceContainersWithOptionsAsync(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstancesResponse
        /// </returns>
        public ListServiceInstancesResponse ListServiceInstancesWithOptions(string ClusterId, string ServiceName, ListServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostIP))
            {
                query["HostIP"] = request.HostIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIP))
            {
                query["InstanceIP"] = request.InstanceIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSpot))
            {
                query["IsSpot"] = request.IsSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                query["MemberType"] = request.MemberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstancesResponse
        /// </returns>
        public async Task<ListServiceInstancesResponse> ListServiceInstancesWithOptionsAsync(string ClusterId, string ServiceName, ListServiceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostIP))
            {
                query["HostIP"] = request.HostIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIP))
            {
                query["InstanceIP"] = request.InstanceIP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceStatus))
            {
                query["InstanceStatus"] = request.InstanceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSpot))
            {
                query["IsSpot"] = request.IsSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberType))
            {
                query["MemberType"] = request.MemberType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceInstances",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstancesResponse
        /// </returns>
        public ListServiceInstancesResponse ListServiceInstances(string ClusterId, string ServiceName, ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceInstancesWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instances of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceInstancesResponse
        /// </returns>
        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(string ClusterId, string ServiceName, ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceInstancesWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the historical versions of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceVersionsResponse
        /// </returns>
        public ListServiceVersionsResponse ListServiceVersionsWithOptions(string ClusterId, string ServiceName, ListServiceVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceVersions",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the historical versions of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServiceVersionsResponse
        /// </returns>
        public async Task<ListServiceVersionsResponse> ListServiceVersionsWithOptionsAsync(string ClusterId, string ServiceName, ListServiceVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServiceVersions",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServiceVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the historical versions of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceVersionsResponse
        /// </returns>
        public ListServiceVersionsResponse ListServiceVersions(string ClusterId, string ServiceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceVersionsWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the historical versions of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServiceVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServiceVersionsResponse
        /// </returns>
        public async Task<ListServiceVersionsResponse> ListServiceVersionsAsync(string ClusterId, string ServiceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceVersionsWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists services.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServicesWithOptions(ListServicesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServicesShrinkRequest request = new ListServicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Label))
            {
                request.LabelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Label, "Label", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoscalerEnabled))
            {
                query["AutoscalerEnabled"] = request.AutoscalerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronscalerEnabled))
            {
                query["CronscalerEnabled"] = request.CronscalerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gateway))
            {
                query["Gateway"] = request.Gateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeNoWorkspace))
            {
                query["IncludeNoWorkspace"] = request.IncludeNoWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelShrink))
            {
                query["Label"] = request.LabelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentServiceUid))
            {
                query["ParentServiceUid"] = request.ParentServiceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAliasName))
            {
                query["ResourceAliasName"] = request.ResourceAliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceBurstable))
            {
                query["ResourceBurstable"] = request.ResourceBurstable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                query["ServiceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceUid))
            {
                query["ServiceUid"] = request.ServiceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficState))
            {
                query["TrafficState"] = request.TrafficState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists services.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListServicesShrinkRequest request = new ListServicesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Label))
            {
                request.LabelShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Label, "Label", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoscalerEnabled))
            {
                query["AutoscalerEnabled"] = request.AutoscalerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CronscalerEnabled))
            {
                query["CronscalerEnabled"] = request.CronscalerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Gateway))
            {
                query["Gateway"] = request.Gateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeNoWorkspace))
            {
                query["IncludeNoWorkspace"] = request.IncludeNoWorkspace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelShrink))
            {
                query["Label"] = request.LabelShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentServiceUid))
            {
                query["ParentServiceUid"] = request.ParentServiceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceAliasName))
            {
                query["ResourceAliasName"] = request.ResourceAliasName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceBurstable))
            {
                query["ResourceBurstable"] = request.ResourceBurstable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceStatus))
            {
                query["ServiceStatus"] = request.ServiceStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceUid))
            {
                query["ServiceUid"] = request.ServiceUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficState))
            {
                query["TrafficState"] = request.TrafficState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListServices",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists services.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListServicesResponse
        /// </returns>
        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tenant plug-ins.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantAddonsResponse
        /// </returns>
        public ListTenantAddonsResponse ListTenantAddonsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantAddons",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/tenantaddons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantAddonsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tenant plug-ins.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTenantAddonsResponse
        /// </returns>
        public async Task<ListTenantAddonsResponse> ListTenantAddonsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTenantAddons",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/tenantaddons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTenantAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tenant plug-ins.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTenantAddonsResponse
        /// </returns>
        public ListTenantAddonsResponse ListTenantAddons()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTenantAddonsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of tenant plug-ins.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTenantAddonsResponse
        /// </returns>
        public async Task<ListTenantAddonsResponse> ListTenantAddonsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTenantAddonsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of virtual resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualResourceResponse
        /// </returns>
        public ListVirtualResourceResponse ListVirtualResourceWithOptions(ListVirtualResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceId))
            {
                query["VirtualResourceId"] = request.VirtualResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceName))
            {
                query["VirtualResourceName"] = request.VirtualResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of virtual resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualResourceResponse
        /// </returns>
        public async Task<ListVirtualResourceResponse> ListVirtualResourceWithOptionsAsync(ListVirtualResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceId))
            {
                query["VirtualResourceId"] = request.VirtualResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceName))
            {
                query["VirtualResourceName"] = request.VirtualResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of virtual resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualResourceResponse
        /// </returns>
        public ListVirtualResourceResponse ListVirtualResource(ListVirtualResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVirtualResourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of virtual resource groups for the current user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualResourceResponse
        /// </returns>
        public async Task<ListVirtualResourceResponse> ListVirtualResourceAsync(ListVirtualResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVirtualResourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets tenant configurations.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReinstallTenantAddonResponse
        /// </returns>
        public ReinstallTenantAddonResponse ReinstallTenantAddonWithOptions(string ClusterId, string TenantAddonName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReinstallTenantAddon",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/tenantaddons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantAddonName) + "/reinstall",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReinstallTenantAddonResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets tenant configurations.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReinstallTenantAddonResponse
        /// </returns>
        public async Task<ReinstallTenantAddonResponse> ReinstallTenantAddonWithOptionsAsync(string ClusterId, string TenantAddonName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReinstallTenantAddon",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/tenantaddons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TenantAddonName) + "/reinstall",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReinstallTenantAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets tenant configurations.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ReinstallTenantAddonResponse
        /// </returns>
        public ReinstallTenantAddonResponse ReinstallTenantAddon(string ClusterId, string TenantAddonName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReinstallTenantAddonWithOptions(ClusterId, TenantAddonName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets tenant configurations.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ReinstallTenantAddonResponse
        /// </returns>
        public async Task<ReinstallTenantAddonResponse> ReinstallTenantAddonAsync(string ClusterId, string TenantAddonName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReinstallTenantAddonWithOptionsAsync(ClusterId, TenantAddonName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switch the traffic state or weight of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseServiceResponse
        /// </returns>
        public ReleaseServiceResponse ReleaseServiceWithOptions(string ClusterId, string ServiceName, ReleaseServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficState))
            {
                body["TrafficState"] = request.TrafficState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["Weight"] = request.Weight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/release",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switch the traffic state or weight of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReleaseServiceResponse
        /// </returns>
        public async Task<ReleaseServiceResponse> ReleaseServiceWithOptionsAsync(string ClusterId, string ServiceName, ReleaseServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficState))
            {
                body["TrafficState"] = request.TrafficState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Weight))
            {
                body["Weight"] = request.Weight;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReleaseService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/release",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switch the traffic state or weight of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseServiceResponse
        /// </returns>
        public ReleaseServiceResponse ReleaseService(string ClusterId, string ServiceName, ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Switch the traffic state or weight of the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReleaseServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// ReleaseServiceResponse
        /// </returns>
        public async Task<ReleaseServiceResponse> ReleaseServiceAsync(string ClusterId, string ServiceName, ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartServiceResponse
        /// </returns>
        public RestartServiceResponse RestartServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/restart",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartServiceResponse
        /// </returns>
        public async Task<RestartServiceResponse> RestartServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/restart",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RestartServiceResponse
        /// </returns>
        public RestartServiceResponse RestartService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// RestartServiceResponse
        /// </returns>
        public async Task<RestartServiceResponse> RestartServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBenchmarkTaskResponse
        /// </returns>
        public StartBenchmarkTaskResponse StartBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartBenchmarkTaskResponse
        /// </returns>
        public async Task<StartBenchmarkTaskResponse> StartBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartBenchmarkTaskResponse
        /// </returns>
        public StartBenchmarkTaskResponse StartBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartBenchmarkTaskResponse
        /// </returns>
        public async Task<StartBenchmarkTaskResponse> StartBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartServiceResponse
        /// </returns>
        public StartServiceResponse StartServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartServiceResponse
        /// </returns>
        public async Task<StartServiceResponse> StartServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/start",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartServiceResponse
        /// </returns>
        public StartServiceResponse StartService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts a service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartServiceResponse
        /// </returns>
        public async Task<StartServiceResponse> StartServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopBenchmarkTaskResponse
        /// </returns>
        public StopBenchmarkTaskResponse StopBenchmarkTaskWithOptions(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopBenchmarkTaskResponse
        /// </returns>
        public async Task<StopBenchmarkTaskResponse> StopBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopBenchmarkTaskResponse
        /// </returns>
        public StopBenchmarkTaskResponse StopBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a stress testing task.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopBenchmarkTaskResponse
        /// </returns>
        public async Task<StopBenchmarkTaskResponse> StopBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopServiceResponse
        /// </returns>
        public StopServiceResponse StopServiceWithOptions(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running service.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopServiceResponse
        /// </returns>
        public async Task<StopServiceResponse> StopServiceWithOptionsAsync(string ClusterId, string ServiceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/stop",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopServiceResponse
        /// </returns>
        public StopServiceResponse StopService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a running service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopServiceResponse
        /// </returns>
        public async Task<StopServiceResponse> StopServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppServiceResponse
        /// </returns>
        public UpdateAppServiceResponse UpdateAppServiceWithOptions(string ClusterId, string ServiceName, UpdateAppServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSpec))
            {
                body["ServiceSpec"] = request.ServiceSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/app_services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppServiceResponse
        /// </returns>
        public async Task<UpdateAppServiceResponse> UpdateAppServiceWithOptionsAsync(string ClusterId, string ServiceName, UpdateAppServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaId))
            {
                query["QuotaId"] = request.QuotaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                body["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppVersion))
            {
                body["AppVersion"] = request.AppVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceSpec))
            {
                body["ServiceSpec"] = request.ServiceSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/app_services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppServiceResponse
        /// </returns>
        public UpdateAppServiceResponse UpdateAppService(string ClusterId, string ServiceName, UpdateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an application service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppServiceResponse
        /// </returns>
        public async Task<UpdateAppServiceResponse> UpdateAppServiceAsync(string ClusterId, string ServiceName, UpdateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBenchmarkTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBenchmarkTaskResponse
        /// </returns>
        public UpdateBenchmarkTaskResponse UpdateBenchmarkTaskWithOptions(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBenchmarkTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBenchmarkTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBenchmarkTaskResponse
        /// </returns>
        public async Task<UpdateBenchmarkTaskResponse> UpdateBenchmarkTaskWithOptionsAsync(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBenchmarkTask",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/benchmark-tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TaskName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBenchmarkTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBenchmarkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBenchmarkTaskResponse
        /// </returns>
        public UpdateBenchmarkTaskResponse UpdateBenchmarkTask(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBenchmarkTaskWithOptions(ClusterId, TaskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a stress testing task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBenchmarkTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBenchmarkTaskResponse
        /// </returns>
        public async Task<UpdateBenchmarkTaskResponse> UpdateBenchmarkTaskAsync(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public UpdateGatewayResponse UpdateGatewayWithOptions(string GatewayId, string ClusterId, UpdateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInternet))
            {
                body["EnableInternet"] = request.EnableInternet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIntranet))
            {
                body["EnableIntranet"] = request.EnableIntranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSSLRedirection))
            {
                body["EnableSSLRedirection"] = request.EnableSSLRedirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefault))
            {
                body["IsDefault"] = request.IsDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                body["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public async Task<UpdateGatewayResponse> UpdateGatewayWithOptionsAsync(string GatewayId, string ClusterId, UpdateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInternet))
            {
                body["EnableInternet"] = request.EnableInternet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIntranet))
            {
                body["EnableIntranet"] = request.EnableIntranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSSLRedirection))
            {
                body["EnableSSLRedirection"] = request.EnableSSLRedirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                body["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDefault))
            {
                body["IsDefault"] = request.IsDefault;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                body["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                body["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGateway",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/gateways/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GatewayId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGatewayResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public UpdateGatewayResponse UpdateGateway(string GatewayId, string ClusterId, UpdateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayWithOptions(GatewayId, ClusterId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGatewayRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGatewayResponse
        /// </returns>
        public async Task<UpdateGatewayResponse> UpdateGatewayAsync(string GatewayId, string ClusterId, UpdateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayWithOptionsAsync(GatewayId, ClusterId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the specific fields of a service group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public UpdateGroupResponse UpdateGroupWithOptions(string ClusterId, string GroupName, UpdateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                body["TrafficMode"] = request.TrafficMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the specific fields of a service group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(string ClusterId, string GroupName, UpdateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TrafficMode))
            {
                body["TrafficMode"] = request.TrafficMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/groups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(GroupName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the specific fields of a service group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public UpdateGroupResponse UpdateGroup(string ClusterId, string GroupName, UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGroupWithOptions(ClusterId, GroupName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the specific fields of a service group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public async Task<UpdateGroupResponse> UpdateGroupAsync(string ClusterId, string GroupName, UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGroupWithOptionsAsync(ClusterId, GroupName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
        public UpdateResourceResponse UpdateResourceWithOptions(string ClusterId, string ResourceId, UpdateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfManagedResourceOptions))
            {
                body["SelfManagedResourceOptions"] = request.SelfManagedResourceOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
        public async Task<UpdateResourceResponse> UpdateResourceWithOptionsAsync(string ClusterId, string ResourceId, UpdateResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["ResourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelfManagedResourceOptions))
            {
                body["SelfManagedResourceOptions"] = request.SelfManagedResourceOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
        public UpdateResourceResponse UpdateResource(string ClusterId, string ResourceId, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceResponse
        /// </returns>
        public async Task<UpdateResourceResponse> UpdateResourceAsync(string ClusterId, string ResourceId, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceDLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceDLinkResponse
        /// </returns>
        public UpdateResourceDLinkResponse UpdateResourceDLinkWithOptions(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCIDRs))
            {
                body["DestinationCIDRs"] = request.DestinationCIDRs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdList))
            {
                body["VSwitchIdList"] = request.VSwitchIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/dlink",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceDLinkResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceDLinkRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceDLinkResponse
        /// </returns>
        public async Task<UpdateResourceDLinkResponse> UpdateResourceDLinkWithOptionsAsync(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationCIDRs))
            {
                body["DestinationCIDRs"] = request.DestinationCIDRs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                body["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIdList))
            {
                body["VSwitchIdList"] = request.VSwitchIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceDLink",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/dlink",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceDLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceDLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceDLinkResponse
        /// </returns>
        public UpdateResourceDLinkResponse UpdateResourceDLink(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceDLinkWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceDLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceDLinkResponse
        /// </returns>
        public async Task<UpdateResourceDLinkResponse> UpdateResourceDLinkAsync(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceDLinkWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service scheduling status of an instance in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceResponse
        /// </returns>
        public UpdateResourceInstanceResponse UpdateResourceInstanceWithOptions(string ClusterId, string ResourceId, string InstanceId, UpdateResourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["Action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceInstance",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service scheduling status of an instance in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceResponse
        /// </returns>
        public async Task<UpdateResourceInstanceResponse> UpdateResourceInstanceWithOptionsAsync(string ClusterId, string ResourceId, string InstanceId, UpdateResourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["Action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceInstance",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service scheduling status of an instance in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceResponse
        /// </returns>
        public UpdateResourceInstanceResponse UpdateResourceInstance(string ClusterId, string ResourceId, string InstanceId, UpdateResourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceInstanceWithOptions(ClusterId, ResourceId, InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the service scheduling status of an instance in a dedicated resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceResponse
        /// </returns>
        public async Task<UpdateResourceInstanceResponse> UpdateResourceInstanceAsync(string ClusterId, string ResourceId, string InstanceId, UpdateResourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceInstanceWithOptionsAsync(ClusterId, ResourceId, InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tag of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateResourceInstanceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceLabelResponse
        /// </returns>
        public UpdateResourceInstanceLabelResponse UpdateResourceInstanceLabelWithOptions(string ClusterId, string ResourceId, UpdateResourceInstanceLabelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateResourceInstanceLabelShrinkRequest request = new UpdateResourceInstanceLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllInstances))
            {
                query["AllInstances"] = request.AllInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceInstanceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/label",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceInstanceLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tag of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateResourceInstanceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceLabelResponse
        /// </returns>
        public async Task<UpdateResourceInstanceLabelResponse> UpdateResourceInstanceLabelWithOptionsAsync(string ClusterId, string ResourceId, UpdateResourceInstanceLabelRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateResourceInstanceLabelShrinkRequest request = new UpdateResourceInstanceLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllInstances))
            {
                query["AllInstances"] = request.AllInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceInstanceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceId) + "/label",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceInstanceLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tag of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceInstanceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceLabelResponse
        /// </returns>
        public UpdateResourceInstanceLabelResponse UpdateResourceInstanceLabel(string ClusterId, string ResourceId, UpdateResourceInstanceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceInstanceLabelWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the tag of an instance in a resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceInstanceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceInstanceLabelResponse
        /// </returns>
        public async Task<UpdateResourceInstanceLabelResponse> UpdateResourceInstanceLabelAsync(string ClusterId, string ResourceId, UpdateResourceInstanceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceInstanceLabelWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateServiceWithOptions(string ClusterId, string ServiceName, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberToUpdate))
            {
                query["MemberToUpdate"] = request.MemberToUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberToUpdate))
            {
                query["MemberToUpdate"] = request.MemberToUpdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateService",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public UpdateServiceResponse UpdateService(string ClusterId, string ServiceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceResponse
        /// </returns>
        public async Task<UpdateServiceResponse> UpdateServiceAsync(string ClusterId, string ServiceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceAutoScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceAutoScalerResponse
        /// </returns>
        public UpdateServiceAutoScalerResponse UpdateServiceAutoScalerWithOptions(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Behavior))
            {
                body["behavior"] = request.Behavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleStrategies))
            {
                body["scaleStrategies"] = request.ScaleStrategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceAutoScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceAutoScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceAutoScalerResponse
        /// </returns>
        public async Task<UpdateServiceAutoScalerResponse> UpdateServiceAutoScalerWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Behavior))
            {
                body["behavior"] = request.Behavior;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Max))
            {
                body["max"] = request.Max;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Min))
            {
                body["min"] = request.Min;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleStrategies))
            {
                body["scaleStrategies"] = request.ScaleStrategies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceAutoScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/autoscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceAutoScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceAutoScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceAutoScalerResponse
        /// </returns>
        public UpdateServiceAutoScalerResponse UpdateServiceAutoScaler(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceAutoScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Autoscaler configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceAutoScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceAutoScalerResponse
        /// </returns>
        public async Task<UpdateServiceAutoScalerResponse> UpdateServiceAutoScalerAsync(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceCronScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceCronScalerResponse
        /// </returns>
        public UpdateServiceCronScalerResponse UpdateServiceCronScalerWithOptions(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceCronScalerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceCronScalerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceCronScalerResponse
        /// </returns>
        public async Task<UpdateServiceCronScalerResponse> UpdateServiceCronScalerWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeDates))
            {
                body["ExcludeDates"] = request.ExcludeDates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleJobs))
            {
                body["ScaleJobs"] = request.ScaleJobs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceCronScaler",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/cronscaler",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceCronScalerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceCronScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceCronScalerResponse
        /// </returns>
        public UpdateServiceCronScalerResponse UpdateServiceCronScaler(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceCronScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceCronScalerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceCronScalerResponse
        /// </returns>
        public async Task<UpdateServiceCronScalerResponse> UpdateServiceCronScalerAsync(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of service instances. Only isolation can be performed for service instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceInstanceResponse
        /// </returns>
        public UpdateServiceInstanceResponse UpdateServiceInstanceWithOptions(string ClusterId, string ServiceName, string InstanceName, UpdateServiceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isolate))
            {
                body["Isolate"] = request.Isolate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstance",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of service instances. Only isolation can be performed for service instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceInstanceResponse
        /// </returns>
        public async Task<UpdateServiceInstanceResponse> UpdateServiceInstanceWithOptionsAsync(string ClusterId, string ServiceName, string InstanceName, UpdateServiceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Isolate))
            {
                body["Isolate"] = request.Isolate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceInstance",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of service instances. Only isolation can be performed for service instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceInstanceResponse
        /// </returns>
        public UpdateServiceInstanceResponse UpdateServiceInstance(string ClusterId, string ServiceName, string InstanceName, UpdateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceInstanceWithOptions(ClusterId, ServiceName, InstanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of service instances. Only isolation can be performed for service instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceInstanceResponse
        /// </returns>
        public async Task<UpdateServiceInstanceResponse> UpdateServiceInstanceAsync(string ClusterId, string ServiceName, string InstanceName, UpdateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceInstanceWithOptionsAsync(ClusterId, ServiceName, InstanceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds service tags or updates existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceLabelResponse
        /// </returns>
        public UpdateServiceLabelResponse UpdateServiceLabelWithOptions(string ClusterId, string ServiceName, UpdateServiceLabelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/label",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds service tags or updates existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceLabelRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceLabelResponse
        /// </returns>
        public async Task<UpdateServiceLabelResponse> UpdateServiceLabelWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceLabelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceLabel",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/label",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds service tags or updates existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceLabelResponse
        /// </returns>
        public UpdateServiceLabelResponse UpdateServiceLabel(string ClusterId, string ServiceName, UpdateServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceLabelWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds service tags or updates existing service tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceLabelResponse
        /// </returns>
        public async Task<UpdateServiceLabelResponse> UpdateServiceLabelAsync(string ClusterId, string ServiceName, UpdateServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceLabelWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the traffic mirroring configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceMirrorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceMirrorResponse
        /// </returns>
        public UpdateServiceMirrorResponse UpdateServiceMirrorWithOptions(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceMirrorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the traffic mirroring configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceMirrorRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceMirrorResponse
        /// </returns>
        public async Task<UpdateServiceMirrorResponse> UpdateServiceMirrorWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ratio))
            {
                body["Ratio"] = request.Ratio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["Target"] = request.Target;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceMirror",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/mirror",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceMirrorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the traffic mirroring configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceMirrorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceMirrorResponse
        /// </returns>
        public UpdateServiceMirrorResponse UpdateServiceMirror(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceMirrorWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the traffic mirroring configurations of a service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceMirrorRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceMirrorResponse
        /// </returns>
        public async Task<UpdateServiceMirrorResponse> UpdateServiceMirrorAsync(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceMirrorWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the safety lock of a service to minimize misoperations on the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceSafetyLockRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceSafetyLockResponse
        /// </returns>
        public UpdateServiceSafetyLockResponse UpdateServiceSafetyLockWithOptions(string ClusterId, string ServiceName, UpdateServiceSafetyLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lock))
            {
                body["Lock"] = request.Lock;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceSafetyLock",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/lock",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceSafetyLockResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the safety lock of a service to minimize misoperations on the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceSafetyLockRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceSafetyLockResponse
        /// </returns>
        public async Task<UpdateServiceSafetyLockResponse> UpdateServiceSafetyLockWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceSafetyLockRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lock))
            {
                body["Lock"] = request.Lock;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceSafetyLock",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/lock",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceSafetyLockResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the safety lock of a service to minimize misoperations on the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceSafetyLockRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceSafetyLockResponse
        /// </returns>
        public UpdateServiceSafetyLockResponse UpdateServiceSafetyLock(string ClusterId, string ServiceName, UpdateServiceSafetyLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceSafetyLockWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the safety lock of a service to minimize misoperations on the service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceSafetyLockRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceSafetyLockResponse
        /// </returns>
        public async Task<UpdateServiceSafetyLockResponse> UpdateServiceSafetyLockAsync(string ClusterId, string ServiceName, UpdateServiceSafetyLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceSafetyLockWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of a service or rolls back the service to a specific version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public UpdateServiceVersionResponse UpdateServiceVersionWithOptions(string ClusterId, string ServiceName, UpdateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceVersion",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/version",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of a service or rolls back the service to a specific version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateServiceVersion",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/services/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ServiceName) + "/version",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateServiceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of a service or rolls back the service to a specific version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public UpdateServiceVersionResponse UpdateServiceVersion(string ClusterId, string ServiceName, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceVersionWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the version of a service or rolls back the service to a specific version.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateServiceVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateServiceVersionResponse
        /// </returns>
        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionAsync(string ClusterId, string ServiceName, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceVersionWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualResourceResponse
        /// </returns>
        public UpdateVirtualResourceResponse UpdateVirtualResourceWithOptions(string ClusterId, string VirtualResourceId, UpdateVirtualResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSpotProtectionPeriod))
            {
                body["DisableSpotProtectionPeriod"] = request.DisableSpotProtectionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceName))
            {
                body["VirtualResourceName"] = request.VirtualResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VirtualResourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualResourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualResourceResponse
        /// </returns>
        public async Task<UpdateVirtualResourceResponse> UpdateVirtualResourceWithOptionsAsync(string ClusterId, string VirtualResourceId, UpdateVirtualResourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableSpotProtectionPeriod))
            {
                body["DisableSpotProtectionPeriod"] = request.DisableSpotProtectionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualResourceName))
            {
                body["VirtualResourceName"] = request.VirtualResourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualResource",
                Version = "2021-07-01",
                Protocol = "HTTPS",
                Pathname = "/api/v2/virtualresources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(VirtualResourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualResourceResponse
        /// </returns>
        public UpdateVirtualResourceResponse UpdateVirtualResource(string ClusterId, string VirtualResourceId, UpdateVirtualResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVirtualResourceWithOptions(ClusterId, VirtualResourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a virtual resource group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualResourceResponse
        /// </returns>
        public async Task<UpdateVirtualResourceResponse> UpdateVirtualResourceAsync(string ClusterId, string VirtualResourceId, UpdateVirtualResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVirtualResourceWithOptionsAsync(ClusterId, VirtualResourceId, request, headers, runtime);
        }

    }
}
