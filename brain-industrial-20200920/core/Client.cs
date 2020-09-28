// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Brain_industrial20200920.Models;

namespace AlibabaCloud.SDK.Brain_industrial20200920
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("brain-industrial", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public GetOpPvCustomValuesResponse GetOpPvCustomValues(GetOpPvCustomValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetOpPvCustomValuesResponse>(DoRequest("GetOpPvCustomValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetOpPvCustomValuesResponse> GetOpPvCustomValuesAsync(GetOpPvCustomValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetOpPvCustomValuesResponse>(await DoRequestAsync("GetOpPvCustomValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public SubmitPidLoopEvaluationResponse SubmitPidLoopEvaluation(SubmitPidLoopEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubmitPidLoopEvaluationResponse>(DoRequest("SubmitPidLoopEvaluation", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SubmitPidLoopEvaluationResponse> SubmitPidLoopEvaluationAsync(SubmitPidLoopEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubmitPidLoopEvaluationResponse>(await DoRequestAsync("SubmitPidLoopEvaluation", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDefaultAdjustValuesResponse GetDefaultAdjustValues(GetDefaultAdjustValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDefaultAdjustValuesResponse>(DoRequest("GetDefaultAdjustValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDefaultAdjustValuesResponse> GetDefaultAdjustValuesAsync(GetDefaultAdjustValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDefaultAdjustValuesResponse>(await DoRequestAsync("GetDefaultAdjustValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPvOpAdjustValuesResponse GetPvOpAdjustValues(GetPvOpAdjustValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPvOpAdjustValuesResponse>(DoRequest("GetPvOpAdjustValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPvOpAdjustValuesResponse> GetPvOpAdjustValuesAsync(GetPvOpAdjustValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPvOpAdjustValuesResponse>(await DoRequestAsync("GetPvOpAdjustValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPvCustomSimulationValuesResponse GetPvCustomSimulationValues(GetPvCustomSimulationValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPvCustomSimulationValuesResponse>(DoRequest("GetPvCustomSimulationValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPvCustomSimulationValuesResponse> GetPvCustomSimulationValuesAsync(GetPvCustomSimulationValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPvCustomSimulationValuesResponse>(await DoRequestAsync("GetPvCustomSimulationValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetIdentificateValuesResponse GetIdentificateValues(GetIdentificateValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetIdentificateValuesResponse>(DoRequest("GetIdentificateValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetIdentificateValuesResponse> GetIdentificateValuesAsync(GetIdentificateValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetIdentificateValuesResponse>(await DoRequestAsync("GetIdentificateValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPvIdentSimulationValuesResponse GetPvIdentSimulationValues(GetPvIdentSimulationValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPvIdentSimulationValuesResponse>(DoRequest("GetPvIdentSimulationValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPvIdentSimulationValuesResponse> GetPvIdentSimulationValuesAsync(GetPvIdentSimulationValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPvIdentSimulationValuesResponse>(await DoRequestAsync("GetPvIdentSimulationValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetCustomIdentValuesResponse GetCustomIdentValues(GetCustomIdentValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetCustomIdentValuesResponse>(DoRequest("GetCustomIdentValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetCustomIdentValuesResponse> GetCustomIdentValuesAsync(GetCustomIdentValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetCustomIdentValuesResponse>(await DoRequestAsync("GetCustomIdentValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPidProjectReportOverviewResponse GetPidProjectReportOverview(GetPidProjectReportOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidProjectReportOverviewResponse>(DoRequest("GetPidProjectReportOverview", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPidProjectReportOverviewResponse> GetPidProjectReportOverviewAsync(GetPidProjectReportOverviewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidProjectReportOverviewResponse>(await DoRequestAsync("GetPidProjectReportOverview", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetLowModelPerformValuesResponse GetLowModelPerformValues(GetLowModelPerformValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLowModelPerformValuesResponse>(DoRequest("GetLowModelPerformValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetLowModelPerformValuesResponse> GetLowModelPerformValuesAsync(GetLowModelPerformValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLowModelPerformValuesResponse>(await DoRequestAsync("GetLowModelPerformValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListPidLoopEvaluationsResponse ListPidLoopEvaluations(ListPidLoopEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidLoopEvaluationsResponse>(DoRequest("ListPidLoopEvaluations", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPidLoopEvaluationsResponse> ListPidLoopEvaluationsAsync(ListPidLoopEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidLoopEvaluationsResponse>(await DoRequestAsync("ListPidLoopEvaluations", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListLoopParameterTagValuesResponse ListLoopParameterTagValues(ListLoopParameterTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLoopParameterTagValuesResponse>(DoRequest("ListLoopParameterTagValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListLoopParameterTagValuesResponse> ListLoopParameterTagValuesAsync(ListLoopParameterTagValuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLoopParameterTagValuesResponse>(await DoRequestAsync("ListLoopParameterTagValues", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPidLoopParameterResponse GetPidLoopParameter(GetPidLoopParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidLoopParameterResponse>(DoRequest("GetPidLoopParameter", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPidLoopParameterResponse> GetPidLoopParameterAsync(GetPidLoopParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidLoopParameterResponse>(await DoRequestAsync("GetPidLoopParameter", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDailyReportInfoResponse GetDailyReportInfo(GetDailyReportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportInfoResponse>(DoRequest("GetDailyReportInfo", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDailyReportInfoResponse> GetDailyReportInfoAsync(GetDailyReportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportInfoResponse>(await DoRequestAsync("GetDailyReportInfo", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPidLoopResponse GetPidLoop(GetPidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidLoopResponse>(DoRequest("GetPidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPidLoopResponse> GetPidLoopAsync(GetPidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidLoopResponse>(await DoRequestAsync("GetPidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public CreatePidProjectResponse CreatePidProject(CreatePidProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidProjectResponse>(DoRequest("CreatePidProject", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePidProjectResponse> CreatePidProjectAsync(CreatePidProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidProjectResponse>(await DoRequestAsync("CreatePidProject", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListIdentModelsResponse ListIdentModels(ListIdentModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListIdentModelsResponse>(DoRequest("ListIdentModels", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListIdentModelsResponse> ListIdentModelsAsync(ListIdentModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListIdentModelsResponse>(await DoRequestAsync("ListIdentModels", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListPidDataProcessResponse ListPidDataProcess(ListPidDataProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidDataProcessResponse>(DoRequest("ListPidDataProcess", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPidDataProcessResponse> ListPidDataProcessAsync(ListPidDataProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidDataProcessResponse>(await DoRequestAsync("ListPidDataProcess", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public AddCustomIdentModelResponse AddCustomIdentModel(AddCustomIdentModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCustomIdentModelResponse>(DoRequest("AddCustomIdentModel", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCustomIdentModelResponse> AddCustomIdentModelAsync(AddCustomIdentModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCustomIdentModelResponse>(await DoRequestAsync("AddCustomIdentModel", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetLoopParameterStepResponse GetLoopParameterStep(GetLoopParameterStepRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLoopParameterStepResponse>(DoRequest("GetLoopParameterStep", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetLoopParameterStepResponse> GetLoopParameterStepAsync(GetLoopParameterStepRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLoopParameterStepResponse>(await DoRequestAsync("GetLoopParameterStep", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListPidLoopsResponse ListPidLoops(ListPidLoopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidLoopsResponse>(DoRequest("ListPidLoops", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPidLoopsResponse> ListPidLoopsAsync(ListPidLoopsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidLoopsResponse>(await DoRequestAsync("ListPidLoops", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public MovePidOrganizationResponse MovePidOrganization(MovePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<MovePidOrganizationResponse>(DoRequest("MovePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<MovePidOrganizationResponse> MovePidOrganizationAsync(MovePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<MovePidOrganizationResponse>(await DoRequestAsync("MovePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdatePidLoopResponse UpdatePidLoop(UpdatePidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdatePidLoopResponse>(DoRequest("UpdatePidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdatePidLoopResponse> UpdatePidLoopAsync(UpdatePidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdatePidLoopResponse>(await DoRequestAsync("UpdatePidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public AddPidLoopToScheduleResponse AddPidLoopToSchedule(AddPidLoopToScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddPidLoopToScheduleResponse>(DoRequest("AddPidLoopToSchedule", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddPidLoopToScheduleResponse> AddPidLoopToScheduleAsync(AddPidLoopToScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddPidLoopToScheduleResponse>(await DoRequestAsync("AddPidLoopToSchedule", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetParsingTagTaskResponse GetParsingTagTask(GetParsingTagTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetParsingTagTaskResponse>(DoRequest("GetParsingTagTask", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetParsingTagTaskResponse> GetParsingTagTaskAsync(GetParsingTagTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetParsingTagTaskResponse>(await DoRequestAsync("GetParsingTagTask", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPidLoopLatestTaskStatusResponse GetPidLoopLatestTaskStatus(GetPidLoopLatestTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidLoopLatestTaskStatusResponse>(DoRequest("GetPidLoopLatestTaskStatus", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPidLoopLatestTaskStatusResponse> GetPidLoopLatestTaskStatusAsync(GetPidLoopLatestTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidLoopLatestTaskStatusResponse>(await DoRequestAsync("GetPidLoopLatestTaskStatus", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public DeletePidLoopResponse DeletePidLoop(DeletePidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidLoopResponse>(DoRequest("DeletePidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePidLoopResponse> DeletePidLoopAsync(DeletePidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidLoopResponse>(await DoRequestAsync("DeletePidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSummaryReportInfoResponse GetSummaryReportInfo(GetSummaryReportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSummaryReportInfoResponse>(DoRequest("GetSummaryReportInfo", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSummaryReportInfoResponse> GetSummaryReportInfoAsync(GetSummaryReportInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSummaryReportInfoResponse>(await DoRequestAsync("GetSummaryReportInfo", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSummaryReportDataTrendResponse GetSummaryReportDataTrend(GetSummaryReportDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSummaryReportDataTrendResponse>(DoRequest("GetSummaryReportDataTrend", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSummaryReportDataTrendResponse> GetSummaryReportDataTrendAsync(GetSummaryReportDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSummaryReportDataTrendResponse>(await DoRequestAsync("GetSummaryReportDataTrend", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSummaryReportChartResponse GetSummaryReportChart(GetSummaryReportChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSummaryReportChartResponse>(DoRequest("GetSummaryReportChart", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSummaryReportChartResponse> GetSummaryReportChartAsync(GetSummaryReportChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSummaryReportChartResponse>(await DoRequestAsync("GetSummaryReportChart", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDailyReportDataTrendResponse GetDailyReportDataTrend(GetDailyReportDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportDataTrendResponse>(DoRequest("GetDailyReportDataTrend", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDailyReportDataTrendResponse> GetDailyReportDataTrendAsync(GetDailyReportDataTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportDataTrendResponse>(await DoRequestAsync("GetDailyReportDataTrend", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListTagValueTrendResponse ListTagValueTrend(ListTagValueTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagValueTrendResponse>(DoRequest("ListTagValueTrend", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTagValueTrendResponse> ListTagValueTrendAsync(ListTagValueTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTagValueTrendResponse>(await DoRequestAsync("ListTagValueTrend", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDailyReportChartResponse GetDailyReportChart(GetDailyReportChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportChartResponse>(DoRequest("GetDailyReportChart", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDailyReportChartResponse> GetDailyReportChartAsync(GetDailyReportChartRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportChartResponse>(await DoRequestAsync("GetDailyReportChart", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListPidOrganizationsResponse ListPidOrganizations(ListPidOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidOrganizationsResponse>(DoRequest("ListPidOrganizations", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPidOrganizationsResponse> ListPidOrganizationsAsync(ListPidOrganizationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidOrganizationsResponse>(await DoRequestAsync("ListPidOrganizations", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public CreatePidDataProcessesResponse CreatePidDataProcesses(CreatePidDataProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidDataProcessesResponse>(DoRequest("CreatePidDataProcesses", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePidDataProcessesResponse> CreatePidDataProcessesAsync(CreatePidDataProcessesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidDataProcessesResponse>(await DoRequestAsync("CreatePidDataProcesses", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDailyReportPidParamResponse GetDailyReportPidParam(GetDailyReportPidParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportPidParamResponse>(DoRequest("GetDailyReportPidParam", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDailyReportPidParamResponse> GetDailyReportPidParamAsync(GetDailyReportPidParamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDailyReportPidParamResponse>(await DoRequestAsync("GetDailyReportPidParam", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public AddParameterToPidLoopResponse AddParameterToPidLoop(AddParameterToPidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddParameterToPidLoopResponse>(DoRequest("AddParameterToPidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddParameterToPidLoopResponse> AddParameterToPidLoopAsync(AddParameterToPidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddParameterToPidLoopResponse>(await DoRequestAsync("AddParameterToPidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListPidProjectsResponse ListPidProjects(ListPidProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidProjectsResponse>(DoRequest("ListPidProjects", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPidProjectsResponse> ListPidProjectsAsync(ListPidProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidProjectsResponse>(await DoRequestAsync("ListPidProjects", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public DeletePidOrganizationResponse DeletePidOrganization(DeletePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidOrganizationResponse>(DoRequest("DeletePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePidOrganizationResponse> DeletePidOrganizationAsync(DeletePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidOrganizationResponse>(await DoRequestAsync("DeletePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public SetPidLoopDefaultParameterResponse SetPidLoopDefaultParameter(SetPidLoopDefaultParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetPidLoopDefaultParameterResponse>(DoRequest("SetPidLoopDefaultParameter", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetPidLoopDefaultParameterResponse> SetPidLoopDefaultParameterAsync(SetPidLoopDefaultParameterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetPidLoopDefaultParameterResponse>(await DoRequestAsync("SetPidLoopDefaultParameter", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public GetPidOrganizationParentIdsResponse GetPidOrganizationParentIds(GetPidOrganizationParentIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidOrganizationParentIdsResponse>(DoRequest("GetPidOrganizationParentIds", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPidOrganizationParentIdsResponse> GetPidOrganizationParentIdsAsync(GetPidOrganizationParentIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPidOrganizationParentIdsResponse>(await DoRequestAsync("GetPidOrganizationParentIds", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public CreatePidOrganizationResponse CreatePidOrganization(CreatePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidOrganizationResponse>(DoRequest("CreatePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePidOrganizationResponse> CreatePidOrganizationAsync(CreatePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidOrganizationResponse>(await DoRequestAsync("CreatePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdatePidOrganizationResponse UpdatePidOrganization(UpdatePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdatePidOrganizationResponse>(DoRequest("UpdatePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdatePidOrganizationResponse> UpdatePidOrganizationAsync(UpdatePidOrganizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdatePidOrganizationResponse>(await DoRequestAsync("UpdatePidOrganization", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public CreatePidLoopResponse CreatePidLoop(CreatePidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidLoopResponse>(DoRequest("CreatePidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePidLoopResponse> CreatePidLoopAsync(CreatePidLoopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidLoopResponse>(await DoRequestAsync("CreatePidLoop", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdatePidProjectResponse UpdatePidProject(UpdatePidProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdatePidProjectResponse>(DoRequest("UpdatePidProject", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdatePidProjectResponse> UpdatePidProjectAsync(UpdatePidProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdatePidProjectResponse>(await DoRequestAsync("UpdatePidProject", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public ListPidTagsResponse ListPidTags(ListPidTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidTagsResponse>(DoRequest("ListPidTags", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPidTagsResponse> ListPidTagsAsync(ListPidTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPidTagsResponse>(await DoRequestAsync("ListPidTags", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public DeletePidDataProcessResponse DeletePidDataProcess(DeletePidDataProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidDataProcessResponse>(DoRequest("DeletePidDataProcess", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePidDataProcessResponse> DeletePidDataProcessAsync(DeletePidDataProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidDataProcessResponse>(await DoRequestAsync("DeletePidDataProcess", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public CreatePidDataSourceResponse CreatePidDataSource(CreatePidDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidDataSourceResponse>(DoRequest("CreatePidDataSource", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePidDataSourceResponse> CreatePidDataSourceAsync(CreatePidDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePidDataSourceResponse>(await DoRequestAsync("CreatePidDataSource", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public CreatePidDataSourceResponse CreatePidDataSourceAdvance(CreatePidDataSourceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "brain-industrial",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.Commons.Common.Convert(runtime, ossRuntime);
            CreatePidDataSourceRequest createPidDataSourcereq = new CreatePidDataSourceRequest();
            AlibabaCloud.Commons.Common.Convert(request, createPidDataSourcereq);
            authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.OssPathObject,
                ContentType = "",
            };
            ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
            {
                AccessKeyId = authResponse.AccessKeyId,
                Policy = authResponse.EncodedPolicy,
                Signature = authResponse.Signature,
                Key = authResponse.ObjectKey,
                File = fileObj,
                SuccessActionStatus = "201",
            };
            uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
            {
                BucketName = authResponse.Bucket,
                Header = ossHeader,
            };
            ossClient.PostObject(uploadRequest, ossRuntime);
            createPidDataSourcereq.OssPath = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            CreatePidDataSourceResponse createPidDataSourceResp = CreatePidDataSource(createPidDataSourcereq, runtime);
            return createPidDataSourceResp;
        }

        public async Task<CreatePidDataSourceResponse> CreatePidDataSourceAdvanceAsync(CreatePidDataSourceAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Endpoint = "openplatform.aliyuncs.com",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "brain-industrial",
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse authResponse = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadResponse();
            AlibabaCloud.OSS.Models.Config ossConfig = new AlibabaCloud.OSS.Models.Config
            {
                AccessKeySecret = accessKeySecret,
                Type = "access_key",
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.OSS.Client ossClient = null;
            AlibabaCloud.SDK.TeaFileform.Models.FileField fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField();
            AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader();
            AlibabaCloud.OSS.Models.PostObjectRequest uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest();
            AlibabaCloud.OSSUtil.Models.RuntimeOptions ossRuntime = new AlibabaCloud.OSSUtil.Models.RuntimeOptions();
            AlibabaCloud.Commons.Common.Convert(runtime, ossRuntime);
            CreatePidDataSourceRequest createPidDataSourcereq = new CreatePidDataSourceRequest();
            AlibabaCloud.Commons.Common.Convert(request, createPidDataSourcereq);
            authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
            ossConfig.AccessKeyId = authResponse.AccessKeyId;
            ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
            ossClient = new AlibabaCloud.OSS.Client(ossConfig);
            fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
            {
                Filename = authResponse.ObjectKey,
                Content = request.OssPathObject,
                ContentType = "",
            };
            ossHeader = new AlibabaCloud.OSS.Models.PostObjectRequest.PostObjectRequestHeader
            {
                AccessKeyId = authResponse.AccessKeyId,
                Policy = authResponse.EncodedPolicy,
                Signature = authResponse.Signature,
                Key = authResponse.ObjectKey,
                File = fileObj,
                SuccessActionStatus = "201",
            };
            uploadRequest = new AlibabaCloud.OSS.Models.PostObjectRequest
            {
                BucketName = authResponse.Bucket,
                Header = ossHeader,
            };
            await ossClient.PostObjectAsync(uploadRequest, ossRuntime);
            createPidDataSourcereq.OssPath = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            CreatePidDataSourceResponse createPidDataSourceResp = await CreatePidDataSourceAsync(createPidDataSourcereq, runtime);
            return createPidDataSourceResp;
        }

        public DeletePidProjectResponse DeletePidProject(DeletePidProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidProjectResponse>(DoRequest("DeletePidProject", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePidProjectResponse> DeletePidProjectAsync(DeletePidProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidProjectResponse>(await DoRequestAsync("DeletePidProject", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public DeletePidTagResponse DeletePidTag(DeletePidTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidTagResponse>(DoRequest("DeletePidTag", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeletePidTagResponse> DeletePidTagAsync(DeletePidTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeletePidTagResponse>(await DoRequestAsync("DeletePidTag", "HTTPS", "POST", "2020-09-20", "AK", null, request.ToMap(), runtime));
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

    }
}
