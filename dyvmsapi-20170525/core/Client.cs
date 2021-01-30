// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dyvmsapi20170525.Models;

namespace AlibabaCloud.SDK.Dyvmsapi20170525
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dyvmsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddRtcAccountResponse AddRtcAccountWithOptions(AddRtcAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRtcAccountResponse>(DoRPCRequest("AddRtcAccount", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRtcAccountResponse> AddRtcAccountWithOptionsAsync(AddRtcAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRtcAccountResponse>(await DoRPCRequestAsync("AddRtcAccount", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddRtcAccountResponse AddRtcAccount(AddRtcAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRtcAccountWithOptions(request, runtime);
        }

        public async Task<AddRtcAccountResponse> AddRtcAccountAsync(AddRtcAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRtcAccountWithOptionsAsync(request, runtime);
        }

        public BatchRobotSmartCallResponse BatchRobotSmartCallWithOptions(BatchRobotSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchRobotSmartCallResponse>(DoRPCRequest("BatchRobotSmartCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchRobotSmartCallResponse> BatchRobotSmartCallWithOptionsAsync(BatchRobotSmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchRobotSmartCallResponse>(await DoRPCRequestAsync("BatchRobotSmartCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchRobotSmartCallResponse BatchRobotSmartCall(BatchRobotSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRobotSmartCallWithOptions(request, runtime);
        }

        public async Task<BatchRobotSmartCallResponse> BatchRobotSmartCallAsync(BatchRobotSmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRobotSmartCallWithOptionsAsync(request, runtime);
        }

        public BindNumberAndVoipIdResponse BindNumberAndVoipIdWithOptions(BindNumberAndVoipIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindNumberAndVoipIdResponse>(DoRPCRequest("BindNumberAndVoipId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindNumberAndVoipIdResponse> BindNumberAndVoipIdWithOptionsAsync(BindNumberAndVoipIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindNumberAndVoipIdResponse>(await DoRPCRequestAsync("BindNumberAndVoipId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindNumberAndVoipIdResponse BindNumberAndVoipId(BindNumberAndVoipIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindNumberAndVoipIdWithOptions(request, runtime);
        }

        public async Task<BindNumberAndVoipIdResponse> BindNumberAndVoipIdAsync(BindNumberAndVoipIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindNumberAndVoipIdWithOptionsAsync(request, runtime);
        }

        public CancelCallResponse CancelCallWithOptions(CancelCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelCallResponse>(DoRPCRequest("CancelCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelCallResponse> CancelCallWithOptionsAsync(CancelCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelCallResponse>(await DoRPCRequestAsync("CancelCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelCallResponse CancelCall(CancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelCallWithOptions(request, runtime);
        }

        public async Task<CancelCallResponse> CancelCallAsync(CancelCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelCallWithOptionsAsync(request, runtime);
        }

        public CancelOrderRobotTaskResponse CancelOrderRobotTaskWithOptions(CancelOrderRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderRobotTaskResponse>(DoRPCRequest("CancelOrderRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelOrderRobotTaskResponse> CancelOrderRobotTaskWithOptionsAsync(CancelOrderRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelOrderRobotTaskResponse>(await DoRPCRequestAsync("CancelOrderRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelOrderRobotTaskResponse CancelOrderRobotTask(CancelOrderRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOrderRobotTaskWithOptions(request, runtime);
        }

        public async Task<CancelOrderRobotTaskResponse> CancelOrderRobotTaskAsync(CancelOrderRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOrderRobotTaskWithOptionsAsync(request, runtime);
        }

        public CancelRobotTaskResponse CancelRobotTaskWithOptions(CancelRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelRobotTaskResponse>(DoRPCRequest("CancelRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelRobotTaskResponse> CancelRobotTaskWithOptionsAsync(CancelRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelRobotTaskResponse>(await DoRPCRequestAsync("CancelRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelRobotTaskResponse CancelRobotTask(CancelRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRobotTaskWithOptions(request, runtime);
        }

        public async Task<CancelRobotTaskResponse> CancelRobotTaskAsync(CancelRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRobotTaskWithOptionsAsync(request, runtime);
        }

        public ClickToDialResponse ClickToDialWithOptions(ClickToDialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClickToDialResponse>(DoRPCRequest("ClickToDial", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ClickToDialResponse> ClickToDialWithOptionsAsync(ClickToDialRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ClickToDialResponse>(await DoRPCRequestAsync("ClickToDial", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ClickToDialResponse ClickToDial(ClickToDialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClickToDialWithOptions(request, runtime);
        }

        public async Task<ClickToDialResponse> ClickToDialAsync(ClickToDialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClickToDialWithOptionsAsync(request, runtime);
        }

        public CreateRobotTaskResponse CreateRobotTaskWithOptions(CreateRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRobotTaskResponse>(DoRPCRequest("CreateRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRobotTaskResponse> CreateRobotTaskWithOptionsAsync(CreateRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRobotTaskResponse>(await DoRPCRequestAsync("CreateRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRobotTaskResponse CreateRobotTask(CreateRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRobotTaskWithOptions(request, runtime);
        }

        public async Task<CreateRobotTaskResponse> CreateRobotTaskAsync(CreateRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRobotTaskWithOptionsAsync(request, runtime);
        }

        public DeleteRobotTaskResponse DeleteRobotTaskWithOptions(DeleteRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRobotTaskResponse>(DoRPCRequest("DeleteRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRobotTaskResponse> DeleteRobotTaskWithOptionsAsync(DeleteRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRobotTaskResponse>(await DoRPCRequestAsync("DeleteRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRobotTaskResponse DeleteRobotTask(DeleteRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRobotTaskWithOptions(request, runtime);
        }

        public async Task<DeleteRobotTaskResponse> DeleteRobotTaskAsync(DeleteRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRobotTaskWithOptionsAsync(request, runtime);
        }

        public DescribeRecordDataResponse DescribeRecordDataWithOptions(DescribeRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordDataResponse>(DoRPCRequest("DescribeRecordData", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordDataResponse> DescribeRecordDataWithOptionsAsync(DescribeRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordDataResponse>(await DoRPCRequestAsync("DescribeRecordData", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordDataResponse DescribeRecordData(DescribeRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordDataWithOptions(request, runtime);
        }

        public async Task<DescribeRecordDataResponse> DescribeRecordDataAsync(DescribeRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordDataWithOptionsAsync(request, runtime);
        }

        public DoRtcNumberAuthResponse DoRtcNumberAuthWithOptions(DoRtcNumberAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoRtcNumberAuthResponse>(DoRPCRequest("DoRtcNumberAuth", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DoRtcNumberAuthResponse> DoRtcNumberAuthWithOptionsAsync(DoRtcNumberAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DoRtcNumberAuthResponse>(await DoRPCRequestAsync("DoRtcNumberAuth", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DoRtcNumberAuthResponse DoRtcNumberAuth(DoRtcNumberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DoRtcNumberAuthWithOptions(request, runtime);
        }

        public async Task<DoRtcNumberAuthResponse> DoRtcNumberAuthAsync(DoRtcNumberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DoRtcNumberAuthWithOptionsAsync(request, runtime);
        }

        public GetRtcTokenResponse GetRtcTokenWithOptions(GetRtcTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRtcTokenResponse>(DoRPCRequest("GetRtcToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetRtcTokenResponse> GetRtcTokenWithOptionsAsync(GetRtcTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetRtcTokenResponse>(await DoRPCRequestAsync("GetRtcToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetRtcTokenResponse GetRtcToken(GetRtcTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRtcTokenWithOptions(request, runtime);
        }

        public async Task<GetRtcTokenResponse> GetRtcTokenAsync(GetRtcTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRtcTokenWithOptionsAsync(request, runtime);
        }

        public IvrCallResponse IvrCallWithOptions(IvrCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IvrCallResponse>(DoRPCRequest("IvrCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<IvrCallResponse> IvrCallWithOptionsAsync(IvrCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<IvrCallResponse>(await DoRPCRequestAsync("IvrCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public IvrCallResponse IvrCall(IvrCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IvrCallWithOptions(request, runtime);
        }

        public async Task<IvrCallResponse> IvrCallAsync(IvrCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IvrCallWithOptionsAsync(request, runtime);
        }

        public ListOrderedNumbersResponse ListOrderedNumbersWithOptions(ListOrderedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrderedNumbersResponse>(DoRPCRequest("ListOrderedNumbers", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOrderedNumbersResponse> ListOrderedNumbersWithOptionsAsync(ListOrderedNumbersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOrderedNumbersResponse>(await DoRPCRequestAsync("ListOrderedNumbers", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOrderedNumbersResponse ListOrderedNumbers(ListOrderedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOrderedNumbersWithOptions(request, runtime);
        }

        public async Task<ListOrderedNumbersResponse> ListOrderedNumbersAsync(ListOrderedNumbersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOrderedNumbersWithOptionsAsync(request, runtime);
        }

        public ListOutboundStrategiesResponse ListOutboundStrategiesWithOptions(ListOutboundStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundStrategiesResponse>(DoRPCRequest("ListOutboundStrategies", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListOutboundStrategiesResponse> ListOutboundStrategiesWithOptionsAsync(ListOutboundStrategiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListOutboundStrategiesResponse>(await DoRPCRequestAsync("ListOutboundStrategies", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListOutboundStrategiesResponse ListOutboundStrategies(ListOutboundStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOutboundStrategiesWithOptions(request, runtime);
        }

        public async Task<ListOutboundStrategiesResponse> ListOutboundStrategiesAsync(ListOutboundStrategiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOutboundStrategiesWithOptionsAsync(request, runtime);
        }

        public ListRobotTaskCallsResponse ListRobotTaskCallsWithOptions(ListRobotTaskCallsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRobotTaskCallsResponse>(DoRPCRequest("ListRobotTaskCalls", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRobotTaskCallsResponse> ListRobotTaskCallsWithOptionsAsync(ListRobotTaskCallsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRobotTaskCallsResponse>(await DoRPCRequestAsync("ListRobotTaskCalls", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRobotTaskCallsResponse ListRobotTaskCalls(ListRobotTaskCallsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRobotTaskCallsWithOptions(request, runtime);
        }

        public async Task<ListRobotTaskCallsResponse> ListRobotTaskCallsAsync(ListRobotTaskCallsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRobotTaskCallsWithOptionsAsync(request, runtime);
        }

        public QueryCallDetailByCallIdResponse QueryCallDetailByCallIdWithOptions(QueryCallDetailByCallIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCallDetailByCallIdResponse>(DoRPCRequest("QueryCallDetailByCallId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCallDetailByCallIdResponse> QueryCallDetailByCallIdWithOptionsAsync(QueryCallDetailByCallIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCallDetailByCallIdResponse>(await DoRPCRequestAsync("QueryCallDetailByCallId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCallDetailByCallIdResponse QueryCallDetailByCallId(QueryCallDetailByCallIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallDetailByCallIdWithOptions(request, runtime);
        }

        public async Task<QueryCallDetailByCallIdResponse> QueryCallDetailByCallIdAsync(QueryCallDetailByCallIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallDetailByCallIdWithOptionsAsync(request, runtime);
        }

        public QueryCallDetailByTaskIdResponse QueryCallDetailByTaskIdWithOptions(QueryCallDetailByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCallDetailByTaskIdResponse>(DoRPCRequest("QueryCallDetailByTaskId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryCallDetailByTaskIdResponse> QueryCallDetailByTaskIdWithOptionsAsync(QueryCallDetailByTaskIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryCallDetailByTaskIdResponse>(await DoRPCRequestAsync("QueryCallDetailByTaskId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryCallDetailByTaskIdResponse QueryCallDetailByTaskId(QueryCallDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCallDetailByTaskIdWithOptions(request, runtime);
        }

        public async Task<QueryCallDetailByTaskIdResponse> QueryCallDetailByTaskIdAsync(QueryCallDetailByTaskIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCallDetailByTaskIdWithOptionsAsync(request, runtime);
        }

        public QueryRobotInfoListResponse QueryRobotInfoListWithOptions(QueryRobotInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotInfoListResponse>(DoRPCRequest("QueryRobotInfoList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRobotInfoListResponse> QueryRobotInfoListWithOptionsAsync(QueryRobotInfoListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotInfoListResponse>(await DoRPCRequestAsync("QueryRobotInfoList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRobotInfoListResponse QueryRobotInfoList(QueryRobotInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotInfoListWithOptions(request, runtime);
        }

        public async Task<QueryRobotInfoListResponse> QueryRobotInfoListAsync(QueryRobotInfoListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotInfoListWithOptionsAsync(request, runtime);
        }

        public QueryRobotTaskCallDetailResponse QueryRobotTaskCallDetailWithOptions(QueryRobotTaskCallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskCallDetailResponse>(DoRPCRequest("QueryRobotTaskCallDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRobotTaskCallDetailResponse> QueryRobotTaskCallDetailWithOptionsAsync(QueryRobotTaskCallDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskCallDetailResponse>(await DoRPCRequestAsync("QueryRobotTaskCallDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRobotTaskCallDetailResponse QueryRobotTaskCallDetail(QueryRobotTaskCallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskCallDetailWithOptions(request, runtime);
        }

        public async Task<QueryRobotTaskCallDetailResponse> QueryRobotTaskCallDetailAsync(QueryRobotTaskCallDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskCallDetailWithOptionsAsync(request, runtime);
        }

        public QueryRobotTaskCallListResponse QueryRobotTaskCallListWithOptions(QueryRobotTaskCallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskCallListResponse>(DoRPCRequest("QueryRobotTaskCallList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRobotTaskCallListResponse> QueryRobotTaskCallListWithOptionsAsync(QueryRobotTaskCallListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskCallListResponse>(await DoRPCRequestAsync("QueryRobotTaskCallList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRobotTaskCallListResponse QueryRobotTaskCallList(QueryRobotTaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskCallListWithOptions(request, runtime);
        }

        public async Task<QueryRobotTaskCallListResponse> QueryRobotTaskCallListAsync(QueryRobotTaskCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskCallListWithOptionsAsync(request, runtime);
        }

        public QueryRobotTaskDetailResponse QueryRobotTaskDetailWithOptions(QueryRobotTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskDetailResponse>(DoRPCRequest("QueryRobotTaskDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRobotTaskDetailResponse> QueryRobotTaskDetailWithOptionsAsync(QueryRobotTaskDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskDetailResponse>(await DoRPCRequestAsync("QueryRobotTaskDetail", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRobotTaskDetailResponse QueryRobotTaskDetail(QueryRobotTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskDetailWithOptions(request, runtime);
        }

        public async Task<QueryRobotTaskDetailResponse> QueryRobotTaskDetailAsync(QueryRobotTaskDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskDetailWithOptionsAsync(request, runtime);
        }

        public QueryRobotTaskListResponse QueryRobotTaskListWithOptions(QueryRobotTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskListResponse>(DoRPCRequest("QueryRobotTaskList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRobotTaskListResponse> QueryRobotTaskListWithOptionsAsync(QueryRobotTaskListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotTaskListResponse>(await DoRPCRequestAsync("QueryRobotTaskList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRobotTaskListResponse QueryRobotTaskList(QueryRobotTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotTaskListWithOptions(request, runtime);
        }

        public async Task<QueryRobotTaskListResponse> QueryRobotTaskListAsync(QueryRobotTaskListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotTaskListWithOptionsAsync(request, runtime);
        }

        public QueryRobotv2AllListResponse QueryRobotv2AllListWithOptions(QueryRobotv2AllListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotv2AllListResponse>(DoRPCRequest("QueryRobotv2AllList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRobotv2AllListResponse> QueryRobotv2AllListWithOptionsAsync(QueryRobotv2AllListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRobotv2AllListResponse>(await DoRPCRequestAsync("QueryRobotv2AllList", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRobotv2AllListResponse QueryRobotv2AllList(QueryRobotv2AllListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRobotv2AllListWithOptions(request, runtime);
        }

        public async Task<QueryRobotv2AllListResponse> QueryRobotv2AllListAsync(QueryRobotv2AllListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRobotv2AllListWithOptionsAsync(request, runtime);
        }

        public QueryRtcNumberAuthStatusResponse QueryRtcNumberAuthStatusWithOptions(QueryRtcNumberAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRtcNumberAuthStatusResponse>(DoRPCRequest("QueryRtcNumberAuthStatus", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryRtcNumberAuthStatusResponse> QueryRtcNumberAuthStatusWithOptionsAsync(QueryRtcNumberAuthStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryRtcNumberAuthStatusResponse>(await DoRPCRequestAsync("QueryRtcNumberAuthStatus", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryRtcNumberAuthStatusResponse QueryRtcNumberAuthStatus(QueryRtcNumberAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryRtcNumberAuthStatusWithOptions(request, runtime);
        }

        public async Task<QueryRtcNumberAuthStatusResponse> QueryRtcNumberAuthStatusAsync(QueryRtcNumberAuthStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryRtcNumberAuthStatusWithOptionsAsync(request, runtime);
        }

        public QueryVoipNumberBindInfosResponse QueryVoipNumberBindInfosWithOptions(QueryVoipNumberBindInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVoipNumberBindInfosResponse>(DoRPCRequest("QueryVoipNumberBindInfos", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryVoipNumberBindInfosResponse> QueryVoipNumberBindInfosWithOptionsAsync(QueryVoipNumberBindInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryVoipNumberBindInfosResponse>(await DoRPCRequestAsync("QueryVoipNumberBindInfos", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryVoipNumberBindInfosResponse QueryVoipNumberBindInfos(QueryVoipNumberBindInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryVoipNumberBindInfosWithOptions(request, runtime);
        }

        public async Task<QueryVoipNumberBindInfosResponse> QueryVoipNumberBindInfosAsync(QueryVoipNumberBindInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryVoipNumberBindInfosWithOptionsAsync(request, runtime);
        }

        public ReportVoipProblemsResponse ReportVoipProblemsWithOptions(ReportVoipProblemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportVoipProblemsResponse>(DoRPCRequest("ReportVoipProblems", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ReportVoipProblemsResponse> ReportVoipProblemsWithOptionsAsync(ReportVoipProblemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ReportVoipProblemsResponse>(await DoRPCRequestAsync("ReportVoipProblems", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ReportVoipProblemsResponse ReportVoipProblems(ReportVoipProblemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReportVoipProblemsWithOptions(request, runtime);
        }

        public async Task<ReportVoipProblemsResponse> ReportVoipProblemsAsync(ReportVoipProblemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReportVoipProblemsWithOptionsAsync(request, runtime);
        }

        public SingleCallByTtsResponse SingleCallByTtsWithOptions(SingleCallByTtsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleCallByTtsResponse>(DoRPCRequest("SingleCallByTts", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SingleCallByTtsResponse> SingleCallByTtsWithOptionsAsync(SingleCallByTtsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleCallByTtsResponse>(await DoRPCRequestAsync("SingleCallByTts", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SingleCallByTtsResponse SingleCallByTts(SingleCallByTtsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleCallByTtsWithOptions(request, runtime);
        }

        public async Task<SingleCallByTtsResponse> SingleCallByTtsAsync(SingleCallByTtsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleCallByTtsWithOptionsAsync(request, runtime);
        }

        public SingleCallByVoiceResponse SingleCallByVoiceWithOptions(SingleCallByVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleCallByVoiceResponse>(DoRPCRequest("SingleCallByVoice", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SingleCallByVoiceResponse> SingleCallByVoiceWithOptionsAsync(SingleCallByVoiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SingleCallByVoiceResponse>(await DoRPCRequestAsync("SingleCallByVoice", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SingleCallByVoiceResponse SingleCallByVoice(SingleCallByVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SingleCallByVoiceWithOptions(request, runtime);
        }

        public async Task<SingleCallByVoiceResponse> SingleCallByVoiceAsync(SingleCallByVoiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SingleCallByVoiceWithOptionsAsync(request, runtime);
        }

        public SmartCallResponse SmartCallWithOptions(SmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SmartCallResponse>(DoRPCRequest("SmartCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SmartCallResponse> SmartCallWithOptionsAsync(SmartCallRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SmartCallResponse>(await DoRPCRequestAsync("SmartCall", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SmartCallResponse SmartCall(SmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmartCallWithOptions(request, runtime);
        }

        public async Task<SmartCallResponse> SmartCallAsync(SmartCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmartCallWithOptionsAsync(request, runtime);
        }

        public SmartCallOperateResponse SmartCallOperateWithOptions(SmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SmartCallOperateResponse>(DoRPCRequest("SmartCallOperate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SmartCallOperateResponse> SmartCallOperateWithOptionsAsync(SmartCallOperateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SmartCallOperateResponse>(await DoRPCRequestAsync("SmartCallOperate", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SmartCallOperateResponse SmartCallOperate(SmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmartCallOperateWithOptions(request, runtime);
        }

        public async Task<SmartCallOperateResponse> SmartCallOperateAsync(SmartCallOperateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmartCallOperateWithOptionsAsync(request, runtime);
        }

        public StartMicroOutboundResponse StartMicroOutboundWithOptions(StartMicroOutboundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMicroOutboundResponse>(DoRPCRequest("StartMicroOutbound", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartMicroOutboundResponse> StartMicroOutboundWithOptionsAsync(StartMicroOutboundRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartMicroOutboundResponse>(await DoRPCRequestAsync("StartMicroOutbound", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartMicroOutboundResponse StartMicroOutbound(StartMicroOutboundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMicroOutboundWithOptions(request, runtime);
        }

        public async Task<StartMicroOutboundResponse> StartMicroOutboundAsync(StartMicroOutboundRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMicroOutboundWithOptionsAsync(request, runtime);
        }

        public StartRobotTaskResponse StartRobotTaskWithOptions(StartRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRobotTaskResponse>(DoRPCRequest("StartRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRobotTaskResponse> StartRobotTaskWithOptionsAsync(StartRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRobotTaskResponse>(await DoRPCRequestAsync("StartRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRobotTaskResponse StartRobotTask(StartRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRobotTaskWithOptions(request, runtime);
        }

        public async Task<StartRobotTaskResponse> StartRobotTaskAsync(StartRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRobotTaskWithOptionsAsync(request, runtime);
        }

        public StopRobotTaskResponse StopRobotTaskWithOptions(StopRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRobotTaskResponse>(DoRPCRequest("StopRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopRobotTaskResponse> StopRobotTaskWithOptionsAsync(StopRobotTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopRobotTaskResponse>(await DoRPCRequestAsync("StopRobotTask", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopRobotTaskResponse StopRobotTask(StopRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRobotTaskWithOptions(request, runtime);
        }

        public async Task<StopRobotTaskResponse> StopRobotTaskAsync(StopRobotTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRobotTaskWithOptionsAsync(request, runtime);
        }

        public UnbindNumberAndVoipIdResponse UnbindNumberAndVoipIdWithOptions(UnbindNumberAndVoipIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindNumberAndVoipIdResponse>(DoRPCRequest("UnbindNumberAndVoipId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindNumberAndVoipIdResponse> UnbindNumberAndVoipIdWithOptionsAsync(UnbindNumberAndVoipIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindNumberAndVoipIdResponse>(await DoRPCRequestAsync("UnbindNumberAndVoipId", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindNumberAndVoipIdResponse UnbindNumberAndVoipId(UnbindNumberAndVoipIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindNumberAndVoipIdWithOptions(request, runtime);
        }

        public async Task<UnbindNumberAndVoipIdResponse> UnbindNumberAndVoipIdAsync(UnbindNumberAndVoipIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindNumberAndVoipIdWithOptionsAsync(request, runtime);
        }

        public UndoRtcNumberAuthResponse UndoRtcNumberAuthWithOptions(UndoRtcNumberAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UndoRtcNumberAuthResponse>(DoRPCRequest("UndoRtcNumberAuth", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UndoRtcNumberAuthResponse> UndoRtcNumberAuthWithOptionsAsync(UndoRtcNumberAuthRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UndoRtcNumberAuthResponse>(await DoRPCRequestAsync("UndoRtcNumberAuth", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UndoRtcNumberAuthResponse UndoRtcNumberAuth(UndoRtcNumberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UndoRtcNumberAuthWithOptions(request, runtime);
        }

        public async Task<UndoRtcNumberAuthResponse> UndoRtcNumberAuthAsync(UndoRtcNumberAuthRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UndoRtcNumberAuthWithOptionsAsync(request, runtime);
        }

        public UploadRobotTaskCalledFileResponse UploadRobotTaskCalledFileWithOptions(UploadRobotTaskCalledFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadRobotTaskCalledFileResponse>(DoRPCRequest("UploadRobotTaskCalledFile", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UploadRobotTaskCalledFileResponse> UploadRobotTaskCalledFileWithOptionsAsync(UploadRobotTaskCalledFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UploadRobotTaskCalledFileResponse>(await DoRPCRequestAsync("UploadRobotTaskCalledFile", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UploadRobotTaskCalledFileResponse UploadRobotTaskCalledFile(UploadRobotTaskCalledFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UploadRobotTaskCalledFileWithOptions(request, runtime);
        }

        public async Task<UploadRobotTaskCalledFileResponse> UploadRobotTaskCalledFileAsync(UploadRobotTaskCalledFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UploadRobotTaskCalledFileWithOptionsAsync(request, runtime);
        }

        public VoipAddAccountResponse VoipAddAccountWithOptions(VoipAddAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VoipAddAccountResponse>(DoRPCRequest("VoipAddAccount", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VoipAddAccountResponse> VoipAddAccountWithOptionsAsync(VoipAddAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VoipAddAccountResponse>(await DoRPCRequestAsync("VoipAddAccount", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VoipAddAccountResponse VoipAddAccount(VoipAddAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoipAddAccountWithOptions(request, runtime);
        }

        public async Task<VoipAddAccountResponse> VoipAddAccountAsync(VoipAddAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoipAddAccountWithOptionsAsync(request, runtime);
        }

        public VoipGetTokenResponse VoipGetTokenWithOptions(VoipGetTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VoipGetTokenResponse>(DoRPCRequest("VoipGetToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VoipGetTokenResponse> VoipGetTokenWithOptionsAsync(VoipGetTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VoipGetTokenResponse>(await DoRPCRequestAsync("VoipGetToken", "2017-05-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VoipGetTokenResponse VoipGetToken(VoipGetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoipGetTokenWithOptions(request, runtime);
        }

        public async Task<VoipGetTokenResponse> VoipGetTokenAsync(VoipGetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoipGetTokenWithOptionsAsync(request, runtime);
        }

    }
}
