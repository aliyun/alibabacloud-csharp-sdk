// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dataworks_public20200518.Models;

namespace AlibabaCloud.SDK.Dataworks_public20200518
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "dataworks.ap-northeast-1.aliyuncs.com"},
                {"ap-south-1", "dataworks.ap-south-1.aliyuncs.com"},
                {"ap-southeast-1", "dataworks.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "dataworks.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "dataworks.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "dataworks.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "dataworks.cn-beijing.aliyuncs.com"},
                {"cn-chengdu", "dataworks.cn-chengdu.aliyuncs.com"},
                {"cn-hangzhou", "dataworks.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "dataworks.cn-hongkong.aliyuncs.com"},
                {"cn-huhehaote", "dataworks.aliyuncs.com"},
                {"cn-qingdao", "dataworks.aliyuncs.com"},
                {"cn-shanghai", "dataworks.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "dataworks.cn-shenzhen.aliyuncs.com"},
                {"cn-zhangjiakou", "dataworks.aliyuncs.com"},
                {"eu-central-1", "dataworks.eu-central-1.aliyuncs.com"},
                {"eu-west-1", "dataworks.eu-west-1.aliyuncs.com"},
                {"me-east-1", "dataworks.me-east-1.aliyuncs.com"},
                {"us-east-1", "dataworks.us-east-1.aliyuncs.com"},
                {"us-west-1", "dataworks.us-west-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "dataworks.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "dataworks.aliyuncs.com"},
                {"cn-shanghai-finance-1", "dataworks.aliyuncs.com"},
                {"cn-north-2-gov-1", "dataworks.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dataworks-public", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public GenerateDISyncTaskConfigForCreatingResponse GenerateDISyncTaskConfigForCreating(GenerateDISyncTaskConfigForCreatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDISyncTaskConfigForCreatingResponse>(DoRequest("GenerateDISyncTaskConfigForCreating", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<GenerateDISyncTaskConfigForCreatingResponse> GenerateDISyncTaskConfigForCreatingAsync(GenerateDISyncTaskConfigForCreatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDISyncTaskConfigForCreatingResponse>(await DoRequestAsync("GenerateDISyncTaskConfigForCreating", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public GenerateDISyncTaskConfigForCreatingResponse GenerateDISyncTaskConfigForCreatingSimply(GenerateDISyncTaskConfigForCreatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDISyncTaskConfigForCreating(request, runtime);
        }

        public async Task<GenerateDISyncTaskConfigForCreatingResponse> GenerateDISyncTaskConfigForCreatingSimplyAsync(GenerateDISyncTaskConfigForCreatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDISyncTaskConfigForCreatingAsync(request, runtime);
        }

        public GenerateDISyncTaskConfigForUpdatingResponse GenerateDISyncTaskConfigForUpdating(GenerateDISyncTaskConfigForUpdatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDISyncTaskConfigForUpdatingResponse>(DoRequest("GenerateDISyncTaskConfigForUpdating", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<GenerateDISyncTaskConfigForUpdatingResponse> GenerateDISyncTaskConfigForUpdatingAsync(GenerateDISyncTaskConfigForUpdatingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDISyncTaskConfigForUpdatingResponse>(await DoRequestAsync("GenerateDISyncTaskConfigForUpdating", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public GenerateDISyncTaskConfigForUpdatingResponse GenerateDISyncTaskConfigForUpdatingSimply(GenerateDISyncTaskConfigForUpdatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDISyncTaskConfigForUpdating(request, runtime);
        }

        public async Task<GenerateDISyncTaskConfigForUpdatingResponse> GenerateDISyncTaskConfigForUpdatingSimplyAsync(GenerateDISyncTaskConfigForUpdatingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDISyncTaskConfigForUpdatingAsync(request, runtime);
        }

        public QueryDISyncTaskConfigProcessResultResponse QueryDISyncTaskConfigProcessResult(QueryDISyncTaskConfigProcessResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDISyncTaskConfigProcessResultResponse>(DoRequest("QueryDISyncTaskConfigProcessResult", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<QueryDISyncTaskConfigProcessResultResponse> QueryDISyncTaskConfigProcessResultAsync(QueryDISyncTaskConfigProcessResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDISyncTaskConfigProcessResultResponse>(await DoRequestAsync("QueryDISyncTaskConfigProcessResult", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public QueryDISyncTaskConfigProcessResultResponse QueryDISyncTaskConfigProcessResultSimply(QueryDISyncTaskConfigProcessResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDISyncTaskConfigProcessResult(request, runtime);
        }

        public async Task<QueryDISyncTaskConfigProcessResultResponse> QueryDISyncTaskConfigProcessResultSimplyAsync(QueryDISyncTaskConfigProcessResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDISyncTaskConfigProcessResultAsync(request, runtime);
        }

        public ListProjectIdsResponse ListProjectIds(ListProjectIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectIdsResponse>(DoRequest("ListProjectIds", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProjectIdsResponse> ListProjectIdsAsync(ListProjectIdsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectIdsResponse>(await DoRequestAsync("ListProjectIds", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListProjectIdsResponse ListProjectIdsSimply(ListProjectIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectIds(request, runtime);
        }

        public async Task<ListProjectIdsResponse> ListProjectIdsSimplyAsync(ListProjectIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectIdsAsync(request, runtime);
        }

        public TerminateDISyncInstanceResponse TerminateDISyncInstance(TerminateDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TerminateDISyncInstanceResponse>(DoRequest("TerminateDISyncInstance", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<TerminateDISyncInstanceResponse> TerminateDISyncInstanceAsync(TerminateDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TerminateDISyncInstanceResponse>(await DoRequestAsync("TerminateDISyncInstance", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public TerminateDISyncInstanceResponse TerminateDISyncInstanceSimply(TerminateDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TerminateDISyncInstance(request, runtime);
        }

        public async Task<TerminateDISyncInstanceResponse> TerminateDISyncInstanceSimplyAsync(TerminateDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TerminateDISyncInstanceAsync(request, runtime);
        }

        public DeleteDISyncTaskResponse DeleteDISyncTask(DeleteDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDISyncTaskResponse>(DoRequest("DeleteDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDISyncTaskResponse> DeleteDISyncTaskAsync(DeleteDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDISyncTaskResponse>(await DoRequestAsync("DeleteDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public DeleteDISyncTaskResponse DeleteDISyncTaskSimply(DeleteDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDISyncTask(request, runtime);
        }

        public async Task<DeleteDISyncTaskResponse> DeleteDISyncTaskSimplyAsync(DeleteDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDISyncTaskAsync(request, runtime);
        }

        public DeployDISyncTaskResponse DeployDISyncTask(DeployDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeployDISyncTaskResponse>(DoRequest("DeployDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<DeployDISyncTaskResponse> DeployDISyncTaskAsync(DeployDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeployDISyncTaskResponse>(await DoRequestAsync("DeployDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public DeployDISyncTaskResponse DeployDISyncTaskSimply(DeployDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployDISyncTask(request, runtime);
        }

        public async Task<DeployDISyncTaskResponse> DeployDISyncTaskSimplyAsync(DeployDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployDISyncTaskAsync(request, runtime);
        }

        public StartDISyncInstanceResponse StartDISyncInstance(StartDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartDISyncInstanceResponse>(DoRequest("StartDISyncInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartDISyncInstanceResponse> StartDISyncInstanceAsync(StartDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartDISyncInstanceResponse>(await DoRequestAsync("StartDISyncInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public StartDISyncInstanceResponse StartDISyncInstanceSimply(StartDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDISyncInstance(request, runtime);
        }

        public async Task<StartDISyncInstanceResponse> StartDISyncInstanceSimplyAsync(StartDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDISyncInstanceAsync(request, runtime);
        }

        public GetDISyncInstanceInfoResponse GetDISyncInstanceInfo(GetDISyncInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDISyncInstanceInfoResponse>(DoRequest("GetDISyncInstanceInfo", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<GetDISyncInstanceInfoResponse> GetDISyncInstanceInfoAsync(GetDISyncInstanceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDISyncInstanceInfoResponse>(await DoRequestAsync("GetDISyncInstanceInfo", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public GetDISyncInstanceInfoResponse GetDISyncInstanceInfoSimply(GetDISyncInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDISyncInstanceInfo(request, runtime);
        }

        public async Task<GetDISyncInstanceInfoResponse> GetDISyncInstanceInfoSimplyAsync(GetDISyncInstanceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDISyncInstanceInfoAsync(request, runtime);
        }

        public StopDISyncInstanceResponse StopDISyncInstance(StopDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopDISyncInstanceResponse>(DoRequest("StopDISyncInstance", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<StopDISyncInstanceResponse> StopDISyncInstanceAsync(StopDISyncInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopDISyncInstanceResponse>(await DoRequestAsync("StopDISyncInstance", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public StopDISyncInstanceResponse StopDISyncInstanceSimply(StopDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopDISyncInstance(request, runtime);
        }

        public async Task<StopDISyncInstanceResponse> StopDISyncInstanceSimplyAsync(StopDISyncInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopDISyncInstanceAsync(request, runtime);
        }

        public GetDISyncTaskResponse GetDISyncTask(GetDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDISyncTaskResponse>(DoRequest("GetDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<GetDISyncTaskResponse> GetDISyncTaskAsync(GetDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDISyncTaskResponse>(await DoRequestAsync("GetDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public GetDISyncTaskResponse GetDISyncTaskSimply(GetDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDISyncTask(request, runtime);
        }

        public async Task<GetDISyncTaskResponse> GetDISyncTaskSimplyAsync(GetDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDISyncTaskAsync(request, runtime);
        }

        public CheckMetaTableTaskResponse CheckMetaTableTask(CheckMetaTableTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckMetaTableTaskResponse>(DoRequest("CheckMetaTableTask", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckMetaTableTaskResponse> CheckMetaTableTaskAsync(CheckMetaTableTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckMetaTableTaskResponse>(await DoRequestAsync("CheckMetaTableTask", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CheckMetaTableTaskResponse CheckMetaTableTaskSimply(CheckMetaTableTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMetaTableTask(request, runtime);
        }

        public async Task<CheckMetaTableTaskResponse> CheckMetaTableTaskSimplyAsync(CheckMetaTableTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMetaTableTaskAsync(request, runtime);
        }

        public CheckEngineMetaPartitionResponse CheckEngineMetaPartition(CheckEngineMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckEngineMetaPartitionResponse>(DoRequest("CheckEngineMetaPartition", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckEngineMetaPartitionResponse> CheckEngineMetaPartitionAsync(CheckEngineMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckEngineMetaPartitionResponse>(await DoRequestAsync("CheckEngineMetaPartition", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CheckEngineMetaPartitionResponse CheckEngineMetaPartitionSimply(CheckEngineMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckEngineMetaPartition(request, runtime);
        }

        public async Task<CheckEngineMetaPartitionResponse> CheckEngineMetaPartitionSimplyAsync(CheckEngineMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckEngineMetaPartitionAsync(request, runtime);
        }

        public CheckEngineMetaTableResponse CheckEngineMetaTable(CheckEngineMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckEngineMetaTableResponse>(DoRequest("CheckEngineMetaTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckEngineMetaTableResponse> CheckEngineMetaTableAsync(CheckEngineMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckEngineMetaTableResponse>(await DoRequestAsync("CheckEngineMetaTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CheckEngineMetaTableResponse CheckEngineMetaTableSimply(CheckEngineMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckEngineMetaTable(request, runtime);
        }

        public async Task<CheckEngineMetaTableResponse> CheckEngineMetaTableSimplyAsync(CheckEngineMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckEngineMetaTableAsync(request, runtime);
        }

        public ImportDataSourcesResponse ImportDataSources(ImportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDataSourcesResponse>(DoRequest("ImportDataSources", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<ImportDataSourcesResponse> ImportDataSourcesAsync(ImportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDataSourcesResponse>(await DoRequestAsync("ImportDataSources", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public ImportDataSourcesResponse ImportDataSourcesSimply(ImportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDataSources(request, runtime);
        }

        public async Task<ImportDataSourcesResponse> ImportDataSourcesSimplyAsync(ImportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDataSourcesAsync(request, runtime);
        }

        public ExportDataSourcesResponse ExportDataSources(ExportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportDataSourcesResponse>(DoRequest("ExportDataSources", "HTTPS", "GET", "2020-05-18", "AK,APP,PrivateKey", request.ToMap(), null, runtime));
        }

        public async Task<ExportDataSourcesResponse> ExportDataSourcesAsync(ExportDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportDataSourcesResponse>(await DoRequestAsync("ExportDataSources", "HTTPS", "GET", "2020-05-18", "AK,APP,PrivateKey", request.ToMap(), null, runtime));
        }

        public ExportDataSourcesResponse ExportDataSourcesSimply(ExportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDataSources(request, runtime);
        }

        public async Task<ExportDataSourcesResponse> ExportDataSourcesSimplyAsync(ExportDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDataSourcesAsync(request, runtime);
        }

        public GetDataSourceMetaResponse GetDataSourceMeta(GetDataSourceMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataSourceMetaResponse>(DoRequest("GetDataSourceMeta", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<GetDataSourceMetaResponse> GetDataSourceMetaAsync(GetDataSourceMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataSourceMetaResponse>(await DoRequestAsync("GetDataSourceMeta", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public GetDataSourceMetaResponse GetDataSourceMetaSimply(GetDataSourceMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataSourceMeta(request, runtime);
        }

        public async Task<GetDataSourceMetaResponse> GetDataSourceMetaSimplyAsync(GetDataSourceMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataSourceMetaAsync(request, runtime);
        }

        public SetDataSourceShareResponse SetDataSourceShare(SetDataSourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDataSourceShareResponse>(DoRequest("SetDataSourceShare", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<SetDataSourceShareResponse> SetDataSourceShareAsync(SetDataSourceShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDataSourceShareResponse>(await DoRequestAsync("SetDataSourceShare", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public SetDataSourceShareResponse SetDataSourceShareSimply(SetDataSourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDataSourceShare(request, runtime);
        }

        public async Task<SetDataSourceShareResponse> SetDataSourceShareSimplyAsync(SetDataSourceShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDataSourceShareAsync(request, runtime);
        }

        public ListDIProjectConfigResponse ListDIProjectConfig(ListDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDIProjectConfigResponse>(DoRequest("ListDIProjectConfig", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListDIProjectConfigResponse> ListDIProjectConfigAsync(ListDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDIProjectConfigResponse>(await DoRequestAsync("ListDIProjectConfig", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public ListDIProjectConfigResponse ListDIProjectConfigSimply(ListDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDIProjectConfig(request, runtime);
        }

        public async Task<ListDIProjectConfigResponse> ListDIProjectConfigSimplyAsync(ListDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDIProjectConfigAsync(request, runtime);
        }

        public ExportConnectionsResponse ExportConnections(ExportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportConnectionsResponse>(DoRequest("ExportConnections", "HTTPS", "GET", "2020-05-18", "AK,APP,PrivateKey", request.ToMap(), null, runtime));
        }

        public async Task<ExportConnectionsResponse> ExportConnectionsAsync(ExportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportConnectionsResponse>(await DoRequestAsync("ExportConnections", "HTTPS", "GET", "2020-05-18", "AK,APP,PrivateKey", request.ToMap(), null, runtime));
        }

        public ExportConnectionsResponse ExportConnectionsSimply(ExportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportConnections(request, runtime);
        }

        public async Task<ExportConnectionsResponse> ExportConnectionsSimplyAsync(ExportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportConnectionsAsync(request, runtime);
        }

        public ListRefDISyncTasksResponse ListRefDISyncTasks(ListRefDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRefDISyncTasksResponse>(DoRequest("ListRefDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<ListRefDISyncTasksResponse> ListRefDISyncTasksAsync(ListRefDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRefDISyncTasksResponse>(await DoRequestAsync("ListRefDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public ListRefDISyncTasksResponse ListRefDISyncTasksSimply(ListRefDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRefDISyncTasks(request, runtime);
        }

        public async Task<ListRefDISyncTasksResponse> ListRefDISyncTasksSimplyAsync(ListRefDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRefDISyncTasksAsync(request, runtime);
        }

        public SetConnectionShareResponse SetConnectionShare(SetConnectionShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetConnectionShareResponse>(DoRequest("SetConnectionShare", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public async Task<SetConnectionShareResponse> SetConnectionShareAsync(SetConnectionShareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetConnectionShareResponse>(await DoRequestAsync("SetConnectionShare", "HTTPS", "POST", "2020-05-18", "AK,PrivateKey,APP", null, request.ToMap(), runtime));
        }

        public SetConnectionShareResponse SetConnectionShareSimply(SetConnectionShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetConnectionShare(request, runtime);
        }

        public async Task<SetConnectionShareResponse> SetConnectionShareSimplyAsync(SetConnectionShareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetConnectionShareAsync(request, runtime);
        }

        public ImportConnectionsResponse ImportConnections(ImportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportConnectionsResponse>(DoRequest("ImportConnections", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<ImportConnectionsResponse> ImportConnectionsAsync(ImportConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportConnectionsResponse>(await DoRequestAsync("ImportConnections", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public ImportConnectionsResponse ImportConnectionsSimply(ImportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportConnections(request, runtime);
        }

        public async Task<ImportConnectionsResponse> ImportConnectionsSimplyAsync(ImportConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportConnectionsAsync(request, runtime);
        }

        public GetConnectionMetaResponse GetConnectionMeta(GetConnectionMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetConnectionMetaResponse>(DoRequest("GetConnectionMeta", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<GetConnectionMetaResponse> GetConnectionMetaAsync(GetConnectionMetaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetConnectionMetaResponse>(await DoRequestAsync("GetConnectionMeta", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public GetConnectionMetaResponse GetConnectionMetaSimply(GetConnectionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionMeta(request, runtime);
        }

        public async Task<GetConnectionMetaResponse> GetConnectionMetaSimplyAsync(GetConnectionMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionMetaAsync(request, runtime);
        }

        public UpdateDIProjectConfigResponse UpdateDIProjectConfig(UpdateDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDIProjectConfigResponse>(DoRequest("UpdateDIProjectConfig", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDIProjectConfigResponse> UpdateDIProjectConfigAsync(UpdateDIProjectConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDIProjectConfigResponse>(await DoRequestAsync("UpdateDIProjectConfig", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public UpdateDIProjectConfigResponse UpdateDIProjectConfigSimply(UpdateDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDIProjectConfig(request, runtime);
        }

        public async Task<UpdateDIProjectConfigResponse> UpdateDIProjectConfigSimplyAsync(UpdateDIProjectConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDIProjectConfigAsync(request, runtime);
        }

        public CreateDISyncTaskResponse CreateDISyncTask(CreateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDISyncTaskResponse>(DoRequest("CreateDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<CreateDISyncTaskResponse> CreateDISyncTaskAsync(CreateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDISyncTaskResponse>(await DoRequestAsync("CreateDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public CreateDISyncTaskResponse CreateDISyncTaskSimply(CreateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDISyncTask(request, runtime);
        }

        public async Task<CreateDISyncTaskResponse> CreateDISyncTaskSimplyAsync(CreateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDISyncTaskAsync(request, runtime);
        }

        public UpdateDISyncTaskResponse UpdateDISyncTask(UpdateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDISyncTaskResponse>(DoRequest("UpdateDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDISyncTaskResponse> UpdateDISyncTaskAsync(UpdateDISyncTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDISyncTaskResponse>(await DoRequestAsync("UpdateDISyncTask", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public UpdateDISyncTaskResponse UpdateDISyncTaskSimply(UpdateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDISyncTask(request, runtime);
        }

        public async Task<UpdateDISyncTaskResponse> UpdateDISyncTaskSimplyAsync(UpdateDISyncTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDISyncTaskAsync(request, runtime);
        }

        public TestNetworkConnectionResponse TestNetworkConnection(TestNetworkConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TestNetworkConnectionResponse>(DoRequest("TestNetworkConnection", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<TestNetworkConnectionResponse> TestNetworkConnectionAsync(TestNetworkConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TestNetworkConnectionResponse>(await DoRequestAsync("TestNetworkConnection", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public TestNetworkConnectionResponse TestNetworkConnectionSimply(TestNetworkConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestNetworkConnection(request, runtime);
        }

        public async Task<TestNetworkConnectionResponse> TestNetworkConnectionSimplyAsync(TestNetworkConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestNetworkConnectionAsync(request, runtime);
        }

        public UpdateNodeRunModeResponse UpdateNodeRunMode(UpdateNodeRunModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateNodeRunModeResponse>(DoRequest("UpdateNodeRunMode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateNodeRunModeResponse> UpdateNodeRunModeAsync(UpdateNodeRunModeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateNodeRunModeResponse>(await DoRequestAsync("UpdateNodeRunMode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateNodeRunModeResponse UpdateNodeRunModeSimply(UpdateNodeRunModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNodeRunMode(request, runtime);
        }

        public async Task<UpdateNodeRunModeResponse> UpdateNodeRunModeSimplyAsync(UpdateNodeRunModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNodeRunModeAsync(request, runtime);
        }

        public UpdateNodeOwnerResponse UpdateNodeOwner(UpdateNodeOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateNodeOwnerResponse>(DoRequest("UpdateNodeOwner", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateNodeOwnerResponse> UpdateNodeOwnerAsync(UpdateNodeOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateNodeOwnerResponse>(await DoRequestAsync("UpdateNodeOwner", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateNodeOwnerResponse UpdateNodeOwnerSimply(UpdateNodeOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNodeOwner(request, runtime);
        }

        public async Task<UpdateNodeOwnerResponse> UpdateNodeOwnerSimplyAsync(UpdateNodeOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNodeOwnerAsync(request, runtime);
        }

        public QueryPublicModelEngineResponse QueryPublicModelEngine(QueryPublicModelEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryPublicModelEngineResponse>(DoRequest("QueryPublicModelEngine", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryPublicModelEngineResponse> QueryPublicModelEngineAsync(QueryPublicModelEngineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryPublicModelEngineResponse>(await DoRequestAsync("QueryPublicModelEngine", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public QueryPublicModelEngineResponse QueryPublicModelEngineSimply(QueryPublicModelEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPublicModelEngine(request, runtime);
        }

        public async Task<QueryPublicModelEngineResponse> QueryPublicModelEngineSimplyAsync(QueryPublicModelEngineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPublicModelEngineAsync(request, runtime);
        }

        public DeleteViewResponse DeleteView(DeleteViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteViewResponse>(DoRequest("DeleteView", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteViewResponse> DeleteViewAsync(DeleteViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteViewResponse>(await DoRequestAsync("DeleteView", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteViewResponse DeleteViewSimply(DeleteViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteView(request, runtime);
        }

        public async Task<DeleteViewResponse> DeleteViewSimplyAsync(DeleteViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteViewAsync(request, runtime);
        }

        public CreateViewResponse CreateView(CreateViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateViewResponse>(DoRequest("CreateView", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateViewResponse> CreateViewAsync(CreateViewRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateViewResponse>(await DoRequestAsync("CreateView", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateViewResponse CreateViewSimply(CreateViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateView(request, runtime);
        }

        public async Task<CreateViewResponse> CreateViewSimplyAsync(CreateViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateViewAsync(request, runtime);
        }

        public CheckFileDeploymentResponse CheckFileDeployment(CheckFileDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckFileDeploymentResponse>(DoRequest("CheckFileDeployment", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckFileDeploymentResponse> CheckFileDeploymentAsync(CheckFileDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckFileDeploymentResponse>(await DoRequestAsync("CheckFileDeployment", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CheckFileDeploymentResponse CheckFileDeploymentSimply(CheckFileDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckFileDeployment(request, runtime);
        }

        public async Task<CheckFileDeploymentResponse> CheckFileDeploymentSimplyAsync(CheckFileDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckFileDeploymentAsync(request, runtime);
        }

        public ImportDISyncTasksResponse ImportDISyncTasks(ImportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDISyncTasksResponse>(DoRequest("ImportDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<ImportDISyncTasksResponse> ImportDISyncTasksAsync(ImportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportDISyncTasksResponse>(await DoRequestAsync("ImportDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public ImportDISyncTasksResponse ImportDISyncTasksSimply(ImportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportDISyncTasks(request, runtime);
        }

        public async Task<ImportDISyncTasksResponse> ImportDISyncTasksSimplyAsync(ImportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportDISyncTasksAsync(request, runtime);
        }

        public ExportDISyncTasksResponse ExportDISyncTasks(ExportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportDISyncTasksResponse>(DoRequest("ExportDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<ExportDISyncTasksResponse> ExportDISyncTasksAsync(ExportDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ExportDISyncTasksResponse>(await DoRequestAsync("ExportDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public ExportDISyncTasksResponse ExportDISyncTasksSimply(ExportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExportDISyncTasks(request, runtime);
        }

        public async Task<ExportDISyncTasksResponse> ExportDISyncTasksSimplyAsync(ExportDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExportDISyncTasksAsync(request, runtime);
        }

        public ListDISyncTasksResponse ListDISyncTasks(ListDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDISyncTasksResponse>(DoRequest("ListDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public async Task<ListDISyncTasksResponse> ListDISyncTasksAsync(ListDISyncTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDISyncTasksResponse>(await DoRequestAsync("ListDISyncTasks", "HTTPS", "POST", "2020-05-18", "AK,APP,PrivateKey", null, request.ToMap(), runtime));
        }

        public ListDISyncTasksResponse ListDISyncTasksSimply(ListDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDISyncTasks(request, runtime);
        }

        public async Task<ListDISyncTasksResponse> ListDISyncTasksSimplyAsync(ListDISyncTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDISyncTasksAsync(request, runtime);
        }

        public RevokeColumnPermissionResponse RevokeColumnPermission(RevokeColumnPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeColumnPermissionResponse>(DoRequest("RevokeColumnPermission", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RevokeColumnPermissionResponse> RevokeColumnPermissionAsync(RevokeColumnPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeColumnPermissionResponse>(await DoRequestAsync("RevokeColumnPermission", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RevokeColumnPermissionResponse RevokeColumnPermissionSimply(RevokeColumnPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeColumnPermission(request, runtime);
        }

        public async Task<RevokeColumnPermissionResponse> RevokeColumnPermissionSimplyAsync(RevokeColumnPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeColumnPermissionAsync(request, runtime);
        }

        public RevokeTablePermissionResponse RevokeTablePermission(RevokeTablePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeTablePermissionResponse>(DoRequest("RevokeTablePermission", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RevokeTablePermissionResponse> RevokeTablePermissionAsync(RevokeTablePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RevokeTablePermissionResponse>(await DoRequestAsync("RevokeTablePermission", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RevokeTablePermissionResponse RevokeTablePermissionSimply(RevokeTablePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeTablePermission(request, runtime);
        }

        public async Task<RevokeTablePermissionResponse> RevokeTablePermissionSimplyAsync(RevokeTablePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeTablePermissionAsync(request, runtime);
        }

        public GetMetaTableThemeLevelResponse GetMetaTableThemeLevel(GetMetaTableThemeLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableThemeLevelResponse>(DoRequest("GetMetaTableThemeLevel", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetMetaTableThemeLevelResponse> GetMetaTableThemeLevelAsync(GetMetaTableThemeLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableThemeLevelResponse>(await DoRequestAsync("GetMetaTableThemeLevel", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetMetaTableThemeLevelResponse GetMetaTableThemeLevelSimply(GetMetaTableThemeLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableThemeLevel(request, runtime);
        }

        public async Task<GetMetaTableThemeLevelResponse> GetMetaTableThemeLevelSimplyAsync(GetMetaTableThemeLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableThemeLevelAsync(request, runtime);
        }

        public GetPermissionApplyOrderDetailResponse GetPermissionApplyOrderDetail(GetPermissionApplyOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPermissionApplyOrderDetailResponse>(DoRequest("GetPermissionApplyOrderDetail", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetPermissionApplyOrderDetailResponse> GetPermissionApplyOrderDetailAsync(GetPermissionApplyOrderDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetPermissionApplyOrderDetailResponse>(await DoRequestAsync("GetPermissionApplyOrderDetail", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetPermissionApplyOrderDetailResponse GetPermissionApplyOrderDetailSimply(GetPermissionApplyOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetPermissionApplyOrderDetail(request, runtime);
        }

        public async Task<GetPermissionApplyOrderDetailResponse> GetPermissionApplyOrderDetailSimplyAsync(GetPermissionApplyOrderDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetPermissionApplyOrderDetailAsync(request, runtime);
        }

        public ListPermissionApplyOrdersResponse ListPermissionApplyOrders(ListPermissionApplyOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPermissionApplyOrdersResponse>(DoRequest("ListPermissionApplyOrders", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListPermissionApplyOrdersResponse> ListPermissionApplyOrdersAsync(ListPermissionApplyOrdersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListPermissionApplyOrdersResponse>(await DoRequestAsync("ListPermissionApplyOrders", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListPermissionApplyOrdersResponse ListPermissionApplyOrdersSimply(ListPermissionApplyOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPermissionApplyOrders(request, runtime);
        }

        public async Task<ListPermissionApplyOrdersResponse> ListPermissionApplyOrdersSimplyAsync(ListPermissionApplyOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPermissionApplyOrdersAsync(request, runtime);
        }

        public CreatePermissionApplyOrderResponse CreatePermissionApplyOrder(CreatePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePermissionApplyOrderResponse>(DoRequest("CreatePermissionApplyOrder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreatePermissionApplyOrderResponse> CreatePermissionApplyOrderAsync(CreatePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreatePermissionApplyOrderResponse>(await DoRequestAsync("CreatePermissionApplyOrder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreatePermissionApplyOrderResponse CreatePermissionApplyOrderSimply(CreatePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePermissionApplyOrder(request, runtime);
        }

        public async Task<CreatePermissionApplyOrderResponse> CreatePermissionApplyOrderSimplyAsync(CreatePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePermissionApplyOrderAsync(request, runtime);
        }

        public ApprovePermissionApplyOrderResponse ApprovePermissionApplyOrder(ApprovePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ApprovePermissionApplyOrderResponse>(DoRequest("ApprovePermissionApplyOrder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ApprovePermissionApplyOrderResponse> ApprovePermissionApplyOrderAsync(ApprovePermissionApplyOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ApprovePermissionApplyOrderResponse>(await DoRequestAsync("ApprovePermissionApplyOrder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ApprovePermissionApplyOrderResponse ApprovePermissionApplyOrderSimply(ApprovePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApprovePermissionApplyOrder(request, runtime);
        }

        public async Task<ApprovePermissionApplyOrderResponse> ApprovePermissionApplyOrderSimplyAsync(ApprovePermissionApplyOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApprovePermissionApplyOrderAsync(request, runtime);
        }

        public ListSuccessInstanceAmountResponse ListSuccessInstanceAmount(ListSuccessInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSuccessInstanceAmountResponse>(DoRequest("ListSuccessInstanceAmount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListSuccessInstanceAmountResponse> ListSuccessInstanceAmountAsync(ListSuccessInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSuccessInstanceAmountResponse>(await DoRequestAsync("ListSuccessInstanceAmount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListSuccessInstanceAmountResponse ListSuccessInstanceAmountSimply(ListSuccessInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSuccessInstanceAmount(request, runtime);
        }

        public async Task<ListSuccessInstanceAmountResponse> ListSuccessInstanceAmountSimplyAsync(ListSuccessInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSuccessInstanceAmountAsync(request, runtime);
        }

        public ListFileTypeResponse ListFileType(ListFileTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFileTypeResponse>(DoRequest("ListFileType", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFileTypeResponse> ListFileTypeAsync(ListFileTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFileTypeResponse>(await DoRequestAsync("ListFileType", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListFileTypeResponse ListFileTypeSimply(ListFileTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileType(request, runtime);
        }

        public async Task<ListFileTypeResponse> ListFileTypeSimplyAsync(ListFileTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileTypeAsync(request, runtime);
        }

        public ListInstanceAmountResponse ListInstanceAmount(ListInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListInstanceAmountResponse>(DoRequest("ListInstanceAmount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListInstanceAmountResponse> ListInstanceAmountAsync(ListInstanceAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListInstanceAmountResponse>(await DoRequestAsync("ListInstanceAmount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListInstanceAmountResponse ListInstanceAmountSimply(ListInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceAmount(request, runtime);
        }

        public async Task<ListInstanceAmountResponse> ListInstanceAmountSimplyAsync(ListInstanceAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceAmountAsync(request, runtime);
        }

        public ListDataSourcesResponse ListDataSources(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataSourcesResponse>(DoRequest("ListDataSources", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataSourcesResponse>(await DoRequestAsync("ListDataSources", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public ListDataSourcesResponse ListDataSourcesSimply(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataSources(request, runtime);
        }

        public async Task<ListDataSourcesResponse> ListDataSourcesSimplyAsync(ListDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataSourcesAsync(request, runtime);
        }

        public ListNodesByBaselineResponse ListNodesByBaseline(ListNodesByBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodesByBaselineResponse>(DoRequest("ListNodesByBaseline", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListNodesByBaselineResponse> ListNodesByBaselineAsync(ListNodesByBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodesByBaselineResponse>(await DoRequestAsync("ListNodesByBaseline", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListNodesByBaselineResponse ListNodesByBaselineSimply(ListNodesByBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesByBaseline(request, runtime);
        }

        public async Task<ListNodesByBaselineResponse> ListNodesByBaselineSimplyAsync(ListNodesByBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesByBaselineAsync(request, runtime);
        }

        public ListManualDagInstancesResponse ListManualDagInstances(ListManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListManualDagInstancesResponse>(DoRequest("ListManualDagInstances", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListManualDagInstancesResponse> ListManualDagInstancesAsync(ListManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListManualDagInstancesResponse>(await DoRequestAsync("ListManualDagInstances", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListManualDagInstancesResponse ListManualDagInstancesSimply(ListManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListManualDagInstances(request, runtime);
        }

        public async Task<ListManualDagInstancesResponse> ListManualDagInstancesSimplyAsync(ListManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListManualDagInstancesAsync(request, runtime);
        }

        public GetInstanceStatusStatisticResponse GetInstanceStatusStatistic(GetInstanceStatusStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceStatusStatisticResponse>(DoRequest("GetInstanceStatusStatistic", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceStatusStatisticResponse> GetInstanceStatusStatisticAsync(GetInstanceStatusStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceStatusStatisticResponse>(await DoRequestAsync("GetInstanceStatusStatistic", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceStatusStatisticResponse GetInstanceStatusStatisticSimply(GetInstanceStatusStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceStatusStatistic(request, runtime);
        }

        public async Task<GetInstanceStatusStatisticResponse> GetInstanceStatusStatisticSimplyAsync(GetInstanceStatusStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceStatusStatisticAsync(request, runtime);
        }

        public DeleteDataSourceResponse DeleteDataSource(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataSourceResponse>(DoRequest("DeleteDataSource", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataSourceResponse>(await DoRequestAsync("DeleteDataSource", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDataSourceResponse DeleteDataSourceSimply(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataSource(request, runtime);
        }

        public async Task<DeleteDataSourceResponse> DeleteDataSourceSimplyAsync(DeleteDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataSourceAsync(request, runtime);
        }

        public CreateDataSourceResponse CreateDataSource(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataSourceResponse>(DoRequest("CreateDataSource", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceAsync(CreateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataSourceResponse>(await DoRequestAsync("CreateDataSource", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataSourceResponse CreateDataSourceSimply(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataSource(request, runtime);
        }

        public async Task<CreateDataSourceResponse> CreateDataSourceSimplyAsync(CreateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataSourceAsync(request, runtime);
        }

        public TopTenErrorTimesInstanceResponse TopTenErrorTimesInstance(TopTenErrorTimesInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TopTenErrorTimesInstanceResponse>(DoRequest("TopTenErrorTimesInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TopTenErrorTimesInstanceResponse> TopTenErrorTimesInstanceAsync(TopTenErrorTimesInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TopTenErrorTimesInstanceResponse>(await DoRequestAsync("TopTenErrorTimesInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public TopTenErrorTimesInstanceResponse TopTenErrorTimesInstanceSimply(TopTenErrorTimesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TopTenErrorTimesInstance(request, runtime);
        }

        public async Task<TopTenErrorTimesInstanceResponse> TopTenErrorTimesInstanceSimplyAsync(TopTenErrorTimesInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TopTenErrorTimesInstanceAsync(request, runtime);
        }

        public TopTenElapsedTimeInstanceResponse TopTenElapsedTimeInstance(TopTenElapsedTimeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TopTenElapsedTimeInstanceResponse>(DoRequest("TopTenElapsedTimeInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TopTenElapsedTimeInstanceResponse> TopTenElapsedTimeInstanceAsync(TopTenElapsedTimeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TopTenElapsedTimeInstanceResponse>(await DoRequestAsync("TopTenElapsedTimeInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public TopTenElapsedTimeInstanceResponse TopTenElapsedTimeInstanceSimply(TopTenElapsedTimeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TopTenElapsedTimeInstance(request, runtime);
        }

        public async Task<TopTenElapsedTimeInstanceResponse> TopTenElapsedTimeInstanceSimplyAsync(TopTenElapsedTimeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TopTenElapsedTimeInstanceAsync(request, runtime);
        }

        public GetProjectResponse GetProject(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProjectResponse>(DoRequest("GetProject", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetProjectResponse> GetProjectAsync(GetProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProjectResponse>(await DoRequestAsync("GetProject", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetProjectResponse GetProjectSimply(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProject(request, runtime);
        }

        public async Task<GetProjectResponse> GetProjectSimplyAsync(GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectAsync(request, runtime);
        }

        public ListNodesByOutputResponse ListNodesByOutput(ListNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodesByOutputResponse>(DoRequest("ListNodesByOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListNodesByOutputResponse> ListNodesByOutputAsync(ListNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodesByOutputResponse>(await DoRequestAsync("ListNodesByOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListNodesByOutputResponse ListNodesByOutputSimply(ListNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesByOutput(request, runtime);
        }

        public async Task<ListNodesByOutputResponse> ListNodesByOutputSimplyAsync(ListNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesByOutputAsync(request, runtime);
        }

        public GetFileTypeStatisticResponse GetFileTypeStatistic(GetFileTypeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFileTypeStatisticResponse>(DoRequest("GetFileTypeStatistic", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFileTypeStatisticResponse> GetFileTypeStatisticAsync(GetFileTypeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFileTypeStatisticResponse>(await DoRequestAsync("GetFileTypeStatistic", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetFileTypeStatisticResponse GetFileTypeStatisticSimply(GetFileTypeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileTypeStatistic(request, runtime);
        }

        public async Task<GetFileTypeStatisticResponse> GetFileTypeStatisticSimplyAsync(GetFileTypeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileTypeStatisticAsync(request, runtime);
        }

        public RunSmokeTestResponse RunSmokeTest(RunSmokeTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunSmokeTestResponse>(DoRequest("RunSmokeTest", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RunSmokeTestResponse> RunSmokeTestAsync(RunSmokeTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunSmokeTestResponse>(await DoRequestAsync("RunSmokeTest", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RunSmokeTestResponse RunSmokeTestSimply(RunSmokeTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunSmokeTest(request, runtime);
        }

        public async Task<RunSmokeTestResponse> RunSmokeTestSimplyAsync(RunSmokeTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunSmokeTestAsync(request, runtime);
        }

        public ListNodeInputOrOutputResponse ListNodeInputOrOutput(ListNodeInputOrOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodeInputOrOutputResponse>(DoRequest("ListNodeInputOrOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListNodeInputOrOutputResponse> ListNodeInputOrOutputAsync(ListNodeInputOrOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodeInputOrOutputResponse>(await DoRequestAsync("ListNodeInputOrOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListNodeInputOrOutputResponse ListNodeInputOrOutputSimply(ListNodeInputOrOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeInputOrOutput(request, runtime);
        }

        public async Task<ListNodeInputOrOutputResponse> ListNodeInputOrOutputSimplyAsync(ListNodeInputOrOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeInputOrOutputAsync(request, runtime);
        }

        public RunCycleDagNodesResponse RunCycleDagNodes(RunCycleDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunCycleDagNodesResponse>(DoRequest("RunCycleDagNodes", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RunCycleDagNodesResponse> RunCycleDagNodesAsync(RunCycleDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunCycleDagNodesResponse>(await DoRequestAsync("RunCycleDagNodes", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RunCycleDagNodesResponse RunCycleDagNodesSimply(RunCycleDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunCycleDagNodes(request, runtime);
        }

        public async Task<RunCycleDagNodesResponse> RunCycleDagNodesSimplyAsync(RunCycleDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunCycleDagNodesAsync(request, runtime);
        }

        public RunManualDagNodesResponse RunManualDagNodes(RunManualDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunManualDagNodesResponse>(DoRequest("RunManualDagNodes", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RunManualDagNodesResponse> RunManualDagNodesAsync(RunManualDagNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunManualDagNodesResponse>(await DoRequestAsync("RunManualDagNodes", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RunManualDagNodesResponse RunManualDagNodesSimply(RunManualDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunManualDagNodes(request, runtime);
        }

        public async Task<RunManualDagNodesResponse> RunManualDagNodesSimplyAsync(RunManualDagNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunManualDagNodesAsync(request, runtime);
        }

        public UpdateDataSourceResponse UpdateDataSource(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDataSourceResponse>(DoRequest("UpdateDataSource", "HTTPS", "PUT", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDataSourceResponse>(await DoRequestAsync("UpdateDataSource", "HTTPS", "PUT", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDataSourceResponse UpdateDataSourceSimply(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataSource(request, runtime);
        }

        public async Task<UpdateDataSourceResponse> UpdateDataSourceSimplyAsync(UpdateDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataSourceAsync(request, runtime);
        }

        public UpdateTableAddColumnResponse UpdateTableAddColumn(UpdateTableAddColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableAddColumnResponse>(DoRequest("UpdateTableAddColumn", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateTableAddColumnResponse> UpdateTableAddColumnAsync(UpdateTableAddColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableAddColumnResponse>(await DoRequestAsync("UpdateTableAddColumn", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateTableAddColumnResponse UpdateTableAddColumnSimply(UpdateTableAddColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableAddColumn(request, runtime);
        }

        public async Task<UpdateTableAddColumnResponse> UpdateTableAddColumnSimplyAsync(UpdateTableAddColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableAddColumnAsync(request, runtime);
        }

        public GetMigrationProcessResponse GetMigrationProcess(GetMigrationProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMigrationProcessResponse>(DoRequest("GetMigrationProcess", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMigrationProcessResponse> GetMigrationProcessAsync(GetMigrationProcessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMigrationProcessResponse>(await DoRequestAsync("GetMigrationProcess", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMigrationProcessResponse GetMigrationProcessSimply(GetMigrationProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMigrationProcess(request, runtime);
        }

        public async Task<GetMigrationProcessResponse> GetMigrationProcessSimplyAsync(GetMigrationProcessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMigrationProcessAsync(request, runtime);
        }

        public CreateImportMigrationResponse CreateImportMigration(CreateImportMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImportMigrationResponse>(DoRequest("CreateImportMigration", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateImportMigrationResponse> CreateImportMigrationAsync(CreateImportMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateImportMigrationResponse>(await DoRequestAsync("CreateImportMigration", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateImportMigrationResponse CreateImportMigrationSimply(CreateImportMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImportMigration(request, runtime);
        }

        public async Task<CreateImportMigrationResponse> CreateImportMigrationSimplyAsync(CreateImportMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImportMigrationAsync(request, runtime);
        }

        public CreateImportMigrationResponse CreateImportMigrationAdvance(CreateImportMigrationAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = this._credential.GetAccessKeyId();
            string accessKeySecret = this._credential.GetAccessKeySecret();
            string openPlatformEndpoint = _openPlatformEndpoint;
            string securityToken = this._credential.GetSecurityToken();
            string credentialType = this._credential.GetType();
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "dataworks-public",
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
            CreateImportMigrationRequest createImportMigrationReq = new CreateImportMigrationRequest();
            AlibabaCloud.Commons.Common.Convert(request, createImportMigrationReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageFileObject))
            {
                authResponse = authClient.AuthorizeFileUploadWithOptions(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.PackageFileObject,
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
                createImportMigrationReq.PackageFile = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            CreateImportMigrationResponse createImportMigrationResp = CreateImportMigration(createImportMigrationReq, runtime);
            return createImportMigrationResp;
        }

        public async Task<CreateImportMigrationResponse> CreateImportMigrationAdvanceAsync(CreateImportMigrationAdvanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            // Step 0: init client
            string accessKeyId = await this._credential.GetAccessKeyIdAsync();
            string accessKeySecret = await this._credential.GetAccessKeySecretAsync();
            string openPlatformEndpoint = _openPlatformEndpoint;
            string securityToken = await this._credential.GetSecurityTokenAsync();
            string credentialType = this._credential.GetType();
            if (AlibabaCloud.TeaUtil.Common.IsUnset(openPlatformEndpoint))
            {
                openPlatformEndpoint = "openplatform.aliyuncs.com";
            }
            if (AlibabaCloud.TeaUtil.Common.IsUnset(credentialType))
            {
                credentialType = "access_key";
            }
            AlibabaCloud.RPCClient.Models.Config authConfig = new AlibabaCloud.RPCClient.Models.Config
            {
                AccessKeyId = accessKeyId,
                AccessKeySecret = accessKeySecret,
                SecurityToken = securityToken,
                Type = credentialType,
                Endpoint = openPlatformEndpoint,
                Protocol = _protocol,
                RegionId = _regionId,
            };
            AlibabaCloud.SDK.OpenPlatform20191219.Client authClient = new AlibabaCloud.SDK.OpenPlatform20191219.Client(authConfig);
            AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest authRequest = new AlibabaCloud.SDK.OpenPlatform20191219.Models.AuthorizeFileUploadRequest
            {
                Product = "dataworks-public",
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
            CreateImportMigrationRequest createImportMigrationReq = new CreateImportMigrationRequest();
            AlibabaCloud.Commons.Common.Convert(request, createImportMigrationReq);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageFileObject))
            {
                authResponse = await authClient.AuthorizeFileUploadWithOptionsAsync(authRequest, runtime);
                ossConfig.AccessKeyId = authResponse.AccessKeyId;
                ossConfig.Endpoint = AlibabaCloud.Commons.Common.GetEndpoint(authResponse.Endpoint, authResponse.UseAccelerate, _endpointType);
                ossClient = new AlibabaCloud.OSS.Client(ossConfig);
                fileObj = new AlibabaCloud.SDK.TeaFileform.Models.FileField
                {
                    Filename = authResponse.ObjectKey,
                    Content = request.PackageFileObject,
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
                createImportMigrationReq.PackageFile = "http://" + authResponse.Bucket + "." + authResponse.Endpoint + "/" + authResponse.ObjectKey;
            }
            CreateImportMigrationResponse createImportMigrationResp = await CreateImportMigrationAsync(createImportMigrationReq, runtime);
            return createImportMigrationResp;
        }

        public StartMigrationResponse StartMigration(StartMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartMigrationResponse>(DoRequest("StartMigration", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartMigrationResponse> StartMigrationAsync(StartMigrationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartMigrationResponse>(await DoRequestAsync("StartMigration", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public StartMigrationResponse StartMigrationSimply(StartMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartMigration(request, runtime);
        }

        public async Task<StartMigrationResponse> StartMigrationSimplyAsync(StartMigrationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartMigrationAsync(request, runtime);
        }

        public GetNodeParentsResponse GetNodeParents(GetNodeParentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeParentsResponse>(DoRequest("GetNodeParents", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodeParentsResponse> GetNodeParentsAsync(GetNodeParentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeParentsResponse>(await DoRequestAsync("GetNodeParents", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetNodeParentsResponse GetNodeParentsSimply(GetNodeParentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeParents(request, runtime);
        }

        public async Task<GetNodeParentsResponse> GetNodeParentsSimplyAsync(GetNodeParentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeParentsAsync(request, runtime);
        }

        public GetNodeChildrenResponse GetNodeChildren(GetNodeChildrenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeChildrenResponse>(DoRequest("GetNodeChildren", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodeChildrenResponse> GetNodeChildrenAsync(GetNodeChildrenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeChildrenResponse>(await DoRequestAsync("GetNodeChildren", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetNodeChildrenResponse GetNodeChildrenSimply(GetNodeChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeChildren(request, runtime);
        }

        public async Task<GetNodeChildrenResponse> GetNodeChildrenSimplyAsync(GetNodeChildrenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeChildrenAsync(request, runtime);
        }

        public GetSensitiveDataResponse GetSensitiveData(GetSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSensitiveDataResponse>(DoRequest("GetSensitiveData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetSensitiveDataResponse> GetSensitiveDataAsync(GetSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSensitiveDataResponse>(await DoRequestAsync("GetSensitiveData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetSensitiveDataResponse GetSensitiveDataSimply(GetSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSensitiveData(request, runtime);
        }

        public async Task<GetSensitiveDataResponse> GetSensitiveDataSimplyAsync(GetSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSensitiveDataAsync(request, runtime);
        }

        public DesensitizeDataResponse DesensitizeData(DesensitizeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DesensitizeDataResponse>(DoRequest("DesensitizeData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DesensitizeDataResponse> DesensitizeDataAsync(DesensitizeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DesensitizeDataResponse>(await DoRequestAsync("DesensitizeData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public DesensitizeDataResponse DesensitizeDataSimply(DesensitizeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DesensitizeData(request, runtime);
        }

        public async Task<DesensitizeDataResponse> DesensitizeDataSimplyAsync(DesensitizeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DesensitizeDataAsync(request, runtime);
        }

        public GetOpRiskDataResponse GetOpRiskData(GetOpRiskDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetOpRiskDataResponse>(DoRequest("GetOpRiskData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetOpRiskDataResponse> GetOpRiskDataAsync(GetOpRiskDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetOpRiskDataResponse>(await DoRequestAsync("GetOpRiskData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetOpRiskDataResponse GetOpRiskDataSimply(GetOpRiskDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpRiskData(request, runtime);
        }

        public async Task<GetOpRiskDataResponse> GetOpRiskDataSimplyAsync(GetOpRiskDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpRiskDataAsync(request, runtime);
        }

        public ScanSensitiveDataResponse ScanSensitiveData(ScanSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ScanSensitiveDataResponse>(DoRequest("ScanSensitiveData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ScanSensitiveDataResponse> ScanSensitiveDataAsync(ScanSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ScanSensitiveDataResponse>(await DoRequestAsync("ScanSensitiveData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public ScanSensitiveDataResponse ScanSensitiveDataSimply(ScanSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ScanSensitiveData(request, runtime);
        }

        public async Task<ScanSensitiveDataResponse> ScanSensitiveDataSimplyAsync(ScanSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ScanSensitiveDataAsync(request, runtime);
        }

        public GetOpSensitiveDataResponse GetOpSensitiveData(GetOpSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetOpSensitiveDataResponse>(DoRequest("GetOpSensitiveData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetOpSensitiveDataResponse> GetOpSensitiveDataAsync(GetOpSensitiveDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetOpSensitiveDataResponse>(await DoRequestAsync("GetOpSensitiveData", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetOpSensitiveDataResponse GetOpSensitiveDataSimply(GetOpSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOpSensitiveData(request, runtime);
        }

        public async Task<GetOpSensitiveDataResponse> GetOpSensitiveDataSimplyAsync(GetOpSensitiveDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOpSensitiveDataAsync(request, runtime);
        }

        public CreateBusinessResponse CreateBusiness(CreateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBusinessResponse>(DoRequest("CreateBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateBusinessResponse> CreateBusinessAsync(CreateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBusinessResponse>(await DoRequestAsync("CreateBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateBusinessResponse CreateBusinessSimply(CreateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBusiness(request, runtime);
        }

        public async Task<CreateBusinessResponse> CreateBusinessSimplyAsync(CreateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBusinessAsync(request, runtime);
        }

        public RunTriggerNodeResponse RunTriggerNode(RunTriggerNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunTriggerNodeResponse>(DoRequest("RunTriggerNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RunTriggerNodeResponse> RunTriggerNodeAsync(RunTriggerNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RunTriggerNodeResponse>(await DoRequestAsync("RunTriggerNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RunTriggerNodeResponse RunTriggerNodeSimply(RunTriggerNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunTriggerNode(request, runtime);
        }

        public async Task<RunTriggerNodeResponse> RunTriggerNodeSimplyAsync(RunTriggerNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunTriggerNodeAsync(request, runtime);
        }

        public GetDagResponse GetDag(GetDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDagResponse>(DoRequest("GetDag", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDagResponse> GetDagAsync(GetDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDagResponse>(await DoRequestAsync("GetDag", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDagResponse GetDagSimply(GetDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDag(request, runtime);
        }

        public async Task<GetDagResponse> GetDagSimplyAsync(GetDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDagAsync(request, runtime);
        }

        public SearchNodesByOutputResponse SearchNodesByOutput(SearchNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SearchNodesByOutputResponse>(DoRequest("SearchNodesByOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SearchNodesByOutputResponse> SearchNodesByOutputAsync(SearchNodesByOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SearchNodesByOutputResponse>(await DoRequestAsync("SearchNodesByOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public SearchNodesByOutputResponse SearchNodesByOutputSimply(SearchNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchNodesByOutput(request, runtime);
        }

        public async Task<SearchNodesByOutputResponse> SearchNodesByOutputSimplyAsync(SearchNodesByOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchNodesByOutputAsync(request, runtime);
        }

        public GetManualDagInstancesResponse GetManualDagInstances(GetManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetManualDagInstancesResponse>(DoRequest("GetManualDagInstances", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetManualDagInstancesResponse> GetManualDagInstancesAsync(GetManualDagInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetManualDagInstancesResponse>(await DoRequestAsync("GetManualDagInstances", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetManualDagInstancesResponse GetManualDagInstancesSimply(GetManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetManualDagInstances(request, runtime);
        }

        public async Task<GetManualDagInstancesResponse> GetManualDagInstancesSimplyAsync(GetManualDagInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetManualDagInstancesAsync(request, runtime);
        }

        public CreateManualDagResponse CreateManualDag(CreateManualDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateManualDagResponse>(DoRequest("CreateManualDag", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateManualDagResponse> CreateManualDagAsync(CreateManualDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateManualDagResponse>(await DoRequestAsync("CreateManualDag", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateManualDagResponse CreateManualDagSimply(CreateManualDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateManualDag(request, runtime);
        }

        public async Task<CreateManualDagResponse> CreateManualDagSimplyAsync(CreateManualDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateManualDagAsync(request, runtime);
        }

        public ListQualityResultsByEntityResponse ListQualityResultsByEntity(ListQualityResultsByEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListQualityResultsByEntityResponse>(DoRequest("ListQualityResultsByEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListQualityResultsByEntityResponse> ListQualityResultsByEntityAsync(ListQualityResultsByEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListQualityResultsByEntityResponse>(await DoRequestAsync("ListQualityResultsByEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListQualityResultsByEntityResponse ListQualityResultsByEntitySimply(ListQualityResultsByEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityResultsByEntity(request, runtime);
        }

        public async Task<ListQualityResultsByEntityResponse> ListQualityResultsByEntitySimplyAsync(ListQualityResultsByEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityResultsByEntityAsync(request, runtime);
        }

        public GetNodeTypeListInfoResponse GetNodeTypeListInfo(GetNodeTypeListInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeTypeListInfoResponse>(DoRequest("GetNodeTypeListInfo", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodeTypeListInfoResponse> GetNodeTypeListInfoAsync(GetNodeTypeListInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeTypeListInfoResponse>(await DoRequestAsync("GetNodeTypeListInfo", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetNodeTypeListInfoResponse GetNodeTypeListInfoSimply(GetNodeTypeListInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeTypeListInfo(request, runtime);
        }

        public async Task<GetNodeTypeListInfoResponse> GetNodeTypeListInfoSimplyAsync(GetNodeTypeListInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeTypeListInfoAsync(request, runtime);
        }

        public GetInstanceStatusCountResponse GetInstanceStatusCount(GetInstanceStatusCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceStatusCountResponse>(DoRequest("GetInstanceStatusCount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceStatusCountResponse> GetInstanceStatusCountAsync(GetInstanceStatusCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceStatusCountResponse>(await DoRequestAsync("GetInstanceStatusCount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceStatusCountResponse GetInstanceStatusCountSimply(GetInstanceStatusCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceStatusCount(request, runtime);
        }

        public async Task<GetInstanceStatusCountResponse> GetInstanceStatusCountSimplyAsync(GetInstanceStatusCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceStatusCountAsync(request, runtime);
        }

        public ListDataServiceFoldersResponse ListDataServiceFolders(ListDataServiceFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceFoldersResponse>(DoRequest("ListDataServiceFolders", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServiceFoldersResponse> ListDataServiceFoldersAsync(ListDataServiceFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceFoldersResponse>(await DoRequestAsync("ListDataServiceFolders", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServiceFoldersResponse ListDataServiceFoldersSimply(ListDataServiceFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceFolders(request, runtime);
        }

        public async Task<ListDataServiceFoldersResponse> ListDataServiceFoldersSimplyAsync(ListDataServiceFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceFoldersAsync(request, runtime);
        }

        public ListQualityResultsByRuleResponse ListQualityResultsByRule(ListQualityResultsByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListQualityResultsByRuleResponse>(DoRequest("ListQualityResultsByRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListQualityResultsByRuleResponse> ListQualityResultsByRuleAsync(ListQualityResultsByRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListQualityResultsByRuleResponse>(await DoRequestAsync("ListQualityResultsByRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListQualityResultsByRuleResponse ListQualityResultsByRuleSimply(ListQualityResultsByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityResultsByRule(request, runtime);
        }

        public async Task<ListQualityResultsByRuleResponse> ListQualityResultsByRuleSimplyAsync(ListQualityResultsByRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityResultsByRuleAsync(request, runtime);
        }

        public ListMetaDBResponse ListMetaDB(ListMetaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMetaDBResponse>(DoRequest("ListMetaDB", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListMetaDBResponse> ListMetaDBAsync(ListMetaDBRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListMetaDBResponse>(await DoRequestAsync("ListMetaDB", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public ListMetaDBResponse ListMetaDBSimply(ListMetaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMetaDB(request, runtime);
        }

        public async Task<ListMetaDBResponse> ListMetaDBSimplyAsync(ListMetaDBRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMetaDBAsync(request, runtime);
        }

        public CreateTableResponse CreateTable(CreateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTableResponse>(DoRequest("CreateTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateTableResponse> CreateTableAsync(CreateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTableResponse>(await DoRequestAsync("CreateTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateTableResponse CreateTableSimply(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTable(request, runtime);
        }

        public async Task<CreateTableResponse> CreateTableSimplyAsync(CreateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableAsync(request, runtime);
        }

        public CreateTableThemeResponse CreateTableTheme(CreateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTableThemeResponse>(DoRequest("CreateTableTheme", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateTableThemeResponse> CreateTableThemeAsync(CreateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTableThemeResponse>(await DoRequestAsync("CreateTableTheme", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateTableThemeResponse CreateTableThemeSimply(CreateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTableTheme(request, runtime);
        }

        public async Task<CreateTableThemeResponse> CreateTableThemeSimplyAsync(CreateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableThemeAsync(request, runtime);
        }

        public GetInstanceErrorRankResponse GetInstanceErrorRank(GetInstanceErrorRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceErrorRankResponse>(DoRequest("GetInstanceErrorRank", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceErrorRankResponse> GetInstanceErrorRankAsync(GetInstanceErrorRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceErrorRankResponse>(await DoRequestAsync("GetInstanceErrorRank", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceErrorRankResponse GetInstanceErrorRankSimply(GetInstanceErrorRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceErrorRank(request, runtime);
        }

        public async Task<GetInstanceErrorRankResponse> GetInstanceErrorRankSimplyAsync(GetInstanceErrorRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceErrorRankAsync(request, runtime);
        }

        public GetDDLJobStatusResponse GetDDLJobStatus(GetDDLJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDDLJobStatusResponse>(DoRequest("GetDDLJobStatus", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetDDLJobStatusResponse> GetDDLJobStatusAsync(GetDDLJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDDLJobStatusResponse>(await DoRequestAsync("GetDDLJobStatus", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetDDLJobStatusResponse GetDDLJobStatusSimply(GetDDLJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDDLJobStatus(request, runtime);
        }

        public async Task<GetDDLJobStatusResponse> GetDDLJobStatusSimplyAsync(GetDDLJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDDLJobStatusAsync(request, runtime);
        }

        public GetInstanceConsumeTimeRankResponse GetInstanceConsumeTimeRank(GetInstanceConsumeTimeRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceConsumeTimeRankResponse>(DoRequest("GetInstanceConsumeTimeRank", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceConsumeTimeRankResponse> GetInstanceConsumeTimeRankAsync(GetInstanceConsumeTimeRankRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceConsumeTimeRankResponse>(await DoRequestAsync("GetInstanceConsumeTimeRank", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceConsumeTimeRankResponse GetInstanceConsumeTimeRankSimply(GetInstanceConsumeTimeRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceConsumeTimeRank(request, runtime);
        }

        public async Task<GetInstanceConsumeTimeRankResponse> GetInstanceConsumeTimeRankSimplyAsync(GetInstanceConsumeTimeRankRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceConsumeTimeRankAsync(request, runtime);
        }

        public CreateDataServiceApiAuthorityResponse CreateDataServiceApiAuthority(CreateDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceApiAuthorityResponse>(DoRequest("CreateDataServiceApiAuthority", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataServiceApiAuthorityResponse> CreateDataServiceApiAuthorityAsync(CreateDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceApiAuthorityResponse>(await DoRequestAsync("CreateDataServiceApiAuthority", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataServiceApiAuthorityResponse CreateDataServiceApiAuthoritySimply(CreateDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceApiAuthority(request, runtime);
        }

        public async Task<CreateDataServiceApiAuthorityResponse> CreateDataServiceApiAuthoritySimplyAsync(CreateDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceApiAuthorityAsync(request, runtime);
        }

        public DeleteDataServiceApiAuthorityResponse DeleteDataServiceApiAuthority(DeleteDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataServiceApiAuthorityResponse>(DoRequest("DeleteDataServiceApiAuthority", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDataServiceApiAuthorityResponse> DeleteDataServiceApiAuthorityAsync(DeleteDataServiceApiAuthorityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataServiceApiAuthorityResponse>(await DoRequestAsync("DeleteDataServiceApiAuthority", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDataServiceApiAuthorityResponse DeleteDataServiceApiAuthoritySimply(DeleteDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataServiceApiAuthority(request, runtime);
        }

        public async Task<DeleteDataServiceApiAuthorityResponse> DeleteDataServiceApiAuthoritySimplyAsync(DeleteDataServiceApiAuthorityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataServiceApiAuthorityAsync(request, runtime);
        }

        public CreateDataServiceGroupResponse CreateDataServiceGroup(CreateDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceGroupResponse>(DoRequest("CreateDataServiceGroup", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataServiceGroupResponse> CreateDataServiceGroupAsync(CreateDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceGroupResponse>(await DoRequestAsync("CreateDataServiceGroup", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataServiceGroupResponse CreateDataServiceGroupSimply(CreateDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceGroup(request, runtime);
        }

        public async Task<CreateDataServiceGroupResponse> CreateDataServiceGroupSimplyAsync(CreateDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceGroupAsync(request, runtime);
        }

        public UpdateMetaTableResponse UpdateMetaTable(UpdateMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMetaTableResponse>(DoRequest("UpdateMetaTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateMetaTableResponse> UpdateMetaTableAsync(UpdateMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMetaTableResponse>(await DoRequestAsync("UpdateMetaTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateMetaTableResponse UpdateMetaTableSimply(UpdateMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMetaTable(request, runtime);
        }

        public async Task<UpdateMetaTableResponse> UpdateMetaTableSimplyAsync(UpdateMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMetaTableAsync(request, runtime);
        }

        public GetInstanceCountTrendResponse GetInstanceCountTrend(GetInstanceCountTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceCountTrendResponse>(DoRequest("GetInstanceCountTrend", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceCountTrendResponse> GetInstanceCountTrendAsync(GetInstanceCountTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceCountTrendResponse>(await DoRequestAsync("GetInstanceCountTrend", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceCountTrendResponse GetInstanceCountTrendSimply(GetInstanceCountTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceCountTrend(request, runtime);
        }

        public async Task<GetInstanceCountTrendResponse> GetInstanceCountTrendSimplyAsync(GetInstanceCountTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceCountTrendAsync(request, runtime);
        }

        public DeleteTableResponse DeleteTable(DeleteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTableResponse>(DoRequest("DeleteTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTableResponse>(await DoRequestAsync("DeleteTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteTableResponse DeleteTableSimply(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTable(request, runtime);
        }

        public async Task<DeleteTableResponse> DeleteTableSimplyAsync(DeleteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableAsync(request, runtime);
        }

        public ListTableThemeResponse ListTableTheme(ListTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTableThemeResponse>(DoRequest("ListTableTheme", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListTableThemeResponse> ListTableThemeAsync(ListTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTableThemeResponse>(await DoRequestAsync("ListTableTheme", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public ListTableThemeResponse ListTableThemeSimply(ListTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTableTheme(request, runtime);
        }

        public async Task<ListTableThemeResponse> ListTableThemeSimplyAsync(ListTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTableThemeAsync(request, runtime);
        }

        public GetSuccessInstanceTrendResponse GetSuccessInstanceTrend(GetSuccessInstanceTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSuccessInstanceTrendResponse>(DoRequest("GetSuccessInstanceTrend", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSuccessInstanceTrendResponse> GetSuccessInstanceTrendAsync(GetSuccessInstanceTrendRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSuccessInstanceTrendResponse>(await DoRequestAsync("GetSuccessInstanceTrend", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetSuccessInstanceTrendResponse GetSuccessInstanceTrendSimply(GetSuccessInstanceTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSuccessInstanceTrend(request, runtime);
        }

        public async Task<GetSuccessInstanceTrendResponse> GetSuccessInstanceTrendSimplyAsync(GetSuccessInstanceTrendRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSuccessInstanceTrendAsync(request, runtime);
        }

        public UpdateTableResponse UpdateTable(UpdateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableResponse>(DoRequest("UpdateTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableResponse>(await DoRequestAsync("UpdateTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateTableResponse UpdateTableSimply(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTable(request, runtime);
        }

        public async Task<UpdateTableResponse> UpdateTableSimplyAsync(UpdateTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableAsync(request, runtime);
        }

        public GetDataServiceFolderResponse GetDataServiceFolder(GetDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceFolderResponse>(DoRequest("GetDataServiceFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataServiceFolderResponse> GetDataServiceFolderAsync(GetDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceFolderResponse>(await DoRequestAsync("GetDataServiceFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDataServiceFolderResponse GetDataServiceFolderSimply(GetDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceFolder(request, runtime);
        }

        public async Task<GetDataServiceFolderResponse> GetDataServiceFolderSimplyAsync(GetDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceFolderAsync(request, runtime);
        }

        public ListTableLevelResponse ListTableLevel(ListTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTableLevelResponse>(DoRequest("ListTableLevel", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListTableLevelResponse> ListTableLevelAsync(ListTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTableLevelResponse>(await DoRequestAsync("ListTableLevel", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public ListTableLevelResponse ListTableLevelSimply(ListTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTableLevel(request, runtime);
        }

        public async Task<ListTableLevelResponse> ListTableLevelSimplyAsync(ListTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTableLevelAsync(request, runtime);
        }

        public ListDataServiceGroupsResponse ListDataServiceGroups(ListDataServiceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceGroupsResponse>(DoRequest("ListDataServiceGroups", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServiceGroupsResponse> ListDataServiceGroupsAsync(ListDataServiceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceGroupsResponse>(await DoRequestAsync("ListDataServiceGroups", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServiceGroupsResponse ListDataServiceGroupsSimply(ListDataServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceGroups(request, runtime);
        }

        public async Task<ListDataServiceGroupsResponse> ListDataServiceGroupsSimplyAsync(ListDataServiceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceGroupsAsync(request, runtime);
        }

        public UpdateTableThemeResponse UpdateTableTheme(UpdateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableThemeResponse>(DoRequest("UpdateTableTheme", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateTableThemeResponse> UpdateTableThemeAsync(UpdateTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableThemeResponse>(await DoRequestAsync("UpdateTableTheme", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateTableThemeResponse UpdateTableThemeSimply(UpdateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableTheme(request, runtime);
        }

        public async Task<UpdateTableThemeResponse> UpdateTableThemeSimplyAsync(UpdateTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableThemeAsync(request, runtime);
        }

        public CreateDataServiceFolderResponse CreateDataServiceFolder(CreateDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceFolderResponse>(DoRequest("CreateDataServiceFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataServiceFolderResponse> CreateDataServiceFolderAsync(CreateDataServiceFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceFolderResponse>(await DoRequestAsync("CreateDataServiceFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataServiceFolderResponse CreateDataServiceFolderSimply(CreateDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceFolder(request, runtime);
        }

        public async Task<CreateDataServiceFolderResponse> CreateDataServiceFolderSimplyAsync(CreateDataServiceFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceFolderAsync(request, runtime);
        }

        public GetDataServiceGroupResponse GetDataServiceGroup(GetDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceGroupResponse>(DoRequest("GetDataServiceGroup", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataServiceGroupResponse> GetDataServiceGroupAsync(GetDataServiceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceGroupResponse>(await DoRequestAsync("GetDataServiceGroup", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDataServiceGroupResponse GetDataServiceGroupSimply(GetDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceGroup(request, runtime);
        }

        public async Task<GetDataServiceGroupResponse> GetDataServiceGroupSimplyAsync(GetDataServiceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceGroupAsync(request, runtime);
        }

        public CreateTableLevelResponse CreateTableLevel(CreateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTableLevelResponse>(DoRequest("CreateTableLevel", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateTableLevelResponse> CreateTableLevelAsync(CreateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTableLevelResponse>(await DoRequestAsync("CreateTableLevel", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateTableLevelResponse CreateTableLevelSimply(CreateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTableLevel(request, runtime);
        }

        public async Task<CreateTableLevelResponse> CreateTableLevelSimplyAsync(CreateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTableLevelAsync(request, runtime);
        }

        public UpdateMetaTableIntroWikiResponse UpdateMetaTableIntroWiki(UpdateMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMetaTableIntroWikiResponse>(DoRequest("UpdateMetaTableIntroWiki", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateMetaTableIntroWikiResponse> UpdateMetaTableIntroWikiAsync(UpdateMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMetaTableIntroWikiResponse>(await DoRequestAsync("UpdateMetaTableIntroWiki", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateMetaTableIntroWikiResponse UpdateMetaTableIntroWikiSimply(UpdateMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMetaTableIntroWiki(request, runtime);
        }

        public async Task<UpdateMetaTableIntroWikiResponse> UpdateMetaTableIntroWikiSimplyAsync(UpdateMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMetaTableIntroWikiAsync(request, runtime);
        }

        public DeleteTableLevelResponse DeleteTableLevel(DeleteTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTableLevelResponse>(DoRequest("DeleteTableLevel", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteTableLevelResponse> DeleteTableLevelAsync(DeleteTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTableLevelResponse>(await DoRequestAsync("DeleteTableLevel", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteTableLevelResponse DeleteTableLevelSimply(DeleteTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTableLevel(request, runtime);
        }

        public async Task<DeleteTableLevelResponse> DeleteTableLevelSimplyAsync(DeleteTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableLevelAsync(request, runtime);
        }

        public UpdateTableLevelResponse UpdateTableLevel(UpdateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableLevelResponse>(DoRequest("UpdateTableLevel", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateTableLevelResponse> UpdateTableLevelAsync(UpdateTableLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableLevelResponse>(await DoRequestAsync("UpdateTableLevel", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateTableLevelResponse UpdateTableLevelSimply(UpdateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableLevel(request, runtime);
        }

        public async Task<UpdateTableLevelResponse> UpdateTableLevelSimplyAsync(UpdateTableLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableLevelAsync(request, runtime);
        }

        public DeleteTableThemeResponse DeleteTableTheme(DeleteTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTableThemeResponse>(DoRequest("DeleteTableTheme", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteTableThemeResponse> DeleteTableThemeAsync(DeleteTableThemeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTableThemeResponse>(await DoRequestAsync("DeleteTableTheme", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteTableThemeResponse DeleteTableThemeSimply(DeleteTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTableTheme(request, runtime);
        }

        public async Task<DeleteTableThemeResponse> DeleteTableThemeSimplyAsync(DeleteTableThemeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTableThemeAsync(request, runtime);
        }

        public ListProgramTypeCountResponse ListProgramTypeCount(ListProgramTypeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProgramTypeCountResponse>(DoRequest("ListProgramTypeCount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProgramTypeCountResponse> ListProgramTypeCountAsync(ListProgramTypeCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProgramTypeCountResponse>(await DoRequestAsync("ListProgramTypeCount", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListProgramTypeCountResponse ListProgramTypeCountSimply(ListProgramTypeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProgramTypeCount(request, runtime);
        }

        public async Task<ListProgramTypeCountResponse> ListProgramTypeCountSimplyAsync(ListProgramTypeCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProgramTypeCountAsync(request, runtime);
        }

        public UpdateTableModelInfoResponse UpdateTableModelInfo(UpdateTableModelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableModelInfoResponse>(DoRequest("UpdateTableModelInfo", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateTableModelInfoResponse> UpdateTableModelInfoAsync(UpdateTableModelInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateTableModelInfoResponse>(await DoRequestAsync("UpdateTableModelInfo", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateTableModelInfoResponse UpdateTableModelInfoSimply(UpdateTableModelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTableModelInfo(request, runtime);
        }

        public async Task<UpdateTableModelInfoResponse> UpdateTableModelInfoSimplyAsync(UpdateTableModelInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTableModelInfoAsync(request, runtime);
        }

        public ListProjectsResponse ListProjects(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectsResponse>(DoRequest("ListProjects", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectsResponse>(await DoRequestAsync("ListProjects", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListProjectsResponse ListProjectsSimply(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjects(request, runtime);
        }

        public async Task<ListProjectsResponse> ListProjectsSimplyAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectsAsync(request, runtime);
        }

        public ListProjectMembersResponse ListProjectMembers(ListProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectMembersResponse>(DoRequest("ListProjectMembers", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProjectMembersResponse> ListProjectMembersAsync(ListProjectMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectMembersResponse>(await DoRequestAsync("ListProjectMembers", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListProjectMembersResponse ListProjectMembersSimply(ListProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectMembers(request, runtime);
        }

        public async Task<ListProjectMembersResponse> ListProjectMembersSimplyAsync(ListProjectMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectMembersAsync(request, runtime);
        }

        public CreateProjectMemberResponse CreateProjectMember(CreateProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProjectMemberResponse>(DoRequest("CreateProjectMember", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProjectMemberResponse> CreateProjectMemberAsync(CreateProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProjectMemberResponse>(await DoRequestAsync("CreateProjectMember", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateProjectMemberResponse CreateProjectMemberSimply(CreateProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectMember(request, runtime);
        }

        public async Task<CreateProjectMemberResponse> CreateProjectMemberSimplyAsync(CreateProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectMemberAsync(request, runtime);
        }

        public ListProjectRolesResponse ListProjectRoles(ListProjectRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectRolesResponse>(DoRequest("ListProjectRoles", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProjectRolesResponse> ListProjectRolesAsync(ListProjectRolesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProjectRolesResponse>(await DoRequestAsync("ListProjectRoles", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListProjectRolesResponse ListProjectRolesSimply(ListProjectRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProjectRoles(request, runtime);
        }

        public async Task<ListProjectRolesResponse> ListProjectRolesSimplyAsync(ListProjectRolesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProjectRolesAsync(request, runtime);
        }

        public AddProjectMemberToRoleResponse AddProjectMemberToRole(AddProjectMemberToRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProjectMemberToRoleResponse>(DoRequest("AddProjectMemberToRole", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddProjectMemberToRoleResponse> AddProjectMemberToRoleAsync(AddProjectMemberToRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddProjectMemberToRoleResponse>(await DoRequestAsync("AddProjectMemberToRole", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public AddProjectMemberToRoleResponse AddProjectMemberToRoleSimply(AddProjectMemberToRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddProjectMemberToRole(request, runtime);
        }

        public async Task<AddProjectMemberToRoleResponse> AddProjectMemberToRoleSimplyAsync(AddProjectMemberToRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddProjectMemberToRoleAsync(request, runtime);
        }

        public RemoveProjectMemberFromRoleResponse RemoveProjectMemberFromRole(RemoveProjectMemberFromRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveProjectMemberFromRoleResponse>(DoRequest("RemoveProjectMemberFromRole", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveProjectMemberFromRoleResponse> RemoveProjectMemberFromRoleAsync(RemoveProjectMemberFromRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveProjectMemberFromRoleResponse>(await DoRequestAsync("RemoveProjectMemberFromRole", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RemoveProjectMemberFromRoleResponse RemoveProjectMemberFromRoleSimply(RemoveProjectMemberFromRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveProjectMemberFromRole(request, runtime);
        }

        public async Task<RemoveProjectMemberFromRoleResponse> RemoveProjectMemberFromRoleSimplyAsync(RemoveProjectMemberFromRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveProjectMemberFromRoleAsync(request, runtime);
        }

        public DeleteProjectMemberResponse DeleteProjectMember(DeleteProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProjectMemberResponse>(DoRequest("DeleteProjectMember", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberAsync(DeleteProjectMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProjectMemberResponse>(await DoRequestAsync("DeleteProjectMember", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProjectMemberResponse DeleteProjectMemberSimply(DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProjectMember(request, runtime);
        }

        public async Task<DeleteProjectMemberResponse> DeleteProjectMemberSimplyAsync(DeleteProjectMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProjectMemberAsync(request, runtime);
        }

        public CreateDagComplementResponse CreateDagComplement(CreateDagComplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDagComplementResponse>(DoRequest("CreateDagComplement", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDagComplementResponse> CreateDagComplementAsync(CreateDagComplementRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDagComplementResponse>(await DoRequestAsync("CreateDagComplement", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDagComplementResponse CreateDagComplementSimply(CreateDagComplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDagComplement(request, runtime);
        }

        public async Task<CreateDagComplementResponse> CreateDagComplementSimplyAsync(CreateDagComplementRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDagComplementAsync(request, runtime);
        }

        public CreateDagTestResponse CreateDagTest(CreateDagTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDagTestResponse>(DoRequest("CreateDagTest", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDagTestResponse> CreateDagTestAsync(CreateDagTestRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDagTestResponse>(await DoRequestAsync("CreateDagTest", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDagTestResponse CreateDagTestSimply(CreateDagTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDagTest(request, runtime);
        }

        public async Task<CreateDagTestResponse> CreateDagTestSimplyAsync(CreateDagTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDagTestAsync(request, runtime);
        }

        public ListCalcEnginesResponse ListCalcEngines(ListCalcEnginesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCalcEnginesResponse>(DoRequest("ListCalcEngines", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListCalcEnginesResponse> ListCalcEnginesAsync(ListCalcEnginesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListCalcEnginesResponse>(await DoRequestAsync("ListCalcEngines", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListCalcEnginesResponse ListCalcEnginesSimply(ListCalcEnginesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCalcEngines(request, runtime);
        }

        public async Task<ListCalcEnginesResponse> ListCalcEnginesSimplyAsync(ListCalcEnginesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCalcEnginesAsync(request, runtime);
        }

        public ListConnectionsResponse ListConnections(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListConnectionsResponse>(DoRequest("ListConnections", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListConnectionsResponse>(await DoRequestAsync("ListConnections", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public ListConnectionsResponse ListConnectionsSimply(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnections(request, runtime);
        }

        public async Task<ListConnectionsResponse> ListConnectionsSimplyAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionsAsync(request, runtime);
        }

        public UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateConnectionResponse>(DoRequest("UpdateConnection", "HTTPS", "PUT", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateConnectionResponse>(await DoRequestAsync("UpdateConnection", "HTTPS", "PUT", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateConnectionResponse UpdateConnectionSimply(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnection(request, runtime);
        }

        public async Task<UpdateConnectionResponse> UpdateConnectionSimplyAsync(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnectionAsync(request, runtime);
        }

        public DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConnectionResponse>(DoRequest("DeleteConnection", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConnectionResponse>(await DoRequestAsync("DeleteConnection", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteConnectionResponse DeleteConnectionSimply(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConnection(request, runtime);
        }

        public async Task<DeleteConnectionResponse> DeleteConnectionSimplyAsync(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConnectionAsync(request, runtime);
        }

        public GetProjectDetailResponse GetProjectDetail(GetProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProjectDetailResponse>(DoRequest("GetProjectDetail", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetProjectDetailResponse> GetProjectDetailAsync(GetProjectDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetProjectDetailResponse>(await DoRequestAsync("GetProjectDetail", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetProjectDetailResponse GetProjectDetailSimply(GetProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProjectDetail(request, runtime);
        }

        public async Task<GetProjectDetailResponse> GetProjectDetailSimplyAsync(GetProjectDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProjectDetailAsync(request, runtime);
        }

        public ListResourceGroupsResponse ListResourceGroups(ListResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceGroupsResponse>(DoRequest("ListResourceGroups", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListResourceGroupsResponse> ListResourceGroupsAsync(ListResourceGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListResourceGroupsResponse>(await DoRequestAsync("ListResourceGroups", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListResourceGroupsResponse ListResourceGroupsSimply(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceGroups(request, runtime);
        }

        public async Task<ListResourceGroupsResponse> ListResourceGroupsSimplyAsync(ListResourceGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceGroupsAsync(request, runtime);
        }

        public CreateConnectionResponse CreateConnection(CreateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConnectionResponse>(DoRequest("CreateConnection", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConnectionResponse>(await DoRequestAsync("CreateConnection", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateConnectionResponse CreateConnectionSimply(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConnection(request, runtime);
        }

        public async Task<CreateConnectionResponse> CreateConnectionSimplyAsync(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConnectionAsync(request, runtime);
        }

        public GetDataServiceApplicationResponse GetDataServiceApplication(GetDataServiceApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceApplicationResponse>(DoRequest("GetDataServiceApplication", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataServiceApplicationResponse> GetDataServiceApplicationAsync(GetDataServiceApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceApplicationResponse>(await DoRequestAsync("GetDataServiceApplication", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDataServiceApplicationResponse GetDataServiceApplicationSimply(GetDataServiceApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceApplication(request, runtime);
        }

        public async Task<GetDataServiceApplicationResponse> GetDataServiceApplicationSimplyAsync(GetDataServiceApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceApplicationAsync(request, runtime);
        }

        public ListDataServiceApplicationsResponse ListDataServiceApplications(ListDataServiceApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceApplicationsResponse>(DoRequest("ListDataServiceApplications", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServiceApplicationsResponse> ListDataServiceApplicationsAsync(ListDataServiceApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceApplicationsResponse>(await DoRequestAsync("ListDataServiceApplications", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServiceApplicationsResponse ListDataServiceApplicationsSimply(ListDataServiceApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceApplications(request, runtime);
        }

        public async Task<ListDataServiceApplicationsResponse> ListDataServiceApplicationsSimplyAsync(ListDataServiceApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceApplicationsAsync(request, runtime);
        }

        public GetNodeOnBaselineResponse GetNodeOnBaseline(GetNodeOnBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeOnBaselineResponse>(DoRequest("GetNodeOnBaseline", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodeOnBaselineResponse> GetNodeOnBaselineAsync(GetNodeOnBaselineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeOnBaselineResponse>(await DoRequestAsync("GetNodeOnBaseline", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetNodeOnBaselineResponse GetNodeOnBaselineSimply(GetNodeOnBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeOnBaseline(request, runtime);
        }

        public async Task<GetNodeOnBaselineResponse> GetNodeOnBaselineSimplyAsync(GetNodeOnBaselineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeOnBaselineAsync(request, runtime);
        }

        public ListBaselineConfigsResponse ListBaselineConfigs(ListBaselineConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBaselineConfigsResponse>(DoRequest("ListBaselineConfigs", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListBaselineConfigsResponse> ListBaselineConfigsAsync(ListBaselineConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBaselineConfigsResponse>(await DoRequestAsync("ListBaselineConfigs", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListBaselineConfigsResponse ListBaselineConfigsSimply(ListBaselineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaselineConfigs(request, runtime);
        }

        public async Task<ListBaselineConfigsResponse> ListBaselineConfigsSimplyAsync(ListBaselineConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaselineConfigsAsync(request, runtime);
        }

        public GetMetaTableChangeLogResponse GetMetaTableChangeLog(GetMetaTableChangeLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableChangeLogResponse>(DoRequest("GetMetaTableChangeLog", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaTableChangeLogResponse> GetMetaTableChangeLogAsync(GetMetaTableChangeLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableChangeLogResponse>(await DoRequestAsync("GetMetaTableChangeLog", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaTableChangeLogResponse GetMetaTableChangeLogSimply(GetMetaTableChangeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableChangeLog(request, runtime);
        }

        public async Task<GetMetaTableChangeLogResponse> GetMetaTableChangeLogSimplyAsync(GetMetaTableChangeLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableChangeLogAsync(request, runtime);
        }

        public GetMetaTableOutputResponse GetMetaTableOutput(GetMetaTableOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableOutputResponse>(DoRequest("GetMetaTableOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaTableOutputResponse> GetMetaTableOutputAsync(GetMetaTableOutputRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableOutputResponse>(await DoRequestAsync("GetMetaTableOutput", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaTableOutputResponse GetMetaTableOutputSimply(GetMetaTableOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableOutput(request, runtime);
        }

        public async Task<GetMetaTableOutputResponse> GetMetaTableOutputSimplyAsync(GetMetaTableOutputRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableOutputAsync(request, runtime);
        }

        public GetMetaTablePartitionResponse GetMetaTablePartition(GetMetaTablePartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTablePartitionResponse>(DoRequest("GetMetaTablePartition", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaTablePartitionResponse> GetMetaTablePartitionAsync(GetMetaTablePartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTablePartitionResponse>(await DoRequestAsync("GetMetaTablePartition", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaTablePartitionResponse GetMetaTablePartitionSimply(GetMetaTablePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTablePartition(request, runtime);
        }

        public async Task<GetMetaTablePartitionResponse> GetMetaTablePartitionSimplyAsync(GetMetaTablePartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTablePartitionAsync(request, runtime);
        }

        public GetMetaTableFullInfoResponse GetMetaTableFullInfo(GetMetaTableFullInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableFullInfoResponse>(DoRequest("GetMetaTableFullInfo", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetMetaTableFullInfoResponse> GetMetaTableFullInfoAsync(GetMetaTableFullInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableFullInfoResponse>(await DoRequestAsync("GetMetaTableFullInfo", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetMetaTableFullInfoResponse GetMetaTableFullInfoSimply(GetMetaTableFullInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableFullInfo(request, runtime);
        }

        public async Task<GetMetaTableFullInfoResponse> GetMetaTableFullInfoSimplyAsync(GetMetaTableFullInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableFullInfoAsync(request, runtime);
        }

        public GetFileVersionResponse GetFileVersion(GetFileVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFileVersionResponse>(DoRequest("GetFileVersion", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFileVersionResponse> GetFileVersionAsync(GetFileVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFileVersionResponse>(await DoRequestAsync("GetFileVersion", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetFileVersionResponse GetFileVersionSimply(GetFileVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFileVersion(request, runtime);
        }

        public async Task<GetFileVersionResponse> GetFileVersionSimplyAsync(GetFileVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileVersionAsync(request, runtime);
        }

        public GetMetaTableBasicInfoResponse GetMetaTableBasicInfo(GetMetaTableBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableBasicInfoResponse>(DoRequest("GetMetaTableBasicInfo", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetMetaTableBasicInfoResponse> GetMetaTableBasicInfoAsync(GetMetaTableBasicInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableBasicInfoResponse>(await DoRequestAsync("GetMetaTableBasicInfo", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetMetaTableBasicInfoResponse GetMetaTableBasicInfoSimply(GetMetaTableBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableBasicInfo(request, runtime);
        }

        public async Task<GetMetaTableBasicInfoResponse> GetMetaTableBasicInfoSimplyAsync(GetMetaTableBasicInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableBasicInfoAsync(request, runtime);
        }

        public GetMetaTableColumnResponse GetMetaTableColumn(GetMetaTableColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableColumnResponse>(DoRequest("GetMetaTableColumn", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetMetaTableColumnResponse> GetMetaTableColumnAsync(GetMetaTableColumnRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableColumnResponse>(await DoRequestAsync("GetMetaTableColumn", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetMetaTableColumnResponse GetMetaTableColumnSimply(GetMetaTableColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableColumn(request, runtime);
        }

        public async Task<GetMetaTableColumnResponse> GetMetaTableColumnSimplyAsync(GetMetaTableColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableColumnAsync(request, runtime);
        }

        public GetMetaDBInfoResponse GetMetaDBInfo(GetMetaDBInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaDBInfoResponse>(DoRequest("GetMetaDBInfo", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetMetaDBInfoResponse> GetMetaDBInfoAsync(GetMetaDBInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaDBInfoResponse>(await DoRequestAsync("GetMetaDBInfo", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetMetaDBInfoResponse GetMetaDBInfoSimply(GetMetaDBInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaDBInfo(request, runtime);
        }

        public async Task<GetMetaDBInfoResponse> GetMetaDBInfoSimplyAsync(GetMetaDBInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaDBInfoAsync(request, runtime);
        }

        public GetMetaCategoryResponse GetMetaCategory(GetMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaCategoryResponse>(DoRequest("GetMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaCategoryResponse> GetMetaCategoryAsync(GetMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaCategoryResponse>(await DoRequestAsync("GetMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaCategoryResponse GetMetaCategorySimply(GetMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaCategory(request, runtime);
        }

        public async Task<GetMetaCategoryResponse> GetMetaCategorySimplyAsync(GetMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaCategoryAsync(request, runtime);
        }

        public ListAlertMessagesResponse ListAlertMessages(ListAlertMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAlertMessagesResponse>(DoRequest("ListAlertMessages", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAlertMessagesResponse> ListAlertMessagesAsync(ListAlertMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAlertMessagesResponse>(await DoRequestAsync("ListAlertMessages", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListAlertMessagesResponse ListAlertMessagesSimply(ListAlertMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlertMessages(request, runtime);
        }

        public async Task<ListAlertMessagesResponse> ListAlertMessagesSimplyAsync(ListAlertMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlertMessagesAsync(request, runtime);
        }

        public GetBaselineConfigResponse GetBaselineConfig(GetBaselineConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBaselineConfigResponse>(DoRequest("GetBaselineConfig", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetBaselineConfigResponse> GetBaselineConfigAsync(GetBaselineConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBaselineConfigResponse>(await DoRequestAsync("GetBaselineConfig", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetBaselineConfigResponse GetBaselineConfigSimply(GetBaselineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineConfig(request, runtime);
        }

        public async Task<GetBaselineConfigResponse> GetBaselineConfigSimplyAsync(GetBaselineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineConfigAsync(request, runtime);
        }

        public SearchMetaTablesResponse SearchMetaTables(SearchMetaTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SearchMetaTablesResponse>(DoRequest("SearchMetaTables", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SearchMetaTablesResponse> SearchMetaTablesAsync(SearchMetaTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SearchMetaTablesResponse>(await DoRequestAsync("SearchMetaTables", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public SearchMetaTablesResponse SearchMetaTablesSimply(SearchMetaTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchMetaTables(request, runtime);
        }

        public async Task<SearchMetaTablesResponse> SearchMetaTablesSimplyAsync(SearchMetaTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchMetaTablesAsync(request, runtime);
        }

        public GetMetaTableListByCategoryResponse GetMetaTableListByCategory(GetMetaTableListByCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableListByCategoryResponse>(DoRequest("GetMetaTableListByCategory", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetMetaTableListByCategoryResponse> GetMetaTableListByCategoryAsync(GetMetaTableListByCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableListByCategoryResponse>(await DoRequestAsync("GetMetaTableListByCategory", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public GetMetaTableListByCategoryResponse GetMetaTableListByCategorySimply(GetMetaTableListByCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableListByCategory(request, runtime);
        }

        public async Task<GetMetaTableListByCategoryResponse> GetMetaTableListByCategorySimplyAsync(GetMetaTableListByCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableListByCategoryAsync(request, runtime);
        }

        public DeleteMetaCategoryResponse DeleteMetaCategory(DeleteMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteMetaCategoryResponse>(DoRequest("DeleteMetaCategory", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DeleteMetaCategoryResponse> DeleteMetaCategoryAsync(DeleteMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteMetaCategoryResponse>(await DoRequestAsync("DeleteMetaCategory", "HTTPS", "GET", "2020-05-18", "AK", request.ToMap(), null, runtime));
        }

        public DeleteMetaCategoryResponse DeleteMetaCategorySimply(DeleteMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMetaCategory(request, runtime);
        }

        public async Task<DeleteMetaCategoryResponse> DeleteMetaCategorySimplyAsync(DeleteMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMetaCategoryAsync(request, runtime);
        }

        public UpdateMetaCategoryResponse UpdateMetaCategory(UpdateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMetaCategoryResponse>(DoRequest("UpdateMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateMetaCategoryResponse> UpdateMetaCategoryAsync(UpdateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMetaCategoryResponse>(await DoRequestAsync("UpdateMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateMetaCategoryResponse UpdateMetaCategorySimply(UpdateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMetaCategory(request, runtime);
        }

        public async Task<UpdateMetaCategoryResponse> UpdateMetaCategorySimplyAsync(UpdateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMetaCategoryAsync(request, runtime);
        }

        public ListTopicsResponse ListTopics(ListTopicsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTopicsResponse>(DoRequest("ListTopics", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListTopicsResponse>(await DoRequestAsync("ListTopics", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListTopicsResponse ListTopicsSimply(ListTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopics(request, runtime);
        }

        public async Task<ListTopicsResponse> ListTopicsSimplyAsync(ListTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicsAsync(request, runtime);
        }

        public ListFileVersionsResponse ListFileVersions(ListFileVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFileVersionsResponse>(DoRequest("ListFileVersions", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFileVersionsResponse> ListFileVersionsAsync(ListFileVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFileVersionsResponse>(await DoRequestAsync("ListFileVersions", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListFileVersionsResponse ListFileVersionsSimply(ListFileVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFileVersions(request, runtime);
        }

        public async Task<ListFileVersionsResponse> ListFileVersionsSimplyAsync(ListFileVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFileVersionsAsync(request, runtime);
        }

        public CreateMetaCategoryResponse CreateMetaCategory(CreateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateMetaCategoryResponse>(DoRequest("CreateMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateMetaCategoryResponse> CreateMetaCategoryAsync(CreateMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateMetaCategoryResponse>(await DoRequestAsync("CreateMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateMetaCategoryResponse CreateMetaCategorySimply(CreateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMetaCategory(request, runtime);
        }

        public async Task<CreateMetaCategoryResponse> CreateMetaCategorySimplyAsync(CreateMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMetaCategoryAsync(request, runtime);
        }

        public ListNodeIOResponse ListNodeIO(ListNodeIORequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodeIOResponse>(DoRequest("ListNodeIO", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListNodeIOResponse> ListNodeIOAsync(ListNodeIORequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodeIOResponse>(await DoRequestAsync("ListNodeIO", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListNodeIOResponse ListNodeIOSimply(ListNodeIORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeIO(request, runtime);
        }

        public async Task<ListNodeIOResponse> ListNodeIOSimplyAsync(ListNodeIORequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeIOAsync(request, runtime);
        }

        public GetTopicInfluenceResponse GetTopicInfluence(GetTopicInfluenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTopicInfluenceResponse>(DoRequest("GetTopicInfluence", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTopicInfluenceResponse> GetTopicInfluenceAsync(GetTopicInfluenceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTopicInfluenceResponse>(await DoRequestAsync("GetTopicInfluence", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetTopicInfluenceResponse GetTopicInfluenceSimply(GetTopicInfluenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicInfluence(request, runtime);
        }

        public async Task<GetTopicInfluenceResponse> GetTopicInfluenceSimplyAsync(GetTopicInfluenceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicInfluenceAsync(request, runtime);
        }

        public GetTopicResponse GetTopic(GetTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTopicResponse>(DoRequest("GetTopic", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTopicResponse> GetTopicAsync(GetTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTopicResponse>(await DoRequestAsync("GetTopic", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetTopicResponse GetTopicSimply(GetTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopic(request, runtime);
        }

        public async Task<GetTopicResponse> GetTopicSimplyAsync(GetTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicAsync(request, runtime);
        }

        public DeleteFromMetaCategoryResponse DeleteFromMetaCategory(DeleteFromMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFromMetaCategoryResponse>(DoRequest("DeleteFromMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteFromMetaCategoryResponse> DeleteFromMetaCategoryAsync(DeleteFromMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFromMetaCategoryResponse>(await DoRequestAsync("DeleteFromMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteFromMetaCategoryResponse DeleteFromMetaCategorySimply(DeleteFromMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFromMetaCategory(request, runtime);
        }

        public async Task<DeleteFromMetaCategoryResponse> DeleteFromMetaCategorySimplyAsync(DeleteFromMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFromMetaCategoryAsync(request, runtime);
        }

        public GetNodeResponse GetNode(GetNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeResponse>(DoRequest("GetNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodeResponse> GetNodeAsync(GetNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeResponse>(await DoRequestAsync("GetNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetNodeResponse GetNodeSimply(GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNode(request, runtime);
        }

        public async Task<GetNodeResponse> GetNodeSimplyAsync(GetNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeAsync(request, runtime);
        }

        public ListNodesResponse ListNodes(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodesResponse>(DoRequest("ListNodes", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListNodesResponse>(await DoRequestAsync("ListNodes", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListNodesResponse ListNodesSimply(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodes(request, runtime);
        }

        public async Task<ListNodesResponse> ListNodesSimplyAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesAsync(request, runtime);
        }

        public GetNodeCodeResponse GetNodeCode(GetNodeCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeCodeResponse>(DoRequest("GetNodeCode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodeCodeResponse> GetNodeCodeAsync(GetNodeCodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodeCodeResponse>(await DoRequestAsync("GetNodeCode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetNodeCodeResponse GetNodeCodeSimply(GetNodeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeCode(request, runtime);
        }

        public async Task<GetNodeCodeResponse> GetNodeCodeSimplyAsync(GetNodeCodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeCodeAsync(request, runtime);
        }

        public EstablishRelationTableToBusinessResponse EstablishRelationTableToBusiness(EstablishRelationTableToBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EstablishRelationTableToBusinessResponse>(DoRequest("EstablishRelationTableToBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EstablishRelationTableToBusinessResponse> EstablishRelationTableToBusinessAsync(EstablishRelationTableToBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EstablishRelationTableToBusinessResponse>(await DoRequestAsync("EstablishRelationTableToBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public EstablishRelationTableToBusinessResponse EstablishRelationTableToBusinessSimply(EstablishRelationTableToBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EstablishRelationTableToBusiness(request, runtime);
        }

        public async Task<EstablishRelationTableToBusinessResponse> EstablishRelationTableToBusinessSimplyAsync(EstablishRelationTableToBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EstablishRelationTableToBusinessAsync(request, runtime);
        }

        public UpdateDataServiceApiResponse UpdateDataServiceApi(UpdateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDataServiceApiResponse>(DoRequest("UpdateDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDataServiceApiResponse> UpdateDataServiceApiAsync(UpdateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDataServiceApiResponse>(await DoRequestAsync("UpdateDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDataServiceApiResponse UpdateDataServiceApiSimply(UpdateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataServiceApi(request, runtime);
        }

        public async Task<UpdateDataServiceApiResponse> UpdateDataServiceApiSimplyAsync(UpdateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataServiceApiAsync(request, runtime);
        }

        public UpdateUdfFileResponse UpdateUdfFile(UpdateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateUdfFileResponse>(DoRequest("UpdateUdfFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateUdfFileResponse> UpdateUdfFileAsync(UpdateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateUdfFileResponse>(await DoRequestAsync("UpdateUdfFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateUdfFileResponse UpdateUdfFileSimply(UpdateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUdfFile(request, runtime);
        }

        public async Task<UpdateUdfFileResponse> UpdateUdfFileSimplyAsync(UpdateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUdfFileAsync(request, runtime);
        }

        public CreateUdfFileResponse CreateUdfFile(CreateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateUdfFileResponse>(DoRequest("CreateUdfFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateUdfFileResponse> CreateUdfFileAsync(CreateUdfFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateUdfFileResponse>(await DoRequestAsync("CreateUdfFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateUdfFileResponse CreateUdfFileSimply(CreateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUdfFile(request, runtime);
        }

        public async Task<CreateUdfFileResponse> CreateUdfFileSimplyAsync(CreateUdfFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUdfFileAsync(request, runtime);
        }

        public ListFilesResponse ListFiles(ListFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFilesResponse>(DoRequest("ListFiles", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFilesResponse> ListFilesAsync(ListFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFilesResponse>(await DoRequestAsync("ListFiles", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListFilesResponse ListFilesSimply(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFiles(request, runtime);
        }

        public async Task<ListFilesResponse> ListFilesSimplyAsync(ListFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFilesAsync(request, runtime);
        }

        public ListDataServiceAuthorizedApisResponse ListDataServiceAuthorizedApis(ListDataServiceAuthorizedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceAuthorizedApisResponse>(DoRequest("ListDataServiceAuthorizedApis", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServiceAuthorizedApisResponse> ListDataServiceAuthorizedApisAsync(ListDataServiceAuthorizedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceAuthorizedApisResponse>(await DoRequestAsync("ListDataServiceAuthorizedApis", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServiceAuthorizedApisResponse ListDataServiceAuthorizedApisSimply(ListDataServiceAuthorizedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceAuthorizedApis(request, runtime);
        }

        public async Task<ListDataServiceAuthorizedApisResponse> ListDataServiceAuthorizedApisSimplyAsync(ListDataServiceAuthorizedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceAuthorizedApisAsync(request, runtime);
        }

        public UpdateFileResponse UpdateFile(UpdateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFileResponse>(DoRequest("UpdateFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateFileResponse> UpdateFileAsync(UpdateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFileResponse>(await DoRequestAsync("UpdateFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateFileResponse UpdateFileSimply(UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFile(request, runtime);
        }

        public async Task<UpdateFileResponse> UpdateFileSimplyAsync(UpdateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFileAsync(request, runtime);
        }

        public DeleteFolderResponse DeleteFolder(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFolderResponse>(DoRequest("DeleteFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteFolderResponse> DeleteFolderAsync(DeleteFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFolderResponse>(await DoRequestAsync("DeleteFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteFolderResponse DeleteFolderSimply(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFolder(request, runtime);
        }

        public async Task<DeleteFolderResponse> DeleteFolderSimplyAsync(DeleteFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFolderAsync(request, runtime);
        }

        public ListFoldersResponse ListFolders(ListFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFoldersResponse>(DoRequest("ListFolders", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListFoldersResponse> ListFoldersAsync(ListFoldersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListFoldersResponse>(await DoRequestAsync("ListFolders", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListFoldersResponse ListFoldersSimply(ListFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListFolders(request, runtime);
        }

        public async Task<ListFoldersResponse> ListFoldersSimplyAsync(ListFoldersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListFoldersAsync(request, runtime);
        }

        public CheckMetaPartitionResponse CheckMetaPartition(CheckMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckMetaPartitionResponse>(DoRequest("CheckMetaPartition", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckMetaPartitionResponse> CheckMetaPartitionAsync(CheckMetaPartitionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckMetaPartitionResponse>(await DoRequestAsync("CheckMetaPartition", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CheckMetaPartitionResponse CheckMetaPartitionSimply(CheckMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMetaPartition(request, runtime);
        }

        public async Task<CheckMetaPartitionResponse> CheckMetaPartitionSimplyAsync(CheckMetaPartitionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMetaPartitionAsync(request, runtime);
        }

        public UpdateFolderResponse UpdateFolder(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFolderResponse>(DoRequest("UpdateFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateFolderResponse> UpdateFolderAsync(UpdateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateFolderResponse>(await DoRequestAsync("UpdateFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateFolderResponse UpdateFolderSimply(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateFolder(request, runtime);
        }

        public async Task<UpdateFolderResponse> UpdateFolderSimplyAsync(UpdateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateFolderAsync(request, runtime);
        }

        public DeleteRemindResponse DeleteRemind(DeleteRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRemindResponse>(DoRequest("DeleteRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRemindResponse> DeleteRemindAsync(DeleteRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRemindResponse>(await DoRequestAsync("DeleteRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRemindResponse DeleteRemindSimply(DeleteRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRemind(request, runtime);
        }

        public async Task<DeleteRemindResponse> DeleteRemindSimplyAsync(DeleteRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRemindAsync(request, runtime);
        }

        public AddToMetaCategoryResponse AddToMetaCategory(AddToMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddToMetaCategoryResponse>(DoRequest("AddToMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddToMetaCategoryResponse> AddToMetaCategoryAsync(AddToMetaCategoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddToMetaCategoryResponse>(await DoRequestAsync("AddToMetaCategory", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public AddToMetaCategoryResponse AddToMetaCategorySimply(AddToMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddToMetaCategory(request, runtime);
        }

        public async Task<AddToMetaCategoryResponse> AddToMetaCategorySimplyAsync(AddToMetaCategoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddToMetaCategoryAsync(request, runtime);
        }

        public ListInstancesResponse ListInstances(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListInstancesResponse>(DoRequest("ListInstances", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListInstancesResponse>(await DoRequestAsync("ListInstances", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListInstancesResponse ListInstancesSimply(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstances(request, runtime);
        }

        public async Task<ListInstancesResponse> ListInstancesSimplyAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesAsync(request, runtime);
        }

        public SetSuccessInstanceResponse SetSuccessInstance(SetSuccessInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetSuccessInstanceResponse>(DoRequest("SetSuccessInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetSuccessInstanceResponse> SetSuccessInstanceAsync(SetSuccessInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetSuccessInstanceResponse>(await DoRequestAsync("SetSuccessInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public SetSuccessInstanceResponse SetSuccessInstanceSimply(SetSuccessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSuccessInstance(request, runtime);
        }

        public async Task<SetSuccessInstanceResponse> SetSuccessInstanceSimplyAsync(SetSuccessInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSuccessInstanceAsync(request, runtime);
        }

        public CreateFileResponse CreateFile(CreateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFileResponse>(DoRequest("CreateFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateFileResponse> CreateFileAsync(CreateFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFileResponse>(await DoRequestAsync("CreateFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateFileResponse CreateFileSimply(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFile(request, runtime);
        }

        public async Task<CreateFileResponse> CreateFileSimplyAsync(CreateFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFileAsync(request, runtime);
        }

        public StopInstanceResponse StopInstance(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInstanceResponse>(DoRequest("StopInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopInstanceResponse>(await DoRequestAsync("StopInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public StopInstanceResponse StopInstanceSimply(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstance(request, runtime);
        }

        public async Task<StopInstanceResponse> StopInstanceSimplyAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceAsync(request, runtime);
        }

        public ResumeInstanceResponse ResumeInstance(ResumeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResumeInstanceResponse>(DoRequest("ResumeInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResumeInstanceResponse> ResumeInstanceAsync(ResumeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResumeInstanceResponse>(await DoRequestAsync("ResumeInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ResumeInstanceResponse ResumeInstanceSimply(ResumeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeInstance(request, runtime);
        }

        public async Task<ResumeInstanceResponse> ResumeInstanceSimplyAsync(ResumeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeInstanceAsync(request, runtime);
        }

        public SuspendInstanceResponse SuspendInstance(SuspendInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SuspendInstanceResponse>(DoRequest("SuspendInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SuspendInstanceResponse> SuspendInstanceAsync(SuspendInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SuspendInstanceResponse>(await DoRequestAsync("SuspendInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public SuspendInstanceResponse SuspendInstanceSimply(SuspendInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SuspendInstance(request, runtime);
        }

        public async Task<SuspendInstanceResponse> SuspendInstanceSimplyAsync(SuspendInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SuspendInstanceAsync(request, runtime);
        }

        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RestartInstanceResponse>(DoRequest("RestartInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RestartInstanceResponse>(await DoRequestAsync("RestartInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public RestartInstanceResponse RestartInstanceSimply(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartInstance(request, runtime);
        }

        public async Task<RestartInstanceResponse> RestartInstanceSimplyAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartInstanceAsync(request, runtime);
        }

        public ListDataServiceApiAuthoritiesResponse ListDataServiceApiAuthorities(ListDataServiceApiAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceApiAuthoritiesResponse>(DoRequest("ListDataServiceApiAuthorities", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServiceApiAuthoritiesResponse> ListDataServiceApiAuthoritiesAsync(ListDataServiceApiAuthoritiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceApiAuthoritiesResponse>(await DoRequestAsync("ListDataServiceApiAuthorities", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServiceApiAuthoritiesResponse ListDataServiceApiAuthoritiesSimply(ListDataServiceApiAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceApiAuthorities(request, runtime);
        }

        public async Task<ListDataServiceApiAuthoritiesResponse> ListDataServiceApiAuthoritiesSimplyAsync(ListDataServiceApiAuthoritiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceApiAuthoritiesAsync(request, runtime);
        }

        public ListDataServicePublishedApisResponse ListDataServicePublishedApis(ListDataServicePublishedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServicePublishedApisResponse>(DoRequest("ListDataServicePublishedApis", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServicePublishedApisResponse> ListDataServicePublishedApisAsync(ListDataServicePublishedApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServicePublishedApisResponse>(await DoRequestAsync("ListDataServicePublishedApis", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServicePublishedApisResponse ListDataServicePublishedApisSimply(ListDataServicePublishedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServicePublishedApis(request, runtime);
        }

        public async Task<ListDataServicePublishedApisResponse> ListDataServicePublishedApisSimplyAsync(ListDataServicePublishedApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServicePublishedApisAsync(request, runtime);
        }

        public GetInstanceLogResponse GetInstanceLog(GetInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceLogResponse>(DoRequest("GetInstanceLog", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceLogResponse> GetInstanceLogAsync(GetInstanceLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceLogResponse>(await DoRequestAsync("GetInstanceLog", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceLogResponse GetInstanceLogSimply(GetInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceLog(request, runtime);
        }

        public async Task<GetInstanceLogResponse> GetInstanceLogSimplyAsync(GetInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceLogAsync(request, runtime);
        }

        public CreateFolderResponse CreateFolder(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFolderResponse>(DoRequest("CreateFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateFolderResponse> CreateFolderAsync(CreateFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateFolderResponse>(await DoRequestAsync("CreateFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateFolderResponse CreateFolderSimply(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateFolder(request, runtime);
        }

        public async Task<CreateFolderResponse> CreateFolderSimplyAsync(CreateFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateFolderAsync(request, runtime);
        }

        public GetBusinessResponse GetBusiness(GetBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBusinessResponse>(DoRequest("GetBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetBusinessResponse> GetBusinessAsync(GetBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBusinessResponse>(await DoRequestAsync("GetBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetBusinessResponse GetBusinessSimply(GetBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBusiness(request, runtime);
        }

        public async Task<GetBusinessResponse> GetBusinessSimplyAsync(GetBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBusinessAsync(request, runtime);
        }

        public GetInstanceResponse GetInstance(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceResponse>(DoRequest("GetInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetInstanceResponse>(await DoRequestAsync("GetInstance", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetInstanceResponse GetInstanceSimply(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstance(request, runtime);
        }

        public async Task<GetInstanceResponse> GetInstanceSimplyAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceAsync(request, runtime);
        }

        public GetFileResponse GetFile(GetFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFileResponse>(DoRequest("GetFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFileResponse> GetFileAsync(GetFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFileResponse>(await DoRequestAsync("GetFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetFileResponse GetFileSimply(GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFile(request, runtime);
        }

        public async Task<GetFileResponse> GetFileSimplyAsync(GetFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFileAsync(request, runtime);
        }

        public ListBusinessResponse ListBusiness(ListBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBusinessResponse>(DoRequest("ListBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListBusinessResponse> ListBusinessAsync(ListBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBusinessResponse>(await DoRequestAsync("ListBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListBusinessResponse ListBusinessSimply(ListBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBusiness(request, runtime);
        }

        public async Task<ListBusinessResponse> ListBusinessSimplyAsync(ListBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBusinessAsync(request, runtime);
        }

        public GetMetaDBTableListResponse GetMetaDBTableList(GetMetaDBTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaDBTableListResponse>(DoRequest("GetMetaDBTableList", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaDBTableListResponse> GetMetaDBTableListAsync(GetMetaDBTableListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaDBTableListResponse>(await DoRequestAsync("GetMetaDBTableList", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaDBTableListResponse GetMetaDBTableListSimply(GetMetaDBTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaDBTableList(request, runtime);
        }

        public async Task<GetMetaDBTableListResponse> GetMetaDBTableListSimplyAsync(GetMetaDBTableListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaDBTableListAsync(request, runtime);
        }

        public CheckMetaTableResponse CheckMetaTable(CheckMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckMetaTableResponse>(DoRequest("CheckMetaTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CheckMetaTableResponse> CheckMetaTableAsync(CheckMetaTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CheckMetaTableResponse>(await DoRequestAsync("CheckMetaTable", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CheckMetaTableResponse CheckMetaTableSimply(CheckMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckMetaTable(request, runtime);
        }

        public async Task<CheckMetaTableResponse> CheckMetaTableSimplyAsync(CheckMetaTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckMetaTableAsync(request, runtime);
        }

        public GetFolderResponse GetFolder(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFolderResponse>(DoRequest("GetFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetFolderResponse>(await DoRequestAsync("GetFolder", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetFolderResponse GetFolderSimply(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetFolder(request, runtime);
        }

        public async Task<GetFolderResponse> GetFolderSimplyAsync(GetFolderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetFolderAsync(request, runtime);
        }

        public DeployFileResponse DeployFile(DeployFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeployFileResponse>(DoRequest("DeployFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeployFileResponse> DeployFileAsync(DeployFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeployFileResponse>(await DoRequestAsync("DeployFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeployFileResponse DeployFileSimply(DeployFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployFile(request, runtime);
        }

        public async Task<DeployFileResponse> DeployFileSimplyAsync(DeployFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployFileAsync(request, runtime);
        }

        public DeleteBusinessResponse DeleteBusiness(DeleteBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBusinessResponse>(DoRequest("DeleteBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteBusinessResponse> DeleteBusinessAsync(DeleteBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBusinessResponse>(await DoRequestAsync("DeleteBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteBusinessResponse DeleteBusinessSimply(DeleteBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBusiness(request, runtime);
        }

        public async Task<DeleteBusinessResponse> DeleteBusinessSimplyAsync(DeleteBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBusinessAsync(request, runtime);
        }

        public DeleteFileResponse DeleteFile(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFileResponse>(DoRequest("DeleteFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteFileResponse>(await DoRequestAsync("DeleteFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteFileResponse DeleteFileSimply(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFile(request, runtime);
        }

        public async Task<DeleteFileResponse> DeleteFileSimplyAsync(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileAsync(request, runtime);
        }

        public ListQualityRulesResponse ListQualityRules(ListQualityRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListQualityRulesResponse>(DoRequest("ListQualityRules", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListQualityRulesResponse> ListQualityRulesAsync(ListQualityRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListQualityRulesResponse>(await DoRequestAsync("ListQualityRules", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListQualityRulesResponse ListQualityRulesSimply(ListQualityRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQualityRules(request, runtime);
        }

        public async Task<ListQualityRulesResponse> ListQualityRulesSimplyAsync(ListQualityRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQualityRulesAsync(request, runtime);
        }

        public CreateRemindResponse CreateRemind(CreateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRemindResponse>(DoRequest("CreateRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRemindResponse> CreateRemindAsync(CreateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRemindResponse>(await DoRequestAsync("CreateRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateRemindResponse CreateRemindSimply(CreateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRemind(request, runtime);
        }

        public async Task<CreateRemindResponse> CreateRemindSimplyAsync(CreateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRemindAsync(request, runtime);
        }

        public GetQualityRuleResponse GetQualityRule(GetQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetQualityRuleResponse>(DoRequest("GetQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetQualityRuleResponse> GetQualityRuleAsync(GetQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetQualityRuleResponse>(await DoRequestAsync("GetQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetQualityRuleResponse GetQualityRuleSimply(GetQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityRule(request, runtime);
        }

        public async Task<GetQualityRuleResponse> GetQualityRuleSimplyAsync(GetQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityRuleAsync(request, runtime);
        }

        public GetDeploymentResponse GetDeployment(GetDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeploymentResponse>(DoRequest("GetDeployment", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeploymentResponse>(await DoRequestAsync("GetDeployment", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDeploymentResponse GetDeploymentSimply(GetDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeployment(request, runtime);
        }

        public async Task<GetDeploymentResponse> GetDeploymentSimplyAsync(GetDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeploymentAsync(request, runtime);
        }

        public UpdateRemindResponse UpdateRemind(UpdateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRemindResponse>(DoRequest("UpdateRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateRemindResponse> UpdateRemindAsync(UpdateRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRemindResponse>(await DoRequestAsync("UpdateRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateRemindResponse UpdateRemindSimply(UpdateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRemind(request, runtime);
        }

        public async Task<UpdateRemindResponse> UpdateRemindSimplyAsync(UpdateRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRemindAsync(request, runtime);
        }

        public GetMetaColumnLineageResponse GetMetaColumnLineage(GetMetaColumnLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaColumnLineageResponse>(DoRequest("GetMetaColumnLineage", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaColumnLineageResponse> GetMetaColumnLineageAsync(GetMetaColumnLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaColumnLineageResponse>(await DoRequestAsync("GetMetaColumnLineage", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaColumnLineageResponse GetMetaColumnLineageSimply(GetMetaColumnLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaColumnLineage(request, runtime);
        }

        public async Task<GetMetaColumnLineageResponse> GetMetaColumnLineageSimplyAsync(GetMetaColumnLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaColumnLineageAsync(request, runtime);
        }

        public UpdateBusinessResponse UpdateBusiness(UpdateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateBusinessResponse>(DoRequest("UpdateBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateBusinessResponse> UpdateBusinessAsync(UpdateBusinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateBusinessResponse>(await DoRequestAsync("UpdateBusiness", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateBusinessResponse UpdateBusinessSimply(UpdateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBusiness(request, runtime);
        }

        public async Task<UpdateBusinessResponse> UpdateBusinessSimplyAsync(UpdateBusinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBusinessAsync(request, runtime);
        }

        public UpdateQualityRuleResponse UpdateQualityRule(UpdateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateQualityRuleResponse>(DoRequest("UpdateQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateQualityRuleResponse> UpdateQualityRuleAsync(UpdateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateQualityRuleResponse>(await DoRequestAsync("UpdateQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateQualityRuleResponse UpdateQualityRuleSimply(UpdateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityRule(request, runtime);
        }

        public async Task<UpdateQualityRuleResponse> UpdateQualityRuleSimplyAsync(UpdateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityRuleAsync(request, runtime);
        }

        public DeleteQualityRuleResponse DeleteQualityRule(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityRuleResponse>(DoRequest("DeleteQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleAsync(DeleteQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityRuleResponse>(await DoRequestAsync("DeleteQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteQualityRuleResponse DeleteQualityRuleSimply(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityRule(request, runtime);
        }

        public async Task<DeleteQualityRuleResponse> DeleteQualityRuleSimplyAsync(DeleteQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityRuleAsync(request, runtime);
        }

        public SubmitFileResponse SubmitFile(SubmitFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubmitFileResponse>(DoRequest("SubmitFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SubmitFileResponse> SubmitFileAsync(SubmitFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubmitFileResponse>(await DoRequestAsync("SubmitFile", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public SubmitFileResponse SubmitFileSimply(SubmitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitFile(request, runtime);
        }

        public async Task<SubmitFileResponse> SubmitFileSimplyAsync(SubmitFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitFileAsync(request, runtime);
        }

        public GetDataServiceApiResponse GetDataServiceApi(GetDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceApiResponse>(DoRequest("GetDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataServiceApiResponse> GetDataServiceApiAsync(GetDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServiceApiResponse>(await DoRequestAsync("GetDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDataServiceApiResponse GetDataServiceApiSimply(GetDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceApi(request, runtime);
        }

        public async Task<GetDataServiceApiResponse> GetDataServiceApiSimplyAsync(GetDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceApiAsync(request, runtime);
        }

        public ListDataServiceApisResponse ListDataServiceApis(ListDataServiceApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceApisResponse>(DoRequest("ListDataServiceApis", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDataServiceApisResponse> ListDataServiceApisAsync(ListDataServiceApisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDataServiceApisResponse>(await DoRequestAsync("ListDataServiceApis", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListDataServiceApisResponse ListDataServiceApisSimply(ListDataServiceApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataServiceApis(request, runtime);
        }

        public async Task<ListDataServiceApisResponse> ListDataServiceApisSimplyAsync(ListDataServiceApisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataServiceApisAsync(request, runtime);
        }

        public GetDataServicePublishedApiResponse GetDataServicePublishedApi(GetDataServicePublishedApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServicePublishedApiResponse>(DoRequest("GetDataServicePublishedApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataServicePublishedApiResponse> GetDataServicePublishedApiAsync(GetDataServicePublishedApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataServicePublishedApiResponse>(await DoRequestAsync("GetDataServicePublishedApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetDataServicePublishedApiResponse GetDataServicePublishedApiSimply(GetDataServicePublishedApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServicePublishedApi(request, runtime);
        }

        public async Task<GetDataServicePublishedApiResponse> GetDataServicePublishedApiSimplyAsync(GetDataServicePublishedApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServicePublishedApiAsync(request, runtime);
        }

        public GetBaselineKeyPathResponse GetBaselineKeyPath(GetBaselineKeyPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBaselineKeyPathResponse>(DoRequest("GetBaselineKeyPath", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetBaselineKeyPathResponse> GetBaselineKeyPathAsync(GetBaselineKeyPathRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBaselineKeyPathResponse>(await DoRequestAsync("GetBaselineKeyPath", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetBaselineKeyPathResponse GetBaselineKeyPathSimply(GetBaselineKeyPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineKeyPath(request, runtime);
        }

        public async Task<GetBaselineKeyPathResponse> GetBaselineKeyPathSimplyAsync(GetBaselineKeyPathRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineKeyPathAsync(request, runtime);
        }

        public GetRemindResponse GetRemind(GetRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRemindResponse>(DoRequest("GetRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetRemindResponse> GetRemindAsync(GetRemindRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRemindResponse>(await DoRequestAsync("GetRemind", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetRemindResponse GetRemindSimply(GetRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRemind(request, runtime);
        }

        public async Task<GetRemindResponse> GetRemindSimplyAsync(GetRemindRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRemindAsync(request, runtime);
        }

        public GetMetaTableIntroWikiResponse GetMetaTableIntroWiki(GetMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableIntroWikiResponse>(DoRequest("GetMetaTableIntroWiki", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaTableIntroWikiResponse> GetMetaTableIntroWikiAsync(GetMetaTableIntroWikiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableIntroWikiResponse>(await DoRequestAsync("GetMetaTableIntroWiki", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaTableIntroWikiResponse GetMetaTableIntroWikiSimply(GetMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableIntroWiki(request, runtime);
        }

        public async Task<GetMetaTableIntroWikiResponse> GetMetaTableIntroWikiSimplyAsync(GetMetaTableIntroWikiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableIntroWikiAsync(request, runtime);
        }

        public GetBaselineStatusResponse GetBaselineStatus(GetBaselineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBaselineStatusResponse>(DoRequest("GetBaselineStatus", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetBaselineStatusResponse> GetBaselineStatusAsync(GetBaselineStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetBaselineStatusResponse>(await DoRequestAsync("GetBaselineStatus", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetBaselineStatusResponse GetBaselineStatusSimply(GetBaselineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetBaselineStatus(request, runtime);
        }

        public async Task<GetBaselineStatusResponse> GetBaselineStatusSimplyAsync(GetBaselineStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetBaselineStatusAsync(request, runtime);
        }

        public DeleteDataServiceApiResponse DeleteDataServiceApi(DeleteDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataServiceApiResponse>(DoRequest("DeleteDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDataServiceApiResponse> DeleteDataServiceApiAsync(DeleteDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDataServiceApiResponse>(await DoRequestAsync("DeleteDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDataServiceApiResponse DeleteDataServiceApiSimply(DeleteDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataServiceApi(request, runtime);
        }

        public async Task<DeleteDataServiceApiResponse> DeleteDataServiceApiSimplyAsync(DeleteDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataServiceApiAsync(request, runtime);
        }

        public PublishDataServiceApiResponse PublishDataServiceApi(PublishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishDataServiceApiResponse>(DoRequest("PublishDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PublishDataServiceApiResponse> PublishDataServiceApiAsync(PublishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishDataServiceApiResponse>(await DoRequestAsync("PublishDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public PublishDataServiceApiResponse PublishDataServiceApiSimply(PublishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishDataServiceApi(request, runtime);
        }

        public async Task<PublishDataServiceApiResponse> PublishDataServiceApiSimplyAsync(PublishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishDataServiceApiAsync(request, runtime);
        }

        public GetMetaTableLineageResponse GetMetaTableLineage(GetMetaTableLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableLineageResponse>(DoRequest("GetMetaTableLineage", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetMetaTableLineageResponse> GetMetaTableLineageAsync(GetMetaTableLineageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetMetaTableLineageResponse>(await DoRequestAsync("GetMetaTableLineage", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetMetaTableLineageResponse GetMetaTableLineageSimply(GetMetaTableLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetaTableLineage(request, runtime);
        }

        public async Task<GetMetaTableLineageResponse> GetMetaTableLineageSimplyAsync(GetMetaTableLineageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetaTableLineageAsync(request, runtime);
        }

        public ListBaselineStatusesResponse ListBaselineStatuses(ListBaselineStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBaselineStatusesResponse>(DoRequest("ListBaselineStatuses", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListBaselineStatusesResponse> ListBaselineStatusesAsync(ListBaselineStatusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListBaselineStatusesResponse>(await DoRequestAsync("ListBaselineStatuses", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListBaselineStatusesResponse ListBaselineStatusesSimply(ListBaselineStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBaselineStatuses(request, runtime);
        }

        public async Task<ListBaselineStatusesResponse> ListBaselineStatusesSimplyAsync(ListBaselineStatusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBaselineStatusesAsync(request, runtime);
        }

        public ListRemindsResponse ListReminds(ListRemindsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRemindsResponse>(DoRequest("ListReminds", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListRemindsResponse> ListRemindsAsync(ListRemindsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRemindsResponse>(await DoRequestAsync("ListReminds", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public ListRemindsResponse ListRemindsSimply(ListRemindsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListReminds(request, runtime);
        }

        public async Task<ListRemindsResponse> ListRemindsSimplyAsync(ListRemindsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemindsAsync(request, runtime);
        }

        public DeleteQualityEntityResponse DeleteQualityEntity(DeleteQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityEntityResponse>(DoRequest("DeleteQualityEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteQualityEntityResponse> DeleteQualityEntityAsync(DeleteQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityEntityResponse>(await DoRequestAsync("DeleteQualityEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteQualityEntityResponse DeleteQualityEntitySimply(DeleteQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityEntity(request, runtime);
        }

        public async Task<DeleteQualityEntityResponse> DeleteQualityEntitySimplyAsync(DeleteQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityEntityAsync(request, runtime);
        }

        public CreateQualityFollowerResponse CreateQualityFollower(CreateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityFollowerResponse>(DoRequest("CreateQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateQualityFollowerResponse> CreateQualityFollowerAsync(CreateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityFollowerResponse>(await DoRequestAsync("CreateQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateQualityFollowerResponse CreateQualityFollowerSimply(CreateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityFollower(request, runtime);
        }

        public async Task<CreateQualityFollowerResponse> CreateQualityFollowerSimplyAsync(CreateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityFollowerAsync(request, runtime);
        }

        public CreateDataServiceApiResponse CreateDataServiceApi(CreateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceApiResponse>(DoRequest("CreateDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataServiceApiResponse> CreateDataServiceApiAsync(CreateDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataServiceApiResponse>(await DoRequestAsync("CreateDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataServiceApiResponse CreateDataServiceApiSimply(CreateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataServiceApi(request, runtime);
        }

        public async Task<CreateDataServiceApiResponse> CreateDataServiceApiSimplyAsync(CreateDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataServiceApiAsync(request, runtime);
        }

        public AbolishDataServiceApiResponse AbolishDataServiceApi(AbolishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AbolishDataServiceApiResponse>(DoRequest("AbolishDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AbolishDataServiceApiResponse> AbolishDataServiceApiAsync(AbolishDataServiceApiRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AbolishDataServiceApiResponse>(await DoRequestAsync("AbolishDataServiceApi", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public AbolishDataServiceApiResponse AbolishDataServiceApiSimply(AbolishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AbolishDataServiceApi(request, runtime);
        }

        public async Task<AbolishDataServiceApiResponse> AbolishDataServiceApiSimplyAsync(AbolishDataServiceApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AbolishDataServiceApiAsync(request, runtime);
        }

        public GetQualityEntityResponse GetQualityEntity(GetQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetQualityEntityResponse>(DoRequest("GetQualityEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetQualityEntityResponse> GetQualityEntityAsync(GetQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetQualityEntityResponse>(await DoRequestAsync("GetQualityEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetQualityEntityResponse GetQualityEntitySimply(GetQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityEntity(request, runtime);
        }

        public async Task<GetQualityEntityResponse> GetQualityEntitySimplyAsync(GetQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityEntityAsync(request, runtime);
        }

        public GetQualityFollowerResponse GetQualityFollower(GetQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetQualityFollowerResponse>(DoRequest("GetQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetQualityFollowerResponse> GetQualityFollowerAsync(GetQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetQualityFollowerResponse>(await DoRequestAsync("GetQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public GetQualityFollowerResponse GetQualityFollowerSimply(GetQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQualityFollower(request, runtime);
        }

        public async Task<GetQualityFollowerResponse> GetQualityFollowerSimplyAsync(GetQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQualityFollowerAsync(request, runtime);
        }

        public DeleteQualityFollowerResponse DeleteQualityFollower(DeleteQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityFollowerResponse>(DoRequest("DeleteQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteQualityFollowerResponse> DeleteQualityFollowerAsync(DeleteQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityFollowerResponse>(await DoRequestAsync("DeleteQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteQualityFollowerResponse DeleteQualityFollowerSimply(DeleteQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityFollower(request, runtime);
        }

        public async Task<DeleteQualityFollowerResponse> DeleteQualityFollowerSimplyAsync(DeleteQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityFollowerAsync(request, runtime);
        }

        public CreateQualityEntityResponse CreateQualityEntity(CreateQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityEntityResponse>(DoRequest("CreateQualityEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateQualityEntityResponse> CreateQualityEntityAsync(CreateQualityEntityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityEntityResponse>(await DoRequestAsync("CreateQualityEntity", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateQualityEntityResponse CreateQualityEntitySimply(CreateQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityEntity(request, runtime);
        }

        public async Task<CreateQualityEntityResponse> CreateQualityEntitySimplyAsync(CreateQualityEntityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityEntityAsync(request, runtime);
        }

        public CreateQualityRuleResponse CreateQualityRule(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityRuleResponse>(DoRequest("CreateQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateQualityRuleResponse> CreateQualityRuleAsync(CreateQualityRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityRuleResponse>(await DoRequestAsync("CreateQualityRule", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateQualityRuleResponse CreateQualityRuleSimply(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityRule(request, runtime);
        }

        public async Task<CreateQualityRuleResponse> CreateQualityRuleSimplyAsync(CreateQualityRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityRuleAsync(request, runtime);
        }

        public UpdateQualityFollowerResponse UpdateQualityFollower(UpdateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateQualityFollowerResponse>(DoRequest("UpdateQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateQualityFollowerResponse> UpdateQualityFollowerAsync(UpdateQualityFollowerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateQualityFollowerResponse>(await DoRequestAsync("UpdateQualityFollower", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public UpdateQualityFollowerResponse UpdateQualityFollowerSimply(UpdateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQualityFollower(request, runtime);
        }

        public async Task<UpdateQualityFollowerResponse> UpdateQualityFollowerSimplyAsync(UpdateQualityFollowerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQualityFollowerAsync(request, runtime);
        }

        public CreateQualityRelativeNodeResponse CreateQualityRelativeNode(CreateQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityRelativeNodeResponse>(DoRequest("CreateQualityRelativeNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateQualityRelativeNodeResponse> CreateQualityRelativeNodeAsync(CreateQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateQualityRelativeNodeResponse>(await DoRequestAsync("CreateQualityRelativeNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public CreateQualityRelativeNodeResponse CreateQualityRelativeNodeSimply(CreateQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQualityRelativeNode(request, runtime);
        }

        public async Task<CreateQualityRelativeNodeResponse> CreateQualityRelativeNodeSimplyAsync(CreateQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQualityRelativeNodeAsync(request, runtime);
        }

        public DeleteQualityRelativeNodeResponse DeleteQualityRelativeNode(DeleteQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityRelativeNodeResponse>(DoRequest("DeleteQualityRelativeNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteQualityRelativeNodeResponse> DeleteQualityRelativeNodeAsync(DeleteQualityRelativeNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteQualityRelativeNodeResponse>(await DoRequestAsync("DeleteQualityRelativeNode", "HTTPS", "POST", "2020-05-18", "AK", null, request.ToMap(), runtime));
        }

        public DeleteQualityRelativeNodeResponse DeleteQualityRelativeNodeSimply(DeleteQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQualityRelativeNode(request, runtime);
        }

        public async Task<DeleteQualityRelativeNodeResponse> DeleteQualityRelativeNodeSimplyAsync(DeleteQualityRelativeNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQualityRelativeNodeAsync(request, runtime);
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
