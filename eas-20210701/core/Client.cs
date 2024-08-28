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

        /**
         * @summary Clones a service.
         *
         * @param tmpReq CloneServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneServiceResponse
         */
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

        /**
         * @summary Clones a service.
         *
         * @param tmpReq CloneServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CloneServiceResponse
         */
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

        /**
         * @summary Clones a service.
         *
         * @param request CloneServiceRequest
         * @return CloneServiceResponse
         */
        public CloneServiceResponse CloneService(string ClusterId, string ServiceName, CloneServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Clones a service.
         *
         * @param request CloneServiceRequest
         * @return CloneServiceResponse
         */
        public async Task<CloneServiceResponse> CloneServiceAsync(string ClusterId, string ServiceName, CloneServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Commits the Worker0 container in the custom container service and deploys the container as a new image.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitServiceResponse
         */
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

        /**
         * @summary Commits the Worker0 container in the custom container service and deploys the container as a new image.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitServiceResponse
         */
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

        /**
         * @summary Commits the Worker0 container in the custom container service and deploys the container as a new image.
         *
         * @return CommitServiceResponse
         */
        public CommitServiceResponse CommitService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CommitServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Commits the Worker0 container in the custom container service and deploys the container as a new image.
         *
         * @return CommitServiceResponse
         */
        public async Task<CommitServiceResponse> CommitServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CommitServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary 创建网关访问权限ACL Policy
         *
         * @param tmpReq CreateAclPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAclPolicyResponse
         */
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

        /**
         * @summary 创建网关访问权限ACL Policy
         *
         * @param tmpReq CreateAclPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAclPolicyResponse
         */
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

        /**
         * @summary 创建网关访问权限ACL Policy
         *
         * @param request CreateAclPolicyRequest
         * @return CreateAclPolicyResponse
         */
        public CreateAclPolicyResponse CreateAclPolicy(string ClusterId, string GatewayId, CreateAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAclPolicyWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary 创建网关访问权限ACL Policy
         *
         * @param request CreateAclPolicyRequest
         * @return CreateAclPolicyResponse
         */
        public async Task<CreateAclPolicyResponse> CreateAclPolicyAsync(string ClusterId, string GatewayId, CreateAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAclPolicyWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary Creates an application service.
         *
         * @param request CreateAppServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppServiceResponse
         */
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

        /**
         * @summary Creates an application service.
         *
         * @param request CreateAppServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAppServiceResponse
         */
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

        /**
         * @summary Creates an application service.
         *
         * @param request CreateAppServiceRequest
         * @return CreateAppServiceResponse
         */
        public CreateAppServiceResponse CreateAppService(CreateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAppServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates an application service.
         *
         * @param request CreateAppServiceRequest
         * @return CreateAppServiceResponse
         */
        public async Task<CreateAppServiceResponse> CreateAppServiceAsync(CreateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAppServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a stress testing task.
         *
         * @param request CreateBenchmarkTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBenchmarkTaskResponse
         */
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

        /**
         * @summary Creates a stress testing task.
         *
         * @param request CreateBenchmarkTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBenchmarkTaskResponse
         */
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

        /**
         * @summary Creates a stress testing task.
         *
         * @param request CreateBenchmarkTaskRequest
         * @return CreateBenchmarkTaskResponse
         */
        public CreateBenchmarkTaskResponse CreateBenchmarkTask(CreateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBenchmarkTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a stress testing task.
         *
         * @param request CreateBenchmarkTaskRequest
         * @return CreateBenchmarkTaskResponse
         */
        public async Task<CreateBenchmarkTaskResponse> CreateBenchmarkTaskAsync(CreateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBenchmarkTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a private gateway. You can create a private gateway only in a self-managed resource group.
         *
         * @param request CreateGatewayRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayResponse
         */
        public CreateGatewayResponse CreateGatewayWithOptions(CreateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInternet))
            {
                body["EnableInternet"] = request.EnableInternet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIntranet))
            {
                body["EnableIntranet"] = request.EnableIntranet;
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

        /**
         * @summary Creates a private gateway. You can create a private gateway only in a self-managed resource group.
         *
         * @param request CreateGatewayRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayResponse
         */
        public async Task<CreateGatewayResponse> CreateGatewayWithOptionsAsync(CreateGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableInternet))
            {
                body["EnableInternet"] = request.EnableInternet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIntranet))
            {
                body["EnableIntranet"] = request.EnableIntranet;
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

        /**
         * @summary Creates a private gateway. You can create a private gateway only in a self-managed resource group.
         *
         * @param request CreateGatewayRequest
         * @return CreateGatewayResponse
         */
        public CreateGatewayResponse CreateGateway(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a private gateway. You can create a private gateway only in a self-managed resource group.
         *
         * @param request CreateGatewayRequest
         * @return CreateGatewayResponse
         */
        public async Task<CreateGatewayResponse> CreateGatewayAsync(CreateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates an internal endpoint of a private gateway.
         *
         * @param request CreateGatewayIntranetLinkedVpcRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayIntranetLinkedVpcResponse
         */
        public CreateGatewayIntranetLinkedVpcResponse CreateGatewayIntranetLinkedVpcWithOptions(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Creates an internal endpoint of a private gateway.
         *
         * @param request CreateGatewayIntranetLinkedVpcRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGatewayIntranetLinkedVpcResponse
         */
        public async Task<CreateGatewayIntranetLinkedVpcResponse> CreateGatewayIntranetLinkedVpcWithOptionsAsync(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Creates an internal endpoint of a private gateway.
         *
         * @param request CreateGatewayIntranetLinkedVpcRequest
         * @return CreateGatewayIntranetLinkedVpcResponse
         */
        public CreateGatewayIntranetLinkedVpcResponse CreateGatewayIntranetLinkedVpc(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGatewayIntranetLinkedVpcWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary Creates an internal endpoint of a private gateway.
         *
         * @param request CreateGatewayIntranetLinkedVpcRequest
         * @return CreateGatewayIntranetLinkedVpcResponse
         */
        public async Task<CreateGatewayIntranetLinkedVpcResponse> CreateGatewayIntranetLinkedVpcAsync(string ClusterId, string GatewayId, CreateGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGatewayIntranetLinkedVpcWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary Creates a resource group.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param request CreateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceResponse
         */
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

        /**
         * @summary Creates a resource group.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param request CreateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceResponse
         */
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

        /**
         * @summary Creates a resource group.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param request CreateResourceRequest
         * @return CreateResourceResponse
         */
        public CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a resource group.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param request CreateResourceRequest
         * @return CreateResourceResponse
         */
        public async Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates instances in a dedicated resource group.
         *
         * @param request CreateResourceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceInstancesResponse
         */
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

        /**
         * @summary Creates instances in a dedicated resource group.
         *
         * @param request CreateResourceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceInstancesResponse
         */
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

        /**
         * @summary Creates instances in a dedicated resource group.
         *
         * @param request CreateResourceInstancesRequest
         * @return CreateResourceInstancesResponse
         */
        public CreateResourceInstancesResponse CreateResourceInstances(string ClusterId, string ResourceId, CreateResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Creates instances in a dedicated resource group.
         *
         * @param request CreateResourceInstancesRequest
         * @return CreateResourceInstancesResponse
         */
        public async Task<CreateResourceInstancesResponse> CreateResourceInstancesAsync(string ClusterId, string ResourceId, CreateResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Enables the LogShipper feature of Log Service for a resource group.
         *
         * @param request CreateResourceLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceLogResponse
         */
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

        /**
         * @summary Enables the LogShipper feature of Log Service for a resource group.
         *
         * @param request CreateResourceLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateResourceLogResponse
         */
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

        /**
         * @summary Enables the LogShipper feature of Log Service for a resource group.
         *
         * @param request CreateResourceLogRequest
         * @return CreateResourceLogResponse
         */
        public CreateResourceLogResponse CreateResourceLog(string ClusterId, string ResourceId, CreateResourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceLogWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Enables the LogShipper feature of Log Service for a resource group.
         *
         * @param request CreateResourceLogRequest
         * @return CreateResourceLogResponse
         */
        public async Task<CreateResourceLogResponse> CreateResourceLogAsync(string ClusterId, string ResourceId, CreateResourceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceLogWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Creates a model service in Elastic Algorithm Service (EAS).
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param tmpReq CreateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceResponse
         */
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

        /**
         * @summary Creates a model service in Elastic Algorithm Service (EAS).
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param tmpReq CreateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceResponse
         */
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

        /**
         * @summary Creates a model service in Elastic Algorithm Service (EAS).
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param request CreateServiceRequest
         * @return CreateServiceResponse
         */
        public CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a model service in Elastic Algorithm Service (EAS).
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/144261.html) of Elastic Algorithm Service (EAS).
         *
         * @param request CreateServiceRequest
         * @return CreateServiceResponse
         */
        public async Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Enables the Autoscaler feature and creates an Autoscaler controller for a service.
         *
         * @param request CreateServiceAutoScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceAutoScalerResponse
         */
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

        /**
         * @summary Enables the Autoscaler feature and creates an Autoscaler controller for a service.
         *
         * @param request CreateServiceAutoScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceAutoScalerResponse
         */
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

        /**
         * @summary Enables the Autoscaler feature and creates an Autoscaler controller for a service.
         *
         * @param request CreateServiceAutoScalerRequest
         * @return CreateServiceAutoScalerResponse
         */
        public CreateServiceAutoScalerResponse CreateServiceAutoScaler(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceAutoScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Enables the Autoscaler feature and creates an Autoscaler controller for a service.
         *
         * @param request CreateServiceAutoScalerRequest
         * @return CreateServiceAutoScalerResponse
         */
        public async Task<CreateServiceAutoScalerResponse> CreateServiceAutoScalerAsync(string ClusterId, string ServiceName, CreateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.
         *
         * @param request CreateServiceCronScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceCronScalerResponse
         */
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

        /**
         * @summary Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.
         *
         * @param request CreateServiceCronScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceCronScalerResponse
         */
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

        /**
         * @summary Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.
         *
         * @param request CreateServiceCronScalerRequest
         * @return CreateServiceCronScalerResponse
         */
        public CreateServiceCronScalerResponse CreateServiceCronScaler(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceCronScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Enables the Cron Horizontal Pod Autoscaler (CronHPA) feature for a service.
         *
         * @param request CreateServiceCronScalerRequest
         * @return CreateServiceCronScalerResponse
         */
        public async Task<CreateServiceCronScalerResponse> CreateServiceCronScalerAsync(string ClusterId, string ServiceName, CreateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.
         *
         * @param request CreateServiceMirrorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceMirrorResponse
         */
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

        /**
         * @summary Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.
         *
         * @param request CreateServiceMirrorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateServiceMirrorResponse
         */
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

        /**
         * @summary Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.
         *
         * @param request CreateServiceMirrorRequest
         * @return CreateServiceMirrorResponse
         */
        public CreateServiceMirrorResponse CreateServiceMirror(string ClusterId, string ServiceName, CreateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateServiceMirrorWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Enables the traffic mirroring feature for a service. After the feature is enabled, requests received by the service can be mirrored to another service.
         *
         * @param request CreateServiceMirrorRequest
         * @return CreateServiceMirrorResponse
         */
        public async Task<CreateServiceMirrorResponse> CreateServiceMirrorAsync(string ClusterId, string ServiceName, CreateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateServiceMirrorWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary 移除网关acl policy entry
         *
         * @param tmpReq DeleteAclPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAclPolicyResponse
         */
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

        /**
         * @summary 移除网关acl policy entry
         *
         * @param tmpReq DeleteAclPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAclPolicyResponse
         */
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

        /**
         * @summary 移除网关acl policy entry
         *
         * @param request DeleteAclPolicyRequest
         * @return DeleteAclPolicyResponse
         */
        public DeleteAclPolicyResponse DeleteAclPolicy(string ClusterId, string GatewayId, DeleteAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAclPolicyWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary 移除网关acl policy entry
         *
         * @param request DeleteAclPolicyRequest
         * @return DeleteAclPolicyResponse
         */
        public async Task<DeleteAclPolicyResponse> DeleteAclPolicyAsync(string ClusterId, string GatewayId, DeleteAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAclPolicyWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary Deletes a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBenchmarkTaskResponse
         */
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

        /**
         * @summary Deletes a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBenchmarkTaskResponse
         */
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

        /**
         * @summary Deletes a stress testing task.
         *
         * @return DeleteBenchmarkTaskResponse
         */
        public DeleteBenchmarkTaskResponse DeleteBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Deletes a stress testing task.
         *
         * @return DeleteBenchmarkTaskResponse
         */
        public async Task<DeleteBenchmarkTaskResponse> DeleteBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Deletes a private gateway.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayResponse
         */
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

        /**
         * @summary Deletes a private gateway.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayResponse
         */
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

        /**
         * @summary Deletes a private gateway.
         *
         * @return DeleteGatewayResponse
         */
        public DeleteGatewayResponse DeleteGateway(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /**
         * @summary Deletes a private gateway.
         *
         * @return DeleteGatewayResponse
         */
        public async Task<DeleteGatewayResponse> DeleteGatewayAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /**
         * @summary 删除网关内网访问端点
         *
         * @param request DeleteGatewayIntranetLinkedVpcRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayIntranetLinkedVpcResponse
         */
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

        /**
         * @summary 删除网关内网访问端点
         *
         * @param request DeleteGatewayIntranetLinkedVpcRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGatewayIntranetLinkedVpcResponse
         */
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

        /**
         * @summary 删除网关内网访问端点
         *
         * @param request DeleteGatewayIntranetLinkedVpcRequest
         * @return DeleteGatewayIntranetLinkedVpcResponse
         */
        public DeleteGatewayIntranetLinkedVpcResponse DeleteGatewayIntranetLinkedVpc(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGatewayIntranetLinkedVpcWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary 删除网关内网访问端点
         *
         * @param request DeleteGatewayIntranetLinkedVpcRequest
         * @return DeleteGatewayIntranetLinkedVpcResponse
         */
        public async Task<DeleteGatewayIntranetLinkedVpcResponse> DeleteGatewayIntranetLinkedVpcAsync(string ClusterId, string GatewayId, DeleteGatewayIntranetLinkedVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGatewayIntranetLinkedVpcWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary Deletes a resource group that contains no resources or instances.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceResponse
         */
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

        /**
         * @summary Deletes a resource group that contains no resources or instances.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceResponse
         */
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

        /**
         * @summary Deletes a resource group that contains no resources or instances.
         *
         * @return DeleteResourceResponse
         */
        public DeleteResourceResponse DeleteResource(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Deletes a resource group that contains no resources or instances.
         *
         * @return DeleteResourceResponse
         */
        public async Task<DeleteResourceResponse> DeleteResourceAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceDLinkResponse
         */
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

        /**
         * @summary Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceDLinkResponse
         */
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

        /**
         * @summary Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.
         *
         * @return DeleteResourceDLinkResponse
         */
        public DeleteResourceDLinkResponse DeleteResourceDLink(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceDLinkWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Disables the virtual private cloud (VPC) direct connection feature for a dedicated resource group.
         *
         * @return DeleteResourceDLinkResponse
         */
        public async Task<DeleteResourceDLinkResponse> DeleteResourceDLinkAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceDLinkWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.
         *
         * @param request DeleteResourceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceInstancesResponse
         */
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

        /**
         * @summary Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.
         *
         * @param request DeleteResourceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceInstancesResponse
         */
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

        /**
         * @summary Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.
         *
         * @param request DeleteResourceInstancesRequest
         * @return DeleteResourceInstancesResponse
         */
        public DeleteResourceInstancesResponse DeleteResourceInstances(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Deletes instances in a dedicated resource group. You can delete only pay-as-you-go instances as a regular user.
         *
         * @param request DeleteResourceInstancesRequest
         * @return DeleteResourceInstancesResponse
         */
        public async Task<DeleteResourceInstancesResponse> DeleteResourceInstancesAsync(string ClusterId, string ResourceId, DeleteResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Disables the LogShipper feature of Log Service for a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceLogResponse
         */
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

        /**
         * @summary Disables the LogShipper feature of Log Service for a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteResourceLogResponse
         */
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

        /**
         * @summary Disables the LogShipper feature of Log Service for a dedicated resource group.
         *
         * @return DeleteResourceLogResponse
         */
        public DeleteResourceLogResponse DeleteResourceLog(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceLogWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Disables the LogShipper feature of Log Service for a dedicated resource group.
         *
         * @return DeleteResourceLogResponse
         */
        public async Task<DeleteResourceLogResponse> DeleteResourceLogAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceLogWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Deletes a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceResponse
         */
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

        /**
         * @summary Deletes a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceResponse
         */
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

        /**
         * @summary Deletes a service.
         *
         * @return DeleteServiceResponse
         */
        public DeleteServiceResponse DeleteService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Deletes a service.
         *
         * @return DeleteServiceResponse
         */
        public async Task<DeleteServiceResponse> DeleteServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceAutoScalerResponse
         */
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

        /**
         * @summary Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceAutoScalerResponse
         */
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

        /**
         * @summary Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.
         *
         * @return DeleteServiceAutoScalerResponse
         */
        public DeleteServiceAutoScalerResponse DeleteServiceAutoScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceAutoScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Deletes the existing Autoscaler controller and disables the Autoscaler feature for a service.
         *
         * @return DeleteServiceAutoScalerResponse
         */
        public async Task<DeleteServiceAutoScalerResponse> DeleteServiceAutoScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Disables the Cronscaler feature for a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceCronScalerResponse
         */
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

        /**
         * @summary Disables the Cronscaler feature for a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceCronScalerResponse
         */
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

        /**
         * @summary Disables the Cronscaler feature for a service.
         *
         * @return DeleteServiceCronScalerResponse
         */
        public DeleteServiceCronScalerResponse DeleteServiceCronScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceCronScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Disables the Cronscaler feature for a service.
         *
         * @return DeleteServiceCronScalerResponse
         */
        public async Task<DeleteServiceCronScalerResponse> DeleteServiceCronScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Restarts the instances of a service.
         *
         * @param request DeleteServiceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceInstancesResponse
         */
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

        /**
         * @summary Restarts the instances of a service.
         *
         * @param request DeleteServiceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceInstancesResponse
         */
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

        /**
         * @summary Restarts the instances of a service.
         *
         * @param request DeleteServiceInstancesRequest
         * @return DeleteServiceInstancesResponse
         */
        public DeleteServiceInstancesResponse DeleteServiceInstances(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceInstancesWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Restarts the instances of a service.
         *
         * @param request DeleteServiceInstancesRequest
         * @return DeleteServiceInstancesResponse
         */
        public async Task<DeleteServiceInstancesResponse> DeleteServiceInstancesAsync(string ClusterId, string ServiceName, DeleteServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceInstancesWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Deletes existing service tags.
         *
         * @param tmpReq DeleteServiceLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceLabelResponse
         */
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

        /**
         * @summary Deletes existing service tags.
         *
         * @param tmpReq DeleteServiceLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceLabelResponse
         */
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

        /**
         * @summary Deletes existing service tags.
         *
         * @param request DeleteServiceLabelRequest
         * @return DeleteServiceLabelResponse
         */
        public DeleteServiceLabelResponse DeleteServiceLabel(string ClusterId, string ServiceName, DeleteServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceLabelWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Deletes existing service tags.
         *
         * @param request DeleteServiceLabelRequest
         * @return DeleteServiceLabelResponse
         */
        public async Task<DeleteServiceLabelResponse> DeleteServiceLabelAsync(string ClusterId, string ServiceName, DeleteServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceLabelWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Disables the traffic mirroring feature for a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceMirrorResponse
         */
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

        /**
         * @summary Disables the traffic mirroring feature for a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteServiceMirrorResponse
         */
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

        /**
         * @summary Disables the traffic mirroring feature for a service.
         *
         * @return DeleteServiceMirrorResponse
         */
        public DeleteServiceMirrorResponse DeleteServiceMirror(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteServiceMirrorWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Disables the traffic mirroring feature for a service.
         *
         * @return DeleteServiceMirrorResponse
         */
        public async Task<DeleteServiceMirrorResponse> DeleteServiceMirrorAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteServiceMirrorWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries details about the configurations of a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBenchmarkTaskResponse
         */
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

        /**
         * @summary Queries details about the configurations of a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBenchmarkTaskResponse
         */
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

        /**
         * @summary Queries details about the configurations of a stress testing task.
         *
         * @return DescribeBenchmarkTaskResponse
         */
        public DescribeBenchmarkTaskResponse DescribeBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Queries details about the configurations of a stress testing task.
         *
         * @return DescribeBenchmarkTaskResponse
         */
        public async Task<DescribeBenchmarkTaskResponse> DescribeBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Queries the report of a stress testing task.
         *
         * @param request DescribeBenchmarkTaskReportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBenchmarkTaskReportResponse
         */
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

        /**
         * @summary Queries the report of a stress testing task.
         *
         * @param request DescribeBenchmarkTaskReportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBenchmarkTaskReportResponse
         */
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

        /**
         * @summary Queries the report of a stress testing task.
         *
         * @param request DescribeBenchmarkTaskReportRequest
         * @return DescribeBenchmarkTaskReportResponse
         */
        public DescribeBenchmarkTaskReportResponse DescribeBenchmarkTaskReport(string ClusterId, string TaskName, DescribeBenchmarkTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeBenchmarkTaskReportWithOptions(ClusterId, TaskName, request, headers, runtime);
        }

        /**
         * @summary Queries the report of a stress testing task.
         *
         * @param request DescribeBenchmarkTaskReportRequest
         * @return DescribeBenchmarkTaskReportResponse
         */
        public async Task<DescribeBenchmarkTaskReportResponse> DescribeBenchmarkTaskReportAsync(string ClusterId, string TaskName, DescribeBenchmarkTaskReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeBenchmarkTaskReportWithOptionsAsync(ClusterId, TaskName, request, headers, runtime);
        }

        /**
         * @summary Queries the details of a private gateway.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGatewayResponse
         */
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

        /**
         * @summary Queries the details of a private gateway.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGatewayResponse
         */
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

        /**
         * @summary Queries the details of a private gateway.
         *
         * @return DescribeGatewayResponse
         */
        public DescribeGatewayResponse DescribeGateway(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGatewayWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /**
         * @summary Queries the details of a private gateway.
         *
         * @return DescribeGatewayResponse
         */
        public async Task<DescribeGatewayResponse> DescribeGatewayAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGatewayWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /**
         * @summary Queries the information about a service group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGroupResponse
         */
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

        /**
         * @summary Queries the information about a service group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGroupResponse
         */
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

        /**
         * @summary Queries the information about a service group.
         *
         * @return DescribeGroupResponse
         */
        public DescribeGroupResponse DescribeGroup(string ClusterId, string GroupName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGroupWithOptions(ClusterId, GroupName, headers, runtime);
        }

        /**
         * @summary Queries the information about a service group.
         *
         * @return DescribeGroupResponse
         */
        public async Task<DescribeGroupResponse> DescribeGroupAsync(string ClusterId, string GroupName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGroupWithOptionsAsync(ClusterId, GroupName, headers, runtime);
        }

        /**
         * @summary Queries the information about a resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceResponse
         */
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

        /**
         * @summary Queries the information about a resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceResponse
         */
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

        /**
         * @summary Queries the information about a resource group.
         *
         * @return DescribeResourceResponse
         */
        public DescribeResourceResponse DescribeResource(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Queries the information about a resource group.
         *
         * @return DescribeResourceResponse
         */
        public async Task<DescribeResourceResponse> DescribeResourceAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceDLinkResponse
         */
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

        /**
         * @summary Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceDLinkResponse
         */
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

        /**
         * @summary Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.
         *
         * @return DescribeResourceDLinkResponse
         */
        public DescribeResourceDLinkResponse DescribeResourceDLink(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceDLinkWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Queries detailed configurations about a virtual private cloud (VPC) direct connection of a dedicated resource group.
         *
         * @return DescribeResourceDLinkResponse
         */
        public async Task<DescribeResourceDLinkResponse> DescribeResourceDLinkAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceDLinkWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceLogResponse
         */
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

        /**
         * @summary Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourceLogResponse
         */
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

        /**
         * @summary Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.
         *
         * @return DescribeResourceLogResponse
         */
        public DescribeResourceLogResponse DescribeResourceLog(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourceLogWithOptions(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Queries the details about the LogShipper configurations of Log Service for a dedicated resource group.
         *
         * @return DescribeResourceLogResponse
         */
        public async Task<DescribeResourceLogResponse> DescribeResourceLogAsync(string ClusterId, string ResourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourceLogWithOptionsAsync(ClusterId, ResourceId, headers, runtime);
        }

        /**
         * @summary Queries the details about a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceResponse
         */
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

        /**
         * @summary Queries the details about a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceResponse
         */
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

        /**
         * @summary Queries the details about a service.
         *
         * @return DescribeServiceResponse
         */
        public DescribeServiceResponse DescribeService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries the details about a service.
         *
         * @return DescribeServiceResponse
         */
        public async Task<DescribeServiceResponse> DescribeServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries information about the Autoscaler configurations of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceAutoScalerResponse
         */
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

        /**
         * @summary Queries information about the Autoscaler configurations of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceAutoScalerResponse
         */
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

        /**
         * @summary Queries information about the Autoscaler configurations of a service.
         *
         * @return DescribeServiceAutoScalerResponse
         */
        public DescribeServiceAutoScalerResponse DescribeServiceAutoScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceAutoScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries information about the Autoscaler configurations of a service.
         *
         * @return DescribeServiceAutoScalerResponse
         */
        public async Task<DescribeServiceAutoScalerResponse> DescribeServiceAutoScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceCronScalerResponse
         */
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

        /**
         * @summary Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceCronScalerResponse
         */
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

        /**
         * @summary Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.
         *
         * @return DescribeServiceCronScalerResponse
         */
        public DescribeServiceCronScalerResponse DescribeServiceCronScaler(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceCronScalerWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries the Cron Horizontal Pod Autoscaler (CronHPA) configurations of a service.
         *
         * @return DescribeServiceCronScalerResponse
         */
        public async Task<DescribeServiceCronScalerResponse> DescribeServiceCronScalerAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries the diagnostics details of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceDiagnosisResponse
         */
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

        /**
         * @summary Queries the diagnostics details of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceDiagnosisResponse
         */
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

        /**
         * @summary Queries the diagnostics details of a service.
         *
         * @return DescribeServiceDiagnosisResponse
         */
        public DescribeServiceDiagnosisResponse DescribeServiceDiagnosis(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceDiagnosisWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries the diagnostics details of a service.
         *
         * @return DescribeServiceDiagnosisResponse
         */
        public async Task<DescribeServiceDiagnosisResponse> DescribeServiceDiagnosisAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceDiagnosisWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries information about recent service deployment events.
         *
         * @param request DescribeServiceEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceEventResponse
         */
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

        /**
         * @summary Queries information about recent service deployment events.
         *
         * @param request DescribeServiceEventRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceEventResponse
         */
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

        /**
         * @summary Queries information about recent service deployment events.
         *
         * @param request DescribeServiceEventRequest
         * @return DescribeServiceEventResponse
         */
        public DescribeServiceEventResponse DescribeServiceEvent(string ClusterId, string ServiceName, DescribeServiceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceEventWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries information about recent service deployment events.
         *
         * @param request DescribeServiceEventRequest
         * @return DescribeServiceEventResponse
         */
        public async Task<DescribeServiceEventResponse> DescribeServiceEventAsync(string ClusterId, string ServiceName, DescribeServiceEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceEventWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceInstanceDiagnosisResponse
         */
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

        /**
         * @summary Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceInstanceDiagnosisResponse
         */
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

        /**
         * @summary Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).
         *
         * @return DescribeServiceInstanceDiagnosisResponse
         */
        public DescribeServiceInstanceDiagnosisResponse DescribeServiceInstanceDiagnosis(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceInstanceDiagnosisWithOptions(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /**
         * @summary Queries the diagnostics details of an instance that runs Elastic Algorithm Service (EAS).
         *
         * @return DescribeServiceInstanceDiagnosisResponse
         */
        public async Task<DescribeServiceInstanceDiagnosisResponse> DescribeServiceInstanceDiagnosisAsync(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceInstanceDiagnosisWithOptionsAsync(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /**
         * @summary Queries the information about the logs of a service.
         *
         * @param request DescribeServiceLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceLogResponse
         */
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

        /**
         * @summary Queries the information about the logs of a service.
         *
         * @param request DescribeServiceLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceLogResponse
         */
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

        /**
         * @summary Queries the information about the logs of a service.
         *
         * @param request DescribeServiceLogRequest
         * @return DescribeServiceLogResponse
         */
        public DescribeServiceLogResponse DescribeServiceLog(string ClusterId, string ServiceName, DescribeServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceLogWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries the information about the logs of a service.
         *
         * @param request DescribeServiceLogRequest
         * @return DescribeServiceLogResponse
         */
        public async Task<DescribeServiceLogResponse> DescribeServiceLogAsync(string ClusterId, string ServiceName, DescribeServiceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceLogWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries details about the traffic mirroring settings of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceMirrorResponse
         */
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

        /**
         * @summary Queries details about the traffic mirroring settings of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeServiceMirrorResponse
         */
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

        /**
         * @summary Queries details about the traffic mirroring settings of a service.
         *
         * @return DescribeServiceMirrorResponse
         */
        public DescribeServiceMirrorResponse DescribeServiceMirror(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeServiceMirrorWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries details about the traffic mirroring settings of a service.
         *
         * @return DescribeServiceMirrorResponse
         */
        public async Task<DescribeServiceMirrorResponse> DescribeServiceMirrorAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeServiceMirrorWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.
         *
         * @param request DescribeSpotDiscountHistoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSpotDiscountHistoryResponse
         */
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

        /**
         * @summary Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.
         *
         * @param request DescribeSpotDiscountHistoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSpotDiscountHistoryResponse
         */
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

        /**
         * @summary Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.
         *
         * @param request DescribeSpotDiscountHistoryRequest
         * @return DescribeSpotDiscountHistoryResponse
         */
        public DescribeSpotDiscountHistoryResponse DescribeSpotDiscountHistory(DescribeSpotDiscountHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSpotDiscountHistoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the historical prices of preemptible instances. For more information about preemptible instances, see Create and use preemptible instances.
         *
         * @param request DescribeSpotDiscountHistoryRequest
         * @return DescribeSpotDiscountHistoryResponse
         */
        public async Task<DescribeSpotDiscountHistoryResponse> DescribeSpotDiscountHistoryAsync(DescribeSpotDiscountHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSpotDiscountHistoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Switches a container service to development mode or exits development mode.
         *
         * @param request DevelopServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DevelopServiceResponse
         */
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

        /**
         * @summary Switches a container service to development mode or exits development mode.
         *
         * @param request DevelopServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DevelopServiceResponse
         */
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

        /**
         * @summary Switches a container service to development mode or exits development mode.
         *
         * @param request DevelopServiceRequest
         * @return DevelopServiceResponse
         */
        public DevelopServiceResponse DevelopService(string ClusterId, string ServiceName, DevelopServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DevelopServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Switches a container service to development mode or exits development mode.
         *
         * @param request DevelopServiceRequest
         * @return DevelopServiceResponse
         */
        public async Task<DevelopServiceResponse> DevelopServiceAsync(string ClusterId, string ServiceName, DevelopServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DevelopServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary 查询网关所有ACL Policy
         *
         * @param request ListAclPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAclPolicyResponse
         */
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

        /**
         * @summary 查询网关所有ACL Policy
         *
         * @param request ListAclPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAclPolicyResponse
         */
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

        /**
         * @summary 查询网关所有ACL Policy
         *
         * @param request ListAclPolicyRequest
         * @return ListAclPolicyResponse
         */
        public ListAclPolicyResponse ListAclPolicy(string ClusterId, string GatewayId, ListAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAclPolicyWithOptions(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary 查询网关所有ACL Policy
         *
         * @param request ListAclPolicyRequest
         * @return ListAclPolicyResponse
         */
        public async Task<ListAclPolicyResponse> ListAclPolicyAsync(string ClusterId, string GatewayId, ListAclPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAclPolicyWithOptionsAsync(ClusterId, GatewayId, request, headers, runtime);
        }

        /**
         * @summary Queries a list of stress testing tasks that are created by the current user.
         *
         * @param request ListBenchmarkTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBenchmarkTaskResponse
         */
        public ListBenchmarkTaskResponse ListBenchmarkTaskWithOptions(ListBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
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

        /**
         * @summary Queries a list of stress testing tasks that are created by the current user.
         *
         * @param request ListBenchmarkTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBenchmarkTaskResponse
         */
        public async Task<ListBenchmarkTaskResponse> ListBenchmarkTaskWithOptionsAsync(ListBenchmarkTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
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

        /**
         * @summary Queries a list of stress testing tasks that are created by the current user.
         *
         * @param request ListBenchmarkTaskRequest
         * @return ListBenchmarkTaskResponse
         */
        public ListBenchmarkTaskResponse ListBenchmarkTask(ListBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBenchmarkTaskWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of stress testing tasks that are created by the current user.
         *
         * @param request ListBenchmarkTaskRequest
         * @return ListBenchmarkTaskResponse
         */
        public async Task<ListBenchmarkTaskResponse> ListBenchmarkTaskAsync(ListBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBenchmarkTaskWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 列举gateway
         *
         * @param request ListGatewayRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayResponse
         */
        public ListGatewayResponse ListGatewayWithOptions(ListGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
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

        /**
         * @summary 列举gateway
         *
         * @param request ListGatewayRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayResponse
         */
        public async Task<ListGatewayResponse> ListGatewayWithOptionsAsync(ListGatewayRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayId))
            {
                query["GatewayId"] = request.GatewayId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayName))
            {
                query["GatewayName"] = request.GatewayName;
            }
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

        /**
         * @summary 列举gateway
         *
         * @param request ListGatewayRequest
         * @return ListGatewayResponse
         */
        public ListGatewayResponse ListGateway(ListGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayWithOptions(request, headers, runtime);
        }

        /**
         * @summary 列举gateway
         *
         * @param request ListGatewayRequest
         * @return ListGatewayResponse
         */
        public async Task<ListGatewayResponse> ListGatewayAsync(ListGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of the internal endpoints of a private gateway.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayIntranetLinkedVpcResponse
         */
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

        /**
         * @summary Queries a list of the internal endpoints of a private gateway.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGatewayIntranetLinkedVpcResponse
         */
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

        /**
         * @summary Queries a list of the internal endpoints of a private gateway.
         *
         * @return ListGatewayIntranetLinkedVpcResponse
         */
        public ListGatewayIntranetLinkedVpcResponse ListGatewayIntranetLinkedVpc(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGatewayIntranetLinkedVpcWithOptions(ClusterId, GatewayId, headers, runtime);
        }

        /**
         * @summary Queries a list of the internal endpoints of a private gateway.
         *
         * @return ListGatewayIntranetLinkedVpcResponse
         */
        public async Task<ListGatewayIntranetLinkedVpcResponse> ListGatewayIntranetLinkedVpcAsync(string ClusterId, string GatewayId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGatewayIntranetLinkedVpcWithOptionsAsync(ClusterId, GatewayId, headers, runtime);
        }

        /**
         * @summary Queries created service groups.
         *
         * @param request ListGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroupsWithOptions(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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

        /**
         * @summary Queries created service groups.
         *
         * @param request ListGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsWithOptionsAsync(ListGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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

        /**
         * @summary Queries created service groups.
         *
         * @param request ListGroupsRequest
         * @return ListGroupsResponse
         */
        public ListGroupsResponse ListGroups(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries created service groups.
         *
         * @param request ListGroupsRequest
         * @return ListGroupsResponse
         */
        public async Task<ListGroupsResponse> ListGroupsAsync(ListGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of workers in a resource group.
         *
         * @param request ListResourceInstanceWorkerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceInstanceWorkerResponse
         */
        public ListResourceInstanceWorkerResponse ListResourceInstanceWorkerWithOptions(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Queries a list of workers in a resource group.
         *
         * @param request ListResourceInstanceWorkerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceInstanceWorkerResponse
         */
        public async Task<ListResourceInstanceWorkerResponse> ListResourceInstanceWorkerWithOptionsAsync(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Queries a list of workers in a resource group.
         *
         * @param request ListResourceInstanceWorkerRequest
         * @return ListResourceInstanceWorkerResponse
         */
        public ListResourceInstanceWorkerResponse ListResourceInstanceWorker(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceInstanceWorkerWithOptions(ClusterId, ResourceId, InstanceName, request, headers, runtime);
        }

        /**
         * @summary Queries a list of workers in a resource group.
         *
         * @param request ListResourceInstanceWorkerRequest
         * @return ListResourceInstanceWorkerResponse
         */
        public async Task<ListResourceInstanceWorkerResponse> ListResourceInstanceWorkerAsync(string ClusterId, string ResourceId, string InstanceName, ListResourceInstanceWorkerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceInstanceWorkerWithOptionsAsync(ClusterId, ResourceId, InstanceName, request, headers, runtime);
        }

        /**
         * @summary Queries a list of instances in a dedicated resource group.
         *
         * @param request ListResourceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceInstancesResponse
         */
        public ListResourceInstancesResponse ListResourceInstancesWithOptions(string ClusterId, string ResourceId, ListResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        /**
         * @summary Queries a list of instances in a dedicated resource group.
         *
         * @param request ListResourceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceInstancesResponse
         */
        public async Task<ListResourceInstancesResponse> ListResourceInstancesWithOptionsAsync(string ClusterId, string ResourceId, ListResourceInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        /**
         * @summary Queries a list of instances in a dedicated resource group.
         *
         * @param request ListResourceInstancesRequest
         * @return ListResourceInstancesResponse
         */
        public ListResourceInstancesResponse ListResourceInstances(string ClusterId, string ResourceId, ListResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceInstancesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Queries a list of instances in a dedicated resource group.
         *
         * @param request ListResourceInstancesRequest
         * @return ListResourceInstancesResponse
         */
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(string ClusterId, string ResourceId, ListResourceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceInstancesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ListResourceServices is deprecated
         *
         * @summary Queries a list of services that are deployed in the dedicated resource group.
         *
         * @param request ListResourceServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceServicesResponse
         */
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

        /**
         * @deprecated OpenAPI ListResourceServices is deprecated
         *
         * @summary Queries a list of services that are deployed in the dedicated resource group.
         *
         * @param request ListResourceServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourceServicesResponse
         */
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

        /**
         * @deprecated OpenAPI ListResourceServices is deprecated
         *
         * @summary Queries a list of services that are deployed in the dedicated resource group.
         *
         * @param request ListResourceServicesRequest
         * @return ListResourceServicesResponse
         */
        // Deprecated
        public ListResourceServicesResponse ListResourceServices(string ClusterId, string ResourceId, ListResourceServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceServicesWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ListResourceServices is deprecated
         *
         * @summary Queries a list of services that are deployed in the dedicated resource group.
         *
         * @param request ListResourceServicesRequest
         * @return ListResourceServicesResponse
         */
        // Deprecated
        public async Task<ListResourceServicesResponse> ListResourceServicesAsync(string ClusterId, string ResourceId, ListResourceServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceServicesWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Queries a list of dedicated resource groups for the current user.
         *
         * @param request ListResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourcesResponse
         */
        public ListResourcesResponse ListResourcesWithOptions(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Queries a list of dedicated resource groups for the current user.
         *
         * @param request ListResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListResourcesResponse
         */
        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Queries a list of dedicated resource groups for the current user.
         *
         * @param request ListResourcesRequest
         * @return ListResourcesResponse
         */
        public ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of dedicated resource groups for the current user.
         *
         * @param request ListResourcesRequest
         * @return ListResourcesResponse
         */
        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the containers of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceContainersResponse
         */
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

        /**
         * @summary Queries the containers of a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceContainersResponse
         */
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

        /**
         * @summary Queries the containers of a service.
         *
         * @return ListServiceContainersResponse
         */
        public ListServiceContainersResponse ListServiceContainers(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceContainersWithOptions(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /**
         * @summary Queries the containers of a service.
         *
         * @return ListServiceContainersResponse
         */
        public async Task<ListServiceContainersResponse> ListServiceContainersAsync(string ClusterId, string ServiceName, string InstanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceContainersWithOptionsAsync(ClusterId, ServiceName, InstanceName, headers, runtime);
        }

        /**
         * @summary Queries instances of a service.
         *
         * @param request ListServiceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstancesResponse
         */
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

        /**
         * @summary Queries instances of a service.
         *
         * @param request ListServiceInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceInstancesResponse
         */
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

        /**
         * @summary Queries instances of a service.
         *
         * @param request ListServiceInstancesRequest
         * @return ListServiceInstancesResponse
         */
        public ListServiceInstancesResponse ListServiceInstances(string ClusterId, string ServiceName, ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceInstancesWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries instances of a service.
         *
         * @param request ListServiceInstancesRequest
         * @return ListServiceInstancesResponse
         */
        public async Task<ListServiceInstancesResponse> ListServiceInstancesAsync(string ClusterId, string ServiceName, ListServiceInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceInstancesWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries the information about the historical versions of a service.
         *
         * @param request ListServiceVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceVersionsResponse
         */
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

        /**
         * @summary Queries the information about the historical versions of a service.
         *
         * @param request ListServiceVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServiceVersionsResponse
         */
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

        /**
         * @summary Queries the information about the historical versions of a service.
         *
         * @param request ListServiceVersionsRequest
         * @return ListServiceVersionsResponse
         */
        public ListServiceVersionsResponse ListServiceVersions(string ClusterId, string ServiceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServiceVersionsWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries the information about the historical versions of a service.
         *
         * @param request ListServiceVersionsRequest
         * @return ListServiceVersionsResponse
         */
        public async Task<ListServiceVersionsResponse> ListServiceVersionsAsync(string ClusterId, string ServiceName, ListServiceVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServiceVersionsWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Queries a list of services that are created by the current user.
         *
         * @param tmpReq ListServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServicesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
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

        /**
         * @summary Queries a list of services that are created by the current user.
         *
         * @param tmpReq ListServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListServicesResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["ResourceName"] = request.ResourceName;
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

        /**
         * @summary Queries a list of services that are created by the current user.
         *
         * @param request ListServicesRequest
         * @return ListServicesResponse
         */
        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListServicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of services that are created by the current user.
         *
         * @param request ListServicesRequest
         * @return ListServicesResponse
         */
        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取租户配置列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantAddonsResponse
         */
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

        /**
         * @summary 获取租户配置列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTenantAddonsResponse
         */
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

        /**
         * @summary 获取租户配置列表
         *
         * @return ListTenantAddonsResponse
         */
        public ListTenantAddonsResponse ListTenantAddons()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTenantAddonsWithOptions(headers, runtime);
        }

        /**
         * @summary 获取租户配置列表
         *
         * @return ListTenantAddonsResponse
         */
        public async Task<ListTenantAddonsResponse> ListTenantAddonsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTenantAddonsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 重置租户配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReinstallTenantAddonResponse
         */
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

        /**
         * @summary 重置租户配置
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReinstallTenantAddonResponse
         */
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

        /**
         * @summary 重置租户配置
         *
         * @return ReinstallTenantAddonResponse
         */
        public ReinstallTenantAddonResponse ReinstallTenantAddon(string ClusterId, string TenantAddonName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReinstallTenantAddonWithOptions(ClusterId, TenantAddonName, headers, runtime);
        }

        /**
         * @summary 重置租户配置
         *
         * @return ReinstallTenantAddonResponse
         */
        public async Task<ReinstallTenantAddonResponse> ReinstallTenantAddonAsync(string ClusterId, string TenantAddonName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReinstallTenantAddonWithOptionsAsync(ClusterId, TenantAddonName, headers, runtime);
        }

        /**
         * @summary Performs canary release or blue-green release of a service.
         *
         * @param request ReleaseServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseServiceResponse
         */
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

        /**
         * @summary Performs canary release or blue-green release of a service.
         *
         * @param request ReleaseServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseServiceResponse
         */
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

        /**
         * @summary Performs canary release or blue-green release of a service.
         *
         * @param request ReleaseServiceRequest
         * @return ReleaseServiceResponse
         */
        public ReleaseServiceResponse ReleaseService(string ClusterId, string ServiceName, ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReleaseServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Performs canary release or blue-green release of a service.
         *
         * @param request ReleaseServiceRequest
         * @return ReleaseServiceResponse
         */
        public async Task<ReleaseServiceResponse> ReleaseServiceAsync(string ClusterId, string ServiceName, ReleaseServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReleaseServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Restarts a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartServiceResponse
         */
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

        /**
         * @summary Restarts a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartServiceResponse
         */
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

        /**
         * @summary Restarts a service.
         *
         * @return RestartServiceResponse
         */
        public RestartServiceResponse RestartService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Restarts a service.
         *
         * @return RestartServiceResponse
         */
        public async Task<RestartServiceResponse> RestartServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Starts a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartBenchmarkTaskResponse
         */
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

        /**
         * @summary Starts a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartBenchmarkTaskResponse
         */
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

        /**
         * @summary Starts a stress testing task.
         *
         * @return StartBenchmarkTaskResponse
         */
        public StartBenchmarkTaskResponse StartBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Starts a stress testing task.
         *
         * @return StartBenchmarkTaskResponse
         */
        public async Task<StartBenchmarkTaskResponse> StartBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Starts a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartServiceResponse
         */
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

        /**
         * @summary Starts a service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartServiceResponse
         */
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

        /**
         * @summary Starts a service.
         *
         * @return StartServiceResponse
         */
        public StartServiceResponse StartService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Starts a service.
         *
         * @return StartServiceResponse
         */
        public async Task<StartServiceResponse> StartServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Stops a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopBenchmarkTaskResponse
         */
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

        /**
         * @summary Stops a stress testing task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopBenchmarkTaskResponse
         */
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

        /**
         * @summary Stops a stress testing task.
         *
         * @return StopBenchmarkTaskResponse
         */
        public StopBenchmarkTaskResponse StopBenchmarkTask(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopBenchmarkTaskWithOptions(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Stops a stress testing task.
         *
         * @return StopBenchmarkTaskResponse
         */
        public async Task<StopBenchmarkTaskResponse> StopBenchmarkTaskAsync(string ClusterId, string TaskName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, headers, runtime);
        }

        /**
         * @summary Stops a running service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopServiceResponse
         */
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

        /**
         * @summary Stops a running service.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopServiceResponse
         */
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

        /**
         * @summary Stops a running service.
         *
         * @return StopServiceResponse
         */
        public StopServiceResponse StopService(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopServiceWithOptions(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Stops a running service.
         *
         * @return StopServiceResponse
         */
        public async Task<StopServiceResponse> StopServiceAsync(string ClusterId, string ServiceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopServiceWithOptionsAsync(ClusterId, ServiceName, headers, runtime);
        }

        /**
         * @summary Updates an application service.
         *
         * @param request UpdateAppServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppServiceResponse
         */
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

        /**
         * @summary Updates an application service.
         *
         * @param request UpdateAppServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppServiceResponse
         */
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

        /**
         * @summary Updates an application service.
         *
         * @param request UpdateAppServiceRequest
         * @return UpdateAppServiceResponse
         */
        public UpdateAppServiceResponse UpdateAppService(string ClusterId, string ServiceName, UpdateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates an application service.
         *
         * @param request UpdateAppServiceRequest
         * @return UpdateAppServiceResponse
         */
        public async Task<UpdateAppServiceResponse> UpdateAppServiceAsync(string ClusterId, string ServiceName, UpdateAppServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates a stress testing task.
         *
         * @param request UpdateBenchmarkTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBenchmarkTaskResponse
         */
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

        /**
         * @summary Updates a stress testing task.
         *
         * @param request UpdateBenchmarkTaskRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateBenchmarkTaskResponse
         */
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

        /**
         * @summary Updates a stress testing task.
         *
         * @param request UpdateBenchmarkTaskRequest
         * @return UpdateBenchmarkTaskResponse
         */
        public UpdateBenchmarkTaskResponse UpdateBenchmarkTask(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBenchmarkTaskWithOptions(ClusterId, TaskName, request, headers, runtime);
        }

        /**
         * @summary Updates a stress testing task.
         *
         * @param request UpdateBenchmarkTaskRequest
         * @return UpdateBenchmarkTaskResponse
         */
        public async Task<UpdateBenchmarkTaskResponse> UpdateBenchmarkTaskAsync(string ClusterId, string TaskName, UpdateBenchmarkTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBenchmarkTaskWithOptionsAsync(ClusterId, TaskName, request, headers, runtime);
        }

        /**
         * @summary Update a private gateway.
         *
         * @param request UpdateGatewayRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayResponse
         */
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

        /**
         * @summary Update a private gateway.
         *
         * @param request UpdateGatewayRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGatewayResponse
         */
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

        /**
         * @summary Update a private gateway.
         *
         * @param request UpdateGatewayRequest
         * @return UpdateGatewayResponse
         */
        public UpdateGatewayResponse UpdateGateway(string GatewayId, string ClusterId, UpdateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGatewayWithOptions(GatewayId, ClusterId, request, headers, runtime);
        }

        /**
         * @summary Update a private gateway.
         *
         * @param request UpdateGatewayRequest
         * @return UpdateGatewayResponse
         */
        public async Task<UpdateGatewayResponse> UpdateGatewayAsync(string GatewayId, string ClusterId, UpdateGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGatewayWithOptionsAsync(GatewayId, ClusterId, request, headers, runtime);
        }

        /**
         * @summary Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.
         *
         * @param request UpdateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceResponse
         */
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

        /**
         * @summary Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.
         *
         * @param request UpdateResourceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceResponse
         */
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

        /**
         * @summary Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.
         *
         * @param request UpdateResourceRequest
         * @return UpdateResourceResponse
         */
        public UpdateResourceResponse UpdateResource(string ClusterId, string ResourceId, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Updates the information about a dedicated resource group. Only the name of a dedicated resource group can be updated.
         *
         * @param request UpdateResourceRequest
         * @return UpdateResourceResponse
         */
        public async Task<UpdateResourceResponse> UpdateResourceAsync(string ClusterId, string ResourceId, UpdateResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.
         *
         * @param request UpdateResourceDLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceDLinkResponse
         */
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

        /**
         * @summary Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.
         *
         * @param request UpdateResourceDLinkRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceDLinkResponse
         */
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

        /**
         * @summary Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.
         *
         * @param request UpdateResourceDLinkRequest
         * @return UpdateResourceDLinkResponse
         */
        public UpdateResourceDLinkResponse UpdateResourceDLink(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceDLinkWithOptions(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Updates the configurations of a virtual private cloud (VPC) direct connection for a dedicated resource group.
         *
         * @param request UpdateResourceDLinkRequest
         * @return UpdateResourceDLinkResponse
         */
        public async Task<UpdateResourceDLinkResponse> UpdateResourceDLinkAsync(string ClusterId, string ResourceId, UpdateResourceDLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceDLinkWithOptionsAsync(ClusterId, ResourceId, request, headers, runtime);
        }

        /**
         * @summary Updates the service scheduling status of an instance in a dedicated resource group.
         *
         * @param request UpdateResourceInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceInstanceResponse
         */
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

        /**
         * @summary Updates the service scheduling status of an instance in a dedicated resource group.
         *
         * @param request UpdateResourceInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourceInstanceResponse
         */
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

        /**
         * @summary Updates the service scheduling status of an instance in a dedicated resource group.
         *
         * @param request UpdateResourceInstanceRequest
         * @return UpdateResourceInstanceResponse
         */
        public UpdateResourceInstanceResponse UpdateResourceInstance(string ClusterId, string ResourceId, string InstanceId, UpdateResourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceInstanceWithOptions(ClusterId, ResourceId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary Updates the service scheduling status of an instance in a dedicated resource group.
         *
         * @param request UpdateResourceInstanceRequest
         * @return UpdateResourceInstanceResponse
         */
        public async Task<UpdateResourceInstanceResponse> UpdateResourceInstanceAsync(string ClusterId, string ResourceId, string InstanceId, UpdateResourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceInstanceWithOptionsAsync(ClusterId, ResourceId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.
         *
         * @param request UpdateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceResponse
         */
        public UpdateServiceResponse UpdateServiceWithOptions(string ClusterId, string ServiceName, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.
         *
         * @param request UpdateServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceResponse
         */
        public async Task<UpdateServiceResponse> UpdateServiceWithOptionsAsync(string ClusterId, string ServiceName, UpdateServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @summary Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.
         *
         * @param request UpdateServiceRequest
         * @return UpdateServiceResponse
         */
        public UpdateServiceResponse UpdateService(string ClusterId, string ServiceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates a model or processor of a service. If only the metadata.instance field is updated, manual scaling can be performed.
         *
         * @param request UpdateServiceRequest
         * @return UpdateServiceResponse
         */
        public async Task<UpdateServiceResponse> UpdateServiceAsync(string ClusterId, string ServiceName, UpdateServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the Autoscaler configurations of a service.
         *
         * @param request UpdateServiceAutoScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceAutoScalerResponse
         */
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

        /**
         * @summary Updates the Autoscaler configurations of a service.
         *
         * @param request UpdateServiceAutoScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceAutoScalerResponse
         */
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

        /**
         * @summary Updates the Autoscaler configurations of a service.
         *
         * @param request UpdateServiceAutoScalerRequest
         * @return UpdateServiceAutoScalerResponse
         */
        public UpdateServiceAutoScalerResponse UpdateServiceAutoScaler(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceAutoScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the Autoscaler configurations of a service.
         *
         * @param request UpdateServiceAutoScalerRequest
         * @return UpdateServiceAutoScalerResponse
         */
        public async Task<UpdateServiceAutoScalerResponse> UpdateServiceAutoScalerAsync(string ClusterId, string ServiceName, UpdateServiceAutoScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceAutoScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.
         *
         * @param request UpdateServiceCronScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceCronScalerResponse
         */
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

        /**
         * @summary Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.
         *
         * @param request UpdateServiceCronScalerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceCronScalerResponse
         */
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

        /**
         * @summary Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.
         *
         * @param request UpdateServiceCronScalerRequest
         * @return UpdateServiceCronScalerResponse
         */
        public UpdateServiceCronScalerResponse UpdateServiceCronScaler(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceCronScalerWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the Cron Horizontal Pod Autoscaler (CronHPA) settings of a service.
         *
         * @param request UpdateServiceCronScalerRequest
         * @return UpdateServiceCronScalerResponse
         */
        public async Task<UpdateServiceCronScalerResponse> UpdateServiceCronScalerAsync(string ClusterId, string ServiceName, UpdateServiceCronScalerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceCronScalerWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates attributes of service instances. Only isolation can be performed for service instances.
         *
         * @param request UpdateServiceInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceResponse
         */
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

        /**
         * @summary Updates attributes of service instances. Only isolation can be performed for service instances.
         *
         * @param request UpdateServiceInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceInstanceResponse
         */
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

        /**
         * @summary Updates attributes of service instances. Only isolation can be performed for service instances.
         *
         * @param request UpdateServiceInstanceRequest
         * @return UpdateServiceInstanceResponse
         */
        public UpdateServiceInstanceResponse UpdateServiceInstance(string ClusterId, string ServiceName, string InstanceName, UpdateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceInstanceWithOptions(ClusterId, ServiceName, InstanceName, request, headers, runtime);
        }

        /**
         * @summary Updates attributes of service instances. Only isolation can be performed for service instances.
         *
         * @param request UpdateServiceInstanceRequest
         * @return UpdateServiceInstanceResponse
         */
        public async Task<UpdateServiceInstanceResponse> UpdateServiceInstanceAsync(string ClusterId, string ServiceName, string InstanceName, UpdateServiceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceInstanceWithOptionsAsync(ClusterId, ServiceName, InstanceName, request, headers, runtime);
        }

        /**
         * @summary Adds service tags or updates existing service tags.
         *
         * @param request UpdateServiceLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceLabelResponse
         */
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

        /**
         * @summary Adds service tags or updates existing service tags.
         *
         * @param request UpdateServiceLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceLabelResponse
         */
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

        /**
         * @summary Adds service tags or updates existing service tags.
         *
         * @param request UpdateServiceLabelRequest
         * @return UpdateServiceLabelResponse
         */
        public UpdateServiceLabelResponse UpdateServiceLabel(string ClusterId, string ServiceName, UpdateServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceLabelWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Adds service tags or updates existing service tags.
         *
         * @param request UpdateServiceLabelRequest
         * @return UpdateServiceLabelResponse
         */
        public async Task<UpdateServiceLabelResponse> UpdateServiceLabelAsync(string ClusterId, string ServiceName, UpdateServiceLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceLabelWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the traffic mirroring configurations of a service.
         *
         * @param request UpdateServiceMirrorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceMirrorResponse
         */
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

        /**
         * @summary Updates the traffic mirroring configurations of a service.
         *
         * @param request UpdateServiceMirrorRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceMirrorResponse
         */
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

        /**
         * @summary Updates the traffic mirroring configurations of a service.
         *
         * @param request UpdateServiceMirrorRequest
         * @return UpdateServiceMirrorResponse
         */
        public UpdateServiceMirrorResponse UpdateServiceMirror(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceMirrorWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the traffic mirroring configurations of a service.
         *
         * @param request UpdateServiceMirrorRequest
         * @return UpdateServiceMirrorResponse
         */
        public async Task<UpdateServiceMirrorResponse> UpdateServiceMirrorAsync(string ClusterId, string ServiceName, UpdateServiceMirrorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceMirrorWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the safety lock of a service to minimize misoperations on the service.
         *
         * @param request UpdateServiceSafetyLockRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceSafetyLockResponse
         */
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

        /**
         * @summary Updates the safety lock of a service to minimize misoperations on the service.
         *
         * @param request UpdateServiceSafetyLockRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceSafetyLockResponse
         */
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

        /**
         * @summary Updates the safety lock of a service to minimize misoperations on the service.
         *
         * @param request UpdateServiceSafetyLockRequest
         * @return UpdateServiceSafetyLockResponse
         */
        public UpdateServiceSafetyLockResponse UpdateServiceSafetyLock(string ClusterId, string ServiceName, UpdateServiceSafetyLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceSafetyLockWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the safety lock of a service to minimize misoperations on the service.
         *
         * @param request UpdateServiceSafetyLockRequest
         * @return UpdateServiceSafetyLockResponse
         */
        public async Task<UpdateServiceSafetyLockResponse> UpdateServiceSafetyLockAsync(string ClusterId, string ServiceName, UpdateServiceSafetyLockRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceSafetyLockWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the version of a service or rolls back the service to a specific version.
         *
         * @param request UpdateServiceVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceVersionResponse
         */
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

        /**
         * @summary Updates the version of a service or rolls back the service to a specific version.
         *
         * @param request UpdateServiceVersionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateServiceVersionResponse
         */
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

        /**
         * @summary Updates the version of a service or rolls back the service to a specific version.
         *
         * @param request UpdateServiceVersionRequest
         * @return UpdateServiceVersionResponse
         */
        public UpdateServiceVersionResponse UpdateServiceVersion(string ClusterId, string ServiceName, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateServiceVersionWithOptions(ClusterId, ServiceName, request, headers, runtime);
        }

        /**
         * @summary Updates the version of a service or rolls back the service to a specific version.
         *
         * @param request UpdateServiceVersionRequest
         * @return UpdateServiceVersionResponse
         */
        public async Task<UpdateServiceVersionResponse> UpdateServiceVersionAsync(string ClusterId, string ServiceName, UpdateServiceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateServiceVersionWithOptionsAsync(ClusterId, ServiceName, request, headers, runtime);
        }

    }
}
