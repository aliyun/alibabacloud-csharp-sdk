// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sae20190506.Models;

namespace AlibabaCloud.SDK.Sae20190506
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sae", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Terminates a change order and rolls back the corresponding application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortAndRollbackChangeOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortAndRollbackChangeOrderResponse
        /// </returns>
        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrderWithOptions(AbortAndRollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortAndRollbackChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortAndRollbackChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a change order and rolls back the corresponding application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortAndRollbackChangeOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortAndRollbackChangeOrderResponse
        /// </returns>
        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderWithOptionsAsync(AbortAndRollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortAndRollbackChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortAndRollbackChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a change order and rolls back the corresponding application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortAndRollbackChangeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortAndRollbackChangeOrderResponse
        /// </returns>
        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrder(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortAndRollbackChangeOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a change order and rolls back the corresponding application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortAndRollbackChangeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortAndRollbackChangeOrderResponse
        /// </returns>
        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderAsync(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortAndRollbackChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminate a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortChangeOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortChangeOrderResponse
        /// </returns>
        public AbortChangeOrderResponse AbortChangeOrderWithOptions(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rollback))
            {
                query["Rollback"] = request.Rollback;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminate a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortChangeOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AbortChangeOrderResponse
        /// </returns>
        public async Task<AbortChangeOrderResponse> AbortChangeOrderWithOptionsAsync(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rollback))
            {
                query["Rollback"] = request.Rollback;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminate a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortChangeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortChangeOrderResponse
        /// </returns>
        public AbortChangeOrderResponse AbortChangeOrder(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortChangeOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminate a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AbortChangeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// AbortChangeOrderResponse
        /// </returns>
        public async Task<AbortChangeOrderResponse> AbortChangeOrderAsync(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-shanghai</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStartApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchStartApplicationsResponse
        /// </returns>
        public BatchStartApplicationsResponse BatchStartApplicationsWithOptions(BatchStartApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStartApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-shanghai</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStartApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchStartApplicationsResponse
        /// </returns>
        public async Task<BatchStartApplicationsResponse> BatchStartApplicationsWithOptionsAsync(BatchStartApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStartApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-shanghai</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStartApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchStartApplicationsResponse
        /// </returns>
        public BatchStartApplicationsResponse BatchStartApplications(BatchStartApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchStartApplicationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-shanghai</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStartApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchStartApplicationsResponse
        /// </returns>
        public async Task<BatchStartApplicationsResponse> BatchStartApplicationsAsync(BatchStartApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchStartApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops multiple applications at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStopApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchStopApplicationsResponse
        /// </returns>
        public BatchStopApplicationsResponse BatchStopApplicationsWithOptions(BatchStopApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStopApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops multiple applications at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStopApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchStopApplicationsResponse
        /// </returns>
        public async Task<BatchStopApplicationsResponse> BatchStopApplicationsWithOptionsAsync(BatchStopApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["Version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStopApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops multiple applications at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStopApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchStopApplicationsResponse
        /// </returns>
        public BatchStopApplicationsResponse BatchStopApplications(BatchStopApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchStopApplicationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops multiple applications at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchStopApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchStopApplicationsResponse
        /// </returns>
        public async Task<BatchStopApplicationsResponse> BatchStopApplicationsAsync(BatchStopApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchStopApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// BindSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindSlbResponse
        /// </returns>
        public BindSlbResponse BindSlbWithOptions(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbChargeType))
            {
                query["InternetSlbChargeType"] = request.InternetSlbChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbChargeType))
            {
                query["IntranetSlbChargeType"] = request.IntranetSlbChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSlbResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BindSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindSlbResponse
        /// </returns>
        public async Task<BindSlbResponse> BindSlbWithOptionsAsync(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbChargeType))
            {
                query["InternetSlbChargeType"] = request.InternetSlbChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbChargeType))
            {
                query["IntranetSlbChargeType"] = request.IntranetSlbChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BindSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// BindSlbResponse
        /// </returns>
        public BindSlbResponse BindSlb(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindSlbWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// BindSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// BindSlbResponse
        /// </returns>
        public async Task<BindSlbResponse> BindSlbAsync(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindSlbWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// ConfirmPipelineBatchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPipelineBatchResponse
        /// </returns>
        public ConfirmPipelineBatchResponse ConfirmPipelineBatchWithOptions(ConfirmPipelineBatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmPipelineBatch",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ConfirmPipelineBatch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmPipelineBatchResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ConfirmPipelineBatchRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPipelineBatchResponse
        /// </returns>
        public async Task<ConfirmPipelineBatchResponse> ConfirmPipelineBatchWithOptionsAsync(ConfirmPipelineBatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmPipelineBatch",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ConfirmPipelineBatch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmPipelineBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ConfirmPipelineBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPipelineBatchResponse
        /// </returns>
        public ConfirmPipelineBatchResponse ConfirmPipelineBatch(ConfirmPipelineBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmPipelineBatchWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// ConfirmPipelineBatchRequest
        /// </param>
        /// 
        /// <returns>
        /// ConfirmPipelineBatchResponse
        /// </returns>
        public async Task<ConfirmPipelineBatchResponse> ConfirmPipelineBatchAsync(ConfirmPipelineBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmPipelineBatchWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="tmpReq">
        /// CreateApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApplicationShrinkRequest request = new CreateApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InitContainersConfig))
            {
                request.InitContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InitContainersConfig, "InitContainersConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SidecarContainersConfig))
            {
                request.SidecarContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SidecarContainersConfig, "SidecarContainersConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomImageNetworkType))
            {
                query["CustomImageNetworkType"] = request.CustomImageNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dotnet))
            {
                query["Dotnet"] = request.Dotnet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCpuBurst))
            {
                query["EnableCpuBurst"] = request.EnableCpuBurst;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEbpf))
            {
                query["EnableEbpf"] = request.EnableEbpf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNewArms))
            {
                query["EnableNewArms"] = request.EnableNewArms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuConfig))
            {
                query["GpuConfig"] = request.GpuConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroserviceEngineConfig))
            {
                query["MicroserviceEngineConfig"] = request.MicroserviceEngineConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSaeVersion))
            {
                query["NewSaeVersion"] = request.NewSaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OidcRoleName))
            {
                query["OidcRoleName"] = request.OidcRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaeVersion))
            {
                query["SaeVersion"] = request.SaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretMountDesc))
            {
                query["SecretMountDesc"] = request.SecretMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupProbe))
            {
                query["StartupProbe"] = request.StartupProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseAppId))
            {
                body["BaseAppId"] = request.BaseAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarResourceIsolated))
            {
                body["EnableSidecarResourceIsolated"] = request.EnableSidecarResourceIsolated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainersConfigShrink))
            {
                body["InitContainersConfig"] = request.InitContainersConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistrationConfig))
            {
                body["MicroRegistrationConfig"] = request.MicroRegistrationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTags))
            {
                body["ServiceTags"] = request.ServiceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarContainersConfigShrink))
            {
                body["SidecarContainersConfig"] = request.SidecarContainersConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/createApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="tmpReq">
        /// CreateApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApplicationShrinkRequest request = new CreateApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InitContainersConfig))
            {
                request.InitContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InitContainersConfig, "InitContainersConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SidecarContainersConfig))
            {
                request.SidecarContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SidecarContainersConfig, "SidecarContainersConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomImageNetworkType))
            {
                query["CustomImageNetworkType"] = request.CustomImageNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dotnet))
            {
                query["Dotnet"] = request.Dotnet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCpuBurst))
            {
                query["EnableCpuBurst"] = request.EnableCpuBurst;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEbpf))
            {
                query["EnableEbpf"] = request.EnableEbpf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNewArms))
            {
                query["EnableNewArms"] = request.EnableNewArms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuConfig))
            {
                query["GpuConfig"] = request.GpuConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroserviceEngineConfig))
            {
                query["MicroserviceEngineConfig"] = request.MicroserviceEngineConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSaeVersion))
            {
                query["NewSaeVersion"] = request.NewSaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OidcRoleName))
            {
                query["OidcRoleName"] = request.OidcRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaeVersion))
            {
                query["SaeVersion"] = request.SaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretMountDesc))
            {
                query["SecretMountDesc"] = request.SecretMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupProbe))
            {
                query["StartupProbe"] = request.StartupProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BaseAppId))
            {
                body["BaseAppId"] = request.BaseAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarResourceIsolated))
            {
                body["EnableSidecarResourceIsolated"] = request.EnableSidecarResourceIsolated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainersConfigShrink))
            {
                body["InitContainersConfig"] = request.InitContainersConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistrationConfig))
            {
                body["MicroRegistrationConfig"] = request.MicroRegistrationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTags))
            {
                body["ServiceTags"] = request.ServiceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarContainersConfigShrink))
            {
                body["SidecarContainersConfig"] = request.SidecarContainersConfigShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/createApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// CreateApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationResponse
        /// </returns>
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The HTTP status code. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationScalingRuleResponse
        /// </returns>
        public CreateApplicationScalingRuleResponse CreateApplicationScalingRuleWithOptions(CreateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIdle))
            {
                query["EnableIdle"] = request.EnableIdle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The HTTP status code. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationScalingRuleResponse
        /// </returns>
        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleWithOptionsAsync(CreateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIdle))
            {
                query["EnableIdle"] = request.EnableIdle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The HTTP status code. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationScalingRuleResponse
        /// </returns>
        public CreateApplicationScalingRuleResponse CreateApplicationScalingRule(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The HTTP status code. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApplicationScalingRuleResponse
        /// </returns>
        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleAsync(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a ConfigMap in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigMapResponse
        /// </returns>
        public CreateConfigMapResponse CreateConfigMapWithOptions(CreateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a ConfigMap in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigMapResponse
        /// </returns>
        public async Task<CreateConfigMapResponse> CreateConfigMapWithOptionsAsync(CreateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a ConfigMap in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigMapResponse
        /// </returns>
        public CreateConfigMapResponse CreateConfigMap(CreateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigMapWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a ConfigMap in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateConfigMapResponse
        /// </returns>
        public async Task<CreateConfigMapResponse> CreateConfigMapAsync(CreateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a canary release rule for a Spring Cloud or Dubbo application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGreyTagRouteResponse
        /// </returns>
        public CreateGreyTagRouteResponse CreateGreyTagRouteWithOptions(CreateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a canary release rule for a Spring Cloud or Dubbo application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGreyTagRouteResponse
        /// </returns>
        public async Task<CreateGreyTagRouteResponse> CreateGreyTagRouteWithOptionsAsync(CreateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a canary release rule for a Spring Cloud or Dubbo application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGreyTagRouteResponse
        /// </returns>
        public CreateGreyTagRouteResponse CreateGreyTagRoute(CreateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGreyTagRouteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a canary release rule for a Spring Cloud or Dubbo application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGreyTagRouteResponse
        /// </returns>
        public async Task<CreateGreyTagRouteResponse> CreateGreyTagRouteAsync(CreateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIngressResponse
        /// </returns>
        public CreateIngressResponse CreateIngressWithOptions(CreateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorsConfig))
            {
                query["CorsConfig"] = request.CorsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedFor))
            {
                query["EnableXForwardedFor"] = request.EnableXForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForClientSrcPort))
            {
                query["EnableXForwardedForClientSrcPort"] = request.EnableXForwardedForClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForProto))
            {
                query["EnableXForwardedForProto"] = request.EnableXForwardedForProto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbId))
            {
                query["EnableXForwardedForSlbId"] = request.EnableXForwardedForSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbPort))
            {
                query["EnableXForwardedForSlbPort"] = request.EnableXForwardedForSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerEdition))
            {
                query["LoadBalancerEdition"] = request.LoadBalancerEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIngressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateIngressResponse
        /// </returns>
        public async Task<CreateIngressResponse> CreateIngressWithOptionsAsync(CreateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddressType))
            {
                query["AddressType"] = request.AddressType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorsConfig))
            {
                query["CorsConfig"] = request.CorsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedFor))
            {
                query["EnableXForwardedFor"] = request.EnableXForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForClientSrcPort))
            {
                query["EnableXForwardedForClientSrcPort"] = request.EnableXForwardedForClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForProto))
            {
                query["EnableXForwardedForProto"] = request.EnableXForwardedForProto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbId))
            {
                query["EnableXForwardedForSlbId"] = request.EnableXForwardedForSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbPort))
            {
                query["EnableXForwardedForSlbPort"] = request.EnableXForwardedForSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerEdition))
            {
                query["LoadBalancerEdition"] = request.LoadBalancerEdition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneMappings))
            {
                query["ZoneMappings"] = request.ZoneMappings;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIngressResponse
        /// </returns>
        public CreateIngressResponse CreateIngress(CreateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIngressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateIngressResponse
        /// </returns>
        public async Task<CreateIngressResponse> CreateIngressAsync(CreateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIngressWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/createJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/createJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateNamespaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNamespaceResponse
        /// </returns>
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrUpdateSwimmingLaneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneResponse
        /// </returns>
        public CreateOrUpdateSwimmingLaneResponse CreateOrUpdateSwimmingLaneWithOptions(CreateOrUpdateSwimmingLaneRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrUpdateSwimmingLaneShrinkRequest request = new CreateOrUpdateSwimmingLaneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppEntryRule))
            {
                request.AppEntryRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppEntryRule, "AppEntryRule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MseGatewayEntryRule))
            {
                request.MseGatewayEntryRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MseGatewayEntryRule, "MseGatewayEntryRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppEntryRuleShrink))
            {
                query["AppEntryRule"] = request.AppEntryRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanaryModel))
            {
                query["CanaryModel"] = request.CanaryModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneName))
            {
                query["LaneName"] = request.LaneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneTag))
            {
                query["LaneTag"] = request.LaneTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MseGatewayEntryRuleShrink))
            {
                query["MseGatewayEntryRule"] = request.MseGatewayEntryRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrUpdateSwimmingLane",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/createOrUpdateSwimmingLane",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateSwimmingLaneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrUpdateSwimmingLaneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneResponse
        /// </returns>
        public async Task<CreateOrUpdateSwimmingLaneResponse> CreateOrUpdateSwimmingLaneWithOptionsAsync(CreateOrUpdateSwimmingLaneRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrUpdateSwimmingLaneShrinkRequest request = new CreateOrUpdateSwimmingLaneShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppEntryRule))
            {
                request.AppEntryRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppEntryRule, "AppEntryRule", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MseGatewayEntryRule))
            {
                request.MseGatewayEntryRuleShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MseGatewayEntryRule, "MseGatewayEntryRule", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppEntryRuleShrink))
            {
                query["AppEntryRule"] = request.AppEntryRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CanaryModel))
            {
                query["CanaryModel"] = request.CanaryModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneName))
            {
                query["LaneName"] = request.LaneName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneTag))
            {
                query["LaneTag"] = request.LaneTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MseGatewayEntryRuleShrink))
            {
                query["MseGatewayEntryRule"] = request.MseGatewayEntryRuleShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrUpdateSwimmingLane",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/createOrUpdateSwimmingLane",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateSwimmingLaneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateSwimmingLaneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneResponse
        /// </returns>
        public CreateOrUpdateSwimmingLaneResponse CreateOrUpdateSwimmingLane(CreateOrUpdateSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOrUpdateSwimmingLaneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateSwimmingLaneRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneResponse
        /// </returns>
        public async Task<CreateOrUpdateSwimmingLaneResponse> CreateOrUpdateSwimmingLaneAsync(CreateOrUpdateSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOrUpdateSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道组</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrUpdateSwimmingLaneGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneGroupResponse
        /// </returns>
        public CreateOrUpdateSwimmingLaneGroupResponse CreateOrUpdateSwimmingLaneGroupWithOptions(CreateOrUpdateSwimmingLaneGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrUpdateSwimmingLaneGroupShrinkRequest request = new CreateOrUpdateSwimmingLaneGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppIds))
            {
                request.AppIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppIds, "AppIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdsShrink))
            {
                query["AppIds"] = request.AppIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryAppId))
            {
                query["EntryAppId"] = request.EntryAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryAppType))
            {
                query["EntryAppType"] = request.EntryAppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimVersion))
            {
                query["SwimVersion"] = request.SwimVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrUpdateSwimmingLaneGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/createOrUpdateSwimmingLaneGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateSwimmingLaneGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道组</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateOrUpdateSwimmingLaneGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneGroupResponse
        /// </returns>
        public async Task<CreateOrUpdateSwimmingLaneGroupResponse> CreateOrUpdateSwimmingLaneGroupWithOptionsAsync(CreateOrUpdateSwimmingLaneGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateOrUpdateSwimmingLaneGroupShrinkRequest request = new CreateOrUpdateSwimmingLaneGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AppIds))
            {
                request.AppIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AppIds, "AppIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIdsShrink))
            {
                query["AppIds"] = request.AppIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryAppId))
            {
                query["EntryAppId"] = request.EntryAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryAppType))
            {
                query["EntryAppType"] = request.EntryAppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimVersion))
            {
                query["SwimVersion"] = request.SwimVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOrUpdateSwimmingLaneGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/createOrUpdateSwimmingLaneGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOrUpdateSwimmingLaneGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateSwimmingLaneGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneGroupResponse
        /// </returns>
        public CreateOrUpdateSwimmingLaneGroupResponse CreateOrUpdateSwimmingLaneGroup(CreateOrUpdateSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOrUpdateSwimmingLaneGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建或者更新泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOrUpdateSwimmingLaneGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOrUpdateSwimmingLaneGroupResponse
        /// </returns>
        public async Task<CreateOrUpdateSwimmingLaneGroupResponse> CreateOrUpdateSwimmingLaneGroupAsync(CreateOrUpdateSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOrUpdateSwimmingLaneGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
        public CreateSecretResponse CreateSecretWithOptions(CreateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretType))
            {
                query["SecretType"] = request.SecretType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
        public async Task<CreateSecretResponse> CreateSecretWithOptionsAsync(CreateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretType))
            {
                query["SecretType"] = request.SecretType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
        public CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSecretWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Null</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSecretResponse
        /// </returns>
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSecretWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a web application</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the CreateWebApplication operation to create a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWebApplicationResponse
        /// </returns>
        public CreateWebApplicationResponse CreateWebApplicationWithOptions(CreateWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWebApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a web application</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the CreateWebApplication operation to create a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWebApplicationResponse
        /// </returns>
        public async Task<CreateWebApplicationResponse> CreateWebApplicationWithOptionsAsync(CreateWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWebApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a web application</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the CreateWebApplication operation to create a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWebApplicationResponse
        /// </returns>
        public CreateWebApplicationResponse CreateWebApplication(CreateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWebApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a web application</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the CreateWebApplication operation to create a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWebApplicationResponse
        /// </returns>
        public async Task<CreateWebApplicationResponse> CreateWebApplicationAsync(CreateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWebApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom domain name for the web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a custom domain name for the web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWebCustomDomainResponse
        /// </returns>
        public CreateWebCustomDomainResponse CreateWebCustomDomainWithOptions(CreateWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWebCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom domain name for the web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a custom domain name for the web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateWebCustomDomainResponse
        /// </returns>
        public async Task<CreateWebCustomDomainResponse> CreateWebCustomDomainWithOptionsAsync(CreateWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateWebCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom domain name for the web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a custom domain name for the web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWebCustomDomainResponse
        /// </returns>
        public CreateWebCustomDomainResponse CreateWebCustomDomain(CreateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWebCustomDomainWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a custom domain name for the web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Create a custom domain name for the web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateWebCustomDomainResponse
        /// </returns>
        public async Task<CreateWebCustomDomainResponse> CreateWebCustomDomainAsync(CreateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWebCustomDomainWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deleteApplication",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deleteApplication",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationResponse
        /// </returns>
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationScalingRuleResponse
        /// </returns>
        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRuleWithOptions(DeleteApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationScalingRuleResponse
        /// </returns>
        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleWithOptionsAsync(DeleteApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationScalingRuleResponse
        /// </returns>
        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRule(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApplicationScalingRuleResponse
        /// </returns>
        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleAsync(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigMapResponse
        /// </returns>
        public DeleteConfigMapResponse DeleteConfigMapWithOptions(DeleteConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigMapResponse
        /// </returns>
        public async Task<DeleteConfigMapResponse> DeleteConfigMapWithOptionsAsync(DeleteConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigMapResponse
        /// </returns>
        public DeleteConfigMapResponse DeleteConfigMap(DeleteConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigMapWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteConfigMapResponse
        /// </returns>
        public async Task<DeleteConfigMapResponse> DeleteConfigMapAsync(DeleteConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGreyTagRouteResponse
        /// </returns>
        public DeleteGreyTagRouteResponse DeleteGreyTagRouteWithOptions(DeleteGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGreyTagRouteResponse
        /// </returns>
        public async Task<DeleteGreyTagRouteResponse> DeleteGreyTagRouteWithOptionsAsync(DeleteGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGreyTagRouteResponse
        /// </returns>
        public DeleteGreyTagRouteResponse DeleteGreyTagRoute(DeleteGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGreyTagRouteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteGreyTagRouteResponse
        /// </returns>
        public async Task<DeleteGreyTagRouteResponse> DeleteGreyTagRouteAsync(DeleteGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHistoryJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHistoryJobResponse
        /// </returns>
        public DeleteHistoryJobResponse DeleteHistoryJobWithOptions(DeleteHistoryJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHistoryJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteHistoryJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHistoryJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHistoryJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHistoryJobResponse
        /// </returns>
        public async Task<DeleteHistoryJobResponse> DeleteHistoryJobWithOptionsAsync(DeleteHistoryJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHistoryJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteHistoryJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHistoryJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHistoryJobResponse
        /// </returns>
        public DeleteHistoryJobResponse DeleteHistoryJob(DeleteHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHistoryJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHistoryJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHistoryJobResponse
        /// </returns>
        public async Task<DeleteHistoryJobResponse> DeleteHistoryJobAsync(DeleteHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHistoryJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIngressResponse
        /// </returns>
        public DeleteIngressResponse DeleteIngressWithOptions(DeleteIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIngressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteIngressResponse
        /// </returns>
        public async Task<DeleteIngressResponse> DeleteIngressWithOptionsAsync(DeleteIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIngressResponse
        /// </returns>
        public DeleteIngressResponse DeleteIngress(DeleteIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIngressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a routing rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteIngressResponse
        /// </returns>
        public async Task<DeleteIngressResponse> DeleteIngressAsync(DeleteIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIngressWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstancesResponse
        /// </returns>
        public DeleteInstancesResponse DeleteInstancesWithOptions(DeleteInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deleteInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstancesResponse
        /// </returns>
        public async Task<DeleteInstancesResponse> DeleteInstancesWithOptionsAsync(DeleteInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deleteInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstancesResponse
        /// </returns>
        public DeleteInstancesResponse DeleteInstances(DeleteInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteInstancesResponse
        /// </returns>
        public async Task<DeleteInstancesResponse> DeleteInstancesAsync(DeleteInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteJobResponse
        /// </returns>
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteNamespaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNamespaceResponse
        /// </returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
        public DeleteSecretResponse DeleteSecretWithOptions(DeleteSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
        public async Task<DeleteSecretResponse> DeleteSecretWithOptionsAsync(DeleteSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSecretWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSecretResponse
        /// </returns>
        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSecretWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSwimmingLaneGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSwimmingLaneGroupResponse
        /// </returns>
        public DeleteSwimmingLaneGroupResponse DeleteSwimmingLaneGroupWithOptions(DeleteSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSwimmingLaneGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/deleteSwimmingLaneGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSwimmingLaneGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSwimmingLaneGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSwimmingLaneGroupResponse
        /// </returns>
        public async Task<DeleteSwimmingLaneGroupResponse> DeleteSwimmingLaneGroupWithOptionsAsync(DeleteSwimmingLaneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSwimmingLaneGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/deleteSwimmingLaneGroup",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSwimmingLaneGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSwimmingLaneGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSwimmingLaneGroupResponse
        /// </returns>
        public DeleteSwimmingLaneGroupResponse DeleteSwimmingLaneGroup(DeleteSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSwimmingLaneGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSwimmingLaneGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSwimmingLaneGroupResponse
        /// </returns>
        public async Task<DeleteSwimmingLaneGroupResponse> DeleteSwimmingLaneGroupAsync(DeleteSwimmingLaneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSwimmingLaneGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DeleteWebApplication operation to delete a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationResponse
        /// </returns>
        public DeleteWebApplicationResponse DeleteWebApplicationWithOptions(string ApplicationId, DeleteWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DeleteWebApplication operation to delete a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationResponse
        /// </returns>
        public async Task<DeleteWebApplicationResponse> DeleteWebApplicationWithOptionsAsync(string ApplicationId, DeleteWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DeleteWebApplication operation to delete a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationResponse
        /// </returns>
        public DeleteWebApplicationResponse DeleteWebApplication(string ApplicationId, DeleteWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DeleteWebApplication operation to delete a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationResponse
        /// </returns>
        public async Task<DeleteWebApplicationResponse> DeleteWebApplicationAsync(string ApplicationId, DeleteWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRevisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationRevisionResponse
        /// </returns>
        public DeleteWebApplicationRevisionResponse DeleteWebApplicationRevisionWithOptions(string ApplicationId, string RevisionId, DeleteWebApplicationRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebApplicationRevision",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RevisionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebApplicationRevisionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRevisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationRevisionResponse
        /// </returns>
        public async Task<DeleteWebApplicationRevisionResponse> DeleteWebApplicationRevisionWithOptionsAsync(string ApplicationId, string RevisionId, DeleteWebApplicationRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebApplicationRevision",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RevisionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebApplicationRevisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRevisionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationRevisionResponse
        /// </returns>
        public DeleteWebApplicationRevisionResponse DeleteWebApplicationRevision(string ApplicationId, string RevisionId, DeleteWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWebApplicationRevisionWithOptions(ApplicationId, RevisionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebApplicationRevisionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebApplicationRevisionResponse
        /// </returns>
        public async Task<DeleteWebApplicationRevisionResponse> DeleteWebApplicationRevisionAsync(string ApplicationId, string RevisionId, DeleteWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWebApplicationRevisionWithOptionsAsync(ApplicationId, RevisionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebCustomDomainResponse
        /// </returns>
        public DeleteWebCustomDomainResponse DeleteWebCustomDomainWithOptions(string DomainName, DeleteWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebCustomDomainResponse
        /// </returns>
        public async Task<DeleteWebCustomDomainResponse> DeleteWebCustomDomainWithOptionsAsync(string DomainName, DeleteWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteWebCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebCustomDomainResponse
        /// </returns>
        public DeleteWebCustomDomainResponse DeleteWebCustomDomain(string DomainName, DeleteWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWebCustomDomainWithOptions(DomainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Delete a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteWebCustomDomainResponse
        /// </returns>
        public async Task<DeleteWebCustomDomainResponse> DeleteWebCustomDomainAsync(string DomainName, DeleteWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWebCustomDomainWithOptionsAsync(DomainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeployApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationResponse
        /// </returns>
        public DeployApplicationResponse DeployApplicationWithOptions(DeployApplicationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeployApplicationShrinkRequest request = new DeployApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InitContainersConfig))
            {
                request.InitContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InitContainersConfig, "InitContainersConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SidecarContainersConfig))
            {
                request.SidecarContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SidecarContainersConfig, "SidecarContainersConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomImageNetworkType))
            {
                query["CustomImageNetworkType"] = request.CustomImageNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dotnet))
            {
                query["Dotnet"] = request.Dotnet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCpuBurst))
            {
                query["EnableCpuBurst"] = request.EnableCpuBurst;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGreyTagRoute))
            {
                query["EnableGreyTagRoute"] = request.EnableGreyTagRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNewArms))
            {
                query["EnableNewArms"] = request.EnableNewArms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuConfig))
            {
                query["GpuConfig"] = request.GpuConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroserviceEngineConfig))
            {
                query["MicroserviceEngineConfig"] = request.MicroserviceEngineConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSaeVersion))
            {
                query["NewSaeVersion"] = request.NewSaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OidcRoleName))
            {
                query["OidcRoleName"] = request.OidcRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretMountDesc))
            {
                query["SecretMountDesc"] = request.SecretMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupProbe))
            {
                query["StartupProbe"] = request.StartupProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarResourceIsolated))
            {
                body["EnableSidecarResourceIsolated"] = request.EnableSidecarResourceIsolated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainersConfigShrink))
            {
                body["InitContainersConfig"] = request.InitContainersConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistrationConfig))
            {
                body["MicroRegistrationConfig"] = request.MicroRegistrationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTags))
            {
                body["ServiceTags"] = request.ServiceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarContainersConfigShrink))
            {
                body["SidecarContainersConfig"] = request.SidecarContainersConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimlanePvtzDiscoverySvc))
            {
                body["SwimlanePvtzDiscoverySvc"] = request.SwimlanePvtzDiscoverySvc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deployApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeployApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationResponse
        /// </returns>
        public async Task<DeployApplicationResponse> DeployApplicationWithOptionsAsync(DeployApplicationRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeployApplicationShrinkRequest request = new DeployApplicationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InitContainersConfig))
            {
                request.InitContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InitContainersConfig, "InitContainersConfig", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SidecarContainersConfig))
            {
                request.SidecarContainersConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SidecarContainersConfig, "SidecarContainersConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomImageNetworkType))
            {
                query["CustomImageNetworkType"] = request.CustomImageNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dotnet))
            {
                query["Dotnet"] = request.Dotnet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableCpuBurst))
            {
                query["EnableCpuBurst"] = request.EnableCpuBurst;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGreyTagRoute))
            {
                query["EnableGreyTagRoute"] = request.EnableGreyTagRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableNewArms))
            {
                query["EnableNewArms"] = request.EnableNewArms;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuConfig))
            {
                query["GpuConfig"] = request.GpuConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroserviceEngineConfig))
            {
                query["MicroserviceEngineConfig"] = request.MicroserviceEngineConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSaeVersion))
            {
                query["NewSaeVersion"] = request.NewSaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OidcRoleName))
            {
                query["OidcRoleName"] = request.OidcRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretMountDesc))
            {
                query["SecretMountDesc"] = request.SecretMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartupProbe))
            {
                query["StartupProbe"] = request.StartupProbe;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableSidecarResourceIsolated))
            {
                body["EnableSidecarResourceIsolated"] = request.EnableSidecarResourceIsolated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainersConfigShrink))
            {
                body["InitContainersConfig"] = request.InitContainersConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistrationConfig))
            {
                body["MicroRegistrationConfig"] = request.MicroRegistrationConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceTags))
            {
                body["ServiceTags"] = request.ServiceTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidecarContainersConfigShrink))
            {
                body["SidecarContainersConfig"] = request.SidecarContainersConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwimlanePvtzDiscoverySvc))
            {
                body["SwimlanePvtzDiscoverySvc"] = request.SwimlanePvtzDiscoverySvc;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deployApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationResponse
        /// </returns>
        public DeployApplicationResponse DeployApplication(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deploys an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeployApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DeployApplicationResponse
        /// </returns>
        public async Task<DeployApplicationResponse> DeployApplicationAsync(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata details of the service of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppServiceDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppServiceDetailResponse
        /// </returns>
        public DescribeAppServiceDetailResponse DescribeAppServiceDetailWithOptions(DescribeAppServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosInstanceId))
            {
                query["NacosInstanceId"] = request.NacosInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosNamespaceId))
            {
                query["NacosNamespaceId"] = request.NacosNamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppServiceDetail",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/describeAppServiceDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppServiceDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata details of the service of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppServiceDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppServiceDetailResponse
        /// </returns>
        public async Task<DescribeAppServiceDetailResponse> DescribeAppServiceDetailWithOptionsAsync(DescribeAppServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosInstanceId))
            {
                query["NacosInstanceId"] = request.NacosInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosNamespaceId))
            {
                query["NacosNamespaceId"] = request.NacosNamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppServiceDetail",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/describeAppServiceDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppServiceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata details of the service of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppServiceDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppServiceDetailResponse
        /// </returns>
        public DescribeAppServiceDetailResponse DescribeAppServiceDetail(DescribeAppServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppServiceDetailWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the metadata details of the service of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAppServiceDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppServiceDetailResponse
        /// </returns>
        public async Task<DescribeAppServiceDetailResponse> DescribeAppServiceDetailAsync(DescribeAppServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppServiceDetailWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationConfigResponse
        /// </returns>
        public DescribeApplicationConfigResponse DescribeApplicationConfigWithOptions(DescribeApplicationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationConfigResponse
        /// </returns>
        public async Task<DescribeApplicationConfigResponse> DescribeApplicationConfigWithOptionsAsync(DescribeApplicationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationConfigResponse
        /// </returns>
        public DescribeApplicationConfigResponse DescribeApplicationConfig(DescribeApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationConfigWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationConfigResponse
        /// </returns>
        public async Task<DescribeApplicationConfigResponse> DescribeApplicationConfigAsync(DescribeApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationConfigWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeApplicationGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupsResponse
        /// </returns>
        public DescribeApplicationGroupsResponse DescribeApplicationGroupsWithOptions(DescribeApplicationGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "DescribeApplicationGroups",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeApplicationGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupsResponse
        /// </returns>
        public async Task<DescribeApplicationGroupsResponse> DescribeApplicationGroupsWithOptionsAsync(DescribeApplicationGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "DescribeApplicationGroups",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeApplicationGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupsResponse
        /// </returns>
        public DescribeApplicationGroupsResponse DescribeApplicationGroups(DescribeApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationGroupsWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeApplicationGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationGroupsResponse
        /// </returns>
        public async Task<DescribeApplicationGroupsResponse> DescribeApplicationGroupsAsync(DescribeApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the image of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationImageResponse
        /// </returns>
        public DescribeApplicationImageResponse DescribeApplicationImageWithOptions(DescribeApplicationImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationImage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/container/describeApplicationImage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationImageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the image of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationImageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationImageResponse
        /// </returns>
        public async Task<DescribeApplicationImageResponse> DescribeApplicationImageWithOptionsAsync(DescribeApplicationImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationImage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/container/describeApplicationImage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the image of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationImageResponse
        /// </returns>
        public DescribeApplicationImageResponse DescribeApplicationImage(DescribeApplicationImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationImageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the image of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationImageRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationImageResponse
        /// </returns>
        public async Task<DescribeApplicationImageResponse> DescribeApplicationImageAsync(DescribeApplicationImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationImageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries application instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationInstancesResponse
        /// </returns>
        public DescribeApplicationInstancesResponse DescribeApplicationInstancesWithOptions(DescribeApplicationInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries application instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationInstancesResponse
        /// </returns>
        public async Task<DescribeApplicationInstancesResponse> DescribeApplicationInstancesWithOptionsAsync(DescribeApplicationInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries application instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationInstancesResponse
        /// </returns>
        public DescribeApplicationInstancesResponse DescribeApplicationInstances(DescribeApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries application instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationInstancesResponse
        /// </returns>
        public async Task<DescribeApplicationInstancesResponse> DescribeApplicationInstancesAsync(DescribeApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specified auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRuleResponse
        /// </returns>
        public DescribeApplicationScalingRuleResponse DescribeApplicationScalingRuleWithOptions(DescribeApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specified auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRuleResponse
        /// </returns>
        public async Task<DescribeApplicationScalingRuleResponse> DescribeApplicationScalingRuleWithOptionsAsync(DescribeApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specified auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRuleResponse
        /// </returns>
        public DescribeApplicationScalingRuleResponse DescribeApplicationScalingRule(DescribeApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a specified auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRuleResponse
        /// </returns>
        public async Task<DescribeApplicationScalingRuleResponse> DescribeApplicationScalingRuleAsync(DescribeApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling policies of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRulesResponse
        /// </returns>
        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRulesWithOptions(DescribeApplicationScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRules",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling policies of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRulesResponse
        /// </returns>
        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesWithOptionsAsync(DescribeApplicationScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRules",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling policies of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRulesResponse
        /// </returns>
        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRules(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the auto scaling policies of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationScalingRulesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationScalingRulesResponse
        /// </returns>
        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesAsync(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationSlbsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationSlbsResponse
        /// </returns>
        public DescribeApplicationSlbsResponse DescribeApplicationSlbsWithOptions(DescribeApplicationSlbsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationSlbs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationSlbsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationSlbsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationSlbsResponse
        /// </returns>
        public async Task<DescribeApplicationSlbsResponse> DescribeApplicationSlbsWithOptionsAsync(DescribeApplicationSlbsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationSlbs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationSlbsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationSlbsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationSlbsResponse
        /// </returns>
        public DescribeApplicationSlbsResponse DescribeApplicationSlbs(DescribeApplicationSlbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationSlbsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>017f39b8-dfa4-4e16-a84b-1dcee4b1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationSlbsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationSlbsResponse
        /// </returns>
        public async Task<DescribeApplicationSlbsResponse> DescribeApplicationSlbsAsync(DescribeApplicationSlbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationSlbsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationStatusResponse
        /// </returns>
        public DescribeApplicationStatusResponse DescribeApplicationStatusWithOptions(DescribeApplicationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationStatusResponse
        /// </returns>
        public async Task<DescribeApplicationStatusResponse> DescribeApplicationStatusWithOptionsAsync(DescribeApplicationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationStatusResponse
        /// </returns>
        public DescribeApplicationStatusResponse DescribeApplicationStatus(DescribeApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeApplicationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeApplicationStatusResponse
        /// </returns>
        public async Task<DescribeApplicationStatusResponse> DescribeApplicationStatusAsync(DescribeApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChangeOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChangeOrderResponse
        /// </returns>
        public DescribeChangeOrderResponse DescribeChangeOrderWithOptions(DescribeChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribeChangeOrder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChangeOrderRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeChangeOrderResponse
        /// </returns>
        public async Task<DescribeChangeOrderResponse> DescribeChangeOrderWithOptionsAsync(DescribeChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribeChangeOrder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChangeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChangeOrderResponse
        /// </returns>
        public DescribeChangeOrderResponse DescribeChangeOrder(DescribeChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChangeOrderWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information of a change order.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeChangeOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeChangeOrderResponse
        /// </returns>
        public async Task<DescribeChangeOrderResponse> DescribeChangeOrderAsync(DescribeChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version of the component that is required when you create and deploy an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsResponse
        /// </returns>
        public DescribeComponentsResponse DescribeComponentsWithOptions(DescribeComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
                Action = "DescribeComponents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version of the component that is required when you create and deploy an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsResponse
        /// </returns>
        public async Task<DescribeComponentsResponse> DescribeComponentsWithOptionsAsync(DescribeComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
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
                Action = "DescribeComponents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version of the component that is required when you create and deploy an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsResponse
        /// </returns>
        public DescribeComponentsResponse DescribeComponents(DescribeComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeComponentsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the version of the component that is required when you create and deploy an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeComponentsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeComponentsResponse
        /// </returns>
        public async Task<DescribeComponentsResponse> DescribeComponentsAsync(DescribeComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeComponentsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigMapResponse
        /// </returns>
        public DescribeConfigMapResponse DescribeConfigMapWithOptions(DescribeConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigMapResponse
        /// </returns>
        public async Task<DescribeConfigMapResponse> DescribeConfigMapWithOptionsAsync(DescribeConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigMapResponse
        /// </returns>
        public DescribeConfigMapResponse DescribeConfigMap(DescribeConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigMapWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigMapResponse
        /// </returns>
        public async Task<DescribeConfigMapResponse> DescribeConfigMapAsync(DescribeConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query configuration price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigurationPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigurationPriceResponse
        /// </returns>
        public DescribeConfigurationPriceResponse DescribeConfigurationPriceWithOptions(DescribeConfigurationPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSaeVersion))
            {
                query["NewSaeVersion"] = request.NewSaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigurationPrice",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/configurationPrice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigurationPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query configuration price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigurationPriceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigurationPriceResponse
        /// </returns>
        public async Task<DescribeConfigurationPriceResponse> DescribeConfigurationPriceWithOptionsAsync(DescribeConfigurationPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSaeVersion))
            {
                query["NewSaeVersion"] = request.NewSaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigurationPrice",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/configurationPrice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigurationPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query configuration price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigurationPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigurationPriceResponse
        /// </returns>
        public DescribeConfigurationPriceResponse DescribeConfigurationPrice(DescribeConfigurationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigurationPriceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query configuration price.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeConfigurationPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeConfigurationPriceResponse
        /// </returns>
        public async Task<DescribeConfigurationPriceResponse> DescribeConfigurationPriceAsync(DescribeConfigurationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigurationPriceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the container components of a microservices application.</para>
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
        /// DescribeEdasContainersResponse
        /// </returns>
        public DescribeEdasContainersResponse DescribeEdasContainersWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdasContainers",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/edasContainers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdasContainersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the container components of a microservices application.</para>
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
        /// DescribeEdasContainersResponse
        /// </returns>
        public async Task<DescribeEdasContainersResponse> DescribeEdasContainersWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdasContainers",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/edasContainers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdasContainersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the container components of a microservices application.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeEdasContainersResponse
        /// </returns>
        public DescribeEdasContainersResponse DescribeEdasContainers()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdasContainersWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the container components of a microservices application.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeEdasContainersResponse
        /// </returns>
        public async Task<DescribeEdasContainersResponse> DescribeEdasContainersAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdasContainersWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGreyTagRouteResponse
        /// </returns>
        public DescribeGreyTagRouteResponse DescribeGreyTagRouteWithOptions(DescribeGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeGreyTagRouteResponse
        /// </returns>
        public async Task<DescribeGreyTagRouteResponse> DescribeGreyTagRouteWithOptionsAsync(DescribeGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGreyTagRouteResponse
        /// </returns>
        public DescribeGreyTagRouteResponse DescribeGreyTagRoute(DescribeGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGreyTagRouteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on the specified rule ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeGreyTagRouteResponse
        /// </returns>
        public async Task<DescribeGreyTagRouteResponse> DescribeGreyTagRouteAsync(DescribeGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the DescribeIngress operation to query the details of an Ingress.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIngressResponse
        /// </returns>
        public DescribeIngressResponse DescribeIngressWithOptions(DescribeIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIngressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the DescribeIngress operation to query the details of an Ingress.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIngressResponse
        /// </returns>
        public async Task<DescribeIngressResponse> DescribeIngressWithOptionsAsync(DescribeIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the DescribeIngress operation to query the details of an Ingress.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIngressResponse
        /// </returns>
        public DescribeIngressResponse DescribeIngress(DescribeIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIngressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Call the DescribeIngress operation to query the details of an Ingress.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIngressResponse
        /// </returns>
        public async Task<DescribeIngressResponse> DescribeIngressAsync(DescribeIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIngressWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceLogResponse
        /// </returns>
        public DescribeInstanceLogResponse DescribeInstanceLogWithOptions(DescribeInstanceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerId))
            {
                query["ContainerId"] = request.ContainerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceLog",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/instance/describeInstanceLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceLogResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeInstanceLogRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceLogResponse
        /// </returns>
        public async Task<DescribeInstanceLogResponse> DescribeInstanceLogWithOptionsAsync(DescribeInstanceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerId))
            {
                query["ContainerId"] = request.ContainerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceLog",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/instance/describeInstanceLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeInstanceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceLogResponse
        /// </returns>
        public DescribeInstanceLogResponse DescribeInstanceLog(DescribeInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceLogWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeInstanceLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceLogResponse
        /// </returns>
        public async Task<DescribeInstanceLogResponse> DescribeInstanceLogAsync(DescribeInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceLogWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all instance types.</para>
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
        /// DescribeInstanceSpecificationsResponse
        /// </returns>
        public DescribeInstanceSpecificationsResponse DescribeInstanceSpecificationsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecifications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/instanceSpecifications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSpecificationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all instance types.</para>
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
        /// DescribeInstanceSpecificationsResponse
        /// </returns>
        public async Task<DescribeInstanceSpecificationsResponse> DescribeInstanceSpecificationsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecifications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/instanceSpecifications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSpecificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all instance types.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeInstanceSpecificationsResponse
        /// </returns>
        public DescribeInstanceSpecificationsResponse DescribeInstanceSpecifications()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceSpecificationsWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all instance types.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeInstanceSpecificationsResponse
        /// </returns>
        public async Task<DescribeInstanceSpecificationsResponse> DescribeInstanceSpecificationsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceSpecificationsWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public DescribeJobResponse DescribeJobWithOptions(DescribeJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public async Task<DescribeJobResponse> DescribeJobWithOptionsAsync(DescribeJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobResponse
        /// </returns>
        public async Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the information about jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobHistoryResponse
        /// </returns>
        public DescribeJobHistoryResponse DescribeJobHistoryWithOptions(DescribeJobHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobHistory",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobHistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobHistoryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the information about jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobHistoryRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobHistoryResponse
        /// </returns>
        public async Task<DescribeJobHistoryResponse> DescribeJobHistoryWithOptionsAsync(DescribeJobHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobHistory",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobHistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the information about jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobHistoryResponse
        /// </returns>
        public DescribeJobHistoryResponse DescribeJobHistory(DescribeJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobHistoryWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the information about jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobHistoryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobHistoryResponse
        /// </returns>
        public async Task<DescribeJobHistoryResponse> DescribeJobHistoryAsync(DescribeJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobHistoryWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobStatusResponse
        /// </returns>
        public DescribeJobStatusResponse DescribeJobStatusWithOptions(DescribeJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobStatusResponse
        /// </returns>
        public async Task<DescribeJobStatusResponse> DescribeJobStatusWithOptionsAsync(DescribeJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobStatusResponse
        /// </returns>
        public DescribeJobStatusResponse DescribeJobStatus(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeJobStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeJobStatusResponse
        /// </returns>
        public async Task<DescribeJobStatusResponse> DescribeJobStatusAsync(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobStatusWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResponse
        /// </returns>
        public DescribeNamespaceResponse DescribeNamespaceWithOptions(DescribeNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResponse
        /// </returns>
        public async Task<DescribeNamespaceResponse> DescribeNamespaceWithOptionsAsync(DescribeNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResponse
        /// </returns>
        public DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResponse
        /// </returns>
        public async Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceListResponse
        /// </returns>
        public DescribeNamespaceListResponse DescribeNamespaceListWithOptions(DescribeNamespaceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainCustom))
            {
                query["ContainCustom"] = request.ContainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridCloudExclude))
            {
                query["HybridCloudExclude"] = request.HybridCloudExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceList",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceListResponse
        /// </returns>
        public async Task<DescribeNamespaceListResponse> DescribeNamespaceListWithOptionsAsync(DescribeNamespaceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainCustom))
            {
                query["ContainCustom"] = request.ContainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridCloudExclude))
            {
                query["HybridCloudExclude"] = request.HybridCloudExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceList",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceListResponse
        /// </returns>
        public DescribeNamespaceListResponse DescribeNamespaceList(DescribeNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceListWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespaceListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceListResponse
        /// </returns>
        public async Task<DescribeNamespaceListResponse> DescribeNamespaceListAsync(DescribeNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceListWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeNamespaceResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResourcesResponse
        /// </returns>
        public DescribeNamespaceResourcesResponse DescribeNamespaceResourcesWithOptions(DescribeNamespaceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeNamespaceResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResourcesResponse
        /// </returns>
        public async Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResourcesWithOptionsAsync(DescribeNamespaceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DescribeNamespaceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResourcesResponse
        /// </returns>
        public DescribeNamespaceResourcesResponse DescribeNamespaceResources(DescribeNamespaceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceResourcesWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// DescribeNamespaceResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespaceResourcesResponse
        /// </returns>
        public async Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResourcesAsync(DescribeNamespaceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public DescribeNamespacesResponse DescribeNamespacesWithOptions(DescribeNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "DescribeNamespaces",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespacesWithOptionsAsync(DescribeNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "DescribeNamespaces",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public DescribeNamespacesResponse DescribeNamespaces(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespacesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of namespaces.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeNamespacesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeNamespacesResponse
        /// </returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespacesAsync(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespacesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View batch information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePipelineResponse
        /// </returns>
        public DescribePipelineResponse DescribePipelineWithOptions(DescribePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePipeline",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribePipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePipelineResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View batch information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePipelineRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePipelineResponse
        /// </returns>
        public async Task<DescribePipelineResponse> DescribePipelineWithOptionsAsync(DescribePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePipeline",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribePipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View batch information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePipelineResponse
        /// </returns>
        public DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePipelineWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>View batch information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePipelineRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePipelineResponse
        /// </returns>
        public async Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePipelineWithOptionsAsync(request, headers, runtime);
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
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/regionConfig",
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
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/regionConfig",
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
        /// <para>Queries the details of a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
        public DescribeSecretResponse DescribeSecretWithOptions(DescribeSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
        public async Task<DescribeSecretResponse> DescribeSecretWithOptionsAsync(DescribeSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSecretWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a Secret.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSecretResponse
        /// </returns>
        public async Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSecretWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSwimmingLaneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSwimmingLaneResponse
        /// </returns>
        public DescribeSwimmingLaneResponse DescribeSwimmingLaneWithOptions(DescribeSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSwimmingLane",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/describeSwimmingLane",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSwimmingLaneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSwimmingLaneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSwimmingLaneResponse
        /// </returns>
        public async Task<DescribeSwimmingLaneResponse> DescribeSwimmingLaneWithOptionsAsync(DescribeSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSwimmingLane",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/describeSwimmingLane",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSwimmingLaneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSwimmingLaneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSwimmingLaneResponse
        /// </returns>
        public DescribeSwimmingLaneResponse DescribeSwimmingLane(DescribeSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSwimmingLaneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeSwimmingLaneRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSwimmingLaneResponse
        /// </returns>
        public async Task<DescribeSwimmingLaneResponse> DescribeSwimmingLaneAsync(DescribeSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplication operation to query web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResponse
        /// </returns>
        public DescribeWebApplicationResponse DescribeWebApplicationWithOptions(string ApplicationId, DescribeWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplication operation to query web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResponse
        /// </returns>
        public async Task<DescribeWebApplicationResponse> DescribeWebApplicationWithOptionsAsync(string ApplicationId, DescribeWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplication operation to query web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResponse
        /// </returns>
        public DescribeWebApplicationResponse DescribeWebApplication(string ApplicationId, DescribeWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplication operation to query web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResponse
        /// </returns>
        public async Task<DescribeWebApplicationResponse> DescribeWebApplicationAsync(string ApplicationId, DescribeWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the resource usage of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the resource usage of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationResourceStaticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResourceStaticsResponse
        /// </returns>
        public DescribeWebApplicationResourceStaticsResponse DescribeWebApplicationResourceStaticsWithOptions(string ApplicationId, DescribeWebApplicationResourceStaticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationResourceStatics",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/resource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationResourceStaticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the resource usage of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the resource usage of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationResourceStaticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResourceStaticsResponse
        /// </returns>
        public async Task<DescribeWebApplicationResourceStaticsResponse> DescribeWebApplicationResourceStaticsWithOptionsAsync(string ApplicationId, DescribeWebApplicationResourceStaticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationResourceStatics",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/resource",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationResourceStaticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the resource usage of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the resource usage of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationResourceStaticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResourceStaticsResponse
        /// </returns>
        public DescribeWebApplicationResourceStaticsResponse DescribeWebApplicationResourceStatics(string ApplicationId, DescribeWebApplicationResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationResourceStaticsWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the resource usage of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the resource usage of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationResourceStaticsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationResourceStaticsResponse
        /// </returns>
        public async Task<DescribeWebApplicationResourceStaticsResponse> DescribeWebApplicationResourceStaticsAsync(string ApplicationId, DescribeWebApplicationResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationResourceStaticsWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Describe a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRevisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationRevisionResponse
        /// </returns>
        public DescribeWebApplicationRevisionResponse DescribeWebApplicationRevisionWithOptions(string ApplicationId, string RevisionId, DescribeWebApplicationRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationRevision",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RevisionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationRevisionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Describe a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRevisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationRevisionResponse
        /// </returns>
        public async Task<DescribeWebApplicationRevisionResponse> DescribeWebApplicationRevisionWithOptionsAsync(string ApplicationId, string RevisionId, DescribeWebApplicationRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationRevision",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(RevisionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationRevisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Describe a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRevisionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationRevisionResponse
        /// </returns>
        public DescribeWebApplicationRevisionResponse DescribeWebApplicationRevision(string ApplicationId, string RevisionId, DescribeWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationRevisionWithOptions(ApplicationId, RevisionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Describe a web application version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationRevisionRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationRevisionResponse
        /// </returns>
        public async Task<DescribeWebApplicationRevisionResponse> DescribeWebApplicationRevisionAsync(string ApplicationId, string RevisionId, DescribeWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationRevisionWithOptionsAsync(ApplicationId, RevisionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationScalingConfig operation to obtain the scaling configuration of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationScalingConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationScalingConfigResponse
        /// </returns>
        public DescribeWebApplicationScalingConfigResponse DescribeWebApplicationScalingConfigWithOptions(string ApplicationId, DescribeWebApplicationScalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationScalingConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-scaling/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationScalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationScalingConfig operation to obtain the scaling configuration of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationScalingConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationScalingConfigResponse
        /// </returns>
        public async Task<DescribeWebApplicationScalingConfigResponse> DescribeWebApplicationScalingConfigWithOptionsAsync(string ApplicationId, DescribeWebApplicationScalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationScalingConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-scaling/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationScalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationScalingConfig operation to obtain the scaling configuration of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationScalingConfigResponse
        /// </returns>
        public DescribeWebApplicationScalingConfigResponse DescribeWebApplicationScalingConfig(string ApplicationId, DescribeWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationScalingConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Describe the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationScalingConfig operation to obtain the scaling configuration of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationScalingConfigResponse
        /// </returns>
        public async Task<DescribeWebApplicationScalingConfigResponse> DescribeWebApplicationScalingConfigAsync(string ApplicationId, DescribeWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationScalingConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationTrafficConfig operation to query the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationTrafficConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationTrafficConfigResponse
        /// </returns>
        public DescribeWebApplicationTrafficConfigResponse DescribeWebApplicationTrafficConfigWithOptions(string ApplicationId, DescribeWebApplicationTrafficConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationTrafficConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-traffic/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationTrafficConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationTrafficConfig operation to query the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationTrafficConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationTrafficConfigResponse
        /// </returns>
        public async Task<DescribeWebApplicationTrafficConfigResponse> DescribeWebApplicationTrafficConfigWithOptionsAsync(string ApplicationId, DescribeWebApplicationTrafficConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebApplicationTrafficConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-traffic/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebApplicationTrafficConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationTrafficConfig operation to query the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationTrafficConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationTrafficConfigResponse
        /// </returns>
        public DescribeWebApplicationTrafficConfigResponse DescribeWebApplicationTrafficConfig(string ApplicationId, DescribeWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationTrafficConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the DescribeWebApplicationTrafficConfig operation to query the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebApplicationTrafficConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebApplicationTrafficConfigResponse
        /// </returns>
        public async Task<DescribeWebApplicationTrafficConfigResponse> DescribeWebApplicationTrafficConfigAsync(string ApplicationId, DescribeWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationTrafficConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebCustomDomainResponse
        /// </returns>
        public DescribeWebCustomDomainResponse DescribeWebCustomDomainWithOptions(string DomainName, DescribeWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebCustomDomainResponse
        /// </returns>
        public async Task<DescribeWebCustomDomainResponse> DescribeWebCustomDomainWithOptionsAsync(string DomainName, DescribeWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebCustomDomainResponse
        /// </returns>
        public DescribeWebCustomDomainResponse DescribeWebCustomDomain(string DomainName, DescribeWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebCustomDomainWithOptions(DomainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the details of a custom domain name for a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebCustomDomainResponse
        /// </returns>
        public async Task<DescribeWebCustomDomainResponse> DescribeWebCustomDomainAsync(string DomainName, DescribeWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebCustomDomainWithOptionsAsync(DomainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the logs of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the logs of web application instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebInstanceLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebInstanceLogsResponse
        /// </returns>
        public DescribeWebInstanceLogsResponse DescribeWebInstanceLogsWithOptions(string ApplicationId, string InstanceId, DescribeWebInstanceLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebInstanceLogs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebInstanceLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the logs of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the logs of web application instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebInstanceLogsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebInstanceLogsResponse
        /// </returns>
        public async Task<DescribeWebInstanceLogsResponse> DescribeWebInstanceLogsWithOptionsAsync(string ApplicationId, string InstanceId, DescribeWebInstanceLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWebInstanceLogs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(InstanceId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWebInstanceLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the logs of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the logs of web application instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebInstanceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebInstanceLogsResponse
        /// </returns>
        public DescribeWebInstanceLogsResponse DescribeWebInstanceLogs(string ApplicationId, string InstanceId, DescribeWebInstanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebInstanceLogsWithOptions(ApplicationId, InstanceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtain the logs of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Obtain the logs of web application instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWebInstanceLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWebInstanceLogsResponse
        /// </returns>
        public async Task<DescribeWebInstanceLogsResponse> DescribeWebInstanceLogsAsync(string ApplicationId, string InstanceId, DescribeWebInstanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebInstanceLogsWithOptionsAsync(ApplicationId, InstanceId, request, headers, runtime);
        }

        /// <param name="request">
        /// DisableApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableApplicationScalingRuleResponse
        /// </returns>
        public DisableApplicationScalingRuleResponse DisableApplicationScalingRuleWithOptions(DisableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/disableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// DisableApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableApplicationScalingRuleResponse
        /// </returns>
        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleWithOptionsAsync(DisableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/disableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// DisableApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableApplicationScalingRuleResponse
        /// </returns>
        public DisableApplicationScalingRuleResponse DisableApplicationScalingRule(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// DisableApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableApplicationScalingRuleResponse
        /// </returns>
        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleAsync(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradeApplicationApmServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradeApplicationApmServiceResponse
        /// </returns>
        public DowngradeApplicationApmServiceResponse DowngradeApplicationApmServiceWithOptions(DowngradeApplicationApmServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeApplicationApmService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/applicationApmService",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeApplicationApmServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradeApplicationApmServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DowngradeApplicationApmServiceResponse
        /// </returns>
        public async Task<DowngradeApplicationApmServiceResponse> DowngradeApplicationApmServiceWithOptionsAsync(DowngradeApplicationApmServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DowngradeApplicationApmService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/applicationApmService",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DowngradeApplicationApmServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradeApplicationApmServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradeApplicationApmServiceResponse
        /// </returns>
        public DowngradeApplicationApmServiceResponse DowngradeApplicationApmService(DowngradeApplicationApmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DowngradeApplicationApmServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DowngradeApplicationApmServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DowngradeApplicationApmServiceResponse
        /// </returns>
        public async Task<DowngradeApplicationApmServiceResponse> DowngradeApplicationApmServiceAsync(DowngradeApplicationApmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DowngradeApplicationApmServiceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an auto scaling policy for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableApplicationScalingRuleResponse
        /// </returns>
        public EnableApplicationScalingRuleResponse EnableApplicationScalingRuleWithOptions(EnableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/enableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an auto scaling policy for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableApplicationScalingRuleResponse
        /// </returns>
        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleWithOptionsAsync(EnableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/enableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an auto scaling policy for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableApplicationScalingRuleResponse
        /// </returns>
        public EnableApplicationScalingRuleResponse EnableApplicationScalingRule(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an auto scaling policy for an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// EnableApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableApplicationScalingRuleResponse
        /// </returns>
        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleAsync(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// ExecJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecJobResponse
        /// </returns>
        public ExecJobResponse ExecJobWithOptions(ExecJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/execJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecJobResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ExecJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecJobResponse
        /// </returns>
        public async Task<ExecJobResponse> ExecJobWithOptionsAsync(ExecJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/execJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ExecJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecJobResponse
        /// </returns>
        public ExecJobResponse ExecJob(ExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecJobWithOptions(request, headers, runtime);
        }

        /// <param name="request">
        /// ExecJobRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecJobResponse
        /// </returns>
        public async Task<ExecJobResponse> ExecJobAsync(ExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public GetApplicationResponse GetApplicationWithOptions(GetApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/getApplication",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public async Task<GetApplicationResponse> GetApplicationWithOptionsAsync(GetApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/getApplication",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetApplicationResponse
        /// </returns>
        public async Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArmsTopNMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArmsTopNMetricResponse
        /// </returns>
        public GetArmsTopNMetricResponse GetArmsTopNMetricWithOptions(GetArmsTopNMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArmsTopNMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getArmsTopNMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArmsTopNMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArmsTopNMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetArmsTopNMetricResponse
        /// </returns>
        public async Task<GetArmsTopNMetricResponse> GetArmsTopNMetricWithOptionsAsync(GetArmsTopNMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArmsTopNMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getArmsTopNMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArmsTopNMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArmsTopNMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArmsTopNMetricResponse
        /// </returns>
        public GetArmsTopNMetricResponse GetArmsTopNMetric(GetArmsTopNMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetArmsTopNMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The application name.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetArmsTopNMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetArmsTopNMetricResponse
        /// </returns>
        public async Task<GetArmsTopNMetricResponse> GetArmsTopNMetricAsync(GetArmsTopNMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetArmsTopNMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAvailabilityMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAvailabilityMetricResponse
        /// </returns>
        public GetAvailabilityMetricResponse GetAvailabilityMetricWithOptions(GetAvailabilityMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailabilityMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getAvailabilityMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailabilityMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAvailabilityMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAvailabilityMetricResponse
        /// </returns>
        public async Task<GetAvailabilityMetricResponse> GetAvailabilityMetricWithOptionsAsync(GetAvailabilityMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailabilityMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getAvailabilityMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailabilityMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAvailabilityMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAvailabilityMetricResponse
        /// </returns>
        public GetAvailabilityMetricResponse GetAvailabilityMetric(GetAvailabilityMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAvailabilityMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAvailabilityMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAvailabilityMetricResponse
        /// </returns>
        public async Task<GetAvailabilityMetricResponse> GetAvailabilityMetricAsync(GetAvailabilityMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAvailabilityMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries top N applications in abnormal change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeOrderMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChangeOrderMetricResponse
        /// </returns>
        public GetChangeOrderMetricResponse GetChangeOrderMetricWithOptions(GetChangeOrderMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeOrderMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getChangeOrderMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeOrderMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries top N applications in abnormal change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeOrderMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChangeOrderMetricResponse
        /// </returns>
        public async Task<GetChangeOrderMetricResponse> GetChangeOrderMetricWithOptionsAsync(GetChangeOrderMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeOrderMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getChangeOrderMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeOrderMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries top N applications in abnormal change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeOrderMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChangeOrderMetricResponse
        /// </returns>
        public GetChangeOrderMetricResponse GetChangeOrderMetric(GetChangeOrderMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChangeOrderMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries top N applications in abnormal change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChangeOrderMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChangeOrderMetricResponse
        /// </returns>
        public async Task<GetChangeOrderMetricResponse> GetChangeOrderMetricAsync(GetChangeOrderMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChangeOrderMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which auto scaling takes effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScaleAppMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScaleAppMetricResponse
        /// </returns>
        public GetScaleAppMetricResponse GetScaleAppMetricWithOptions(GetScaleAppMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScaleAppMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getScaleAppMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScaleAppMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which auto scaling takes effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScaleAppMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScaleAppMetricResponse
        /// </returns>
        public async Task<GetScaleAppMetricResponse> GetScaleAppMetricWithOptionsAsync(GetScaleAppMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScaleAppMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getScaleAppMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScaleAppMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which auto scaling takes effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScaleAppMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScaleAppMetricResponse
        /// </returns>
        public GetScaleAppMetricResponse GetScaleAppMetric(GetScaleAppMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScaleAppMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the top N applications in which auto scaling takes effect.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScaleAppMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScaleAppMetricResponse
        /// </returns>
        public async Task<GetScaleAppMetricResponse> GetScaleAppMetricAsync(GetScaleAppMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScaleAppMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The number of Warning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningEventMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWarningEventMetricResponse
        /// </returns>
        public GetWarningEventMetricResponse GetWarningEventMetricWithOptions(GetWarningEventMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarningEventMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getWarningEventMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarningEventMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The number of Warning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningEventMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWarningEventMetricResponse
        /// </returns>
        public async Task<GetWarningEventMetricResponse> GetWarningEventMetricWithOptionsAsync(GetWarningEventMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuStrategy))
            {
                query["CpuStrategy"] = request.CpuStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarningEventMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getWarningEventMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarningEventMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The number of Warning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningEventMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWarningEventMetricResponse
        /// </returns>
        public GetWarningEventMetricResponse GetWarningEventMetric(GetWarningEventMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWarningEventMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The number of Warning events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWarningEventMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWarningEventMetricResponse
        /// </returns>
        public async Task<GetWarningEventMetricResponse> GetWarningEventMetricAsync(GetWarningEventMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWarningEventMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used to remotely log on to the Webshell of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebshellTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebshellTokenResponse
        /// </returns>
        public GetWebshellTokenResponse GetWebshellTokenWithOptions(GetWebshellTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodName))
            {
                query["PodName"] = request.PodName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebshellToken",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/instance/webshellToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebshellTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used to remotely log on to the Webshell of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebshellTokenRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetWebshellTokenResponse
        /// </returns>
        public async Task<GetWebshellTokenResponse> GetWebshellTokenWithOptionsAsync(GetWebshellTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodName))
            {
                query["PodName"] = request.PodName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWebshellToken",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/instance/webshellToken",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWebshellTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used to remotely log on to the Webshell of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebshellTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebshellTokenResponse
        /// </returns>
        public GetWebshellTokenResponse GetWebshellToken(GetWebshellTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWebshellTokenWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the token used to remotely log on to the Webshell of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetWebshellTokenRequest
        /// </param>
        /// 
        /// <returns>
        /// GetWebshellTokenResponse
        /// </returns>
        public async Task<GetWebshellTokenResponse> GetWebshellTokenAsync(GetWebshellTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWebshellTokenWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLaneGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLaneGroupsResponse
        /// </returns>
        public ListAllSwimmingLaneGroupsResponse ListAllSwimmingLaneGroupsWithOptions(ListAllSwimmingLaneGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllSwimmingLaneGroups",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLaneGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllSwimmingLaneGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLaneGroupsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLaneGroupsResponse
        /// </returns>
        public async Task<ListAllSwimmingLaneGroupsResponse> ListAllSwimmingLaneGroupsWithOptionsAsync(ListAllSwimmingLaneGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllSwimmingLaneGroups",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLaneGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllSwimmingLaneGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLaneGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLaneGroupsResponse
        /// </returns>
        public ListAllSwimmingLaneGroupsResponse ListAllSwimmingLaneGroups(ListAllSwimmingLaneGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAllSwimmingLaneGroupsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLaneGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLaneGroupsResponse
        /// </returns>
        public async Task<ListAllSwimmingLaneGroupsResponse> ListAllSwimmingLaneGroupsAsync(ListAllSwimmingLaneGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAllSwimmingLaneGroupsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLanesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLanesResponse
        /// </returns>
        public ListAllSwimmingLanesResponse ListAllSwimmingLanesWithOptions(ListAllSwimmingLanesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllSwimmingLanes",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLanes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllSwimmingLanesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLanesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLanesResponse
        /// </returns>
        public async Task<ListAllSwimmingLanesResponse> ListAllSwimmingLanesWithOptionsAsync(ListAllSwimmingLanesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAllSwimmingLanes",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLanes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAllSwimmingLanesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLanesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLanesResponse
        /// </returns>
        public ListAllSwimmingLanesResponse ListAllSwimmingLanes(ListAllSwimmingLanesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAllSwimmingLanesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAllSwimmingLanesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAllSwimmingLanesResponse
        /// </returns>
        public async Task<ListAllSwimmingLanesResponse> ListAllSwimmingLanesAsync(ListAllSwimmingLanesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAllSwimmingLanesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events that occurred in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppEventsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppEventsResponse
        /// </returns>
        public ListAppEventsResponse ListAppEventsWithOptions(ListAppEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKind))
            {
                query["ObjectKind"] = request.ObjectKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppEvents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppEvents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events that occurred in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppEventsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppEventsResponse
        /// </returns>
        public async Task<ListAppEventsResponse> ListAppEventsWithOptionsAsync(ListAppEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKind))
            {
                query["ObjectKind"] = request.ObjectKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppEvents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppEvents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events that occurred in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppEventsResponse
        /// </returns>
        public ListAppEventsResponse ListAppEvents(ListAppEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppEventsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the events that occurred in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppEventsResponse
        /// </returns>
        public async Task<ListAppEventsResponse> ListAppEventsAsync(ListAppEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppEventsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of microservices</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesResponse
        /// </returns>
        public ListAppServicesResponse ListAppServicesWithOptions(ListAppServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosInstanceId))
            {
                query["NacosInstanceId"] = request.NacosInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosNamespaceId))
            {
                query["NacosNamespaceId"] = request.NacosNamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["RegistryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
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
                Action = "ListAppServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listAppServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of microservices</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesResponse
        /// </returns>
        public async Task<ListAppServicesResponse> ListAppServicesWithOptionsAsync(ListAppServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosInstanceId))
            {
                query["NacosInstanceId"] = request.NacosInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NacosNamespaceId))
            {
                query["NacosNamespaceId"] = request.NacosNamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegistryType))
            {
                query["RegistryType"] = request.RegistryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
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
                Action = "ListAppServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listAppServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of microservices</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesResponse
        /// </returns>
        public ListAppServicesResponse ListAppServices(ListAppServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppServicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of microservices</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesResponse
        /// </returns>
        public async Task<ListAppServicesResponse> ListAppServicesAsync(ListAppServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppServicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the services of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesPageResponse
        /// </returns>
        public ListAppServicesPageResponse ListAppServicesPageWithOptions(ListAppServicesPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppServicesPage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listAppServicesPage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppServicesPageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the services of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesPageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesPageResponse
        /// </returns>
        public async Task<ListAppServicesPageResponse> ListAppServicesPageWithOptionsAsync(ListAppServicesPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppServicesPage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listAppServicesPage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppServicesPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the services of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesPageResponse
        /// </returns>
        public ListAppServicesPageResponse ListAppServicesPage(ListAppServicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppServicesPageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the services of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppServicesPageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppServicesPageResponse
        /// </returns>
        public async Task<ListAppServicesPageResponse> ListAppServicesPageAsync(ListAppServicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppServicesPageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployment versions of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppVersionsResponse
        /// </returns>
        public ListAppVersionsResponse ListAppVersionsWithOptions(ListAppVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppVersions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployment versions of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAppVersionsResponse
        /// </returns>
        public async Task<ListAppVersionsResponse> ListAppVersionsWithOptionsAsync(ListAppVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppVersions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployment versions of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppVersionsResponse
        /// </returns>
        public ListAppVersionsResponse ListAppVersions(ListAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppVersionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the deployment versions of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAppVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAppVersionsResponse
        /// </returns>
        public async Task<ListAppVersionsResponse> ListAppVersionsAsync(ListAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppVersionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listApplications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listApplications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApplicationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of applications.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsResponse
        /// </returns>
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用列表，供全链路灰度拉取应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForSwimmingLaneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForSwimmingLaneResponse
        /// </returns>
        public ListApplicationsForSwimmingLaneResponse ListApplicationsForSwimmingLaneWithOptions(ListApplicationsForSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationsForSwimmingLane",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listApplicationsForSwimmingLane",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForSwimmingLaneResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用列表，供全链路灰度拉取应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForSwimmingLaneRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForSwimmingLaneResponse
        /// </returns>
        public async Task<ListApplicationsForSwimmingLaneResponse> ListApplicationsForSwimmingLaneWithOptionsAsync(ListApplicationsForSwimmingLaneRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationsForSwimmingLane",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listApplicationsForSwimmingLane",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsForSwimmingLaneResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用列表，供全链路灰度拉取应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForSwimmingLaneRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForSwimmingLaneResponse
        /// </returns>
        public ListApplicationsForSwimmingLaneResponse ListApplicationsForSwimmingLane(ListApplicationsForSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApplicationsForSwimmingLaneWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取应用列表，供全链路灰度拉取应用列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListApplicationsForSwimmingLaneRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApplicationsForSwimmingLaneResponse
        /// </returns>
        public async Task<ListApplicationsForSwimmingLaneResponse> ListApplicationsForSwimmingLaneAsync(ListApplicationsForSwimmingLaneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApplicationsForSwimmingLaneWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a list of change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChangeOrdersResponse
        /// </returns>
        public ListChangeOrdersResponse ListChangeOrdersWithOptions(ListChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ListChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChangeOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a list of change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChangeOrdersResponse
        /// </returns>
        public async Task<ListChangeOrdersResponse> ListChangeOrdersWithOptionsAsync(ListChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ListChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChangeOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a list of change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChangeOrdersResponse
        /// </returns>
        public ListChangeOrdersResponse ListChangeOrders(ListChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChangeOrdersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query a list of change orders.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChangeOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChangeOrdersResponse
        /// </returns>
        public async Task<ListChangeOrdersResponse> ListChangeOrdersAsync(ListChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChangeOrdersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are subscribed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumedServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConsumedServicesResponse
        /// </returns>
        public ListConsumedServicesResponse ListConsumedServicesWithOptions(ListConsumedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listConsumedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumedServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are subscribed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumedServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListConsumedServicesResponse
        /// </returns>
        public async Task<ListConsumedServicesResponse> ListConsumedServicesWithOptionsAsync(ListConsumedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listConsumedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are subscribed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumedServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConsumedServicesResponse
        /// </returns>
        public ListConsumedServicesResponse ListConsumedServices(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumedServicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are subscribed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListConsumedServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListConsumedServicesResponse
        /// </returns>
        public async Task<ListConsumedServicesResponse> ListConsumedServicesAsync(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumedServicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on an application ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGreyTagRouteResponse
        /// </returns>
        public ListGreyTagRouteResponse ListGreyTagRouteWithOptions(ListGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRouteList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on an application ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGreyTagRouteResponse
        /// </returns>
        public async Task<ListGreyTagRouteResponse> ListGreyTagRouteWithOptionsAsync(ListGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRouteList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on an application ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGreyTagRouteResponse
        /// </returns>
        public ListGreyTagRouteResponse ListGreyTagRoute(ListGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGreyTagRouteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a canary release rule based on an application ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para> You can configure only one canary release rule for each application.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ListGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGreyTagRouteResponse
        /// </returns>
        public async Task<ListGreyTagRouteResponse> ListGreyTagRouteAsync(ListGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use ListIngress API call to query Ingress list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIngressesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIngressesResponse
        /// </returns>
        public ListIngressesResponse ListIngressesWithOptions(ListIngressesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIngresses",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/IngressList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIngressesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use ListIngress API call to query Ingress list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIngressesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListIngressesResponse
        /// </returns>
        public async Task<ListIngressesResponse> ListIngressesWithOptionsAsync(ListIngressesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIngresses",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/IngressList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIngressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use ListIngress API call to query Ingress list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIngressesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIngressesResponse
        /// </returns>
        public ListIngressesResponse ListIngresses(ListIngressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIngressesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Use ListIngress API call to query Ingress list</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListIngressesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListIngressesResponse
        /// </returns>
        public async Task<ListIngressesResponse> ListIngressesAsync(ListIngressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIngressesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about job templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/listJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about job templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/listJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about job templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about job templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogConfigsResponse
        /// </returns>
        public ListLogConfigsResponse ListLogConfigsWithOptions(ListLogConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "ListLogConfigs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/log/listLogConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogConfigsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogConfigsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLogConfigsResponse
        /// </returns>
        public async Task<ListLogConfigsResponse> ListLogConfigsWithOptionsAsync(ListLogConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
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
                Action = "ListLogConfigs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/log/listLogConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogConfigsResponse
        /// </returns>
        public ListLogConfigsResponse ListLogConfigs(ListLogConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogConfigsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of application logs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListLogConfigsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLogConfigsResponse
        /// </returns>
        public async Task<ListLogConfigsResponse> ListLogConfigsAsync(ListLogConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogConfigsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of change orders in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceChangeOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceChangeOrdersResponse
        /// </returns>
        public ListNamespaceChangeOrdersResponse ListNamespaceChangeOrdersWithOptions(ListNamespaceChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
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
                Action = "ListNamespaceChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/listNamespaceChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespaceChangeOrdersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of change orders in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceChangeOrdersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceChangeOrdersResponse
        /// </returns>
        public async Task<ListNamespaceChangeOrdersResponse> ListNamespaceChangeOrdersWithOptionsAsync(ListNamespaceChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
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
                Action = "ListNamespaceChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/listNamespaceChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespaceChangeOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of change orders in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceChangeOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceChangeOrdersResponse
        /// </returns>
        public ListNamespaceChangeOrdersResponse ListNamespaceChangeOrders(ListNamespaceChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespaceChangeOrdersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of change orders in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespaceChangeOrdersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespaceChangeOrdersResponse
        /// </returns>
        public async Task<ListNamespaceChangeOrdersResponse> ListNamespaceChangeOrdersAsync(ListNamespaceChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespaceChangeOrdersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ConfigMap instances in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacedConfigMapsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacedConfigMapsResponse
        /// </returns>
        public ListNamespacedConfigMapsResponse ListNamespacedConfigMapsWithOptions(ListNamespacedConfigMapsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespacedConfigMaps",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/listNamespacedConfigMaps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacedConfigMapsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ConfigMap instances in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacedConfigMapsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacedConfigMapsResponse
        /// </returns>
        public async Task<ListNamespacedConfigMapsResponse> ListNamespacedConfigMapsWithOptionsAsync(ListNamespacedConfigMapsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespacedConfigMaps",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/listNamespacedConfigMaps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacedConfigMapsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ConfigMap instances in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacedConfigMapsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacedConfigMapsResponse
        /// </returns>
        public ListNamespacedConfigMapsResponse ListNamespacedConfigMaps(ListNamespacedConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespacedConfigMapsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the ConfigMap instances in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNamespacedConfigMapsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNamespacedConfigMapsResponse
        /// </returns>
        public async Task<ListNamespacedConfigMapsResponse> ListNamespacedConfigMapsAsync(ListNamespacedConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespacedConfigMapsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are published.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedServicesResponse
        /// </returns>
        public ListPublishedServicesResponse ListPublishedServicesWithOptions(ListPublishedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listPublishedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedServicesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are published.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedServicesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedServicesResponse
        /// </returns>
        public async Task<ListPublishedServicesResponse> ListPublishedServicesWithOptionsAsync(ListPublishedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listPublishedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are published.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedServicesResponse
        /// </returns>
        public ListPublishedServicesResponse ListPublishedServices(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPublishedServicesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of microservices that are published.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListPublishedServicesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListPublishedServicesResponse
        /// </returns>
        public async Task<ListPublishedServicesResponse> ListPublishedServicesAsync(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPublishedServicesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Secrets in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
        public ListSecretsResponse ListSecretsWithOptions(ListSecretsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecrets",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secrets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Secrets in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
        public async Task<ListSecretsResponse> ListSecretsWithOptionsAsync(ListSecretsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecrets",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secrets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Secrets in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
        public ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSecretsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about Secrets in a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSecretsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSecretsResponse
        /// </returns>
        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSecretsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道可选的网关路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGatewayRoutesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGatewayRoutesResponse
        /// </returns>
        public ListSwimmingLaneGatewayRoutesResponse ListSwimmingLaneGatewayRoutesWithOptions(ListSwimmingLaneGatewayRoutesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayUniqueId))
            {
                query["GatewayUniqueId"] = request.GatewayUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSwimmingLaneGatewayRoutes",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLaneGatewayRoutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSwimmingLaneGatewayRoutesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道可选的网关路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGatewayRoutesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGatewayRoutesResponse
        /// </returns>
        public async Task<ListSwimmingLaneGatewayRoutesResponse> ListSwimmingLaneGatewayRoutesWithOptionsAsync(ListSwimmingLaneGatewayRoutesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayUniqueId))
            {
                query["GatewayUniqueId"] = request.GatewayUniqueId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSwimmingLaneGatewayRoutes",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLaneGatewayRoutes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSwimmingLaneGatewayRoutesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道可选的网关路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGatewayRoutesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGatewayRoutesResponse
        /// </returns>
        public ListSwimmingLaneGatewayRoutesResponse ListSwimmingLaneGatewayRoutes(ListSwimmingLaneGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSwimmingLaneGatewayRoutesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询泳道可选的网关路由</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGatewayRoutesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGatewayRoutesResponse
        /// </returns>
        public async Task<ListSwimmingLaneGatewayRoutesResponse> ListSwimmingLaneGatewayRoutesAsync(ListSwimmingLaneGatewayRoutesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSwimmingLaneGatewayRoutesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGroupTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGroupTagsResponse
        /// </returns>
        public ListSwimmingLaneGroupTagsResponse ListSwimmingLaneGroupTagsWithOptions(ListSwimmingLaneGroupTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSwimmingLaneGroupTags",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLaneGroupTags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSwimmingLaneGroupTagsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGroupTagsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGroupTagsResponse
        /// </returns>
        public async Task<ListSwimmingLaneGroupTagsResponse> ListSwimmingLaneGroupTagsWithOptionsAsync(ListSwimmingLaneGroupTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSwimmingLaneGroupTags",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/listSwimmingLaneGroupTags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSwimmingLaneGroupTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGroupTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGroupTagsResponse
        /// </returns>
        public ListSwimmingLaneGroupTagsResponse ListSwimmingLaneGroupTags(ListSwimmingLaneGroupTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSwimmingLaneGroupTagsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询所有泳道标签列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSwimmingLaneGroupTagsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSwimmingLaneGroupTagsResponse
        /// </returns>
        public async Task<ListSwimmingLaneGroupTagsResponse> ListSwimmingLaneGroupTagsAsync(ListSwimmingLaneGroupTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSwimmingLaneGroupTagsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mapping relationships between applications and tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mapping relationships between applications and tags.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mapping relationships between applications and tags.</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the mapping relationships between applications and tags.</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application instances.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListWebApplicationInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationInstancesResponse
        /// </returns>
        public ListWebApplicationInstancesResponse ListWebApplicationInstancesWithOptions(string ApplicationId, ListWebApplicationInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWebApplicationInstancesShrinkRequest request = new ListWebApplicationInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Statuses))
            {
                request.StatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Statuses, "Statuses", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VersionIds))
            {
                request.VersionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VersionIds, "VersionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusesShrink))
            {
                query["Statuses"] = request.StatusesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionIdsShrink))
            {
                query["VersionIds"] = request.VersionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebApplicationInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebApplicationInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application instances.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ListWebApplicationInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationInstancesResponse
        /// </returns>
        public async Task<ListWebApplicationInstancesResponse> ListWebApplicationInstancesWithOptionsAsync(string ApplicationId, ListWebApplicationInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListWebApplicationInstancesShrinkRequest request = new ListWebApplicationInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Statuses))
            {
                request.StatusesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Statuses, "Statuses", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VersionIds))
            {
                request.VersionIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VersionIds, "VersionIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusesShrink))
            {
                query["Statuses"] = request.StatusesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionIdsShrink))
            {
                query["VersionIds"] = request.VersionIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebApplicationInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications-observability/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebApplicationInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationInstancesResponse
        /// </returns>
        public ListWebApplicationInstancesResponse ListWebApplicationInstances(string ApplicationId, ListWebApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebApplicationInstancesWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application instances.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationInstancesResponse
        /// </returns>
        public async Task<ListWebApplicationInstancesResponse> ListWebApplicationInstancesAsync(string ApplicationId, ListWebApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebApplicationInstancesWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationRevisionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationRevisionsResponse
        /// </returns>
        public ListWebApplicationRevisionsResponse ListWebApplicationRevisionsWithOptions(string ApplicationId, ListWebApplicationRevisionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebApplicationRevisions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebApplicationRevisionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationRevisionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationRevisionsResponse
        /// </returns>
        public async Task<ListWebApplicationRevisionsResponse> ListWebApplicationRevisionsWithOptionsAsync(string ApplicationId, ListWebApplicationRevisionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebApplicationRevisions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebApplicationRevisionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationRevisionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationRevisionsResponse
        /// </returns>
        public ListWebApplicationRevisionsResponse ListWebApplicationRevisions(string ApplicationId, ListWebApplicationRevisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebApplicationRevisionsWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web application versions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query the list of web application versions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationRevisionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationRevisionsResponse
        /// </returns>
        public async Task<ListWebApplicationRevisionsResponse> ListWebApplicationRevisionsAsync(string ApplicationId, ListWebApplicationRevisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebApplicationRevisionsWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ListWebApplications operation to query the list of web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationsResponse
        /// </returns>
        public ListWebApplicationsResponse ListWebApplicationsWithOptions(ListWebApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ListWebApplications operation to query the list of web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationsResponse
        /// </returns>
        public async Task<ListWebApplicationsResponse> ListWebApplicationsWithOptionsAsync(ListWebApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ListWebApplications operation to query the list of web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationsResponse
        /// </returns>
        public ListWebApplicationsResponse ListWebApplications(ListWebApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebApplicationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the list of web applications.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the ListWebApplications operation to query the list of web applications.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebApplicationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebApplicationsResponse
        /// </returns>
        public async Task<ListWebApplicationsResponse> ListWebApplicationsAsync(ListWebApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available custom domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query available custom domain names.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebCustomDomainsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebCustomDomainsResponse
        /// </returns>
        public ListWebCustomDomainsResponse ListWebCustomDomainsWithOptions(ListWebCustomDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebCustomDomains",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebCustomDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available custom domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query available custom domain names.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebCustomDomainsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListWebCustomDomainsResponse
        /// </returns>
        public async Task<ListWebCustomDomainsResponse> ListWebCustomDomainsWithOptionsAsync(ListWebCustomDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationId))
            {
                query["ApplicationId"] = request.ApplicationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListWebCustomDomains",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListWebCustomDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available custom domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query available custom domain names.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebCustomDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebCustomDomainsResponse
        /// </returns>
        public ListWebCustomDomainsResponse ListWebCustomDomains(ListWebCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebCustomDomainsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query available custom domain names.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Query available custom domain names.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListWebCustomDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListWebCustomDomainsResponse
        /// </returns>
        public async Task<ListWebCustomDomainsResponse> ListWebCustomDomainsAsync(ListWebCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebCustomDomainsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Serverless App Engine (SAE) service for free.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenSaeServiceResponse
        /// </returns>
        public OpenSaeServiceResponse OpenSaeServiceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSaeService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/service/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSaeServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Serverless App Engine (SAE) service for free.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenSaeServiceResponse
        /// </returns>
        public async Task<OpenSaeServiceResponse> OpenSaeServiceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSaeService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/service/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSaeServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Serverless App Engine (SAE) service for free.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <returns>
        /// OpenSaeServiceResponse
        /// </returns>
        public OpenSaeServiceResponse OpenSaeService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenSaeServiceWithOptions(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates the Serverless App Engine (SAE) service for free.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <remarks>
        /// <para>Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <returns>
        /// OpenSaeServiceResponse
        /// </returns>
        public async Task<OpenSaeServiceResponse> OpenSaeServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenSaeServiceWithOptionsAsync(headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publish a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publish a web application version. You can change the configurations of the version and create a new version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishWebApplicationRevisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishWebApplicationRevisionResponse
        /// </returns>
        public PublishWebApplicationRevisionResponse PublishWebApplicationRevisionWithOptions(string ApplicationId, PublishWebApplicationRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishWebApplicationRevision",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishWebApplicationRevisionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publish a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publish a web application version. You can change the configurations of the version and create a new version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishWebApplicationRevisionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PublishWebApplicationRevisionResponse
        /// </returns>
        public async Task<PublishWebApplicationRevisionResponse> PublishWebApplicationRevisionWithOptionsAsync(string ApplicationId, PublishWebApplicationRevisionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PublishWebApplicationRevision",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-revisions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/revisions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PublishWebApplicationRevisionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publish a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publish a web application version. You can change the configurations of the version and create a new version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishWebApplicationRevisionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishWebApplicationRevisionResponse
        /// </returns>
        public PublishWebApplicationRevisionResponse PublishWebApplicationRevision(string ApplicationId, PublishWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishWebApplicationRevisionWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Publish a web application version.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Publish a web application version. You can change the configurations of the version and create a new version.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// PublishWebApplicationRevisionRequest
        /// </param>
        /// 
        /// <returns>
        /// PublishWebApplicationRevisionResponse
        /// </returns>
        public async Task<PublishWebApplicationRevisionResponse> PublishWebApplicationRevisionAsync(string ApplicationId, PublishWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishWebApplicationRevisionWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource usage of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourceStaticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceStaticsResponse
        /// </returns>
        public QueryResourceStaticsResponse QueryResourceStaticsWithOptions(QueryResourceStaticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourceStatics",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/queryResourceStatics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceStaticsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource usage of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourceStaticsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceStaticsResponse
        /// </returns>
        public async Task<QueryResourceStaticsResponse> QueryResourceStaticsWithOptionsAsync(QueryResourceStaticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourceStatics",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/queryResourceStatics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceStaticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource usage of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourceStaticsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceStaticsResponse
        /// </returns>
        public QueryResourceStaticsResponse QueryResourceStatics(QueryResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryResourceStaticsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the resource usage of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryResourceStaticsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryResourceStaticsResponse
        /// </returns>
        public async Task<QueryResourceStaticsResponse> QueryResourceStaticsAsync(QueryResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryResourceStaticsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reduces capacity by instance IDs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReduceApplicationCapacityByInstanceIdsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReduceApplicationCapacityByInstanceIdsResponse
        /// </returns>
        public ReduceApplicationCapacityByInstanceIdsResponse ReduceApplicationCapacityByInstanceIdsWithOptions(ReduceApplicationCapacityByInstanceIdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceApplicationCapacityByInstanceIds",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/ScaleInApplicationWithInstanceIds",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceApplicationCapacityByInstanceIdsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reduces capacity by instance IDs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReduceApplicationCapacityByInstanceIdsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReduceApplicationCapacityByInstanceIdsResponse
        /// </returns>
        public async Task<ReduceApplicationCapacityByInstanceIdsResponse> ReduceApplicationCapacityByInstanceIdsWithOptionsAsync(ReduceApplicationCapacityByInstanceIdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceApplicationCapacityByInstanceIds",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/ScaleInApplicationWithInstanceIds",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceApplicationCapacityByInstanceIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reduces capacity by instance IDs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReduceApplicationCapacityByInstanceIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReduceApplicationCapacityByInstanceIdsResponse
        /// </returns>
        public ReduceApplicationCapacityByInstanceIdsResponse ReduceApplicationCapacityByInstanceIds(ReduceApplicationCapacityByInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReduceApplicationCapacityByInstanceIdsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Reduces capacity by instance IDs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ReduceApplicationCapacityByInstanceIdsRequest
        /// </param>
        /// 
        /// <returns>
        /// ReduceApplicationCapacityByInstanceIdsResponse
        /// </returns>
        public async Task<ReduceApplicationCapacityByInstanceIdsResponse> ReduceApplicationCapacityByInstanceIdsAsync(ReduceApplicationCapacityByInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReduceApplicationCapacityByInstanceIdsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationResponse
        /// </returns>
        public RescaleApplicationResponse RescaleApplicationWithOptions(RescaleApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationResponse
        /// </returns>
        public async Task<RescaleApplicationResponse> RescaleApplicationWithOptionsAsync(RescaleApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationResponse
        /// </returns>
        public RescaleApplicationResponse RescaleApplication(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RescaleApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationResponse
        /// </returns>
        public async Task<RescaleApplicationResponse> RescaleApplicationAsync(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RescaleApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the instance specifications of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationVerticallyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationVerticallyResponse
        /// </returns>
        public RescaleApplicationVerticallyResponse RescaleApplicationVerticallyWithOptions(RescaleApplicationVerticallyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["autoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["minReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["minReadyInstances"] = request.MinReadyInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplicationVertically",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplicationVertically",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationVerticallyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the instance specifications of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationVerticallyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationVerticallyResponse
        /// </returns>
        public async Task<RescaleApplicationVerticallyResponse> RescaleApplicationVerticallyWithOptionsAsync(RescaleApplicationVerticallyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["autoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["minReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["minReadyInstances"] = request.MinReadyInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplicationVertically",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplicationVertically",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationVerticallyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the instance specifications of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationVerticallyRequest
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationVerticallyResponse
        /// </returns>
        public RescaleApplicationVerticallyResponse RescaleApplicationVertically(RescaleApplicationVerticallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RescaleApplicationVerticallyWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the instance specifications of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RescaleApplicationVerticallyRequest
        /// </param>
        /// 
        /// <returns>
        /// RescaleApplicationVerticallyResponse
        /// </returns>
        public async Task<RescaleApplicationVerticallyResponse> RescaleApplicationVerticallyAsync(RescaleApplicationVerticallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RescaleApplicationVerticallyWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartApplicationResponse
        /// </returns>
        public RestartApplicationResponse RestartApplicationWithOptions(RestartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartApplicationResponse
        /// </returns>
        public async Task<RestartApplicationResponse> RestartApplicationWithOptionsAsync(RestartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartApplicationResponse
        /// </returns>
        public RestartApplicationResponse RestartApplication(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartApplicationResponse
        /// </returns>
        public async Task<RestartApplicationResponse> RestartApplicationAsync(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more instances in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartInstancesResponse
        /// </returns>
        public RestartInstancesResponse RestartInstancesWithOptions(RestartInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more instances in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartInstancesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartInstancesResponse
        /// </returns>
        public async Task<RestartInstancesResponse> RestartInstancesWithOptionsAsync(RestartInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more instances in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartInstancesResponse
        /// </returns>
        public RestartInstancesResponse RestartInstances(RestartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartInstancesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts one or more instances in an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RestartInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartInstancesResponse
        /// </returns>
        public async Task<RestartInstancesResponse> RestartInstancesAsync(RestartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartInstancesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackApplicationResponse
        /// </returns>
        public RollbackApplicationResponse RollbackApplicationWithOptions(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rollbackApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RollbackApplicationResponse
        /// </returns>
        public async Task<RollbackApplicationResponse> RollbackApplicationWithOptionsAsync(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rollbackApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackApplicationResponse
        /// </returns>
        public RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Rolls back an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RollbackApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// RollbackApplicationResponse
        /// </returns>
        public async Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartApplicationResponse
        /// </returns>
        public StartApplicationResponse StartApplicationWithOptions(StartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/startApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartApplicationResponse
        /// </returns>
        public async Task<StartApplicationResponse> StartApplicationWithOptionsAsync(StartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/startApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StartApplicationResponse
        /// </returns>
        public StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StartApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StartApplicationResponse
        /// </returns>
        public async Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StartWebApplication operation to start a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartWebApplicationResponse
        /// </returns>
        public StartWebApplicationResponse StartWebApplicationWithOptions(string ApplicationId, StartWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-ops/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWebApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StartWebApplication operation to start a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartWebApplicationResponse
        /// </returns>
        public async Task<StartWebApplicationResponse> StartWebApplicationWithOptionsAsync(string ApplicationId, StartWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-ops/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWebApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StartWebApplication operation to start a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StartWebApplicationResponse
        /// </returns>
        public StartWebApplicationResponse StartWebApplication(string ApplicationId, StartWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Start a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StartWebApplication operation to start a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StartWebApplicationResponse
        /// </returns>
        public async Task<StartWebApplicationResponse> StartWebApplicationAsync(string ApplicationId, StartWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopApplicationResponse
        /// </returns>
        public StopApplicationResponse StopApplicationWithOptions(StopApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/stopApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopApplicationResponse
        /// </returns>
        public async Task<StopApplicationResponse> StopApplicationWithOptionsAsync(StopApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/stopApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StopApplicationResponse
        /// </returns>
        public StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopApplicationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>0099b7be-5f5b-4512-a7fc-56049ef1\<em>\</em>\<em>\</em></para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StopApplicationResponse
        /// </returns>
        public async Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopApplicationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StopWebApplication operation to stop a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopWebApplicationResponse
        /// </returns>
        public StopWebApplicationResponse StopWebApplicationWithOptions(string ApplicationId, StopWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-ops/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopWebApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StopWebApplication operation to stop a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopWebApplicationResponse
        /// </returns>
        public async Task<StopWebApplicationResponse> StopWebApplicationWithOptionsAsync(string ApplicationId, StopWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-ops/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopWebApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StopWebApplication operation to stop a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StopWebApplicationResponse
        /// </returns>
        public StopWebApplicationResponse StopWebApplication(string ApplicationId, StopWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stop a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the StopWebApplication operation to stop a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// StopWebApplicationResponse
        /// </returns>
        public async Task<StopWebApplicationResponse> StopWebApplicationAsync(string ApplicationId, StopWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobResponse
        /// </returns>
        public SuspendJobResponse SuspendJobWithOptions(SuspendJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suspend))
            {
                query["Suspend"] = request.Suspend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/suspendJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobResponse
        /// </returns>
        public async Task<SuspendJobResponse> SuspendJobWithOptionsAsync(SuspendJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suspend))
            {
                query["Suspend"] = request.Suspend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/suspendJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobResponse
        /// </returns>
        public SuspendJobResponse SuspendJob(SuspendJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SuspendJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Suspends a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SuspendJobRequest
        /// </param>
        /// 
        /// <returns>
        /// SuspendJobResponse
        /// </returns>
        public async Task<SuspendJobResponse> SuspendJobAsync(SuspendJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SuspendJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing</para>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the UnbindNlb operation to delete an NLB listener bound for application access</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindNlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindNlbResponse
        /// </returns>
        public UnbindNlbResponse UnbindNlbWithOptions(UnbindNlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlbId))
            {
                query["NlbId"] = request.NlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindNlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/nlb",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindNlbResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the UnbindNlb operation to delete an NLB listener bound for application access</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindNlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindNlbResponse
        /// </returns>
        public async Task<UnbindNlbResponse> UnbindNlbWithOptionsAsync(UnbindNlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NlbId))
            {
                query["NlbId"] = request.NlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                query["Port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Protocol))
            {
                query["Protocol"] = request.Protocol;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindNlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/nlb",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindNlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the UnbindNlb operation to delete an NLB listener bound for application access</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindNlbRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindNlbResponse
        /// </returns>
        public UnbindNlbResponse UnbindNlb(UnbindNlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindNlbWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Calls the UnbindNlb operation to delete an NLB listener bound for application access</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindNlbRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindNlbResponse
        /// </returns>
        public async Task<UnbindNlbResponse> UnbindNlbAsync(UnbindNlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindNlbWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an internal-facing or Internet-facing SLB instance from an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindSlbResponse
        /// </returns>
        public UnbindSlbResponse UnbindSlbWithOptions(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSlbResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an internal-facing or Internet-facing SLB instance from an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindSlbRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnbindSlbResponse
        /// </returns>
        public async Task<UnbindSlbResponse> UnbindSlbWithOptionsAsync(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an internal-facing or Internet-facing SLB instance from an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindSlbResponse
        /// </returns>
        public UnbindSlbResponse UnbindSlb(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindSlbWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates an internal-facing or Internet-facing SLB instance from an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UnbindSlbRequest
        /// </param>
        /// 
        /// <returns>
        /// UnbindSlbResponse
        /// </returns>
        public async Task<UnbindSlbResponse> UnbindSlbAsync(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindSlbWithOptionsAsync(request, headers, runtime);
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the security group of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppSecurityGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppSecurityGroupResponse
        /// </returns>
        public UpdateAppSecurityGroupResponse UpdateAppSecurityGroupWithOptions(UpdateAppSecurityGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppSecurityGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppSecurityGroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the security group of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppSecurityGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppSecurityGroupResponse
        /// </returns>
        public async Task<UpdateAppSecurityGroupResponse> UpdateAppSecurityGroupWithOptionsAsync(UpdateAppSecurityGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppSecurityGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppSecurityGroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the security group of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppSecurityGroupResponse
        /// </returns>
        public UpdateAppSecurityGroupResponse UpdateAppSecurityGroup(UpdateAppSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppSecurityGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the security group of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAppSecurityGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAppSecurityGroupResponse
        /// </returns>
        public async Task<UpdateAppSecurityGroupResponse> UpdateAppSecurityGroupAsync(UpdateAppSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppSecurityGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationDescriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationDescriptionResponse
        /// </returns>
        public UpdateApplicationDescriptionResponse UpdateApplicationDescriptionWithOptions(UpdateApplicationDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationDescription",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppDescription",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationDescriptionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationDescriptionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationDescriptionResponse
        /// </returns>
        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionWithOptionsAsync(UpdateApplicationDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationDescription",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppDescription",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationDescriptionResponse
        /// </returns>
        public UpdateApplicationDescriptionResponse UpdateApplicationDescription(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationDescriptionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the description of an application.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationDescriptionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationDescriptionResponse
        /// </returns>
        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionAsync(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationDescriptionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para>If you want to configure more than 50 instances for an application, you must submit a <a href="https://workorder.console.aliyun.com/#/ticket/createIndex">ticket</a> to add your account to the whitelist.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationScalingRuleResponse
        /// </returns>
        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRuleWithOptions(UpdateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIdle))
            {
                query["EnableIdle"] = request.EnableIdle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para>If you want to configure more than 50 instances for an application, you must submit a <a href="https://workorder.console.aliyun.com/#/ticket/createIndex">ticket</a> to add your account to the whitelist.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationScalingRuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationScalingRuleResponse
        /// </returns>
        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleWithOptionsAsync(UpdateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableIdle))
            {
                query["EnableIdle"] = request.EnableIdle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para>If you want to configure more than 50 instances for an application, you must submit a <a href="https://workorder.console.aliyun.com/#/ticket/createIndex">ticket</a> to add your account to the whitelist.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationScalingRuleResponse
        /// </returns>
        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRule(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the auto scaling policy of an application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2></h2>
        /// <para>If you want to configure more than 50 instances for an application, you must submit a <a href="https://workorder.console.aliyun.com/#/ticket/createIndex">ticket</a> to add your account to the whitelist.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApplicationScalingRuleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationScalingRuleResponse
        /// </returns>
        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleAsync(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configuration of a vSwitch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationVswitchesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationVswitchesResponse
        /// </returns>
        public UpdateApplicationVswitchesResponse UpdateApplicationVswitchesWithOptions(UpdateApplicationVswitchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationVswitches",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppVswitches",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationVswitchesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configuration of a vSwitch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationVswitchesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationVswitchesResponse
        /// </returns>
        public async Task<UpdateApplicationVswitchesResponse> UpdateApplicationVswitchesWithOptionsAsync(UpdateApplicationVswitchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationVswitches",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppVswitches",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationVswitchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configuration of a vSwitch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationVswitchesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationVswitchesResponse
        /// </returns>
        public UpdateApplicationVswitchesResponse UpdateApplicationVswitches(UpdateApplicationVswitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationVswitchesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configuration of a vSwitch.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateApplicationVswitchesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApplicationVswitchesResponse
        /// </returns>
        public async Task<UpdateApplicationVswitchesResponse> UpdateApplicationVswitchesAsync(UpdateApplicationVswitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationVswitchesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigMapResponse
        /// </returns>
        public UpdateConfigMapResponse UpdateConfigMapWithOptions(UpdateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigMapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigMapRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigMapResponse
        /// </returns>
        public async Task<UpdateConfigMapResponse> UpdateConfigMapWithOptionsAsync(UpdateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigMapResponse
        /// </returns>
        public UpdateConfigMapResponse UpdateConfigMap(UpdateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigMapWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a ConfigMap.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateConfigMapRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateConfigMapResponse
        /// </returns>
        public async Task<UpdateConfigMapResponse> UpdateConfigMapAsync(UpdateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a canary release rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGreyTagRouteResponse
        /// </returns>
        public UpdateGreyTagRouteResponse UpdateGreyTagRouteWithOptions(UpdateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a canary release rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGreyTagRouteRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGreyTagRouteResponse
        /// </returns>
        public async Task<UpdateGreyTagRouteResponse> UpdateGreyTagRouteWithOptionsAsync(UpdateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a canary release rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGreyTagRouteResponse
        /// </returns>
        public UpdateGreyTagRouteResponse UpdateGreyTagRoute(UpdateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGreyTagRouteWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a canary release rule.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGreyTagRouteRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGreyTagRouteResponse
        /// </returns>
        public async Task<UpdateGreyTagRouteResponse> UpdateGreyTagRouteAsync(UpdateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configurations of an Ingress instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIngressResponse
        /// </returns>
        public UpdateIngressResponse UpdateIngressWithOptions(UpdateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorsConfig))
            {
                query["CorsConfig"] = request.CorsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedFor))
            {
                query["EnableXForwardedFor"] = request.EnableXForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForClientSrcPort))
            {
                query["EnableXForwardedForClientSrcPort"] = request.EnableXForwardedForClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForProto))
            {
                query["EnableXForwardedForProto"] = request.EnableXForwardedForProto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbId))
            {
                query["EnableXForwardedForSlbId"] = request.EnableXForwardedForSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbPort))
            {
                query["EnableXForwardedForSlbPort"] = request.EnableXForwardedForSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIngressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configurations of an Ingress instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIngressRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateIngressResponse
        /// </returns>
        public async Task<UpdateIngressResponse> UpdateIngressWithOptionsAsync(UpdateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorsConfig))
            {
                query["CorsConfig"] = request.CorsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedFor))
            {
                query["EnableXForwardedFor"] = request.EnableXForwardedFor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForClientSrcPort))
            {
                query["EnableXForwardedForClientSrcPort"] = request.EnableXForwardedForClientSrcPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForProto))
            {
                query["EnableXForwardedForProto"] = request.EnableXForwardedForProto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbId))
            {
                query["EnableXForwardedForSlbId"] = request.EnableXForwardedForSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableXForwardedForSlbPort))
            {
                query["EnableXForwardedForSlbPort"] = request.EnableXForwardedForSlbPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleTimeout))
            {
                query["IdleTimeout"] = request.IdleTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestTimeout))
            {
                query["RequestTimeout"] = request.RequestTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityPolicyId))
            {
                query["SecurityPolicyId"] = request.SecurityPolicyId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configurations of an Ingress instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIngressResponse
        /// </returns>
        public UpdateIngressResponse UpdateIngress(UpdateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIngressWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the configurations of an Ingress instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateIngressRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateIngressResponse
        /// </returns>
        public async Task<UpdateIngressResponse> UpdateIngressAsync(UpdateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIngressWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public UpdateJobResponse UpdateJobWithOptions(UpdateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/updateJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(UpdateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/updateJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateJobWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a job template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateJobResponse
        /// </returns>
        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateJobWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public UpdateNamespaceResponse UpdateNamespaceWithOptions(UpdateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(UpdateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information about a namespace.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceResponse
        /// </returns>
        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing:test</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceVpcRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceVpcResponse
        /// </returns>
        public UpdateNamespaceVpcResponse UpdateNamespaceVpcWithOptions(UpdateNamespaceVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
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
                Action = "UpdateNamespaceVpc",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/updateNamespaceVpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceVpcResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing:test</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceVpcRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceVpcResponse
        /// </returns>
        public async Task<UpdateNamespaceVpcResponse> UpdateNamespaceVpcWithOptionsAsync(UpdateNamespaceVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
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
                Action = "UpdateNamespaceVpc",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/updateNamespaceVpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing:test</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceVpcResponse
        /// </returns>
        public UpdateNamespaceVpcResponse UpdateNamespaceVpc(UpdateNamespaceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceVpcWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>cn-beijing:test</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateNamespaceVpcRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNamespaceVpcResponse
        /// </returns>
        public async Task<UpdateNamespaceVpcResponse> UpdateNamespaceVpcAsync(UpdateNamespaceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceVpcWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
        public UpdateSecretResponse UpdateSecretWithOptions(UpdateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSecretShrinkRequest request = new UpdateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecretResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSecretRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
        public async Task<UpdateSecretResponse> UpdateSecretWithOptionsAsync(UpdateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSecretShrinkRequest request = new UpdateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSecretWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSecretRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSecretResponse
        /// </returns>
        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSecretWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新泳道的启用属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSwimmingLaneEnableAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSwimmingLaneEnableAttributeResponse
        /// </returns>
        public UpdateSwimmingLaneEnableAttributeResponse UpdateSwimmingLaneEnableAttributeWithOptions(UpdateSwimmingLaneEnableAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSwimmingLaneEnableAttribute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/updateSwimmingLaneEnableAttribute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSwimmingLaneEnableAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新泳道的启用属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSwimmingLaneEnableAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSwimmingLaneEnableAttributeResponse
        /// </returns>
        public async Task<UpdateSwimmingLaneEnableAttributeResponse> UpdateSwimmingLaneEnableAttributeWithOptionsAsync(UpdateSwimmingLaneEnableAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LaneId))
            {
                query["LaneId"] = request.LaneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSwimmingLaneEnableAttribute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/cas/gray/updateSwimmingLaneEnableAttribute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSwimmingLaneEnableAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新泳道的启用属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSwimmingLaneEnableAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSwimmingLaneEnableAttributeResponse
        /// </returns>
        public UpdateSwimmingLaneEnableAttributeResponse UpdateSwimmingLaneEnableAttribute(UpdateSwimmingLaneEnableAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSwimmingLaneEnableAttributeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新泳道的启用属性</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSwimmingLaneEnableAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSwimmingLaneEnableAttributeResponse
        /// </returns>
        public async Task<UpdateSwimmingLaneEnableAttributeResponse> UpdateSwimmingLaneEnableAttributeAsync(UpdateSwimmingLaneEnableAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSwimmingLaneEnableAttributeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration at the web application level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplication operation to update the configuration at the web application level.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationResponse
        /// </returns>
        public UpdateWebApplicationResponse UpdateWebApplicationWithOptions(string ApplicationId, UpdateWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebApplicationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration at the web application level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplication operation to update the configuration at the web application level.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationResponse
        /// </returns>
        public async Task<UpdateWebApplicationResponse> UpdateWebApplicationWithOptionsAsync(string ApplicationId, UpdateWebApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/applications/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration at the web application level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplication operation to update the configuration at the web application level.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationResponse
        /// </returns>
        public UpdateWebApplicationResponse UpdateWebApplication(string ApplicationId, UpdateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration at the web application level.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplication operation to update the configuration at the web application level.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationResponse
        /// </returns>
        public async Task<UpdateWebApplicationResponse> UpdateWebApplicationAsync(string ApplicationId, UpdateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplicationScalingConfig operation to update the scaling configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationScalingConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationScalingConfigResponse
        /// </returns>
        public UpdateWebApplicationScalingConfigResponse UpdateWebApplicationScalingConfigWithOptions(string ApplicationId, UpdateWebApplicationScalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebApplicationScalingConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-scaling/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebApplicationScalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplicationScalingConfig operation to update the scaling configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationScalingConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationScalingConfigResponse
        /// </returns>
        public async Task<UpdateWebApplicationScalingConfigResponse> UpdateWebApplicationScalingConfigWithOptionsAsync(string ApplicationId, UpdateWebApplicationScalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebApplicationScalingConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-scaling/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebApplicationScalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplicationScalingConfig operation to update the scaling configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationScalingConfigResponse
        /// </returns>
        public UpdateWebApplicationScalingConfigResponse UpdateWebApplicationScalingConfig(string ApplicationId, UpdateWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebApplicationScalingConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the scaling configuration of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateWebApplicationScalingConfig operation to update the scaling configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationScalingConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationScalingConfigResponse
        /// </returns>
        public async Task<UpdateWebApplicationScalingConfigResponse> UpdateWebApplicationScalingConfigAsync(string ApplicationId, UpdateWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebApplicationScalingConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the UpdateWebApplicationTrafficConfig operation to update the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationTrafficConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationTrafficConfigResponse
        /// </returns>
        public UpdateWebApplicationTrafficConfigResponse UpdateWebApplicationTrafficConfigWithOptions(string ApplicationId, UpdateWebApplicationTrafficConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebApplicationTrafficConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-traffic/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebApplicationTrafficConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the UpdateWebApplicationTrafficConfig operation to update the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationTrafficConfigRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationTrafficConfigResponse
        /// </returns>
        public async Task<UpdateWebApplicationTrafficConfigResponse> UpdateWebApplicationTrafficConfigWithOptionsAsync(string ApplicationId, UpdateWebApplicationTrafficConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebApplicationTrafficConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/application-traffic/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ApplicationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebApplicationTrafficConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the UpdateWebApplicationTrafficConfig operation to update the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationTrafficConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationTrafficConfigResponse
        /// </returns>
        public UpdateWebApplicationTrafficConfigResponse UpdateWebApplicationTrafficConfig(string ApplicationId, UpdateWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebApplicationTrafficConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the traffic configurations of a web application.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Call the UpdateWebApplicationTrafficConfig operation to update the traffic configurations of a web application.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebApplicationTrafficConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebApplicationTrafficConfigResponse
        /// </returns>
        public async Task<UpdateWebApplicationTrafficConfigResponse> UpdateWebApplicationTrafficConfigAsync(string ApplicationId, UpdateWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebApplicationTrafficConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebCustomDomainResponse
        /// </returns>
        public UpdateWebCustomDomainResponse UpdateWebCustomDomainWithOptions(string DomainName, UpdateWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebCustomDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebCustomDomainRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebCustomDomainResponse
        /// </returns>
        public async Task<UpdateWebCustomDomainResponse> UpdateWebCustomDomainWithOptionsAsync(string DomainName, UpdateWebCustomDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateWebCustomDomain",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v2/api/web/custom-domains/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(DomainName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateWebCustomDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebCustomDomainResponse
        /// </returns>
        public UpdateWebCustomDomainResponse UpdateWebCustomDomain(string DomainName, UpdateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebCustomDomainWithOptions(DomainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update a custom domain name.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Update a custom domain name.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateWebCustomDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateWebCustomDomainResponse
        /// </returns>
        public async Task<UpdateWebCustomDomainResponse> UpdateWebCustomDomainAsync(string DomainName, UpdateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebCustomDomainWithOptionsAsync(DomainName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You are charged when you use the ARMS advanced monitoring feature. Enable this feature based on your business requirements. For more information, see <a href="https://icms.alibaba-inc.com/content/arms/arms?l=1%5C&m=16992%5C&n=3183148">Billing overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeApplicationApmServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeApplicationApmServiceResponse
        /// </returns>
        public UpgradeApplicationApmServiceResponse UpgradeApplicationApmServiceWithOptions(UpgradeApplicationApmServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeApplicationApmService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/applicationApmService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeApplicationApmServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You are charged when you use the ARMS advanced monitoring feature. Enable this feature based on your business requirements. For more information, see <a href="https://icms.alibaba-inc.com/content/arms/arms?l=1%5C&m=16992%5C&n=3183148">Billing overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeApplicationApmServiceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeApplicationApmServiceResponse
        /// </returns>
        public async Task<UpgradeApplicationApmServiceResponse> UpgradeApplicationApmServiceWithOptionsAsync(UpgradeApplicationApmServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeApplicationApmService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/applicationApmService",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeApplicationApmServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You are charged when you use the ARMS advanced monitoring feature. Enable this feature based on your business requirements. For more information, see <a href="https://icms.alibaba-inc.com/content/arms/arms?l=1%5C&m=16992%5C&n=3183148">Billing overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeApplicationApmServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeApplicationApmServiceResponse
        /// </returns>
        public UpgradeApplicationApmServiceResponse UpgradeApplicationApmService(UpgradeApplicationApmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeApplicationApmServiceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the advanced monitoring feature of Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You are charged when you use the ARMS advanced monitoring feature. Enable this feature based on your business requirements. For more information, see <a href="https://icms.alibaba-inc.com/content/arms/arms?l=1%5C&m=16992%5C&n=3183148">Billing overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeApplicationApmServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeApplicationApmServiceResponse
        /// </returns>
        public async Task<UpgradeApplicationApmServiceResponse> UpgradeApplicationApmServiceAsync(UpgradeApplicationApmServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeApplicationApmServiceWithOptionsAsync(request, headers, runtime);
        }

    }
}
