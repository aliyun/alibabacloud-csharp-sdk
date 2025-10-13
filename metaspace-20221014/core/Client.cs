// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Metaspace20221014.Models;

namespace AlibabaCloud.SDK.Metaspace20221014
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("metaspace", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>协同者发起流协同请求并获取协同ticket的API接口。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API为内部使用，主要用于协同者发起流协同。</description></item>
        /// <item><description><c>DependOnMainStream</c>参数指定了是否依赖主流的状态来建立或断开协同流。</description></item>
        /// <item><description>当<c>InitiatorType</c>设置为强制协同类型时（如<c>ADMIN_INITIATE_FORCE</c>或<c>COORDINATOR_INITIATE_FORCE</c>），将返回一个<c>CoordinateTicket</c>。</description></item>
        /// <item><description>协同资源列表<c>CoordinationResourceCandidates</c>中必须包含至少一项资源信息，并且所有提供的资源ID、类型和地区等信息需准确无误。</description></item>
        /// <item><description>确保<c>OwnerAliUid</c>与协同者的租户ID相同，否则可能无法成功发起协同请求。</description></item>
        /// <item><description>对于AD用户，请务必填写<c>AdDomainName</c>字段。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyCoordinationForCoordinatorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationForCoordinatorResponse
        /// </returns>
        public ApplyCoordinationForCoordinatorResponse ApplyCoordinationForCoordinatorWithOptions(ApplyCoordinationForCoordinatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoordinationResourceCandidates))
            {
                bodyFlat["CoordinationResourceCandidates"] = request.CoordinationResourceCandidates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorType))
            {
                body["InitiatorType"] = request.InitiatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
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
                Action = "ApplyCoordinationForCoordinator",
                Version = "2022-10-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCoordinationForCoordinatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协同者发起流协同请求并获取协同ticket的API接口。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API为内部使用，主要用于协同者发起流协同。</description></item>
        /// <item><description><c>DependOnMainStream</c>参数指定了是否依赖主流的状态来建立或断开协同流。</description></item>
        /// <item><description>当<c>InitiatorType</c>设置为强制协同类型时（如<c>ADMIN_INITIATE_FORCE</c>或<c>COORDINATOR_INITIATE_FORCE</c>），将返回一个<c>CoordinateTicket</c>。</description></item>
        /// <item><description>协同资源列表<c>CoordinationResourceCandidates</c>中必须包含至少一项资源信息，并且所有提供的资源ID、类型和地区等信息需准确无误。</description></item>
        /// <item><description>确保<c>OwnerAliUid</c>与协同者的租户ID相同，否则可能无法成功发起协同请求。</description></item>
        /// <item><description>对于AD用户，请务必填写<c>AdDomainName</c>字段。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyCoordinationForCoordinatorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationForCoordinatorResponse
        /// </returns>
        public async Task<ApplyCoordinationForCoordinatorResponse> ApplyCoordinationForCoordinatorWithOptionsAsync(ApplyCoordinationForCoordinatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoordinationResourceCandidates))
            {
                bodyFlat["CoordinationResourceCandidates"] = request.CoordinationResourceCandidates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatorType))
            {
                body["InitiatorType"] = request.InitiatorType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uuid))
            {
                body["Uuid"] = request.Uuid;
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
                Action = "ApplyCoordinationForCoordinator",
                Version = "2022-10-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyCoordinationForCoordinatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协同者发起流协同请求并获取协同ticket的API接口。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API为内部使用，主要用于协同者发起流协同。</description></item>
        /// <item><description><c>DependOnMainStream</c>参数指定了是否依赖主流的状态来建立或断开协同流。</description></item>
        /// <item><description>当<c>InitiatorType</c>设置为强制协同类型时（如<c>ADMIN_INITIATE_FORCE</c>或<c>COORDINATOR_INITIATE_FORCE</c>），将返回一个<c>CoordinateTicket</c>。</description></item>
        /// <item><description>协同资源列表<c>CoordinationResourceCandidates</c>中必须包含至少一项资源信息，并且所有提供的资源ID、类型和地区等信息需准确无误。</description></item>
        /// <item><description>确保<c>OwnerAliUid</c>与协同者的租户ID相同，否则可能无法成功发起协同请求。</description></item>
        /// <item><description>对于AD用户，请务必填写<c>AdDomainName</c>字段。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyCoordinationForCoordinatorRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationForCoordinatorResponse
        /// </returns>
        public ApplyCoordinationForCoordinatorResponse ApplyCoordinationForCoordinator(ApplyCoordinationForCoordinatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyCoordinationForCoordinatorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>协同者发起流协同请求并获取协同ticket的API接口。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该API为内部使用，主要用于协同者发起流协同。</description></item>
        /// <item><description><c>DependOnMainStream</c>参数指定了是否依赖主流的状态来建立或断开协同流。</description></item>
        /// <item><description>当<c>InitiatorType</c>设置为强制协同类型时（如<c>ADMIN_INITIATE_FORCE</c>或<c>COORDINATOR_INITIATE_FORCE</c>），将返回一个<c>CoordinateTicket</c>。</description></item>
        /// <item><description>协同资源列表<c>CoordinationResourceCandidates</c>中必须包含至少一项资源信息，并且所有提供的资源ID、类型和地区等信息需准确无误。</description></item>
        /// <item><description>确保<c>OwnerAliUid</c>与协同者的租户ID相同，否则可能无法成功发起协同请求。</description></item>
        /// <item><description>对于AD用户，请务必填写<c>AdDomainName</c>字段。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ApplyCoordinationForCoordinatorRequest
        /// </param>
        /// 
        /// <returns>
        /// ApplyCoordinationForCoordinatorResponse
        /// </returns>
        public async Task<ApplyCoordinationForCoordinatorResponse> ApplyCoordinationForCoordinatorAsync(ApplyCoordinationForCoordinatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyCoordinationForCoordinatorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消协同请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCoordinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelCoordinationResponse
        /// </returns>
        public CancelCoordinationResponse CancelCoordinationWithOptions(CancelCoordinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoIds))
            {
                bodyFlat["CoIds"] = request.CoIds;
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
                Action = "CancelCoordination",
                Version = "2022-10-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCoordinationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消协同请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCoordinationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelCoordinationResponse
        /// </returns>
        public async Task<CancelCoordinationResponse> CancelCoordinationWithOptionsAsync(CancelCoordinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoIds))
            {
                bodyFlat["CoIds"] = request.CoIds;
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
                Action = "CancelCoordination",
                Version = "2022-10-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelCoordinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消协同请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCoordinationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelCoordinationResponse
        /// </returns>
        public CancelCoordinationResponse CancelCoordination(CancelCoordinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCoordinationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消协同请求</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelCoordinationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelCoordinationResponse
        /// </returns>
        public async Task<CancelCoordinationResponse> CancelCoordinationAsync(CancelCoordinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCoordinationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协同流连接ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoordinationTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCoordinationTicketResponse
        /// </returns>
        public GetCoordinationTicketResponse GetCoordinationTicketWithOptions(GetCoordinationTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoId))
            {
                body["CoId"] = request.CoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCoordinationTicket",
                Version = "2022-10-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCoordinationTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协同流连接ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoordinationTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCoordinationTicketResponse
        /// </returns>
        public async Task<GetCoordinationTicketResponse> GetCoordinationTicketWithOptionsAsync(GetCoordinationTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoId))
            {
                body["CoId"] = request.CoId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCoordinationTicket",
                Version = "2022-10-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCoordinationTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协同流连接ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoordinationTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCoordinationTicketResponse
        /// </returns>
        public GetCoordinationTicketResponse GetCoordinationTicket(GetCoordinationTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCoordinationTicketWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取协同流连接ticket</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCoordinationTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCoordinationTicketResponse
        /// </returns>
        public async Task<GetCoordinationTicketResponse> GetCoordinationTicketAsync(GetCoordinationTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCoordinationTicketWithOptionsAsync(request, runtime);
        }

    }
}
