// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sae20190506.Models;

namespace AlibabaCloud.SDK.Sae20190506
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("sae", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrderWithOptions(AbortAndRollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortAndRollbackChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortAndRollbackChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderWithOptionsAsync(AbortAndRollbackChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortAndRollbackChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortAndRollbackChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortAndRollbackChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AbortAndRollbackChangeOrderResponse AbortAndRollbackChangeOrder(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortAndRollbackChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<AbortAndRollbackChangeOrderResponse> AbortAndRollbackChangeOrderAsync(AbortAndRollbackChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortAndRollbackChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public AbortChangeOrderResponse AbortChangeOrderWithOptions(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AbortChangeOrderResponse> AbortChangeOrderWithOptionsAsync(AbortChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AbortChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/AbortChangeOrder",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AbortChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AbortChangeOrderResponse AbortChangeOrder(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AbortChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<AbortChangeOrderResponse> AbortChangeOrderAsync(AbortChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AbortChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public BatchStartApplicationsResponse BatchStartApplicationsWithOptions(BatchStartApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStartApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartApplicationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchStartApplicationsResponse> BatchStartApplicationsWithOptionsAsync(BatchStartApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStartApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStartApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStartApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchStartApplicationsResponse BatchStartApplications(BatchStartApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchStartApplicationsWithOptions(request, headers, runtime);
        }

        public async Task<BatchStartApplicationsResponse> BatchStartApplicationsAsync(BatchStartApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchStartApplicationsWithOptionsAsync(request, headers, runtime);
        }

        public BatchStopApplicationsResponse BatchStopApplicationsWithOptions(BatchStopApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStopApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopApplicationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BatchStopApplicationsResponse> BatchStopApplicationsWithOptionsAsync(BatchStopApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchStopApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/batchStopApplications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchStopApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BatchStopApplicationsResponse BatchStopApplications(BatchStopApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchStopApplicationsWithOptions(request, headers, runtime);
        }

        public async Task<BatchStopApplicationsResponse> BatchStopApplicationsAsync(BatchStopApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchStopApplicationsWithOptionsAsync(request, headers, runtime);
        }

        public BindSlbResponse BindSlbWithOptions(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<BindSlbResponse> BindSlbWithOptionsAsync(BindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetSlbId))
            {
                query["InternetSlbId"] = request.InternetSlbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntranetSlbId))
            {
                query["IntranetSlbId"] = request.IntranetSlbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BindSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public BindSlbResponse BindSlb(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BindSlbWithOptions(request, headers, runtime);
        }

        public async Task<BindSlbResponse> BindSlbAsync(BindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BindSlbWithOptionsAsync(request, headers, runtime);
        }

        public ConfirmPipelineBatchResponse ConfirmPipelineBatchWithOptions(ConfirmPipelineBatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmPipelineBatch",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ConfirmPipelineBatch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmPipelineBatchResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ConfirmPipelineBatchResponse> ConfirmPipelineBatchWithOptionsAsync(ConfirmPipelineBatchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Confirm))
            {
                query["Confirm"] = request.Confirm;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConfirmPipelineBatch",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ConfirmPipelineBatch",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConfirmPipelineBatchResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ConfirmPipelineBatchResponse ConfirmPipelineBatch(ConfirmPipelineBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConfirmPipelineBatchWithOptions(request, headers, runtime);
        }

        public async Task<ConfirmPipelineBatchResponse> ConfirmPipelineBatchAsync(ConfirmPipelineBatchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConfirmPipelineBatchWithOptionsAsync(request, headers, runtime);
        }

        public CreateApplicationResponse CreateApplicationWithOptions(CreateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEbpf))
            {
                query["EnableEbpf"] = request.EnableEbpf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaeVersion))
            {
                query["SaeVersion"] = request.SaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/createApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateApplicationResponse> CreateApplicationWithOptionsAsync(CreateApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableEbpf))
            {
                query["EnableEbpf"] = request.EnableEbpf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaeVersion))
            {
                query["SaeVersion"] = request.SaeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/createApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationWithOptions(request, headers, runtime);
        }

        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationWithOptionsAsync(request, headers, runtime);
        }

        /**
          * The HTTP status code. Take note of the following rules:
          * *   **2xx**: The call was successful.
          * *   **3xx**: The call was redirected.
          * *   **4xx**: The call failed.
          * *   **5xx**: A server error occurred.
          *
          * @param request CreateApplicationScalingRuleRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateApplicationScalingRuleResponse
         */
        public CreateApplicationScalingRuleResponse CreateApplicationScalingRuleWithOptions(CreateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * The HTTP status code. Take note of the following rules:
          * *   **2xx**: The call was successful.
          * *   **3xx**: The call was redirected.
          * *   **4xx**: The call failed.
          * *   **5xx**: A server error occurred.
          *
          * @param request CreateApplicationScalingRuleRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateApplicationScalingRuleResponse
         */
        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleWithOptionsAsync(CreateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleEnable))
            {
                query["ScalingRuleEnable"] = request.ScalingRuleEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleType))
            {
                query["ScalingRuleType"] = request.ScalingRuleType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * The HTTP status code. Take note of the following rules:
          * *   **2xx**: The call was successful.
          * *   **3xx**: The call was redirected.
          * *   **4xx**: The call failed.
          * *   **5xx**: A server error occurred.
          *
          * @param request CreateApplicationScalingRuleRequest
          * @return CreateApplicationScalingRuleResponse
         */
        public CreateApplicationScalingRuleResponse CreateApplicationScalingRule(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
          * The HTTP status code. Take note of the following rules:
          * *   **2xx**: The call was successful.
          * *   **3xx**: The call was redirected.
          * *   **4xx**: The call failed.
          * *   **5xx**: A server error occurred.
          *
          * @param request CreateApplicationScalingRuleRequest
          * @return CreateApplicationScalingRuleResponse
         */
        public async Task<CreateApplicationScalingRuleResponse> CreateApplicationScalingRuleAsync(CreateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public CreateConfigMapResponse CreateConfigMapWithOptions(CreateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateConfigMapResponse> CreateConfigMapWithOptionsAsync(CreateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateConfigMapResponse CreateConfigMap(CreateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<CreateConfigMapResponse> CreateConfigMapAsync(CreateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigMapWithOptionsAsync(request, headers, runtime);
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request CreateGreyTagRouteRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateGreyTagRouteResponse
         */
        public CreateGreyTagRouteResponse CreateGreyTagRouteWithOptions(CreateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request CreateGreyTagRouteRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateGreyTagRouteResponse
         */
        public async Task<CreateGreyTagRouteResponse> CreateGreyTagRouteWithOptionsAsync(CreateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request CreateGreyTagRouteRequest
          * @return CreateGreyTagRouteResponse
         */
        public CreateGreyTagRouteResponse CreateGreyTagRoute(CreateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request CreateGreyTagRouteRequest
          * @return CreateGreyTagRouteResponse
         */
        public async Task<CreateGreyTagRouteResponse> CreateGreyTagRouteAsync(CreateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        public CreateIngressResponse CreateIngressWithOptions(CreateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIngressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateIngressResponse> CreateIngressWithOptionsAsync(CreateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlbId))
            {
                query["SlbId"] = request.SlbId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateIngressResponse CreateIngress(CreateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIngressWithOptions(request, headers, runtime);
        }

        public async Task<CreateIngressResponse> CreateIngressAsync(CreateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIngressWithOptionsAsync(request, headers, runtime);
        }

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/createJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoConfig))
            {
                query["AutoConfig"] = request.AutoConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/createJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobWithOptions(request, headers, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobWithOptionsAsync(request, headers, runtime);
        }

        public CreateNamespaceResponse CreateNamespaceWithOptions(CreateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceWithOptionsAsync(CreateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateNamespaceWithOptions(request, headers, runtime);
        }

        public async Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        public CreateSecretResponse CreateSecretWithOptions(CreateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretType))
            {
                query["SecretType"] = request.SecretType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateSecretResponse> CreateSecretWithOptionsAsync(CreateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSecretShrinkRequest request = new CreateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretName))
            {
                query["SecretName"] = request.SecretName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretType))
            {
                query["SecretType"] = request.SecretType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSecretWithOptions(request, headers, runtime);
        }

        public async Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSecretWithOptionsAsync(request, headers, runtime);
        }

        public DeleteApplicationResponse DeleteApplicationWithOptions(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deleteApplication",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationWithOptionsAsync(DeleteApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deleteApplication",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRuleWithOptions(DeleteApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleWithOptionsAsync(DeleteApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteApplicationScalingRuleResponse DeleteApplicationScalingRule(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteApplicationScalingRuleResponse> DeleteApplicationScalingRuleAsync(DeleteApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteConfigMapResponse DeleteConfigMapWithOptions(DeleteConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteConfigMapResponse> DeleteConfigMapWithOptionsAsync(DeleteConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteConfigMapResponse DeleteConfigMap(DeleteConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<DeleteConfigMapResponse> DeleteConfigMapAsync(DeleteConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigMapWithOptionsAsync(request, headers, runtime);
        }

        public DeleteGreyTagRouteResponse DeleteGreyTagRouteWithOptions(DeleteGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteGreyTagRouteResponse> DeleteGreyTagRouteWithOptionsAsync(DeleteGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteGreyTagRouteResponse DeleteGreyTagRoute(DeleteGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGreyTagRouteWithOptions(request, headers, runtime);
        }

        public async Task<DeleteGreyTagRouteResponse> DeleteGreyTagRouteAsync(DeleteGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        public DeleteHistoryJobResponse DeleteHistoryJobWithOptions(DeleteHistoryJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHistoryJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteHistoryJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHistoryJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHistoryJobResponse> DeleteHistoryJobWithOptionsAsync(DeleteHistoryJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHistoryJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteHistoryJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHistoryJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHistoryJobResponse DeleteHistoryJob(DeleteHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteHistoryJobWithOptions(request, headers, runtime);
        }

        public async Task<DeleteHistoryJobResponse> DeleteHistoryJobAsync(DeleteHistoryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteHistoryJobWithOptionsAsync(request, headers, runtime);
        }

        public DeleteIngressResponse DeleteIngressWithOptions(DeleteIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIngressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteIngressResponse> DeleteIngressWithOptionsAsync(DeleteIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteIngressResponse DeleteIngress(DeleteIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIngressWithOptions(request, headers, runtime);
        }

        public async Task<DeleteIngressResponse> DeleteIngressAsync(DeleteIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIngressWithOptionsAsync(request, headers, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/deleteJob",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteJobWithOptions(request, headers, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteJobWithOptionsAsync(request, headers, runtime);
        }

        public DeleteNamespaceResponse DeleteNamespaceWithOptions(DeleteNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceWithOptionsAsync(DeleteNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteNamespaceWithOptions(request, headers, runtime);
        }

        public async Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteNamespaceWithOptionsAsync(request, headers, runtime);
        }

        public DeleteSecretResponse DeleteSecretWithOptions(DeleteSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteSecretResponse> DeleteSecretWithOptionsAsync(DeleteSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSecretWithOptions(request, headers, runtime);
        }

        public async Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSecretWithOptionsAsync(request, headers, runtime);
        }

        public DeployApplicationResponse DeployApplicationWithOptions(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGreyTagRoute))
            {
                query["EnableGreyTagRoute"] = request.EnableGreyTagRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deployApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployApplicationResponse> DeployApplicationWithOptionsAsync(DeployApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderDesc))
            {
                query["ChangeOrderDesc"] = request.ChangeOrderDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Deploy))
            {
                query["Deploy"] = request.Deploy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAhas))
            {
                query["EnableAhas"] = request.EnableAhas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableGreyTagRoute))
            {
                query["EnableGreyTagRoute"] = request.EnableGreyTagRoute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KafkaConfigs))
            {
                query["KafkaConfigs"] = request.KafkaConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Liveness))
            {
                query["Liveness"] = request.Liveness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MicroRegistration))
            {
                query["MicroRegistration"] = request.MicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasConfigs))
            {
                query["NasConfigs"] = request.NasConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageType))
            {
                query["PackageType"] = request.PackageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpArmsConfigLocation))
            {
                query["PhpArmsConfigLocation"] = request.PhpArmsConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PvtzDiscoverySvc))
            {
                query["PvtzDiscoverySvc"] = request.PvtzDiscoverySvc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Readiness))
            {
                query["Readiness"] = request.Readiness;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssociateEip))
            {
                body["AssociateEip"] = request.AssociateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/deployApplication",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployApplicationResponse DeployApplication(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployApplicationWithOptions(request, headers, runtime);
        }

        public async Task<DeployApplicationResponse> DeployApplicationAsync(DeployApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployApplicationWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppServiceDetailResponse DescribeAppServiceDetailWithOptions(DescribeAppServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppServiceDetail",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/describeAppServiceDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppServiceDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeAppServiceDetailResponse> DescribeAppServiceDetailWithOptionsAsync(DescribeAppServiceDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceGroup))
            {
                query["ServiceGroup"] = request.ServiceGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceName))
            {
                query["ServiceName"] = request.ServiceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppServiceDetail",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/describeAppServiceDetail",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppServiceDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAppServiceDetailResponse DescribeAppServiceDetail(DescribeAppServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppServiceDetailWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppServiceDetailResponse> DescribeAppServiceDetailAsync(DescribeAppServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppServiceDetailWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationConfigResponse DescribeApplicationConfigWithOptions(DescribeApplicationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationConfigResponse> DescribeApplicationConfigWithOptionsAsync(DescribeApplicationConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationConfig",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationConfigResponse DescribeApplicationConfig(DescribeApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationConfigWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationConfigResponse> DescribeApplicationConfigAsync(DescribeApplicationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationConfigWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationGroupsResponse DescribeApplicationGroupsWithOptions(DescribeApplicationGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationGroups",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationGroupsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationGroupsResponse> DescribeApplicationGroupsWithOptionsAsync(DescribeApplicationGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationGroups",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationGroupsResponse DescribeApplicationGroups(DescribeApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationGroupsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationGroupsResponse> DescribeApplicationGroupsAsync(DescribeApplicationGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationGroupsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationImageResponse DescribeApplicationImageWithOptions(DescribeApplicationImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationImage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/container/describeApplicationImage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationImageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationImageResponse> DescribeApplicationImageWithOptionsAsync(DescribeApplicationImageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationImage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/container/describeApplicationImage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationImageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationImageResponse DescribeApplicationImage(DescribeApplicationImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationImageWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationImageResponse> DescribeApplicationImageAsync(DescribeApplicationImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationImageWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationInstancesResponse DescribeApplicationInstancesWithOptions(DescribeApplicationInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationInstancesResponse> DescribeApplicationInstancesWithOptionsAsync(DescribeApplicationInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationInstances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationInstancesResponse DescribeApplicationInstances(DescribeApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationInstancesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationInstancesResponse> DescribeApplicationInstancesAsync(DescribeApplicationInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationInstancesWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationScalingRuleResponse DescribeApplicationScalingRuleWithOptions(DescribeApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationScalingRuleResponse> DescribeApplicationScalingRuleWithOptionsAsync(DescribeApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationScalingRuleResponse DescribeApplicationScalingRule(DescribeApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationScalingRuleResponse> DescribeApplicationScalingRuleAsync(DescribeApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRulesWithOptions(DescribeApplicationScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRules",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRulesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesWithOptionsAsync(DescribeApplicationScalingRulesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationScalingRules",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationScalingRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationScalingRulesResponse DescribeApplicationScalingRules(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationScalingRulesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationScalingRulesResponse> DescribeApplicationScalingRulesAsync(DescribeApplicationScalingRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationScalingRulesWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationSlbsResponse DescribeApplicationSlbsWithOptions(DescribeApplicationSlbsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationSlbs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationSlbsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationSlbsResponse> DescribeApplicationSlbsWithOptionsAsync(DescribeApplicationSlbsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationSlbs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationSlbsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationSlbsResponse DescribeApplicationSlbs(DescribeApplicationSlbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationSlbsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationSlbsResponse> DescribeApplicationSlbsAsync(DescribeApplicationSlbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationSlbsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeApplicationStatusResponse DescribeApplicationStatusWithOptions(DescribeApplicationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeApplicationStatusResponse> DescribeApplicationStatusWithOptionsAsync(DescribeApplicationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeApplicationStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/describeApplicationStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeApplicationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeApplicationStatusResponse DescribeApplicationStatus(DescribeApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeApplicationStatusWithOptions(request, headers, runtime);
        }

        public async Task<DescribeApplicationStatusResponse> DescribeApplicationStatusAsync(DescribeApplicationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeApplicationStatusWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChangeOrderResponse DescribeChangeOrderWithOptions(DescribeChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribeChangeOrder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChangeOrderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeChangeOrderResponse> DescribeChangeOrderWithOptionsAsync(DescribeChangeOrderRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeOrderId))
            {
                query["ChangeOrderId"] = request.ChangeOrderId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeChangeOrder",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribeChangeOrder",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeChangeOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeChangeOrderResponse DescribeChangeOrder(DescribeChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChangeOrderWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChangeOrderResponse> DescribeChangeOrderAsync(DescribeChangeOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChangeOrderWithOptionsAsync(request, headers, runtime);
        }

        public DescribeComponentsResponse DescribeComponentsWithOptions(DescribeComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeComponentsResponse> DescribeComponentsWithOptionsAsync(DescribeComponentsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeComponents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/components",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeComponentsResponse DescribeComponents(DescribeComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeComponentsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeComponentsResponse> DescribeComponentsAsync(DescribeComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeComponentsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeConfigMapResponse DescribeConfigMapWithOptions(DescribeConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeConfigMapResponse> DescribeConfigMapWithOptionsAsync(DescribeConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeConfigMapResponse DescribeConfigMap(DescribeConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<DescribeConfigMapResponse> DescribeConfigMapAsync(DescribeConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigMapWithOptionsAsync(request, headers, runtime);
        }

        public DescribeConfigurationPriceResponse DescribeConfigurationPriceWithOptions(DescribeConfigurationPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigurationPrice",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/configurationPrice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigurationPriceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeConfigurationPriceResponse> DescribeConfigurationPriceWithOptionsAsync(DescribeConfigurationPriceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeConfigurationPrice",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/configurationPrice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeConfigurationPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeConfigurationPriceResponse DescribeConfigurationPrice(DescribeConfigurationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeConfigurationPriceWithOptions(request, headers, runtime);
        }

        public async Task<DescribeConfigurationPriceResponse> DescribeConfigurationPriceAsync(DescribeConfigurationPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeConfigurationPriceWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEdasContainersResponse DescribeEdasContainersWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdasContainers",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/edasContainers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdasContainersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEdasContainersResponse> DescribeEdasContainersWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdasContainers",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/resource/edasContainers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdasContainersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEdasContainersResponse DescribeEdasContainers()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdasContainersWithOptions(headers, runtime);
        }

        public async Task<DescribeEdasContainersResponse> DescribeEdasContainersAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdasContainersWithOptionsAsync(headers, runtime);
        }

        public DescribeGreyTagRouteResponse DescribeGreyTagRouteWithOptions(DescribeGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeGreyTagRouteResponse> DescribeGreyTagRouteWithOptionsAsync(DescribeGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeGreyTagRouteResponse DescribeGreyTagRoute(DescribeGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeGreyTagRouteWithOptions(request, headers, runtime);
        }

        public async Task<DescribeGreyTagRouteResponse> DescribeGreyTagRouteAsync(DescribeGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        public DescribeIngressResponse DescribeIngressWithOptions(DescribeIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIngressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeIngressResponse> DescribeIngressWithOptionsAsync(DescribeIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeIngressResponse DescribeIngress(DescribeIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIngressWithOptions(request, headers, runtime);
        }

        public async Task<DescribeIngressResponse> DescribeIngressAsync(DescribeIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIngressWithOptionsAsync(request, headers, runtime);
        }

        public DescribeInstanceLogResponse DescribeInstanceLogWithOptions(DescribeInstanceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceLog",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/instance/describeInstanceLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceLogResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceLogResponse> DescribeInstanceLogWithOptionsAsync(DescribeInstanceLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceLog",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/instance/describeInstanceLog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceLogResponse DescribeInstanceLog(DescribeInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceLogWithOptions(request, headers, runtime);
        }

        public async Task<DescribeInstanceLogResponse> DescribeInstanceLogAsync(DescribeInstanceLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceLogWithOptionsAsync(request, headers, runtime);
        }

        public DescribeInstanceSpecificationsResponse DescribeInstanceSpecificationsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecifications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/instanceSpecifications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSpecificationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeInstanceSpecificationsResponse> DescribeInstanceSpecificationsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSpecifications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/instanceSpecifications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSpecificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeInstanceSpecificationsResponse DescribeInstanceSpecifications()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeInstanceSpecificationsWithOptions(headers, runtime);
        }

        public async Task<DescribeInstanceSpecificationsResponse> DescribeInstanceSpecificationsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeInstanceSpecificationsWithOptionsAsync(headers, runtime);
        }

        public DescribeJobResponse DescribeJobWithOptions(DescribeJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeJobResponse> DescribeJobWithOptionsAsync(DescribeJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeJobResponse DescribeJob(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobWithOptions(request, headers, runtime);
        }

        public async Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobWithOptionsAsync(request, headers, runtime);
        }

        public DescribeJobHistoryResponse DescribeJobHistoryWithOptions(DescribeJobHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobHistory",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobHistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobHistoryResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeJobHistoryResponse> DescribeJobHistoryWithOptionsAsync(DescribeJobHistoryRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["State"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobHistory",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobHistory",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobHistoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeJobHistoryResponse DescribeJobHistory(DescribeJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobHistoryWithOptions(request, headers, runtime);
        }

        public async Task<DescribeJobHistoryResponse> DescribeJobHistoryAsync(DescribeJobHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobHistoryWithOptionsAsync(request, headers, runtime);
        }

        public DescribeJobStatusResponse DescribeJobStatusWithOptions(DescribeJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeJobStatusResponse> DescribeJobStatusWithOptionsAsync(DescribeJobStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeJobStatus",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/describeJobStatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeJobStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeJobStatusResponse DescribeJobStatus(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeJobStatusWithOptions(request, headers, runtime);
        }

        public async Task<DescribeJobStatusResponse> DescribeJobStatusAsync(DescribeJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeJobStatusWithOptionsAsync(request, headers, runtime);
        }

        public DescribeNamespaceResponse DescribeNamespaceWithOptions(DescribeNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNamespaceResponse> DescribeNamespaceWithOptionsAsync(DescribeNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNamespaceResponse DescribeNamespace(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceWithOptions(request, headers, runtime);
        }

        public async Task<DescribeNamespaceResponse> DescribeNamespaceAsync(DescribeNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceWithOptionsAsync(request, headers, runtime);
        }

        public DescribeNamespaceListResponse DescribeNamespaceListWithOptions(DescribeNamespaceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainCustom))
            {
                query["ContainCustom"] = request.ContainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridCloudExclude))
            {
                query["HybridCloudExclude"] = request.HybridCloudExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceList",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNamespaceListResponse> DescribeNamespaceListWithOptionsAsync(DescribeNamespaceListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainCustom))
            {
                query["ContainCustom"] = request.ContainCustom;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HybridCloudExclude))
            {
                query["HybridCloudExclude"] = request.HybridCloudExclude;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceList",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNamespaceListResponse DescribeNamespaceList(DescribeNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeNamespaceListResponse> DescribeNamespaceListAsync(DescribeNamespaceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeNamespaceResourcesResponse DescribeNamespaceResourcesWithOptions(DescribeNamespaceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResourcesWithOptionsAsync(DescribeNamespaceResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaceResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/describeNamespaceResources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespaceResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNamespaceResourcesResponse DescribeNamespaceResources(DescribeNamespaceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespaceResourcesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResourcesAsync(DescribeNamespaceResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespaceResourcesWithOptionsAsync(request, headers, runtime);
        }

        public DescribeNamespacesResponse DescribeNamespacesWithOptions(DescribeNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNamespacesResponse> DescribeNamespacesWithOptionsAsync(DescribeNamespacesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNamespaces",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNamespacesResponse DescribeNamespaces(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNamespacesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeNamespacesResponse> DescribeNamespacesAsync(DescribeNamespacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNamespacesWithOptionsAsync(request, headers, runtime);
        }

        public DescribePipelineResponse DescribePipelineWithOptions(DescribePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePipeline",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribePipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePipelineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePipelineResponse> DescribePipelineWithOptionsAsync(DescribePipelineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PipelineId))
            {
                query["PipelineId"] = request.PipelineId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePipeline",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/DescribePipeline",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePipelineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePipelineResponse DescribePipeline(DescribePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePipelineWithOptions(request, headers, runtime);
        }

        public async Task<DescribePipelineResponse> DescribePipelineAsync(DescribePipelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePipelineWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/regionConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/regionConfig",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRegionsWithOptions(headers, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRegionsWithOptionsAsync(headers, runtime);
        }

        public DescribeSecretResponse DescribeSecretWithOptions(DescribeSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeSecretResponse> DescribeSecretWithOptionsAsync(DescribeSecretRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSecretWithOptions(request, headers, runtime);
        }

        public async Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSecretWithOptionsAsync(request, headers, runtime);
        }

        public DisableApplicationScalingRuleResponse DisableApplicationScalingRuleWithOptions(DisableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/disableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleWithOptionsAsync(DisableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/disableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DisableApplicationScalingRuleResponse DisableApplicationScalingRule(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<DisableApplicationScalingRuleResponse> DisableApplicationScalingRuleAsync(DisableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public EnableApplicationScalingRuleResponse EnableApplicationScalingRuleWithOptions(EnableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/enableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleWithOptionsAsync(EnableApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/enableApplicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public EnableApplicationScalingRuleResponse EnableApplicationScalingRule(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        public async Task<EnableApplicationScalingRuleResponse> EnableApplicationScalingRuleAsync(EnableApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public ExecJobResponse ExecJobWithOptions(ExecJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/execJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExecJobResponse> ExecJobWithOptionsAsync(ExecJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/execJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExecJobResponse ExecJob(ExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecJobWithOptions(request, headers, runtime);
        }

        public async Task<ExecJobResponse> ExecJobAsync(ExecJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecJobWithOptionsAsync(request, headers, runtime);
        }

        public GetArmsTopNMetricResponse GetArmsTopNMetricWithOptions(GetArmsTopNMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArmsTopNMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getArmsTopNMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArmsTopNMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetArmsTopNMetricResponse> GetArmsTopNMetricWithOptionsAsync(GetArmsTopNMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetArmsTopNMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getArmsTopNMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetArmsTopNMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetArmsTopNMetricResponse GetArmsTopNMetric(GetArmsTopNMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetArmsTopNMetricWithOptions(request, headers, runtime);
        }

        public async Task<GetArmsTopNMetricResponse> GetArmsTopNMetricAsync(GetArmsTopNMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetArmsTopNMetricWithOptionsAsync(request, headers, runtime);
        }

        public GetAvailabilityMetricResponse GetAvailabilityMetricWithOptions(GetAvailabilityMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailabilityMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getAvailabilityMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailabilityMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAvailabilityMetricResponse> GetAvailabilityMetricWithOptionsAsync(GetAvailabilityMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailabilityMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getAvailabilityMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailabilityMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAvailabilityMetricResponse GetAvailabilityMetric(GetAvailabilityMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAvailabilityMetricWithOptions(request, headers, runtime);
        }

        public async Task<GetAvailabilityMetricResponse> GetAvailabilityMetricAsync(GetAvailabilityMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAvailabilityMetricWithOptionsAsync(request, headers, runtime);
        }

        public GetChangeOrderMetricResponse GetChangeOrderMetricWithOptions(GetChangeOrderMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeOrderMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getChangeOrderMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeOrderMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetChangeOrderMetricResponse> GetChangeOrderMetricWithOptionsAsync(GetChangeOrderMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChangeOrderMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getChangeOrderMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChangeOrderMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetChangeOrderMetricResponse GetChangeOrderMetric(GetChangeOrderMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChangeOrderMetricWithOptions(request, headers, runtime);
        }

        public async Task<GetChangeOrderMetricResponse> GetChangeOrderMetricAsync(GetChangeOrderMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChangeOrderMetricWithOptionsAsync(request, headers, runtime);
        }

        public GetScaleAppMetricResponse GetScaleAppMetricWithOptions(GetScaleAppMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScaleAppMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getScaleAppMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScaleAppMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetScaleAppMetricResponse> GetScaleAppMetricWithOptionsAsync(GetScaleAppMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScaleAppMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getScaleAppMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScaleAppMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetScaleAppMetricResponse GetScaleAppMetric(GetScaleAppMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScaleAppMetricWithOptions(request, headers, runtime);
        }

        public async Task<GetScaleAppMetricResponse> GetScaleAppMetricAsync(GetScaleAppMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScaleAppMetricWithOptionsAsync(request, headers, runtime);
        }

        public GetWarningEventMetricResponse GetWarningEventMetricWithOptions(GetWarningEventMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarningEventMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getWarningEventMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarningEventMetricResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetWarningEventMetricResponse> GetWarningEventMetricWithOptionsAsync(GetWarningEventMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetWarningEventMetric",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/getWarningEventMetric",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetWarningEventMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetWarningEventMetricResponse GetWarningEventMetric(GetWarningEventMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetWarningEventMetricWithOptions(request, headers, runtime);
        }

        public async Task<GetWarningEventMetricResponse> GetWarningEventMetricAsync(GetWarningEventMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetWarningEventMetricWithOptionsAsync(request, headers, runtime);
        }

        public ListAppEventsResponse ListAppEventsWithOptions(ListAppEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKind))
            {
                query["ObjectKind"] = request.ObjectKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppEvents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppEvents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppEventsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppEventsResponse> ListAppEventsWithOptionsAsync(ListAppEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectKind))
            {
                query["ObjectKind"] = request.ObjectKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["ObjectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                query["Reason"] = request.Reason;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppEvents",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppEvents",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppEventsResponse ListAppEvents(ListAppEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppEventsWithOptions(request, headers, runtime);
        }

        public async Task<ListAppEventsResponse> ListAppEventsAsync(ListAppEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppEventsWithOptionsAsync(request, headers, runtime);
        }

        public ListAppServicesPageResponse ListAppServicesPageWithOptions(ListAppServicesPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppServicesPage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listAppServicesPage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppServicesPageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppServicesPageResponse> ListAppServicesPageWithOptionsAsync(ListAppServicesPageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceType))
            {
                query["ServiceType"] = request.ServiceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppServicesPage",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listAppServicesPage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppServicesPageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppServicesPageResponse ListAppServicesPage(ListAppServicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppServicesPageWithOptions(request, headers, runtime);
        }

        public async Task<ListAppServicesPageResponse> ListAppServicesPageAsync(ListAppServicesPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppServicesPageWithOptionsAsync(request, headers, runtime);
        }

        public ListAppVersionsResponse ListAppVersionsWithOptions(ListAppVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppVersions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppVersionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListAppVersionsResponse> ListAppVersionsWithOptionsAsync(ListAppVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAppVersions",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listAppVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAppVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListAppVersionsResponse ListAppVersions(ListAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAppVersionsWithOptions(request, headers, runtime);
        }

        public async Task<ListAppVersionsResponse> ListAppVersionsAsync(ListAppVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAppVersionsWithOptionsAsync(request, headers, runtime);
        }

        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listApplications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppSource))
            {
                query["AppSource"] = request.AppSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/listApplications",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListApplicationsWithOptions(request, headers, runtime);
        }

        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListApplicationsWithOptionsAsync(request, headers, runtime);
        }

        public ListChangeOrdersResponse ListChangeOrdersWithOptions(ListChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ListChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChangeOrdersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListChangeOrdersResponse> ListChangeOrdersWithOptionsAsync(ListChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/ListChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChangeOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListChangeOrdersResponse ListChangeOrders(ListChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChangeOrdersWithOptions(request, headers, runtime);
        }

        public async Task<ListChangeOrdersResponse> ListChangeOrdersAsync(ListChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChangeOrdersWithOptionsAsync(request, headers, runtime);
        }

        public ListConsumedServicesResponse ListConsumedServicesWithOptions(ListConsumedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listConsumedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumedServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListConsumedServicesResponse> ListConsumedServicesWithOptionsAsync(ListConsumedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listConsumedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListConsumedServicesResponse ListConsumedServices(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumedServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListConsumedServicesResponse> ListConsumedServicesAsync(ListConsumedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumedServicesWithOptionsAsync(request, headers, runtime);
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request ListGreyTagRouteRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListGreyTagRouteResponse
         */
        public ListGreyTagRouteResponse ListGreyTagRouteWithOptions(ListGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRouteList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request ListGreyTagRouteRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListGreyTagRouteResponse
         */
        public async Task<ListGreyTagRouteResponse> ListGreyTagRouteWithOptionsAsync(ListGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRouteList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request ListGreyTagRouteRequest
          * @return ListGreyTagRouteResponse
         */
        public ListGreyTagRouteResponse ListGreyTagRoute(ListGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGreyTagRouteWithOptions(request, headers, runtime);
        }

        /**
          * >  You can configure only one canary release rule for each application.
          *
          * @param request ListGreyTagRouteRequest
          * @return ListGreyTagRouteResponse
         */
        public async Task<ListGreyTagRouteResponse> ListGreyTagRouteAsync(ListGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        public ListIngressesResponse ListIngressesWithOptions(ListIngressesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIngresses",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/IngressList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIngressesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListIngressesResponse> ListIngressesWithOptionsAsync(ListIngressesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListIngresses",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/IngressList",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListIngressesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListIngressesResponse ListIngresses(ListIngressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListIngressesWithOptions(request, headers, runtime);
        }

        public async Task<ListIngressesResponse> ListIngressesAsync(ListIngressesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListIngressesWithOptionsAsync(request, headers, runtime);
        }

        public ListJobsResponse ListJobsWithOptions(ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/listJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldType))
            {
                query["FieldType"] = request.FieldType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FieldValue))
            {
                query["FieldValue"] = request.FieldValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["Reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Workload))
            {
                query["Workload"] = request.Workload;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/listJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(request, headers, runtime);
        }

        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(request, headers, runtime);
        }

        public ListLogConfigsResponse ListLogConfigsWithOptions(ListLogConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogConfigs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/log/listLogConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogConfigsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListLogConfigsResponse> ListLogConfigsWithOptionsAsync(ListLogConfigsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogConfigs",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/log/listLogConfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListLogConfigsResponse ListLogConfigs(ListLogConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogConfigsWithOptions(request, headers, runtime);
        }

        public async Task<ListLogConfigsResponse> ListLogConfigsAsync(ListLogConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogConfigsWithOptionsAsync(request, headers, runtime);
        }

        public ListNamespaceChangeOrdersResponse ListNamespaceChangeOrdersWithOptions(ListNamespaceChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespaceChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/listNamespaceChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespaceChangeOrdersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListNamespaceChangeOrdersResponse> ListNamespaceChangeOrdersWithOptionsAsync(ListNamespaceChangeOrdersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoStatus))
            {
                query["CoStatus"] = request.CoStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoType))
            {
                query["CoType"] = request.CoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespaceChangeOrders",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/changeorder/listNamespaceChangeOrders",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespaceChangeOrdersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListNamespaceChangeOrdersResponse ListNamespaceChangeOrders(ListNamespaceChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespaceChangeOrdersWithOptions(request, headers, runtime);
        }

        public async Task<ListNamespaceChangeOrdersResponse> ListNamespaceChangeOrdersAsync(ListNamespaceChangeOrdersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespaceChangeOrdersWithOptionsAsync(request, headers, runtime);
        }

        public ListNamespacedConfigMapsResponse ListNamespacedConfigMapsWithOptions(ListNamespacedConfigMapsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespacedConfigMaps",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/listNamespacedConfigMaps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacedConfigMapsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListNamespacedConfigMapsResponse> ListNamespacedConfigMapsWithOptionsAsync(ListNamespacedConfigMapsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNamespacedConfigMaps",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/listNamespacedConfigMaps",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNamespacedConfigMapsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListNamespacedConfigMapsResponse ListNamespacedConfigMaps(ListNamespacedConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListNamespacedConfigMapsWithOptions(request, headers, runtime);
        }

        public async Task<ListNamespacedConfigMapsResponse> ListNamespacedConfigMapsAsync(ListNamespacedConfigMapsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListNamespacedConfigMapsWithOptionsAsync(request, headers, runtime);
        }

        public ListPublishedServicesResponse ListPublishedServicesWithOptions(ListPublishedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listPublishedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedServicesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListPublishedServicesResponse> ListPublishedServicesWithOptionsAsync(ListPublishedServicesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPublishedServices",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/service/listPublishedServices",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPublishedServicesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListPublishedServicesResponse ListPublishedServices(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPublishedServicesWithOptions(request, headers, runtime);
        }

        public async Task<ListPublishedServicesResponse> ListPublishedServicesAsync(ListPublishedServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPublishedServicesWithOptionsAsync(request, headers, runtime);
        }

        public ListSecretsResponse ListSecretsWithOptions(ListSecretsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecrets",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secrets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListSecretsResponse> ListSecretsWithOptionsAsync(ListSecretsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSecrets",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secrets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSecretsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSecretsWithOptions(request, headers, runtime);
        }

        public async Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSecretsWithOptionsAsync(request, headers, runtime);
        }

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
          * > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenSaeServiceResponse
         */
        public OpenSaeServiceResponse OpenSaeServiceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSaeService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/service/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSaeServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenSaeServiceResponse
         */
        public async Task<OpenSaeServiceResponse> OpenSaeServiceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSaeService",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/service/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenSaeServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
          *
          * @return OpenSaeServiceResponse
         */
        public OpenSaeServiceResponse OpenSaeService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenSaeServiceWithOptions(headers, runtime);
        }

        /**
          * > Make sure that your account balance is greater than 0. Otherwise, the SAE service cannot be activated.
          *
          * @return OpenSaeServiceResponse
         */
        public async Task<OpenSaeServiceResponse> OpenSaeServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenSaeServiceWithOptionsAsync(headers, runtime);
        }

        public QueryResourceStaticsResponse QueryResourceStaticsWithOptions(QueryResourceStaticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourceStatics",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/queryResourceStatics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceStaticsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryResourceStaticsResponse> QueryResourceStaticsWithOptionsAsync(QueryResourceStaticsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryResourceStatics",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/quota/queryResourceStatics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryResourceStaticsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryResourceStaticsResponse QueryResourceStatics(QueryResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryResourceStaticsWithOptions(request, headers, runtime);
        }

        public async Task<QueryResourceStaticsResponse> QueryResourceStaticsAsync(QueryResourceStaticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryResourceStaticsWithOptionsAsync(request, headers, runtime);
        }

        public ReduceApplicationCapacityByInstanceIdsResponse ReduceApplicationCapacityByInstanceIdsWithOptions(ReduceApplicationCapacityByInstanceIdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceApplicationCapacityByInstanceIds",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/ScaleInApplicationWithInstanceIds",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceApplicationCapacityByInstanceIdsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ReduceApplicationCapacityByInstanceIdsResponse> ReduceApplicationCapacityByInstanceIdsWithOptionsAsync(ReduceApplicationCapacityByInstanceIdsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ReduceApplicationCapacityByInstanceIds",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/ScaleInApplicationWithInstanceIds",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReduceApplicationCapacityByInstanceIdsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ReduceApplicationCapacityByInstanceIdsResponse ReduceApplicationCapacityByInstanceIds(ReduceApplicationCapacityByInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ReduceApplicationCapacityByInstanceIdsWithOptions(request, headers, runtime);
        }

        public async Task<ReduceApplicationCapacityByInstanceIdsResponse> ReduceApplicationCapacityByInstanceIdsAsync(ReduceApplicationCapacityByInstanceIdsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ReduceApplicationCapacityByInstanceIdsWithOptionsAsync(request, headers, runtime);
        }

        public RescaleApplicationResponse RescaleApplicationWithOptions(RescaleApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RescaleApplicationResponse> RescaleApplicationWithOptionsAsync(RescaleApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RescaleApplicationResponse RescaleApplication(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RescaleApplicationWithOptions(request, headers, runtime);
        }

        public async Task<RescaleApplicationResponse> RescaleApplicationAsync(RescaleApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RescaleApplicationWithOptionsAsync(request, headers, runtime);
        }

        public RescaleApplicationVerticallyResponse RescaleApplicationVerticallyWithOptions(RescaleApplicationVerticallyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplicationVertically",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplicationVertically",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationVerticallyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RescaleApplicationVerticallyResponse> RescaleApplicationVerticallyWithOptionsAsync(RescaleApplicationVerticallyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RescaleApplicationVertically",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rescaleApplicationVertically",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RescaleApplicationVerticallyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RescaleApplicationVerticallyResponse RescaleApplicationVertically(RescaleApplicationVerticallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RescaleApplicationVerticallyWithOptions(request, headers, runtime);
        }

        public async Task<RescaleApplicationVerticallyResponse> RescaleApplicationVerticallyAsync(RescaleApplicationVerticallyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RescaleApplicationVerticallyWithOptionsAsync(request, headers, runtime);
        }

        public RestartApplicationResponse RestartApplicationWithOptions(RestartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartApplicationResponse> RestartApplicationWithOptionsAsync(RestartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartApplicationResponse RestartApplication(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartApplicationWithOptions(request, headers, runtime);
        }

        public async Task<RestartApplicationResponse> RestartApplicationAsync(RestartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartApplicationWithOptionsAsync(request, headers, runtime);
        }

        public RestartInstancesResponse RestartInstancesWithOptions(RestartInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RestartInstancesResponse> RestartInstancesWithOptionsAsync(RestartInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstances",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/restartInstances",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RestartInstancesResponse RestartInstances(RestartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RestartInstancesWithOptions(request, headers, runtime);
        }

        public async Task<RestartInstancesResponse> RestartInstancesAsync(RestartInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RestartInstancesWithOptionsAsync(request, headers, runtime);
        }

        public RollbackApplicationResponse RollbackApplicationWithOptions(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rollbackApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationWithOptionsAsync(RollbackApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoEnableApplicationScalingRule))
            {
                query["AutoEnableApplicationScalingRule"] = request.AutoEnableApplicationScalingRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchWaitTime))
            {
                query["BatchWaitTime"] = request.BatchWaitTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateStrategy))
            {
                query["UpdateStrategy"] = request.UpdateStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RollbackApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/rollbackApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RollbackApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RollbackApplicationResponse RollbackApplication(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RollbackApplicationWithOptions(request, headers, runtime);
        }

        public async Task<RollbackApplicationResponse> RollbackApplicationAsync(RollbackApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RollbackApplicationWithOptionsAsync(request, headers, runtime);
        }

        public StartApplicationResponse StartApplicationWithOptions(StartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/startApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartApplicationResponse> StartApplicationWithOptionsAsync(StartApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/startApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartApplicationResponse StartApplication(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartApplicationWithOptions(request, headers, runtime);
        }

        public async Task<StartApplicationResponse> StartApplicationAsync(StartApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartApplicationWithOptionsAsync(request, headers, runtime);
        }

        public StopApplicationResponse StopApplicationWithOptions(StopApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/stopApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplicationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopApplicationResponse> StopApplicationWithOptionsAsync(StopApplicationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopApplication",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/stopApplication",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StopApplicationResponse StopApplication(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopApplicationWithOptions(request, headers, runtime);
        }

        public async Task<StopApplicationResponse> StopApplicationAsync(StopApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopApplicationWithOptionsAsync(request, headers, runtime);
        }

        public SuspendJobResponse SuspendJobWithOptions(SuspendJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suspend))
            {
                query["Suspend"] = request.Suspend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/suspendJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SuspendJobResponse> SuspendJobWithOptionsAsync(SuspendJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Suspend))
            {
                query["Suspend"] = request.Suspend;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SuspendJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/suspendJob",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SuspendJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SuspendJobResponse SuspendJob(SuspendJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SuspendJobWithOptions(request, headers, runtime);
        }

        public async Task<SuspendJobResponse> SuspendJobAsync(SuspendJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SuspendJobWithOptionsAsync(request, headers, runtime);
        }

        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UnbindSlbResponse UnbindSlbWithOptions(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSlbResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnbindSlbResponse> UnbindSlbWithOptionsAsync(UnbindSlbRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internet))
            {
                query["Internet"] = request.Internet;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Intranet))
            {
                query["Intranet"] = request.Intranet;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnbindSlb",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/slb",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnbindSlbResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UnbindSlbResponse UnbindSlb(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnbindSlbWithOptions(request, headers, runtime);
        }

        public async Task<UnbindSlbResponse> UnbindSlbAsync(UnbindSlbRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnbindSlbWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteAll))
            {
                query["DeleteAll"] = request.DeleteAll;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAppSecurityGroupResponse UpdateAppSecurityGroupWithOptions(UpdateAppSecurityGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppSecurityGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppSecurityGroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppSecurityGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateAppSecurityGroupResponse> UpdateAppSecurityGroupWithOptionsAsync(UpdateAppSecurityGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAppSecurityGroup",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppSecurityGroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAppSecurityGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateAppSecurityGroupResponse UpdateAppSecurityGroup(UpdateAppSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppSecurityGroupWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAppSecurityGroupResponse> UpdateAppSecurityGroupAsync(UpdateAppSecurityGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppSecurityGroupWithOptionsAsync(request, headers, runtime);
        }

        public UpdateApplicationDescriptionResponse UpdateApplicationDescriptionWithOptions(UpdateApplicationDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationDescription",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppDescription",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationDescriptionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionWithOptionsAsync(UpdateApplicationDescriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppDescription))
            {
                query["AppDescription"] = request.AppDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationDescription",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppDescription",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationDescriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateApplicationDescriptionResponse UpdateApplicationDescription(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationDescriptionWithOptions(request, headers, runtime);
        }

        public async Task<UpdateApplicationDescriptionResponse> UpdateApplicationDescriptionAsync(UpdateApplicationDescriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationDescriptionWithOptionsAsync(request, headers, runtime);
        }

        /**
          * ##
          * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
          *
          * @param request UpdateApplicationScalingRuleRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateApplicationScalingRuleResponse
         */
        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRuleWithOptions(UpdateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ##
          * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
          *
          * @param request UpdateApplicationScalingRuleRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateApplicationScalingRuleResponse
         */
        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleWithOptionsAsync(UpdateApplicationScalingRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstanceRatio))
            {
                query["MinReadyInstanceRatio"] = request.MinReadyInstanceRatio;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReadyInstances))
            {
                query["MinReadyInstances"] = request.MinReadyInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleMetric))
            {
                query["ScalingRuleMetric"] = request.ScalingRuleMetric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleTimer))
            {
                query["ScalingRuleTimer"] = request.ScalingRuleTimer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationScalingRule",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/scale/applicationScalingRule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ##
          * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
          *
          * @param request UpdateApplicationScalingRuleRequest
          * @return UpdateApplicationScalingRuleResponse
         */
        public UpdateApplicationScalingRuleResponse UpdateApplicationScalingRule(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationScalingRuleWithOptions(request, headers, runtime);
        }

        /**
          * ##
          * If you want to configure more than 50 instances for an application, you must submit a [ticket](https://workorder.console.aliyun.com/#/ticket/createIndex) to add your account to the whitelist.
          *
          * @param request UpdateApplicationScalingRuleRequest
          * @return UpdateApplicationScalingRuleResponse
         */
        public async Task<UpdateApplicationScalingRuleResponse> UpdateApplicationScalingRuleAsync(UpdateApplicationScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationScalingRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateApplicationVswitchesResponse UpdateApplicationVswitchesWithOptions(UpdateApplicationVswitchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationVswitches",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppVswitches",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationVswitchesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateApplicationVswitchesResponse> UpdateApplicationVswitchesWithOptionsAsync(UpdateApplicationVswitchesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationVswitches",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/app/updateAppVswitches",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationVswitchesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateApplicationVswitchesResponse UpdateApplicationVswitches(UpdateApplicationVswitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateApplicationVswitchesWithOptions(request, headers, runtime);
        }

        public async Task<UpdateApplicationVswitchesResponse> UpdateApplicationVswitchesAsync(UpdateApplicationVswitchesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateApplicationVswitchesWithOptionsAsync(request, headers, runtime);
        }

        public UpdateConfigMapResponse UpdateConfigMapWithOptions(UpdateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigMapResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateConfigMapResponse> UpdateConfigMapWithOptionsAsync(UpdateConfigMapRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapId))
            {
                query["ConfigMapId"] = request.ConfigMapId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfigMap",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/configmap/configMap",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConfigMapResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateConfigMapResponse UpdateConfigMap(UpdateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigMapWithOptions(request, headers, runtime);
        }

        public async Task<UpdateConfigMapResponse> UpdateConfigMapAsync(UpdateConfigMapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigMapWithOptionsAsync(request, headers, runtime);
        }

        public UpdateGreyTagRouteResponse UpdateGreyTagRouteWithOptions(UpdateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGreyTagRouteResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateGreyTagRouteResponse> UpdateGreyTagRouteWithOptionsAsync(UpdateGreyTagRouteRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlbRules))
            {
                query["AlbRules"] = request.AlbRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DubboRules))
            {
                query["DubboRules"] = request.DubboRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GreyTagRouteId))
            {
                query["GreyTagRouteId"] = request.GreyTagRouteId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScRules))
            {
                query["ScRules"] = request.ScRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGreyTagRoute",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/tagroute/greyTagRoute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGreyTagRouteResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateGreyTagRouteResponse UpdateGreyTagRoute(UpdateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGreyTagRouteWithOptions(request, headers, runtime);
        }

        public async Task<UpdateGreyTagRouteResponse> UpdateGreyTagRouteAsync(UpdateGreyTagRouteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGreyTagRouteWithOptionsAsync(request, headers, runtime);
        }

        public UpdateIngressResponse UpdateIngressWithOptions(UpdateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIngressResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateIngressResponse> UpdateIngressWithOptionsAsync(UpdateIngressRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertId))
            {
                query["CertId"] = request.CertId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CertIds))
            {
                query["CertIds"] = request.CertIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultRule))
            {
                query["DefaultRule"] = request.DefaultRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressId))
            {
                query["IngressId"] = request.IngressId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerPort))
            {
                query["ListenerPort"] = request.ListenerPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerProtocol))
            {
                query["ListenerProtocol"] = request.ListenerProtocol;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalanceType))
            {
                query["LoadBalanceType"] = request.LoadBalanceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rules))
            {
                body["Rules"] = request.Rules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIngress",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/ingress/Ingress",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateIngressResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateIngressResponse UpdateIngress(UpdateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIngressWithOptions(request, headers, runtime);
        }

        public async Task<UpdateIngressResponse> UpdateIngressAsync(UpdateIngressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIngressWithOptionsAsync(request, headers, runtime);
        }

        public UpdateJobResponse UpdateJobWithOptions(UpdateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/updateJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(UpdateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrAssumeRoleArn))
            {
                query["AcrAssumeRoleArn"] = request.AcrAssumeRoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackoffLimit))
            {
                query["BackoffLimit"] = request.BackoffLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommandArgs))
            {
                query["CommandArgs"] = request.CommandArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConcurrencyPolicy))
            {
                query["ConcurrencyPolicy"] = request.ConcurrencyPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomHostAlias))
            {
                query["CustomHostAlias"] = request.CustomHostAlias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EdasContainerVersion))
            {
                query["EdasContainerVersion"] = request.EdasContainerVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Envs))
            {
                query["Envs"] = request.Envs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagePullSecrets))
            {
                query["ImagePullSecrets"] = request.ImagePullSecrets;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                query["ImageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartArgs))
            {
                query["JarStartArgs"] = request.JarStartArgs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JarStartOptions))
            {
                query["JarStartOptions"] = request.JarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Jdk))
            {
                query["Jdk"] = request.Jdk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountDesc))
            {
                query["MountDesc"] = request.MountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MountHost))
            {
                query["MountHost"] = request.MountHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NasId))
            {
                query["NasId"] = request.NasId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageUrl))
            {
                query["PackageUrl"] = request.PackageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackageVersion))
            {
                query["PackageVersion"] = request.PackageVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfigLocation))
            {
                query["PhpConfigLocation"] = request.PhpConfigLocation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PostStart))
            {
                query["PostStart"] = request.PostStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PreStop))
            {
                query["PreStop"] = request.PreStop;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProgrammingLanguage))
            {
                query["ProgrammingLanguage"] = request.ProgrammingLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Python))
            {
                query["Python"] = request.Python;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PythonModules))
            {
                query["PythonModules"] = request.PythonModules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RefAppId))
            {
                query["RefAppId"] = request.RefAppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Slice))
            {
                query["Slice"] = request.Slice;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SliceEnvs))
            {
                query["SliceEnvs"] = request.SliceEnvs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsConfigs))
            {
                query["SlsConfigs"] = request.SlsConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                query["Timeout"] = request.Timeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["Timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TomcatConfig))
            {
                query["TomcatConfig"] = request.TomcatConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                query["TriggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WarStartOptions))
            {
                query["WarStartOptions"] = request.WarStartOptions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebContainer))
            {
                query["WebContainer"] = request.WebContainer;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrInstanceId))
            {
                body["AcrInstanceId"] = request.AcrInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigMapMountDesc))
            {
                body["ConfigMapMountDesc"] = request.ConfigMapMountDesc;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableImageAccl))
            {
                body["EnableImageAccl"] = request.EnableImageAccl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkId))
            {
                body["OssAkId"] = request.OssAkId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssAkSecret))
            {
                body["OssAkSecret"] = request.OssAkSecret;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssMountDescs))
            {
                body["OssMountDescs"] = request.OssMountDescs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Php))
            {
                body["Php"] = request.Php;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhpConfig))
            {
                body["PhpConfig"] = request.PhpConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateJob",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/job/updateJob",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateJobWithOptions(request, headers, runtime);
        }

        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateJobWithOptionsAsync(request, headers, runtime);
        }

        public UpdateNamespaceResponse UpdateNamespaceWithOptions(UpdateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateNamespaceResponse> UpdateNamespaceWithOptionsAsync(UpdateNamespaceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMicroRegistration))
            {
                query["EnableMicroRegistration"] = request.EnableMicroRegistration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceDescription))
            {
                query["NamespaceDescription"] = request.NamespaceDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceName))
            {
                query["NamespaceName"] = request.NamespaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespace",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/paas/namespace",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceWithOptions(request, headers, runtime);
        }

        public async Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceWithOptionsAsync(request, headers, runtime);
        }

        public UpdateNamespaceVpcResponse UpdateNamespaceVpcWithOptions(UpdateNamespaceVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespaceVpc",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/updateNamespaceVpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceVpcResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateNamespaceVpcResponse> UpdateNamespaceVpcWithOptionsAsync(UpdateNamespaceVpcRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NameSpaceShortId))
            {
                query["NameSpaceShortId"] = request.NameSpaceShortId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNamespaceVpc",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/namespace/updateNamespaceVpc",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNamespaceVpcResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateNamespaceVpcResponse UpdateNamespaceVpc(UpdateNamespaceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateNamespaceVpcWithOptions(request, headers, runtime);
        }

        public async Task<UpdateNamespaceVpcResponse> UpdateNamespaceVpcAsync(UpdateNamespaceVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateNamespaceVpcWithOptionsAsync(request, headers, runtime);
        }

        public UpdateSecretResponse UpdateSecretWithOptions(UpdateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSecretShrinkRequest request = new UpdateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecretResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateSecretResponse> UpdateSecretWithOptionsAsync(UpdateSecretRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSecretShrinkRequest request = new UpdateSecretShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SecretData))
            {
                request.SecretDataShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SecretData, "SecretData", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespaceId))
            {
                query["NamespaceId"] = request.NamespaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretDataShrink))
            {
                query["SecretData"] = request.SecretDataShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretId))
            {
                query["SecretId"] = request.SecretId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSecret",
                Version = "2019-05-06",
                Protocol = "HTTPS",
                Pathname = "/pop/v1/sam/secret/secret",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSecretResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSecretWithOptions(request, headers, runtime);
        }

        public async Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSecretWithOptionsAsync(request, headers, runtime);
        }

    }
}
