// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.ResourceCenter20221201.Models;

namespace AlibabaCloud.SDK.ResourceCenter20221201
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("resourcecenter", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Sets a default filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateDefaultFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateDefaultFilterResponse
        /// </returns>
        public AssociateDefaultFilterResponse AssociateDefaultFilterWithOptions(AssociateDefaultFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateDefaultFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<AssociateDefaultFilterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AssociateDefaultFilterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a default filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateDefaultFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateDefaultFilterResponse
        /// </returns>
        public async Task<AssociateDefaultFilterResponse> AssociateDefaultFilterWithOptionsAsync(AssociateDefaultFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AssociateDefaultFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<AssociateDefaultFilterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<AssociateDefaultFilterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a default filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateDefaultFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateDefaultFilterResponse
        /// </returns>
        public AssociateDefaultFilterResponse AssociateDefaultFilter(AssociateDefaultFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AssociateDefaultFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sets a default filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateDefaultFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateDefaultFilterResponse
        /// </returns>
        public async Task<AssociateDefaultFilterResponse> AssociateDefaultFilterAsync(AssociateDefaultFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AssociateDefaultFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFilterResponse
        /// </returns>
        public CreateFilterResponse CreateFilterWithOptions(CreateFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConfiguration))
            {
                query["FilterConfiguration"] = request.FilterConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<CreateFilterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFilterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFilterResponse
        /// </returns>
        public async Task<CreateFilterResponse> CreateFilterWithOptionsAsync(CreateFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConfiguration))
            {
                query["FilterConfiguration"] = request.FilterConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<CreateFilterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateFilterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFilterResponse
        /// </returns>
        public CreateFilterResponse CreateFilter(CreateFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFilterResponse
        /// </returns>
        public async Task<CreateFilterResponse> CreateFilterAsync(CreateFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSavedQueryResponse
        /// </returns>
        public CreateSavedQueryResponse CreateSavedQueryWithOptions(CreateSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<CreateSavedQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSavedQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSavedQueryResponse
        /// </returns>
        public async Task<CreateSavedQueryResponse> CreateSavedQueryWithOptionsAsync(CreateSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<CreateSavedQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<CreateSavedQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSavedQueryResponse
        /// </returns>
        public CreateSavedQueryResponse CreateSavedQuery(CreateSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSavedQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSavedQueryResponse
        /// </returns>
        public async Task<CreateSavedQueryResponse> CreateSavedQueryAsync(CreateSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSavedQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilterResponse
        /// </returns>
        public DeleteFilterResponse DeleteFilterWithOptions(DeleteFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DeleteFilterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFilterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilterResponse
        /// </returns>
        public async Task<DeleteFilterResponse> DeleteFilterWithOptionsAsync(DeleteFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DeleteFilterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteFilterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilterResponse
        /// </returns>
        public DeleteFilterResponse DeleteFilter(DeleteFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteFilterResponse
        /// </returns>
        public async Task<DeleteFilterResponse> DeleteFilterAsync(DeleteFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSavedQueryResponse
        /// </returns>
        public DeleteSavedQueryResponse DeleteSavedQueryWithOptions(DeleteSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DeleteSavedQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSavedQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSavedQueryResponse
        /// </returns>
        public async Task<DeleteSavedQueryResponse> DeleteSavedQueryWithOptionsAsync(DeleteSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DeleteSavedQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DeleteSavedQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSavedQueryResponse
        /// </returns>
        public DeleteSavedQueryResponse DeleteSavedQuery(DeleteSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSavedQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSavedQueryResponse
        /// </returns>
        public async Task<DeleteSavedQueryResponse> DeleteSavedQueryAsync(DeleteSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSavedQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableMultiAccountResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableMultiAccountResourceCenterResponse
        /// </returns>
        public DisableMultiAccountResourceCenterResponse DisableMultiAccountResourceCenterWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableMultiAccountResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DisableMultiAccountResourceCenterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableMultiAccountResourceCenterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableMultiAccountResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableMultiAccountResourceCenterResponse
        /// </returns>
        public async Task<DisableMultiAccountResourceCenterResponse> DisableMultiAccountResourceCenterWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableMultiAccountResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DisableMultiAccountResourceCenterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableMultiAccountResourceCenterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisableMultiAccountResourceCenterResponse
        /// </returns>
        public DisableMultiAccountResourceCenterResponse DisableMultiAccountResourceCenter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableMultiAccountResourceCenterWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisableMultiAccountResourceCenterResponse
        /// </returns>
        public async Task<DisableMultiAccountResourceCenterResponse> DisableMultiAccountResourceCenterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableMultiAccountResourceCenterWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableResourceCenterResponse
        /// </returns>
        public DisableResourceCenterResponse DisableResourceCenterWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DisableResourceCenterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableResourceCenterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisableResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableResourceCenterResponse
        /// </returns>
        public async Task<DisableResourceCenterResponse> DisableResourceCenterWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DisableResourceCenterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisableResourceCenterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisableResourceCenterResponse
        /// </returns>
        public DisableResourceCenterResponse DisableResourceCenter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableResourceCenterWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deactivates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisableResourceCenterResponse
        /// </returns>
        public async Task<DisableResourceCenterResponse> DisableResourceCenterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableResourceCenterWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the default filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisassociateDefaultFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisassociateDefaultFilterResponse
        /// </returns>
        public DisassociateDefaultFilterResponse DisassociateDefaultFilterWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateDefaultFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DisassociateDefaultFilterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisassociateDefaultFilterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the default filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DisassociateDefaultFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisassociateDefaultFilterResponse
        /// </returns>
        public async Task<DisassociateDefaultFilterResponse> DisassociateDefaultFilterWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisassociateDefaultFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<DisassociateDefaultFilterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<DisassociateDefaultFilterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the default filter.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisassociateDefaultFilterResponse
        /// </returns>
        public DisassociateDefaultFilterResponse DisassociateDefaultFilter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisassociateDefaultFilterWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels the default filter.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DisassociateDefaultFilterResponse
        /// </returns>
        public async Task<DisassociateDefaultFilterResponse> DisassociateDefaultFilterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisassociateDefaultFilterWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have created a resource directory for your enterprise, you can enable the cross-account resource search feature by using the management account of the resource directory or a delegated administrator account of Resource Center to view the resources of members in the resource directory. For more information about a resource directory, see <a href="https://help.aliyun.com/document_detail/200506.html">Resource Directory overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableMultiAccountResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableMultiAccountResourceCenterResponse
        /// </returns>
        public EnableMultiAccountResourceCenterResponse EnableMultiAccountResourceCenterWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMultiAccountResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<EnableMultiAccountResourceCenterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableMultiAccountResourceCenterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have created a resource directory for your enterprise, you can enable the cross-account resource search feature by using the management account of the resource directory or a delegated administrator account of Resource Center to view the resources of members in the resource directory. For more information about a resource directory, see <a href="https://help.aliyun.com/document_detail/200506.html">Resource Directory overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableMultiAccountResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableMultiAccountResourceCenterResponse
        /// </returns>
        public async Task<EnableMultiAccountResourceCenterResponse> EnableMultiAccountResourceCenterWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableMultiAccountResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<EnableMultiAccountResourceCenterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableMultiAccountResourceCenterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have created a resource directory for your enterprise, you can enable the cross-account resource search feature by using the management account of the resource directory or a delegated administrator account of Resource Center to view the resources of members in the resource directory. For more information about a resource directory, see <a href="https://help.aliyun.com/document_detail/200506.html">Resource Directory overview</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableMultiAccountResourceCenterResponse
        /// </returns>
        public EnableMultiAccountResourceCenterResponse EnableMultiAccountResourceCenter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableMultiAccountResourceCenterWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you have created a resource directory for your enterprise, you can enable the cross-account resource search feature by using the management account of the resource directory or a delegated administrator account of Resource Center to view the resources of members in the resource directory. For more information about a resource directory, see <a href="https://help.aliyun.com/document_detail/200506.html">Resource Directory overview</a>.</para>
        /// </description>
        /// 
        /// <returns>
        /// EnableMultiAccountResourceCenterResponse
        /// </returns>
        public async Task<EnableMultiAccountResourceCenterResponse> EnableMultiAccountResourceCenterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableMultiAccountResourceCenterWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableResourceCenterResponse
        /// </returns>
        public EnableResourceCenterResponse EnableResourceCenterWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<EnableResourceCenterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableResourceCenterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableResourceCenterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableResourceCenterResponse
        /// </returns>
        public async Task<EnableResourceCenterResponse> EnableResourceCenterWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableResourceCenter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<EnableResourceCenterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<EnableResourceCenterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// EnableResourceCenterResponse
        /// </returns>
        public EnableResourceCenterResponse EnableResourceCenter()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableResourceCenterWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Resource Center service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// EnableResourceCenterResponse
        /// </returns>
        public async Task<EnableResourceCenterResponse> EnableResourceCenterAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableResourceCenterWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query resources across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteMultiAccountSQLQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteMultiAccountSQLQueryResponse
        /// </returns>
        public ExecuteMultiAccountSQLQueryResponse ExecuteMultiAccountSQLQueryWithOptions(ExecuteMultiAccountSQLQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteMultiAccountSQLQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ExecuteMultiAccountSQLQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteMultiAccountSQLQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query resources across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteMultiAccountSQLQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteMultiAccountSQLQueryResponse
        /// </returns>
        public async Task<ExecuteMultiAccountSQLQueryResponse> ExecuteMultiAccountSQLQueryWithOptionsAsync(ExecuteMultiAccountSQLQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteMultiAccountSQLQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ExecuteMultiAccountSQLQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteMultiAccountSQLQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query resources across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteMultiAccountSQLQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteMultiAccountSQLQueryResponse
        /// </returns>
        public ExecuteMultiAccountSQLQueryResponse ExecuteMultiAccountSQLQuery(ExecuteMultiAccountSQLQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteMultiAccountSQLQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query resources across accounts.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteMultiAccountSQLQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteMultiAccountSQLQueryResponse
        /// </returns>
        public async Task<ExecuteMultiAccountSQLQueryResponse> ExecuteMultiAccountSQLQueryAsync(ExecuteMultiAccountSQLQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteMultiAccountSQLQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query the resources that can be accessed within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSQLQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSQLQueryResponse
        /// </returns>
        public ExecuteSQLQueryResponse ExecuteSQLQueryWithOptions(ExecuteSQLQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSQLQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ExecuteSQLQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteSQLQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query the resources that can be accessed within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSQLQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSQLQueryResponse
        /// </returns>
        public async Task<ExecuteSQLQueryResponse> ExecuteSQLQueryWithOptionsAsync(ExecuteSQLQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteSQLQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ExecuteSQLQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ExecuteSQLQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query the resources that can be accessed within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSQLQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSQLQueryResponse
        /// </returns>
        public ExecuteSQLQueryResponse ExecuteSQLQuery(ExecuteSQLQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteSQLQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes an SQL statement to query the resources that can be accessed within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteSQLQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteSQLQueryResponse
        /// </returns>
        public async Task<ExecuteSQLQueryResponse> ExecuteSQLQueryAsync(ExecuteSQLQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteSQLQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a sample query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExampleQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExampleQueryResponse
        /// </returns>
        public GetExampleQueryResponse GetExampleQueryWithOptions(GetExampleQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExampleQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetExampleQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetExampleQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a sample query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExampleQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExampleQueryResponse
        /// </returns>
        public async Task<GetExampleQueryResponse> GetExampleQueryWithOptionsAsync(GetExampleQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExampleQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetExampleQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetExampleQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a sample query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExampleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExampleQueryResponse
        /// </returns>
        public GetExampleQueryResponse GetExampleQuery(GetExampleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetExampleQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a sample query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetExampleQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetExampleQueryResponse
        /// </returns>
        public async Task<GetExampleQueryResponse> GetExampleQueryAsync(GetExampleQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetExampleQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiAccountResourceCenterServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiAccountResourceCenterServiceStatusResponse
        /// </returns>
        public GetMultiAccountResourceCenterServiceStatusResponse GetMultiAccountResourceCenterServiceStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMultiAccountResourceCenterServiceStatus",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetMultiAccountResourceCenterServiceStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetMultiAccountResourceCenterServiceStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiAccountResourceCenterServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiAccountResourceCenterServiceStatusResponse
        /// </returns>
        public async Task<GetMultiAccountResourceCenterServiceStatusResponse> GetMultiAccountResourceCenterServiceStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMultiAccountResourceCenterServiceStatus",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetMultiAccountResourceCenterServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetMultiAccountResourceCenterServiceStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMultiAccountResourceCenterServiceStatusResponse
        /// </returns>
        public GetMultiAccountResourceCenterServiceStatusResponse GetMultiAccountResourceCenterServiceStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultiAccountResourceCenterServiceStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the cross-account resource search feature by using the management account of a resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMultiAccountResourceCenterServiceStatusResponse
        /// </returns>
        public async Task<GetMultiAccountResourceCenterServiceStatusResponse> GetMultiAccountResourceCenterServiceStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultiAccountResourceCenterServiceStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the management account or a member of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiAccountResourceConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiAccountResourceConfigurationResponse
        /// </returns>
        public GetMultiAccountResourceConfigurationResponse GetMultiAccountResourceConfigurationWithOptions(GetMultiAccountResourceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
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
                Action = "GetMultiAccountResourceConfiguration",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetMultiAccountResourceConfigurationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetMultiAccountResourceConfigurationResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the management account or a member of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiAccountResourceConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMultiAccountResourceConfigurationResponse
        /// </returns>
        public async Task<GetMultiAccountResourceConfigurationResponse> GetMultiAccountResourceConfigurationWithOptionsAsync(GetMultiAccountResourceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
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
                Action = "GetMultiAccountResourceConfiguration",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetMultiAccountResourceConfigurationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetMultiAccountResourceConfigurationResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the management account or a member of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiAccountResourceConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultiAccountResourceConfigurationResponse
        /// </returns>
        public GetMultiAccountResourceConfigurationResponse GetMultiAccountResourceConfiguration(GetMultiAccountResourceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultiAccountResourceConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the management account or a member of a resource directory.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMultiAccountResourceConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMultiAccountResourceConfigurationResponse
        /// </returns>
        public async Task<GetMultiAccountResourceConfigurationResponse> GetMultiAccountResourceConfigurationAsync(GetMultiAccountResourceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultiAccountResourceConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Resource Center service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceCenterServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceCenterServiceStatusResponse
        /// </returns>
        public GetResourceCenterServiceStatusResponse GetResourceCenterServiceStatusWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceCenterServiceStatus",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetResourceCenterServiceStatusResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceCenterServiceStatusResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Resource Center service.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceCenterServiceStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceCenterServiceStatusResponse
        /// </returns>
        public async Task<GetResourceCenterServiceStatusResponse> GetResourceCenterServiceStatusWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceCenterServiceStatus",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetResourceCenterServiceStatusResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceCenterServiceStatusResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Resource Center service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetResourceCenterServiceStatusResponse
        /// </returns>
        public GetResourceCenterServiceStatusResponse GetResourceCenterServiceStatus()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceCenterServiceStatusWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of the Resource Center service.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetResourceCenterServiceStatusResponse
        /// </returns>
        public async Task<GetResourceCenterServiceStatusResponse> GetResourceCenterServiceStatusAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceCenterServiceStatusWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceConfigurationResponse
        /// </returns>
        public GetResourceConfigurationResponse GetResourceConfigurationWithOptions(GetResourceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
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
                Action = "GetResourceConfiguration",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetResourceConfigurationResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceConfigurationResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceConfigurationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceConfigurationResponse
        /// </returns>
        public async Task<GetResourceConfigurationResponse> GetResourceConfigurationWithOptionsAsync(GetResourceConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceRegionId))
            {
                query["ResourceRegionId"] = request.ResourceRegionId;
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
                Action = "GetResourceConfiguration",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetResourceConfigurationResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceConfigurationResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceConfigurationResponse
        /// </returns>
        public GetResourceConfigurationResponse GetResourceConfiguration(GetResourceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceConfigurationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a resource within the current account.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceConfigurationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceConfigurationResponse
        /// </returns>
        public async Task<GetResourceConfigurationResponse> GetResourceConfigurationAsync(GetResourceConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceConfigurationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the numbers of resources on which the current account has access permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceCountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceCountsResponse
        /// </returns>
        public GetResourceCountsResponse GetResourceCountsWithOptions(GetResourceCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByKey))
            {
                query["GroupByKey"] = request.GroupByKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceCounts",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetResourceCountsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceCountsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the numbers of resources on which the current account has access permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceCountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceCountsResponse
        /// </returns>
        public async Task<GetResourceCountsResponse> GetResourceCountsWithOptionsAsync(GetResourceCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupByKey))
            {
                query["GroupByKey"] = request.GroupByKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceCounts",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetResourceCountsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetResourceCountsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the numbers of resources on which the current account has access permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceCountsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceCountsResponse
        /// </returns>
        public GetResourceCountsResponse GetResourceCounts(GetResourceCountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceCountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the numbers of resources on which the current account has access permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceCountsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceCountsResponse
        /// </returns>
        public async Task<GetResourceCountsResponse> GetResourceCountsAsync(GetResourceCountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceCountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavedQueryResponse
        /// </returns>
        public GetSavedQueryResponse GetSavedQueryWithOptions(GetSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetSavedQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSavedQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSavedQueryResponse
        /// </returns>
        public async Task<GetSavedQueryResponse> GetSavedQueryWithOptionsAsync(GetSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<GetSavedQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<GetSavedQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavedQueryResponse
        /// </returns>
        public GetSavedQueryResponse GetSavedQuery(GetSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSavedQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSavedQueryResponse
        /// </returns>
        public async Task<GetSavedQueryResponse> GetSavedQueryAsync(GetSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSavedQueryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all sample query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExampleQueriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExampleQueriesResponse
        /// </returns>
        public ListExampleQueriesResponse ListExampleQueriesWithOptions(ListExampleQueriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExampleQueries",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListExampleQueriesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListExampleQueriesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all sample query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExampleQueriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExampleQueriesResponse
        /// </returns>
        public async Task<ListExampleQueriesResponse> ListExampleQueriesWithOptionsAsync(ListExampleQueriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExampleQueries",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListExampleQueriesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListExampleQueriesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all sample query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExampleQueriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExampleQueriesResponse
        /// </returns>
        public ListExampleQueriesResponse ListExampleQueries(ListExampleQueriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExampleQueriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all sample query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExampleQueriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExampleQueriesResponse
        /// </returns>
        public async Task<ListExampleQueriesResponse> ListExampleQueriesAsync(ListExampleQueriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExampleQueriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of filters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFiltersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFiltersResponse
        /// </returns>
        public ListFiltersResponse ListFiltersWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFilters",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListFiltersResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFiltersResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of filters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFiltersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFiltersResponse
        /// </returns>
        public async Task<ListFiltersResponse> ListFiltersWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFilters",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListFiltersResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListFiltersResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of filters.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListFiltersResponse
        /// </returns>
        public ListFiltersResponse ListFilters()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFiltersWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of filters.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListFiltersResponse
        /// </returns>
        public async Task<ListFiltersResponse> ListFiltersAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFiltersWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource groups within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceGroupsResponse
        /// </returns>
        public ListMultiAccountResourceGroupsResponse ListMultiAccountResourceGroupsWithOptions(ListMultiAccountResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiAccountResourceGroups",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountResourceGroupsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountResourceGroupsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource groups within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceGroupsResponse
        /// </returns>
        public async Task<ListMultiAccountResourceGroupsResponse> ListMultiAccountResourceGroupsWithOptionsAsync(ListMultiAccountResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                query["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupIds))
            {
                query["ResourceGroupIds"] = request.ResourceGroupIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiAccountResourceGroups",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountResourceGroupsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountResourceGroupsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource groups within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceGroupsResponse
        /// </returns>
        public ListMultiAccountResourceGroupsResponse ListMultiAccountResourceGroups(ListMultiAccountResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMultiAccountResourceGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource groups within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceGroupsResponse
        /// </returns>
        public async Task<ListMultiAccountResourceGroupsResponse> ListMultiAccountResourceGroupsAsync(ListMultiAccountResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMultiAccountResourceGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨账号列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceRelationshipsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceRelationshipsResponse
        /// </returns>
        public ListMultiAccountResourceRelationshipsResponse ListMultiAccountResourceRelationshipsWithOptions(ListMultiAccountResourceRelationshipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedResourceFilter))
            {
                query["RelatedResourceFilter"] = request.RelatedResourceFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiAccountResourceRelationships",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountResourceRelationshipsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountResourceRelationshipsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨账号列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceRelationshipsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceRelationshipsResponse
        /// </returns>
        public async Task<ListMultiAccountResourceRelationshipsResponse> ListMultiAccountResourceRelationshipsWithOptionsAsync(ListMultiAccountResourceRelationshipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedResourceFilter))
            {
                query["RelatedResourceFilter"] = request.RelatedResourceFilter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiAccountResourceRelationships",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountResourceRelationshipsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountResourceRelationshipsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨账号列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceRelationshipsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceRelationshipsResponse
        /// </returns>
        public ListMultiAccountResourceRelationshipsResponse ListMultiAccountResourceRelationships(ListMultiAccountResourceRelationshipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMultiAccountResourceRelationshipsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>跨账号列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountResourceRelationshipsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountResourceRelationshipsResponse
        /// </returns>
        public async Task<ListMultiAccountResourceRelationshipsResponse> ListMultiAccountResourceRelationshipsAsync(ListMultiAccountResourceRelationshipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMultiAccountResourceRelationshipsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagKeysResponse
        /// </returns>
        public ListMultiAccountTagKeysResponse ListMultiAccountTagKeysWithOptions(ListMultiAccountTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
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
                Action = "ListMultiAccountTagKeys",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountTagKeysResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountTagKeysResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagKeysResponse
        /// </returns>
        public async Task<ListMultiAccountTagKeysResponse> ListMultiAccountTagKeysWithOptionsAsync(ListMultiAccountTagKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
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
                Action = "ListMultiAccountTagKeys",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountTagKeysResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountTagKeysResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagKeysResponse
        /// </returns>
        public ListMultiAccountTagKeysResponse ListMultiAccountTagKeys(ListMultiAccountTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMultiAccountTagKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagKeysResponse
        /// </returns>
        public async Task<ListMultiAccountTagKeysResponse> ListMultiAccountTagKeysAsync(ListMultiAccountTagKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMultiAccountTagKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagValuesResponse
        /// </returns>
        public ListMultiAccountTagValuesResponse ListMultiAccountTagValuesWithOptions(ListMultiAccountTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiAccountTagValues",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountTagValuesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountTagValuesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagValuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagValuesResponse
        /// </returns>
        public async Task<ListMultiAccountTagValuesResponse> ListMultiAccountTagValuesWithOptionsAsync(ListMultiAccountTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMultiAccountTagValues",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListMultiAccountTagValuesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListMultiAccountTagValuesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagValuesResponse
        /// </returns>
        public ListMultiAccountTagValuesResponse ListMultiAccountTagValues(ListMultiAccountTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMultiAccountTagValuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of resources within the management account or a member of a resource directory by using the management account of the resource directory or a delegated administrator account of Resource Center.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMultiAccountTagValuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMultiAccountTagValuesResponse
        /// </returns>
        public async Task<ListMultiAccountTagValuesResponse> ListMultiAccountTagValuesAsync(ListMultiAccountTagValuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMultiAccountTagValuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRelationshipsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRelationshipsResponse
        /// </returns>
        public ListResourceRelationshipsResponse ListResourceRelationshipsWithOptions(ListResourceRelationshipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedResourceFilter))
            {
                query["RelatedResourceFilter"] = request.RelatedResourceFilter;
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
                Action = "ListResourceRelationships",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListResourceRelationshipsResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListResourceRelationshipsResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRelationshipsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRelationshipsResponse
        /// </returns>
        public async Task<ListResourceRelationshipsResponse> ListResourceRelationshipsWithOptionsAsync(ListResourceRelationshipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RelatedResourceFilter))
            {
                query["RelatedResourceFilter"] = request.RelatedResourceFilter;
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
                Action = "ListResourceRelationships",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListResourceRelationshipsResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListResourceRelationshipsResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRelationshipsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRelationshipsResponse
        /// </returns>
        public ListResourceRelationshipsResponse ListResourceRelationships(ListResourceRelationshipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceRelationshipsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceRelationshipsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceRelationshipsResponse
        /// </returns>
        public async Task<ListResourceRelationshipsResponse> ListResourceRelationshipsAsync(ListResourceRelationshipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceRelationshipsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of resource types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public ListResourceTypesResponse ListResourceTypesWithOptions(ListResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
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
                Action = "ListResourceTypes",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListResourceTypesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListResourceTypesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of resource types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public async Task<ListResourceTypesResponse> ListResourceTypesWithOptionsAsync(ListResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
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
                Action = "ListResourceTypes",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListResourceTypesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListResourceTypesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of resource types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public ListResourceTypesResponse ListResourceTypes(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceTypesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata of resource types.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceTypesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceTypesResponse
        /// </returns>
        public async Task<ListResourceTypesResponse> ListResourceTypesAsync(ListResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceTypesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all custom query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavedQueriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSavedQueriesResponse
        /// </returns>
        public ListSavedQueriesResponse ListSavedQueriesWithOptions(ListSavedQueriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavedQueries",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListSavedQueriesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSavedQueriesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all custom query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavedQueriesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSavedQueriesResponse
        /// </returns>
        public async Task<ListSavedQueriesResponse> ListSavedQueriesWithOptionsAsync(ListSavedQueriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavedQueries",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListSavedQueriesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListSavedQueriesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all custom query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavedQueriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSavedQueriesResponse
        /// </returns>
        public ListSavedQueriesResponse ListSavedQueries(ListSavedQueriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSavedQueriesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all custom query templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSavedQueriesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSavedQueriesResponse
        /// </returns>
        public async Task<ListSavedQueriesResponse> ListSavedQueriesAsync(ListSavedQueriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSavedQueriesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the current account.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListTagKeys",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListTagKeysResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagKeysResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the current account.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListTagKeys",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListTagKeysResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagKeysResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag keys of resources within the current account.</para>
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
        /// <para>Queries the tag keys of resources within the current account.</para>
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
        /// <para>Queries the tag values of resources within the current account.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListTagValuesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagValuesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of resources within the current account.</para>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchType))
            {
                query["MatchType"] = request.MatchType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagValue))
            {
                query["TagValue"] = request.TagValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagValues",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<ListTagValuesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<ListTagValuesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tag values of resources within the current account.</para>
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
        /// <para>Queries the tag values of resources within the current account.</para>
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
        /// <para>Searches for resources within the management account or members of a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you use a RAM user or a RAM role to call the operation, you must make sure that the RAM user or RAM role is granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/600556.html">Grant a RAM user the permissions to use Resource Center</a>.</description></item>
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.alibabacloud.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchMultiAccountResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMultiAccountResourcesResponse
        /// </returns>
        public SearchMultiAccountResourcesResponse SearchMultiAccountResourcesWithOptions(SearchMultiAccountResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriterion))
            {
                query["SortCriterion"] = request.SortCriterion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMultiAccountResources",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<SearchMultiAccountResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SearchMultiAccountResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for resources within the management account or members of a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you use a RAM user or a RAM role to call the operation, you must make sure that the RAM user or RAM role is granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/600556.html">Grant a RAM user the permissions to use Resource Center</a>.</description></item>
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.alibabacloud.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchMultiAccountResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchMultiAccountResourcesResponse
        /// </returns>
        public async Task<SearchMultiAccountResourcesResponse> SearchMultiAccountResourcesWithOptionsAsync(SearchMultiAccountResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriterion))
            {
                query["SortCriterion"] = request.SortCriterion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchMultiAccountResources",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<SearchMultiAccountResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SearchMultiAccountResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for resources within the management account or members of a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you use a RAM user or a RAM role to call the operation, you must make sure that the RAM user or RAM role is granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/600556.html">Grant a RAM user the permissions to use Resource Center</a>.</description></item>
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.alibabacloud.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchMultiAccountResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMultiAccountResourcesResponse
        /// </returns>
        public SearchMultiAccountResourcesResponse SearchMultiAccountResources(SearchMultiAccountResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMultiAccountResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Searches for resources within the management account or members of a resource directory.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you use a RAM user or a RAM role to call the operation, you must make sure that the RAM user or RAM role is granted the required permissions. For more information, see <a href="https://help.aliyun.com/document_detail/600556.html">Grant a RAM user the permissions to use Resource Center</a>.</description></item>
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.alibabacloud.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchMultiAccountResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchMultiAccountResourcesResponse
        /// </returns>
        public async Task<SearchMultiAccountResourcesResponse> SearchMultiAccountResourcesAsync(SearchMultiAccountResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMultiAccountResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for resources that you can access within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.aliyun.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResourcesResponse
        /// </returns>
        public SearchResourcesResponse SearchResourcesWithOptions(SearchResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriterion))
            {
                query["SortCriterion"] = request.SortCriterion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchResources",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<SearchResourcesResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SearchResourcesResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for resources that you can access within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.aliyun.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchResourcesResponse
        /// </returns>
        public async Task<SearchResourcesResponse> SearchResourcesWithOptionsAsync(SearchResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriterion))
            {
                query["SortCriterion"] = request.SortCriterion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchResources",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<SearchResourcesResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<SearchResourcesResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for resources that you can access within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.aliyun.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResourcesResponse
        /// </returns>
        public SearchResourcesResponse SearchResources(SearchResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Search for resources that you can access within the current account.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can use this operation to search for only resources whose types are supported by Resource Center in services that work with Resource Center. For more information about the services and the resource types that are supported by Resource Center, see <a href="https://help.aliyun.com/document_detail/477798.html">Services that work with Resource Center</a>.</para>
        /// <list type="bullet">
        /// <item><description>By default, the operation returns a maximum of 20 entries. You can configure the <c>MaxResults</c> parameter to specify the maximum number of entries to return.</description></item>
        /// <item><description>If the response does not contain the <c>NextToken</c> parameter, all entries are returned. Otherwise, more entries exist. If you want to obtain the entries, you can call the operation again to initiate another query request. In the request, set the <c>NextToken</c> parameter to the value of <c>NextToken</c> in the last response of the operation. If you do not configure the <c>NextToken</c> parameter, entries on the first page are returned by default.</description></item>
        /// <item><description>You can specify one or more filter conditions to narrow the search scope. For more information about supported filter parameters and matching methods, see the Supported filter parameters section. Multiple filter conditions have logical <c>AND</c> relations. Only resources that meet all filter conditions are returned. The values of a filter condition have logical <c>OR</c> relations. Resources that meet any value of the filter condition are returned.</description></item>
        /// <item><description>You can visit <a href="https://api.aliyun.com/api-tools/demo/ResourceCenter">Sample Code Center</a> to view more sample queries.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SearchResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchResourcesResponse
        /// </returns>
        public async Task<SearchResourcesResponse> SearchResourcesAsync(SearchResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFilterResponse
        /// </returns>
        public UpdateFilterResponse UpdateFilterWithOptions(UpdateFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConfiguration))
            {
                query["FilterConfiguration"] = request.FilterConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<UpdateFilterResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateFilterResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFilterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateFilterResponse
        /// </returns>
        public async Task<UpdateFilterResponse> UpdateFilterWithOptionsAsync(UpdateFilterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterConfiguration))
            {
                query["FilterConfiguration"] = request.FilterConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterName))
            {
                query["FilterName"] = request.FilterName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateFilter",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<UpdateFilterResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateFilterResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFilterResponse
        /// </returns>
        public UpdateFilterResponse UpdateFilter(UpdateFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFilterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a filter.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateFilterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateFilterResponse
        /// </returns>
        public async Task<UpdateFilterResponse> UpdateFilterAsync(UpdateFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFilterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSavedQueryResponse
        /// </returns>
        public UpdateSavedQueryResponse UpdateSavedQueryWithOptions(UpdateSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<UpdateSavedQueryResponse>(CallApi(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSavedQueryResponse>(Execute(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSavedQueryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSavedQueryResponse
        /// </returns>
        public async Task<UpdateSavedQueryResponse> UpdateSavedQueryWithOptionsAsync(UpdateSavedQueryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expression))
            {
                query["Expression"] = request.Expression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSavedQuery",
                Version = "2022-12-01",
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
                return TeaModel.ToObject<UpdateSavedQueryResponse>(await CallApiAsync(params_, req, runtime));
            }
            else
            {
                return TeaModel.ToObject<UpdateSavedQueryResponse>(await ExecuteAsync(params_, req, runtime));
            }
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSavedQueryResponse
        /// </returns>
        public UpdateSavedQueryResponse UpdateSavedQuery(UpdateSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSavedQueryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a custom query template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSavedQueryRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSavedQueryResponse
        /// </returns>
        public async Task<UpdateSavedQueryResponse> UpdateSavedQueryAsync(UpdateSavedQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSavedQueryWithOptionsAsync(request, runtime);
        }

    }
}
