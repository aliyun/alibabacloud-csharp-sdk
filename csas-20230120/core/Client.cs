// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Csas20230120.Models;

namespace AlibabaCloud.SDK.Csas20230120
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("csas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>挂载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AttachApplication2ConnectorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachApplication2ConnectorResponse
        /// </returns>
        public AttachApplication2ConnectorResponse AttachApplication2ConnectorWithOptions(AttachApplication2ConnectorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachApplication2ConnectorShrinkRequest request = new AttachApplication2ConnectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationIds))
            {
                request.ApplicationIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationIds, "ApplicationIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIdsShrink))
            {
                body["ApplicationIds"] = request.ApplicationIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachApplication2Connector",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachApplication2ConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AttachApplication2ConnectorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachApplication2ConnectorResponse
        /// </returns>
        public async Task<AttachApplication2ConnectorResponse> AttachApplication2ConnectorWithOptionsAsync(AttachApplication2ConnectorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachApplication2ConnectorShrinkRequest request = new AttachApplication2ConnectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationIds))
            {
                request.ApplicationIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationIds, "ApplicationIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIdsShrink))
            {
                body["ApplicationIds"] = request.ApplicationIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachApplication2Connector",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachApplication2ConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachApplication2ConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachApplication2ConnectorResponse
        /// </returns>
        public AttachApplication2ConnectorResponse AttachApplication2Connector(AttachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachApplication2ConnectorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachApplication2ConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachApplication2ConnectorResponse
        /// </returns>
        public async Task<AttachApplication2ConnectorResponse> AttachApplication2ConnectorAsync(AttachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachApplication2ConnectorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载业务策略至指定审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicy2ApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicy2ApprovalProcessResponse
        /// </returns>
        public AttachPolicy2ApprovalProcessResponse AttachPolicy2ApprovalProcessWithOptions(AttachPolicy2ApprovalProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["ProcessId"] = request.ProcessId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicy2ApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicy2ApprovalProcessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载业务策略至指定审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicy2ApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicy2ApprovalProcessResponse
        /// </returns>
        public async Task<AttachPolicy2ApprovalProcessResponse> AttachPolicy2ApprovalProcessWithOptionsAsync(AttachPolicy2ApprovalProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["ProcessId"] = request.ProcessId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachPolicy2ApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachPolicy2ApprovalProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载业务策略至指定审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicy2ApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicy2ApprovalProcessResponse
        /// </returns>
        public AttachPolicy2ApprovalProcessResponse AttachPolicy2ApprovalProcess(AttachPolicy2ApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachPolicy2ApprovalProcessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>挂载业务策略至指定审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachPolicy2ApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachPolicy2ApprovalProcessResponse
        /// </returns>
        public async Task<AttachPolicy2ApprovalProcessResponse> AttachPolicy2ApprovalProcessAsync(AttachPolicy2ApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachPolicy2ApprovalProcessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批流程</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApprovalProcessResponse
        /// </returns>
        public CreateApprovalProcessResponse CreateApprovalProcessWithOptions(CreateApprovalProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApprovalProcessShrinkRequest request = new CreateApprovalProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MatchSchemas))
            {
                request.MatchSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MatchSchemas, "MatchSchemas", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchSchemasShrink))
            {
                body["MatchSchemas"] = request.MatchSchemasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["ProcessName"] = request.ProcessName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNodes))
            {
                bodyFlat["ProcessNodes"] = request.ProcessNodes;
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
                Action = "CreateApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApprovalProcessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批流程</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApprovalProcessResponse
        /// </returns>
        public async Task<CreateApprovalProcessResponse> CreateApprovalProcessWithOptionsAsync(CreateApprovalProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApprovalProcessShrinkRequest request = new CreateApprovalProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MatchSchemas))
            {
                request.MatchSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MatchSchemas, "MatchSchemas", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchSchemasShrink))
            {
                body["MatchSchemas"] = request.MatchSchemasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["ProcessName"] = request.ProcessName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNodes))
            {
                bodyFlat["ProcessNodes"] = request.ProcessNodes;
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
                Action = "CreateApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApprovalProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApprovalProcessResponse
        /// </returns>
        public CreateApprovalProcessResponse CreateApprovalProcess(CreateApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApprovalProcessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApprovalProcessResponse
        /// </returns>
        public async Task<CreateApprovalProcessResponse> CreateApprovalProcessAsync(CreateApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApprovalProcessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientUserResponse
        /// </returns>
        public CreateClientUserResponse CreateClientUserWithOptions(CreateClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                query["MobileNumber"] = request.MobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "CreateClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientUserResponse
        /// </returns>
        public async Task<CreateClientUserResponse> CreateClientUserWithOptionsAsync(CreateClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                query["MobileNumber"] = request.MobileNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "CreateClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientUserResponse
        /// </returns>
        public CreateClientUserResponse CreateClientUser(CreateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientUserResponse
        /// </returns>
        public async Task<CreateClientUserResponse> CreateClientUserAsync(CreateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDynamicRouteResponse
        /// </returns>
        public CreateDynamicRouteResponse CreateDynamicRouteWithOptions(CreateDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteType))
            {
                body["DynamicRouteType"] = request.DynamicRouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                body["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIds))
            {
                bodyFlat["RegionIds"] = request.RegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "CreateDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDynamicRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDynamicRouteResponse
        /// </returns>
        public async Task<CreateDynamicRouteResponse> CreateDynamicRouteWithOptionsAsync(CreateDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteType))
            {
                body["DynamicRouteType"] = request.DynamicRouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                body["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIds))
            {
                bodyFlat["RegionIds"] = request.RegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "CreateDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDynamicRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDynamicRouteResponse
        /// </returns>
        public CreateDynamicRouteResponse CreateDynamicRoute(CreateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDynamicRouteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDynamicRouteResponse
        /// </returns>
        public async Task<CreateDynamicRouteResponse> CreateDynamicRouteAsync(CreateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDynamicRouteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdpDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIdpDepartmentResponse
        /// </returns>
        public CreateIdpDepartmentResponse CreateIdpDepartmentWithOptions(CreateIdpDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdpDepartment",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdpDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdpDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIdpDepartmentResponse
        /// </returns>
        public async Task<CreateIdpDepartmentResponse> CreateIdpDepartmentWithOptionsAsync(CreateIdpDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIdpDepartment",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIdpDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdpDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIdpDepartmentResponse
        /// </returns>
        public CreateIdpDepartmentResponse CreateIdpDepartment(CreateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIdpDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIdpDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIdpDepartmentResponse
        /// </returns>
        public async Task<CreateIdpDepartmentResponse> CreateIdpDepartmentAsync(CreateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIdpDepartmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessApplicationResponse
        /// </returns>
        public CreatePrivateAccessApplicationResponse CreatePrivateAccessApplicationWithOptions(CreatePrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                bodyFlat["Addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserAccessStatus))
            {
                body["BrowserAccessStatus"] = request.BrowserAccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainAutomaticPrefix))
            {
                body["L7ProxyDomainAutomaticPrefix"] = request.L7ProxyDomainAutomaticPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainCustom))
            {
                body["L7ProxyDomainCustom"] = request.L7ProxyDomainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                bodyFlat["PortRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "CreatePrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrivateAccessApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessApplicationResponse
        /// </returns>
        public async Task<CreatePrivateAccessApplicationResponse> CreatePrivateAccessApplicationWithOptionsAsync(CreatePrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                bodyFlat["Addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BrowserAccessStatus))
            {
                body["BrowserAccessStatus"] = request.BrowserAccessStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainAutomaticPrefix))
            {
                body["L7ProxyDomainAutomaticPrefix"] = request.L7ProxyDomainAutomaticPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainCustom))
            {
                body["L7ProxyDomainCustom"] = request.L7ProxyDomainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                bodyFlat["PortRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "CreatePrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrivateAccessApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessApplicationResponse
        /// </returns>
        public CreatePrivateAccessApplicationResponse CreatePrivateAccessApplication(CreatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrivateAccessApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessApplicationResponse
        /// </returns>
        public async Task<CreatePrivateAccessApplicationResponse> CreatePrivateAccessApplicationAsync(CreatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessPolicyResponse
        /// </returns>
        public CreatePrivateAccessPolicyResponse CreatePrivateAccessPolicyWithOptions(CreatePrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserAttributes))
            {
                bodyFlat["CustomUserAttributes"] = request.CustomUserAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeAction))
            {
                body["DeviceAttributeAction"] = request.DeviceAttributeAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeId))
            {
                body["DeviceAttributeId"] = request.DeviceAttributeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyAction))
            {
                body["PolicyAction"] = request.PolicyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupMode))
            {
                body["UserGroupMode"] = request.UserGroupMode;
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
                Action = "CreatePrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessPolicyResponse
        /// </returns>
        public async Task<CreatePrivateAccessPolicyResponse> CreatePrivateAccessPolicyWithOptionsAsync(CreatePrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserAttributes))
            {
                bodyFlat["CustomUserAttributes"] = request.CustomUserAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeAction))
            {
                body["DeviceAttributeAction"] = request.DeviceAttributeAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeId))
            {
                body["DeviceAttributeId"] = request.DeviceAttributeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyAction))
            {
                body["PolicyAction"] = request.PolicyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupMode))
            {
                body["UserGroupMode"] = request.UserGroupMode;
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
                Action = "CreatePrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessPolicyResponse
        /// </returns>
        public CreatePrivateAccessPolicyResponse CreatePrivateAccessPolicy(CreatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessPolicyResponse
        /// </returns>
        public async Task<CreatePrivateAccessPolicyResponse> CreatePrivateAccessPolicyAsync(CreatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessTagResponse
        /// </returns>
        public CreatePrivateAccessTagResponse CreatePrivateAccessTagWithOptions(CreatePrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrivateAccessTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessTagResponse
        /// </returns>
        public async Task<CreatePrivateAccessTagResponse> CreatePrivateAccessTagWithOptionsAsync(CreatePrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrivateAccessTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessTagResponse
        /// </returns>
        public CreatePrivateAccessTagResponse CreatePrivateAccessTag(CreatePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrivateAccessTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePrivateAccessTagResponse
        /// </returns>
        public async Task<CreatePrivateAccessTagResponse> CreatePrivateAccessTagAsync(CreatePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRegistrationPolicyResponse
        /// </returns>
        public CreateRegistrationPolicyResponse CreateRegistrationPolicyWithOptions(CreateRegistrationPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRegistrationPolicyShrinkRequest request = new CreateRegistrationPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CompanyLimitCount))
            {
                request.CompanyLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CompanyLimitCount, "CompanyLimitCount", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonalLimitCount))
            {
                request.PersonalLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonalLimitCount, "PersonalLimitCount", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitCountShrink))
            {
                body["CompanyLimitCount"] = request.CompanyLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitType))
            {
                body["CompanyLimitType"] = request.CompanyLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                body["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitCountShrink))
            {
                body["PersonalLimitCount"] = request.PersonalLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitType))
            {
                body["PersonalLimitType"] = request.PersonalLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                bodyFlat["Whitelist"] = request.Whitelist;
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
                Action = "CreateRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRegistrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRegistrationPolicyResponse
        /// </returns>
        public async Task<CreateRegistrationPolicyResponse> CreateRegistrationPolicyWithOptionsAsync(CreateRegistrationPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRegistrationPolicyShrinkRequest request = new CreateRegistrationPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CompanyLimitCount))
            {
                request.CompanyLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CompanyLimitCount, "CompanyLimitCount", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonalLimitCount))
            {
                request.PersonalLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonalLimitCount, "PersonalLimitCount", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitCountShrink))
            {
                body["CompanyLimitCount"] = request.CompanyLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitType))
            {
                body["CompanyLimitType"] = request.CompanyLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                body["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitCountShrink))
            {
                body["PersonalLimitCount"] = request.PersonalLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitType))
            {
                body["PersonalLimitType"] = request.PersonalLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                bodyFlat["Whitelist"] = request.Whitelist;
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
                Action = "CreateRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRegistrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRegistrationPolicyResponse
        /// </returns>
        public CreateRegistrationPolicyResponse CreateRegistrationPolicy(CreateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRegistrationPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRegistrationPolicyResponse
        /// </returns>
        public async Task<CreateRegistrationPolicyResponse> CreateRegistrationPolicyAsync(CreateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public CreateUserGroupResponse CreateUserGroupWithOptions(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                bodyFlat["Attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "CreateUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public async Task<CreateUserGroupResponse> CreateUserGroupWithOptionsAsync(CreateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                bodyFlat["Attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
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
                Action = "CreateUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUserGroupResponse
        /// </returns>
        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字水印暗水印透明底图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmBaseImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmBaseImageResponse
        /// </returns>
        public CreateWmBaseImageResponse CreateWmBaseImageWithOptions(CreateWmBaseImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Opacity))
            {
                body["Opacity"] = request.Opacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scale))
            {
                body["Scale"] = request.Scale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["Width"] = request.Width;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoBytesB64))
            {
                body["WmInfoBytesB64"] = request.WmInfoBytesB64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoUint))
            {
                body["WmInfoUint"] = request.WmInfoUint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmBaseImage",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmBaseImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字水印暗水印透明底图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmBaseImageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmBaseImageResponse
        /// </returns>
        public async Task<CreateWmBaseImageResponse> CreateWmBaseImageWithOptionsAsync(CreateWmBaseImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Height))
            {
                body["Height"] = request.Height;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Opacity))
            {
                body["Opacity"] = request.Opacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scale))
            {
                body["Scale"] = request.Scale;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Width))
            {
                body["Width"] = request.Width;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoBytesB64))
            {
                body["WmInfoBytesB64"] = request.WmInfoBytesB64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoUint))
            {
                body["WmInfoUint"] = request.WmInfoUint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmBaseImage",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmBaseImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字水印暗水印透明底图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmBaseImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmBaseImageResponse
        /// </returns>
        public CreateWmBaseImageResponse CreateWmBaseImage(CreateWmBaseImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmBaseImageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数字水印暗水印透明底图</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmBaseImageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmBaseImageResponse
        /// </returns>
        public async Task<CreateWmBaseImageResponse> CreateWmBaseImageAsync(CreateWmBaseImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmBaseImageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWmEmbedTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmEmbedTaskResponse
        /// </returns>
        public CreateWmEmbedTaskResponse CreateWmEmbedTaskWithOptions(CreateWmEmbedTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWmEmbedTaskShrinkRequest request = new CreateWmEmbedTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CsvControl))
            {
                request.CsvControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CsvControl, "CsvControl", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentControl))
            {
                request.DocumentControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentControl, "DocumentControl", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsvControlShrink))
            {
                query["CsvControl"] = request.CsvControlShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentControlShrink))
            {
                body["DocumentControl"] = request.DocumentControlShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                body["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageEmbedJpegQuality))
            {
                body["ImageEmbedJpegQuality"] = request.ImageEmbedJpegQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageEmbedLevel))
            {
                body["ImageEmbedLevel"] = request.ImageEmbedLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoBitrate))
            {
                body["VideoBitrate"] = request.VideoBitrate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIsLong))
            {
                body["VideoIsLong"] = request.VideoIsLong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoBytesB64))
            {
                body["WmInfoBytesB64"] = request.WmInfoBytesB64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoUint))
            {
                body["WmInfoUint"] = request.WmInfoUint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmEmbedTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmEmbedTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWmEmbedTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmEmbedTaskResponse
        /// </returns>
        public async Task<CreateWmEmbedTaskResponse> CreateWmEmbedTaskWithOptionsAsync(CreateWmEmbedTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWmEmbedTaskShrinkRequest request = new CreateWmEmbedTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CsvControl))
            {
                request.CsvControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CsvControl, "CsvControl", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentControl))
            {
                request.DocumentControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentControl, "DocumentControl", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsvControlShrink))
            {
                query["CsvControl"] = request.CsvControlShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentControlShrink))
            {
                body["DocumentControl"] = request.DocumentControlShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                body["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageEmbedJpegQuality))
            {
                body["ImageEmbedJpegQuality"] = request.ImageEmbedJpegQuality;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageEmbedLevel))
            {
                body["ImageEmbedLevel"] = request.ImageEmbedLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoBitrate))
            {
                body["VideoBitrate"] = request.VideoBitrate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIsLong))
            {
                body["VideoIsLong"] = request.VideoIsLong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoBytesB64))
            {
                body["WmInfoBytesB64"] = request.WmInfoBytesB64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoUint))
            {
                body["WmInfoUint"] = request.WmInfoUint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmEmbedTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmEmbedTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmEmbedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmEmbedTaskResponse
        /// </returns>
        public CreateWmEmbedTaskResponse CreateWmEmbedTask(CreateWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmEmbedTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmEmbedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmEmbedTaskResponse
        /// </returns>
        public async Task<CreateWmEmbedTaskResponse> CreateWmEmbedTaskAsync(CreateWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmEmbedTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件水印提取任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWmExtractTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmExtractTaskResponse
        /// </returns>
        public CreateWmExtractTaskResponse CreateWmExtractTaskWithOptions(CreateWmExtractTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWmExtractTaskShrinkRequest request = new CreateWmExtractTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CsvControl))
            {
                request.CsvControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CsvControl, "CsvControl", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsvControlShrink))
            {
                query["CsvControl"] = request.CsvControlShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIsCapture))
            {
                body["DocumentIsCapture"] = request.DocumentIsCapture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                body["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIsLong))
            {
                body["VideoIsLong"] = request.VideoIsLong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoSpeed))
            {
                body["VideoSpeed"] = request.VideoSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmExtractTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmExtractTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件水印提取任务</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateWmExtractTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmExtractTaskResponse
        /// </returns>
        public async Task<CreateWmExtractTaskResponse> CreateWmExtractTaskWithOptionsAsync(CreateWmExtractTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWmExtractTaskShrinkRequest request = new CreateWmExtractTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CsvControl))
            {
                request.CsvControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CsvControl, "CsvControl", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CsvControlShrink))
            {
                query["CsvControl"] = request.CsvControlShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentIsCapture))
            {
                body["DocumentIsCapture"] = request.DocumentIsCapture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileUrl))
            {
                body["FileUrl"] = request.FileUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filename))
            {
                body["Filename"] = request.Filename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoIsLong))
            {
                body["VideoIsLong"] = request.VideoIsLong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VideoSpeed))
            {
                body["VideoSpeed"] = request.VideoSpeed;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmExtractTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmExtractTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件水印提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmExtractTaskResponse
        /// </returns>
        public CreateWmExtractTaskResponse CreateWmExtractTask(CreateWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmExtractTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建文件水印提取任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmExtractTaskResponse
        /// </returns>
        public async Task<CreateWmExtractTaskResponse> CreateWmExtractTaskAsync(CreateWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmExtractTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一条字符串水印信息到数字水印信息的映射记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmInfoMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmInfoMappingResponse
        /// </returns>
        public CreateWmInfoMappingResponse CreateWmInfoMappingWithOptions(CreateWmInfoMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoBytesB64))
            {
                body["WmInfoBytesB64"] = request.WmInfoBytesB64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmInfoMapping",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmInfoMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一条字符串水印信息到数字水印信息的映射记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmInfoMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWmInfoMappingResponse
        /// </returns>
        public async Task<CreateWmInfoMappingResponse> CreateWmInfoMappingWithOptionsAsync(CreateWmInfoMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoBytesB64))
            {
                body["WmInfoBytesB64"] = request.WmInfoBytesB64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmInfoSize))
            {
                body["WmInfoSize"] = request.WmInfoSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WmType))
            {
                body["WmType"] = request.WmType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWmInfoMapping",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWmInfoMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一条字符串水印信息到数字水印信息的映射记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmInfoMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmInfoMappingResponse
        /// </returns>
        public CreateWmInfoMappingResponse CreateWmInfoMapping(CreateWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmInfoMappingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一条字符串水印信息到数字水印信息的映射记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateWmInfoMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWmInfoMappingResponse
        /// </returns>
        public async Task<CreateWmInfoMappingResponse> CreateWmInfoMappingAsync(CreateWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmInfoMappingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApprovalProcessesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApprovalProcessesResponse
        /// </returns>
        public DeleteApprovalProcessesResponse DeleteApprovalProcessesWithOptions(DeleteApprovalProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIds))
            {
                bodyFlat["ProcessIds"] = request.ProcessIds;
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
                Action = "DeleteApprovalProcesses",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApprovalProcessesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApprovalProcessesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApprovalProcessesResponse
        /// </returns>
        public async Task<DeleteApprovalProcessesResponse> DeleteApprovalProcessesWithOptionsAsync(DeleteApprovalProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessIds))
            {
                bodyFlat["ProcessIds"] = request.ProcessIds;
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
                Action = "DeleteApprovalProcesses",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApprovalProcessesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApprovalProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApprovalProcessesResponse
        /// </returns>
        public DeleteApprovalProcessesResponse DeleteApprovalProcesses(DeleteApprovalProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApprovalProcessesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApprovalProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApprovalProcessesResponse
        /// </returns>
        public async Task<DeleteApprovalProcessesResponse> DeleteApprovalProcessesAsync(DeleteApprovalProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApprovalProcessesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientUserResponse
        /// </returns>
        public DeleteClientUserResponse DeleteClientUserWithOptions(DeleteClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientUserResponse
        /// </returns>
        public async Task<DeleteClientUserResponse> DeleteClientUserWithOptionsAsync(DeleteClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientUserResponse
        /// </returns>
        public DeleteClientUserResponse DeleteClientUser(DeleteClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientUserResponse
        /// </returns>
        public async Task<DeleteClientUserResponse> DeleteClientUserAsync(DeleteClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDynamicRouteResponse
        /// </returns>
        public DeleteDynamicRouteResponse DeleteDynamicRouteWithOptions(DeleteDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteId))
            {
                query["DynamicRouteId"] = request.DynamicRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDynamicRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDynamicRouteResponse
        /// </returns>
        public async Task<DeleteDynamicRouteResponse> DeleteDynamicRouteWithOptionsAsync(DeleteDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteId))
            {
                query["DynamicRouteId"] = request.DynamicRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDynamicRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDynamicRouteResponse
        /// </returns>
        public DeleteDynamicRouteResponse DeleteDynamicRoute(DeleteDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDynamicRouteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDynamicRouteResponse
        /// </returns>
        public async Task<DeleteDynamicRouteResponse> DeleteDynamicRouteAsync(DeleteDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDynamicRouteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdpDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdpDepartmentResponse
        /// </returns>
        public DeleteIdpDepartmentResponse DeleteIdpDepartmentWithOptions(DeleteIdpDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdpDepartment",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdpDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdpDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdpDepartmentResponse
        /// </returns>
        public async Task<DeleteIdpDepartmentResponse> DeleteIdpDepartmentWithOptionsAsync(DeleteIdpDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIdpDepartment",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIdpDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdpDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdpDepartmentResponse
        /// </returns>
        public DeleteIdpDepartmentResponse DeleteIdpDepartment(DeleteIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIdpDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIdpDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIdpDepartmentResponse
        /// </returns>
        public async Task<DeleteIdpDepartmentResponse> DeleteIdpDepartmentAsync(DeleteIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIdpDepartmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessApplicationResponse
        /// </returns>
        public DeletePrivateAccessApplicationResponse DeletePrivateAccessApplicationWithOptions(DeletePrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivateAccessApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessApplicationResponse
        /// </returns>
        public async Task<DeletePrivateAccessApplicationResponse> DeletePrivateAccessApplicationWithOptionsAsync(DeletePrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivateAccessApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessApplicationResponse
        /// </returns>
        public DeletePrivateAccessApplicationResponse DeletePrivateAccessApplication(DeletePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivateAccessApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessApplicationResponse
        /// </returns>
        public async Task<DeletePrivateAccessApplicationResponse> DeletePrivateAccessApplicationAsync(DeletePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessPolicyResponse
        /// </returns>
        public DeletePrivateAccessPolicyResponse DeletePrivateAccessPolicyWithOptions(DeletePrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessPolicyResponse
        /// </returns>
        public async Task<DeletePrivateAccessPolicyResponse> DeletePrivateAccessPolicyWithOptionsAsync(DeletePrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessPolicyResponse
        /// </returns>
        public DeletePrivateAccessPolicyResponse DeletePrivateAccessPolicy(DeletePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessPolicyResponse
        /// </returns>
        public async Task<DeletePrivateAccessPolicyResponse> DeletePrivateAccessPolicyAsync(DeletePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessTagResponse
        /// </returns>
        public DeletePrivateAccessTagResponse DeletePrivateAccessTagWithOptions(DeletePrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                body["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivateAccessTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessTagResponse
        /// </returns>
        public async Task<DeletePrivateAccessTagResponse> DeletePrivateAccessTagWithOptionsAsync(DeletePrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagId))
            {
                body["TagId"] = request.TagId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePrivateAccessTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessTagResponse
        /// </returns>
        public DeletePrivateAccessTagResponse DeletePrivateAccessTag(DeletePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivateAccessTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePrivateAccessTagResponse
        /// </returns>
        public async Task<DeletePrivateAccessTagResponse> DeletePrivateAccessTagAsync(DeletePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrationPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrationPoliciesResponse
        /// </returns>
        public DeleteRegistrationPoliciesResponse DeleteRegistrationPoliciesWithOptions(DeleteRegistrationPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIds))
            {
                bodyFlat["PolicyIds"] = request.PolicyIds;
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
                Action = "DeleteRegistrationPolicies",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRegistrationPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrationPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrationPoliciesResponse
        /// </returns>
        public async Task<DeleteRegistrationPoliciesResponse> DeleteRegistrationPoliciesWithOptionsAsync(DeleteRegistrationPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyIds))
            {
                bodyFlat["PolicyIds"] = request.PolicyIds;
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
                Action = "DeleteRegistrationPolicies",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRegistrationPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrationPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrationPoliciesResponse
        /// </returns>
        public DeleteRegistrationPoliciesResponse DeleteRegistrationPolicies(DeleteRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRegistrationPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteRegistrationPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteRegistrationPoliciesResponse
        /// </returns>
        public async Task<DeleteRegistrationPoliciesResponse> DeleteRegistrationPoliciesAsync(DeleteRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRegistrationPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除用户非在线设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDevicesResponse
        /// </returns>
        public DeleteUserDevicesResponse DeleteUserDevicesWithOptions(DeleteUserDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
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
                Action = "DeleteUserDevices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDevicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除用户非在线设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDevicesResponse
        /// </returns>
        public async Task<DeleteUserDevicesResponse> DeleteUserDevicesWithOptionsAsync(DeleteUserDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
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
                Action = "DeleteUserDevices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除用户非在线设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDevicesResponse
        /// </returns>
        public DeleteUserDevicesResponse DeleteUserDevices(DeleteUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserDevicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除用户非在线设备</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserDevicesResponse
        /// </returns>
        public async Task<DeleteUserDevicesResponse> DeleteUserDevicesAsync(DeleteUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserDevicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public DeleteUserGroupResponse DeleteUserGroupWithOptions(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                body["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public async Task<DeleteUserGroupResponse> DeleteUserGroupWithOptionsAsync(DeleteUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                body["UserGroupId"] = request.UserGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUserGroupResponse
        /// </returns>
        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetachApplication2ConnectorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachApplication2ConnectorResponse
        /// </returns>
        public DetachApplication2ConnectorResponse DetachApplication2ConnectorWithOptions(DetachApplication2ConnectorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachApplication2ConnectorShrinkRequest request = new DetachApplication2ConnectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationIds))
            {
                request.ApplicationIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationIds, "ApplicationIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIdsShrink))
            {
                body["ApplicationIds"] = request.ApplicationIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachApplication2Connector",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachApplication2ConnectorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetachApplication2ConnectorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachApplication2ConnectorResponse
        /// </returns>
        public async Task<DetachApplication2ConnectorResponse> DetachApplication2ConnectorWithOptionsAsync(DetachApplication2ConnectorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachApplication2ConnectorShrinkRequest request = new DetachApplication2ConnectorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApplicationIds))
            {
                request.ApplicationIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApplicationIds, "ApplicationIds", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIdsShrink))
            {
                body["ApplicationIds"] = request.ApplicationIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectorId))
            {
                body["ConnectorId"] = request.ConnectorId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachApplication2Connector",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachApplication2ConnectorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachApplication2ConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachApplication2ConnectorResponse
        /// </returns>
        public DetachApplication2ConnectorResponse DetachApplication2Connector(DetachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachApplication2ConnectorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>卸载connector的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachApplication2ConnectorRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachApplication2ConnectorResponse
        /// </returns>
        public async Task<DetachApplication2ConnectorResponse> DetachApplication2ConnectorAsync(DetachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachApplication2ConnectorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑业务策略与审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicy2ApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicy2ApprovalProcessResponse
        /// </returns>
        public DetachPolicy2ApprovalProcessResponse DetachPolicy2ApprovalProcessWithOptions(DetachPolicy2ApprovalProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["ProcessId"] = request.ProcessId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicy2ApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicy2ApprovalProcessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑业务策略与审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicy2ApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicy2ApprovalProcessResponse
        /// </returns>
        public async Task<DetachPolicy2ApprovalProcessResponse> DetachPolicy2ApprovalProcessWithOptionsAsync(DetachPolicy2ApprovalProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["ProcessId"] = request.ProcessId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachPolicy2ApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachPolicy2ApprovalProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑业务策略与审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicy2ApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicy2ApprovalProcessResponse
        /// </returns>
        public DetachPolicy2ApprovalProcessResponse DetachPolicy2ApprovalProcess(DetachPolicy2ApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachPolicy2ApprovalProcessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解绑业务策略与审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachPolicy2ApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachPolicy2ApprovalProcessResponse
        /// </returns>
        public async Task<DetachPolicy2ApprovalProcessResponse> DetachPolicy2ApprovalProcessAsync(DetachPolicy2ApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachPolicy2ApprovalProcessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportUserDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportUserDevicesResponse
        /// </returns>
        public ExportUserDevicesResponse ExportUserDevicesWithOptions(ExportUserDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStatuses))
            {
                bodyFlat["AppStatuses"] = request.AppStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                body["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceBelong))
            {
                body["DeviceBelong"] = request.DeviceBelong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceStatuses))
            {
                bodyFlat["DeviceStatuses"] = request.DeviceStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypes))
            {
                bodyFlat["DeviceTypes"] = request.DeviceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlpStatuses))
            {
                bodyFlat["DlpStatuses"] = request.DlpStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hostname))
            {
                body["Hostname"] = request.Hostname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaStatuses))
            {
                bodyFlat["IaStatuses"] = request.IaStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacStatuses))
            {
                bodyFlat["NacStatuses"] = request.NacStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaStatuses))
            {
                bodyFlat["PaStatuses"] = request.PaStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaseUserId))
            {
                body["SaseUserId"] = request.SaseUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharingStatus))
            {
                body["SharingStatus"] = request.SharingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
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
                Action = "ExportUserDevices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportUserDevicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportUserDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExportUserDevicesResponse
        /// </returns>
        public async Task<ExportUserDevicesResponse> ExportUserDevicesWithOptionsAsync(ExportUserDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppStatuses))
            {
                bodyFlat["AppStatuses"] = request.AppStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                body["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceBelong))
            {
                body["DeviceBelong"] = request.DeviceBelong;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceStatuses))
            {
                bodyFlat["DeviceStatuses"] = request.DeviceStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTypes))
            {
                bodyFlat["DeviceTypes"] = request.DeviceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DlpStatuses))
            {
                bodyFlat["DlpStatuses"] = request.DlpStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hostname))
            {
                body["Hostname"] = request.Hostname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaStatuses))
            {
                bodyFlat["IaStatuses"] = request.IaStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mac))
            {
                body["Mac"] = request.Mac;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacStatuses))
            {
                bodyFlat["NacStatuses"] = request.NacStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaStatuses))
            {
                bodyFlat["PaStatuses"] = request.PaStatuses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaseUserId))
            {
                body["SaseUserId"] = request.SaseUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharingStatus))
            {
                body["SharingStatus"] = request.SharingStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["Username"] = request.Username;
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
                Action = "ExportUserDevices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExportUserDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportUserDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportUserDevicesResponse
        /// </returns>
        public ExportUserDevicesResponse ExportUserDevices(ExportUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportUserDevicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExportUserDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ExportUserDevicesResponse
        /// </returns>
        public async Task<ExportUserDevicesResponse> ExportUserDevicesAsync(ExportUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportUserDevicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已启用的身份源配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActiveIdpConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActiveIdpConfigResponse
        /// </returns>
        public GetActiveIdpConfigResponse GetActiveIdpConfigWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetActiveIdpConfig",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActiveIdpConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已启用的身份源配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetActiveIdpConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetActiveIdpConfigResponse
        /// </returns>
        public async Task<GetActiveIdpConfigResponse> GetActiveIdpConfigWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetActiveIdpConfig",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetActiveIdpConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已启用的身份源配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetActiveIdpConfigResponse
        /// </returns>
        public GetActiveIdpConfigResponse GetActiveIdpConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetActiveIdpConfigWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询已启用的身份源配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetActiveIdpConfigResponse
        /// </returns>
        public async Task<GetActiveIdpConfigResponse> GetActiveIdpConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetActiveIdpConfigWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalResponse
        /// </returns>
        public GetApprovalResponse GetApprovalWithOptions(GetApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApproval",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApprovalResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalResponse
        /// </returns>
        public async Task<GetApprovalResponse> GetApprovalWithOptionsAsync(GetApprovalRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApproval",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApprovalResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalResponse
        /// </returns>
        public GetApprovalResponse GetApproval(GetApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApprovalWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalResponse
        /// </returns>
        public async Task<GetApprovalResponse> GetApprovalAsync(GetApprovalRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApprovalWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalProcessResponse
        /// </returns>
        public GetApprovalProcessResponse GetApprovalProcessWithOptions(GetApprovalProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApprovalProcessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalProcessResponse
        /// </returns>
        public async Task<GetApprovalProcessResponse> GetApprovalProcessWithOptionsAsync(GetApprovalProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApprovalProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalProcessResponse
        /// </returns>
        public GetApprovalProcessResponse GetApprovalProcess(GetApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApprovalProcessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalProcessResponse
        /// </returns>
        public async Task<GetApprovalProcessResponse> GetApprovalProcessAsync(GetApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApprovalProcessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalSchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalSchemaResponse
        /// </returns>
        public GetApprovalSchemaResponse GetApprovalSchemaWithOptions(GetApprovalSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApprovalSchema",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApprovalSchemaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalSchemaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalSchemaResponse
        /// </returns>
        public async Task<GetApprovalSchemaResponse> GetApprovalSchemaWithOptionsAsync(GetApprovalSchemaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApprovalSchema",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApprovalSchemaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalSchemaResponse
        /// </returns>
        public GetApprovalSchemaResponse GetApprovalSchema(GetApprovalSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApprovalSchemaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApprovalSchemaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApprovalSchemaResponse
        /// </returns>
        public async Task<GetApprovalSchemaResponse> GetApprovalSchemaAsync(GetApprovalSchemaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApprovalSchemaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBootAndAntiUninstallPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBootAndAntiUninstallPolicyResponse
        /// </returns>
        public GetBootAndAntiUninstallPolicyResponse GetBootAndAntiUninstallPolicyWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBootAndAntiUninstallPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBootAndAntiUninstallPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetBootAndAntiUninstallPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetBootAndAntiUninstallPolicyResponse
        /// </returns>
        public async Task<GetBootAndAntiUninstallPolicyResponse> GetBootAndAntiUninstallPolicyWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBootAndAntiUninstallPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBootAndAntiUninstallPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetBootAndAntiUninstallPolicyResponse
        /// </returns>
        public GetBootAndAntiUninstallPolicyResponse GetBootAndAntiUninstallPolicy()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBootAndAntiUninstallPolicyWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetBootAndAntiUninstallPolicyResponse
        /// </returns>
        public async Task<GetBootAndAntiUninstallPolicyResponse> GetBootAndAntiUninstallPolicyAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBootAndAntiUninstallPolicyWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientUserResponse
        /// </returns>
        public GetClientUserResponse GetClientUserWithOptions(GetClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClientUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClientUserResponse
        /// </returns>
        public async Task<GetClientUserResponse> GetClientUserWithOptionsAsync(GetClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClientUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientUserResponse
        /// </returns>
        public GetClientUserResponse GetClientUser(GetClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClientUserResponse
        /// </returns>
        public async Task<GetClientUserResponse> GetClientUserAsync(GetClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态路由详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDynamicRouteResponse
        /// </returns>
        public GetDynamicRouteResponse GetDynamicRouteWithOptions(GetDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDynamicRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态路由详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetDynamicRouteResponse
        /// </returns>
        public async Task<GetDynamicRouteResponse> GetDynamicRouteWithOptionsAsync(GetDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDynamicRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态路由详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDynamicRouteResponse
        /// </returns>
        public GetDynamicRouteResponse GetDynamicRoute(GetDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDynamicRouteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询动态路由详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// GetDynamicRouteResponse
        /// </returns>
        public async Task<GetDynamicRouteResponse> GetDynamicRouteAsync(GetDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDynamicRouteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份源配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdpConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdpConfigResponse
        /// </returns>
        public GetIdpConfigResponse GetIdpConfigWithOptions(GetIdpConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdpConfig",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdpConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份源配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdpConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIdpConfigResponse
        /// </returns>
        public async Task<GetIdpConfigResponse> GetIdpConfigWithOptionsAsync(GetIdpConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIdpConfig",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIdpConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份源配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdpConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdpConfigResponse
        /// </returns>
        public GetIdpConfigResponse GetIdpConfig(GetIdpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIdpConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询身份源配置详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetIdpConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// GetIdpConfigResponse
        /// </returns>
        public async Task<GetIdpConfigResponse> GetIdpConfigAsync(GetIdpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIdpConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessApplicationResponse
        /// </returns>
        public GetPrivateAccessApplicationResponse GetPrivateAccessApplicationWithOptions(GetPrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrivateAccessApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessApplicationResponse
        /// </returns>
        public async Task<GetPrivateAccessApplicationResponse> GetPrivateAccessApplicationWithOptionsAsync(GetPrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrivateAccessApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessApplicationResponse
        /// </returns>
        public GetPrivateAccessApplicationResponse GetPrivateAccessApplication(GetPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrivateAccessApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问应用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessApplicationResponse
        /// </returns>
        public async Task<GetPrivateAccessApplicationResponse> GetPrivateAccessApplicationAsync(GetPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessPolicyResponse
        /// </returns>
        public GetPrivateAccessPolicyResponse GetPrivateAccessPolicyWithOptions(GetPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessPolicyResponse
        /// </returns>
        public async Task<GetPrivateAccessPolicyResponse> GetPrivateAccessPolicyWithOptionsAsync(GetPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessPolicyResponse
        /// </returns>
        public GetPrivateAccessPolicyResponse GetPrivateAccessPolicy(GetPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询内网访问策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPrivateAccessPolicyResponse
        /// </returns>
        public async Task<GetPrivateAccessPolicyResponse> GetPrivateAccessPolicyAsync(GetPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRegistrationPolicyResponse
        /// </returns>
        public GetRegistrationPolicyResponse GetRegistrationPolicyWithOptions(GetRegistrationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegistrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRegistrationPolicyResponse
        /// </returns>
        public async Task<GetRegistrationPolicyResponse> GetRegistrationPolicyWithOptionsAsync(GetRegistrationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRegistrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRegistrationPolicyResponse
        /// </returns>
        public GetRegistrationPolicyResponse GetRegistrationPolicy(GetRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegistrationPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRegistrationPolicyResponse
        /// </returns>
        public async Task<GetRegistrationPolicyResponse> GetRegistrationPolicyAsync(GetRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeviceResponse
        /// </returns>
        public GetUserDeviceResponse GetUserDeviceWithOptions(GetUserDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserDevice",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeviceResponse
        /// </returns>
        public async Task<GetUserDeviceResponse> GetUserDeviceWithOptionsAsync(GetUserDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserDevice",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeviceResponse
        /// </returns>
        public GetUserDeviceResponse GetUserDevice(GetUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserDeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserDeviceResponse
        /// </returns>
        public async Task<GetUserDeviceResponse> GetUserDeviceAsync(GetUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserDeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public GetUserGroupResponse GetUserGroupWithOptions(GetUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public async Task<GetUserGroupResponse> GetUserGroupWithOptionsAsync(GetUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public GetUserGroupResponse GetUserGroup(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// GetUserGroupResponse
        /// </returns>
        public async Task<GetUserGroupResponse> GetUserGroupAsync(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmEmbedTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWmEmbedTaskResponse
        /// </returns>
        public GetWmEmbedTaskResponse GetWmEmbedTaskWithOptions(GetWmEmbedTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWmEmbedTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWmEmbedTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmEmbedTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWmEmbedTaskResponse
        /// </returns>
        public async Task<GetWmEmbedTaskResponse> GetWmEmbedTaskWithOptionsAsync(GetWmEmbedTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWmEmbedTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWmEmbedTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmEmbedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWmEmbedTaskResponse
        /// </returns>
        public GetWmEmbedTaskResponse GetWmEmbedTask(GetWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWmEmbedTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询嵌入水印任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmEmbedTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWmEmbedTaskResponse
        /// </returns>
        public async Task<GetWmEmbedTaskResponse> GetWmEmbedTaskAsync(GetWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWmEmbedTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文件水印提取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmExtractTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWmExtractTaskResponse
        /// </returns>
        public GetWmExtractTaskResponse GetWmExtractTaskWithOptions(GetWmExtractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWmExtractTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWmExtractTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文件水印提取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmExtractTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWmExtractTaskResponse
        /// </returns>
        public async Task<GetWmExtractTaskResponse> GetWmExtractTaskWithOptionsAsync(GetWmExtractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWmExtractTask",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWmExtractTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文件水印提取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWmExtractTaskResponse
        /// </returns>
        public GetWmExtractTaskResponse GetWmExtractTask(GetWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWmExtractTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询文件水印提取任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWmExtractTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWmExtractTaskResponse
        /// </returns>
        public async Task<GetWmExtractTaskResponse> GetWmExtractTaskAsync(GetWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWmExtractTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessPolicyResponse
        /// </returns>
        public ListApplicationsForPrivateAccessPolicyResponse ListApplicationsForPrivateAccessPolicyWithOptions(ListApplicationsForPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationsForPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForPrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessPolicyResponse
        /// </returns>
        public async Task<ListApplicationsForPrivateAccessPolicyResponse> ListApplicationsForPrivateAccessPolicyWithOptionsAsync(ListApplicationsForPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationsForPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForPrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessPolicyResponse
        /// </returns>
        public ListApplicationsForPrivateAccessPolicyResponse ListApplicationsForPrivateAccessPolicy(ListApplicationsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsForPrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessPolicyResponse
        /// </returns>
        public async Task<ListApplicationsForPrivateAccessPolicyResponse> ListApplicationsForPrivateAccessPolicyAsync(ListApplicationsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsForPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessTagResponse
        /// </returns>
        public ListApplicationsForPrivateAccessTagResponse ListApplicationsForPrivateAccessTagWithOptions(ListApplicationsForPrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationsForPrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForPrivateAccessTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessTagResponse
        /// </returns>
        public async Task<ListApplicationsForPrivateAccessTagResponse> ListApplicationsForPrivateAccessTagWithOptionsAsync(ListApplicationsForPrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationsForPrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForPrivateAccessTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessTagResponse
        /// </returns>
        public ListApplicationsForPrivateAccessTagResponse ListApplicationsForPrivateAccessTag(ListApplicationsForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsForPrivateAccessTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForPrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForPrivateAccessTagResponse
        /// </returns>
        public async Task<ListApplicationsForPrivateAccessTagResponse> ListApplicationsForPrivateAccessTagAsync(ListApplicationsForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsForPrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesResponse
        /// </returns>
        public ListApprovalProcessesResponse ListApprovalProcessesWithOptions(ListApprovalProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalProcesses",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalProcessesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesResponse
        /// </returns>
        public async Task<ListApprovalProcessesResponse> ListApprovalProcessesWithOptionsAsync(ListApprovalProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalProcesses",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalProcessesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesResponse
        /// </returns>
        public ListApprovalProcessesResponse ListApprovalProcesses(ListApprovalProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApprovalProcessesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesResponse
        /// </returns>
        public async Task<ListApprovalProcessesResponse> ListApprovalProcessesAsync(ListApprovalProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApprovalProcessesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批渲染模板关联的流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesForApprovalSchemasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesForApprovalSchemasResponse
        /// </returns>
        public ListApprovalProcessesForApprovalSchemasResponse ListApprovalProcessesForApprovalSchemasWithOptions(ListApprovalProcessesForApprovalSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalProcessesForApprovalSchemas",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalProcessesForApprovalSchemasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批渲染模板关联的流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesForApprovalSchemasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesForApprovalSchemasResponse
        /// </returns>
        public async Task<ListApprovalProcessesForApprovalSchemasResponse> ListApprovalProcessesForApprovalSchemasWithOptionsAsync(ListApprovalProcessesForApprovalSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalProcessesForApprovalSchemas",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalProcessesForApprovalSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批渲染模板关联的流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesForApprovalSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesForApprovalSchemasResponse
        /// </returns>
        public ListApprovalProcessesForApprovalSchemasResponse ListApprovalProcessesForApprovalSchemas(ListApprovalProcessesForApprovalSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApprovalProcessesForApprovalSchemasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批渲染模板关联的流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalProcessesForApprovalSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalProcessesForApprovalSchemasResponse
        /// </returns>
        public async Task<ListApprovalProcessesForApprovalSchemasResponse> ListApprovalProcessesForApprovalSchemasAsync(ListApprovalProcessesForApprovalSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApprovalProcessesForApprovalSchemasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasResponse
        /// </returns>
        public ListApprovalSchemasResponse ListApprovalSchemasWithOptions(ListApprovalSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalSchemas",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalSchemasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasResponse
        /// </returns>
        public async Task<ListApprovalSchemasResponse> ListApprovalSchemasWithOptionsAsync(ListApprovalSchemasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalSchemas",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalSchemasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasResponse
        /// </returns>
        public ListApprovalSchemasResponse ListApprovalSchemas(ListApprovalSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApprovalSchemasWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询审批动态模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasResponse
        /// </returns>
        public async Task<ListApprovalSchemasResponse> ListApprovalSchemasAsync(ListApprovalSchemasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApprovalSchemasWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程关联的渲染模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasForApprovalProcessesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasForApprovalProcessesResponse
        /// </returns>
        public ListApprovalSchemasForApprovalProcessesResponse ListApprovalSchemasForApprovalProcessesWithOptions(ListApprovalSchemasForApprovalProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalSchemasForApprovalProcesses",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalSchemasForApprovalProcessesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程关联的渲染模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasForApprovalProcessesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasForApprovalProcessesResponse
        /// </returns>
        public async Task<ListApprovalSchemasForApprovalProcessesResponse> ListApprovalSchemasForApprovalProcessesWithOptionsAsync(ListApprovalSchemasForApprovalProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovalSchemasForApprovalProcesses",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalSchemasForApprovalProcessesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程关联的渲染模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasForApprovalProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasForApprovalProcessesResponse
        /// </returns>
        public ListApprovalSchemasForApprovalProcessesResponse ListApprovalSchemasForApprovalProcesses(ListApprovalSchemasForApprovalProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApprovalSchemasForApprovalProcessesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询审批流程关联的渲染模板</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalSchemasForApprovalProcessesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalSchemasForApprovalProcessesResponse
        /// </returns>
        public async Task<ListApprovalSchemasForApprovalProcessesResponse> ListApprovalSchemasForApprovalProcessesAsync(ListApprovalSchemasForApprovalProcessesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApprovalSchemasForApprovalProcessesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalsResponse
        /// </returns>
        public ListApprovalsResponse ListApprovalsWithOptions(ListApprovalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovals",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalsResponse
        /// </returns>
        public async Task<ListApprovalsResponse> ListApprovalsWithOptionsAsync(ListApprovalsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApprovals",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApprovalsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalsResponse
        /// </returns>
        public ListApprovalsResponse ListApprovals(ListApprovalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApprovalsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询审批</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApprovalsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApprovalsResponse
        /// </returns>
        public async Task<ListApprovalsResponse> ListApprovalsAsync(ListApprovalsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApprovalsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientUsersResponse
        /// </returns>
        public ListClientUsersResponse ListClientUsersWithOptions(ListClientUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientUsers",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClientUsersResponse
        /// </returns>
        public async Task<ListClientUsersResponse> ListClientUsersWithOptionsAsync(ListClientUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClientUsers",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClientUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientUsersResponse
        /// </returns>
        public ListClientUsersResponse ListClientUsers(ListClientUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClientUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClientUsersResponse
        /// </returns>
        public async Task<ListClientUsersResponse> ListClientUsersAsync(ListClientUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询connector</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorsResponse
        /// </returns>
        public ListConnectorsResponse ListConnectorsWithOptions(ListConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectors",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectorsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询connector</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorsResponse
        /// </returns>
        public async Task<ListConnectorsResponse> ListConnectorsWithOptionsAsync(ListConnectorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnectors",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectorsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询connector</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorsResponse
        /// </returns>
        public ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectorsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询connector</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConnectorsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConnectorsResponse
        /// </returns>
        public async Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectorsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的地域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDynamicRouteRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDynamicRouteRegionsResponse
        /// </returns>
        public ListDynamicRouteRegionsResponse ListDynamicRouteRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDynamicRouteRegions",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicRouteRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的地域</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDynamicRouteRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDynamicRouteRegionsResponse
        /// </returns>
        public async Task<ListDynamicRouteRegionsResponse> ListDynamicRouteRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDynamicRouteRegions",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicRouteRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的地域</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListDynamicRouteRegionsResponse
        /// </returns>
        public ListDynamicRouteRegionsResponse ListDynamicRouteRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicRouteRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的地域</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListDynamicRouteRegionsResponse
        /// </returns>
        public async Task<ListDynamicRouteRegionsResponse> ListDynamicRouteRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicRouteRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDynamicRoutesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDynamicRoutesResponse
        /// </returns>
        public ListDynamicRoutesResponse ListDynamicRoutesWithOptions(ListDynamicRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDynamicRoutes",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicRoutesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDynamicRoutesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDynamicRoutesResponse
        /// </returns>
        public async Task<ListDynamicRoutesResponse> ListDynamicRoutesWithOptionsAsync(ListDynamicRoutesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDynamicRoutes",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDynamicRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDynamicRoutesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDynamicRoutesResponse
        /// </returns>
        public ListDynamicRoutesResponse ListDynamicRoutes(ListDynamicRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicRoutesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDynamicRoutesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDynamicRoutesResponse
        /// </returns>
        public async Task<ListDynamicRoutesResponse> ListDynamicRoutesAsync(ListDynamicRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicRoutesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询超额注册申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExcessiveDeviceRegistrationApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExcessiveDeviceRegistrationApplicationsResponse
        /// </returns>
        public ListExcessiveDeviceRegistrationApplicationsResponse ListExcessiveDeviceRegistrationApplicationsWithOptions(ListExcessiveDeviceRegistrationApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExcessiveDeviceRegistrationApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExcessiveDeviceRegistrationApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询超额注册申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExcessiveDeviceRegistrationApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExcessiveDeviceRegistrationApplicationsResponse
        /// </returns>
        public async Task<ListExcessiveDeviceRegistrationApplicationsResponse> ListExcessiveDeviceRegistrationApplicationsWithOptionsAsync(ListExcessiveDeviceRegistrationApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExcessiveDeviceRegistrationApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExcessiveDeviceRegistrationApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询超额注册申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExcessiveDeviceRegistrationApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExcessiveDeviceRegistrationApplicationsResponse
        /// </returns>
        public ListExcessiveDeviceRegistrationApplicationsResponse ListExcessiveDeviceRegistrationApplications(ListExcessiveDeviceRegistrationApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExcessiveDeviceRegistrationApplicationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询超额注册申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExcessiveDeviceRegistrationApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExcessiveDeviceRegistrationApplicationsResponse
        /// </returns>
        public async Task<ListExcessiveDeviceRegistrationApplicationsResponse> ListExcessiveDeviceRegistrationApplicationsAsync(ListExcessiveDeviceRegistrationApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExcessiveDeviceRegistrationApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询IDP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdpConfigsResponse
        /// </returns>
        public ListIdpConfigsResponse ListIdpConfigsWithOptions(ListIdpConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdpConfigs",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdpConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询IDP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpConfigsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdpConfigsResponse
        /// </returns>
        public async Task<ListIdpConfigsResponse> ListIdpConfigsWithOptionsAsync(ListIdpConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdpConfigs",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdpConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询IDP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdpConfigsResponse
        /// </returns>
        public ListIdpConfigsResponse ListIdpConfigs(ListIdpConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIdpConfigsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询IDP配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdpConfigsResponse
        /// </returns>
        public async Task<ListIdpConfigsResponse> ListIdpConfigsAsync(ListIdpConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIdpConfigsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpDepartmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdpDepartmentsResponse
        /// </returns>
        public ListIdpDepartmentsResponse ListIdpDepartmentsWithOptions(ListIdpDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdpDepartments",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdpDepartmentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpDepartmentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIdpDepartmentsResponse
        /// </returns>
        public async Task<ListIdpDepartmentsResponse> ListIdpDepartmentsWithOptionsAsync(ListIdpDepartmentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIdpDepartments",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIdpDepartmentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpDepartmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdpDepartmentsResponse
        /// </returns>
        public ListIdpDepartmentsResponse ListIdpDepartments(ListIdpDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIdpDepartmentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIdpDepartmentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIdpDepartmentsResponse
        /// </returns>
        public async Task<ListIdpDepartmentsResponse> ListIdpDepartmentsAsync(ListIdpDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIdpDepartmentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入网用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNacUserCertRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNacUserCertResponse
        /// </returns>
        public ListNacUserCertResponse ListNacUserCertWithOptions(ListNacUserCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListNacUserCert",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNacUserCertResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入网用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNacUserCertRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNacUserCertResponse
        /// </returns>
        public async Task<ListNacUserCertResponse> ListNacUserCertWithOptionsAsync(ListNacUserCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Department))
            {
                query["Department"] = request.Department;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceType))
            {
                query["DeviceType"] = request.DeviceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
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
                Action = "ListNacUserCert",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNacUserCertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入网用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNacUserCertRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNacUserCertResponse
        /// </returns>
        public ListNacUserCertResponse ListNacUserCert(ListNacUserCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNacUserCertWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>入网用户列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNacUserCertRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNacUserCertResponse
        /// </returns>
        public async Task<ListNacUserCertResponse> ListNacUserCertAsync(ListNacUserCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNacUserCertWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessApplicationResponse
        /// </returns>
        public ListPolicesForPrivateAccessApplicationResponse ListPolicesForPrivateAccessApplicationWithOptions(ListPolicesForPrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicesForPrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicesForPrivateAccessApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessApplicationResponse
        /// </returns>
        public async Task<ListPolicesForPrivateAccessApplicationResponse> ListPolicesForPrivateAccessApplicationWithOptionsAsync(ListPolicesForPrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicesForPrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicesForPrivateAccessApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessApplicationResponse
        /// </returns>
        public ListPolicesForPrivateAccessApplicationResponse ListPolicesForPrivateAccessApplication(ListPolicesForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicesForPrivateAccessApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessApplicationResponse
        /// </returns>
        public async Task<ListPolicesForPrivateAccessApplicationResponse> ListPolicesForPrivateAccessApplicationAsync(ListPolicesForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicesForPrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessTagResponse
        /// </returns>
        public ListPolicesForPrivateAccessTagResponse ListPolicesForPrivateAccessTagWithOptions(ListPolicesForPrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicesForPrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicesForPrivateAccessTagResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessTagRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessTagResponse
        /// </returns>
        public async Task<ListPolicesForPrivateAccessTagResponse> ListPolicesForPrivateAccessTagWithOptionsAsync(ListPolicesForPrivateAccessTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicesForPrivateAccessTag",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicesForPrivateAccessTagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessTagResponse
        /// </returns>
        public ListPolicesForPrivateAccessTagResponse ListPolicesForPrivateAccessTag(ListPolicesForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicesForPrivateAccessTagWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问标签的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForPrivateAccessTagRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForPrivateAccessTagResponse
        /// </returns>
        public async Task<ListPolicesForPrivateAccessTagResponse> ListPolicesForPrivateAccessTagAsync(ListPolicesForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicesForPrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForUserGroupResponse
        /// </returns>
        public ListPolicesForUserGroupResponse ListPolicesForUserGroupWithOptions(ListPolicesForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicesForUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicesForUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForUserGroupResponse
        /// </returns>
        public async Task<ListPolicesForUserGroupResponse> ListPolicesForUserGroupWithOptionsAsync(ListPolicesForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPolicesForUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPolicesForUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForUserGroupResponse
        /// </returns>
        public ListPolicesForUserGroupResponse ListPolicesForUserGroup(ListPolicesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicesForUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组的策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPolicesForUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPolicesForUserGroupResponse
        /// </returns>
        public async Task<ListPolicesForUserGroupResponse> ListPolicesForUserGroupAsync(ListPolicesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicesForUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pop节点流量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPopTrafficStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPopTrafficStatisticsResponse
        /// </returns>
        public ListPopTrafficStatisticsResponse ListPopTrafficStatisticsWithOptions(ListPopTrafficStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPopTrafficStatistics",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPopTrafficStatisticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pop节点流量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPopTrafficStatisticsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPopTrafficStatisticsResponse
        /// </returns>
        public async Task<ListPopTrafficStatisticsResponse> ListPopTrafficStatisticsWithOptionsAsync(ListPopTrafficStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPopTrafficStatistics",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPopTrafficStatisticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pop节点流量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPopTrafficStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPopTrafficStatisticsResponse
        /// </returns>
        public ListPopTrafficStatisticsResponse ListPopTrafficStatistics(ListPopTrafficStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPopTrafficStatisticsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>pop节点流量统计</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPopTrafficStatisticsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPopTrafficStatisticsResponse
        /// </returns>
        public async Task<ListPopTrafficStatisticsResponse> ListPopTrafficStatisticsAsync(ListPopTrafficStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPopTrafficStatisticsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsResponse
        /// </returns>
        public ListPrivateAccessApplicationsResponse ListPrivateAccessApplicationsWithOptions(ListPrivateAccessApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsResponse
        /// </returns>
        public async Task<ListPrivateAccessApplicationsResponse> ListPrivateAccessApplicationsWithOptionsAsync(ListPrivateAccessApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsResponse
        /// </returns>
        public ListPrivateAccessApplicationsResponse ListPrivateAccessApplications(ListPrivateAccessApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessApplicationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsResponse
        /// </returns>
        public async Task<ListPrivateAccessApplicationsResponse> ListPrivateAccessApplicationsAsync(ListPrivateAccessApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsForDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsForDynamicRouteResponse
        /// </returns>
        public ListPrivateAccessApplicationsForDynamicRouteResponse ListPrivateAccessApplicationsForDynamicRouteWithOptions(ListPrivateAccessApplicationsForDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessApplicationsForDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessApplicationsForDynamicRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsForDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsForDynamicRouteResponse
        /// </returns>
        public async Task<ListPrivateAccessApplicationsForDynamicRouteResponse> ListPrivateAccessApplicationsForDynamicRouteWithOptionsAsync(ListPrivateAccessApplicationsForDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessApplicationsForDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessApplicationsForDynamicRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsForDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsForDynamicRouteResponse
        /// </returns>
        public ListPrivateAccessApplicationsForDynamicRouteResponse ListPrivateAccessApplicationsForDynamicRoute(ListPrivateAccessApplicationsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessApplicationsForDynamicRouteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessApplicationsForDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessApplicationsForDynamicRouteResponse
        /// </returns>
        public async Task<ListPrivateAccessApplicationsForDynamicRouteResponse> ListPrivateAccessApplicationsForDynamicRouteAsync(ListPrivateAccessApplicationsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessApplicationsForDynamicRouteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessPolicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessPolicesResponse
        /// </returns>
        public ListPrivateAccessPolicesResponse ListPrivateAccessPolicesWithOptions(ListPrivateAccessPolicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessPolices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessPolicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessPolicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessPolicesResponse
        /// </returns>
        public async Task<ListPrivateAccessPolicesResponse> ListPrivateAccessPolicesWithOptionsAsync(ListPrivateAccessPolicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessPolices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessPolicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessPolicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessPolicesResponse
        /// </returns>
        public ListPrivateAccessPolicesResponse ListPrivateAccessPolices(ListPrivateAccessPolicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessPolicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessPolicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessPolicesResponse
        /// </returns>
        public async Task<ListPrivateAccessPolicesResponse> ListPrivateAccessPolicesAsync(ListPrivateAccessPolicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessPolicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all internal access tags within the current Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsResponse
        /// </returns>
        public ListPrivateAccessTagsResponse ListPrivateAccessTagsWithOptions(ListPrivateAccessTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessTags",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all internal access tags within the current Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsResponse
        /// </returns>
        public async Task<ListPrivateAccessTagsResponse> ListPrivateAccessTagsWithOptionsAsync(ListPrivateAccessTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessTags",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all internal access tags within the current Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsResponse
        /// </returns>
        public ListPrivateAccessTagsResponse ListPrivateAccessTags(ListPrivateAccessTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessTagsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about all internal access tags within the current Alibaba Cloud account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsResponse
        /// </returns>
        public async Task<ListPrivateAccessTagsResponse> ListPrivateAccessTagsAsync(ListPrivateAccessTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessTagsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsForDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsForDynamicRouteResponse
        /// </returns>
        public ListPrivateAccessTagsForDynamicRouteResponse ListPrivateAccessTagsForDynamicRouteWithOptions(ListPrivateAccessTagsForDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessTagsForDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessTagsForDynamicRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsForDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsForDynamicRouteResponse
        /// </returns>
        public async Task<ListPrivateAccessTagsForDynamicRouteResponse> ListPrivateAccessTagsForDynamicRouteWithOptionsAsync(ListPrivateAccessTagsForDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPrivateAccessTagsForDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPrivateAccessTagsForDynamicRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsForDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsForDynamicRouteResponse
        /// </returns>
        public ListPrivateAccessTagsForDynamicRouteResponse ListPrivateAccessTagsForDynamicRoute(ListPrivateAccessTagsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessTagsForDynamicRouteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询动态路由的内网访问标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPrivateAccessTagsForDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPrivateAccessTagsForDynamicRouteResponse
        /// </returns>
        public async Task<ListPrivateAccessTagsForDynamicRouteResponse> ListPrivateAccessTagsForDynamicRouteAsync(ListPrivateAccessTagsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessTagsForDynamicRouteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备注册策略列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesResponse
        /// </returns>
        public ListRegistrationPoliciesResponse ListRegistrationPoliciesWithOptions(ListRegistrationPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegistrationPolicies",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegistrationPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备注册策略列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesResponse
        /// </returns>
        public async Task<ListRegistrationPoliciesResponse> ListRegistrationPoliciesWithOptionsAsync(ListRegistrationPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegistrationPolicies",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegistrationPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备注册策略列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesResponse
        /// </returns>
        public ListRegistrationPoliciesResponse ListRegistrationPolicies(ListRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegistrationPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户设备注册策略列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesResponse
        /// </returns>
        public async Task<ListRegistrationPoliciesResponse> ListRegistrationPoliciesAsync(ListRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegistrationPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组相关的设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesForUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesForUserGroupResponse
        /// </returns>
        public ListRegistrationPoliciesForUserGroupResponse ListRegistrationPoliciesForUserGroupWithOptions(ListRegistrationPoliciesForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegistrationPoliciesForUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegistrationPoliciesForUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组相关的设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesForUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesForUserGroupResponse
        /// </returns>
        public async Task<ListRegistrationPoliciesForUserGroupResponse> ListRegistrationPoliciesForUserGroupWithOptionsAsync(ListRegistrationPoliciesForUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegistrationPoliciesForUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegistrationPoliciesForUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组相关的设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesForUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesForUserGroupResponse
        /// </returns>
        public ListRegistrationPoliciesForUserGroupResponse ListRegistrationPoliciesForUserGroup(ListRegistrationPoliciesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegistrationPoliciesForUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询用户组相关的设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegistrationPoliciesForUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegistrationPoliciesForUserGroupResponse
        /// </returns>
        public async Task<ListRegistrationPoliciesForUserGroupResponse> ListRegistrationPoliciesForUserGroupAsync(ListRegistrationPoliciesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegistrationPoliciesForUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端安装软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwareForUserDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwareForUserDeviceResponse
        /// </returns>
        public ListSoftwareForUserDeviceResponse ListSoftwareForUserDeviceWithOptions(ListSoftwareForUserDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSoftwareForUserDevice",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSoftwareForUserDeviceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端安装软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwareForUserDeviceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwareForUserDeviceResponse
        /// </returns>
        public async Task<ListSoftwareForUserDeviceResponse> ListSoftwareForUserDeviceWithOptionsAsync(ListSoftwareForUserDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSoftwareForUserDevice",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSoftwareForUserDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端安装软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwareForUserDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwareForUserDeviceResponse
        /// </returns>
        public ListSoftwareForUserDeviceResponse ListSoftwareForUserDevice(ListSoftwareForUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSoftwareForUserDeviceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询终端安装软件列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwareForUserDeviceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwareForUserDeviceResponse
        /// </returns>
        public async Task<ListSoftwareForUserDeviceResponse> ListSoftwareForUserDeviceAsync(ListSoftwareForUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSoftwareForUserDeviceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessApplicationResponse
        /// </returns>
        public ListTagsForPrivateAccessApplicationResponse ListTagsForPrivateAccessApplicationWithOptions(ListTagsForPrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagsForPrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsForPrivateAccessApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessApplicationResponse
        /// </returns>
        public async Task<ListTagsForPrivateAccessApplicationResponse> ListTagsForPrivateAccessApplicationWithOptionsAsync(ListTagsForPrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagsForPrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsForPrivateAccessApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessApplicationResponse
        /// </returns>
        public ListTagsForPrivateAccessApplicationResponse ListTagsForPrivateAccessApplication(ListTagsForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsForPrivateAccessApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问应用的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessApplicationResponse
        /// </returns>
        public async Task<ListTagsForPrivateAccessApplicationResponse> ListTagsForPrivateAccessApplicationAsync(ListTagsForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsForPrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessPolicyResponse
        /// </returns>
        public ListTagsForPrivateAccessPolicyResponse ListTagsForPrivateAccessPolicyWithOptions(ListTagsForPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagsForPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsForPrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessPolicyResponse
        /// </returns>
        public async Task<ListTagsForPrivateAccessPolicyResponse> ListTagsForPrivateAccessPolicyWithOptionsAsync(ListTagsForPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagsForPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagsForPrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessPolicyResponse
        /// </returns>
        public ListTagsForPrivateAccessPolicyResponse ListTagsForPrivateAccessPolicy(ListTagsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsForPrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagsForPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagsForPrivateAccessPolicyResponse
        /// </returns>
        public async Task<ListTagsForPrivateAccessPolicyResponse> ListTagsForPrivateAccessPolicyAsync(ListTagsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsForPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询卸载申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUninstallApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUninstallApplicationsResponse
        /// </returns>
        public ListUninstallApplicationsResponse ListUninstallApplicationsWithOptions(ListUninstallApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUninstallApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUninstallApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询卸载申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUninstallApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUninstallApplicationsResponse
        /// </returns>
        public async Task<ListUninstallApplicationsResponse> ListUninstallApplicationsWithOptionsAsync(ListUninstallApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUninstallApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUninstallApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询卸载申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUninstallApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUninstallApplicationsResponse
        /// </returns>
        public ListUninstallApplicationsResponse ListUninstallApplications(ListUninstallApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUninstallApplicationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询卸载申请列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUninstallApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUninstallApplicationsResponse
        /// </returns>
        public async Task<ListUninstallApplicationsResponse> ListUninstallApplicationsAsync(ListUninstallApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUninstallApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户应用权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserApplicationsResponse
        /// </returns>
        public ListUserApplicationsResponse ListUserApplicationsWithOptions(ListUserApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户应用权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserApplicationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserApplicationsResponse
        /// </returns>
        public async Task<ListUserApplicationsResponse> ListUserApplicationsWithOptionsAsync(ListUserApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserApplications",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户应用权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserApplicationsResponse
        /// </returns>
        public ListUserApplicationsResponse ListUserApplications(ListUserApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserApplicationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户应用权限</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserApplicationsResponse
        /// </returns>
        public async Task<ListUserApplicationsResponse> ListUserApplicationsAsync(ListUserApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserApplicationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDevicesResponse
        /// </returns>
        public ListUserDevicesResponse ListUserDevicesWithOptions(ListUserDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDevices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDevicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDevicesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserDevicesResponse
        /// </returns>
        public async Task<ListUserDevicesResponse> ListUserDevicesWithOptionsAsync(ListUserDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDevices",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDevicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDevicesResponse
        /// </returns>
        public ListUserDevicesResponse ListUserDevices(ListUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDevicesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户设备列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserDevicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserDevicesResponse
        /// </returns>
        public async Task<ListUserDevicesResponse> ListUserDevicesAsync(ListUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDevicesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public ListUserGroupsResponse ListUserGroupsWithOptions(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroups",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public async Task<ListUserGroupsResponse> ListUserGroupsWithOptionsAsync(ListUserGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroups",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsResponse
        /// </returns>
        public async Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForPrivateAccessPolicyResponse
        /// </returns>
        public ListUserGroupsForPrivateAccessPolicyResponse ListUserGroupsForPrivateAccessPolicyWithOptions(ListUserGroupsForPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroupsForPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsForPrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForPrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForPrivateAccessPolicyResponse
        /// </returns>
        public async Task<ListUserGroupsForPrivateAccessPolicyResponse> ListUserGroupsForPrivateAccessPolicyWithOptionsAsync(ListUserGroupsForPrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroupsForPrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsForPrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForPrivateAccessPolicyResponse
        /// </returns>
        public ListUserGroupsForPrivateAccessPolicyResponse ListUserGroupsForPrivateAccessPolicy(ListUserGroupsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsForPrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量查询内网访问策略的用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForPrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForPrivateAccessPolicyResponse
        /// </returns>
        public async Task<ListUserGroupsForPrivateAccessPolicyResponse> ListUserGroupsForPrivateAccessPolicyAsync(ListUserGroupsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsForPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略相关用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForRegistrationPolicyResponse
        /// </returns>
        public ListUserGroupsForRegistrationPolicyResponse ListUserGroupsForRegistrationPolicyWithOptions(ListUserGroupsForRegistrationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroupsForRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsForRegistrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略相关用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForRegistrationPolicyResponse
        /// </returns>
        public async Task<ListUserGroupsForRegistrationPolicyResponse> ListUserGroupsForRegistrationPolicyWithOptionsAsync(ListUserGroupsForRegistrationPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserGroupsForRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserGroupsForRegistrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略相关用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForRegistrationPolicyResponse
        /// </returns>
        public ListUserGroupsForRegistrationPolicyResponse ListUserGroupsForRegistrationPolicy(ListUserGroupsForRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsForRegistrationPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询设备注册策略相关用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserGroupsForRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserGroupsForRegistrationPolicyResponse
        /// </returns>
        public async Task<ListUserGroupsForRegistrationPolicyResponse> ListUserGroupsForRegistrationPolicyAsync(ListUserGroupsForRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsForRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户零信任策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPrivateAccessPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPrivateAccessPoliciesResponse
        /// </returns>
        public ListUserPrivateAccessPoliciesResponse ListUserPrivateAccessPoliciesWithOptions(ListUserPrivateAccessPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPrivateAccessPolicies",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPrivateAccessPoliciesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户零信任策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPrivateAccessPoliciesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUserPrivateAccessPoliciesResponse
        /// </returns>
        public async Task<ListUserPrivateAccessPoliciesResponse> ListUserPrivateAccessPoliciesWithOptionsAsync(ListUserPrivateAccessPoliciesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserPrivateAccessPolicies",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserPrivateAccessPoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户零信任策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPrivateAccessPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPrivateAccessPoliciesResponse
        /// </returns>
        public ListUserPrivateAccessPoliciesResponse ListUserPrivateAccessPolicies(ListUserPrivateAccessPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserPrivateAccessPoliciesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询用户零信任策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUserPrivateAccessPoliciesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUserPrivateAccessPoliciesResponse
        /// </returns>
        public async Task<ListUserPrivateAccessPoliciesResponse> ListUserPrivateAccessPoliciesAsync(ListUserPrivateAccessPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserPrivateAccessPoliciesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询登陆用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询登陆用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询登陆用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列表查询登陆用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据数字水印信息查询字符串水印信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LookupWmInfoMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LookupWmInfoMappingResponse
        /// </returns>
        public LookupWmInfoMappingResponse LookupWmInfoMappingWithOptions(LookupWmInfoMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LookupWmInfoMapping",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LookupWmInfoMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据数字水印信息查询字符串水印信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LookupWmInfoMappingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// LookupWmInfoMappingResponse
        /// </returns>
        public async Task<LookupWmInfoMappingResponse> LookupWmInfoMappingWithOptionsAsync(LookupWmInfoMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "LookupWmInfoMapping",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<LookupWmInfoMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据数字水印信息查询字符串水印信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LookupWmInfoMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// LookupWmInfoMappingResponse
        /// </returns>
        public LookupWmInfoMappingResponse LookupWmInfoMapping(LookupWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupWmInfoMappingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据数字水印信息查询字符串水印信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// LookupWmInfoMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// LookupWmInfoMappingResponse
        /// </returns>
        public async Task<LookupWmInfoMappingResponse> LookupWmInfoMappingAsync(LookupWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupWmInfoMappingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>吊销用户登录会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeUserSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeUserSessionResponse
        /// </returns>
        public RevokeUserSessionResponse RevokeUserSessionWithOptions(RevokeUserSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalIds))
            {
                query["ExternalIds"] = request.ExternalIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                query["IdpId"] = request.IdpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeUserSession",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeUserSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>吊销用户登录会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeUserSessionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeUserSessionResponse
        /// </returns>
        public async Task<RevokeUserSessionResponse> RevokeUserSessionWithOptionsAsync(RevokeUserSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalIds))
            {
                query["ExternalIds"] = request.ExternalIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpId))
            {
                query["IdpId"] = request.IdpId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeUserSession",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeUserSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>吊销用户登录会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeUserSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeUserSessionResponse
        /// </returns>
        public RevokeUserSessionResponse RevokeUserSession(RevokeUserSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeUserSessionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>吊销用户登录会话</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RevokeUserSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeUserSessionResponse
        /// </returns>
        public async Task<RevokeUserSessionResponse> RevokeUserSessionAsync(RevokeUserSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeUserSessionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批流程</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalProcessResponse
        /// </returns>
        public UpdateApprovalProcessResponse UpdateApprovalProcessWithOptions(UpdateApprovalProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApprovalProcessShrinkRequest request = new UpdateApprovalProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MatchSchemas))
            {
                request.MatchSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MatchSchemas, "MatchSchemas", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchSchemasShrink))
            {
                body["MatchSchemas"] = request.MatchSchemasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["ProcessName"] = request.ProcessName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNodes))
            {
                bodyFlat["ProcessNodes"] = request.ProcessNodes;
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
                Action = "UpdateApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApprovalProcessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批流程</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateApprovalProcessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalProcessResponse
        /// </returns>
        public async Task<UpdateApprovalProcessResponse> UpdateApprovalProcessWithOptionsAsync(UpdateApprovalProcessRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApprovalProcessShrinkRequest request = new UpdateApprovalProcessShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MatchSchemas))
            {
                request.MatchSchemasShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MatchSchemas, "MatchSchemas", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchSchemasShrink))
            {
                body["MatchSchemas"] = request.MatchSchemasShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessId))
            {
                body["ProcessId"] = request.ProcessId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessName))
            {
                body["ProcessName"] = request.ProcessName;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProcessNodes))
            {
                bodyFlat["ProcessNodes"] = request.ProcessNodes;
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
                Action = "UpdateApprovalProcess",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApprovalProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalProcessResponse
        /// </returns>
        public UpdateApprovalProcessResponse UpdateApprovalProcess(UpdateApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApprovalProcessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新审批流程</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApprovalProcessRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalProcessResponse
        /// </returns>
        public async Task<UpdateApprovalProcessResponse> UpdateApprovalProcessAsync(UpdateApprovalProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApprovalProcessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改审批状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApprovalStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalStatusResponse
        /// </returns>
        public UpdateApprovalStatusResponse UpdateApprovalStatusWithOptions(UpdateApprovalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalId))
            {
                query["ApprovalId"] = request.ApprovalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApprovalStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApprovalStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改审批状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApprovalStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalStatusResponse
        /// </returns>
        public async Task<UpdateApprovalStatusResponse> UpdateApprovalStatusWithOptionsAsync(UpdateApprovalStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApprovalId))
            {
                query["ApprovalId"] = request.ApprovalId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApprovalStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApprovalStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改审批状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApprovalStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalStatusResponse
        /// </returns>
        public UpdateApprovalStatusResponse UpdateApprovalStatus(UpdateApprovalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApprovalStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改审批状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApprovalStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApprovalStatusResponse
        /// </returns>
        public async Task<UpdateApprovalStatusResponse> UpdateApprovalStatusAsync(UpdateApprovalStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApprovalStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBootAndAntiUninstallPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBootAndAntiUninstallPolicyResponse
        /// </returns>
        public UpdateBootAndAntiUninstallPolicyResponse UpdateBootAndAntiUninstallPolicyWithOptions(UpdateBootAndAntiUninstallPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBootAndAntiUninstallPolicyShrinkRequest request = new UpdateBootAndAntiUninstallPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BlockContent))
            {
                request.BlockContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BlockContent, "BlockContent", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowReport))
            {
                body["AllowReport"] = request.AllowReport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockContentShrink))
            {
                body["BlockContent"] = request.BlockContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAntiUninstall))
            {
                body["IsAntiUninstall"] = request.IsAntiUninstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBoot))
            {
                body["IsBoot"] = request.IsBoot;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistUsers))
            {
                bodyFlat["WhitelistUsers"] = request.WhitelistUsers;
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
                Action = "UpdateBootAndAntiUninstallPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBootAndAntiUninstallPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBootAndAntiUninstallPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBootAndAntiUninstallPolicyResponse
        /// </returns>
        public async Task<UpdateBootAndAntiUninstallPolicyResponse> UpdateBootAndAntiUninstallPolicyWithOptionsAsync(UpdateBootAndAntiUninstallPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBootAndAntiUninstallPolicyShrinkRequest request = new UpdateBootAndAntiUninstallPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BlockContent))
            {
                request.BlockContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BlockContent, "BlockContent", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowReport))
            {
                body["AllowReport"] = request.AllowReport;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BlockContentShrink))
            {
                body["BlockContent"] = request.BlockContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAntiUninstall))
            {
                body["IsAntiUninstall"] = request.IsAntiUninstall;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsBoot))
            {
                body["IsBoot"] = request.IsBoot;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhitelistUsers))
            {
                bodyFlat["WhitelistUsers"] = request.WhitelistUsers;
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
                Action = "UpdateBootAndAntiUninstallPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBootAndAntiUninstallPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBootAndAntiUninstallPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBootAndAntiUninstallPolicyResponse
        /// </returns>
        public UpdateBootAndAntiUninstallPolicyResponse UpdateBootAndAntiUninstallPolicy(UpdateBootAndAntiUninstallPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBootAndAntiUninstallPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新自启动与防卸载策略配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBootAndAntiUninstallPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBootAndAntiUninstallPolicyResponse
        /// </returns>
        public async Task<UpdateBootAndAntiUninstallPolicyResponse> UpdateBootAndAntiUninstallPolicyAsync(UpdateBootAndAntiUninstallPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBootAndAntiUninstallPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserResponse
        /// </returns>
        public UpdateClientUserResponse UpdateClientUserWithOptions(UpdateClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                query["MobileNumber"] = request.MobileNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientUserResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserResponse
        /// </returns>
        public async Task<UpdateClientUserResponse> UpdateClientUserWithOptionsAsync(UpdateClientUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MobileNumber))
            {
                query["MobileNumber"] = request.MobileNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientUser",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserResponse
        /// </returns>
        public UpdateClientUserResponse UpdateClientUser(UpdateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserResponse
        /// </returns>
        public async Task<UpdateClientUserResponse> UpdateClientUserAsync(UpdateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientUserWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserPasswordResponse
        /// </returns>
        public UpdateClientUserPasswordResponse UpdateClientUserPasswordWithOptions(UpdateClientUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "UpdateClientUserPassword",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientUserPasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserPasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserPasswordResponse
        /// </returns>
        public async Task<UpdateClientUserPasswordResponse> UpdateClientUserPasswordWithOptionsAsync(UpdateClientUserPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "UpdateClientUserPassword",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientUserPasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserPasswordResponse
        /// </returns>
        public UpdateClientUserPasswordResponse UpdateClientUserPassword(UpdateClientUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientUserPasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户密码</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserPasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserPasswordResponse
        /// </returns>
        public async Task<UpdateClientUserPasswordResponse> UpdateClientUserPasswordAsync(UpdateClientUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientUserPasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserStatusResponse
        /// </returns>
        public UpdateClientUserStatusResponse UpdateClientUserStatusWithOptions(UpdateClientUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientUserStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientUserStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserStatusResponse
        /// </returns>
        public async Task<UpdateClientUserStatusResponse> UpdateClientUserStatusWithOptionsAsync(UpdateClientUserStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientUserStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientUserStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserStatusResponse
        /// </returns>
        public UpdateClientUserStatusResponse UpdateClientUserStatus(UpdateClientUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientUserStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改自定义身份源指定用户启用状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClientUserStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientUserStatusResponse
        /// </returns>
        public async Task<UpdateClientUserStatusResponse> UpdateClientUserStatusAsync(UpdateClientUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientUserStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDynamicRouteResponse
        /// </returns>
        public UpdateDynamicRouteResponse UpdateDynamicRouteWithOptions(UpdateDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteId))
            {
                body["DynamicRouteId"] = request.DynamicRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteType))
            {
                body["DynamicRouteType"] = request.DynamicRouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                body["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIds))
            {
                bodyFlat["RegionIds"] = request.RegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "UpdateDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDynamicRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDynamicRouteRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDynamicRouteResponse
        /// </returns>
        public async Task<UpdateDynamicRouteResponse> UpdateDynamicRouteWithOptionsAsync(UpdateDynamicRouteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteId))
            {
                body["DynamicRouteId"] = request.DynamicRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DynamicRouteType))
            {
                body["DynamicRouteType"] = request.DynamicRouteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextHop))
            {
                body["NextHop"] = request.NextHop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionIds))
            {
                bodyFlat["RegionIds"] = request.RegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "UpdateDynamicRoute",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDynamicRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDynamicRouteResponse
        /// </returns>
        public UpdateDynamicRouteResponse UpdateDynamicRoute(UpdateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDynamicRouteWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改动态路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDynamicRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDynamicRouteResponse
        /// </returns>
        public async Task<UpdateDynamicRouteResponse> UpdateDynamicRouteAsync(UpdateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDynamicRouteWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新超额注册申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
        /// </returns>
        public UpdateExcessiveDeviceRegistrationApplicationsStatusResponse UpdateExcessiveDeviceRegistrationApplicationsStatusWithOptions(UpdateExcessiveDeviceRegistrationApplicationsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateExcessiveDeviceRegistrationApplicationsStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExcessiveDeviceRegistrationApplicationsStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新超额注册申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
        /// </returns>
        public async Task<UpdateExcessiveDeviceRegistrationApplicationsStatusResponse> UpdateExcessiveDeviceRegistrationApplicationsStatusWithOptionsAsync(UpdateExcessiveDeviceRegistrationApplicationsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateExcessiveDeviceRegistrationApplicationsStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExcessiveDeviceRegistrationApplicationsStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新超额注册申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
        /// </returns>
        public UpdateExcessiveDeviceRegistrationApplicationsStatusResponse UpdateExcessiveDeviceRegistrationApplicationsStatus(UpdateExcessiveDeviceRegistrationApplicationsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExcessiveDeviceRegistrationApplicationsStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新超额注册申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
        /// </returns>
        public async Task<UpdateExcessiveDeviceRegistrationApplicationsStatusResponse> UpdateExcessiveDeviceRegistrationApplicationsStatusAsync(UpdateExcessiveDeviceRegistrationApplicationsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExcessiveDeviceRegistrationApplicationsStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdpDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdpDepartmentResponse
        /// </returns>
        public UpdateIdpDepartmentResponse UpdateIdpDepartmentWithOptions(UpdateIdpDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdpDepartment",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdpDepartmentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdpDepartmentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdpDepartmentResponse
        /// </returns>
        public async Task<UpdateIdpDepartmentResponse> UpdateIdpDepartmentWithOptionsAsync(UpdateIdpDepartmentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentId))
            {
                query["DepartmentId"] = request.DepartmentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DepartmentName))
            {
                query["DepartmentName"] = request.DepartmentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdpConfigId))
            {
                query["IdpConfigId"] = request.IdpConfigId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIdpDepartment",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIdpDepartmentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdpDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdpDepartmentResponse
        /// </returns>
        public UpdateIdpDepartmentResponse UpdateIdpDepartment(UpdateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIdpDepartmentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定自定义身份源部门</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIdpDepartmentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIdpDepartmentResponse
        /// </returns>
        public async Task<UpdateIdpDepartmentResponse> UpdateIdpDepartmentAsync(UpdateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIdpDepartmentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新NAC User 状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNacUserCertStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNacUserCertStatusResponse
        /// </returns>
        public UpdateNacUserCertStatusResponse UpdateNacUserCertStatusWithOptions(UpdateNacUserCertStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdList))
            {
                bodyFlat["IdList"] = request.IdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateNacUserCertStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNacUserCertStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新NAC User 状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNacUserCertStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNacUserCertStatusResponse
        /// </returns>
        public async Task<UpdateNacUserCertStatusResponse> UpdateNacUserCertStatusWithOptionsAsync(UpdateNacUserCertStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdList))
            {
                bodyFlat["IdList"] = request.IdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateNacUserCertStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNacUserCertStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新NAC User 状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNacUserCertStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNacUserCertStatusResponse
        /// </returns>
        public UpdateNacUserCertStatusResponse UpdateNacUserCertStatus(UpdateNacUserCertStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNacUserCertStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新NAC User 状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNacUserCertStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNacUserCertStatusResponse
        /// </returns>
        public async Task<UpdateNacUserCertStatusResponse> UpdateNacUserCertStatusAsync(UpdateNacUserCertStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNacUserCertStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessApplicationResponse
        /// </returns>
        public UpdatePrivateAccessApplicationResponse UpdatePrivateAccessApplicationWithOptions(UpdatePrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                bodyFlat["Addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainAutomaticPrefix))
            {
                body["L7ProxyDomainAutomaticPrefix"] = request.L7ProxyDomainAutomaticPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainCustom))
            {
                body["L7ProxyDomainCustom"] = request.L7ProxyDomainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainPrivate))
            {
                body["L7ProxyDomainPrivate"] = request.L7ProxyDomainPrivate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                bodyFlat["PortRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "UpdatePrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivateAccessApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessApplicationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessApplicationResponse
        /// </returns>
        public async Task<UpdatePrivateAccessApplicationResponse> UpdatePrivateAccessApplicationWithOptionsAsync(UpdatePrivateAccessApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addresses))
            {
                bodyFlat["Addresses"] = request.Addresses;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                body["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainAutomaticPrefix))
            {
                body["L7ProxyDomainAutomaticPrefix"] = request.L7ProxyDomainAutomaticPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainCustom))
            {
                body["L7ProxyDomainCustom"] = request.L7ProxyDomainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.L7ProxyDomainPrivate))
            {
                body["L7ProxyDomainPrivate"] = request.L7ProxyDomainPrivate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRanges))
            {
                bodyFlat["PortRanges"] = request.PortRanges;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                body["Protocol"] = request.Protocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
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
                Action = "UpdatePrivateAccessApplication",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivateAccessApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessApplicationResponse
        /// </returns>
        public UpdatePrivateAccessApplicationResponse UpdatePrivateAccessApplication(UpdatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivateAccessApplicationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问应用</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessApplicationResponse
        /// </returns>
        public async Task<UpdatePrivateAccessApplicationResponse> UpdatePrivateAccessApplicationAsync(UpdatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessPolicyResponse
        /// </returns>
        public UpdatePrivateAccessPolicyResponse UpdatePrivateAccessPolicyWithOptions(UpdatePrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserAttributes))
            {
                bodyFlat["CustomUserAttributes"] = request.CustomUserAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeAction))
            {
                body["DeviceAttributeAction"] = request.DeviceAttributeAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeId))
            {
                body["DeviceAttributeId"] = request.DeviceAttributeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyAction))
            {
                body["PolicyAction"] = request.PolicyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupMode))
            {
                body["UserGroupMode"] = request.UserGroupMode;
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
                Action = "UpdatePrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivateAccessPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessPolicyResponse
        /// </returns>
        public async Task<UpdatePrivateAccessPolicyResponse> UpdatePrivateAccessPolicyWithOptionsAsync(UpdatePrivateAccessPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationType))
            {
                body["ApplicationType"] = request.ApplicationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomUserAttributes))
            {
                bodyFlat["CustomUserAttributes"] = request.CustomUserAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeAction))
            {
                body["DeviceAttributeAction"] = request.DeviceAttributeAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAttributeId))
            {
                body["DeviceAttributeId"] = request.DeviceAttributeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyAction))
            {
                body["PolicyAction"] = request.PolicyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagIds))
            {
                bodyFlat["TagIds"] = request.TagIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupMode))
            {
                body["UserGroupMode"] = request.UserGroupMode;
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
                Action = "UpdatePrivateAccessPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePrivateAccessPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessPolicyResponse
        /// </returns>
        public UpdatePrivateAccessPolicyResponse UpdatePrivateAccessPolicy(UpdatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivateAccessPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改内网访问策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePrivateAccessPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePrivateAccessPolicyResponse
        /// </returns>
        public async Task<UpdatePrivateAccessPolicyResponse> UpdatePrivateAccessPolicyAsync(UpdatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRegistrationPolicyResponse
        /// </returns>
        public UpdateRegistrationPolicyResponse UpdateRegistrationPolicyWithOptions(UpdateRegistrationPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRegistrationPolicyShrinkRequest request = new UpdateRegistrationPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CompanyLimitCount))
            {
                request.CompanyLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CompanyLimitCount, "CompanyLimitCount", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonalLimitCount))
            {
                request.PersonalLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonalLimitCount, "PersonalLimitCount", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitCountShrink))
            {
                body["CompanyLimitCount"] = request.CompanyLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitType))
            {
                body["CompanyLimitType"] = request.CompanyLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                body["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitCountShrink))
            {
                body["PersonalLimitCount"] = request.PersonalLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitType))
            {
                body["PersonalLimitType"] = request.PersonalLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                bodyFlat["Whitelist"] = request.Whitelist;
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
                Action = "UpdateRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRegistrationPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateRegistrationPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRegistrationPolicyResponse
        /// </returns>
        public async Task<UpdateRegistrationPolicyResponse> UpdateRegistrationPolicyWithOptionsAsync(UpdateRegistrationPolicyRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateRegistrationPolicyShrinkRequest request = new UpdateRegistrationPolicyShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.CompanyLimitCount))
            {
                request.CompanyLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.CompanyLimitCount, "CompanyLimitCount", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PersonalLimitCount))
            {
                request.PersonalLimitCountShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PersonalLimitCount, "PersonalLimitCount", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitCountShrink))
            {
                body["CompanyLimitCount"] = request.CompanyLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompanyLimitType))
            {
                body["CompanyLimitType"] = request.CompanyLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchMode))
            {
                body["MatchMode"] = request.MatchMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitCountShrink))
            {
                body["PersonalLimitCount"] = request.PersonalLimitCountShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PersonalLimitType))
            {
                body["PersonalLimitType"] = request.PersonalLimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Priority))
            {
                body["Priority"] = request.Priority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupIds))
            {
                bodyFlat["UserGroupIds"] = request.UserGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Whitelist))
            {
                bodyFlat["Whitelist"] = request.Whitelist;
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
                Action = "UpdateRegistrationPolicy",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRegistrationPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRegistrationPolicyResponse
        /// </returns>
        public UpdateRegistrationPolicyResponse UpdateRegistrationPolicy(UpdateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRegistrationPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改设备注册策略</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRegistrationPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRegistrationPolicyResponse
        /// </returns>
        public async Task<UpdateRegistrationPolicyResponse> UpdateRegistrationPolicyAsync(UpdateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改卸载申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUninstallApplicationsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUninstallApplicationsStatusResponse
        /// </returns>
        public UpdateUninstallApplicationsStatusResponse UpdateUninstallApplicationsStatusWithOptions(UpdateUninstallApplicationsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateUninstallApplicationsStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUninstallApplicationsStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改卸载申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUninstallApplicationsStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUninstallApplicationsStatusResponse
        /// </returns>
        public async Task<UpdateUninstallApplicationsStatusResponse> UpdateUninstallApplicationsStatusWithOptionsAsync(UpdateUninstallApplicationsStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationIds))
            {
                bodyFlat["ApplicationIds"] = request.ApplicationIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
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
                Action = "UpdateUninstallApplicationsStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUninstallApplicationsStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改卸载申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUninstallApplicationsStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUninstallApplicationsStatusResponse
        /// </returns>
        public UpdateUninstallApplicationsStatusResponse UpdateUninstallApplicationsStatus(UpdateUninstallApplicationsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUninstallApplicationsStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改卸载申请状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUninstallApplicationsStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUninstallApplicationsStatusResponse
        /// </returns>
        public async Task<UpdateUninstallApplicationsStatusResponse> UpdateUninstallApplicationsStatusAsync(UpdateUninstallApplicationsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUninstallApplicationsStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备共享状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesSharingStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesSharingStatusResponse
        /// </returns>
        public UpdateUserDevicesSharingStatusResponse UpdateUserDevicesSharingStatusWithOptions(UpdateUserDevicesSharingStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharingStatus))
            {
                body["SharingStatus"] = request.SharingStatus;
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
                Action = "UpdateUserDevicesSharingStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDevicesSharingStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备共享状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesSharingStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesSharingStatusResponse
        /// </returns>
        public async Task<UpdateUserDevicesSharingStatusResponse> UpdateUserDevicesSharingStatusWithOptionsAsync(UpdateUserDevicesSharingStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharingStatus))
            {
                body["SharingStatus"] = request.SharingStatus;
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
                Action = "UpdateUserDevicesSharingStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDevicesSharingStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备共享状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesSharingStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesSharingStatusResponse
        /// </returns>
        public UpdateUserDevicesSharingStatusResponse UpdateUserDevicesSharingStatus(UpdateUserDevicesSharingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDevicesSharingStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备共享状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesSharingStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesSharingStatusResponse
        /// </returns>
        public async Task<UpdateUserDevicesSharingStatusResponse> UpdateUserDevicesSharingStatusAsync(UpdateUserDevicesSharingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDevicesSharingStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesStatusResponse
        /// </returns>
        public UpdateUserDevicesStatusResponse UpdateUserDevicesStatusWithOptions(UpdateUserDevicesStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAction))
            {
                body["DeviceAction"] = request.DeviceAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
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
                Action = "UpdateUserDevicesStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDevicesStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesStatusResponse
        /// </returns>
        public async Task<UpdateUserDevicesStatusResponse> UpdateUserDevicesStatusWithOptionsAsync(UpdateUserDevicesStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceAction))
            {
                body["DeviceAction"] = request.DeviceAction;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTags))
            {
                bodyFlat["DeviceTags"] = request.DeviceTags;
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
                Action = "UpdateUserDevicesStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserDevicesStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesStatusResponse
        /// </returns>
        public UpdateUserDevicesStatusResponse UpdateUserDevicesStatus(UpdateUserDevicesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDevicesStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量更新用户设备状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserDevicesStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserDevicesStatusResponse
        /// </returns>
        public async Task<UpdateUserDevicesStatusResponse> UpdateUserDevicesStatusAsync(UpdateUserDevicesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDevicesStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public UpdateUserGroupResponse UpdateUserGroupWithOptions(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                bodyFlat["Attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                body["UserGroupId"] = request.UserGroupId;
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
                Action = "UpdateUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public async Task<UpdateUserGroupResponse> UpdateUserGroupWithOptionsAsync(UpdateUserGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attributes))
            {
                bodyFlat["Attributes"] = request.Attributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                body["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserGroupId))
            {
                body["UserGroupId"] = request.UserGroupId;
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
                Action = "UpdateUserGroup",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改用户组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserGroupResponse
        /// </returns>
        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改登陆用户状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUsersStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUsersStatusResponse
        /// </returns>
        public UpdateUsersStatusResponse UpdateUsersStatusWithOptions(UpdateUsersStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaseUserIds))
            {
                query["SaseUserIds"] = request.SaseUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUsersStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUsersStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改登陆用户状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUsersStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUsersStatusResponse
        /// </returns>
        public async Task<UpdateUsersStatusResponse> UpdateUsersStatusWithOptionsAsync(UpdateUsersStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaseUserIds))
            {
                query["SaseUserIds"] = request.SaseUserIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUsersStatus",
                Version = "2023-01-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUsersStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改登陆用户状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUsersStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUsersStatusResponse
        /// </returns>
        public UpdateUsersStatusResponse UpdateUsersStatus(UpdateUsersStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUsersStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量修改登陆用户状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUsersStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUsersStatusResponse
        /// </returns>
        public async Task<UpdateUsersStatusResponse> UpdateUsersStatusAsync(UpdateUsersStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUsersStatusWithOptionsAsync(request, runtime);
        }

    }
}
