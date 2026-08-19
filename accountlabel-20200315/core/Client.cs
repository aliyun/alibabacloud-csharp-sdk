// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AccountLabel20200315.Models;

namespace AlibabaCloud.SDK.AccountLabel20200315
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("accountlabel", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public AddCustomerLabelResponse AddCustomerLabelWithOptions(AddCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endtime))
            {
                query["Endtime"] = request.Endtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomerLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomerLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public async Task<AddCustomerLabelResponse> AddCustomerLabelWithOptionsAsync(AddCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endtime))
            {
                query["Endtime"] = request.Endtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddCustomerLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddCustomerLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public AddCustomerLabelResponse AddCustomerLabel(AddCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomerLabelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// AddCustomerLabelResponse
        /// </returns>
        public async Task<AddCustomerLabelResponse> AddCustomerLabelAsync(AddCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomerLabelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>传入多个labelSeries查询标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchFetchAccountLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchFetchAccountLabelResponse
        /// </returns>
        public BatchFetchAccountLabelResponse BatchFetchAccountLabelWithOptions(BatchFetchAccountLabelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchFetchAccountLabelShrinkRequest request = new BatchFetchAccountLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSeriesList))
            {
                request.LabelSeriesListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSeriesList, "LabelSeriesList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instant))
            {
                query["Instant"] = request.Instant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeriesListShrink))
            {
                query["LabelSeriesList"] = request.LabelSeriesListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchFetchAccountLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchFetchAccountLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>传入多个labelSeries查询标签</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchFetchAccountLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchFetchAccountLabelResponse
        /// </returns>
        public async Task<BatchFetchAccountLabelResponse> BatchFetchAccountLabelWithOptionsAsync(BatchFetchAccountLabelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchFetchAccountLabelShrinkRequest request = new BatchFetchAccountLabelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.LabelSeriesList))
            {
                request.LabelSeriesListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.LabelSeriesList, "LabelSeriesList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instant))
            {
                query["Instant"] = request.Instant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeriesListShrink))
            {
                query["LabelSeriesList"] = request.LabelSeriesListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pk))
            {
                query["Pk"] = request.Pk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchFetchAccountLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchFetchAccountLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>传入多个labelSeries查询标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchFetchAccountLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchFetchAccountLabelResponse
        /// </returns>
        public BatchFetchAccountLabelResponse BatchFetchAccountLabel(BatchFetchAccountLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchFetchAccountLabelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>传入多个labelSeries查询标签</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchFetchAccountLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchFetchAccountLabelResponse
        /// </returns>
        public async Task<BatchFetchAccountLabelResponse> BatchFetchAccountLabelAsync(BatchFetchAccountLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchFetchAccountLabelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public DeleteCustomerLabelResponse DeleteCustomerLabelWithOptions(DeleteCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomerLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomerLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public async Task<DeleteCustomerLabelResponse> DeleteCustomerLabelWithOptionsAsync(DeleteCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelTypes))
            {
                query["LabelTypes"] = request.LabelTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Organization))
            {
                query["Organization"] = request.Organization;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomerLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomerLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public DeleteCustomerLabelResponse DeleteCustomerLabel(DeleteCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomerLabelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomerLabelResponse
        /// </returns>
        public async Task<DeleteCustomerLabelResponse> DeleteCustomerLabelAsync(DeleteCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomerLabelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public QueryCustomerLabelResponse QueryCustomerLabelWithOptions(QueryCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instant))
            {
                query["Instant"] = request.Instant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerLabelResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public async Task<QueryCustomerLabelResponse> QueryCustomerLabelWithOptionsAsync(QueryCustomerLabelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instant))
            {
                query["Instant"] = request.Instant;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabelSeries))
            {
                query["LabelSeries"] = request.LabelSeries;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerLabel",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerLabelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public QueryCustomerLabelResponse QueryCustomerLabel(QueryCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerLabelWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryCustomerLabelRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelResponse
        /// </returns>
        public async Task<QueryCustomerLabelResponse> QueryCustomerLabelAsync(QueryCustomerLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerLabelWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryCustomerLabelByConfigGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelByConfigGroupResponse
        /// </returns>
        public QueryCustomerLabelByConfigGroupResponse QueryCustomerLabelByConfigGroupWithOptions(QueryCustomerLabelByConfigGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerLabelByConfigGroup",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerLabelByConfigGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCustomerLabelByConfigGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelByConfigGroupResponse
        /// </returns>
        public async Task<QueryCustomerLabelByConfigGroupResponse> QueryCustomerLabelByConfigGroupWithOptionsAsync(QueryCustomerLabelByConfigGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PK))
            {
                query["PK"] = request.PK;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryCustomerLabelByConfigGroup",
                Version = "2020-03-15",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryCustomerLabelByConfigGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryCustomerLabelByConfigGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelByConfigGroupResponse
        /// </returns>
        public QueryCustomerLabelByConfigGroupResponse QueryCustomerLabelByConfigGroup(QueryCustomerLabelByConfigGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCustomerLabelByConfigGroupWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryCustomerLabelByConfigGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryCustomerLabelByConfigGroupResponse
        /// </returns>
        public async Task<QueryCustomerLabelByConfigGroupResponse> QueryCustomerLabelByConfigGroupAsync(QueryCustomerLabelByConfigGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCustomerLabelByConfigGroupWithOptionsAsync(request, runtime);
        }

    }
}
