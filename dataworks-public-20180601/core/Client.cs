// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dataworks_public20180601.Models;

namespace AlibabaCloud.SDK.Dataworks_public20180601
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
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
         * @param request CreateManualDagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateManualDagResponse
         */
        public CreateManualDagResponse CreateManualDagWithOptions(CreateManualDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bizdate))
            {
                query["Bizdate"] = request.Bizdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagPara))
            {
                query["DagPara"] = request.DagPara;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePara))
            {
                query["NodePara"] = request.NodePara;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateManualDag",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateManualDagResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateManualDagRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateManualDagResponse
         */
        public async Task<CreateManualDagResponse> CreateManualDagWithOptionsAsync(CreateManualDagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bizdate))
            {
                query["Bizdate"] = request.Bizdate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagPara))
            {
                query["DagPara"] = request.DagPara;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlowName))
            {
                query["FlowName"] = request.FlowName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePara))
            {
                query["NodePara"] = request.NodePara;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateManualDag",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateManualDagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateManualDagRequest
         * @return CreateManualDagResponse
         */
        public CreateManualDagResponse CreateManualDag(CreateManualDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateManualDagWithOptions(request, runtime);
        }

        /**
         * @param request CreateManualDagRequest
         * @return CreateManualDagResponse
         */
        public async Task<CreateManualDagResponse> CreateManualDagAsync(CreateManualDagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateManualDagWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFileWithOptions(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdentifier))
            {
                body["ProjectIdentifier"] = request.ProjectIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteFileRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileWithOptionsAsync(DeleteFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectIdentifier))
            {
                body["ProjectIdentifier"] = request.ProjectIdentifier;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteFile",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteFileResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteFileRequest
         * @return DeleteFileResponse
         */
        public DeleteFileResponse DeleteFile(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteFileWithOptions(request, runtime);
        }

        /**
         * @param request DeleteFileRequest
         * @return DeleteFileResponse
         */
        public async Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteFileWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DescribeEmrHiveTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEmrHiveTableResponse
         */
        public DescribeEmrHiveTableResponse DescribeEmrHiveTableWithOptions(DescribeEmrHiveTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmrHiveTable",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmrHiveTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DescribeEmrHiveTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEmrHiveTableResponse
         */
        public async Task<DescribeEmrHiveTableResponse> DescribeEmrHiveTableWithOptionsAsync(DescribeEmrHiveTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEmrHiveTable",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEmrHiveTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DescribeEmrHiveTableRequest
         * @return DescribeEmrHiveTableResponse
         */
        public DescribeEmrHiveTableResponse DescribeEmrHiveTable(DescribeEmrHiveTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEmrHiveTableWithOptions(request, runtime);
        }

        /**
         * @param request DescribeEmrHiveTableRequest
         * @return DescribeEmrHiveTableResponse
         */
        public async Task<DescribeEmrHiveTableResponse> DescribeEmrHiveTableAsync(DescribeEmrHiveTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEmrHiveTableWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询apiContext接口
         *
         * @param request GetDataServiceApiContextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataServiceApiContextResponse
         */
        public GetDataServiceApiContextResponse GetDataServiceApiContextWithOptions(GetDataServiceApiContextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataServiceApiContext",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataServiceApiContextResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询apiContext接口
         *
         * @param request GetDataServiceApiContextRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataServiceApiContextResponse
         */
        public async Task<GetDataServiceApiContextResponse> GetDataServiceApiContextWithOptionsAsync(GetDataServiceApiContextRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataServiceApiContext",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataServiceApiContextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询apiContext接口
         *
         * @param request GetDataServiceApiContextRequest
         * @return GetDataServiceApiContextResponse
         */
        public GetDataServiceApiContextResponse GetDataServiceApiContext(GetDataServiceApiContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceApiContextWithOptions(request, runtime);
        }

        /**
         * @summary 查询apiContext接口
         *
         * @param request GetDataServiceApiContextRequest
         * @return GetDataServiceApiContextResponse
         */
        public async Task<GetDataServiceApiContextResponse> GetDataServiceApiContextAsync(GetDataServiceApiContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceApiContextWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询apiContext更新事件接口
         *
         * @param request GetDataServiceContextUpdateEventRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataServiceContextUpdateEventResponse
         */
        public GetDataServiceContextUpdateEventResponse GetDataServiceContextUpdateEventWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataServiceContextUpdateEvent",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataServiceContextUpdateEventResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询apiContext更新事件接口
         *
         * @param request GetDataServiceContextUpdateEventRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDataServiceContextUpdateEventResponse
         */
        public async Task<GetDataServiceContextUpdateEventResponse> GetDataServiceContextUpdateEventWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDataServiceContextUpdateEvent",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDataServiceContextUpdateEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询apiContext更新事件接口
         *
         * @return GetDataServiceContextUpdateEventResponse
         */
        public GetDataServiceContextUpdateEventResponse GetDataServiceContextUpdateEvent()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataServiceContextUpdateEventWithOptions(runtime);
        }

        /**
         * @summary 查询apiContext更新事件接口
         *
         * @return GetDataServiceContextUpdateEventResponse
         */
        public async Task<GetDataServiceContextUpdateEventResponse> GetDataServiceContextUpdateEventAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataServiceContextUpdateEventWithOptionsAsync(runtime);
        }

        /**
         * @summary 根据Switch名称获取值
         *
         * @param request GetSwitchValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSwitchValueResponse
         */
        public GetSwitchValueResponse GetSwitchValueWithOptions(GetSwitchValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchName))
            {
                query["SwitchName"] = request.SwitchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSwitchValue",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwitchValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 根据Switch名称获取值
         *
         * @param request GetSwitchValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSwitchValueResponse
         */
        public async Task<GetSwitchValueResponse> GetSwitchValueWithOptionsAsync(GetSwitchValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchName))
            {
                query["SwitchName"] = request.SwitchName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSwitchValue",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSwitchValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 根据Switch名称获取值
         *
         * @param request GetSwitchValueRequest
         * @return GetSwitchValueResponse
         */
        public GetSwitchValueResponse GetSwitchValue(GetSwitchValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSwitchValueWithOptions(request, runtime);
        }

        /**
         * @summary 根据Switch名称获取值
         *
         * @param request GetSwitchValueRequest
         * @return GetSwitchValueResponse
         */
        public async Task<GetSwitchValueResponse> GetSwitchValueAsync(GetSwitchValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSwitchValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询timeMachine任务详情
         *
         * @param request GetTimeMachineTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTimeMachineTaskResponse
         */
        public GetTimeMachineTaskResponse GetTimeMachineTaskWithOptions(GetTimeMachineTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTimeMachineTask",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTimeMachineTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询timeMachine任务详情
         *
         * @param request GetTimeMachineTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTimeMachineTaskResponse
         */
        public async Task<GetTimeMachineTaskResponse> GetTimeMachineTaskWithOptionsAsync(GetTimeMachineTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTimeMachineTask",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTimeMachineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询timeMachine任务详情
         *
         * @param request GetTimeMachineTaskRequest
         * @return GetTimeMachineTaskResponse
         */
        public GetTimeMachineTaskResponse GetTimeMachineTask(GetTimeMachineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTimeMachineTaskWithOptions(request, runtime);
        }

        /**
         * @summary 查询timeMachine任务详情
         *
         * @param request GetTimeMachineTaskRequest
         * @return GetTimeMachineTaskResponse
         */
        public async Task<GetTimeMachineTaskResponse> GetTimeMachineTaskAsync(GetTimeMachineTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTimeMachineTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListEmrHiveAuditLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmrHiveAuditLogsResponse
         */
        public ListEmrHiveAuditLogsResponse ListEmrHiveAuditLogsWithOptions(ListEmrHiveAuditLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrHiveAuditLogs",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrHiveAuditLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListEmrHiveAuditLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmrHiveAuditLogsResponse
         */
        public async Task<ListEmrHiveAuditLogsResponse> ListEmrHiveAuditLogsWithOptionsAsync(ListEmrHiveAuditLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrHiveAuditLogs",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrHiveAuditLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListEmrHiveAuditLogsRequest
         * @return ListEmrHiveAuditLogsResponse
         */
        public ListEmrHiveAuditLogsResponse ListEmrHiveAuditLogs(ListEmrHiveAuditLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrHiveAuditLogsWithOptions(request, runtime);
        }

        /**
         * @param request ListEmrHiveAuditLogsRequest
         * @return ListEmrHiveAuditLogsResponse
         */
        public async Task<ListEmrHiveAuditLogsResponse> ListEmrHiveAuditLogsAsync(ListEmrHiveAuditLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrHiveAuditLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListEmrHiveDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmrHiveDatabasesResponse
         */
        public ListEmrHiveDatabasesResponse ListEmrHiveDatabasesWithOptions(ListEmrHiveDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrHiveDatabases",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrHiveDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListEmrHiveDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmrHiveDatabasesResponse
         */
        public async Task<ListEmrHiveDatabasesResponse> ListEmrHiveDatabasesWithOptionsAsync(ListEmrHiveDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEmrHiveDatabases",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrHiveDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListEmrHiveDatabasesRequest
         * @return ListEmrHiveDatabasesResponse
         */
        public ListEmrHiveDatabasesResponse ListEmrHiveDatabases(ListEmrHiveDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrHiveDatabasesWithOptions(request, runtime);
        }

        /**
         * @param request ListEmrHiveDatabasesRequest
         * @return ListEmrHiveDatabasesResponse
         */
        public async Task<ListEmrHiveDatabasesResponse> ListEmrHiveDatabasesAsync(ListEmrHiveDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrHiveDatabasesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListEmrHiveTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmrHiveTablesResponse
         */
        public ListEmrHiveTablesResponse ListEmrHiveTablesWithOptions(ListEmrHiveTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "ListEmrHiveTables",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrHiveTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListEmrHiveTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListEmrHiveTablesResponse
         */
        public async Task<ListEmrHiveTablesResponse> ListEmrHiveTablesWithOptionsAsync(ListEmrHiveTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
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
                Action = "ListEmrHiveTables",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEmrHiveTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListEmrHiveTablesRequest
         * @return ListEmrHiveTablesResponse
         */
        public ListEmrHiveTablesResponse ListEmrHiveTables(ListEmrHiveTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEmrHiveTablesWithOptions(request, runtime);
        }

        /**
         * @param request ListEmrHiveTablesRequest
         * @return ListEmrHiveTablesResponse
         */
        public async Task<ListEmrHiveTablesResponse> ListEmrHiveTablesAsync(ListEmrHiveTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEmrHiveTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询数据服务API
         *
         * @param request ListGovernanceIssueDataServiceAPIsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceIssueDataServiceAPIsResponse
         */
        public ListGovernanceIssueDataServiceAPIsResponse ListGovernanceIssueDataServiceAPIsWithOptions(ListGovernanceIssueDataServiceAPIsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                body["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["RuleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGovernanceIssueDataServiceAPIs",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceIssueDataServiceAPIsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询数据服务API
         *
         * @param request ListGovernanceIssueDataServiceAPIsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceIssueDataServiceAPIsResponse
         */
        public async Task<ListGovernanceIssueDataServiceAPIsResponse> ListGovernanceIssueDataServiceAPIsWithOptionsAsync(ListGovernanceIssueDataServiceAPIsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                body["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["RuleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGovernanceIssueDataServiceAPIs",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceIssueDataServiceAPIsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询数据服务API
         *
         * @param request ListGovernanceIssueDataServiceAPIsRequest
         * @return ListGovernanceIssueDataServiceAPIsResponse
         */
        public ListGovernanceIssueDataServiceAPIsResponse ListGovernanceIssueDataServiceAPIs(ListGovernanceIssueDataServiceAPIsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGovernanceIssueDataServiceAPIsWithOptions(request, runtime);
        }

        /**
         * @summary 查询数据服务API
         *
         * @param request ListGovernanceIssueDataServiceAPIsRequest
         * @return ListGovernanceIssueDataServiceAPIsResponse
         */
        public async Task<ListGovernanceIssueDataServiceAPIsResponse> ListGovernanceIssueDataServiceAPIsAsync(ListGovernanceIssueDataServiceAPIsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGovernanceIssueDataServiceAPIsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询治理项问题详情
         *
         * @param request ListGovernanceIssueTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceIssueTablesResponse
         */
        public ListGovernanceIssueTablesResponse ListGovernanceIssueTablesWithOptions(ListGovernanceIssueTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                body["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["RuleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGovernanceIssueTables",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceIssueTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询治理项问题详情
         *
         * @param request ListGovernanceIssueTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceIssueTablesResponse
         */
        public async Task<ListGovernanceIssueTablesResponse> ListGovernanceIssueTablesWithOptionsAsync(ListGovernanceIssueTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                body["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["RuleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGovernanceIssueTables",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceIssueTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询治理项问题详情
         *
         * @param request ListGovernanceIssueTablesRequest
         * @return ListGovernanceIssueTablesResponse
         */
        public ListGovernanceIssueTablesResponse ListGovernanceIssueTables(ListGovernanceIssueTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGovernanceIssueTablesWithOptions(request, runtime);
        }

        /**
         * @summary 查询治理项问题详情
         *
         * @param request ListGovernanceIssueTablesRequest
         * @return ListGovernanceIssueTablesResponse
         */
        public async Task<ListGovernanceIssueTablesResponse> ListGovernanceIssueTablesAsync(ListGovernanceIssueTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGovernanceIssueTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询治理项-任务问题详情
         *
         * @param request ListGovernanceIssueTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceIssueTasksResponse
         */
        public ListGovernanceIssueTasksResponse ListGovernanceIssueTasksWithOptions(ListGovernanceIssueTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                body["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["RuleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGovernanceIssueTasks",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceIssueTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询治理项-任务问题详情
         *
         * @param request ListGovernanceIssueTasksRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceIssueTasksResponse
         */
        public async Task<ListGovernanceIssueTasksResponse> ListGovernanceIssueTasksWithOptionsAsync(ListGovernanceIssueTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                body["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                body["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleCategory))
            {
                body["RuleCategory"] = request.RuleCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                body["RuleId"] = request.RuleId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGovernanceIssueTasks",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceIssueTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询治理项-任务问题详情
         *
         * @param request ListGovernanceIssueTasksRequest
         * @return ListGovernanceIssueTasksResponse
         */
        public ListGovernanceIssueTasksResponse ListGovernanceIssueTasks(ListGovernanceIssueTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGovernanceIssueTasksWithOptions(request, runtime);
        }

        /**
         * @summary 查询治理项-任务问题详情
         *
         * @param request ListGovernanceIssueTasksRequest
         * @return ListGovernanceIssueTasksResponse
         */
        public async Task<ListGovernanceIssueTasksResponse> ListGovernanceIssueTasksAsync(ListGovernanceIssueTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGovernanceIssueTasksWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询治理项定义信息
         *
         * @param request ListGovernanceRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceRulesResponse
         */
        public ListGovernanceRulesResponse ListGovernanceRulesWithOptions(ListGovernanceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueType))
            {
                body["IssueType"] = request.IssueType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
                Action = "ListGovernanceRules",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询治理项定义信息
         *
         * @param request ListGovernanceRulesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListGovernanceRulesResponse
         */
        public async Task<ListGovernanceRulesResponse> ListGovernanceRulesWithOptionsAsync(ListGovernanceRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Category))
            {
                body["Category"] = request.Category;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IssueType))
            {
                body["IssueType"] = request.IssueType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["PageNumber"] = request.PageNumber;
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
                Action = "ListGovernanceRules",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGovernanceRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询治理项定义信息
         *
         * @param request ListGovernanceRulesRequest
         * @return ListGovernanceRulesResponse
         */
        public ListGovernanceRulesResponse ListGovernanceRules(ListGovernanceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListGovernanceRulesWithOptions(request, runtime);
        }

        /**
         * @summary 查询治理项定义信息
         *
         * @param request ListGovernanceRulesRequest
         * @return ListGovernanceRulesResponse
         */
        public async Task<ListGovernanceRulesResponse> ListGovernanceRulesAsync(ListGovernanceRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListGovernanceRulesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListHiveColumnLineagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHiveColumnLineagesResponse
         */
        public ListHiveColumnLineagesResponse ListHiveColumnLineagesWithOptions(ListHiveColumnLineagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHiveColumnLineages",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHiveColumnLineagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListHiveColumnLineagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHiveColumnLineagesResponse
         */
        public async Task<ListHiveColumnLineagesResponse> ListHiveColumnLineagesWithOptionsAsync(ListHiveColumnLineagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnName))
            {
                query["ColumnName"] = request.ColumnName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHiveColumnLineages",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHiveColumnLineagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListHiveColumnLineagesRequest
         * @return ListHiveColumnLineagesResponse
         */
        public ListHiveColumnLineagesResponse ListHiveColumnLineages(ListHiveColumnLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHiveColumnLineagesWithOptions(request, runtime);
        }

        /**
         * @param request ListHiveColumnLineagesRequest
         * @return ListHiveColumnLineagesResponse
         */
        public async Task<ListHiveColumnLineagesResponse> ListHiveColumnLineagesAsync(ListHiveColumnLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHiveColumnLineagesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListHiveTableLineagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHiveTableLineagesResponse
         */
        public ListHiveTableLineagesResponse ListHiveTableLineagesWithOptions(ListHiveTableLineagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHiveTableLineages",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHiveTableLineagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListHiveTableLineagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListHiveTableLineagesResponse
         */
        public async Task<ListHiveTableLineagesResponse> ListHiveTableLineagesWithOptionsAsync(ListHiveTableLineagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListHiveTableLineages",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListHiveTableLineagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListHiveTableLineagesRequest
         * @return ListHiveTableLineagesResponse
         */
        public ListHiveTableLineagesResponse ListHiveTableLineages(ListHiveTableLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListHiveTableLineagesWithOptions(request, runtime);
        }

        /**
         * @param request ListHiveTableLineagesRequest
         * @return ListHiveTableLineagesResponse
         */
        public async Task<ListHiveTableLineagesResponse> ListHiveTableLineagesAsync(ListHiveTableLineagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListHiveTableLineagesWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListTablePartitionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTablePartitionsResponse
         */
        public ListTablePartitionsResponse ListTablePartitionsWithOptions(ListTablePartitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTablePartitions",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablePartitionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListTablePartitionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTablePartitionsResponse
         */
        public async Task<ListTablePartitionsResponse> ListTablePartitionsWithOptionsAsync(ListTablePartitionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTablePartitions",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablePartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListTablePartitionsRequest
         * @return ListTablePartitionsResponse
         */
        public ListTablePartitionsResponse ListTablePartitions(ListTablePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTablePartitionsWithOptions(request, runtime);
        }

        /**
         * @param request ListTablePartitionsRequest
         * @return ListTablePartitionsResponse
         */
        public async Task<ListTablePartitionsResponse> ListTablePartitionsAsync(ListTablePartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTablePartitionsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request OpenDataWorksStandardServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenDataWorksStandardServiceResponse
         */
        public OpenDataWorksStandardServiceResponse OpenDataWorksStandardServiceWithOptions(OpenDataWorksStandardServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDataWorksStandardService",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDataWorksStandardServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request OpenDataWorksStandardServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenDataWorksStandardServiceResponse
         */
        public async Task<OpenDataWorksStandardServiceResponse> OpenDataWorksStandardServiceWithOptionsAsync(OpenDataWorksStandardServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenDataWorksStandardService",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenDataWorksStandardServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request OpenDataWorksStandardServiceRequest
         * @return OpenDataWorksStandardServiceResponse
         */
        public OpenDataWorksStandardServiceResponse OpenDataWorksStandardService(OpenDataWorksStandardServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenDataWorksStandardServiceWithOptions(request, runtime);
        }

        /**
         * @param request OpenDataWorksStandardServiceRequest
         * @return OpenDataWorksStandardServiceResponse
         */
        public async Task<OpenDataWorksStandardServiceResponse> OpenDataWorksStandardServiceAsync(OpenDataWorksStandardServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenDataWorksStandardServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SearchManualDagNodeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchManualDagNodeInstanceResponse
         */
        public SearchManualDagNodeInstanceResponse SearchManualDagNodeInstanceWithOptions(SearchManualDagNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagId))
            {
                query["DagId"] = request.DagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchManualDagNodeInstance",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchManualDagNodeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SearchManualDagNodeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SearchManualDagNodeInstanceResponse
         */
        public async Task<SearchManualDagNodeInstanceResponse> SearchManualDagNodeInstanceWithOptionsAsync(SearchManualDagNodeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DagId))
            {
                query["DagId"] = request.DagId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["ProjectName"] = request.ProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchManualDagNodeInstance",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchManualDagNodeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SearchManualDagNodeInstanceRequest
         * @return SearchManualDagNodeInstanceResponse
         */
        public SearchManualDagNodeInstanceResponse SearchManualDagNodeInstance(SearchManualDagNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchManualDagNodeInstanceWithOptions(request, runtime);
        }

        /**
         * @param request SearchManualDagNodeInstanceRequest
         * @return SearchManualDagNodeInstanceResponse
         */
        public async Task<SearchManualDagNodeInstanceResponse> SearchManualDagNodeInstanceAsync(SearchManualDagNodeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchManualDagNodeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @param request SendTaskMetaCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTaskMetaCallbackResponse
         */
        public SendTaskMetaCallbackResponse SendTaskMetaCallbackWithOptions(SendTaskMetaCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionInfo))
            {
                body["ConnectionInfo"] = request.ConnectionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["SubType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEnvParam))
            {
                body["TaskEnvParam"] = request.TaskEnvParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTaskMetaCallback",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTaskMetaCallbackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request SendTaskMetaCallbackRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SendTaskMetaCallbackResponse
         */
        public async Task<SendTaskMetaCallbackResponse> SendTaskMetaCallbackWithOptionsAsync(SendTaskMetaCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionInfo))
            {
                body["ConnectionInfo"] = request.ConnectionInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["Resources"] = request.Resources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubType))
            {
                body["SubType"] = request.SubType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskEnvParam))
            {
                body["TaskEnvParam"] = request.TaskEnvParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                body["TenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["User"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendTaskMetaCallback",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendTaskMetaCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request SendTaskMetaCallbackRequest
         * @return SendTaskMetaCallbackResponse
         */
        public SendTaskMetaCallbackResponse SendTaskMetaCallback(SendTaskMetaCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendTaskMetaCallbackWithOptions(request, runtime);
        }

        /**
         * @param request SendTaskMetaCallbackRequest
         * @return SendTaskMetaCallbackResponse
         */
        public async Task<SendTaskMetaCallbackResponse> SendTaskMetaCallbackAsync(SendTaskMetaCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendTaskMetaCallbackWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 设置Switch的值
         *
         * @param request SetSwitchValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSwitchValueResponse
         */
        public SetSwitchValueResponse SetSwitchValueWithOptions(SetSwitchValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchName))
            {
                query["SwitchName"] = request.SwitchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchValue))
            {
                query["SwitchValue"] = request.SwitchValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSwitchValue",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSwitchValueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 设置Switch的值
         *
         * @param request SetSwitchValueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSwitchValueResponse
         */
        public async Task<SetSwitchValueResponse> SetSwitchValueWithOptionsAsync(SetSwitchValueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchName))
            {
                query["SwitchName"] = request.SwitchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SwitchValue))
            {
                query["SwitchValue"] = request.SwitchValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSwitchValue",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSwitchValueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 设置Switch的值
         *
         * @param request SetSwitchValueRequest
         * @return SetSwitchValueResponse
         */
        public SetSwitchValueResponse SetSwitchValue(SetSwitchValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSwitchValueWithOptions(request, runtime);
        }

        /**
         * @summary 设置Switch的值
         *
         * @param request SetSwitchValueRequest
         * @return SetSwitchValueResponse
         */
        public async Task<SetSwitchValueResponse> SetSwitchValueAsync(SetSwitchValueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSwitchValueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary startCollect
         *
         * @param request StartCollectQualityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCollectQualityResponse
         */
        public StartCollectQualityResponse StartCollectQualityWithOptions(StartCollectQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackResultString))
            {
                body["CallbackResultString"] = request.CallbackResultString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCollectQuality",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCollectQualityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary startCollect
         *
         * @param request StartCollectQualityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartCollectQualityResponse
         */
        public async Task<StartCollectQualityResponse> StartCollectQualityWithOptionsAsync(StartCollectQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackResultString))
            {
                body["CallbackResultString"] = request.CallbackResultString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartCollectQuality",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartCollectQualityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary startCollect
         *
         * @param request StartCollectQualityRequest
         * @return StartCollectQualityResponse
         */
        public StartCollectQualityResponse StartCollectQuality(StartCollectQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCollectQualityWithOptions(request, runtime);
        }

        /**
         * @summary startCollect
         *
         * @param request StartCollectQualityRequest
         * @return StartCollectQualityResponse
         */
        public async Task<StartCollectQualityResponse> StartCollectQualityAsync(StartCollectQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCollectQualityWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StartDoCheckQualityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartDoCheckQualityResponse
         */
        public StartDoCheckQualityResponse StartDoCheckQualityWithOptions(StartDoCheckQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackResultString))
            {
                body["CallbackResultString"] = request.CallbackResultString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDoCheckQuality",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDoCheckQualityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StartDoCheckQualityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartDoCheckQualityResponse
         */
        public async Task<StartDoCheckQualityResponse> StartDoCheckQualityWithOptionsAsync(StartDoCheckQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackResultString))
            {
                body["CallbackResultString"] = request.CallbackResultString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartDoCheckQuality",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartDoCheckQualityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StartDoCheckQualityRequest
         * @return StartDoCheckQualityResponse
         */
        public StartDoCheckQualityResponse StartDoCheckQuality(StartDoCheckQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartDoCheckQualityWithOptions(request, runtime);
        }

        /**
         * @param request StartDoCheckQualityRequest
         * @return StartDoCheckQualityResponse
         */
        public async Task<StartDoCheckQualityResponse> StartDoCheckQualityAsync(StartDoCheckQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartDoCheckQualityWithOptionsAsync(request, runtime);
        }

        /**
         * @param request StartTaskQualityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTaskQualityResponse
         */
        public StartTaskQualityResponse StartTaskQualityWithOptions(StartTaskQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackResultString))
            {
                body["CallbackResultString"] = request.CallbackResultString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTaskQuality",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskQualityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StartTaskQualityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartTaskQualityResponse
         */
        public async Task<StartTaskQualityResponse> StartTaskQualityWithOptionsAsync(StartTaskQualityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallbackResultString))
            {
                body["CallbackResultString"] = request.CallbackResultString;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartTaskQuality",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartTaskQualityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StartTaskQualityRequest
         * @return StartTaskQualityResponse
         */
        public StartTaskQualityResponse StartTaskQuality(StartTaskQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartTaskQualityWithOptions(request, runtime);
        }

        /**
         * @param request StartTaskQualityRequest
         * @return StartTaskQualityResponse
         */
        public async Task<StartTaskQualityResponse> StartTaskQualityAsync(StartTaskQualityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartTaskQualityWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 触发元数据的Merge操作
         *
         * @param request TriggerDataLoaderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerDataLoaderResponse
         */
        public TriggerDataLoaderResponse TriggerDataLoaderWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerDataLoader",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerDataLoaderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 触发元数据的Merge操作
         *
         * @param request TriggerDataLoaderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerDataLoaderResponse
         */
        public async Task<TriggerDataLoaderResponse> TriggerDataLoaderWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerDataLoader",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerDataLoaderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 触发元数据的Merge操作
         *
         * @return TriggerDataLoaderResponse
         */
        public TriggerDataLoaderResponse TriggerDataLoader()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerDataLoaderWithOptions(runtime);
        }

        /**
         * @summary 触发元数据的Merge操作
         *
         * @return TriggerDataLoaderResponse
         */
        public async Task<TriggerDataLoaderResponse> TriggerDataLoaderAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerDataLoaderWithOptionsAsync(runtime);
        }

        /**
         * @summary 触发timeMachine任务
         *
         * @param request TriggerTimeMachineTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerTimeMachineTaskResponse
         */
        public TriggerTimeMachineTaskResponse TriggerTimeMachineTaskWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerTimeMachineTask",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerTimeMachineTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 触发timeMachine任务
         *
         * @param request TriggerTimeMachineTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TriggerTimeMachineTaskResponse
         */
        public async Task<TriggerTimeMachineTaskResponse> TriggerTimeMachineTaskWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TriggerTimeMachineTask",
                Version = "2018-06-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TriggerTimeMachineTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 触发timeMachine任务
         *
         * @return TriggerTimeMachineTaskResponse
         */
        public TriggerTimeMachineTaskResponse TriggerTimeMachineTask()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerTimeMachineTaskWithOptions(runtime);
        }

        /**
         * @summary 触发timeMachine任务
         *
         * @return TriggerTimeMachineTaskResponse
         */
        public async Task<TriggerTimeMachineTaskResponse> TriggerTimeMachineTaskAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerTimeMachineTaskWithOptionsAsync(runtime);
        }

    }
}
