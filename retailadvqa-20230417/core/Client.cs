// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Retailadvqa20230417.Models;

namespace AlibabaCloud.SDK.Retailadvqa20230417
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("retailadvqa", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 开放平台同步会员基础信息
         *
         * @param tmpReq AddMemberBasicInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMemberBasicInfoResponse
         */
        public AddMemberBasicInfoResponse AddMemberBasicInfoWithOptions(AddMemberBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddMemberBasicInfoShrinkRequest request = new AddMemberBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMemberBasicInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开放平台同步会员基础信息
         *
         * @param tmpReq AddMemberBasicInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AddMemberBasicInfoResponse
         */
        public async Task<AddMemberBasicInfoResponse> AddMemberBasicInfoWithOptionsAsync(AddMemberBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddMemberBasicInfoShrinkRequest request = new AddMemberBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddMemberBasicInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddMemberBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开放平台同步会员基础信息
         *
         * @param request AddMemberBasicInfoRequest
         * @return AddMemberBasicInfoResponse
         */
        public AddMemberBasicInfoResponse AddMemberBasicInfo(AddMemberBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMemberBasicInfoWithOptions(request, runtime);
        }

        /**
         * @summary 开放平台同步会员基础信息
         *
         * @param request AddMemberBasicInfoRequest
         * @return AddMemberBasicInfoResponse
         */
        public async Task<AddMemberBasicInfoResponse> AddMemberBasicInfoAsync(AddMemberBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMemberBasicInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 批量保存订单信息
         *
         * @param tmpReq BatchSaveOrderPopRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSaveOrderPopResponse
         */
        public BatchSaveOrderPopResponse BatchSaveOrderPopWithOptions(BatchSaveOrderPopRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchSaveOrderPopShrinkRequest request = new BatchSaveOrderPopShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Orders))
            {
                request.OrdersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Orders, "Orders", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrdersShrink))
            {
                query["Orders"] = request.OrdersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSaveOrderPop",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSaveOrderPopResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 批量保存订单信息
         *
         * @param tmpReq BatchSaveOrderPopRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return BatchSaveOrderPopResponse
         */
        public async Task<BatchSaveOrderPopResponse> BatchSaveOrderPopWithOptionsAsync(BatchSaveOrderPopRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            BatchSaveOrderPopShrinkRequest request = new BatchSaveOrderPopShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Orders))
            {
                request.OrdersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Orders, "Orders", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrdersShrink))
            {
                query["Orders"] = request.OrdersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSaveOrderPop",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSaveOrderPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 批量保存订单信息
         *
         * @param request BatchSaveOrderPopRequest
         * @return BatchSaveOrderPopResponse
         */
        public BatchSaveOrderPopResponse BatchSaveOrderPop(BatchSaveOrderPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSaveOrderPopWithOptions(request, runtime);
        }

        /**
         * @summary 批量保存订单信息
         *
         * @param request BatchSaveOrderPopRequest
         * @return BatchSaveOrderPopResponse
         */
        public async Task<BatchSaveOrderPopResponse> BatchSaveOrderPopAsync(BatchSaveOrderPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSaveOrderPopWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会员等级初始化
         *
         * @param tmpReq CalculateMemberLevelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CalculateMemberLevelResponse
         */
        public CalculateMemberLevelResponse CalculateMemberLevelWithOptions(CalculateMemberLevelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CalculateMemberLevelShrinkRequest request = new CalculateMemberLevelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["Body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalculateMemberLevel",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalculateMemberLevelResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会员等级初始化
         *
         * @param tmpReq CalculateMemberLevelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CalculateMemberLevelResponse
         */
        public async Task<CalculateMemberLevelResponse> CalculateMemberLevelWithOptionsAsync(CalculateMemberLevelRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CalculateMemberLevelShrinkRequest request = new CalculateMemberLevelShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["Body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CalculateMemberLevel",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CalculateMemberLevelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会员等级初始化
         *
         * @param request CalculateMemberLevelRequest
         * @return CalculateMemberLevelResponse
         */
        public CalculateMemberLevelResponse CalculateMemberLevel(CalculateMemberLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CalculateMemberLevelWithOptions(request, runtime);
        }

        /**
         * @summary 会员等级初始化
         *
         * @param request CalculateMemberLevelRequest
         * @return CalculateMemberLevelResponse
         */
        public async Task<CalculateMemberLevelResponse> CalculateMemberLevelAsync(CalculateMemberLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CalculateMemberLevelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会员信息编辑API
         *
         * @param tmpReq EditMemberBasicInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditMemberBasicInfoResponse
         */
        public EditMemberBasicInfoResponse EditMemberBasicInfoWithOptions(EditMemberBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditMemberBasicInfoShrinkRequest request = new EditMemberBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["Body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditMemberBasicInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditMemberBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会员信息编辑API
         *
         * @param tmpReq EditMemberBasicInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EditMemberBasicInfoResponse
         */
        public async Task<EditMemberBasicInfoResponse> EditMemberBasicInfoWithOptionsAsync(EditMemberBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            EditMemberBasicInfoShrinkRequest request = new EditMemberBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "Body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["Body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EditMemberBasicInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EditMemberBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会员信息编辑API
         *
         * @param request EditMemberBasicInfoRequest
         * @return EditMemberBasicInfoResponse
         */
        public EditMemberBasicInfoResponse EditMemberBasicInfo(EditMemberBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditMemberBasicInfoWithOptions(request, runtime);
        }

        /**
         * @summary 会员信息编辑API
         *
         * @param request EditMemberBasicInfoRequest
         * @return EditMemberBasicInfoResponse
         */
        public async Task<EditMemberBasicInfoResponse> EditMemberBasicInfoAsync(EditMemberBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditMemberBasicInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开放平台会员积分明细查询
         *
         * @param tmpReq MemberAccountDetailPageQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MemberAccountDetailPageQueryResponse
         */
        public MemberAccountDetailPageQueryResponse MemberAccountDetailPageQueryWithOptions(MemberAccountDetailPageQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MemberAccountDetailPageQueryShrinkRequest request = new MemberAccountDetailPageQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MemberAccountDetailPageQuery",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MemberAccountDetailPageQueryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开放平台会员积分明细查询
         *
         * @param tmpReq MemberAccountDetailPageQueryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MemberAccountDetailPageQueryResponse
         */
        public async Task<MemberAccountDetailPageQueryResponse> MemberAccountDetailPageQueryWithOptionsAsync(MemberAccountDetailPageQueryRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MemberAccountDetailPageQueryShrinkRequest request = new MemberAccountDetailPageQueryShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MemberAccountDetailPageQuery",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MemberAccountDetailPageQueryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开放平台会员积分明细查询
         *
         * @param request MemberAccountDetailPageQueryRequest
         * @return MemberAccountDetailPageQueryResponse
         */
        public MemberAccountDetailPageQueryResponse MemberAccountDetailPageQuery(MemberAccountDetailPageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MemberAccountDetailPageQueryWithOptions(request, runtime);
        }

        /**
         * @summary 开放平台会员积分明细查询
         *
         * @param request MemberAccountDetailPageQueryRequest
         * @return MemberAccountDetailPageQueryResponse
         */
        public async Task<MemberAccountDetailPageQueryResponse> MemberAccountDetailPageQueryAsync(MemberAccountDetailPageQueryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MemberAccountDetailPageQueryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 会员积分变更
         *
         * @param tmpReq MemberPointChangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MemberPointChangeResponse
         */
        public MemberPointChangeResponse MemberPointChangeWithOptions(MemberPointChangeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MemberPointChangeShrinkRequest request = new MemberPointChangeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MemberPointChange",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MemberPointChangeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 会员积分变更
         *
         * @param tmpReq MemberPointChangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return MemberPointChangeResponse
         */
        public async Task<MemberPointChangeResponse> MemberPointChangeWithOptionsAsync(MemberPointChangeRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            MemberPointChangeShrinkRequest request = new MemberPointChangeShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MemberPointChange",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MemberPointChangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 会员积分变更
         *
         * @param request MemberPointChangeRequest
         * @return MemberPointChangeResponse
         */
        public MemberPointChangeResponse MemberPointChange(MemberPointChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MemberPointChangeWithOptions(request, runtime);
        }

        /**
         * @summary 会员积分变更
         *
         * @param request MemberPointChangeRequest
         * @return MemberPointChangeResponse
         */
        public async Task<MemberPointChangeResponse> MemberPointChangeAsync(MemberPointChangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MemberPointChangeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询会员基础信息
         *
         * @param tmpReq QueryMemberBasicInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMemberBasicInfoResponse
         */
        public QueryMemberBasicInfoResponse QueryMemberBasicInfoWithOptions(QueryMemberBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMemberBasicInfoShrinkRequest request = new QueryMemberBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMemberBasicInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMemberBasicInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询会员基础信息
         *
         * @param tmpReq QueryMemberBasicInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMemberBasicInfoResponse
         */
        public async Task<QueryMemberBasicInfoResponse> QueryMemberBasicInfoWithOptionsAsync(QueryMemberBasicInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            QueryMemberBasicInfoShrinkRequest request = new QueryMemberBasicInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMemberBasicInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMemberBasicInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询会员基础信息
         *
         * @param request QueryMemberBasicInfoRequest
         * @return QueryMemberBasicInfoResponse
         */
        public QueryMemberBasicInfoResponse QueryMemberBasicInfo(QueryMemberBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMemberBasicInfoWithOptions(request, runtime);
        }

        /**
         * @summary 查询会员基础信息
         *
         * @param request QueryMemberBasicInfoRequest
         * @return QueryMemberBasicInfoResponse
         */
        public async Task<QueryMemberBasicInfoResponse> QueryMemberBasicInfoAsync(QueryMemberBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMemberBasicInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 卡券信息同步
         *
         * @param tmpReq SyncCardInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncCardInfoResponse
         */
        public SyncCardInfoResponse SyncCardInfoWithOptions(SyncCardInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncCardInfoShrinkRequest request = new SyncCardInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncCardInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncCardInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 卡券信息同步
         *
         * @param tmpReq SyncCardInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncCardInfoResponse
         */
        public async Task<SyncCardInfoResponse> SyncCardInfoWithOptionsAsync(SyncCardInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncCardInfoShrinkRequest request = new SyncCardInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncCardInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncCardInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 卡券信息同步
         *
         * @param request SyncCardInfoRequest
         * @return SyncCardInfoResponse
         */
        public SyncCardInfoResponse SyncCardInfo(SyncCardInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncCardInfoWithOptions(request, runtime);
        }

        /**
         * @summary 卡券信息同步
         *
         * @param request SyncCardInfoRequest
         * @return SyncCardInfoResponse
         */
        public async Task<SyncCardInfoResponse> SyncCardInfoAsync(SyncCardInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncCardInfoWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 开放平台会员行为信息同步
         *
         * @param tmpReq SyncMemberBehaviorInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncMemberBehaviorInfoResponse
         */
        public SyncMemberBehaviorInfoResponse SyncMemberBehaviorInfoWithOptions(SyncMemberBehaviorInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncMemberBehaviorInfoShrinkRequest request = new SyncMemberBehaviorInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMemberBehaviorInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMemberBehaviorInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 开放平台会员行为信息同步
         *
         * @param tmpReq SyncMemberBehaviorInfoRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncMemberBehaviorInfoResponse
         */
        public async Task<SyncMemberBehaviorInfoResponse> SyncMemberBehaviorInfoWithOptionsAsync(SyncMemberBehaviorInfoRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SyncMemberBehaviorInfoShrinkRequest request = new SyncMemberBehaviorInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Body))
            {
                request.BodyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Body, "body", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BodyShrink))
            {
                query["body"] = request.BodyShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncMemberBehaviorInfo",
                Version = "2023-04-17",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncMemberBehaviorInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 开放平台会员行为信息同步
         *
         * @param request SyncMemberBehaviorInfoRequest
         * @return SyncMemberBehaviorInfoResponse
         */
        public SyncMemberBehaviorInfoResponse SyncMemberBehaviorInfo(SyncMemberBehaviorInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncMemberBehaviorInfoWithOptions(request, runtime);
        }

        /**
         * @summary 开放平台会员行为信息同步
         *
         * @param request SyncMemberBehaviorInfoRequest
         * @return SyncMemberBehaviorInfoResponse
         */
        public async Task<SyncMemberBehaviorInfoResponse> SyncMemberBehaviorInfoAsync(SyncMemberBehaviorInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncMemberBehaviorInfoWithOptionsAsync(request, runtime);
        }

    }
}
