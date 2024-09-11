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

        /**
         * @summary 挂载connector的应用
         *
         * @param tmpReq AttachApplication2ConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachApplication2ConnectorResponse
         */
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

        /**
         * @summary 挂载connector的应用
         *
         * @param tmpReq AttachApplication2ConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachApplication2ConnectorResponse
         */
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

        /**
         * @summary 挂载connector的应用
         *
         * @param request AttachApplication2ConnectorRequest
         * @return AttachApplication2ConnectorResponse
         */
        public AttachApplication2ConnectorResponse AttachApplication2Connector(AttachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachApplication2ConnectorWithOptions(request, runtime);
        }

        /**
         * @summary 挂载connector的应用
         *
         * @param request AttachApplication2ConnectorRequest
         * @return AttachApplication2ConnectorResponse
         */
        public async Task<AttachApplication2ConnectorResponse> AttachApplication2ConnectorAsync(AttachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachApplication2ConnectorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建自定义身份源用户
         *
         * @param request CreateClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClientUserResponse
         */
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

        /**
         * @summary 创建自定义身份源用户
         *
         * @param request CreateClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClientUserResponse
         */
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

        /**
         * @summary 创建自定义身份源用户
         *
         * @param request CreateClientUserRequest
         * @return CreateClientUserResponse
         */
        public CreateClientUserResponse CreateClientUser(CreateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientUserWithOptions(request, runtime);
        }

        /**
         * @summary 创建自定义身份源用户
         *
         * @param request CreateClientUserRequest
         * @return CreateClientUserResponse
         */
        public async Task<CreateClientUserResponse> CreateClientUserAsync(CreateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建动态路由
         *
         * @param request CreateDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDynamicRouteResponse
         */
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

        /**
         * @summary 创建动态路由
         *
         * @param request CreateDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDynamicRouteResponse
         */
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

        /**
         * @summary 创建动态路由
         *
         * @param request CreateDynamicRouteRequest
         * @return CreateDynamicRouteResponse
         */
        public CreateDynamicRouteResponse CreateDynamicRoute(CreateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDynamicRouteWithOptions(request, runtime);
        }

        /**
         * @summary 创建动态路由
         *
         * @param request CreateDynamicRouteRequest
         * @return CreateDynamicRouteResponse
         */
        public async Task<CreateDynamicRouteResponse> CreateDynamicRouteAsync(CreateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDynamicRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建自定义身份源部门
         *
         * @param request CreateIdpDepartmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIdpDepartmentResponse
         */
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

        /**
         * @summary 创建自定义身份源部门
         *
         * @param request CreateIdpDepartmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIdpDepartmentResponse
         */
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

        /**
         * @summary 创建自定义身份源部门
         *
         * @param request CreateIdpDepartmentRequest
         * @return CreateIdpDepartmentResponse
         */
        public CreateIdpDepartmentResponse CreateIdpDepartment(CreateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateIdpDepartmentWithOptions(request, runtime);
        }

        /**
         * @summary 创建自定义身份源部门
         *
         * @param request CreateIdpDepartmentRequest
         * @return CreateIdpDepartmentResponse
         */
        public async Task<CreateIdpDepartmentResponse> CreateIdpDepartmentAsync(CreateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateIdpDepartmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建内网访问应用
         *
         * @param request CreatePrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrivateAccessApplicationResponse
         */
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

        /**
         * @summary 创建内网访问应用
         *
         * @param request CreatePrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrivateAccessApplicationResponse
         */
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

        /**
         * @summary 创建内网访问应用
         *
         * @param request CreatePrivateAccessApplicationRequest
         * @return CreatePrivateAccessApplicationResponse
         */
        public CreatePrivateAccessApplicationResponse CreatePrivateAccessApplication(CreatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrivateAccessApplicationWithOptions(request, runtime);
        }

        /**
         * @summary 创建内网访问应用
         *
         * @param request CreatePrivateAccessApplicationRequest
         * @return CreatePrivateAccessApplicationResponse
         */
        public async Task<CreatePrivateAccessApplicationResponse> CreatePrivateAccessApplicationAsync(CreatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建内网访问策略
         *
         * @param request CreatePrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrivateAccessPolicyResponse
         */
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

        /**
         * @summary 创建内网访问策略
         *
         * @param request CreatePrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrivateAccessPolicyResponse
         */
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

        /**
         * @summary 创建内网访问策略
         *
         * @param request CreatePrivateAccessPolicyRequest
         * @return CreatePrivateAccessPolicyResponse
         */
        public CreatePrivateAccessPolicyResponse CreatePrivateAccessPolicy(CreatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 创建内网访问策略
         *
         * @param request CreatePrivateAccessPolicyRequest
         * @return CreatePrivateAccessPolicyResponse
         */
        public async Task<CreatePrivateAccessPolicyResponse> CreatePrivateAccessPolicyAsync(CreatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建内网访问标签
         *
         * @param request CreatePrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrivateAccessTagResponse
         */
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

        /**
         * @summary 创建内网访问标签
         *
         * @param request CreatePrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrivateAccessTagResponse
         */
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

        /**
         * @summary 创建内网访问标签
         *
         * @param request CreatePrivateAccessTagRequest
         * @return CreatePrivateAccessTagResponse
         */
        public CreatePrivateAccessTagResponse CreatePrivateAccessTag(CreatePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrivateAccessTagWithOptions(request, runtime);
        }

        /**
         * @summary 创建内网访问标签
         *
         * @param request CreatePrivateAccessTagRequest
         * @return CreatePrivateAccessTagResponse
         */
        public async Task<CreatePrivateAccessTagResponse> CreatePrivateAccessTagAsync(CreatePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建设备注册策略
         *
         * @param tmpReq CreateRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRegistrationPolicyResponse
         */
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

        /**
         * @summary 创建设备注册策略
         *
         * @param tmpReq CreateRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateRegistrationPolicyResponse
         */
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

        /**
         * @summary 创建设备注册策略
         *
         * @param request CreateRegistrationPolicyRequest
         * @return CreateRegistrationPolicyResponse
         */
        public CreateRegistrationPolicyResponse CreateRegistrationPolicy(CreateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRegistrationPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 创建设备注册策略
         *
         * @param request CreateRegistrationPolicyRequest
         * @return CreateRegistrationPolicyResponse
         */
        public async Task<CreateRegistrationPolicyResponse> CreateRegistrationPolicyAsync(CreateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建用户组
         *
         * @param request CreateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserGroupResponse
         */
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

        /**
         * @summary 创建用户组
         *
         * @param request CreateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUserGroupResponse
         */
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

        /**
         * @summary 创建用户组
         *
         * @param request CreateUserGroupRequest
         * @return CreateUserGroupResponse
         */
        public CreateUserGroupResponse CreateUserGroup(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary 创建用户组
         *
         * @param request CreateUserGroupRequest
         * @return CreateUserGroupResponse
         */
        public async Task<CreateUserGroupResponse> CreateUserGroupAsync(CreateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建数字水印暗水印透明底图
         *
         * @param request CreateWmBaseImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmBaseImageResponse
         */
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

        /**
         * @summary 创建数字水印暗水印透明底图
         *
         * @param request CreateWmBaseImageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmBaseImageResponse
         */
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

        /**
         * @summary 创建数字水印暗水印透明底图
         *
         * @param request CreateWmBaseImageRequest
         * @return CreateWmBaseImageResponse
         */
        public CreateWmBaseImageResponse CreateWmBaseImage(CreateWmBaseImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmBaseImageWithOptions(request, runtime);
        }

        /**
         * @summary 创建数字水印暗水印透明底图
         *
         * @param request CreateWmBaseImageRequest
         * @return CreateWmBaseImageResponse
         */
        public async Task<CreateWmBaseImageResponse> CreateWmBaseImageAsync(CreateWmBaseImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmBaseImageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建嵌入水印任务
         *
         * @param tmpReq CreateWmEmbedTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmEmbedTaskResponse
         */
        public CreateWmEmbedTaskResponse CreateWmEmbedTaskWithOptions(CreateWmEmbedTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWmEmbedTaskShrinkRequest request = new CreateWmEmbedTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentControl))
            {
                request.DocumentControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentControl, "DocumentControl", "json");
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

        /**
         * @summary 创建嵌入水印任务
         *
         * @param tmpReq CreateWmEmbedTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmEmbedTaskResponse
         */
        public async Task<CreateWmEmbedTaskResponse> CreateWmEmbedTaskWithOptionsAsync(CreateWmEmbedTaskRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateWmEmbedTaskShrinkRequest request = new CreateWmEmbedTaskShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DocumentControl))
            {
                request.DocumentControlShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DocumentControl, "DocumentControl", "json");
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

        /**
         * @summary 创建嵌入水印任务
         *
         * @param request CreateWmEmbedTaskRequest
         * @return CreateWmEmbedTaskResponse
         */
        public CreateWmEmbedTaskResponse CreateWmEmbedTask(CreateWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmEmbedTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建嵌入水印任务
         *
         * @param request CreateWmEmbedTaskRequest
         * @return CreateWmEmbedTaskResponse
         */
        public async Task<CreateWmEmbedTaskResponse> CreateWmEmbedTaskAsync(CreateWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmEmbedTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建文件水印提取任务
         *
         * @param request CreateWmExtractTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmExtractTaskResponse
         */
        public CreateWmExtractTaskResponse CreateWmExtractTaskWithOptions(CreateWmExtractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        /**
         * @summary 创建文件水印提取任务
         *
         * @param request CreateWmExtractTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmExtractTaskResponse
         */
        public async Task<CreateWmExtractTaskResponse> CreateWmExtractTaskWithOptionsAsync(CreateWmExtractTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        /**
         * @summary 创建文件水印提取任务
         *
         * @param request CreateWmExtractTaskRequest
         * @return CreateWmExtractTaskResponse
         */
        public CreateWmExtractTaskResponse CreateWmExtractTask(CreateWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmExtractTaskWithOptions(request, runtime);
        }

        /**
         * @summary 创建文件水印提取任务
         *
         * @param request CreateWmExtractTaskRequest
         * @return CreateWmExtractTaskResponse
         */
        public async Task<CreateWmExtractTaskResponse> CreateWmExtractTaskAsync(CreateWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmExtractTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建一条字符串水印信息到数字水印信息的映射记录
         *
         * @param request CreateWmInfoMappingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmInfoMappingResponse
         */
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

        /**
         * @summary 创建一条字符串水印信息到数字水印信息的映射记录
         *
         * @param request CreateWmInfoMappingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWmInfoMappingResponse
         */
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

        /**
         * @summary 创建一条字符串水印信息到数字水印信息的映射记录
         *
         * @param request CreateWmInfoMappingRequest
         * @return CreateWmInfoMappingResponse
         */
        public CreateWmInfoMappingResponse CreateWmInfoMapping(CreateWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateWmInfoMappingWithOptions(request, runtime);
        }

        /**
         * @summary 创建一条字符串水印信息到数字水印信息的映射记录
         *
         * @param request CreateWmInfoMappingRequest
         * @return CreateWmInfoMappingResponse
         */
        public async Task<CreateWmInfoMappingResponse> CreateWmInfoMappingAsync(CreateWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateWmInfoMappingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除自定义身份源指定用户
         *
         * @param request DeleteClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClientUserResponse
         */
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

        /**
         * @summary 删除自定义身份源指定用户
         *
         * @param request DeleteClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClientUserResponse
         */
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

        /**
         * @summary 删除自定义身份源指定用户
         *
         * @param request DeleteClientUserRequest
         * @return DeleteClientUserResponse
         */
        public DeleteClientUserResponse DeleteClientUser(DeleteClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientUserWithOptions(request, runtime);
        }

        /**
         * @summary 删除自定义身份源指定用户
         *
         * @param request DeleteClientUserRequest
         * @return DeleteClientUserResponse
         */
        public async Task<DeleteClientUserResponse> DeleteClientUserAsync(DeleteClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除动态路由
         *
         * @param request DeleteDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDynamicRouteResponse
         */
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

        /**
         * @summary 删除动态路由
         *
         * @param request DeleteDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDynamicRouteResponse
         */
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

        /**
         * @summary 删除动态路由
         *
         * @param request DeleteDynamicRouteRequest
         * @return DeleteDynamicRouteResponse
         */
        public DeleteDynamicRouteResponse DeleteDynamicRoute(DeleteDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDynamicRouteWithOptions(request, runtime);
        }

        /**
         * @summary 删除动态路由
         *
         * @param request DeleteDynamicRouteRequest
         * @return DeleteDynamicRouteResponse
         */
        public async Task<DeleteDynamicRouteResponse> DeleteDynamicRouteAsync(DeleteDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDynamicRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除指定自定义身份源部门
         *
         * @param request DeleteIdpDepartmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIdpDepartmentResponse
         */
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

        /**
         * @summary 删除指定自定义身份源部门
         *
         * @param request DeleteIdpDepartmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIdpDepartmentResponse
         */
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

        /**
         * @summary 删除指定自定义身份源部门
         *
         * @param request DeleteIdpDepartmentRequest
         * @return DeleteIdpDepartmentResponse
         */
        public DeleteIdpDepartmentResponse DeleteIdpDepartment(DeleteIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteIdpDepartmentWithOptions(request, runtime);
        }

        /**
         * @summary 删除指定自定义身份源部门
         *
         * @param request DeleteIdpDepartmentRequest
         * @return DeleteIdpDepartmentResponse
         */
        public async Task<DeleteIdpDepartmentResponse> DeleteIdpDepartmentAsync(DeleteIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteIdpDepartmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除内网访问应用
         *
         * @param request DeletePrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrivateAccessApplicationResponse
         */
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

        /**
         * @summary 删除内网访问应用
         *
         * @param request DeletePrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrivateAccessApplicationResponse
         */
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

        /**
         * @summary 删除内网访问应用
         *
         * @param request DeletePrivateAccessApplicationRequest
         * @return DeletePrivateAccessApplicationResponse
         */
        public DeletePrivateAccessApplicationResponse DeletePrivateAccessApplication(DeletePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivateAccessApplicationWithOptions(request, runtime);
        }

        /**
         * @summary 删除内网访问应用
         *
         * @param request DeletePrivateAccessApplicationRequest
         * @return DeletePrivateAccessApplicationResponse
         */
        public async Task<DeletePrivateAccessApplicationResponse> DeletePrivateAccessApplicationAsync(DeletePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除内网访问策略
         *
         * @param request DeletePrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrivateAccessPolicyResponse
         */
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

        /**
         * @summary 删除内网访问策略
         *
         * @param request DeletePrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrivateAccessPolicyResponse
         */
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

        /**
         * @summary 删除内网访问策略
         *
         * @param request DeletePrivateAccessPolicyRequest
         * @return DeletePrivateAccessPolicyResponse
         */
        public DeletePrivateAccessPolicyResponse DeletePrivateAccessPolicy(DeletePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 删除内网访问策略
         *
         * @param request DeletePrivateAccessPolicyRequest
         * @return DeletePrivateAccessPolicyResponse
         */
        public async Task<DeletePrivateAccessPolicyResponse> DeletePrivateAccessPolicyAsync(DeletePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除内网访问标签
         *
         * @param request DeletePrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrivateAccessTagResponse
         */
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

        /**
         * @summary 删除内网访问标签
         *
         * @param request DeletePrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePrivateAccessTagResponse
         */
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

        /**
         * @summary 删除内网访问标签
         *
         * @param request DeletePrivateAccessTagRequest
         * @return DeletePrivateAccessTagResponse
         */
        public DeletePrivateAccessTagResponse DeletePrivateAccessTag(DeletePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePrivateAccessTagWithOptions(request, runtime);
        }

        /**
         * @summary 删除内网访问标签
         *
         * @param request DeletePrivateAccessTagRequest
         * @return DeletePrivateAccessTagResponse
         */
        public async Task<DeletePrivateAccessTagResponse> DeletePrivateAccessTagAsync(DeletePrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除设备注册策略
         *
         * @param request DeleteRegistrationPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRegistrationPoliciesResponse
         */
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

        /**
         * @summary 删除设备注册策略
         *
         * @param request DeleteRegistrationPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteRegistrationPoliciesResponse
         */
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

        /**
         * @summary 删除设备注册策略
         *
         * @param request DeleteRegistrationPoliciesRequest
         * @return DeleteRegistrationPoliciesResponse
         */
        public DeleteRegistrationPoliciesResponse DeleteRegistrationPolicies(DeleteRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRegistrationPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary 删除设备注册策略
         *
         * @param request DeleteRegistrationPoliciesRequest
         * @return DeleteRegistrationPoliciesResponse
         */
        public async Task<DeleteRegistrationPoliciesResponse> DeleteRegistrationPoliciesAsync(DeleteRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRegistrationPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量删除用户非在线设备
         *
         * @param request DeleteUserDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserDevicesResponse
         */
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

        /**
         * @summary 批量删除用户非在线设备
         *
         * @param request DeleteUserDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserDevicesResponse
         */
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

        /**
         * @summary 批量删除用户非在线设备
         *
         * @param request DeleteUserDevicesRequest
         * @return DeleteUserDevicesResponse
         */
        public DeleteUserDevicesResponse DeleteUserDevices(DeleteUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserDevicesWithOptions(request, runtime);
        }

        /**
         * @summary 批量删除用户非在线设备
         *
         * @param request DeleteUserDevicesRequest
         * @return DeleteUserDevicesResponse
         */
        public async Task<DeleteUserDevicesResponse> DeleteUserDevicesAsync(DeleteUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除用户组
         *
         * @param request DeleteUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupResponse
         */
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

        /**
         * @summary 删除用户组
         *
         * @param request DeleteUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserGroupResponse
         */
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

        /**
         * @summary 删除用户组
         *
         * @param request DeleteUserGroupRequest
         * @return DeleteUserGroupResponse
         */
        public DeleteUserGroupResponse DeleteUserGroup(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary 删除用户组
         *
         * @param request DeleteUserGroupRequest
         * @return DeleteUserGroupResponse
         */
        public async Task<DeleteUserGroupResponse> DeleteUserGroupAsync(DeleteUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 卸载connector的应用
         *
         * @param tmpReq DetachApplication2ConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachApplication2ConnectorResponse
         */
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

        /**
         * @summary 卸载connector的应用
         *
         * @param tmpReq DetachApplication2ConnectorRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachApplication2ConnectorResponse
         */
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

        /**
         * @summary 卸载connector的应用
         *
         * @param request DetachApplication2ConnectorRequest
         * @return DetachApplication2ConnectorResponse
         */
        public DetachApplication2ConnectorResponse DetachApplication2Connector(DetachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachApplication2ConnectorWithOptions(request, runtime);
        }

        /**
         * @summary 卸载connector的应用
         *
         * @param request DetachApplication2ConnectorRequest
         * @return DetachApplication2ConnectorResponse
         */
        public async Task<DetachApplication2ConnectorResponse> DetachApplication2ConnectorAsync(DetachApplication2ConnectorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachApplication2ConnectorWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ExportUserDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportUserDevicesResponse
         */
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

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ExportUserDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExportUserDevicesResponse
         */
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

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ExportUserDevicesRequest
         * @return ExportUserDevicesResponse
         */
        public ExportUserDevicesResponse ExportUserDevices(ExportUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportUserDevicesWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ExportUserDevicesRequest
         * @return ExportUserDevicesResponse
         */
        public async Task<ExportUserDevicesResponse> ExportUserDevicesAsync(ExportUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportUserDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询已启用的身份源配置
         *
         * @param request GetActiveIdpConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetActiveIdpConfigResponse
         */
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

        /**
         * @summary 查询已启用的身份源配置
         *
         * @param request GetActiveIdpConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetActiveIdpConfigResponse
         */
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

        /**
         * @summary 查询已启用的身份源配置
         *
         * @return GetActiveIdpConfigResponse
         */
        public GetActiveIdpConfigResponse GetActiveIdpConfig()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetActiveIdpConfigWithOptions(runtime);
        }

        /**
         * @summary 查询已启用的身份源配置
         *
         * @return GetActiveIdpConfigResponse
         */
        public async Task<GetActiveIdpConfigResponse> GetActiveIdpConfigAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetActiveIdpConfigWithOptionsAsync(runtime);
        }

        /**
         * @summary 查询自定义身份源指定用户
         *
         * @param request GetClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClientUserResponse
         */
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

        /**
         * @summary 查询自定义身份源指定用户
         *
         * @param request GetClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClientUserResponse
         */
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

        /**
         * @summary 查询自定义身份源指定用户
         *
         * @param request GetClientUserRequest
         * @return GetClientUserResponse
         */
        public GetClientUserResponse GetClientUser(GetClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClientUserWithOptions(request, runtime);
        }

        /**
         * @summary 查询自定义身份源指定用户
         *
         * @param request GetClientUserRequest
         * @return GetClientUserResponse
         */
        public async Task<GetClientUserResponse> GetClientUserAsync(GetClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClientUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询动态路由详情
         *
         * @param request GetDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDynamicRouteResponse
         */
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

        /**
         * @summary 查询动态路由详情
         *
         * @param request GetDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDynamicRouteResponse
         */
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

        /**
         * @summary 查询动态路由详情
         *
         * @param request GetDynamicRouteRequest
         * @return GetDynamicRouteResponse
         */
        public GetDynamicRouteResponse GetDynamicRoute(GetDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDynamicRouteWithOptions(request, runtime);
        }

        /**
         * @summary 查询动态路由详情
         *
         * @param request GetDynamicRouteRequest
         * @return GetDynamicRouteResponse
         */
        public async Task<GetDynamicRouteResponse> GetDynamicRouteAsync(GetDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDynamicRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询身份源配置详情
         *
         * @param request GetIdpConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIdpConfigResponse
         */
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

        /**
         * @summary 查询身份源配置详情
         *
         * @param request GetIdpConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetIdpConfigResponse
         */
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

        /**
         * @summary 查询身份源配置详情
         *
         * @param request GetIdpConfigRequest
         * @return GetIdpConfigResponse
         */
        public GetIdpConfigResponse GetIdpConfig(GetIdpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIdpConfigWithOptions(request, runtime);
        }

        /**
         * @summary 查询身份源配置详情
         *
         * @param request GetIdpConfigRequest
         * @return GetIdpConfigResponse
         */
        public async Task<GetIdpConfigResponse> GetIdpConfigAsync(GetIdpConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIdpConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询内网访问应用详情
         *
         * @param request GetPrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrivateAccessApplicationResponse
         */
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

        /**
         * @summary 查询内网访问应用详情
         *
         * @param request GetPrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrivateAccessApplicationResponse
         */
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

        /**
         * @summary 查询内网访问应用详情
         *
         * @param request GetPrivateAccessApplicationRequest
         * @return GetPrivateAccessApplicationResponse
         */
        public GetPrivateAccessApplicationResponse GetPrivateAccessApplication(GetPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrivateAccessApplicationWithOptions(request, runtime);
        }

        /**
         * @summary 查询内网访问应用详情
         *
         * @param request GetPrivateAccessApplicationRequest
         * @return GetPrivateAccessApplicationResponse
         */
        public async Task<GetPrivateAccessApplicationResponse> GetPrivateAccessApplicationAsync(GetPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询内网访问策略详情
         *
         * @param request GetPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 查询内网访问策略详情
         *
         * @param request GetPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 查询内网访问策略详情
         *
         * @param request GetPrivateAccessPolicyRequest
         * @return GetPrivateAccessPolicyResponse
         */
        public GetPrivateAccessPolicyResponse GetPrivateAccessPolicy(GetPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 查询内网访问策略详情
         *
         * @param request GetPrivateAccessPolicyRequest
         * @return GetPrivateAccessPolicyResponse
         */
        public async Task<GetPrivateAccessPolicyResponse> GetPrivateAccessPolicyAsync(GetPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询设备注册策略详情
         *
         * @param request GetRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRegistrationPolicyResponse
         */
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

        /**
         * @summary 查询设备注册策略详情
         *
         * @param request GetRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetRegistrationPolicyResponse
         */
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

        /**
         * @summary 查询设备注册策略详情
         *
         * @param request GetRegistrationPolicyRequest
         * @return GetRegistrationPolicyResponse
         */
        public GetRegistrationPolicyResponse GetRegistrationPolicy(GetRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRegistrationPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 查询设备注册策略详情
         *
         * @param request GetRegistrationPolicyRequest
         * @return GetRegistrationPolicyResponse
         */
        public async Task<GetRegistrationPolicyResponse> GetRegistrationPolicyAsync(GetRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户设备详情
         *
         * @param request GetUserDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserDeviceResponse
         */
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

        /**
         * @summary 查询用户设备详情
         *
         * @param request GetUserDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserDeviceResponse
         */
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

        /**
         * @summary 查询用户设备详情
         *
         * @param request GetUserDeviceRequest
         * @return GetUserDeviceResponse
         */
        public GetUserDeviceResponse GetUserDevice(GetUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserDeviceWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户设备详情
         *
         * @param request GetUserDeviceRequest
         * @return GetUserDeviceResponse
         */
        public async Task<GetUserDeviceResponse> GetUserDeviceAsync(GetUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户组详情
         *
         * @param request GetUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserGroupResponse
         */
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

        /**
         * @summary 查询用户组详情
         *
         * @param request GetUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUserGroupResponse
         */
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

        /**
         * @summary 查询用户组详情
         *
         * @param request GetUserGroupRequest
         * @return GetUserGroupResponse
         */
        public GetUserGroupResponse GetUserGroup(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户组详情
         *
         * @param request GetUserGroupRequest
         * @return GetUserGroupResponse
         */
        public async Task<GetUserGroupResponse> GetUserGroupAsync(GetUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询嵌入水印任务
         *
         * @param request GetWmEmbedTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWmEmbedTaskResponse
         */
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

        /**
         * @summary 查询嵌入水印任务
         *
         * @param request GetWmEmbedTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWmEmbedTaskResponse
         */
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

        /**
         * @summary 查询嵌入水印任务
         *
         * @param request GetWmEmbedTaskRequest
         * @return GetWmEmbedTaskResponse
         */
        public GetWmEmbedTaskResponse GetWmEmbedTask(GetWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWmEmbedTaskWithOptions(request, runtime);
        }

        /**
         * @summary 查询嵌入水印任务
         *
         * @param request GetWmEmbedTaskRequest
         * @return GetWmEmbedTaskResponse
         */
        public async Task<GetWmEmbedTaskResponse> GetWmEmbedTaskAsync(GetWmEmbedTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWmEmbedTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询文件水印提取任务详情
         *
         * @param request GetWmExtractTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWmExtractTaskResponse
         */
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

        /**
         * @summary 查询文件水印提取任务详情
         *
         * @param request GetWmExtractTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWmExtractTaskResponse
         */
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

        /**
         * @summary 查询文件水印提取任务详情
         *
         * @param request GetWmExtractTaskRequest
         * @return GetWmExtractTaskResponse
         */
        public GetWmExtractTaskResponse GetWmExtractTask(GetWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetWmExtractTaskWithOptions(request, runtime);
        }

        /**
         * @summary 查询文件水印提取任务详情
         *
         * @param request GetWmExtractTaskRequest
         * @return GetWmExtractTaskResponse
         */
        public async Task<GetWmExtractTaskResponse> GetWmExtractTaskAsync(GetWmExtractTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetWmExtractTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略的应用
         *
         * @param request ListApplicationsForPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 批量查询内网访问策略的应用
         *
         * @param request ListApplicationsForPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 批量查询内网访问策略的应用
         *
         * @param request ListApplicationsForPrivateAccessPolicyRequest
         * @return ListApplicationsForPrivateAccessPolicyResponse
         */
        public ListApplicationsForPrivateAccessPolicyResponse ListApplicationsForPrivateAccessPolicy(ListApplicationsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsForPrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略的应用
         *
         * @param request ListApplicationsForPrivateAccessPolicyRequest
         * @return ListApplicationsForPrivateAccessPolicyResponse
         */
        public async Task<ListApplicationsForPrivateAccessPolicyResponse> ListApplicationsForPrivateAccessPolicyAsync(ListApplicationsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsForPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问标签的应用
         *
         * @param request ListApplicationsForPrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForPrivateAccessTagResponse
         */
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

        /**
         * @summary 批量查询内网访问标签的应用
         *
         * @param request ListApplicationsForPrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsForPrivateAccessTagResponse
         */
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

        /**
         * @summary 批量查询内网访问标签的应用
         *
         * @param request ListApplicationsForPrivateAccessTagRequest
         * @return ListApplicationsForPrivateAccessTagResponse
         */
        public ListApplicationsForPrivateAccessTagResponse ListApplicationsForPrivateAccessTag(ListApplicationsForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsForPrivateAccessTagWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问标签的应用
         *
         * @param request ListApplicationsForPrivateAccessTagRequest
         * @return ListApplicationsForPrivateAccessTagResponse
         */
        public async Task<ListApplicationsForPrivateAccessTagResponse> ListApplicationsForPrivateAccessTagAsync(ListApplicationsForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsForPrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询自定义身份源用户
         *
         * @param request ListClientUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClientUsersResponse
         */
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

        /**
         * @summary 查询自定义身份源用户
         *
         * @param request ListClientUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClientUsersResponse
         */
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

        /**
         * @summary 查询自定义身份源用户
         *
         * @param request ListClientUsersRequest
         * @return ListClientUsersResponse
         */
        public ListClientUsersResponse ListClientUsers(ListClientUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClientUsersWithOptions(request, runtime);
        }

        /**
         * @summary 查询自定义身份源用户
         *
         * @param request ListClientUsersRequest
         * @return ListClientUsersResponse
         */
        public async Task<ListClientUsersResponse> ListClientUsersAsync(ListClientUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClientUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询connector
         *
         * @param request ListConnectorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConnectorsResponse
         */
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

        /**
         * @summary 批量查询connector
         *
         * @param request ListConnectorsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConnectorsResponse
         */
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

        /**
         * @summary 批量查询connector
         *
         * @param request ListConnectorsRequest
         * @return ListConnectorsResponse
         */
        public ListConnectorsResponse ListConnectors(ListConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectorsWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询connector
         *
         * @param request ListConnectorsRequest
         * @return ListConnectorsResponse
         */
        public async Task<ListConnectorsResponse> ListConnectorsAsync(ListConnectorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectorsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询动态路由的地域
         *
         * @param request ListDynamicRouteRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDynamicRouteRegionsResponse
         */
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

        /**
         * @summary 批量查询动态路由的地域
         *
         * @param request ListDynamicRouteRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDynamicRouteRegionsResponse
         */
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

        /**
         * @summary 批量查询动态路由的地域
         *
         * @return ListDynamicRouteRegionsResponse
         */
        public ListDynamicRouteRegionsResponse ListDynamicRouteRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicRouteRegionsWithOptions(runtime);
        }

        /**
         * @summary 批量查询动态路由的地域
         *
         * @return ListDynamicRouteRegionsResponse
         */
        public async Task<ListDynamicRouteRegionsResponse> ListDynamicRouteRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicRouteRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary 批量查询动态路由
         *
         * @param request ListDynamicRoutesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDynamicRoutesResponse
         */
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

        /**
         * @summary 批量查询动态路由
         *
         * @param request ListDynamicRoutesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDynamicRoutesResponse
         */
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

        /**
         * @summary 批量查询动态路由
         *
         * @param request ListDynamicRoutesRequest
         * @return ListDynamicRoutesResponse
         */
        public ListDynamicRoutesResponse ListDynamicRoutes(ListDynamicRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDynamicRoutesWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询动态路由
         *
         * @param request ListDynamicRoutesRequest
         * @return ListDynamicRoutesResponse
         */
        public async Task<ListDynamicRoutesResponse> ListDynamicRoutesAsync(ListDynamicRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDynamicRoutesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询超额注册申请列表
         *
         * @param request ListExcessiveDeviceRegistrationApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExcessiveDeviceRegistrationApplicationsResponse
         */
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

        /**
         * @summary 批量查询超额注册申请列表
         *
         * @param request ListExcessiveDeviceRegistrationApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExcessiveDeviceRegistrationApplicationsResponse
         */
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

        /**
         * @summary 批量查询超额注册申请列表
         *
         * @param request ListExcessiveDeviceRegistrationApplicationsRequest
         * @return ListExcessiveDeviceRegistrationApplicationsResponse
         */
        public ListExcessiveDeviceRegistrationApplicationsResponse ListExcessiveDeviceRegistrationApplications(ListExcessiveDeviceRegistrationApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExcessiveDeviceRegistrationApplicationsWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询超额注册申请列表
         *
         * @param request ListExcessiveDeviceRegistrationApplicationsRequest
         * @return ListExcessiveDeviceRegistrationApplicationsResponse
         */
        public async Task<ListExcessiveDeviceRegistrationApplicationsResponse> ListExcessiveDeviceRegistrationApplicationsAsync(ListExcessiveDeviceRegistrationApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExcessiveDeviceRegistrationApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询IDP配置
         *
         * @param request ListIdpConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdpConfigsResponse
         */
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

        /**
         * @summary 查询IDP配置
         *
         * @param request ListIdpConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdpConfigsResponse
         */
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

        /**
         * @summary 查询IDP配置
         *
         * @param request ListIdpConfigsRequest
         * @return ListIdpConfigsResponse
         */
        public ListIdpConfigsResponse ListIdpConfigs(ListIdpConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIdpConfigsWithOptions(request, runtime);
        }

        /**
         * @summary 查询IDP配置
         *
         * @param request ListIdpConfigsRequest
         * @return ListIdpConfigsResponse
         */
        public async Task<ListIdpConfigsResponse> ListIdpConfigsAsync(ListIdpConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIdpConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询自定义身份源部门
         *
         * @param request ListIdpDepartmentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdpDepartmentsResponse
         */
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

        /**
         * @summary 查询自定义身份源部门
         *
         * @param request ListIdpDepartmentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIdpDepartmentsResponse
         */
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

        /**
         * @summary 查询自定义身份源部门
         *
         * @param request ListIdpDepartmentsRequest
         * @return ListIdpDepartmentsResponse
         */
        public ListIdpDepartmentsResponse ListIdpDepartments(ListIdpDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIdpDepartmentsWithOptions(request, runtime);
        }

        /**
         * @summary 查询自定义身份源部门
         *
         * @param request ListIdpDepartmentsRequest
         * @return ListIdpDepartmentsResponse
         */
        public async Task<ListIdpDepartmentsResponse> ListIdpDepartmentsAsync(ListIdpDepartmentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIdpDepartmentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 入网用户列表
         *
         * @param request ListNacUserCertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNacUserCertResponse
         */
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

        /**
         * @summary 入网用户列表
         *
         * @param request ListNacUserCertRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNacUserCertResponse
         */
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

        /**
         * @summary 入网用户列表
         *
         * @param request ListNacUserCertRequest
         * @return ListNacUserCertResponse
         */
        public ListNacUserCertResponse ListNacUserCert(ListNacUserCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNacUserCertWithOptions(request, runtime);
        }

        /**
         * @summary 入网用户列表
         *
         * @param request ListNacUserCertRequest
         * @return ListNacUserCertResponse
         */
        public async Task<ListNacUserCertResponse> ListNacUserCertAsync(ListNacUserCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNacUserCertWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问应用的策略
         *
         * @param request ListPolicesForPrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicesForPrivateAccessApplicationResponse
         */
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

        /**
         * @summary 批量查询内网访问应用的策略
         *
         * @param request ListPolicesForPrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicesForPrivateAccessApplicationResponse
         */
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

        /**
         * @summary 批量查询内网访问应用的策略
         *
         * @param request ListPolicesForPrivateAccessApplicationRequest
         * @return ListPolicesForPrivateAccessApplicationResponse
         */
        public ListPolicesForPrivateAccessApplicationResponse ListPolicesForPrivateAccessApplication(ListPolicesForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicesForPrivateAccessApplicationWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问应用的策略
         *
         * @param request ListPolicesForPrivateAccessApplicationRequest
         * @return ListPolicesForPrivateAccessApplicationResponse
         */
        public async Task<ListPolicesForPrivateAccessApplicationResponse> ListPolicesForPrivateAccessApplicationAsync(ListPolicesForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicesForPrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问标签的策略
         *
         * @param request ListPolicesForPrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicesForPrivateAccessTagResponse
         */
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

        /**
         * @summary 批量查询内网访问标签的策略
         *
         * @param request ListPolicesForPrivateAccessTagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicesForPrivateAccessTagResponse
         */
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

        /**
         * @summary 批量查询内网访问标签的策略
         *
         * @param request ListPolicesForPrivateAccessTagRequest
         * @return ListPolicesForPrivateAccessTagResponse
         */
        public ListPolicesForPrivateAccessTagResponse ListPolicesForPrivateAccessTag(ListPolicesForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicesForPrivateAccessTagWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问标签的策略
         *
         * @param request ListPolicesForPrivateAccessTagRequest
         * @return ListPolicesForPrivateAccessTagResponse
         */
        public async Task<ListPolicesForPrivateAccessTagResponse> ListPolicesForPrivateAccessTagAsync(ListPolicesForPrivateAccessTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicesForPrivateAccessTagWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询用户组的策略
         *
         * @param request ListPolicesForUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicesForUserGroupResponse
         */
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

        /**
         * @summary 批量查询用户组的策略
         *
         * @param request ListPolicesForUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPolicesForUserGroupResponse
         */
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

        /**
         * @summary 批量查询用户组的策略
         *
         * @param request ListPolicesForUserGroupRequest
         * @return ListPolicesForUserGroupResponse
         */
        public ListPolicesForUserGroupResponse ListPolicesForUserGroup(ListPolicesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPolicesForUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询用户组的策略
         *
         * @param request ListPolicesForUserGroupRequest
         * @return ListPolicesForUserGroupResponse
         */
        public async Task<ListPolicesForUserGroupResponse> ListPolicesForUserGroupAsync(ListPolicesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPolicesForUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary pop节点流量统计
         *
         * @param request ListPopTrafficStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPopTrafficStatisticsResponse
         */
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

        /**
         * @summary pop节点流量统计
         *
         * @param request ListPopTrafficStatisticsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPopTrafficStatisticsResponse
         */
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

        /**
         * @summary pop节点流量统计
         *
         * @param request ListPopTrafficStatisticsRequest
         * @return ListPopTrafficStatisticsResponse
         */
        public ListPopTrafficStatisticsResponse ListPopTrafficStatistics(ListPopTrafficStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPopTrafficStatisticsWithOptions(request, runtime);
        }

        /**
         * @summary pop节点流量统计
         *
         * @param request ListPopTrafficStatisticsRequest
         * @return ListPopTrafficStatisticsResponse
         */
        public async Task<ListPopTrafficStatisticsResponse> ListPopTrafficStatisticsAsync(ListPopTrafficStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPopTrafficStatisticsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问应用
         *
         * @param request ListPrivateAccessApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessApplicationsResponse
         */
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

        /**
         * @summary 批量查询内网访问应用
         *
         * @param request ListPrivateAccessApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessApplicationsResponse
         */
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

        /**
         * @summary 批量查询内网访问应用
         *
         * @param request ListPrivateAccessApplicationsRequest
         * @return ListPrivateAccessApplicationsResponse
         */
        public ListPrivateAccessApplicationsResponse ListPrivateAccessApplications(ListPrivateAccessApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessApplicationsWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问应用
         *
         * @param request ListPrivateAccessApplicationsRequest
         * @return ListPrivateAccessApplicationsResponse
         */
        public async Task<ListPrivateAccessApplicationsResponse> ListPrivateAccessApplicationsAsync(ListPrivateAccessApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询动态路由的内网访问应用
         *
         * @param request ListPrivateAccessApplicationsForDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessApplicationsForDynamicRouteResponse
         */
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

        /**
         * @summary 批量查询动态路由的内网访问应用
         *
         * @param request ListPrivateAccessApplicationsForDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessApplicationsForDynamicRouteResponse
         */
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

        /**
         * @summary 批量查询动态路由的内网访问应用
         *
         * @param request ListPrivateAccessApplicationsForDynamicRouteRequest
         * @return ListPrivateAccessApplicationsForDynamicRouteResponse
         */
        public ListPrivateAccessApplicationsForDynamicRouteResponse ListPrivateAccessApplicationsForDynamicRoute(ListPrivateAccessApplicationsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessApplicationsForDynamicRouteWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询动态路由的内网访问应用
         *
         * @param request ListPrivateAccessApplicationsForDynamicRouteRequest
         * @return ListPrivateAccessApplicationsForDynamicRouteResponse
         */
        public async Task<ListPrivateAccessApplicationsForDynamicRouteResponse> ListPrivateAccessApplicationsForDynamicRouteAsync(ListPrivateAccessApplicationsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessApplicationsForDynamicRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略
         *
         * @param request ListPrivateAccessPolicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessPolicesResponse
         */
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

        /**
         * @summary 批量查询内网访问策略
         *
         * @param request ListPrivateAccessPolicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessPolicesResponse
         */
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

        /**
         * @summary 批量查询内网访问策略
         *
         * @param request ListPrivateAccessPolicesRequest
         * @return ListPrivateAccessPolicesResponse
         */
        public ListPrivateAccessPolicesResponse ListPrivateAccessPolices(ListPrivateAccessPolicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessPolicesWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略
         *
         * @param request ListPrivateAccessPolicesRequest
         * @return ListPrivateAccessPolicesResponse
         */
        public async Task<ListPrivateAccessPolicesResponse> ListPrivateAccessPolicesAsync(ListPrivateAccessPolicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessPolicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about all internal access tags within the current Alibaba Cloud account.
         *
         * @param request ListPrivateAccessTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessTagsResponse
         */
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

        /**
         * @summary Queries the information about all internal access tags within the current Alibaba Cloud account.
         *
         * @param request ListPrivateAccessTagsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessTagsResponse
         */
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

        /**
         * @summary Queries the information about all internal access tags within the current Alibaba Cloud account.
         *
         * @param request ListPrivateAccessTagsRequest
         * @return ListPrivateAccessTagsResponse
         */
        public ListPrivateAccessTagsResponse ListPrivateAccessTags(ListPrivateAccessTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessTagsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about all internal access tags within the current Alibaba Cloud account.
         *
         * @param request ListPrivateAccessTagsRequest
         * @return ListPrivateAccessTagsResponse
         */
        public async Task<ListPrivateAccessTagsResponse> ListPrivateAccessTagsAsync(ListPrivateAccessTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessTagsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询动态路由的内网访问标签
         *
         * @param request ListPrivateAccessTagsForDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessTagsForDynamicRouteResponse
         */
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

        /**
         * @summary 批量查询动态路由的内网访问标签
         *
         * @param request ListPrivateAccessTagsForDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPrivateAccessTagsForDynamicRouteResponse
         */
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

        /**
         * @summary 批量查询动态路由的内网访问标签
         *
         * @param request ListPrivateAccessTagsForDynamicRouteRequest
         * @return ListPrivateAccessTagsForDynamicRouteResponse
         */
        public ListPrivateAccessTagsForDynamicRouteResponse ListPrivateAccessTagsForDynamicRoute(ListPrivateAccessTagsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPrivateAccessTagsForDynamicRouteWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询动态路由的内网访问标签
         *
         * @param request ListPrivateAccessTagsForDynamicRouteRequest
         * @return ListPrivateAccessTagsForDynamicRouteResponse
         */
        public async Task<ListPrivateAccessTagsForDynamicRouteResponse> ListPrivateAccessTagsForDynamicRouteAsync(ListPrivateAccessTagsForDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPrivateAccessTagsForDynamicRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户设备注册策略列表
         *
         * @param request ListRegistrationPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegistrationPoliciesResponse
         */
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

        /**
         * @summary 查询用户设备注册策略列表
         *
         * @param request ListRegistrationPoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegistrationPoliciesResponse
         */
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

        /**
         * @summary 查询用户设备注册策略列表
         *
         * @param request ListRegistrationPoliciesRequest
         * @return ListRegistrationPoliciesResponse
         */
        public ListRegistrationPoliciesResponse ListRegistrationPolicies(ListRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegistrationPoliciesWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户设备注册策略列表
         *
         * @param request ListRegistrationPoliciesRequest
         * @return ListRegistrationPoliciesResponse
         */
        public async Task<ListRegistrationPoliciesResponse> ListRegistrationPoliciesAsync(ListRegistrationPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegistrationPoliciesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户组相关的设备注册策略
         *
         * @param request ListRegistrationPoliciesForUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegistrationPoliciesForUserGroupResponse
         */
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

        /**
         * @summary 查询用户组相关的设备注册策略
         *
         * @param request ListRegistrationPoliciesForUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegistrationPoliciesForUserGroupResponse
         */
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

        /**
         * @summary 查询用户组相关的设备注册策略
         *
         * @param request ListRegistrationPoliciesForUserGroupRequest
         * @return ListRegistrationPoliciesForUserGroupResponse
         */
        public ListRegistrationPoliciesForUserGroupResponse ListRegistrationPoliciesForUserGroup(ListRegistrationPoliciesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegistrationPoliciesForUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary 查询用户组相关的设备注册策略
         *
         * @param request ListRegistrationPoliciesForUserGroupRequest
         * @return ListRegistrationPoliciesForUserGroupResponse
         */
        public async Task<ListRegistrationPoliciesForUserGroupResponse> ListRegistrationPoliciesForUserGroupAsync(ListRegistrationPoliciesForUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegistrationPoliciesForUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询终端安装软件列表
         *
         * @param request ListSoftwareForUserDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSoftwareForUserDeviceResponse
         */
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

        /**
         * @summary 批量查询终端安装软件列表
         *
         * @param request ListSoftwareForUserDeviceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSoftwareForUserDeviceResponse
         */
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

        /**
         * @summary 批量查询终端安装软件列表
         *
         * @param request ListSoftwareForUserDeviceRequest
         * @return ListSoftwareForUserDeviceResponse
         */
        public ListSoftwareForUserDeviceResponse ListSoftwareForUserDevice(ListSoftwareForUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSoftwareForUserDeviceWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询终端安装软件列表
         *
         * @param request ListSoftwareForUserDeviceRequest
         * @return ListSoftwareForUserDeviceResponse
         */
        public async Task<ListSoftwareForUserDeviceResponse> ListSoftwareForUserDeviceAsync(ListSoftwareForUserDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSoftwareForUserDeviceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问应用的标签
         *
         * @param request ListTagsForPrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsForPrivateAccessApplicationResponse
         */
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

        /**
         * @summary 批量查询内网访问应用的标签
         *
         * @param request ListTagsForPrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsForPrivateAccessApplicationResponse
         */
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

        /**
         * @summary 批量查询内网访问应用的标签
         *
         * @param request ListTagsForPrivateAccessApplicationRequest
         * @return ListTagsForPrivateAccessApplicationResponse
         */
        public ListTagsForPrivateAccessApplicationResponse ListTagsForPrivateAccessApplication(ListTagsForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsForPrivateAccessApplicationWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问应用的标签
         *
         * @param request ListTagsForPrivateAccessApplicationRequest
         * @return ListTagsForPrivateAccessApplicationResponse
         */
        public async Task<ListTagsForPrivateAccessApplicationResponse> ListTagsForPrivateAccessApplicationAsync(ListTagsForPrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsForPrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略的标签
         *
         * @param request ListTagsForPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsForPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 批量查询内网访问策略的标签
         *
         * @param request ListTagsForPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagsForPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 批量查询内网访问策略的标签
         *
         * @param request ListTagsForPrivateAccessPolicyRequest
         * @return ListTagsForPrivateAccessPolicyResponse
         */
        public ListTagsForPrivateAccessPolicyResponse ListTagsForPrivateAccessPolicy(ListTagsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsForPrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略的标签
         *
         * @param request ListTagsForPrivateAccessPolicyRequest
         * @return ListTagsForPrivateAccessPolicyResponse
         */
        public async Task<ListTagsForPrivateAccessPolicyResponse> ListTagsForPrivateAccessPolicyAsync(ListTagsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsForPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ListUserDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserDevicesResponse
         */
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

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ListUserDevicesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserDevicesResponse
         */
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

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ListUserDevicesRequest
         * @return ListUserDevicesResponse
         */
        public ListUserDevicesResponse ListUserDevices(ListUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDevicesWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询用户设备列表
         *
         * @param request ListUserDevicesRequest
         * @return ListUserDevicesResponse
         */
        public async Task<ListUserDevicesResponse> ListUserDevicesAsync(ListUserDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDevicesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询用户组
         *
         * @param request ListUserGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsResponse
         */
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

        /**
         * @summary 批量查询用户组
         *
         * @param request ListUserGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsResponse
         */
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

        /**
         * @summary 批量查询用户组
         *
         * @param request ListUserGroupsRequest
         * @return ListUserGroupsResponse
         */
        public ListUserGroupsResponse ListUserGroups(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询用户组
         *
         * @param request ListUserGroupsRequest
         * @return ListUserGroupsResponse
         */
        public async Task<ListUserGroupsResponse> ListUserGroupsAsync(ListUserGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略的用户组
         *
         * @param request ListUserGroupsForPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsForPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 批量查询内网访问策略的用户组
         *
         * @param request ListUserGroupsForPrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsForPrivateAccessPolicyResponse
         */
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

        /**
         * @summary 批量查询内网访问策略的用户组
         *
         * @param request ListUserGroupsForPrivateAccessPolicyRequest
         * @return ListUserGroupsForPrivateAccessPolicyResponse
         */
        public ListUserGroupsForPrivateAccessPolicyResponse ListUserGroupsForPrivateAccessPolicy(ListUserGroupsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsForPrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 批量查询内网访问策略的用户组
         *
         * @param request ListUserGroupsForPrivateAccessPolicyRequest
         * @return ListUserGroupsForPrivateAccessPolicyResponse
         */
        public async Task<ListUserGroupsForPrivateAccessPolicyResponse> ListUserGroupsForPrivateAccessPolicyAsync(ListUserGroupsForPrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsForPrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询设备注册策略相关用户组
         *
         * @param request ListUserGroupsForRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsForRegistrationPolicyResponse
         */
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

        /**
         * @summary 查询设备注册策略相关用户组
         *
         * @param request ListUserGroupsForRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserGroupsForRegistrationPolicyResponse
         */
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

        /**
         * @summary 查询设备注册策略相关用户组
         *
         * @param request ListUserGroupsForRegistrationPolicyRequest
         * @return ListUserGroupsForRegistrationPolicyResponse
         */
        public ListUserGroupsForRegistrationPolicyResponse ListUserGroupsForRegistrationPolicy(ListUserGroupsForRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserGroupsForRegistrationPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 查询设备注册策略相关用户组
         *
         * @param request ListUserGroupsForRegistrationPolicyRequest
         * @return ListUserGroupsForRegistrationPolicyResponse
         */
        public async Task<ListUserGroupsForRegistrationPolicyResponse> ListUserGroupsForRegistrationPolicyAsync(ListUserGroupsForRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserGroupsForRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 列表查询登陆用户
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
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

        /**
         * @summary 列表查询登陆用户
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
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

        /**
         * @summary 列表查询登陆用户
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /**
         * @summary 列表查询登陆用户
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 根据数字水印信息查询字符串水印信息
         *
         * @param request LookupWmInfoMappingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LookupWmInfoMappingResponse
         */
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

        /**
         * @summary 根据数字水印信息查询字符串水印信息
         *
         * @param request LookupWmInfoMappingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return LookupWmInfoMappingResponse
         */
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

        /**
         * @summary 根据数字水印信息查询字符串水印信息
         *
         * @param request LookupWmInfoMappingRequest
         * @return LookupWmInfoMappingResponse
         */
        public LookupWmInfoMappingResponse LookupWmInfoMapping(LookupWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return LookupWmInfoMappingWithOptions(request, runtime);
        }

        /**
         * @summary 根据数字水印信息查询字符串水印信息
         *
         * @param request LookupWmInfoMappingRequest
         * @return LookupWmInfoMappingResponse
         */
        public async Task<LookupWmInfoMappingResponse> LookupWmInfoMappingAsync(LookupWmInfoMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await LookupWmInfoMappingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 吊销用户登录会话
         *
         * @param request RevokeUserSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeUserSessionResponse
         */
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

        /**
         * @summary 吊销用户登录会话
         *
         * @param request RevokeUserSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeUserSessionResponse
         */
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

        /**
         * @summary 吊销用户登录会话
         *
         * @param request RevokeUserSessionRequest
         * @return RevokeUserSessionResponse
         */
        public RevokeUserSessionResponse RevokeUserSession(RevokeUserSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeUserSessionWithOptions(request, runtime);
        }

        /**
         * @summary 吊销用户登录会话
         *
         * @param request RevokeUserSessionRequest
         * @return RevokeUserSessionResponse
         */
        public async Task<RevokeUserSessionResponse> RevokeUserSessionAsync(RevokeUserSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeUserSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改自定义身份源指定用户
         *
         * @param request UpdateClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClientUserResponse
         */
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

        /**
         * @summary 修改自定义身份源指定用户
         *
         * @param request UpdateClientUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClientUserResponse
         */
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

        /**
         * @summary 修改自定义身份源指定用户
         *
         * @param request UpdateClientUserRequest
         * @return UpdateClientUserResponse
         */
        public UpdateClientUserResponse UpdateClientUser(UpdateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientUserWithOptions(request, runtime);
        }

        /**
         * @summary 修改自定义身份源指定用户
         *
         * @param request UpdateClientUserRequest
         * @return UpdateClientUserResponse
         */
        public async Task<UpdateClientUserResponse> UpdateClientUserAsync(UpdateClientUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改自定义身份源指定用户密码
         *
         * @param request UpdateClientUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClientUserPasswordResponse
         */
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

        /**
         * @summary 修改自定义身份源指定用户密码
         *
         * @param request UpdateClientUserPasswordRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClientUserPasswordResponse
         */
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

        /**
         * @summary 修改自定义身份源指定用户密码
         *
         * @param request UpdateClientUserPasswordRequest
         * @return UpdateClientUserPasswordResponse
         */
        public UpdateClientUserPasswordResponse UpdateClientUserPassword(UpdateClientUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientUserPasswordWithOptions(request, runtime);
        }

        /**
         * @summary 修改自定义身份源指定用户密码
         *
         * @param request UpdateClientUserPasswordRequest
         * @return UpdateClientUserPasswordResponse
         */
        public async Task<UpdateClientUserPasswordResponse> UpdateClientUserPasswordAsync(UpdateClientUserPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientUserPasswordWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改自定义身份源指定用户启用状态
         *
         * @param request UpdateClientUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClientUserStatusResponse
         */
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

        /**
         * @summary 修改自定义身份源指定用户启用状态
         *
         * @param request UpdateClientUserStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClientUserStatusResponse
         */
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

        /**
         * @summary 修改自定义身份源指定用户启用状态
         *
         * @param request UpdateClientUserStatusRequest
         * @return UpdateClientUserStatusResponse
         */
        public UpdateClientUserStatusResponse UpdateClientUserStatus(UpdateClientUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientUserStatusWithOptions(request, runtime);
        }

        /**
         * @summary 修改自定义身份源指定用户启用状态
         *
         * @param request UpdateClientUserStatusRequest
         * @return UpdateClientUserStatusResponse
         */
        public async Task<UpdateClientUserStatusResponse> UpdateClientUserStatusAsync(UpdateClientUserStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientUserStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改动态路由
         *
         * @param request UpdateDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDynamicRouteResponse
         */
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

        /**
         * @summary 修改动态路由
         *
         * @param request UpdateDynamicRouteRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDynamicRouteResponse
         */
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

        /**
         * @summary 修改动态路由
         *
         * @param request UpdateDynamicRouteRequest
         * @return UpdateDynamicRouteResponse
         */
        public UpdateDynamicRouteResponse UpdateDynamicRoute(UpdateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDynamicRouteWithOptions(request, runtime);
        }

        /**
         * @summary 修改动态路由
         *
         * @param request UpdateDynamicRouteRequest
         * @return UpdateDynamicRouteResponse
         */
        public async Task<UpdateDynamicRouteResponse> UpdateDynamicRouteAsync(UpdateDynamicRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDynamicRouteWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量更新超额注册申请状态
         *
         * @param request UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
         */
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

        /**
         * @summary 批量更新超额注册申请状态
         *
         * @param request UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
         */
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

        /**
         * @summary 批量更新超额注册申请状态
         *
         * @param request UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
         * @return UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
         */
        public UpdateExcessiveDeviceRegistrationApplicationsStatusResponse UpdateExcessiveDeviceRegistrationApplicationsStatus(UpdateExcessiveDeviceRegistrationApplicationsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateExcessiveDeviceRegistrationApplicationsStatusWithOptions(request, runtime);
        }

        /**
         * @summary 批量更新超额注册申请状态
         *
         * @param request UpdateExcessiveDeviceRegistrationApplicationsStatusRequest
         * @return UpdateExcessiveDeviceRegistrationApplicationsStatusResponse
         */
        public async Task<UpdateExcessiveDeviceRegistrationApplicationsStatusResponse> UpdateExcessiveDeviceRegistrationApplicationsStatusAsync(UpdateExcessiveDeviceRegistrationApplicationsStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateExcessiveDeviceRegistrationApplicationsStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改指定自定义身份源部门
         *
         * @param request UpdateIdpDepartmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIdpDepartmentResponse
         */
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

        /**
         * @summary 修改指定自定义身份源部门
         *
         * @param request UpdateIdpDepartmentRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIdpDepartmentResponse
         */
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

        /**
         * @summary 修改指定自定义身份源部门
         *
         * @param request UpdateIdpDepartmentRequest
         * @return UpdateIdpDepartmentResponse
         */
        public UpdateIdpDepartmentResponse UpdateIdpDepartment(UpdateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateIdpDepartmentWithOptions(request, runtime);
        }

        /**
         * @summary 修改指定自定义身份源部门
         *
         * @param request UpdateIdpDepartmentRequest
         * @return UpdateIdpDepartmentResponse
         */
        public async Task<UpdateIdpDepartmentResponse> UpdateIdpDepartmentAsync(UpdateIdpDepartmentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateIdpDepartmentWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新NAC User 状态
         *
         * @param request UpdateNacUserCertStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNacUserCertStatusResponse
         */
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

        /**
         * @summary 更新NAC User 状态
         *
         * @param request UpdateNacUserCertStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNacUserCertStatusResponse
         */
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

        /**
         * @summary 更新NAC User 状态
         *
         * @param request UpdateNacUserCertStatusRequest
         * @return UpdateNacUserCertStatusResponse
         */
        public UpdateNacUserCertStatusResponse UpdateNacUserCertStatus(UpdateNacUserCertStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNacUserCertStatusWithOptions(request, runtime);
        }

        /**
         * @summary 更新NAC User 状态
         *
         * @param request UpdateNacUserCertStatusRequest
         * @return UpdateNacUserCertStatusResponse
         */
        public async Task<UpdateNacUserCertStatusResponse> UpdateNacUserCertStatusAsync(UpdateNacUserCertStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNacUserCertStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改内网访问应用
         *
         * @param request UpdatePrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePrivateAccessApplicationResponse
         */
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

        /**
         * @summary 修改内网访问应用
         *
         * @param request UpdatePrivateAccessApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePrivateAccessApplicationResponse
         */
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

        /**
         * @summary 修改内网访问应用
         *
         * @param request UpdatePrivateAccessApplicationRequest
         * @return UpdatePrivateAccessApplicationResponse
         */
        public UpdatePrivateAccessApplicationResponse UpdatePrivateAccessApplication(UpdatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivateAccessApplicationWithOptions(request, runtime);
        }

        /**
         * @summary 修改内网访问应用
         *
         * @param request UpdatePrivateAccessApplicationRequest
         * @return UpdatePrivateAccessApplicationResponse
         */
        public async Task<UpdatePrivateAccessApplicationResponse> UpdatePrivateAccessApplicationAsync(UpdatePrivateAccessApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivateAccessApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改内网访问策略
         *
         * @param request UpdatePrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePrivateAccessPolicyResponse
         */
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

        /**
         * @summary 修改内网访问策略
         *
         * @param request UpdatePrivateAccessPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdatePrivateAccessPolicyResponse
         */
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

        /**
         * @summary 修改内网访问策略
         *
         * @param request UpdatePrivateAccessPolicyRequest
         * @return UpdatePrivateAccessPolicyResponse
         */
        public UpdatePrivateAccessPolicyResponse UpdatePrivateAccessPolicy(UpdatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePrivateAccessPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 修改内网访问策略
         *
         * @param request UpdatePrivateAccessPolicyRequest
         * @return UpdatePrivateAccessPolicyResponse
         */
        public async Task<UpdatePrivateAccessPolicyResponse> UpdatePrivateAccessPolicyAsync(UpdatePrivateAccessPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePrivateAccessPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改设备注册策略
         *
         * @param tmpReq UpdateRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRegistrationPolicyResponse
         */
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

        /**
         * @summary 修改设备注册策略
         *
         * @param tmpReq UpdateRegistrationPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateRegistrationPolicyResponse
         */
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

        /**
         * @summary 修改设备注册策略
         *
         * @param request UpdateRegistrationPolicyRequest
         * @return UpdateRegistrationPolicyResponse
         */
        public UpdateRegistrationPolicyResponse UpdateRegistrationPolicy(UpdateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRegistrationPolicyWithOptions(request, runtime);
        }

        /**
         * @summary 修改设备注册策略
         *
         * @param request UpdateRegistrationPolicyRequest
         * @return UpdateRegistrationPolicyResponse
         */
        public async Task<UpdateRegistrationPolicyResponse> UpdateRegistrationPolicyAsync(UpdateRegistrationPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRegistrationPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量更新用户设备共享状态
         *
         * @param request UpdateUserDevicesSharingStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserDevicesSharingStatusResponse
         */
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

        /**
         * @summary 批量更新用户设备共享状态
         *
         * @param request UpdateUserDevicesSharingStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserDevicesSharingStatusResponse
         */
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

        /**
         * @summary 批量更新用户设备共享状态
         *
         * @param request UpdateUserDevicesSharingStatusRequest
         * @return UpdateUserDevicesSharingStatusResponse
         */
        public UpdateUserDevicesSharingStatusResponse UpdateUserDevicesSharingStatus(UpdateUserDevicesSharingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDevicesSharingStatusWithOptions(request, runtime);
        }

        /**
         * @summary 批量更新用户设备共享状态
         *
         * @param request UpdateUserDevicesSharingStatusRequest
         * @return UpdateUserDevicesSharingStatusResponse
         */
        public async Task<UpdateUserDevicesSharingStatusResponse> UpdateUserDevicesSharingStatusAsync(UpdateUserDevicesSharingStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDevicesSharingStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量更新用户设备状态
         *
         * @param request UpdateUserDevicesStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserDevicesStatusResponse
         */
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

        /**
         * @summary 批量更新用户设备状态
         *
         * @param request UpdateUserDevicesStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserDevicesStatusResponse
         */
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

        /**
         * @summary 批量更新用户设备状态
         *
         * @param request UpdateUserDevicesStatusRequest
         * @return UpdateUserDevicesStatusResponse
         */
        public UpdateUserDevicesStatusResponse UpdateUserDevicesStatus(UpdateUserDevicesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserDevicesStatusWithOptions(request, runtime);
        }

        /**
         * @summary 批量更新用户设备状态
         *
         * @param request UpdateUserDevicesStatusRequest
         * @return UpdateUserDevicesStatusResponse
         */
        public async Task<UpdateUserDevicesStatusResponse> UpdateUserDevicesStatusAsync(UpdateUserDevicesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserDevicesStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改用户组
         *
         * @param request UpdateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserGroupResponse
         */
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

        /**
         * @summary 修改用户组
         *
         * @param request UpdateUserGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserGroupResponse
         */
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

        /**
         * @summary 修改用户组
         *
         * @param request UpdateUserGroupRequest
         * @return UpdateUserGroupResponse
         */
        public UpdateUserGroupResponse UpdateUserGroup(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserGroupWithOptions(request, runtime);
        }

        /**
         * @summary 修改用户组
         *
         * @param request UpdateUserGroupRequest
         * @return UpdateUserGroupResponse
         */
        public async Task<UpdateUserGroupResponse> UpdateUserGroupAsync(UpdateUserGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量修改登陆用户状态
         *
         * @param request UpdateUsersStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUsersStatusResponse
         */
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

        /**
         * @summary 批量修改登陆用户状态
         *
         * @param request UpdateUsersStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUsersStatusResponse
         */
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

        /**
         * @summary 批量修改登陆用户状态
         *
         * @param request UpdateUsersStatusRequest
         * @return UpdateUsersStatusResponse
         */
        public UpdateUsersStatusResponse UpdateUsersStatus(UpdateUsersStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUsersStatusWithOptions(request, runtime);
        }

        /**
         * @summary 批量修改登陆用户状态
         *
         * @param request UpdateUsersStatusRequest
         * @return UpdateUsersStatusResponse
         */
        public async Task<UpdateUsersStatusResponse> UpdateUsersStatusAsync(UpdateUsersStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUsersStatusWithOptionsAsync(request, runtime);
        }

    }
}
