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

        /**
         * @summary ba386059-69b1-4e65-b1e5-0682d9fa\\*\\*\\*\\*
         *
         * @param request AbortAndRollbackChangeOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortAndRollbackChangeOrderResponse
         */
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

        /**
         * @summary ba386059-69b1-4e65-b1e5-0682d9fa\\*\\*\\*\\*
         *
         * @param request AbortAndRollbackChangeOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortAndRollbackChangeOrderResponse
         */
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

        /**
         * @summary ba386059-69b1-4e65-b1e5-0682d9fa\\*\\*\\*\\*
         *
         * @param request AbortAndRollbackChangeOrderRequest
         * @return AbortAndRollbackChangeOrderResponse
         */
        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrder(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortAndRollbackChangeOrderWithOptions(request, headers, runtime);
        }

        /**
         * @summary ba386059-69b1-4e65-b1e5-0682d9fa\\*\\*\\*\\*
         *
         * @param request AbortAndRollbackChangeOrderRequest
         * @return AbortAndRollbackChangeOrderResponse
         */
        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderAsync(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortAndRollbackChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request AbortChangeOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortChangeOrderResponse
         */
        public AbortChangeOrderResponse AbortChangeOrderWithOptions(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @param request AbortChangeOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AbortChangeOrderResponse
         */
        public async Task<AbortChangeOrderResponse> AbortChangeOrderWithOptionsAsync(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @param request AbortChangeOrderRequest
         * @return AbortChangeOrderResponse
         */
        public AbortChangeOrderResponse AbortChangeOrder(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortChangeOrderWithOptions(request, headers, runtime);
        }

        /**
         * @param request AbortChangeOrderRequest
         * @return AbortChangeOrderResponse
         */
        public async Task<AbortChangeOrderResponse> AbortChangeOrderAsync(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary cn-shanghai
         *
         * @param request BatchStartApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchStartApplicationsResponse
         */
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

        /**
         * @summary cn-shanghai
         *
         * @param request BatchStartApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchStartApplicationsResponse
         */
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

        /**
         * @summary cn-shanghai
         *
         * @param request BatchStartApplicationsRequest
         * @return BatchStartApplicationsResponse
         */
        public BatchStartApplicationsResponse BatchStartApplications(BatchStartApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchStartApplicationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary cn-shanghai
         *
         * @param request BatchStartApplicationsRequest
         * @return BatchStartApplicationsResponse
         */
        public async Task<BatchStartApplicationsResponse> BatchStartApplicationsAsync(BatchStartApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchStartApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Stops multiple applications at a time.
         *
         * @param request BatchStopApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchStopApplicationsResponse
         */
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

        /**
         * @summary Stops multiple applications at a time.
         *
         * @param request BatchStopApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchStopApplicationsResponse
         */
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

        /**
         * @summary Stops multiple applications at a time.
         *
         * @param request BatchStopApplicationsRequest
         * @return BatchStopApplicationsResponse
         */
        public BatchStopApplicationsResponse BatchStopApplications(BatchStopApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchStopApplicationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Stops multiple applications at a time.
         *
         * @param request BatchStopApplicationsRequest
         * @return BatchStopApplicationsResponse
         */
        public async Task<BatchStopApplicationsResponse> BatchStopApplicationsAsync(BatchStopApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchStopApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request BindSlbRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindSlbResponse
         */
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

        /**
         * @param request BindSlbRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return BindSlbResponse
         */
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

        /**
         * @param request BindSlbRequest
         * @return BindSlbResponse
         */
        public BindSlbResponse BindSlb(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindSlbWithOptions(request, headers, runtime);
        }

        /**
         * @param request BindSlbRequest
         * @return BindSlbResponse
         */
        public async Task<BindSlbResponse> BindSlbAsync(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindSlbWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request ConfirmPipelineBatchRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmPipelineBatchResponse
         */
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

        /**
         * @param request ConfirmPipelineBatchRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConfirmPipelineBatchResponse
         */
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

        /**
         * @param request ConfirmPipelineBatchRequest
         * @return ConfirmPipelineBatchResponse
         */
        public ConfirmPipelineBatchResponse ConfirmPipelineBatch(ConfirmPipelineBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmPipelineBatchWithOptions(request, headers, runtime);
        }

        /**
         * @param request ConfirmPipelineBatchRequest
         * @return ConfirmPipelineBatchResponse
         */
        public async Task<ConfirmPipelineBatchResponse> ConfirmPipelineBatchAsync(ConfirmPipelineBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmPipelineBatchWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request CreateApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationResponse
         */
        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaeVersion))
            {
                query["SaeVersion"] = request.SaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
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

        /**
         * @param request CreateApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationResponse
         */
        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaeVersion))
            {
                query["SaeVersion"] = request.SaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
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

        /**
         * @param request CreateApplicationRequest
         * @return CreateApplicationResponse
         */
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @param request CreateApplicationRequest
         * @return CreateApplicationResponse
         */
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Null
         *
         * @description The HTTP status code. Take note of the following rules:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param request CreateApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationScalingRuleResponse
         */
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

        /**
         * @summary Null
         *
         * @description The HTTP status code. Take note of the following rules:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param request CreateApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApplicationScalingRuleResponse
         */
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

        /**
         * @summary Null
         *
         * @description The HTTP status code. Take note of the following rules:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param request CreateApplicationScalingRuleRequest
         * @return CreateApplicationScalingRuleResponse
         */
        public CreateApplicationScalingRuleResponse CreateApplicationScalingRule(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary Null
         *
         * @description The HTTP status code. Take note of the following rules:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param request CreateApplicationScalingRuleRequest
         * @return CreateApplicationScalingRuleResponse
         */
        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleAsync(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Create a ConfigMap in a namespace.
         *
         * @param request CreateConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigMapResponse
         */
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

        /**
         * @summary Create a ConfigMap in a namespace.
         *
         * @param request CreateConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigMapResponse
         */
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

        /**
         * @summary Create a ConfigMap in a namespace.
         *
         * @param request CreateConfigMapRequest
         * @return CreateConfigMapResponse
         */
        public CreateConfigMapResponse CreateConfigMap(CreateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigMapWithOptions(request, headers, runtime);
        }

        /**
         * @summary Create a ConfigMap in a namespace.
         *
         * @param request CreateConfigMapRequest
         * @return CreateConfigMapResponse
         */
        public async Task<CreateConfigMapResponse> CreateConfigMapAsync(CreateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a canary release rule for a Spring Cloud or Dubbo application.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request CreateGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGreyTagRouteResponse
         */
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

        /**
         * @summary Creates a canary release rule for a Spring Cloud or Dubbo application.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request CreateGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateGreyTagRouteResponse
         */
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

        /**
         * @summary Creates a canary release rule for a Spring Cloud or Dubbo application.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request CreateGreyTagRouteRequest
         * @return CreateGreyTagRouteResponse
         */
        public CreateGreyTagRouteResponse CreateGreyTagRoute(CreateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a canary release rule for a Spring Cloud or Dubbo application.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request CreateGreyTagRouteRequest
         * @return CreateGreyTagRouteResponse
         */
        public async Task<CreateGreyTagRouteResponse> CreateGreyTagRouteAsync(CreateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary {"appId":"395b60e4-0550-458d-9c54-a265d036\\*\\*\\*\\*","containerPort":8080}
         *
         * @param request CreateIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIngressResponse
         */
        public CreateIngressResponse CreateIngressWithOptions(CreateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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

        /**
         * @summary {"appId":"395b60e4-0550-458d-9c54-a265d036\\*\\*\\*\\*","containerPort":8080}
         *
         * @param request CreateIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateIngressResponse
         */
        public async Task<CreateIngressResponse> CreateIngressWithOptionsAsync(CreateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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

        /**
         * @summary {"appId":"395b60e4-0550-458d-9c54-a265d036\\*\\*\\*\\*","containerPort":8080}
         *
         * @param request CreateIngressRequest
         * @return CreateIngressResponse
         */
        public CreateIngressResponse CreateIngress(CreateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIngressWithOptions(request, headers, runtime);
        }

        /**
         * @summary {"appId":"395b60e4-0550-458d-9c54-a265d036\\*\\*\\*\\*","containerPort":8080}
         *
         * @param request CreateIngressRequest
         * @return CreateIngressResponse
         */
        public async Task<CreateIngressResponse> CreateIngressAsync(CreateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIngressWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates a job template.
         *
         * @param request CreateJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateJobResponse
         */
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

        /**
         * @summary Updates a job template.
         *
         * @param request CreateJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateJobResponse
         */
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

        /**
         * @summary Updates a job template.
         *
         * @param request CreateJobRequest
         * @return CreateJobResponse
         */
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates a job template.
         *
         * @param request CreateJobRequest
         * @return CreateJobResponse
         */
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNamespaceResponse
         */
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

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNamespaceResponse
         */
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

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @return CreateNamespaceResponse
         */
        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a namespace.
         *
         * @param request CreateNamespaceRequest
         * @return CreateNamespaceResponse
         */
        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Null
         *
         * @param tmpReq CreateSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecretResponse
         */
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

        /**
         * @summary Null
         *
         * @param tmpReq CreateSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSecretResponse
         */
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

        /**
         * @summary Null
         *
         * @param request CreateSecretRequest
         * @return CreateSecretResponse
         */
        public CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSecretWithOptions(request, headers, runtime);
        }

        /**
         * @summary Null
         *
         * @param request CreateSecretRequest
         * @return CreateSecretResponse
         */
        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSecretWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 创建应用
         *
         * @param request CreateWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWebApplicationResponse
         */
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

        /**
         * @summary 创建应用
         *
         * @param request CreateWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWebApplicationResponse
         */
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

        /**
         * @summary 创建应用
         *
         * @param request CreateWebApplicationRequest
         * @return CreateWebApplicationResponse
         */
        public CreateWebApplicationResponse CreateWebApplication(CreateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWebApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建应用
         *
         * @param request CreateWebApplicationRequest
         * @return CreateWebApplicationResponse
         */
        public async Task<CreateWebApplicationResponse> CreateWebApplicationAsync(CreateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWebApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 新建自定义域名
         *
         * @param request CreateWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWebCustomDomainResponse
         */
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

        /**
         * @summary 新建自定义域名
         *
         * @param request CreateWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateWebCustomDomainResponse
         */
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

        /**
         * @summary 新建自定义域名
         *
         * @param request CreateWebCustomDomainRequest
         * @return CreateWebCustomDomainResponse
         */
        public CreateWebCustomDomainResponse CreateWebCustomDomain(CreateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateWebCustomDomainWithOptions(request, headers, runtime);
        }

        /**
         * @summary 新建自定义域名
         *
         * @param request CreateWebCustomDomainRequest
         * @return CreateWebCustomDomainResponse
         */
        public async Task<CreateWebCustomDomainResponse> CreateWebCustomDomainAsync(CreateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateWebCustomDomainWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeleteApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationResponse
         */
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

        /**
         * @param request DeleteApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationResponse
         */
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

        /**
         * @param request DeleteApplicationRequest
         * @return DeleteApplicationResponse
         */
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeleteApplicationRequest
         * @return DeleteApplicationResponse
         */
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request DeleteApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationScalingRuleResponse
         */
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

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request DeleteApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApplicationScalingRuleResponse
         */
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

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request DeleteApplicationScalingRuleRequest
         * @return DeleteApplicationScalingRuleResponse
         */
        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRule(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request DeleteApplicationScalingRuleRequest
         * @return DeleteApplicationScalingRuleResponse
         */
        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleAsync(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeleteConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigMapResponse
         */
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

        /**
         * @param request DeleteConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigMapResponse
         */
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

        /**
         * @param request DeleteConfigMapRequest
         * @return DeleteConfigMapResponse
         */
        public DeleteConfigMapResponse DeleteConfigMap(DeleteConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigMapWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeleteConfigMapRequest
         * @return DeleteConfigMapResponse
         */
        public async Task<DeleteConfigMapResponse> DeleteConfigMapAsync(DeleteConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 1
         *
         * @param request DeleteGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGreyTagRouteResponse
         */
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

        /**
         * @summary 1
         *
         * @param request DeleteGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteGreyTagRouteResponse
         */
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

        /**
         * @summary 1
         *
         * @param request DeleteGreyTagRouteRequest
         * @return DeleteGreyTagRouteResponse
         */
        public DeleteGreyTagRouteResponse DeleteGreyTagRoute(DeleteGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
         * @summary 1
         *
         * @param request DeleteGreyTagRouteRequest
         * @return DeleteGreyTagRouteResponse
         */
        public async Task<DeleteGreyTagRouteResponse> DeleteGreyTagRouteAsync(DeleteGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a job.
         *
         * @param request DeleteHistoryJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHistoryJobResponse
         */
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

        /**
         * @summary Deletes a job.
         *
         * @param request DeleteHistoryJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHistoryJobResponse
         */
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

        /**
         * @summary Deletes a job.
         *
         * @param request DeleteHistoryJobRequest
         * @return DeleteHistoryJobResponse
         */
        public DeleteHistoryJobResponse DeleteHistoryJob(DeleteHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHistoryJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a job.
         *
         * @param request DeleteHistoryJobRequest
         * @return DeleteHistoryJobResponse
         */
        public async Task<DeleteHistoryJobResponse> DeleteHistoryJobAsync(DeleteHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHistoryJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeleteIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIngressResponse
         */
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

        /**
         * @param request DeleteIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteIngressResponse
         */
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

        /**
         * @param request DeleteIngressRequest
         * @return DeleteIngressResponse
         */
        public DeleteIngressResponse DeleteIngress(DeleteIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIngressWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeleteIngressRequest
         * @return DeleteIngressResponse
         */
        public async Task<DeleteIngressResponse> DeleteIngressAsync(DeleteIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIngressWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a job template.
         *
         * @param request DeleteJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
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

        /**
         * @summary Deletes a job template.
         *
         * @param request DeleteJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobResponse
         */
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

        /**
         * @summary Deletes a job template.
         *
         * @param request DeleteJobRequest
         * @return DeleteJobResponse
         */
        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a job template.
         *
         * @param request DeleteJobRequest
         * @return DeleteJobResponse
         */
        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DeleteNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNamespaceResponse
         */
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

        /**
         * @param request DeleteNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNamespaceResponse
         */
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

        /**
         * @param request DeleteNamespaceRequest
         * @return DeleteNamespaceResponse
         */
        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @param request DeleteNamespaceRequest
         * @return DeleteNamespaceResponse
         */
        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Deletes a Secret.
         *
         * @param request DeleteSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecretResponse
         */
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

        /**
         * @summary Deletes a Secret.
         *
         * @param request DeleteSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSecretResponse
         */
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

        /**
         * @summary Deletes a Secret.
         *
         * @param request DeleteSecretRequest
         * @return DeleteSecretResponse
         */
        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSecretWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deletes a Secret.
         *
         * @param request DeleteSecretRequest
         * @return DeleteSecretResponse
         */
        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSecretWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除应用
         *
         * @param request DeleteWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWebApplicationResponse
         */
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

        /**
         * @summary 删除应用
         *
         * @param request DeleteWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWebApplicationResponse
         */
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

        /**
         * @summary 删除应用
         *
         * @param request DeleteWebApplicationRequest
         * @return DeleteWebApplicationResponse
         */
        public DeleteWebApplicationResponse DeleteWebApplication(string ApplicationId, DeleteWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 删除应用
         *
         * @param request DeleteWebApplicationRequest
         * @return DeleteWebApplicationResponse
         */
        public async Task<DeleteWebApplicationResponse> DeleteWebApplicationAsync(string ApplicationId, DeleteWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 删除应用版本
         *
         * @param request DeleteWebApplicationRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWebApplicationRevisionResponse
         */
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

        /**
         * @summary 删除应用版本
         *
         * @param request DeleteWebApplicationRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWebApplicationRevisionResponse
         */
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

        /**
         * @summary 删除应用版本
         *
         * @param request DeleteWebApplicationRevisionRequest
         * @return DeleteWebApplicationRevisionResponse
         */
        public DeleteWebApplicationRevisionResponse DeleteWebApplicationRevision(string ApplicationId, string RevisionId, DeleteWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWebApplicationRevisionWithOptions(ApplicationId, RevisionId, request, headers, runtime);
        }

        /**
         * @summary 删除应用版本
         *
         * @param request DeleteWebApplicationRevisionRequest
         * @return DeleteWebApplicationRevisionResponse
         */
        public async Task<DeleteWebApplicationRevisionResponse> DeleteWebApplicationRevisionAsync(string ApplicationId, string RevisionId, DeleteWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWebApplicationRevisionWithOptionsAsync(ApplicationId, RevisionId, request, headers, runtime);
        }

        /**
         * @summary 删除自定义域名
         *
         * @param request DeleteWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWebCustomDomainResponse
         */
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

        /**
         * @summary 删除自定义域名
         *
         * @param request DeleteWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteWebCustomDomainResponse
         */
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

        /**
         * @summary 删除自定义域名
         *
         * @param request DeleteWebCustomDomainRequest
         * @return DeleteWebCustomDomainResponse
         */
        public DeleteWebCustomDomainResponse DeleteWebCustomDomain(string DomainName, DeleteWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteWebCustomDomainWithOptions(DomainName, request, headers, runtime);
        }

        /**
         * @summary 删除自定义域名
         *
         * @param request DeleteWebCustomDomainRequest
         * @return DeleteWebCustomDomainResponse
         */
        public async Task<DeleteWebCustomDomainResponse> DeleteWebCustomDomainAsync(string DomainName, DeleteWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteWebCustomDomainWithOptionsAsync(DomainName, request, headers, runtime);
        }

        /**
         * @summary Deploys an application.
         *
         * @param request DeployApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployApplicationResponse
         */
        public DeployApplicationResponse DeployApplicationWithOptions(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
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

        /**
         * @summary Deploys an application.
         *
         * @param request DeployApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployApplicationResponse
         */
        public async Task<DeployApplicationResponse> DeployApplicationWithOptionsAsync(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
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

        /**
         * @summary Deploys an application.
         *
         * @param request DeployApplicationRequest
         * @return DeployApplicationResponse
         */
        public DeployApplicationResponse DeployApplication(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary Deploys an application.
         *
         * @param request DeployApplicationRequest
         * @return DeployApplicationResponse
         */
        public async Task<DeployApplicationResponse> DeployApplicationAsync(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the metadata details of the service of an application.
         *
         * @param request DescribeAppServiceDetailRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppServiceDetailResponse
         */
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

        /**
         * @summary Queries the metadata details of the service of an application.
         *
         * @param request DescribeAppServiceDetailRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAppServiceDetailResponse
         */
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

        /**
         * @summary Queries the metadata details of the service of an application.
         *
         * @param request DescribeAppServiceDetailRequest
         * @return DescribeAppServiceDetailResponse
         */
        public DescribeAppServiceDetailResponse DescribeAppServiceDetail(DescribeAppServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppServiceDetailWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the metadata details of the service of an application.
         *
         * @param request DescribeAppServiceDetailRequest
         * @return DescribeAppServiceDetailResponse
         */
        public async Task<DescribeAppServiceDetailResponse> DescribeAppServiceDetailAsync(DescribeAppServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppServiceDetailWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the configurations of an application.
         *
         * @param request DescribeApplicationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationConfigResponse
         */
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

        /**
         * @summary Queries the configurations of an application.
         *
         * @param request DescribeApplicationConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationConfigResponse
         */
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

        /**
         * @summary Queries the configurations of an application.
         *
         * @param request DescribeApplicationConfigRequest
         * @return DescribeApplicationConfigResponse
         */
        public DescribeApplicationConfigResponse DescribeApplicationConfig(DescribeApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationConfigWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the configurations of an application.
         *
         * @param request DescribeApplicationConfigRequest
         * @return DescribeApplicationConfigResponse
         */
        public async Task<DescribeApplicationConfigResponse> DescribeApplicationConfigAsync(DescribeApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationConfigWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeApplicationGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationGroupsResponse
         */
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

        /**
         * @param request DescribeApplicationGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationGroupsResponse
         */
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

        /**
         * @param request DescribeApplicationGroupsRequest
         * @return DescribeApplicationGroupsResponse
         */
        public DescribeApplicationGroupsResponse DescribeApplicationGroups(DescribeApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationGroupsWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeApplicationGroupsRequest
         * @return DescribeApplicationGroupsResponse
         */
        public async Task<DescribeApplicationGroupsResponse> DescribeApplicationGroupsAsync(DescribeApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationGroupsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about the image of an application.
         *
         * @param request DescribeApplicationImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationImageResponse
         */
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

        /**
         * @summary Queries the information about the image of an application.
         *
         * @param request DescribeApplicationImageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationImageResponse
         */
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

        /**
         * @summary Queries the information about the image of an application.
         *
         * @param request DescribeApplicationImageRequest
         * @return DescribeApplicationImageResponse
         */
        public DescribeApplicationImageResponse DescribeApplicationImage(DescribeApplicationImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationImageWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about the image of an application.
         *
         * @param request DescribeApplicationImageRequest
         * @return DescribeApplicationImageResponse
         */
        public async Task<DescribeApplicationImageResponse> DescribeApplicationImageAsync(DescribeApplicationImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationImageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries application instances.
         *
         * @param request DescribeApplicationInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationInstancesResponse
         */
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

        /**
         * @summary Queries application instances.
         *
         * @param request DescribeApplicationInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationInstancesResponse
         */
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

        /**
         * @summary Queries application instances.
         *
         * @param request DescribeApplicationInstancesRequest
         * @return DescribeApplicationInstancesResponse
         */
        public DescribeApplicationInstancesResponse DescribeApplicationInstances(DescribeApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries application instances.
         *
         * @param request DescribeApplicationInstancesRequest
         * @return DescribeApplicationInstancesResponse
         */
        public async Task<DescribeApplicationInstancesResponse> DescribeApplicationInstancesAsync(DescribeApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a specified auto scaling policy of an application.
         *
         * @param request DescribeApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationScalingRuleResponse
         */
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

        /**
         * @summary Queries a specified auto scaling policy of an application.
         *
         * @param request DescribeApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationScalingRuleResponse
         */
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

        /**
         * @summary Queries a specified auto scaling policy of an application.
         *
         * @param request DescribeApplicationScalingRuleRequest
         * @return DescribeApplicationScalingRuleResponse
         */
        public DescribeApplicationScalingRuleResponse DescribeApplicationScalingRule(DescribeApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a specified auto scaling policy of an application.
         *
         * @param request DescribeApplicationScalingRuleRequest
         * @return DescribeApplicationScalingRuleResponse
         */
        public async Task<DescribeApplicationScalingRuleResponse> DescribeApplicationScalingRuleAsync(DescribeApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the auto scaling policies of an application.
         *
         * @param request DescribeApplicationScalingRulesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationScalingRulesResponse
         */
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

        /**
         * @summary Queries the auto scaling policies of an application.
         *
         * @param request DescribeApplicationScalingRulesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationScalingRulesResponse
         */
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

        /**
         * @summary Queries the auto scaling policies of an application.
         *
         * @param request DescribeApplicationScalingRulesRequest
         * @return DescribeApplicationScalingRulesResponse
         */
        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRules(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRulesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the auto scaling policies of an application.
         *
         * @param request DescribeApplicationScalingRulesRequest
         * @return DescribeApplicationScalingRulesResponse
         */
        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesAsync(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRulesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request DescribeApplicationSlbsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationSlbsResponse
         */
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

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request DescribeApplicationSlbsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationSlbsResponse
         */
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

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request DescribeApplicationSlbsRequest
         * @return DescribeApplicationSlbsResponse
         */
        public DescribeApplicationSlbsResponse DescribeApplicationSlbs(DescribeApplicationSlbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationSlbsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request DescribeApplicationSlbsRequest
         * @return DescribeApplicationSlbsResponse
         */
        public async Task<DescribeApplicationSlbsResponse> DescribeApplicationSlbsAsync(DescribeApplicationSlbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationSlbsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeApplicationStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationStatusResponse
         */
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

        /**
         * @param request DescribeApplicationStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeApplicationStatusResponse
         */
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

        /**
         * @param request DescribeApplicationStatusRequest
         * @return DescribeApplicationStatusResponse
         */
        public DescribeApplicationStatusResponse DescribeApplicationStatus(DescribeApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationStatusWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeApplicationStatusRequest
         * @return DescribeApplicationStatusResponse
         */
        public async Task<DescribeApplicationStatusResponse> DescribeApplicationStatusAsync(DescribeApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeChangeOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChangeOrderResponse
         */
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

        /**
         * @param request DescribeChangeOrderRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeChangeOrderResponse
         */
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

        /**
         * @param request DescribeChangeOrderRequest
         * @return DescribeChangeOrderResponse
         */
        public DescribeChangeOrderResponse DescribeChangeOrder(DescribeChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChangeOrderWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeChangeOrderRequest
         * @return DescribeChangeOrderResponse
         */
        public async Task<DescribeChangeOrderResponse> DescribeChangeOrderAsync(DescribeChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeComponentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentsResponse
         */
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

        /**
         * @param request DescribeComponentsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeComponentsResponse
         */
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

        /**
         * @param request DescribeComponentsRequest
         * @return DescribeComponentsResponse
         */
        public DescribeComponentsResponse DescribeComponents(DescribeComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeComponentsWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeComponentsRequest
         * @return DescribeComponentsResponse
         */
        public async Task<DescribeComponentsResponse> DescribeComponentsAsync(DescribeComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeComponentsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigMapResponse
         */
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

        /**
         * @param request DescribeConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigMapResponse
         */
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

        /**
         * @param request DescribeConfigMapRequest
         * @return DescribeConfigMapResponse
         */
        public DescribeConfigMapResponse DescribeConfigMap(DescribeConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigMapWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeConfigMapRequest
         * @return DescribeConfigMapResponse
         */
        public async Task<DescribeConfigMapResponse> DescribeConfigMapAsync(DescribeConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeConfigurationPriceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigurationPriceResponse
         */
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

        /**
         * @param request DescribeConfigurationPriceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeConfigurationPriceResponse
         */
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

        /**
         * @param request DescribeConfigurationPriceRequest
         * @return DescribeConfigurationPriceResponse
         */
        public DescribeConfigurationPriceResponse DescribeConfigurationPrice(DescribeConfigurationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigurationPriceWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeConfigurationPriceRequest
         * @return DescribeConfigurationPriceResponse
         */
        public async Task<DescribeConfigurationPriceResponse> DescribeConfigurationPriceAsync(DescribeConfigurationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigurationPriceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdasContainersResponse
         */
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

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdasContainersResponse
         */
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

        /**
         * @return DescribeEdasContainersResponse
         */
        public DescribeEdasContainersResponse DescribeEdasContainers()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdasContainersWithOptions(headers, runtime);
        }

        /**
         * @return DescribeEdasContainersResponse
         */
        public async Task<DescribeEdasContainersResponse> DescribeEdasContainersAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdasContainersWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Queries the details of a canary release rule based on the specified rule ID.
         *
         * @param request DescribeGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGreyTagRouteResponse
         */
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

        /**
         * @summary Queries the details of a canary release rule based on the specified rule ID.
         *
         * @param request DescribeGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeGreyTagRouteResponse
         */
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

        /**
         * @summary Queries the details of a canary release rule based on the specified rule ID.
         *
         * @param request DescribeGreyTagRouteRequest
         * @return DescribeGreyTagRouteResponse
         */
        public DescribeGreyTagRouteResponse DescribeGreyTagRoute(DescribeGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the details of a canary release rule based on the specified rule ID.
         *
         * @param request DescribeGreyTagRouteRequest
         * @return DescribeGreyTagRouteResponse
         */
        public async Task<DescribeGreyTagRouteResponse> DescribeGreyTagRouteAsync(DescribeGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIngressResponse
         */
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

        /**
         * @param request DescribeIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIngressResponse
         */
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

        /**
         * @param request DescribeIngressRequest
         * @return DescribeIngressResponse
         */
        public DescribeIngressResponse DescribeIngress(DescribeIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIngressWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeIngressRequest
         * @return DescribeIngressResponse
         */
        public async Task<DescribeIngressResponse> DescribeIngressAsync(DescribeIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIngressWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeInstanceLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceLogResponse
         */
        public DescribeInstanceLogResponse DescribeInstanceLogWithOptions(DescribeInstanceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @param request DescribeInstanceLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceLogResponse
         */
        public async Task<DescribeInstanceLogResponse> DescribeInstanceLogWithOptionsAsync(DescribeInstanceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        /**
         * @param request DescribeInstanceLogRequest
         * @return DescribeInstanceLogResponse
         */
        public DescribeInstanceLogResponse DescribeInstanceLog(DescribeInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceLogWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeInstanceLogRequest
         * @return DescribeInstanceLogResponse
         */
        public async Task<DescribeInstanceLogResponse> DescribeInstanceLogAsync(DescribeInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceLogWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSpecificationsResponse
         */
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

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceSpecificationsResponse
         */
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

        /**
         * @return DescribeInstanceSpecificationsResponse
         */
        public DescribeInstanceSpecificationsResponse DescribeInstanceSpecifications()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceSpecificationsWithOptions(headers, runtime);
        }

        /**
         * @return DescribeInstanceSpecificationsResponse
         */
        public async Task<DescribeInstanceSpecificationsResponse> DescribeInstanceSpecificationsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceSpecificationsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Queries the configurations of a job template.
         *
         * @param request DescribeJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobResponse
         */
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

        /**
         * @summary Queries the configurations of a job template.
         *
         * @param request DescribeJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobResponse
         */
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

        /**
         * @summary Queries the configurations of a job template.
         *
         * @param request DescribeJobRequest
         * @return DescribeJobResponse
         */
        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the configurations of a job template.
         *
         * @param request DescribeJobRequest
         * @return DescribeJobResponse
         */
        public async Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Query the information about jobs.
         *
         * @param request DescribeJobHistoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobHistoryResponse
         */
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

        /**
         * @summary Query the information about jobs.
         *
         * @param request DescribeJobHistoryRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobHistoryResponse
         */
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

        /**
         * @summary Query the information about jobs.
         *
         * @param request DescribeJobHistoryRequest
         * @return DescribeJobHistoryResponse
         */
        public DescribeJobHistoryResponse DescribeJobHistory(DescribeJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobHistoryWithOptions(request, headers, runtime);
        }

        /**
         * @summary Query the information about jobs.
         *
         * @param request DescribeJobHistoryRequest
         * @return DescribeJobHistoryResponse
         */
        public async Task<DescribeJobHistoryResponse> DescribeJobHistoryAsync(DescribeJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobHistoryWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the status of a job.
         *
         * @param request DescribeJobStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobStatusResponse
         */
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

        /**
         * @summary Queries the status of a job.
         *
         * @param request DescribeJobStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeJobStatusResponse
         */
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

        /**
         * @summary Queries the status of a job.
         *
         * @param request DescribeJobStatusRequest
         * @return DescribeJobStatusResponse
         */
        public DescribeJobStatusResponse DescribeJobStatus(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobStatusWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the status of a job.
         *
         * @param request DescribeJobStatusRequest
         * @return DescribeJobStatusResponse
         */
        public async Task<DescribeJobStatusResponse> DescribeJobStatusAsync(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobStatusWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the details of a namespace.
         *
         * @param request DescribeNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceResponse
         */
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

        /**
         * @summary Queries the details of a namespace.
         *
         * @param request DescribeNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceResponse
         */
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

        /**
         * @summary Queries the details of a namespace.
         *
         * @param request DescribeNamespaceRequest
         * @return DescribeNamespaceResponse
         */
        public DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the details of a namespace.
         *
         * @param request DescribeNamespaceRequest
         * @return DescribeNamespaceResponse
         */
        public async Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of namespaces.
         *
         * @param request DescribeNamespaceListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceListResponse
         */
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

        /**
         * @summary Queries a list of namespaces.
         *
         * @param request DescribeNamespaceListRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceListResponse
         */
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

        /**
         * @summary Queries a list of namespaces.
         *
         * @param request DescribeNamespaceListRequest
         * @return DescribeNamespaceListResponse
         */
        public DescribeNamespaceListResponse DescribeNamespaceList(DescribeNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceListWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of namespaces.
         *
         * @param request DescribeNamespaceListRequest
         * @return DescribeNamespaceListResponse
         */
        public async Task<DescribeNamespaceListResponse> DescribeNamespaceListAsync(DescribeNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceListWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request DescribeNamespaceResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceResourcesResponse
         */
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

        /**
         * @param request DescribeNamespaceResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespaceResourcesResponse
         */
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

        /**
         * @param request DescribeNamespaceResourcesRequest
         * @return DescribeNamespaceResourcesResponse
         */
        public DescribeNamespaceResourcesResponse DescribeNamespaceResources(DescribeNamespaceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @param request DescribeNamespaceResourcesRequest
         * @return DescribeNamespaceResourcesResponse
         */
        public async Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResourcesAsync(DescribeNamespaceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the details of namespaces.
         *
         * @param request DescribeNamespacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespacesResponse
         */
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

        /**
         * @summary Queries the details of namespaces.
         *
         * @param request DescribeNamespacesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNamespacesResponse
         */
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

        /**
         * @summary Queries the details of namespaces.
         *
         * @param request DescribeNamespacesRequest
         * @return DescribeNamespacesResponse
         */
        public DescribeNamespacesResponse DescribeNamespaces(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespacesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the details of namespaces.
         *
         * @param request DescribeNamespacesRequest
         * @return DescribeNamespacesResponse
         */
        public async Task<DescribeNamespacesResponse> DescribeNamespacesAsync(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespacesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information of a batch.
         *
         * @param request DescribePipelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePipelineResponse
         */
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

        /**
         * @summary Queries the information of a batch.
         *
         * @param request DescribePipelineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePipelineResponse
         */
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

        /**
         * @summary Queries the information of a batch.
         *
         * @param request DescribePipelineRequest
         * @return DescribePipelineResponse
         */
        public DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePipelineWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information of a batch.
         *
         * @param request DescribePipelineRequest
         * @return DescribePipelineResponse
         */
        public async Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePipelineWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries available regions.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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

        /**
         * @summary Queries available regions.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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

        /**
         * @summary Queries available regions.
         *
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        /**
         * @summary Queries available regions.
         *
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Queries the details of a Secret instance.
         *
         * @param request DescribeSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecretResponse
         */
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

        /**
         * @summary Queries the details of a Secret instance.
         *
         * @param request DescribeSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSecretResponse
         */
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

        /**
         * @summary Queries the details of a Secret instance.
         *
         * @param request DescribeSecretRequest
         * @return DescribeSecretResponse
         */
        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSecretWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the details of a Secret instance.
         *
         * @param request DescribeSecretRequest
         * @return DescribeSecretResponse
         */
        public async Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSecretWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 获取应用信息
         *
         * @param request DescribeWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationResponse
         */
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

        /**
         * @summary 获取应用信息
         *
         * @param request DescribeWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationResponse
         */
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

        /**
         * @summary 获取应用信息
         *
         * @param request DescribeWebApplicationRequest
         * @return DescribeWebApplicationResponse
         */
        public DescribeWebApplicationResponse DescribeWebApplication(string ApplicationId, DescribeWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 获取应用信息
         *
         * @param request DescribeWebApplicationRequest
         * @return DescribeWebApplicationResponse
         */
        public async Task<DescribeWebApplicationResponse> DescribeWebApplicationAsync(string ApplicationId, DescribeWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 应用资源用量统计
         *
         * @param request DescribeWebApplicationResourceStaticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationResourceStaticsResponse
         */
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

        /**
         * @summary 应用资源用量统计
         *
         * @param request DescribeWebApplicationResourceStaticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationResourceStaticsResponse
         */
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

        /**
         * @summary 应用资源用量统计
         *
         * @param request DescribeWebApplicationResourceStaticsRequest
         * @return DescribeWebApplicationResourceStaticsResponse
         */
        public DescribeWebApplicationResourceStaticsResponse DescribeWebApplicationResourceStatics(string ApplicationId, DescribeWebApplicationResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationResourceStaticsWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 应用资源用量统计
         *
         * @param request DescribeWebApplicationResourceStaticsRequest
         * @return DescribeWebApplicationResourceStaticsResponse
         */
        public async Task<DescribeWebApplicationResourceStaticsResponse> DescribeWebApplicationResourceStaticsAsync(string ApplicationId, DescribeWebApplicationResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationResourceStaticsWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 获取应用版本
         *
         * @param request DescribeWebApplicationRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationRevisionResponse
         */
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

        /**
         * @summary 获取应用版本
         *
         * @param request DescribeWebApplicationRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationRevisionResponse
         */
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

        /**
         * @summary 获取应用版本
         *
         * @param request DescribeWebApplicationRevisionRequest
         * @return DescribeWebApplicationRevisionResponse
         */
        public DescribeWebApplicationRevisionResponse DescribeWebApplicationRevision(string ApplicationId, string RevisionId, DescribeWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationRevisionWithOptions(ApplicationId, RevisionId, request, headers, runtime);
        }

        /**
         * @summary 获取应用版本
         *
         * @param request DescribeWebApplicationRevisionRequest
         * @return DescribeWebApplicationRevisionResponse
         */
        public async Task<DescribeWebApplicationRevisionResponse> DescribeWebApplicationRevisionAsync(string ApplicationId, string RevisionId, DescribeWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationRevisionWithOptionsAsync(ApplicationId, RevisionId, request, headers, runtime);
        }

        /**
         * @summary 弹性配置详情
         *
         * @param request DescribeWebApplicationScalingConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationScalingConfigResponse
         */
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

        /**
         * @summary 弹性配置详情
         *
         * @param request DescribeWebApplicationScalingConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationScalingConfigResponse
         */
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

        /**
         * @summary 弹性配置详情
         *
         * @param request DescribeWebApplicationScalingConfigRequest
         * @return DescribeWebApplicationScalingConfigResponse
         */
        public DescribeWebApplicationScalingConfigResponse DescribeWebApplicationScalingConfig(string ApplicationId, DescribeWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationScalingConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 弹性配置详情
         *
         * @param request DescribeWebApplicationScalingConfigRequest
         * @return DescribeWebApplicationScalingConfigResponse
         */
        public async Task<DescribeWebApplicationScalingConfigResponse> DescribeWebApplicationScalingConfigAsync(string ApplicationId, DescribeWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationScalingConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 流量配置详情
         *
         * @param request DescribeWebApplicationTrafficConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationTrafficConfigResponse
         */
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

        /**
         * @summary 流量配置详情
         *
         * @param request DescribeWebApplicationTrafficConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebApplicationTrafficConfigResponse
         */
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

        /**
         * @summary 流量配置详情
         *
         * @param request DescribeWebApplicationTrafficConfigRequest
         * @return DescribeWebApplicationTrafficConfigResponse
         */
        public DescribeWebApplicationTrafficConfigResponse DescribeWebApplicationTrafficConfig(string ApplicationId, DescribeWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebApplicationTrafficConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 流量配置详情
         *
         * @param request DescribeWebApplicationTrafficConfigRequest
         * @return DescribeWebApplicationTrafficConfigResponse
         */
        public async Task<DescribeWebApplicationTrafficConfigResponse> DescribeWebApplicationTrafficConfigAsync(string ApplicationId, DescribeWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebApplicationTrafficConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 获取域名.
         *
         * @param request DescribeWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebCustomDomainResponse
         */
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

        /**
         * @summary 获取域名.
         *
         * @param request DescribeWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebCustomDomainResponse
         */
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

        /**
         * @summary 获取域名.
         *
         * @param request DescribeWebCustomDomainRequest
         * @return DescribeWebCustomDomainResponse
         */
        public DescribeWebCustomDomainResponse DescribeWebCustomDomain(string DomainName, DescribeWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebCustomDomainWithOptions(DomainName, request, headers, runtime);
        }

        /**
         * @summary 获取域名.
         *
         * @param request DescribeWebCustomDomainRequest
         * @return DescribeWebCustomDomainResponse
         */
        public async Task<DescribeWebCustomDomainResponse> DescribeWebCustomDomainAsync(string DomainName, DescribeWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebCustomDomainWithOptionsAsync(DomainName, request, headers, runtime);
        }

        /**
         * @summary 应用实例日志
         *
         * @param request DescribeWebInstanceLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebInstanceLogsResponse
         */
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

        /**
         * @summary 应用实例日志
         *
         * @param request DescribeWebInstanceLogsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWebInstanceLogsResponse
         */
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

        /**
         * @summary 应用实例日志
         *
         * @param request DescribeWebInstanceLogsRequest
         * @return DescribeWebInstanceLogsResponse
         */
        public DescribeWebInstanceLogsResponse DescribeWebInstanceLogs(string ApplicationId, string InstanceId, DescribeWebInstanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWebInstanceLogsWithOptions(ApplicationId, InstanceId, request, headers, runtime);
        }

        /**
         * @summary 应用实例日志
         *
         * @param request DescribeWebInstanceLogsRequest
         * @return DescribeWebInstanceLogsResponse
         */
        public async Task<DescribeWebInstanceLogsResponse> DescribeWebInstanceLogsAsync(string ApplicationId, string InstanceId, DescribeWebInstanceLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWebInstanceLogsWithOptionsAsync(ApplicationId, InstanceId, request, headers, runtime);
        }

        /**
         * @param request DisableApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationScalingRuleResponse
         */
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

        /**
         * @param request DisableApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableApplicationScalingRuleResponse
         */
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

        /**
         * @param request DisableApplicationScalingRuleRequest
         * @return DisableApplicationScalingRuleResponse
         */
        public DisableApplicationScalingRuleResponse DisableApplicationScalingRule(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
         * @param request DisableApplicationScalingRuleRequest
         * @return DisableApplicationScalingRuleResponse
         */
        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleAsync(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Enables an auto scaling policy for an application.
         *
         * @param request EnableApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationScalingRuleResponse
         */
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

        /**
         * @summary Enables an auto scaling policy for an application.
         *
         * @param request EnableApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableApplicationScalingRuleResponse
         */
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

        /**
         * @summary Enables an auto scaling policy for an application.
         *
         * @param request EnableApplicationScalingRuleRequest
         * @return EnableApplicationScalingRuleResponse
         */
        public EnableApplicationScalingRuleResponse EnableApplicationScalingRule(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary Enables an auto scaling policy for an application.
         *
         * @param request EnableApplicationScalingRuleRequest
         * @return EnableApplicationScalingRuleResponse
         */
        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleAsync(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request ExecJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecJobResponse
         */
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

        /**
         * @param request ExecJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecJobResponse
         */
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

        /**
         * @param request ExecJobRequest
         * @return ExecJobResponse
         */
        public ExecJobResponse ExecJob(ExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecJobWithOptions(request, headers, runtime);
        }

        /**
         * @param request ExecJobRequest
         * @return ExecJobResponse
         */
        public async Task<ExecJobResponse> ExecJobAsync(ExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in Application Monitoring.
         *
         * @param request GetArmsTopNMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetArmsTopNMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in Application Monitoring.
         *
         * @param request GetArmsTopNMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetArmsTopNMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in Application Monitoring.
         *
         * @param request GetArmsTopNMetricRequest
         * @return GetArmsTopNMetricResponse
         */
        public GetArmsTopNMetricResponse GetArmsTopNMetric(GetArmsTopNMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetArmsTopNMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in Application Monitoring.
         *
         * @param request GetArmsTopNMetricRequest
         * @return GetArmsTopNMetricResponse
         */
        public async Task<GetArmsTopNMetricResponse> GetArmsTopNMetricAsync(GetArmsTopNMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetArmsTopNMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.
         *
         * @param request GetAvailabilityMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAvailabilityMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.
         *
         * @param request GetAvailabilityMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAvailabilityMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.
         *
         * @param request GetAvailabilityMetricRequest
         * @return GetAvailabilityMetricResponse
         */
        public GetAvailabilityMetricResponse GetAvailabilityMetric(GetAvailabilityMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAvailabilityMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in which abnormal instances exist. The applications are sorted by the total number of abnormal instances.
         *
         * @param request GetAvailabilityMetricRequest
         * @return GetAvailabilityMetricResponse
         */
        public async Task<GetAvailabilityMetricResponse> GetAvailabilityMetricAsync(GetAvailabilityMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAvailabilityMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries top N applications in abnormal change orders.
         *
         * @param request GetChangeOrderMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChangeOrderMetricResponse
         */
        public GetChangeOrderMetricResponse GetChangeOrderMetricWithOptions(GetChangeOrderMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Queries top N applications in abnormal change orders.
         *
         * @param request GetChangeOrderMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetChangeOrderMetricResponse
         */
        public async Task<GetChangeOrderMetricResponse> GetChangeOrderMetricWithOptionsAsync(GetChangeOrderMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Queries top N applications in abnormal change orders.
         *
         * @param request GetChangeOrderMetricRequest
         * @return GetChangeOrderMetricResponse
         */
        public GetChangeOrderMetricResponse GetChangeOrderMetric(GetChangeOrderMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChangeOrderMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries top N applications in abnormal change orders.
         *
         * @param request GetChangeOrderMetricRequest
         * @return GetChangeOrderMetricResponse
         */
        public async Task<GetChangeOrderMetricResponse> GetChangeOrderMetricAsync(GetChangeOrderMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChangeOrderMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in which auto scaling takes effect.
         *
         * @param request GetScaleAppMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScaleAppMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in which auto scaling takes effect.
         *
         * @param request GetScaleAppMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScaleAppMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in which auto scaling takes effect.
         *
         * @param request GetScaleAppMetricRequest
         * @return GetScaleAppMetricResponse
         */
        public GetScaleAppMetricResponse GetScaleAppMetric(GetScaleAppMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScaleAppMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in which auto scaling takes effect.
         *
         * @param request GetScaleAppMetricRequest
         * @return GetScaleAppMetricResponse
         */
        public async Task<GetScaleAppMetricResponse> GetScaleAppMetricAsync(GetScaleAppMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScaleAppMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in which Warning events occur.
         *
         * @param request GetWarningEventMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWarningEventMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in which Warning events occur.
         *
         * @param request GetWarningEventMetricRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetWarningEventMetricResponse
         */
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

        /**
         * @summary Queries the top N applications in which Warning events occur.
         *
         * @param request GetWarningEventMetricRequest
         * @return GetWarningEventMetricResponse
         */
        public GetWarningEventMetricResponse GetWarningEventMetric(GetWarningEventMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWarningEventMetricWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the top N applications in which Warning events occur.
         *
         * @param request GetWarningEventMetricRequest
         * @return GetWarningEventMetricResponse
         */
        public async Task<GetWarningEventMetricResponse> GetWarningEventMetricAsync(GetWarningEventMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWarningEventMetricWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the events that occurred in an application.
         *
         * @param request ListAppEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppEventsResponse
         */
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

        /**
         * @summary Queries the events that occurred in an application.
         *
         * @param request ListAppEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppEventsResponse
         */
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

        /**
         * @summary Queries the events that occurred in an application.
         *
         * @param request ListAppEventsRequest
         * @return ListAppEventsResponse
         */
        public ListAppEventsResponse ListAppEvents(ListAppEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppEventsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the events that occurred in an application.
         *
         * @param request ListAppEventsRequest
         * @return ListAppEventsResponse
         */
        public async Task<ListAppEventsResponse> ListAppEventsAsync(ListAppEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppEventsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 6dcc8c9e-d3da-478a-a066-86dcf820\\*\\*\\*\\*
         *
         * @param request ListAppServicesPageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppServicesPageResponse
         */
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

        /**
         * @summary 6dcc8c9e-d3da-478a-a066-86dcf820\\*\\*\\*\\*
         *
         * @param request ListAppServicesPageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppServicesPageResponse
         */
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

        /**
         * @summary 6dcc8c9e-d3da-478a-a066-86dcf820\\*\\*\\*\\*
         *
         * @param request ListAppServicesPageRequest
         * @return ListAppServicesPageResponse
         */
        public ListAppServicesPageResponse ListAppServicesPage(ListAppServicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppServicesPageWithOptions(request, headers, runtime);
        }

        /**
         * @summary 6dcc8c9e-d3da-478a-a066-86dcf820\\*\\*\\*\\*
         *
         * @param request ListAppServicesPageRequest
         * @return ListAppServicesPageResponse
         */
        public async Task<ListAppServicesPageResponse> ListAppServicesPageAsync(ListAppServicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppServicesPageWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request ListAppVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppVersionsResponse
         */
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

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request ListAppVersionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAppVersionsResponse
         */
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

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request ListAppVersionsRequest
         * @return ListAppVersionsResponse
         */
        public ListAppVersionsResponse ListAppVersions(ListAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppVersionsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 7171a6ca-d1cd-4928-8642-7d5cfe69\\*\\*\\*\\*
         *
         * @param request ListAppVersionsRequest
         * @return ListAppVersionsResponse
         */
        public async Task<ListAppVersionsResponse> ListAppVersionsAsync(ListAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppVersionsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary The ID of the namespace.
         *
         * @param request ListApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsResponse
         */
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

        /**
         * @summary The ID of the namespace.
         *
         * @param request ListApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsResponse
         */
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

        /**
         * @summary The ID of the namespace.
         *
         * @param request ListApplicationsRequest
         * @return ListApplicationsResponse
         */
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApplicationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary The ID of the namespace.
         *
         * @param request ListApplicationsRequest
         * @return ListApplicationsResponse
         */
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request ListChangeOrdersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChangeOrdersResponse
         */
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

        /**
         * @param request ListChangeOrdersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListChangeOrdersResponse
         */
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

        /**
         * @param request ListChangeOrdersRequest
         * @return ListChangeOrdersResponse
         */
        public ListChangeOrdersResponse ListChangeOrders(ListChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChangeOrdersWithOptions(request, headers, runtime);
        }

        /**
         * @param request ListChangeOrdersRequest
         * @return ListChangeOrdersResponse
         */
        public async Task<ListChangeOrdersResponse> ListChangeOrdersAsync(ListChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChangeOrdersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListConsumedServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumedServicesResponse
         */
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

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListConsumedServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumedServicesResponse
         */
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

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListConsumedServicesRequest
         * @return ListConsumedServicesResponse
         */
        public ListConsumedServicesResponse ListConsumedServices(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumedServicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListConsumedServicesRequest
         * @return ListConsumedServicesResponse
         */
        public async Task<ListConsumedServicesResponse> ListConsumedServicesAsync(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumedServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the details of a canary release rule based on an application ID.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request ListGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGreyTagRouteResponse
         */
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

        /**
         * @summary Queries the details of a canary release rule based on an application ID.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request ListGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGreyTagRouteResponse
         */
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

        /**
         * @summary Queries the details of a canary release rule based on an application ID.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request ListGreyTagRouteRequest
         * @return ListGreyTagRouteResponse
         */
        public ListGreyTagRouteResponse ListGreyTagRoute(ListGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the details of a canary release rule based on an application ID.
         *
         * @description >  You can configure only one canary release rule for each application.
         *
         * @param request ListGreyTagRouteRequest
         * @return ListGreyTagRouteResponse
         */
        public async Task<ListGreyTagRouteResponse> ListGreyTagRouteAsync(ListGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary The returned message.
         * *   **success** is returned when the request succeeds.
         * *   An error code is returned when the request fails.
         *
         * @param request ListIngressesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIngressesResponse
         */
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

        /**
         * @summary The returned message.
         * *   **success** is returned when the request succeeds.
         * *   An error code is returned when the request fails.
         *
         * @param request ListIngressesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListIngressesResponse
         */
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

        /**
         * @summary The returned message.
         * *   **success** is returned when the request succeeds.
         * *   An error code is returned when the request fails.
         *
         * @param request ListIngressesRequest
         * @return ListIngressesResponse
         */
        public ListIngressesResponse ListIngresses(ListIngressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIngressesWithOptions(request, headers, runtime);
        }

        /**
         * @summary The returned message.
         * *   **success** is returned when the request succeeds.
         * *   An error code is returned when the request fails.
         *
         * @param request ListIngressesRequest
         * @return ListIngressesResponse
         */
        public async Task<ListIngressesResponse> ListIngressesAsync(ListIngressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIngressesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about job templates.
         *
         * @param request ListJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
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

        /**
         * @summary Queries the information about job templates.
         *
         * @param request ListJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListJobsResponse
         */
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

        /**
         * @summary Queries the information about job templates.
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about job templates.
         *
         * @param request ListJobsRequest
         * @return ListJobsResponse
         */
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 56f77b65-788d-442a-9885-7f20d91f\\*\\*\\*\\*
         *
         * @param request ListLogConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogConfigsResponse
         */
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

        /**
         * @summary 56f77b65-788d-442a-9885-7f20d91f\\*\\*\\*\\*
         *
         * @param request ListLogConfigsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogConfigsResponse
         */
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

        /**
         * @summary 56f77b65-788d-442a-9885-7f20d91f\\*\\*\\*\\*
         *
         * @param request ListLogConfigsRequest
         * @return ListLogConfigsResponse
         */
        public ListLogConfigsResponse ListLogConfigs(ListLogConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogConfigsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 56f77b65-788d-442a-9885-7f20d91f\\*\\*\\*\\*
         *
         * @param request ListLogConfigsRequest
         * @return ListLogConfigsResponse
         */
        public async Task<ListLogConfigsResponse> ListLogConfigsAsync(ListLogConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogConfigsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request ListNamespaceChangeOrdersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNamespaceChangeOrdersResponse
         */
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

        /**
         * @param request ListNamespaceChangeOrdersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNamespaceChangeOrdersResponse
         */
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

        /**
         * @param request ListNamespaceChangeOrdersRequest
         * @return ListNamespaceChangeOrdersResponse
         */
        public ListNamespaceChangeOrdersResponse ListNamespaceChangeOrders(ListNamespaceChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespaceChangeOrdersWithOptions(request, headers, runtime);
        }

        /**
         * @param request ListNamespaceChangeOrdersRequest
         * @return ListNamespaceChangeOrdersResponse
         */
        public async Task<ListNamespaceChangeOrdersResponse> ListNamespaceChangeOrdersAsync(ListNamespaceChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespaceChangeOrdersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the ConfigMap instances in a namespace.
         *
         * @param request ListNamespacedConfigMapsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNamespacedConfigMapsResponse
         */
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

        /**
         * @summary Queries the ConfigMap instances in a namespace.
         *
         * @param request ListNamespacedConfigMapsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNamespacedConfigMapsResponse
         */
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

        /**
         * @summary Queries the ConfigMap instances in a namespace.
         *
         * @param request ListNamespacedConfigMapsRequest
         * @return ListNamespacedConfigMapsResponse
         */
        public ListNamespacedConfigMapsResponse ListNamespacedConfigMaps(ListNamespacedConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespacedConfigMapsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the ConfigMap instances in a namespace.
         *
         * @param request ListNamespacedConfigMapsRequest
         * @return ListNamespacedConfigMapsResponse
         */
        public async Task<ListNamespacedConfigMapsResponse> ListNamespacedConfigMapsAsync(ListNamespacedConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespacedConfigMapsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListPublishedServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublishedServicesResponse
         */
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

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListPublishedServicesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListPublishedServicesResponse
         */
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

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListPublishedServicesRequest
         * @return ListPublishedServicesResponse
         */
        public ListPublishedServicesResponse ListPublishedServices(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPublishedServicesWithOptions(request, headers, runtime);
        }

        /**
         * @summary b2a8a925-477a-4ed7-b825-d5e22500\\*\\*\\*\\*
         *
         * @param request ListPublishedServicesRequest
         * @return ListPublishedServicesResponse
         */
        public async Task<ListPublishedServicesResponse> ListPublishedServicesAsync(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPublishedServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the information about Secrets in a namespace.
         *
         * @param request ListSecretsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSecretsResponse
         */
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

        /**
         * @summary Queries the information about Secrets in a namespace.
         *
         * @param request ListSecretsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSecretsResponse
         */
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

        /**
         * @summary Queries the information about Secrets in a namespace.
         *
         * @param request ListSecretsRequest
         * @return ListSecretsResponse
         */
        public ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSecretsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the information about Secrets in a namespace.
         *
         * @param request ListSecretsRequest
         * @return ListSecretsResponse
         */
        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSecretsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the mapping relationships between applications and tags.
         *
         * @param request ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
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

        /**
         * @summary Queries the mapping relationships between applications and tags.
         *
         * @param request ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
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

        /**
         * @summary Queries the mapping relationships between applications and tags.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the mapping relationships between applications and tags.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 应用实例列表
         *
         * @param tmpReq ListWebApplicationInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebApplicationInstancesResponse
         */
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

        /**
         * @summary 应用实例列表
         *
         * @param tmpReq ListWebApplicationInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebApplicationInstancesResponse
         */
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

        /**
         * @summary 应用实例列表
         *
         * @param request ListWebApplicationInstancesRequest
         * @return ListWebApplicationInstancesResponse
         */
        public ListWebApplicationInstancesResponse ListWebApplicationInstances(string ApplicationId, ListWebApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebApplicationInstancesWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 应用实例列表
         *
         * @param request ListWebApplicationInstancesRequest
         * @return ListWebApplicationInstancesResponse
         */
        public async Task<ListWebApplicationInstancesResponse> ListWebApplicationInstancesAsync(string ApplicationId, ListWebApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebApplicationInstancesWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 版本列表
         *
         * @param request ListWebApplicationRevisionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebApplicationRevisionsResponse
         */
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

        /**
         * @summary 版本列表
         *
         * @param request ListWebApplicationRevisionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebApplicationRevisionsResponse
         */
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

        /**
         * @summary 版本列表
         *
         * @param request ListWebApplicationRevisionsRequest
         * @return ListWebApplicationRevisionsResponse
         */
        public ListWebApplicationRevisionsResponse ListWebApplicationRevisions(string ApplicationId, ListWebApplicationRevisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebApplicationRevisionsWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 版本列表
         *
         * @param request ListWebApplicationRevisionsRequest
         * @return ListWebApplicationRevisionsResponse
         */
        public async Task<ListWebApplicationRevisionsResponse> ListWebApplicationRevisionsAsync(string ApplicationId, ListWebApplicationRevisionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebApplicationRevisionsWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 应用列表
         *
         * @param request ListWebApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebApplicationsResponse
         */
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

        /**
         * @summary 应用列表
         *
         * @param request ListWebApplicationsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebApplicationsResponse
         */
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

        /**
         * @summary 应用列表
         *
         * @param request ListWebApplicationsRequest
         * @return ListWebApplicationsResponse
         */
        public ListWebApplicationsResponse ListWebApplications(ListWebApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebApplicationsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 应用列表
         *
         * @param request ListWebApplicationsRequest
         * @return ListWebApplicationsResponse
         */
        public async Task<ListWebApplicationsResponse> ListWebApplicationsAsync(ListWebApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebApplicationsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 自定义域名列表.
         *
         * @param request ListWebCustomDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebCustomDomainsResponse
         */
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

        /**
         * @summary 自定义域名列表.
         *
         * @param request ListWebCustomDomainsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListWebCustomDomainsResponse
         */
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

        /**
         * @summary 自定义域名列表.
         *
         * @param request ListWebCustomDomainsRequest
         * @return ListWebCustomDomainsResponse
         */
        public ListWebCustomDomainsResponse ListWebCustomDomains(ListWebCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListWebCustomDomainsWithOptions(request, headers, runtime);
        }

        /**
         * @summary 自定义域名列表.
         *
         * @param request ListWebCustomDomainsRequest
         * @return ListWebCustomDomainsResponse
         */
        public async Task<ListWebCustomDomainsResponse> ListWebCustomDomainsAsync(ListWebCustomDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListWebCustomDomainsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Activates the Serverless App Engine (SAE) service for free.
         *
         * @description > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenSaeServiceResponse
         */
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

        /**
         * @summary Activates the Serverless App Engine (SAE) service for free.
         *
         * @description > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenSaeServiceResponse
         */
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

        /**
         * @summary Activates the Serverless App Engine (SAE) service for free.
         *
         * @description > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
         *
         * @return OpenSaeServiceResponse
         */
        public OpenSaeServiceResponse OpenSaeService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenSaeServiceWithOptions(headers, runtime);
        }

        /**
         * @summary Activates the Serverless App Engine (SAE) service for free.
         *
         * @description > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
         *
         * @return OpenSaeServiceResponse
         */
        public async Task<OpenSaeServiceResponse> OpenSaeServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenSaeServiceWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 新建版本
         *
         * @param request PublishWebApplicationRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishWebApplicationRevisionResponse
         */
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

        /**
         * @summary 新建版本
         *
         * @param request PublishWebApplicationRevisionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PublishWebApplicationRevisionResponse
         */
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

        /**
         * @summary 新建版本
         *
         * @param request PublishWebApplicationRevisionRequest
         * @return PublishWebApplicationRevisionResponse
         */
        public PublishWebApplicationRevisionResponse PublishWebApplicationRevision(string ApplicationId, PublishWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PublishWebApplicationRevisionWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 新建版本
         *
         * @param request PublishWebApplicationRevisionRequest
         * @return PublishWebApplicationRevisionResponse
         */
        public async Task<PublishWebApplicationRevisionResponse> PublishWebApplicationRevisionAsync(string ApplicationId, PublishWebApplicationRevisionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PublishWebApplicationRevisionWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary Queries the resource usage of an application.
         *
         * @param request QueryResourceStaticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResourceStaticsResponse
         */
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

        /**
         * @summary Queries the resource usage of an application.
         *
         * @param request QueryResourceStaticsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryResourceStaticsResponse
         */
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

        /**
         * @summary Queries the resource usage of an application.
         *
         * @param request QueryResourceStaticsRequest
         * @return QueryResourceStaticsResponse
         */
        public QueryResourceStaticsResponse QueryResourceStatics(QueryResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryResourceStaticsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the resource usage of an application.
         *
         * @param request QueryResourceStaticsRequest
         * @return QueryResourceStaticsResponse
         */
        public async Task<QueryResourceStaticsResponse> QueryResourceStaticsAsync(QueryResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryResourceStaticsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Reduces capacity by instance IDs.
         *
         * @param request ReduceApplicationCapacityByInstanceIdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReduceApplicationCapacityByInstanceIdsResponse
         */
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

        /**
         * @summary Reduces capacity by instance IDs.
         *
         * @param request ReduceApplicationCapacityByInstanceIdsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReduceApplicationCapacityByInstanceIdsResponse
         */
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

        /**
         * @summary Reduces capacity by instance IDs.
         *
         * @param request ReduceApplicationCapacityByInstanceIdsRequest
         * @return ReduceApplicationCapacityByInstanceIdsResponse
         */
        public ReduceApplicationCapacityByInstanceIdsResponse ReduceApplicationCapacityByInstanceIds(ReduceApplicationCapacityByInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReduceApplicationCapacityByInstanceIdsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Reduces capacity by instance IDs.
         *
         * @param request ReduceApplicationCapacityByInstanceIdsRequest
         * @return ReduceApplicationCapacityByInstanceIdsResponse
         */
        public async Task<ReduceApplicationCapacityByInstanceIdsResponse> ReduceApplicationCapacityByInstanceIdsAsync(ReduceApplicationCapacityByInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReduceApplicationCapacityByInstanceIdsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Scales an application.
         *
         * @param request RescaleApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RescaleApplicationResponse
         */
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

        /**
         * @summary Scales an application.
         *
         * @param request RescaleApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RescaleApplicationResponse
         */
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

        /**
         * @summary Scales an application.
         *
         * @param request RescaleApplicationRequest
         * @return RescaleApplicationResponse
         */
        public RescaleApplicationResponse RescaleApplication(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RescaleApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary Scales an application.
         *
         * @param request RescaleApplicationRequest
         * @return RescaleApplicationResponse
         */
        public async Task<RescaleApplicationResponse> RescaleApplicationAsync(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RescaleApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Changes the instance specifications of an application.
         *
         * @param request RescaleApplicationVerticallyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RescaleApplicationVerticallyResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
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

        /**
         * @summary Changes the instance specifications of an application.
         *
         * @param request RescaleApplicationVerticallyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RescaleApplicationVerticallyResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
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

        /**
         * @summary Changes the instance specifications of an application.
         *
         * @param request RescaleApplicationVerticallyRequest
         * @return RescaleApplicationVerticallyResponse
         */
        public RescaleApplicationVerticallyResponse RescaleApplicationVertically(RescaleApplicationVerticallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RescaleApplicationVerticallyWithOptions(request, headers, runtime);
        }

        /**
         * @summary Changes the instance specifications of an application.
         *
         * @param request RescaleApplicationVerticallyRequest
         * @return RescaleApplicationVerticallyResponse
         */
        public async Task<RescaleApplicationVerticallyResponse> RescaleApplicationVerticallyAsync(RescaleApplicationVerticallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RescaleApplicationVerticallyWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Restarts an application.
         *
         * @param request RestartApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartApplicationResponse
         */
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

        /**
         * @summary Restarts an application.
         *
         * @param request RestartApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartApplicationResponse
         */
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

        /**
         * @summary Restarts an application.
         *
         * @param request RestartApplicationRequest
         * @return RestartApplicationResponse
         */
        public RestartApplicationResponse RestartApplication(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary Restarts an application.
         *
         * @param request RestartApplicationRequest
         * @return RestartApplicationResponse
         */
        public async Task<RestartApplicationResponse> RestartApplicationAsync(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Restarts one or more instances in an application.
         *
         * @param request RestartInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartInstancesResponse
         */
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

        /**
         * @summary Restarts one or more instances in an application.
         *
         * @param request RestartInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartInstancesResponse
         */
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

        /**
         * @summary Restarts one or more instances in an application.
         *
         * @param request RestartInstancesRequest
         * @return RestartInstancesResponse
         */
        public RestartInstancesResponse RestartInstances(RestartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Restarts one or more instances in an application.
         *
         * @param request RestartInstancesRequest
         * @return RestartInstancesResponse
         */
        public async Task<RestartInstancesResponse> RestartInstancesAsync(RestartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Rolls back an application.
         *
         * @param request RollbackApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackApplicationResponse
         */
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

        /**
         * @summary Rolls back an application.
         *
         * @param request RollbackApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RollbackApplicationResponse
         */
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

        /**
         * @summary Rolls back an application.
         *
         * @param request RollbackApplicationRequest
         * @return RollbackApplicationResponse
         */
        public RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary Rolls back an application.
         *
         * @param request RollbackApplicationRequest
         * @return RollbackApplicationResponse
         */
        public async Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Starts an application.
         *
         * @param request StartApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartApplicationResponse
         */
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

        /**
         * @summary Starts an application.
         *
         * @param request StartApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartApplicationResponse
         */
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

        /**
         * @summary Starts an application.
         *
         * @param request StartApplicationRequest
         * @return StartApplicationResponse
         */
        public StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary Starts an application.
         *
         * @param request StartApplicationRequest
         * @return StartApplicationResponse
         */
        public async Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 启动应用
         *
         * @param request StartWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartWebApplicationResponse
         */
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

        /**
         * @summary 启动应用
         *
         * @param request StartWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartWebApplicationResponse
         */
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

        /**
         * @summary 启动应用
         *
         * @param request StartWebApplicationRequest
         * @return StartWebApplicationResponse
         */
        public StartWebApplicationResponse StartWebApplication(string ApplicationId, StartWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 启动应用
         *
         * @param request StartWebApplicationRequest
         * @return StartWebApplicationResponse
         */
        public async Task<StartWebApplicationResponse> StartWebApplicationAsync(string ApplicationId, StartWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request StopApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopApplicationResponse
         */
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

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request StopApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopApplicationResponse
         */
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

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request StopApplicationRequest
         * @return StopApplicationResponse
         */
        public StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopApplicationWithOptions(request, headers, runtime);
        }

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request StopApplicationRequest
         * @return StopApplicationResponse
         */
        public async Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 停止应用
         *
         * @param request StopWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopWebApplicationResponse
         */
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

        /**
         * @summary 停止应用
         *
         * @param request StopWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopWebApplicationResponse
         */
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

        /**
         * @summary 停止应用
         *
         * @param request StopWebApplicationRequest
         * @return StopWebApplicationResponse
         */
        public StopWebApplicationResponse StopWebApplication(string ApplicationId, StopWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 停止应用
         *
         * @param request StopWebApplicationRequest
         * @return StopWebApplicationResponse
         */
        public async Task<StopWebApplicationResponse> StopWebApplicationAsync(string ApplicationId, StopWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary Suspends a job.
         *
         * @param request SuspendJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendJobResponse
         */
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

        /**
         * @summary Suspends a job.
         *
         * @param request SuspendJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SuspendJobResponse
         */
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

        /**
         * @summary Suspends a job.
         *
         * @param request SuspendJobRequest
         * @return SuspendJobResponse
         */
        public SuspendJobResponse SuspendJob(SuspendJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SuspendJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary Suspends a job.
         *
         * @param request SuspendJobRequest
         * @return SuspendJobResponse
         */
        public async Task<SuspendJobResponse> SuspendJobAsync(SuspendJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SuspendJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary cn-beijing
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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

        /**
         * @summary cn-beijing
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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

        /**
         * @summary cn-beijing
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary cn-beijing
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request UnbindSlbRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindSlbResponse
         */
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

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request UnbindSlbRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnbindSlbResponse
         */
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

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request UnbindSlbRequest
         * @return UnbindSlbResponse
         */
        public UnbindSlbResponse UnbindSlb(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindSlbWithOptions(request, headers, runtime);
        }

        /**
         * @summary 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
         *
         * @param request UnbindSlbRequest
         * @return UnbindSlbResponse
         */
        public async Task<UnbindSlbResponse> UnbindSlbAsync(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindSlbWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
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

        /**
         * @param request UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
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

        /**
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request UpdateAppSecurityGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppSecurityGroupResponse
         */
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

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request UpdateAppSecurityGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAppSecurityGroupResponse
         */
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

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request UpdateAppSecurityGroupRequest
         * @return UpdateAppSecurityGroupResponse
         */
        public UpdateAppSecurityGroupResponse UpdateAppSecurityGroup(UpdateAppSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppSecurityGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 017f39b8-dfa4-4e16-a84b-1dcee4b1\\*\\*\\*\\*
         *
         * @param request UpdateAppSecurityGroupRequest
         * @return UpdateAppSecurityGroupResponse
         */
        public async Task<UpdateAppSecurityGroupResponse> UpdateAppSecurityGroupAsync(UpdateAppSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppSecurityGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新应用描述信息
         *
         * @param request UpdateApplicationDescriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationDescriptionResponse
         */
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

        /**
         * @summary 更新应用描述信息
         *
         * @param request UpdateApplicationDescriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationDescriptionResponse
         */
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

        /**
         * @summary 更新应用描述信息
         *
         * @param request UpdateApplicationDescriptionRequest
         * @return UpdateApplicationDescriptionResponse
         */
        public UpdateApplicationDescriptionResponse UpdateApplicationDescription(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationDescriptionWithOptions(request, headers, runtime);
        }

        /**
         * @summary 更新应用描述信息
         *
         * @param request UpdateApplicationDescriptionRequest
         * @return UpdateApplicationDescriptionResponse
         */
        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionAsync(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationDescriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates the auto scaling policy of an application.
         *
         * @description ##
         * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
         *
         * @param request UpdateApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationScalingRuleResponse
         */
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

        /**
         * @summary Updates the auto scaling policy of an application.
         *
         * @description ##
         * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
         *
         * @param request UpdateApplicationScalingRuleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationScalingRuleResponse
         */
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

        /**
         * @summary Updates the auto scaling policy of an application.
         *
         * @description ##
         * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
         *
         * @param request UpdateApplicationScalingRuleRequest
         * @return UpdateApplicationScalingRuleResponse
         */
        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRule(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates the auto scaling policy of an application.
         *
         * @description ##
         * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
         *
         * @param request UpdateApplicationScalingRuleRequest
         * @return UpdateApplicationScalingRuleResponse
         */
        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleAsync(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request UpdateApplicationVswitchesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationVswitchesResponse
         */
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

        /**
         * @param request UpdateApplicationVswitchesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationVswitchesResponse
         */
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

        /**
         * @param request UpdateApplicationVswitchesRequest
         * @return UpdateApplicationVswitchesResponse
         */
        public UpdateApplicationVswitchesResponse UpdateApplicationVswitches(UpdateApplicationVswitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationVswitchesWithOptions(request, headers, runtime);
        }

        /**
         * @param request UpdateApplicationVswitchesRequest
         * @return UpdateApplicationVswitchesResponse
         */
        public async Task<UpdateApplicationVswitchesResponse> UpdateApplicationVswitchesAsync(UpdateApplicationVswitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationVswitchesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 1
         *
         * @param request UpdateConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConfigMapResponse
         */
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

        /**
         * @summary 1
         *
         * @param request UpdateConfigMapRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConfigMapResponse
         */
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

        /**
         * @summary 1
         *
         * @param request UpdateConfigMapRequest
         * @return UpdateConfigMapResponse
         */
        public UpdateConfigMapResponse UpdateConfigMap(UpdateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigMapWithOptions(request, headers, runtime);
        }

        /**
         * @summary 1
         *
         * @param request UpdateConfigMapRequest
         * @return UpdateConfigMapResponse
         */
        public async Task<UpdateConfigMapResponse> UpdateConfigMapAsync(UpdateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates a canary release rule.
         *
         * @param request UpdateGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGreyTagRouteResponse
         */
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

        /**
         * @summary Updates a canary release rule.
         *
         * @param request UpdateGreyTagRouteRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateGreyTagRouteResponse
         */
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

        /**
         * @summary Updates a canary release rule.
         *
         * @param request UpdateGreyTagRouteRequest
         * @return UpdateGreyTagRouteResponse
         */
        public UpdateGreyTagRouteResponse UpdateGreyTagRoute(UpdateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates a canary release rule.
         *
         * @param request UpdateGreyTagRouteRequest
         * @return UpdateGreyTagRouteResponse
         */
        public async Task<UpdateGreyTagRouteResponse> UpdateGreyTagRouteAsync(UpdateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @param request UpdateIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIngressResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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

        /**
         * @param request UpdateIngressRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateIngressResponse
         */
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
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

        /**
         * @param request UpdateIngressRequest
         * @return UpdateIngressResponse
         */
        public UpdateIngressResponse UpdateIngress(UpdateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIngressWithOptions(request, headers, runtime);
        }

        /**
         * @param request UpdateIngressRequest
         * @return UpdateIngressResponse
         */
        public async Task<UpdateIngressResponse> UpdateIngressAsync(UpdateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIngressWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates a job template.
         *
         * @param request UpdateJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateJobResponse
         */
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

        /**
         * @summary Updates a job template.
         *
         * @param request UpdateJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateJobResponse
         */
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

        /**
         * @summary Updates a job template.
         *
         * @param request UpdateJobRequest
         * @return UpdateJobResponse
         */
        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateJobWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates a job template.
         *
         * @param request UpdateJobRequest
         * @return UpdateJobResponse
         */
        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateJobWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Updates the information about a namespace.
         *
         * @param request UpdateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNamespaceResponse
         */
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

        /**
         * @summary Updates the information about a namespace.
         *
         * @param request UpdateNamespaceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNamespaceResponse
         */
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

        /**
         * @summary Updates the information about a namespace.
         *
         * @param request UpdateNamespaceRequest
         * @return UpdateNamespaceResponse
         */
        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates the information about a namespace.
         *
         * @param request UpdateNamespaceRequest
         * @return UpdateNamespaceResponse
         */
        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary cn-beijing:test
         *
         * @param request UpdateNamespaceVpcRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNamespaceVpcResponse
         */
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

        /**
         * @summary cn-beijing:test
         *
         * @param request UpdateNamespaceVpcRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNamespaceVpcResponse
         */
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

        /**
         * @summary cn-beijing:test
         *
         * @param request UpdateNamespaceVpcRequest
         * @return UpdateNamespaceVpcResponse
         */
        public UpdateNamespaceVpcResponse UpdateNamespaceVpc(UpdateNamespaceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceVpcWithOptions(request, headers, runtime);
        }

        /**
         * @summary cn-beijing:test
         *
         * @param request UpdateNamespaceVpcRequest
         * @return UpdateNamespaceVpcResponse
         */
        public async Task<UpdateNamespaceVpcResponse> UpdateNamespaceVpcAsync(UpdateNamespaceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceVpcWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary The HTTP status code. Valid values:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param tmpReq UpdateSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretResponse
         */
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

        /**
         * @summary The HTTP status code. Valid values:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param tmpReq UpdateSecretRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSecretResponse
         */
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

        /**
         * @summary The HTTP status code. Valid values:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param request UpdateSecretRequest
         * @return UpdateSecretResponse
         */
        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSecretWithOptions(request, headers, runtime);
        }

        /**
         * @summary The HTTP status code. Valid values:
         * *   **2xx**: The call was successful.
         * *   **3xx**: The call was redirected.
         * *   **4xx**: The call failed.
         * *   **5xx**: A server error occurred.
         *
         * @param request UpdateSecretRequest
         * @return UpdateSecretResponse
         */
        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSecretWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 更新应用
         *
         * @param request UpdateWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebApplicationResponse
         */
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

        /**
         * @summary 更新应用
         *
         * @param request UpdateWebApplicationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebApplicationResponse
         */
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

        /**
         * @summary 更新应用
         *
         * @param request UpdateWebApplicationRequest
         * @return UpdateWebApplicationResponse
         */
        public UpdateWebApplicationResponse UpdateWebApplication(string ApplicationId, UpdateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebApplicationWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 更新应用
         *
         * @param request UpdateWebApplicationRequest
         * @return UpdateWebApplicationResponse
         */
        public async Task<UpdateWebApplicationResponse> UpdateWebApplicationAsync(string ApplicationId, UpdateWebApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebApplicationWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 更新弹性配置
         *
         * @param request UpdateWebApplicationScalingConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebApplicationScalingConfigResponse
         */
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

        /**
         * @summary 更新弹性配置
         *
         * @param request UpdateWebApplicationScalingConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebApplicationScalingConfigResponse
         */
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

        /**
         * @summary 更新弹性配置
         *
         * @param request UpdateWebApplicationScalingConfigRequest
         * @return UpdateWebApplicationScalingConfigResponse
         */
        public UpdateWebApplicationScalingConfigResponse UpdateWebApplicationScalingConfig(string ApplicationId, UpdateWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebApplicationScalingConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 更新弹性配置
         *
         * @param request UpdateWebApplicationScalingConfigRequest
         * @return UpdateWebApplicationScalingConfigResponse
         */
        public async Task<UpdateWebApplicationScalingConfigResponse> UpdateWebApplicationScalingConfigAsync(string ApplicationId, UpdateWebApplicationScalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebApplicationScalingConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 更新流量配置
         *
         * @param request UpdateWebApplicationTrafficConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebApplicationTrafficConfigResponse
         */
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

        /**
         * @summary 更新流量配置
         *
         * @param request UpdateWebApplicationTrafficConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebApplicationTrafficConfigResponse
         */
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

        /**
         * @summary 更新流量配置
         *
         * @param request UpdateWebApplicationTrafficConfigRequest
         * @return UpdateWebApplicationTrafficConfigResponse
         */
        public UpdateWebApplicationTrafficConfigResponse UpdateWebApplicationTrafficConfig(string ApplicationId, UpdateWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebApplicationTrafficConfigWithOptions(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 更新流量配置
         *
         * @param request UpdateWebApplicationTrafficConfigRequest
         * @return UpdateWebApplicationTrafficConfigResponse
         */
        public async Task<UpdateWebApplicationTrafficConfigResponse> UpdateWebApplicationTrafficConfigAsync(string ApplicationId, UpdateWebApplicationTrafficConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebApplicationTrafficConfigWithOptionsAsync(ApplicationId, request, headers, runtime);
        }

        /**
         * @summary 更新自定义域名.
         *
         * @param request UpdateWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebCustomDomainResponse
         */
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

        /**
         * @summary 更新自定义域名.
         *
         * @param request UpdateWebCustomDomainRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateWebCustomDomainResponse
         */
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

        /**
         * @summary 更新自定义域名.
         *
         * @param request UpdateWebCustomDomainRequest
         * @return UpdateWebCustomDomainResponse
         */
        public UpdateWebCustomDomainResponse UpdateWebCustomDomain(string DomainName, UpdateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateWebCustomDomainWithOptions(DomainName, request, headers, runtime);
        }

        /**
         * @summary 更新自定义域名.
         *
         * @param request UpdateWebCustomDomainRequest
         * @return UpdateWebCustomDomainResponse
         */
        public async Task<UpdateWebCustomDomainResponse> UpdateWebCustomDomainAsync(string DomainName, UpdateWebCustomDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateWebCustomDomainWithOptionsAsync(DomainName, request, headers, runtime);
        }

    }
}
