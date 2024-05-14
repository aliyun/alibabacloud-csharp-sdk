// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EduEmbed20240101.Models;

namespace AlibabaCloud.SDK.EduEmbed20240101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eduembed", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 创建实验预约
         *
         * @param request CreateLabReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabReservationResponse
         */
        public CreateLabReservationResponse CreateLabReservationWithOptions(CreateLabReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabId))
            {
                body["LabId"] = request.LabId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberCount))
            {
                body["MemberCount"] = request.MemberCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabReservation",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabReservationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验预约
         *
         * @param request CreateLabReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabReservationResponse
         */
        public async Task<CreateLabReservationResponse> CreateLabReservationWithOptionsAsync(CreateLabReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabId))
            {
                body["LabId"] = request.LabId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberCount))
            {
                body["MemberCount"] = request.MemberCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabReservation",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabReservationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验预约
         *
         * @param request CreateLabReservationRequest
         * @return CreateLabReservationResponse
         */
        public CreateLabReservationResponse CreateLabReservation(CreateLabReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLabReservationWithOptions(request, runtime);
        }

        /**
         * @summary 创建实验预约
         *
         * @param request CreateLabReservationRequest
         * @return CreateLabReservationResponse
         */
        public async Task<CreateLabReservationResponse> CreateLabReservationAsync(CreateLabReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLabReservationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建实验会话
         *
         * @param request CreateLabSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabSessionResponse
         */
        public CreateLabSessionResponse CreateLabSessionWithOptions(CreateLabSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabId))
            {
                body["LabId"] = request.LabId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamAccountId))
            {
                body["RamAccountId"] = request.RamAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabSession",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实验会话
         *
         * @param request CreateLabSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLabSessionResponse
         */
        public async Task<CreateLabSessionResponse> CreateLabSessionWithOptionsAsync(CreateLabSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabId))
            {
                body["LabId"] = request.LabId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamAccountId))
            {
                body["RamAccountId"] = request.RamAccountId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLabSession",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateLabSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实验会话
         *
         * @param request CreateLabSessionRequest
         * @return CreateLabSessionResponse
         */
        public CreateLabSessionResponse CreateLabSession(CreateLabSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLabSessionWithOptions(request, runtime);
        }

        /**
         * @summary 创建实验会话
         *
         * @param request CreateLabSessionRequest
         * @return CreateLabSessionResponse
         */
        public async Task<CreateLabSessionResponse> CreateLabSessionAsync(CreateLabSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLabSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看实验详情
         *
         * @param request DescribeLabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLabResponse
         */
        public DescribeLabResponse DescribeLabWithOptions(DescribeLabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLab",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLabResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看实验详情
         *
         * @param request DescribeLabRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLabResponse
         */
        public async Task<DescribeLabResponse> DescribeLabWithOptionsAsync(DescribeLabRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLab",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLabResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看实验详情
         *
         * @param request DescribeLabRequest
         * @return DescribeLabResponse
         */
        public DescribeLabResponse DescribeLab(DescribeLabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLabWithOptions(request, runtime);
        }

        /**
         * @summary 查看实验详情
         *
         * @param request DescribeLabRequest
         * @return DescribeLabResponse
         */
        public async Task<DescribeLabResponse> DescribeLabAsync(DescribeLabRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLabWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询实验预约
         *
         * @param request DescribeLabReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLabReservationResponse
         */
        public DescribeLabReservationResponse DescribeLabReservationWithOptions(DescribeLabReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLabReservation",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLabReservationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询实验预约
         *
         * @param request DescribeLabReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLabReservationResponse
         */
        public async Task<DescribeLabReservationResponse> DescribeLabReservationWithOptionsAsync(DescribeLabReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLabReservation",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLabReservationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询实验预约
         *
         * @param request DescribeLabReservationRequest
         * @return DescribeLabReservationResponse
         */
        public DescribeLabReservationResponse DescribeLabReservation(DescribeLabReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLabReservationWithOptions(request, runtime);
        }

        /**
         * @summary 查询实验预约
         *
         * @param request DescribeLabReservationRequest
         * @return DescribeLabReservationResponse
         */
        public async Task<DescribeLabReservationResponse> DescribeLabReservationAsync(DescribeLabReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLabReservationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看实验会话信息
         *
         * @param request DescribeLabSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLabSessionResponse
         */
        public DescribeLabSessionResponse DescribeLabSessionWithOptions(DescribeLabSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLabSession",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLabSessionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看实验会话信息
         *
         * @param request DescribeLabSessionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeLabSessionResponse
         */
        public async Task<DescribeLabSessionResponse> DescribeLabSessionWithOptionsAsync(DescribeLabSessionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeLabSession",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeLabSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看实验会话信息
         *
         * @param request DescribeLabSessionRequest
         * @return DescribeLabSessionResponse
         */
        public DescribeLabSessionResponse DescribeLabSession(DescribeLabSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLabSessionWithOptions(request, runtime);
        }

        /**
         * @summary 查看实验会话信息
         *
         * @param request DescribeLabSessionRequest
         * @return DescribeLabSessionResponse
         */
        public async Task<DescribeLabSessionResponse> DescribeLabSessionAsync(DescribeLabSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLabSessionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 分页查询实验预约
         *
         * @param request PageListLabReservationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListLabReservationsResponse
         */
        public PageListLabReservationsResponse PageListLabReservationsWithOptions(PageListLabReservationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListLabReservations",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListLabReservationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询实验预约
         *
         * @param request PageListLabReservationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListLabReservationsResponse
         */
        public async Task<PageListLabReservationsResponse> PageListLabReservationsWithOptionsAsync(PageListLabReservationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListLabReservations",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListLabReservationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询实验预约
         *
         * @param request PageListLabReservationsRequest
         * @return PageListLabReservationsResponse
         */
        public PageListLabReservationsResponse PageListLabReservations(PageListLabReservationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageListLabReservationsWithOptions(request, runtime);
        }

        /**
         * @summary 分页查询实验预约
         *
         * @param request PageListLabReservationsRequest
         * @return PageListLabReservationsResponse
         */
        public async Task<PageListLabReservationsResponse> PageListLabReservationsAsync(PageListLabReservationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageListLabReservationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 分页查询实验会话
         *
         * @param request PageListLabSessionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListLabSessionsResponse
         */
        public PageListLabSessionsResponse PageListLabSessionsWithOptions(PageListLabSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListLabSessions",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListLabSessionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询实验会话
         *
         * @param request PageListLabSessionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListLabSessionsResponse
         */
        public async Task<PageListLabSessionsResponse> PageListLabSessionsWithOptionsAsync(PageListLabSessionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListLabSessions",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListLabSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询实验会话
         *
         * @param request PageListLabSessionsRequest
         * @return PageListLabSessionsResponse
         */
        public PageListLabSessionsResponse PageListLabSessions(PageListLabSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageListLabSessionsWithOptions(request, runtime);
        }

        /**
         * @summary 分页查询实验会话
         *
         * @param request PageListLabSessionsRequest
         * @return PageListLabSessionsResponse
         */
        public async Task<PageListLabSessionsResponse> PageListLabSessionsAsync(PageListLabSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageListLabSessionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 分页查询实验
         *
         * @param request PageListLabsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListLabsResponse
         */
        public PageListLabsResponse PageListLabsWithOptions(PageListLabsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListLabs",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListLabsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 分页查询实验
         *
         * @param request PageListLabsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PageListLabsResponse
         */
        public async Task<PageListLabsResponse> PageListLabsWithOptionsAsync(PageListLabsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PageListLabs",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PageListLabsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 分页查询实验
         *
         * @param request PageListLabsRequest
         * @return PageListLabsResponse
         */
        public PageListLabsResponse PageListLabs(PageListLabsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PageListLabsWithOptions(request, runtime);
        }

        /**
         * @summary 分页查询实验
         *
         * @param request PageListLabsRequest
         * @return PageListLabsResponse
         */
        public async Task<PageListLabsResponse> PageListLabsAsync(PageListLabsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PageListLabsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 移除实验预约
         *
         * @param request RemoveLabReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveLabReservationResponse
         */
        public RemoveLabReservationResponse RemoveLabReservationWithOptions(RemoveLabReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabReservationId))
            {
                body["LabReservationId"] = request.LabReservationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveLabReservation",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveLabReservationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 移除实验预约
         *
         * @param request RemoveLabReservationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveLabReservationResponse
         */
        public async Task<RemoveLabReservationResponse> RemoveLabReservationWithOptionsAsync(RemoveLabReservationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountId))
            {
                body["AccountId"] = request.AccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LabReservationId))
            {
                body["LabReservationId"] = request.LabReservationId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveLabReservation",
                Version = "2024-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveLabReservationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 移除实验预约
         *
         * @param request RemoveLabReservationRequest
         * @return RemoveLabReservationResponse
         */
        public RemoveLabReservationResponse RemoveLabReservation(RemoveLabReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveLabReservationWithOptions(request, runtime);
        }

        /**
         * @summary 移除实验预约
         *
         * @param request RemoveLabReservationRequest
         * @return RemoveLabReservationResponse
         */
        public async Task<RemoveLabReservationResponse> RemoveLabReservationAsync(RemoveLabReservationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveLabReservationWithOptionsAsync(request, runtime);
        }

    }
}
