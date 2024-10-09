// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Marketing_event20210101.Models;

namespace AlibabaCloud.SDK.Marketing_event20210101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("marketing_event", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// AddSumRecordFlowPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSumRecordFlowPopResponse
        /// </returns>
        public AddSumRecordFlowPopResponse AddSumRecordFlowPopWithOptions(AddSumRecordFlowPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceName))
            {
                query["ConferenceName"] = request.ConferenceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryName))
            {
                query["EntryName"] = request.EntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idcard))
            {
                query["Idcard"] = request.Idcard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignTime))
            {
                query["SignTime"] = request.SignTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSumRecordFlowPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSumRecordFlowPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// AddSumRecordFlowPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddSumRecordFlowPopResponse
        /// </returns>
        public async Task<AddSumRecordFlowPopResponse> AddSumRecordFlowPopWithOptionsAsync(AddSumRecordFlowPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceName))
            {
                query["ConferenceName"] = request.ConferenceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryName))
            {
                query["EntryName"] = request.EntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idcard))
            {
                query["Idcard"] = request.Idcard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignTime))
            {
                query["SignTime"] = request.SignTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddSumRecordFlowPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddSumRecordFlowPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// AddSumRecordFlowPopRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSumRecordFlowPopResponse
        /// </returns>
        public AddSumRecordFlowPopResponse AddSumRecordFlowPop(AddSumRecordFlowPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSumRecordFlowPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// AddSumRecordFlowPopRequest
        /// </param>
        /// 
        /// <returns>
        /// AddSumRecordFlowPopResponse
        /// </returns>
        public async Task<AddSumRecordFlowPopResponse> AddSumRecordFlowPopAsync(AddSumRecordFlowPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSumRecordFlowPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BindExhibitorRfidPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindExhibitorRfidPopResponse
        /// </returns>
        public BindExhibitorRfidPopResponse BindExhibitorRfidPopWithOptions(BindExhibitorRfidPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                query["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                query["GmtModified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestTicketRecordId))
            {
                query["GuestTicketRecordId"] = request.GuestTicketRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rfid))
            {
                query["Rfid"] = request.Rfid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketCode))
            {
                query["TicketCode"] = request.TicketCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindExhibitorRfidPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindExhibitorRfidPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BindExhibitorRfidPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindExhibitorRfidPopResponse
        /// </returns>
        public async Task<BindExhibitorRfidPopResponse> BindExhibitorRfidPopWithOptionsAsync(BindExhibitorRfidPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                query["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                query["GmtModified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestTicketRecordId))
            {
                query["GuestTicketRecordId"] = request.GuestTicketRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rfid))
            {
                query["Rfid"] = request.Rfid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketCode))
            {
                query["TicketCode"] = request.TicketCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindExhibitorRfidPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindExhibitorRfidPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BindExhibitorRfidPopRequest
        /// </param>
        /// 
        /// <returns>
        /// BindExhibitorRfidPopResponse
        /// </returns>
        public BindExhibitorRfidPopResponse BindExhibitorRfidPop(BindExhibitorRfidPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindExhibitorRfidPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BindExhibitorRfidPopRequest
        /// </param>
        /// 
        /// <returns>
        /// BindExhibitorRfidPopResponse
        /// </returns>
        public async Task<BindExhibitorRfidPopResponse> BindExhibitorRfidPopAsync(BindExhibitorRfidPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindExhibitorRfidPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// BindGuestRfidPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindGuestRfidPopResponse
        /// </returns>
        public BindGuestRfidPopResponse BindGuestRfidPopWithOptions(BindGuestRfidPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                query["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                query["GmtModified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestTicketRecordId))
            {
                query["GuestTicketRecordId"] = request.GuestTicketRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rfid))
            {
                query["Rfid"] = request.Rfid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketCode))
            {
                query["TicketCode"] = request.TicketCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindGuestRfidPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindGuestRfidPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// BindGuestRfidPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BindGuestRfidPopResponse
        /// </returns>
        public async Task<BindGuestRfidPopResponse> BindGuestRfidPopWithOptionsAsync(BindGuestRfidPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtCreate))
            {
                query["GmtCreate"] = request.GmtCreate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GmtModified))
            {
                query["GmtModified"] = request.GmtModified;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GuestTicketRecordId))
            {
                query["GuestTicketRecordId"] = request.GuestTicketRecordId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["Id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rfid))
            {
                query["Rfid"] = request.Rfid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TicketCode))
            {
                query["TicketCode"] = request.TicketCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindGuestRfidPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindGuestRfidPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// BindGuestRfidPopRequest
        /// </param>
        /// 
        /// <returns>
        /// BindGuestRfidPopResponse
        /// </returns>
        public BindGuestRfidPopResponse BindGuestRfidPop(BindGuestRfidPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindGuestRfidPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// BindGuestRfidPopRequest
        /// </param>
        /// 
        /// <returns>
        /// BindGuestRfidPopResponse
        /// </returns>
        public async Task<BindGuestRfidPopResponse> BindGuestRfidPopAsync(BindGuestRfidPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindGuestRfidPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// CheckNFCBindPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckNFCBindPopResponse
        /// </returns>
        public CheckNFCBindPopResponse CheckNFCBindPopWithOptions(CheckNFCBindPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NfcId))
            {
                query["NfcId"] = request.NfcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckNFCBindPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckNFCBindPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// CheckNFCBindPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckNFCBindPopResponse
        /// </returns>
        public async Task<CheckNFCBindPopResponse> CheckNFCBindPopWithOptionsAsync(CheckNFCBindPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NfcId))
            {
                query["NfcId"] = request.NfcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckNFCBindPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckNFCBindPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// CheckNFCBindPopRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckNFCBindPopResponse
        /// </returns>
        public CheckNFCBindPopResponse CheckNFCBindPop(CheckNFCBindPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckNFCBindPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// CheckNFCBindPopRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckNFCBindPopResponse
        /// </returns>
        public async Task<CheckNFCBindPopResponse> CheckNFCBindPopAsync(CheckNFCBindPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckNFCBindPopWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取领证人员记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestCredentialsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindGuestCredentialsRecordResponse
        /// </returns>
        public FindGuestCredentialsRecordResponse FindGuestCredentialsRecordWithOptions(FindGuestCredentialsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestCredentialsRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestCredentialsRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取领证人员记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestCredentialsRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindGuestCredentialsRecordResponse
        /// </returns>
        public async Task<FindGuestCredentialsRecordResponse> FindGuestCredentialsRecordWithOptionsAsync(FindGuestCredentialsRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestCredentialsRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestCredentialsRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取领证人员记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestCredentialsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// FindGuestCredentialsRecordResponse
        /// </returns>
        public FindGuestCredentialsRecordResponse FindGuestCredentialsRecord(FindGuestCredentialsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindGuestCredentialsRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>拉取领证人员记录</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestCredentialsRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// FindGuestCredentialsRecordResponse
        /// </returns>
        public async Task<FindGuestCredentialsRecordResponse> FindGuestCredentialsRecordAsync(FindGuestCredentialsRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindGuestCredentialsRecordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云栖大会获取取票人信息list接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestTicketRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindGuestTicketRecordResponse
        /// </returns>
        public FindGuestTicketRecordResponse FindGuestTicketRecordWithOptions(FindGuestTicketRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestTicketRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestTicketRecordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云栖大会获取取票人信息list接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestTicketRecordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FindGuestTicketRecordResponse
        /// </returns>
        public async Task<FindGuestTicketRecordResponse> FindGuestTicketRecordWithOptionsAsync(FindGuestTicketRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTimeString))
            {
                query["DateTimeString"] = request.DateTimeString;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDateTime))
            {
                query["EndDateTime"] = request.EndDateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDateTime))
            {
                query["StartDateTime"] = request.StartDateTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FindGuestTicketRecord",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FindGuestTicketRecordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云栖大会获取取票人信息list接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestTicketRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// FindGuestTicketRecordResponse
        /// </returns>
        public FindGuestTicketRecordResponse FindGuestTicketRecord(FindGuestTicketRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FindGuestTicketRecordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>云栖大会获取取票人信息list接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FindGuestTicketRecordRequest
        /// </param>
        /// 
        /// <returns>
        /// FindGuestTicketRecordResponse
        /// </returns>
        public async Task<FindGuestTicketRecordResponse> FindGuestTicketRecordAsync(FindGuestTicketRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FindGuestTicketRecordWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryAllActivityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllActivityInfoResponse
        /// </returns>
        public QueryAllActivityInfoResponse QueryAllActivityInfoWithOptions(QueryAllActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllActivityInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAllActivityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryAllActivityInfoResponse
        /// </returns>
        public async Task<QueryAllActivityInfoResponse> QueryAllActivityInfoWithOptionsAsync(QueryAllActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryAllActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryAllActivityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryAllActivityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllActivityInfoResponse
        /// </returns>
        public QueryAllActivityInfoResponse QueryAllActivityInfo(QueryAllActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAllActivityInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryAllActivityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryAllActivityInfoResponse
        /// </returns>
        public async Task<QueryAllActivityInfoResponse> QueryAllActivityInfoAsync(QueryAllActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAllActivityInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QueryOrderSessionListPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderSessionListPopResponse
        /// </returns>
        public QueryOrderSessionListPopResponse QueryOrderSessionListPopWithOptions(QueryOrderSessionListPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NfcId))
            {
                query["NfcId"] = request.NfcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderSessionListPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderSessionListPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryOrderSessionListPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderSessionListPopResponse
        /// </returns>
        public async Task<QueryOrderSessionListPopResponse> QueryOrderSessionListPopWithOptionsAsync(QueryOrderSessionListPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NfcId))
            {
                query["NfcId"] = request.NfcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryOrderSessionListPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryOrderSessionListPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QueryOrderSessionListPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderSessionListPopResponse
        /// </returns>
        public QueryOrderSessionListPopResponse QueryOrderSessionListPop(QueryOrderSessionListPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOrderSessionListPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QueryOrderSessionListPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryOrderSessionListPopResponse
        /// </returns>
        public async Task<QueryOrderSessionListPopResponse> QueryOrderSessionListPopAsync(QueryOrderSessionListPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOrderSessionListPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QuerySessionByActivityIdPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByActivityIdPopResponse
        /// </returns>
        public QuerySessionByActivityIdPopResponse QuerySessionByActivityIdPopWithOptions(QuerySessionByActivityIdPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionByActivityIdPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionByActivityIdPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySessionByActivityIdPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByActivityIdPopResponse
        /// </returns>
        public async Task<QuerySessionByActivityIdPopResponse> QuerySessionByActivityIdPopWithOptionsAsync(QuerySessionByActivityIdPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionByActivityIdPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionByActivityIdPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySessionByActivityIdPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByActivityIdPopResponse
        /// </returns>
        public QuerySessionByActivityIdPopResponse QuerySessionByActivityIdPop(QuerySessionByActivityIdPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySessionByActivityIdPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QuerySessionByActivityIdPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionByActivityIdPopResponse
        /// </returns>
        public async Task<QuerySessionByActivityIdPopResponse> QuerySessionByActivityIdPopAsync(QuerySessionByActivityIdPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySessionByActivityIdPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QuerySessionListPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionListPopResponse
        /// </returns>
        public QuerySessionListPopResponse QuerySessionListPopWithOptions(QuerySessionListPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NfcId))
            {
                query["NfcId"] = request.NfcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionListPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionListPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySessionListPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionListPopResponse
        /// </returns>
        public async Task<QuerySessionListPopResponse> QuerySessionListPopWithOptionsAsync(QuerySessionListPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NfcId))
            {
                query["NfcId"] = request.NfcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySessionListPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySessionListPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySessionListPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionListPopResponse
        /// </returns>
        public QuerySessionListPopResponse QuerySessionListPop(QuerySessionListPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySessionListPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QuerySessionListPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySessionListPopResponse
        /// </returns>
        public async Task<QuerySessionListPopResponse> QuerySessionListPopAsync(QuerySessionListPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySessionListPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QuerySignInRecordPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySignInRecordPopResponse
        /// </returns>
        public QuerySignInRecordPopResponse QuerySignInRecordPopWithOptions(QuerySignInRecordPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySignInRecordPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySignInRecordPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySignInRecordPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySignInRecordPopResponse
        /// </returns>
        public async Task<QuerySignInRecordPopResponse> QuerySignInRecordPopWithOptionsAsync(QuerySignInRecordPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySignInRecordPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySignInRecordPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySignInRecordPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySignInRecordPopResponse
        /// </returns>
        public QuerySignInRecordPopResponse QuerySignInRecordPop(QuerySignInRecordPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySignInRecordPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QuerySignInRecordPopRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySignInRecordPopResponse
        /// </returns>
        public async Task<QuerySignInRecordPopResponse> QuerySignInRecordPopAsync(QuerySignInRecordPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySignInRecordPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// QuerySingleActivityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleActivityInfoResponse
        /// </returns>
        public QuerySingleActivityInfoResponse QuerySingleActivityInfoWithOptions(QuerySingleActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleActivityInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySingleActivityInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleActivityInfoResponse
        /// </returns>
        public async Task<QuerySingleActivityInfoResponse> QuerySingleActivityInfoWithOptionsAsync(QuerySingleActivityInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QuerySingleActivityInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QuerySingleActivityInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// QuerySingleActivityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleActivityInfoResponse
        /// </returns>
        public QuerySingleActivityInfoResponse QuerySingleActivityInfo(QuerySingleActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySingleActivityInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// QuerySingleActivityInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// QuerySingleActivityInfoResponse
        /// </returns>
        public async Task<QuerySingleActivityInfoResponse> QuerySingleActivityInfoAsync(QuerySingleActivityInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySingleActivityInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// SyncSignInInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSignInInfoResponse
        /// </returns>
        public SyncSignInInfoResponse SyncSignInInfoWithOptions(SyncSignInInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSignInInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSignInInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// SyncSignInInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncSignInInfoResponse
        /// </returns>
        public async Task<SyncSignInInfoResponse> SyncSignInInfoWithOptionsAsync(SyncSignInInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncSignInInfo",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncSignInInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// SyncSignInInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSignInInfoResponse
        /// </returns>
        public SyncSignInInfoResponse SyncSignInInfo(SyncSignInInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncSignInInfoWithOptions(request, runtime);
        }

        /// <param name="request">
        /// SyncSignInInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncSignInInfoResponse
        /// </returns>
        public async Task<SyncSignInInfoResponse> SyncSignInInfoAsync(SyncSignInInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncSignInInfoWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// TicketOrCredentialsSignInPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketOrCredentialsSignInPopResponse
        /// </returns>
        public TicketOrCredentialsSignInPopResponse TicketOrCredentialsSignInPopWithOptions(TicketOrCredentialsSignInPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceName))
            {
                query["ConferenceName"] = request.ConferenceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryName))
            {
                query["EntryName"] = request.EntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idcard))
            {
                query["Idcard"] = request.Idcard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignTime))
            {
                query["SignTime"] = request.SignTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketOrCredentialsSignInPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketOrCredentialsSignInPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// TicketOrCredentialsSignInPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TicketOrCredentialsSignInPopResponse
        /// </returns>
        public async Task<TicketOrCredentialsSignInPopResponse> TicketOrCredentialsSignInPopWithOptionsAsync(TicketOrCredentialsSignInPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActivityId))
            {
                query["ActivityId"] = request.ActivityId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConferenceName))
            {
                query["ConferenceName"] = request.ConferenceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceId))
            {
                query["DeviceId"] = request.DeviceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EntryName))
            {
                query["EntryName"] = request.EntryName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Idcard))
            {
                query["Idcard"] = request.Idcard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignTime))
            {
                query["SignTime"] = request.SignTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TicketOrCredentialsSignInPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TicketOrCredentialsSignInPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// TicketOrCredentialsSignInPopRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketOrCredentialsSignInPopResponse
        /// </returns>
        public TicketOrCredentialsSignInPopResponse TicketOrCredentialsSignInPop(TicketOrCredentialsSignInPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TicketOrCredentialsSignInPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// TicketOrCredentialsSignInPopRequest
        /// </param>
        /// 
        /// <returns>
        /// TicketOrCredentialsSignInPopResponse
        /// </returns>
        public async Task<TicketOrCredentialsSignInPopResponse> TicketOrCredentialsSignInPopAsync(TicketOrCredentialsSignInPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TicketOrCredentialsSignInPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateCredentialsStatusPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsStatusPopResponse
        /// </returns>
        public UpdateCredentialsStatusPopResponse UpdateCredentialsStatusPopWithOptions(UpdateCredentialsStatusPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRecipientName))
            {
                query["ProxyRecipientName"] = request.ProxyRecipientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRecipientPhoneNumber))
            {
                query["ProxyRecipientPhoneNumber"] = request.ProxyRecipientPhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptLocation))
            {
                query["ReceiptLocation"] = request.ReceiptLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredentialsStatusPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialsStatusPopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateCredentialsStatusPopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsStatusPopResponse
        /// </returns>
        public async Task<UpdateCredentialsStatusPopResponse> UpdateCredentialsStatusPopWithOptionsAsync(UpdateCredentialsStatusPopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRecipientName))
            {
                query["ProxyRecipientName"] = request.ProxyRecipientName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyRecipientPhoneNumber))
            {
                query["ProxyRecipientPhoneNumber"] = request.ProxyRecipientPhoneNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptLocation))
            {
                query["ReceiptLocation"] = request.ReceiptLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCredentialsStatusPop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCredentialsStatusPopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateCredentialsStatusPopRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsStatusPopResponse
        /// </returns>
        public UpdateCredentialsStatusPopResponse UpdateCredentialsStatusPop(UpdateCredentialsStatusPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCredentialsStatusPopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateCredentialsStatusPopRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCredentialsStatusPopResponse
        /// </returns>
        public async Task<UpdateCredentialsStatusPopResponse> UpdateCredentialsStatusPopAsync(UpdateCredentialsStatusPopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCredentialsStatusPopWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// UpdateTicketRecordByticketCodePopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketRecordByticketCodePopResponse
        /// </returns>
        public UpdateTicketRecordByticketCodePopResponse UpdateTicketRecordByticketCodePopWithOptions(UpdateTicketRecordByticketCodePopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgendaId))
            {
                query["AgendaId"] = request.AgendaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                query["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTicketRecordByticketCodePop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketRecordByticketCodePopResponse>(CallApi(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateTicketRecordByticketCodePopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketRecordByticketCodePopResponse
        /// </returns>
        public async Task<UpdateTicketRecordByticketCodePopResponse> UpdateTicketRecordByticketCodePopWithOptionsAsync(UpdateTicketRecordByticketCodePopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgendaId))
            {
                query["AgendaId"] = request.AgendaId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                query["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                query["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneId))
            {
                query["SceneId"] = request.SceneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTicketRecordByticketCodePop",
                Version = "2021-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTicketRecordByticketCodePopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <param name="request">
        /// UpdateTicketRecordByticketCodePopRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketRecordByticketCodePopResponse
        /// </returns>
        public UpdateTicketRecordByticketCodePopResponse UpdateTicketRecordByticketCodePop(UpdateTicketRecordByticketCodePopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTicketRecordByticketCodePopWithOptions(request, runtime);
        }

        /// <param name="request">
        /// UpdateTicketRecordByticketCodePopRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTicketRecordByticketCodePopResponse
        /// </returns>
        public async Task<UpdateTicketRecordByticketCodePopResponse> UpdateTicketRecordByticketCodePopAsync(UpdateTicketRecordByticketCodePopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTicketRecordByticketCodePopWithOptionsAsync(request, runtime);
        }

    }
}
