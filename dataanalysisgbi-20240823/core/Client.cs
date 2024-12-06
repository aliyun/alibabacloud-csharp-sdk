// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DataAnalysisGBI20240823.Models;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dataanalysisgbi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public CancelDatasourceAuthorizationResponse CancelDatasourceAuthorizationWithOptions(CancelDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/cancel/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDatasourceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CancelDatasourceAuthorizationResponse> CancelDatasourceAuthorizationWithOptionsAsync(CancelDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/cancel/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDatasourceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public CancelDatasourceAuthorizationResponse CancelDatasourceAuthorization(CancelDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelDatasourceAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CancelDatasourceAuthorizationResponse> CancelDatasourceAuthorizationAsync(CancelDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelDatasourceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public CreateDatasourceAuthorizationResponse CreateDatasourceAuthorizationWithOptions(CreateDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasourceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CreateDatasourceAuthorizationResponse> CreateDatasourceAuthorizationWithOptionsAsync(CreateDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasourceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public CreateDatasourceAuthorizationResponse CreateDatasourceAuthorization(CreateDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasourceAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CreateDatasourceAuthorizationResponse> CreateDatasourceAuthorizationAsync(CreateDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasourceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public CreateVirtualDatasourceInstanceResponse CreateVirtualDatasourceInstanceWithOptions(CreateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/createVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<CreateVirtualDatasourceInstanceResponse> CreateVirtualDatasourceInstanceWithOptionsAsync(CreateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/createVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public CreateVirtualDatasourceInstanceResponse CreateVirtualDatasourceInstance(CreateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<CreateVirtualDatasourceInstanceResponse> CreateVirtualDatasourceInstanceAsync(CreateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public DeleteVirtualDatasourceInstanceResponse DeleteVirtualDatasourceInstanceWithOptions(DeleteVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/deleteVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<DeleteVirtualDatasourceInstanceResponse> DeleteVirtualDatasourceInstanceWithOptionsAsync(DeleteVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/deleteVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public DeleteVirtualDatasourceInstanceResponse DeleteVirtualDatasourceInstance(DeleteVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<DeleteVirtualDatasourceInstanceResponse> DeleteVirtualDatasourceInstanceAsync(DeleteVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public ListVirtualDatasourceInstanceResponse ListVirtualDatasourceInstanceWithOptions(ListVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/listVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<ListVirtualDatasourceInstanceResponse> ListVirtualDatasourceInstanceWithOptionsAsync(ListVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/listVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public ListVirtualDatasourceInstanceResponse ListVirtualDatasourceInstance(ListVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<ListVirtualDatasourceInstanceResponse> ListVirtualDatasourceInstanceAsync(ListVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public RunDataAnalysisResponse RunDataAnalysisWithOptions(string workspaceId, RunDataAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateSqlOnly))
            {
                body["generateSqlOnly"] = request.GenerateSqlOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationType))
            {
                body["specificationType"] = request.SpecificationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDataAnalysis",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/gbi/runDataAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDataAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public async Task<RunDataAnalysisResponse> RunDataAnalysisWithOptionsAsync(string workspaceId, RunDataAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateSqlOnly))
            {
                body["generateSqlOnly"] = request.GenerateSqlOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationType))
            {
                body["specificationType"] = request.SpecificationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDataAnalysis",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/gbi/runDataAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDataAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public RunDataAnalysisResponse RunDataAnalysis(string workspaceId, RunDataAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunDataAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public async Task<RunDataAnalysisResponse> RunDataAnalysisAsync(string workspaceId, RunDataAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunDataAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public SaveVirtualDatasourceDdlResponse SaveVirtualDatasourceDdlWithOptions(SaveVirtualDatasourceDdlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ddl))
            {
                body["ddl"] = request.Ddl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveVirtualDatasourceDdl",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/addDdl2VirtualInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveVirtualDatasourceDdlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public async Task<SaveVirtualDatasourceDdlResponse> SaveVirtualDatasourceDdlWithOptionsAsync(SaveVirtualDatasourceDdlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ddl))
            {
                body["ddl"] = request.Ddl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveVirtualDatasourceDdl",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/addDdl2VirtualInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveVirtualDatasourceDdlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public SaveVirtualDatasourceDdlResponse SaveVirtualDatasourceDdl(SaveVirtualDatasourceDdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SaveVirtualDatasourceDdlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public async Task<SaveVirtualDatasourceDdlResponse> SaveVirtualDatasourceDdlAsync(SaveVirtualDatasourceDdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SaveVirtualDatasourceDdlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public SyncRemoteTablesResponse SyncRemoteTablesWithOptions(SyncRemoteTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepTableNames))
            {
                body["keepTableNames"] = request.KeepTableNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullSamples))
            {
                body["pullSamples"] = request.PullSamples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["tableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncRemoteTables",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/datasource/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncRemoteTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public async Task<SyncRemoteTablesResponse> SyncRemoteTablesWithOptionsAsync(SyncRemoteTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepTableNames))
            {
                body["keepTableNames"] = request.KeepTableNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullSamples))
            {
                body["pullSamples"] = request.PullSamples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["tableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncRemoteTables",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/datasource/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncRemoteTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public SyncRemoteTablesResponse SyncRemoteTables(SyncRemoteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncRemoteTablesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public async Task<SyncRemoteTablesResponse> SyncRemoteTablesAsync(SyncRemoteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncRemoteTablesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public UpdateVirtualDatasourceInstanceResponse UpdateVirtualDatasourceInstanceWithOptions(UpdateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/updateVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<UpdateVirtualDatasourceInstanceResponse> UpdateVirtualDatasourceInstanceWithOptionsAsync(UpdateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/updateVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public UpdateVirtualDatasourceInstanceResponse UpdateVirtualDatasourceInstance(UpdateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<UpdateVirtualDatasourceInstanceResponse> UpdateVirtualDatasourceInstanceAsync(UpdateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

    }
}
