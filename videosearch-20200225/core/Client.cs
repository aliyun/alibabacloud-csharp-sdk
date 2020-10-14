// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Videosearch20200225.Models;

namespace AlibabaCloud.SDK.Videosearch20200225
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "multisearch.cn-beijing.aliyuncs.com"},
                {"cn-hangzhou", "multisearch.cn-hangzhou.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("videosearch", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public GetStorageHistoryResponse GetStorageHistoryWithOptions(GetStorageHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetStorageHistoryResponse>(DoRequest("GetStorageHistory", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetStorageHistoryResponse> GetStorageHistoryWithOptionsAsync(GetStorageHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetStorageHistoryResponse>(await DoRequestAsync("GetStorageHistory", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public GetStorageHistoryResponse GetStorageHistory(GetStorageHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStorageHistoryWithOptions(request, runtime);
        }

        public async Task<GetStorageHistoryResponse> GetStorageHistoryAsync(GetStorageHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStorageHistoryWithOptionsAsync(request, runtime);
        }

        public AddStorageVideoTaskResponse AddStorageVideoTaskWithOptions(AddStorageVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddStorageVideoTaskResponse>(DoRequest("AddStorageVideoTask", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddStorageVideoTaskResponse> AddStorageVideoTaskWithOptionsAsync(AddStorageVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddStorageVideoTaskResponse>(await DoRequestAsync("AddStorageVideoTask", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public AddStorageVideoTaskResponse AddStorageVideoTask(AddStorageVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddStorageVideoTaskWithOptions(request, runtime);
        }

        public async Task<AddStorageVideoTaskResponse> AddStorageVideoTaskAsync(AddStorageVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddStorageVideoTaskWithOptionsAsync(request, runtime);
        }

        public AddDeletionVideoTaskResponse AddDeletionVideoTaskWithOptions(AddDeletionVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDeletionVideoTaskResponse>(DoRequest("AddDeletionVideoTask", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddDeletionVideoTaskResponse> AddDeletionVideoTaskWithOptionsAsync(AddDeletionVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddDeletionVideoTaskResponse>(await DoRequestAsync("AddDeletionVideoTask", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public AddDeletionVideoTaskResponse AddDeletionVideoTask(AddDeletionVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDeletionVideoTaskWithOptions(request, runtime);
        }

        public async Task<AddDeletionVideoTaskResponse> AddDeletionVideoTaskAsync(AddDeletionVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDeletionVideoTaskWithOptionsAsync(request, runtime);
        }

        public GetTaskStatusResponse GetTaskStatusWithOptions(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTaskStatusResponse>(DoRequest("GetTaskStatus", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusWithOptionsAsync(GetTaskStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetTaskStatusResponse>(await DoRequestAsync("GetTaskStatus", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public GetTaskStatusResponse GetTaskStatus(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTaskStatusWithOptions(request, runtime);
        }

        public async Task<GetTaskStatusResponse> GetTaskStatusAsync(GetTaskStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTaskStatusWithOptionsAsync(request, runtime);
        }

        public AddSearchVideoTaskResponse AddSearchVideoTaskWithOptions(AddSearchVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddSearchVideoTaskResponse>(DoRequest("AddSearchVideoTask", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddSearchVideoTaskResponse> AddSearchVideoTaskWithOptionsAsync(AddSearchVideoTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddSearchVideoTaskResponse>(await DoRequestAsync("AddSearchVideoTask", "HTTPS", "POST", "2020-02-25", "AK", null, request.ToMap(), runtime));
        }

        public AddSearchVideoTaskResponse AddSearchVideoTask(AddSearchVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddSearchVideoTaskWithOptions(request, runtime);
        }

        public async Task<AddSearchVideoTaskResponse> AddSearchVideoTaskAsync(AddSearchVideoTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddSearchVideoTaskWithOptionsAsync(request, runtime);
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
