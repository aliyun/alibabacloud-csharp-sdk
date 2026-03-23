// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Workorder20200801.Models;

namespace AlibabaCloud.SDK.Workorder20200801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "workorder.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-1", "workorder.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("workorder", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        [Obsolete("OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.")]
        // Deprecated
        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonQuestionId))
            {
                query["CommonQuestionId"] = request.CommonQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameList))
            {
                query["FileNameList"] = request.FileNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTimeRange))
            {
                query["NotifyTimeRange"] = request.NotifyTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretContent))
            {
                query["SecretContent"] = request.SecretContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        [Obsolete("OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.")]
        // Deprecated
        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommonQuestionId))
            {
                query["CommonQuestionId"] = request.CommonQuestionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Email))
            {
                query["Email"] = request.Email;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileNameList))
            {
                query["FileNameList"] = request.FileNameList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyTimeRange))
            {
                query["NotifyTimeRange"] = request.NotifyTimeRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Phone))
            {
                query["Phone"] = request.Phone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretContent))
            {
                query["SecretContent"] = request.SecretContent;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                query["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        [Obsolete("OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.")]
        // Deprecated
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTicketWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.
        /// 
        /// <param name="request">
        /// CreateTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTicketResponse
        /// </returns>
        [Obsolete("OpenAPI CreateTicket is deprecated, please use Workorder::2021-06-10::CreateTicket instead.")]
        // Deprecated
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTicketWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAttachmentUploadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUploadUrlResponse
        /// </returns>
        public GetAttachmentUploadUrlResponse GetAttachmentUploadUrlWithOptions(GetAttachmentUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttachmentUploadUrl",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentUploadUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAttachmentUploadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUploadUrlResponse
        /// </returns>
        public async Task<GetAttachmentUploadUrlResponse> GetAttachmentUploadUrlWithOptionsAsync(GetAttachmentUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttachmentUploadUrl",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentUploadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAttachmentUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUploadUrlResponse
        /// </returns>
        public GetAttachmentUploadUrlResponse GetAttachmentUploadUrl(GetAttachmentUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAttachmentUploadUrlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAttachmentUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUploadUrlResponse
        /// </returns>
        public async Task<GetAttachmentUploadUrlResponse> GetAttachmentUploadUrlAsync(GetAttachmentUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAttachmentUploadUrlWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// GetAttachmentUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUrlResponse
        /// </returns>
        public GetAttachmentUrlResponse GetAttachmentUrlWithOptions(GetAttachmentUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachName))
            {
                query["AttachName"] = request.AttachName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoteId))
            {
                query["NoteId"] = request.NoteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketId))
            {
                query["TicketId"] = request.TicketId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttachmentUrl",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAttachmentUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUrlResponse
        /// </returns>
        public async Task<GetAttachmentUrlResponse> GetAttachmentUrlWithOptionsAsync(GetAttachmentUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachName))
            {
                query["AttachName"] = request.AttachName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NoteId))
            {
                query["NoteId"] = request.NoteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketId))
            {
                query["TicketId"] = request.TicketId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttachmentUrl",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttachmentUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// GetAttachmentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUrlResponse
        /// </returns>
        public GetAttachmentUrlResponse GetAttachmentUrl(GetAttachmentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAttachmentUrlWithOptions(request, runtime);
        }

        /// <param name="request">
        /// GetAttachmentUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttachmentUrlResponse
        /// </returns>
        public async Task<GetAttachmentUrlResponse> GetAttachmentUrlAsync(GetAttachmentUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAttachmentUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.
        /// 
        /// <param name="request">
        /// GetTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTicketResponse
        /// </returns>
        [Obsolete("OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.")]
        // Deprecated
        public GetTicketResponse GetTicketWithOptions(GetTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketId))
            {
                query["TicketId"] = request.TicketId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTicket",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTicketResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.
        /// 
        /// <param name="request">
        /// GetTicketRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTicketResponse
        /// </returns>
        [Obsolete("OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.")]
        // Deprecated
        public async Task<GetTicketResponse> GetTicketWithOptionsAsync(GetTicketRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketId))
            {
                query["TicketId"] = request.TicketId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTicket",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTicketResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.
        /// 
        /// <param name="request">
        /// GetTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTicketResponse
        /// </returns>
        [Obsolete("OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.")]
        // Deprecated
        public GetTicketResponse GetTicket(GetTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTicketWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.
        /// 
        /// <param name="request">
        /// GetTicketRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTicketResponse
        /// </returns>
        [Obsolete("OpenAPI GetTicket is deprecated, please use Workorder::2021-06-10::GetTicket instead.")]
        // Deprecated
        public async Task<GetTicketResponse> GetTicketAsync(GetTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTicketWithOptionsAsync(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.
        /// 
        /// <param name="request">
        /// ListTicketsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
        [Obsolete("OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.")]
        // Deprecated
        public ListTicketsResponse ListTicketsWithOptions(ListTicketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedAfterTime))
            {
                query["CreatedAfterTime"] = request.CreatedAfterTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedBeforeTime))
            {
                query["CreatedBeforeTime"] = request.CreatedBeforeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraConditionList))
            {
                query["ExtraConditionList"] = request.ExtraConditionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["PageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketStatus))
            {
                query["TicketStatus"] = request.TicketStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTickets",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTicketsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.
        /// 
        /// <param name="request">
        /// ListTicketsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
        [Obsolete("OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.")]
        // Deprecated
        public async Task<ListTicketsResponse> ListTicketsWithOptionsAsync(ListTicketsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedAfterTime))
            {
                query["CreatedAfterTime"] = request.CreatedAfterTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedBeforeTime))
            {
                query["CreatedBeforeTime"] = request.CreatedBeforeTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraConditionList))
            {
                query["ExtraConditionList"] = request.ExtraConditionList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ids))
            {
                query["Ids"] = request.Ids;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageStart))
            {
                query["PageStart"] = request.PageStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["ProductCode"] = request.ProductCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketStatus))
            {
                query["TicketStatus"] = request.TicketStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTickets",
                Version = "2020-08-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTicketsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.
        /// 
        /// <param name="request">
        /// ListTicketsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
        [Obsolete("OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.")]
        // Deprecated
        public ListTicketsResponse ListTickets(ListTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTicketsWithOptions(request, runtime);
        }

        /// <term><b>Deprecated</b></term>
        /// 
        /// OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.
        /// 
        /// <param name="request">
        /// ListTicketsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTicketsResponse
        /// </returns>
        [Obsolete("OpenAPI ListTickets is deprecated, please use Workorder::2021-06-10::ListTickets instead.")]
        // Deprecated
        public async Task<ListTicketsResponse> ListTicketsAsync(ListTicketsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTicketsWithOptionsAsync(request, runtime);
        }

    }
}
