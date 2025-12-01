// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Domain20180208.Models;

namespace AlibabaCloud.SDK.Domain20180208
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("domain", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// AcceptDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptDemandResponse
        /// </returns>
        public AcceptDemandResponse AcceptDemandWithOptions(AcceptDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AcceptDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AcceptDemandResponse
        /// </returns>
        public async Task<AcceptDemandResponse> AcceptDemandWithOptionsAsync(AcceptDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AcceptDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AcceptDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AcceptDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptDemandResponse
        /// </returns>
        public AcceptDemandResponse AcceptDemand(AcceptDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AcceptDemandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AcceptDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// AcceptDemandResponse
        /// </returns>
        public async Task<AcceptDemandResponse> AcceptDemandAsync(AcceptDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AcceptDemandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闯入接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchIntrudeDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchIntrudeDomainsResponse
        /// </returns>
        public BatchIntrudeDomainsResponse BatchIntrudeDomainsWithOptions(BatchIntrudeDomainsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchIntrudeDomainsShrinkRequest request = new BatchIntrudeDomainsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainNames))
            {
                request.DomainNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainNames, "DomainNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNamesShrink))
            {
                query["DomainNames"] = request.DomainNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchIntrudeDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchIntrudeDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闯入接口</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchIntrudeDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchIntrudeDomainsResponse
        /// </returns>
        public async Task<BatchIntrudeDomainsResponse> BatchIntrudeDomainsWithOptionsAsync(BatchIntrudeDomainsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchIntrudeDomainsShrinkRequest request = new BatchIntrudeDomainsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainNames))
            {
                request.DomainNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainNames, "DomainNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNamesShrink))
            {
                query["DomainNames"] = request.DomainNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchIntrudeDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchIntrudeDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闯入接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchIntrudeDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchIntrudeDomainsResponse
        /// </returns>
        public BatchIntrudeDomainsResponse BatchIntrudeDomains(BatchIntrudeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchIntrudeDomainsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>闯入接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchIntrudeDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchIntrudeDomainsResponse
        /// </returns>
        public async Task<BatchIntrudeDomainsResponse> BatchIntrudeDomainsAsync(BatchIntrudeDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchIntrudeDomainsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据OutBizId（批量）查看带价PUSH状态，通常用于超时场景补偿</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchQueryPushStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPushStatusResponse
        /// </returns>
        public BatchQueryPushStatusResponse BatchQueryPushStatusWithOptions(BatchQueryPushStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchQueryPushStatusShrinkRequest request = new BatchQueryPushStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutBizIds))
            {
                request.OutBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutBizIds, "OutBizIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizIdsShrink))
            {
                query["OutBizIds"] = request.OutBizIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryPushStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryPushStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据OutBizId（批量）查看带价PUSH状态，通常用于超时场景补偿</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchQueryPushStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPushStatusResponse
        /// </returns>
        public async Task<BatchQueryPushStatusResponse> BatchQueryPushStatusWithOptionsAsync(BatchQueryPushStatusRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchQueryPushStatusShrinkRequest request = new BatchQueryPushStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutBizIds))
            {
                request.OutBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutBizIds, "OutBizIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizIdsShrink))
            {
                query["OutBizIds"] = request.OutBizIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchQueryPushStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchQueryPushStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据OutBizId（批量）查看带价PUSH状态，通常用于超时场景补偿</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryPushStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPushStatusResponse
        /// </returns>
        public BatchQueryPushStatusResponse BatchQueryPushStatus(BatchQueryPushStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryPushStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>根据OutBizId（批量）查看带价PUSH状态，通常用于超时场景补偿</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchQueryPushStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchQueryPushStatusResponse
        /// </returns>
        public async Task<BatchQueryPushStatusResponse> BatchQueryPushStatusAsync(BatchQueryPushStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryPushStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回带价PUSH</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchRecallPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPushResponse
        /// </returns>
        public BatchRecallPushResponse BatchRecallPushWithOptions(BatchRecallPushRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchRecallPushShrinkRequest request = new BatchRecallPushShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutBizIds))
            {
                request.OutBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutBizIds, "OutBizIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizIdsShrink))
            {
                query["OutBizIds"] = request.OutBizIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRecallPush",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallPushResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回带价PUSH</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// BatchRecallPushRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPushResponse
        /// </returns>
        public async Task<BatchRecallPushResponse> BatchRecallPushWithOptionsAsync(BatchRecallPushRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchRecallPushShrinkRequest request = new BatchRecallPushShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OutBizIds))
            {
                request.OutBizIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OutBizIds, "OutBizIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizIdsShrink))
            {
                query["OutBizIds"] = request.OutBizIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchRecallPush",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchRecallPushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回带价PUSH</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallPushRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPushResponse
        /// </returns>
        public BatchRecallPushResponse BatchRecallPush(BatchRecallPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRecallPushWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量撤回带价PUSH</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchRecallPushRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchRecallPushResponse
        /// </returns>
        public async Task<BatchRecallPushResponse> BatchRecallPushAsync(BatchRecallPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRecallPushWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BidDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BidDomainResponse
        /// </returns>
        public BidDomainResponse BidDomainWithOptions(BidDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxBid))
            {
                body["MaxBid"] = request.MaxBid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BidDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BidDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BidDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BidDomainResponse
        /// </returns>
        public async Task<BidDomainResponse> BidDomainWithOptionsAsync(BidDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxBid))
            {
                body["MaxBid"] = request.MaxBid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BidDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BidDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BidDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// BidDomainResponse
        /// </returns>
        public BidDomainResponse BidDomain(BidDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BidDomainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BidDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// BidDomainResponse
        /// </returns>
        public async Task<BidDomainResponse> BidDomainAsync(BidDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BidDomainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ChangeAuctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAuctionResponse
        /// </returns>
        public ChangeAuctionResponse ChangeAuctionWithOptions(ChangeAuctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionList))
            {
                body["AuctionList"] = request.AuctionList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAuction",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAuctionResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAuctionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeAuctionResponse
        /// </returns>
        public async Task<ChangeAuctionResponse> ChangeAuctionWithOptionsAsync(ChangeAuctionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionList))
            {
                body["AuctionList"] = request.AuctionList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeAuction",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeAuctionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ChangeAuctionRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAuctionResponse
        /// </returns>
        public ChangeAuctionResponse ChangeAuction(ChangeAuctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeAuctionWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ChangeAuctionRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeAuctionResponse
        /// </returns>
        public async Task<ChangeAuctionResponse> ChangeAuctionAsync(ChangeAuctionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeAuctionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名在售状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainStatusResponse
        /// </returns>
        public CheckDomainStatusResponse CheckDomainStatusWithOptions(CheckDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名在售状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainStatusResponse
        /// </returns>
        public async Task<CheckDomainStatusResponse> CheckDomainStatusWithOptionsAsync(CheckDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckDomainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名在售状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainStatusResponse
        /// </returns>
        public CheckDomainStatusResponse CheckDomainStatus(CheckDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDomainStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名在售状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckDomainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckDomainStatusResponse
        /// </returns>
        public async Task<CheckDomainStatusResponse> CheckDomainStatusAsync(CheckDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDomainStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名带价PUSH接收方可接收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckPushReceiverRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckPushReceiverResponse
        /// </returns>
        public CheckPushReceiverResponse CheckPushReceiverWithOptions(CheckPushReceiverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAccount))
            {
                query["ReceiverAccount"] = request.ReceiverAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckPushReceiver",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckPushReceiverResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名带价PUSH接收方可接收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckPushReceiverRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckPushReceiverResponse
        /// </returns>
        public async Task<CheckPushReceiverResponse> CheckPushReceiverWithOptionsAsync(CheckPushReceiverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAccount))
            {
                query["ReceiverAccount"] = request.ReceiverAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckPushReceiver",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckPushReceiverResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名带价PUSH接收方可接收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckPushReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckPushReceiverResponse
        /// </returns>
        public CheckPushReceiverResponse CheckPushReceiver(CheckPushReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckPushReceiverWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验域名带价PUSH接收方可接收</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckPushReceiverRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckPushReceiverResponse
        /// </returns>
        public async Task<CheckPushReceiverResponse> CheckPushReceiverAsync(CheckPushReceiverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckPushReceiverWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSelectedDomainStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSelectedDomainStatusResponse
        /// </returns>
        public CheckSelectedDomainStatusResponse CheckSelectedDomainStatusWithOptions(CheckSelectedDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSelectedDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSelectedDomainStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSelectedDomainStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckSelectedDomainStatusResponse
        /// </returns>
        public async Task<CheckSelectedDomainStatusResponse> CheckSelectedDomainStatusWithOptionsAsync(CheckSelectedDomainStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckSelectedDomainStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckSelectedDomainStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSelectedDomainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSelectedDomainStatusResponse
        /// </returns>
        public CheckSelectedDomainStatusResponse CheckSelectedDomainStatus(CheckSelectedDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckSelectedDomainStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选询价接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckSelectedDomainStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckSelectedDomainStatusResponse
        /// </returns>
        public async Task<CheckSelectedDomainStatusResponse> CheckSelectedDomainStatusAsync(CheckSelectedDomainStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckSelectedDomainStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一口价需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceDemandOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceDemandOrderResponse
        /// </returns>
        public CreateFixedPriceDemandOrderResponse CreateFixedPriceDemandOrderWithOptions(CreateFixedPriceDemandOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceDemandOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceDemandOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一口价需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceDemandOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceDemandOrderResponse
        /// </returns>
        public async Task<CreateFixedPriceDemandOrderResponse> CreateFixedPriceDemandOrderWithOptionsAsync(CreateFixedPriceDemandOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceDemandOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceDemandOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一口价需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceDemandOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceDemandOrderResponse
        /// </returns>
        public CreateFixedPriceDemandOrderResponse CreateFixedPriceDemandOrder(CreateFixedPriceDemandOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFixedPriceDemandOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建一口价需求单</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceDemandOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceDemandOrderResponse
        /// </returns>
        public async Task<CreateFixedPriceDemandOrderResponse> CreateFixedPriceDemandOrderAsync(CreateFixedPriceDemandOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFixedPriceDemandOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选下单购买接口，阿里云账户余额直接扣费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceSelectedOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceSelectedOrderResponse
        /// </returns>
        public CreateFixedPriceSelectedOrderResponse CreateFixedPriceSelectedOrderWithOptions(CreateFixedPriceSelectedOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedPrice))
            {
                query["ExpectedPrice"] = request.ExpectedPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceSelectedOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceSelectedOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选下单购买接口，阿里云账户余额直接扣费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceSelectedOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceSelectedOrderResponse
        /// </returns>
        public async Task<CreateFixedPriceSelectedOrderResponse> CreateFixedPriceSelectedOrderWithOptionsAsync(CreateFixedPriceSelectedOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactId))
            {
                query["ContactId"] = request.ContactId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpectedPrice))
            {
                query["ExpectedPrice"] = request.ExpectedPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateFixedPriceSelectedOrder",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateFixedPriceSelectedOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选下单购买接口，阿里云账户余额直接扣费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceSelectedOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceSelectedOrderResponse
        /// </returns>
        public CreateFixedPriceSelectedOrderResponse CreateFixedPriceSelectedOrder(CreateFixedPriceSelectedOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFixedPriceSelectedOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>一口价严选下单购买接口，阿里云账户余额直接扣费</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateFixedPriceSelectedOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateFixedPriceSelectedOrderResponse
        /// </returns>
        public async Task<CreateFixedPriceSelectedOrderResponse> CreateFixedPriceSelectedOrderAsync(CreateFixedPriceSelectedOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFixedPriceSelectedOrderWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FailDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailDemandResponse
        /// </returns>
        public FailDemandResponse FailDemandWithOptions(FailDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FailDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FailDemandResponse
        /// </returns>
        public async Task<FailDemandResponse> FailDemandWithOptionsAsync(FailDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FailDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FailDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FailDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// FailDemandResponse
        /// </returns>
        public FailDemandResponse FailDemand(FailDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FailDemandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FailDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// FailDemandResponse
        /// </returns>
        public async Task<FailDemandResponse> FailDemandAsync(FailDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FailDemandWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// FinishDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishDemandResponse
        /// </returns>
        public FinishDemandResponse FinishDemandWithOptions(FinishDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// FinishDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FinishDemandResponse
        /// </returns>
        public async Task<FinishDemandResponse> FinishDemandWithOptionsAsync(FinishDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FinishDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FinishDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// FinishDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishDemandResponse
        /// </returns>
        public FinishDemandResponse FinishDemand(FinishDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FinishDemandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// FinishDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// FinishDemandResponse
        /// </returns>
        public async Task<FinishDemandResponse> FinishDemandAsync(FinishDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FinishDemandWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetIntlDomainDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntlDomainDownloadUrlResponse
        /// </returns>
        public GetIntlDomainDownloadUrlResponse GetIntlDomainDownloadUrlWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntlDomainDownloadUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntlDomainDownloadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetIntlDomainDownloadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetIntlDomainDownloadUrlResponse
        /// </returns>
        public async Task<GetIntlDomainDownloadUrlResponse> GetIntlDomainDownloadUrlWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIntlDomainDownloadUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIntlDomainDownloadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// GetIntlDomainDownloadUrlResponse
        /// </returns>
        public GetIntlDomainDownloadUrlResponse GetIntlDomainDownloadUrl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetIntlDomainDownloadUrlWithOptions(runtime);
        }

        /// <returns>
        /// GetIntlDomainDownloadUrlResponse
        /// </returns>
        public async Task<GetIntlDomainDownloadUrlResponse> GetIntlDomainDownloadUrlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetIntlDomainDownloadUrlWithOptionsAsync(runtime);
        }

        /// <param name="request">
        /// GetReserveDomainUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReserveDomainUrlResponse
        /// </returns>
        public GetReserveDomainUrlResponse GetReserveDomainUrlWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReserveDomainUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReserveDomainUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetReserveDomainUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReserveDomainUrlResponse
        /// </returns>
        public async Task<GetReserveDomainUrlResponse> GetReserveDomainUrlWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReserveDomainUrl",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReserveDomainUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <returns>
        /// GetReserveDomainUrlResponse
        /// </returns>
        public GetReserveDomainUrlResponse GetReserveDomainUrl()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetReserveDomainUrlWithOptions(runtime);
        }

        /// <returns>
        /// GetReserveDomainUrlResponse
        /// </returns>
        public async Task<GetReserveDomainUrlResponse> GetReserveDomainUrlAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetReserveDomainUrlWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买国际站预释放域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PurchaseIntlDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PurchaseIntlDomainResponse
        /// </returns>
        public PurchaseIntlDomainResponse PurchaseIntlDomainWithOptions(PurchaseIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["Price"] = request.Price;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurchaseIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurchaseIntlDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买国际站预释放域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PurchaseIntlDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PurchaseIntlDomainResponse
        /// </returns>
        public async Task<PurchaseIntlDomainResponse> PurchaseIntlDomainWithOptionsAsync(PurchaseIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Currency))
            {
                body["Currency"] = request.Currency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                body["Price"] = request.Price;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PurchaseIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PurchaseIntlDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买国际站预释放域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PurchaseIntlDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// PurchaseIntlDomainResponse
        /// </returns>
        public PurchaseIntlDomainResponse PurchaseIntlDomain(PurchaseIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PurchaseIntlDomainWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>购买国际站预释放域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PurchaseIntlDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// PurchaseIntlDomainResponse
        /// </returns>
        public async Task<PurchaseIntlDomainResponse> PurchaseIntlDomainAsync(PurchaseIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PurchaseIntlDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布域名PUSH，目前只支持0元PUSH</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDomainsResponse
        /// </returns>
        public PushDomainsResponse PushDomainsWithOptions(PushDomainsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushDomainsShrinkRequest request = new PushDomainsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainList))
            {
                request.DomainListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainList, "DomainList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainListShrink))
            {
                query["DomainList"] = request.DomainListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishRemark))
            {
                query["PublishRemark"] = request.PublishRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAccount))
            {
                query["ReceiverAccount"] = request.ReceiverAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布域名PUSH，目前只支持0元PUSH</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// PushDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// PushDomainsResponse
        /// </returns>
        public async Task<PushDomainsResponse> PushDomainsWithOptionsAsync(PushDomainsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushDomainsShrinkRequest request = new PushDomainsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainList))
            {
                request.DomainListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainList, "DomainList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainListShrink))
            {
                query["DomainList"] = request.DomainListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OutBizId))
            {
                query["OutBizId"] = request.OutBizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublishRemark))
            {
                query["PublishRemark"] = request.PublishRemark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiverAccount))
            {
                query["ReceiverAccount"] = request.ReceiverAccount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PushDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布域名PUSH，目前只支持0元PUSH</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushDomainsResponse
        /// </returns>
        public PushDomainsResponse PushDomains(PushDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushDomainsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>发布域名PUSH，目前只支持0元PUSH</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// PushDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// PushDomainsResponse
        /// </returns>
        public async Task<PushDomainsResponse> PushDomainsAsync(PushDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushDomainsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAuctionDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionDetailResponse
        /// </returns>
        public QueryAuctionDetailResponse QueryAuctionDetailWithOptions(QueryAuctionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctionDetail",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAuctionDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionDetailResponse
        /// </returns>
        public async Task<QueryAuctionDetailResponse> QueryAuctionDetailWithOptionsAsync(QueryAuctionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctionDetail",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAuctionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionDetailResponse
        /// </returns>
        public QueryAuctionDetailResponse QueryAuctionDetail(QueryAuctionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuctionDetailWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAuctionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionDetailResponse
        /// </returns>
        public async Task<QueryAuctionDetailResponse> QueryAuctionDetailAsync(QueryAuctionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuctionDetailWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAuctionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionsResponse
        /// </returns>
        public QueryAuctionsResponse QueryAuctionsWithOptions(QueryAuctionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionEndTimeOrder))
            {
                body["AuctionEndTimeOrder"] = request.AuctionEndTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["Statuses"] = request.Statuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctions",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAuctionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionsResponse
        /// </returns>
        public async Task<QueryAuctionsResponse> QueryAuctionsWithOptionsAsync(QueryAuctionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionEndTimeOrder))
            {
                body["AuctionEndTimeOrder"] = request.AuctionEndTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                body["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Statuses))
            {
                body["Statuses"] = request.Statuses;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAuctions",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAuctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAuctionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionsResponse
        /// </returns>
        public QueryAuctionsResponse QueryAuctions(QueryAuctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAuctionsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAuctionsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAuctionsResponse
        /// </returns>
        public async Task<QueryAuctionsResponse> QueryAuctionsAsync(QueryAuctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAuctionsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBidRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBidRecordsResponse
        /// </returns>
        public QueryBidRecordsResponse QueryBidRecordsWithOptions(QueryBidRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBidRecords",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBidRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBidRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBidRecordsResponse
        /// </returns>
        public async Task<QueryBidRecordsResponse> QueryBidRecordsWithOptionsAsync(QueryBidRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                body["AuctionId"] = request.AuctionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBidRecords",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBidRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBidRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBidRecordsResponse
        /// </returns>
        public QueryBidRecordsResponse QueryBidRecords(QueryBidRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBidRecordsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBidRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBidRecordsResponse
        /// </returns>
        public async Task<QueryBidRecordsResponse> QueryBidRecordsAsync(QueryBidRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBidRecordsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBookingDomainInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBookingDomainInfoResponse
        /// </returns>
        public QueryBookingDomainInfoResponse QueryBookingDomainInfoWithOptions(QueryBookingDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBookingDomainInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBookingDomainInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBookingDomainInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBookingDomainInfoResponse
        /// </returns>
        public async Task<QueryBookingDomainInfoResponse> QueryBookingDomainInfoWithOptionsAsync(QueryBookingDomainInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBookingDomainInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBookingDomainInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBookingDomainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBookingDomainInfoResponse
        /// </returns>
        public QueryBookingDomainInfoResponse QueryBookingDomainInfo(QueryBookingDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBookingDomainInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBookingDomainInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBookingDomainInfoResponse
        /// </returns>
        public async Task<QueryBookingDomainInfoResponse> QueryBookingDomainInfoAsync(QueryBookingDomainInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBookingDomainInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询回购订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBrokerDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandResponse
        /// </returns>
        public QueryBrokerDemandResponse QueryBrokerDemandWithOptions(QueryBrokerDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QueryBrokerDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询回购订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBrokerDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandResponse
        /// </returns>
        public async Task<QueryBrokerDemandResponse> QueryBrokerDemandWithOptionsAsync(QueryBrokerDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "QueryBrokerDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询回购订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBrokerDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandResponse
        /// </returns>
        public QueryBrokerDemandResponse QueryBrokerDemand(QueryBrokerDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBrokerDemandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询回购订单列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBrokerDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandResponse
        /// </returns>
        public async Task<QueryBrokerDemandResponse> QueryBrokerDemandAsync(QueryBrokerDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBrokerDemandWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryBrokerDemandRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandRecordResponse
        /// </returns>
        public QueryBrokerDemandRecordResponse QueryBrokerDemandRecordWithOptions(QueryBrokerDemandRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBrokerDemandRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBrokerDemandRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandRecordResponse
        /// </returns>
        public async Task<QueryBrokerDemandRecordResponse> QueryBrokerDemandRecordWithOptionsAsync(QueryBrokerDemandRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBrokerDemandRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBrokerDemandRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryBrokerDemandRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandRecordResponse
        /// </returns>
        public QueryBrokerDemandRecordResponse QueryBrokerDemandRecord(QueryBrokerDemandRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBrokerDemandRecordWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryBrokerDemandRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBrokerDemandRecordResponse
        /// </returns>
        public async Task<QueryBrokerDemandRecordResponse> QueryBrokerDemandRecordAsync(QueryBrokerDemandRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBrokerDemandRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询买家交易记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryBuyerDomainTradeRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBuyerDomainTradeRecordsResponse
        /// </returns>
        public QueryBuyerDomainTradeRecordsResponse QueryBuyerDomainTradeRecordsWithOptions(QueryBuyerDomainTradeRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBuyerDomainTradeRecordsShrinkRequest request = new QueryBuyerDomainTradeRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BizIdList))
            {
                request.BizIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BizIdList, "BizIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainNameList))
            {
                request.DomainNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainNameList, "DomainNameList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "StatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SuffixList))
            {
                request.SuffixListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SuffixList, "SuffixList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TradeTypeList))
            {
                request.TradeTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TradeTypeList, "TradeTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdListShrink))
            {
                query["BizIdList"] = request.BizIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameListShrink))
            {
                query["DomainNameList"] = request.DomainNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPrice))
            {
                query["EndPrice"] = request.EndPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["Sorter"] = request.Sorter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPrice))
            {
                query["StartPrice"] = request.StartPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["StatusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuffixListShrink))
            {
                query["SuffixList"] = request.SuffixListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTypeListShrink))
            {
                query["TradeTypeList"] = request.TradeTypeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBuyerDomainTradeRecords",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBuyerDomainTradeRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询买家交易记录列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// QueryBuyerDomainTradeRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryBuyerDomainTradeRecordsResponse
        /// </returns>
        public async Task<QueryBuyerDomainTradeRecordsResponse> QueryBuyerDomainTradeRecordsWithOptionsAsync(QueryBuyerDomainTradeRecordsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryBuyerDomainTradeRecordsShrinkRequest request = new QueryBuyerDomainTradeRecordsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.BizIdList))
            {
                request.BizIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.BizIdList, "BizIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DomainNameList))
            {
                request.DomainNameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DomainNameList, "DomainNameList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.StatusList))
            {
                request.StatusListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.StatusList, "StatusList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SuffixList))
            {
                request.SuffixListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SuffixList, "SuffixList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TradeTypeList))
            {
                request.TradeTypeListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TradeTypeList, "TradeTypeList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizIdListShrink))
            {
                query["BizIdList"] = request.BizIdListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainNameListShrink))
            {
                query["DomainNameList"] = request.DomainNameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndPrice))
            {
                query["EndPrice"] = request.EndPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["Sorter"] = request.Sorter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartPrice))
            {
                query["StartPrice"] = request.StartPrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusListShrink))
            {
                query["StatusList"] = request.StatusListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SuffixListShrink))
            {
                query["SuffixList"] = request.SuffixListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TradeTypeListShrink))
            {
                query["TradeTypeList"] = request.TradeTypeListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryBuyerDomainTradeRecords",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryBuyerDomainTradeRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询买家交易记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBuyerDomainTradeRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBuyerDomainTradeRecordsResponse
        /// </returns>
        public QueryBuyerDomainTradeRecordsResponse QueryBuyerDomainTradeRecords(QueryBuyerDomainTradeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBuyerDomainTradeRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询买家交易记录列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryBuyerDomainTradeRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryBuyerDomainTradeRecordsResponse
        /// </returns>
        public async Task<QueryBuyerDomainTradeRecordsResponse> QueryBuyerDomainTradeRecordsAsync(QueryBuyerDomainTradeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBuyerDomainTradeRecordsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainTransferStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainTransferStatusResponse
        /// </returns>
        public QueryDomainTransferStatusResponse QueryDomainTransferStatusWithOptions(QueryDomainTransferStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainTransferStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainTransferStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryDomainTransferStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainTransferStatusResponse
        /// </returns>
        public async Task<QueryDomainTransferStatusResponse> QueryDomainTransferStatusWithOptionsAsync(QueryDomainTransferStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryDomainTransferStatus",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryDomainTransferStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryDomainTransferStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainTransferStatusResponse
        /// </returns>
        public QueryDomainTransferStatusResponse QueryDomainTransferStatus(QueryDomainTransferStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDomainTransferStatusWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryDomainTransferStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryDomainTransferStatusResponse
        /// </returns>
        public async Task<QueryDomainTransferStatusResponse> QueryDomainTransferStatusAsync(QueryDomainTransferStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDomainTransferStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询汇率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExchangeRateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExchangeRateResponse
        /// </returns>
        public QueryExchangeRateResponse QueryExchangeRateWithOptions(QueryExchangeRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromCurrency))
            {
                query["FromCurrency"] = request.FromCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCurrency))
            {
                query["ToCurrency"] = request.ToCurrency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExchangeRate",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExchangeRateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询汇率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExchangeRateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExchangeRateResponse
        /// </returns>
        public async Task<QueryExchangeRateResponse> QueryExchangeRateWithOptionsAsync(QueryExchangeRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FromCurrency))
            {
                query["FromCurrency"] = request.FromCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToCurrency))
            {
                query["ToCurrency"] = request.ToCurrency;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExchangeRate",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExchangeRateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询汇率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExchangeRateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExchangeRateResponse
        /// </returns>
        public QueryExchangeRateResponse QueryExchangeRate(QueryExchangeRateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExchangeRateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询汇率</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExchangeRateRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExchangeRateResponse
        /// </returns>
        public async Task<QueryExchangeRateResponse> QueryExchangeRateAsync(QueryExchangeRateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExchangeRateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询竞价商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportAuctionDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExportAuctionDetailResponse
        /// </returns>
        public QueryExportAuctionDetailResponse QueryExportAuctionDetailWithOptions(QueryExportAuctionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                query["AuctionId"] = request.AuctionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExportAuctionDetail",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExportAuctionDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询竞价商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportAuctionDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExportAuctionDetailResponse
        /// </returns>
        public async Task<QueryExportAuctionDetailResponse> QueryExportAuctionDetailWithOptionsAsync(QueryExportAuctionDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuctionId))
            {
                query["AuctionId"] = request.AuctionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExportAuctionDetail",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExportAuctionDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询竞价商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportAuctionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExportAuctionDetailResponse
        /// </returns>
        public QueryExportAuctionDetailResponse QueryExportAuctionDetail(QueryExportAuctionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExportAuctionDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询竞价商品详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportAuctionDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExportAuctionDetailResponse
        /// </returns>
        public async Task<QueryExportAuctionDetailResponse> QueryExportAuctionDetailAsync(QueryExportAuctionDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExportAuctionDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出的抢注域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportDomainExpireSnatchsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExportDomainExpireSnatchsResponse
        /// </returns>
        public QueryExportDomainExpireSnatchsResponse QueryExportDomainExpireSnatchsWithOptions(QueryExportDomainExpireSnatchsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentId))
            {
                query["CurrentId"] = request.CurrentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExportDomainExpireSnatchs",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExportDomainExpireSnatchsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出的抢注域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportDomainExpireSnatchsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryExportDomainExpireSnatchsResponse
        /// </returns>
        public async Task<QueryExportDomainExpireSnatchsResponse> QueryExportDomainExpireSnatchsWithOptionsAsync(QueryExportDomainExpireSnatchsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentId))
            {
                query["CurrentId"] = request.CurrentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryExportDomainExpireSnatchs",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryExportDomainExpireSnatchsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出的抢注域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportDomainExpireSnatchsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExportDomainExpireSnatchsResponse
        /// </returns>
        public QueryExportDomainExpireSnatchsResponse QueryExportDomainExpireSnatchs(QueryExportDomainExpireSnatchsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryExportDomainExpireSnatchsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出的抢注域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryExportDomainExpireSnatchsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryExportDomainExpireSnatchsResponse
        /// </returns>
        public async Task<QueryExportDomainExpireSnatchsResponse> QueryExportDomainExpireSnatchsAsync(QueryExportDomainExpireSnatchsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryExportDomainExpireSnatchsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryPurchasedDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPurchasedDomainsResponse
        /// </returns>
        public QueryPurchasedDomainsResponse QueryPurchasedDomainsWithOptions(QueryPurchasedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOperationTime))
            {
                body["EndOperationTime"] = request.EndOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTimeOrder))
            {
                body["OpTimeOrder"] = request.OpTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOperationTime))
            {
                body["StartOperationTime"] = request.StartOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeOrder))
            {
                body["UpdateTimeOrder"] = request.UpdateTimeOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPurchasedDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPurchasedDomainsResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPurchasedDomainsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryPurchasedDomainsResponse
        /// </returns>
        public async Task<QueryPurchasedDomainsResponse> QueryPurchasedDomainsWithOptionsAsync(QueryPurchasedDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                body["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndOperationTime))
            {
                body["EndOperationTime"] = request.EndOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpTimeOrder))
            {
                body["OpTimeOrder"] = request.OpTimeOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationStatus))
            {
                body["OperationStatus"] = request.OperationStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductType))
            {
                body["ProductType"] = request.ProductType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartOperationTime))
            {
                body["StartOperationTime"] = request.StartOperationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateTimeOrder))
            {
                body["UpdateTimeOrder"] = request.UpdateTimeOrder;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryPurchasedDomains",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryPurchasedDomainsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryPurchasedDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPurchasedDomainsResponse
        /// </returns>
        public QueryPurchasedDomainsResponse QueryPurchasedDomains(QueryPurchasedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPurchasedDomainsWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryPurchasedDomainsRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryPurchasedDomainsResponse
        /// </returns>
        public async Task<QueryPurchasedDomainsResponse> QueryPurchasedDomainsAsync(QueryPurchasedDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPurchasedDomainsWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RecordDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordDemandResponse
        /// </returns>
        public RecordDemandResponse RecordDemandWithOptions(RecordDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RecordDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecordDemandResponse
        /// </returns>
        public async Task<RecordDemandResponse> RecordDemandWithOptionsAsync(RecordDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecordDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecordDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RecordDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordDemandResponse
        /// </returns>
        public RecordDemandResponse RecordDemand(RecordDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecordDemandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RecordDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// RecordDemandResponse
        /// </returns>
        public async Task<RecordDemandResponse> RecordDemandAsync(RecordDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecordDemandWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RefuseDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefuseDemandResponse
        /// </returns>
        public RefuseDemandResponse RefuseDemandWithOptions(RefuseDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RefuseDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RefuseDemandResponse
        /// </returns>
        public async Task<RefuseDemandResponse> RefuseDemandWithOptionsAsync(RefuseDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefuseDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefuseDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RefuseDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// RefuseDemandResponse
        /// </returns>
        public RefuseDemandResponse RefuseDemand(RefuseDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RefuseDemandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RefuseDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// RefuseDemandResponse
        /// </returns>
        public async Task<RefuseDemandResponse> RefuseDemandAsync(RefuseDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RefuseDemandWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// RequestPayDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RequestPayDemandResponse
        /// </returns>
        public RequestPayDemandResponse RequestPayDemandWithOptions(RequestPayDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                query["Price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceType))
            {
                query["ProduceType"] = request.ProduceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestPayDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestPayDemandResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// RequestPayDemandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RequestPayDemandResponse
        /// </returns>
        public async Task<RequestPayDemandResponse> RequestPayDemandWithOptionsAsync(RequestPayDemandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                query["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Price))
            {
                query["Price"] = request.Price;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProduceType))
            {
                query["ProduceType"] = request.ProduceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RequestPayDemand",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RequestPayDemandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// RequestPayDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// RequestPayDemandResponse
        /// </returns>
        public RequestPayDemandResponse RequestPayDemand(RequestPayDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RequestPayDemandWithOptions(request, runtime);
        }

        /// <param name="request">
        /// RequestPayDemandRequest
        /// </param>
        /// 
        /// <returns>
        /// RequestPayDemandResponse
        /// </returns>
        public async Task<RequestPayDemandResponse> RequestPayDemandAsync(RequestPayDemandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RequestPayDemandWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReserveDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReserveDomainResponse
        /// </returns>
        public ReserveDomainResponse ReserveDomainWithOptions(ReserveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["Channels"] = request.Channels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ReserveDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReserveDomainResponse
        /// </returns>
        public async Task<ReserveDomainResponse> ReserveDomainWithOptionsAsync(ReserveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channels))
            {
                body["Channels"] = request.Channels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ReserveDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// ReserveDomainResponse
        /// </returns>
        public ReserveDomainResponse ReserveDomain(ReserveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReserveDomainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReserveDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// ReserveDomainResponse
        /// </returns>
        public async Task<ReserveDomainResponse> ReserveDomainAsync(ReserveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReserveDomainWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// ReserveIntlDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReserveIntlDomainResponse
        /// </returns>
        public ReserveIntlDomainResponse ReserveIntlDomainWithOptions(ReserveIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveIntlDomainResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// ReserveIntlDomainRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ReserveIntlDomainResponse
        /// </returns>
        public async Task<ReserveIntlDomainResponse> ReserveIntlDomainWithOptionsAsync(ReserveIntlDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReserveIntlDomain",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReserveIntlDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// ReserveIntlDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// ReserveIntlDomainResponse
        /// </returns>
        public ReserveIntlDomainResponse ReserveIntlDomain(ReserveIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReserveIntlDomainWithOptions(request, runtime);
        }

        /// <param name="request">
        /// ReserveIntlDomainRequest
        /// </param>
        /// 
        /// <returns>
        /// ReserveIntlDomainResponse
        /// </returns>
        public async Task<ReserveIntlDomainResponse> ReserveIntlDomainAsync(ReserveIntlDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReserveIntlDomainWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectedDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectedDomainListResponse
        /// </returns>
        public SelectedDomainListResponse SelectedDomainListWithOptions(SelectedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDate))
            {
                query["ListDate"] = request.ListDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectedDomainList",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectedDomainListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectedDomainListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SelectedDomainListResponse
        /// </returns>
        public async Task<SelectedDomainListResponse> SelectedDomainListWithOptionsAsync(SelectedDomainListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListDate))
            {
                query["ListDate"] = request.ListDate;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SelectedDomainList",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SelectedDomainListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectedDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectedDomainListResponse
        /// </returns>
        public SelectedDomainListResponse SelectedDomainList(SelectedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SelectedDomainListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>严选列表导出，明日凌晨2点前生成文件，导出凌晨1点前所有在售严选域名</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SelectedDomainListRequest
        /// </param>
        /// 
        /// <returns>
        /// SelectedDomainListResponse
        /// </returns>
        public async Task<SelectedDomainListResponse> SelectedDomainListAsync(SelectedDomainListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SelectedDomainListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交采购信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitPurchaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitPurchaseInfoResponse
        /// </returns>
        public SubmitPurchaseInfoResponse SubmitPurchaseInfoWithOptions(SubmitPurchaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseCurrency))
            {
                body["PurchaseCurrency"] = request.PurchaseCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchasePrice))
            {
                body["PurchasePrice"] = request.PurchasePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseProofs))
            {
                body["PurchaseProofs"] = request.PurchaseProofs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPurchaseInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPurchaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交采购信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitPurchaseInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SubmitPurchaseInfoResponse
        /// </returns>
        public async Task<SubmitPurchaseInfoResponse> SubmitPurchaseInfoWithOptionsAsync(SubmitPurchaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizId))
            {
                body["BizId"] = request.BizId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseCurrency))
            {
                body["PurchaseCurrency"] = request.PurchaseCurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchasePrice))
            {
                body["PurchasePrice"] = request.PurchasePrice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PurchaseProofs))
            {
                body["PurchaseProofs"] = request.PurchaseProofs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SubmitPurchaseInfo",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubmitPurchaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交采购信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitPurchaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitPurchaseInfoResponse
        /// </returns>
        public SubmitPurchaseInfoResponse SubmitPurchaseInfo(SubmitPurchaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitPurchaseInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交采购信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SubmitPurchaseInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SubmitPurchaseInfoResponse
        /// </returns>
        public async Task<SubmitPurchaseInfoResponse> SubmitPurchaseInfoAsync(SubmitPurchaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitPurchaseInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作方同步报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerReservePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerReservePriceResponse
        /// </returns>
        public UpdatePartnerReservePriceResponse UpdatePartnerReservePriceWithOptions(UpdatePartnerReservePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BiddingId))
            {
                body["BiddingId"] = request.BiddingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerType))
            {
                body["PartnerType"] = request.PartnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePrice))
            {
                body["ReservePrice"] = request.ReservePrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePartnerReservePrice",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePartnerReservePriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作方同步报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerReservePriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerReservePriceResponse
        /// </returns>
        public async Task<UpdatePartnerReservePriceResponse> UpdatePartnerReservePriceWithOptionsAsync(UpdatePartnerReservePriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BiddingId))
            {
                body["BiddingId"] = request.BiddingId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartnerType))
            {
                body["PartnerType"] = request.PartnerType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservePrice))
            {
                body["ReservePrice"] = request.ReservePrice;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePartnerReservePrice",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePartnerReservePriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作方同步报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerReservePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerReservePriceResponse
        /// </returns>
        public UpdatePartnerReservePriceResponse UpdatePartnerReservePrice(UpdatePartnerReservePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePartnerReservePriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>合作方同步报价</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePartnerReservePriceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePartnerReservePriceResponse
        /// </returns>
        public async Task<UpdatePartnerReservePriceResponse> UpdatePartnerReservePriceAsync(UpdatePartnerReservePriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePartnerReservePriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站添加DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteAddDnsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WebsiteAddDnsRecordResponse
        /// </returns>
        public WebsiteAddDnsRecordResponse WebsiteAddDnsRecordWithOptions(WebsiteAddDnsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsiteNo))
            {
                query["WebsiteNo"] = request.WebsiteNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebsiteAddDnsRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebsiteAddDnsRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站添加DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteAddDnsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WebsiteAddDnsRecordResponse
        /// </returns>
        public async Task<WebsiteAddDnsRecordResponse> WebsiteAddDnsRecordWithOptionsAsync(WebsiteAddDnsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsiteNo))
            {
                query["WebsiteNo"] = request.WebsiteNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebsiteAddDnsRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebsiteAddDnsRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站添加DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteAddDnsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// WebsiteAddDnsRecordResponse
        /// </returns>
        public WebsiteAddDnsRecordResponse WebsiteAddDnsRecord(WebsiteAddDnsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WebsiteAddDnsRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站添加DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteAddDnsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// WebsiteAddDnsRecordResponse
        /// </returns>
        public async Task<WebsiteAddDnsRecordResponse> WebsiteAddDnsRecordAsync(WebsiteAddDnsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WebsiteAddDnsRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站删除DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteDeleteDnsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WebsiteDeleteDnsRecordResponse
        /// </returns>
        public WebsiteDeleteDnsRecordResponse WebsiteDeleteDnsRecordWithOptions(WebsiteDeleteDnsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsiteNo))
            {
                query["WebsiteNo"] = request.WebsiteNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebsiteDeleteDnsRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebsiteDeleteDnsRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站删除DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteDeleteDnsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// WebsiteDeleteDnsRecordResponse
        /// </returns>
        public async Task<WebsiteDeleteDnsRecordResponse> WebsiteDeleteDnsRecordWithOptionsAsync(WebsiteDeleteDnsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["DomainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rr))
            {
                query["Rr"] = request.Rr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebsiteNo))
            {
                query["WebsiteNo"] = request.WebsiteNo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WebsiteDeleteDnsRecord",
                Version = "2018-02-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<WebsiteDeleteDnsRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站删除DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteDeleteDnsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// WebsiteDeleteDnsRecordResponse
        /// </returns>
        public WebsiteDeleteDnsRecordResponse WebsiteDeleteDnsRecord(WebsiteDeleteDnsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return WebsiteDeleteDnsRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>域名建站删除DNS记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// WebsiteDeleteDnsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// WebsiteDeleteDnsRecordResponse
        /// </returns>
        public async Task<WebsiteDeleteDnsRecordResponse> WebsiteDeleteDnsRecordAsync(WebsiteDeleteDnsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await WebsiteDeleteDnsRecordWithOptionsAsync(request, runtime);
        }

    }
}
