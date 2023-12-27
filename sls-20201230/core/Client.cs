// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Sls20201230.Models;

namespace AlibabaCloud.SDK.Sls20201230
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {
        protected AlibabaCloud.GatewaySpi.Client _client;

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._client = new AlibabaCloud.GatewaySls.Client();
            this._spi = _client;
            this._endpointRule = "central";
        }


        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ApplyConfigToMachineGroupResponse
         */
        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroupWithOptions(string project, string machineGroup, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyConfigToMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/configs/" + configName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ApplyConfigToMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ApplyConfigToMachineGroupResponse
         */
        public async Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroupWithOptionsAsync(string project, string machineGroup, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyConfigToMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/configs/" + configName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ApplyConfigToMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return ApplyConfigToMachineGroupResponse
         */
        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroup(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyConfigToMachineGroupWithOptions(project, machineGroup, configName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return ApplyConfigToMachineGroupResponse
         */
        public async Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroupAsync(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyConfigToMachineGroupWithOptionsAsync(project, machineGroup, configName, headers, runtime);
        }

        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(string project, ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/resourcegroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(Execute(params_, req, runtime));
        }

        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(string project, ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/resourcegroup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ChangeResourceGroupResponse ChangeResourceGroup(string project, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(project, request, headers, runtime);
        }

        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(string project, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(project, request, headers, runtime);
        }

        public ConsumerGroupHeartBeatResponse ConsumerGroupHeartBeatWithOptions(string project, string logstore, string consumerGroup, ConsumerGroupHeartBeatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Consumer))
            {
                query["consumer"] = request.Consumer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConsumerGroupHeartBeat",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup + "?type=heartbeat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ConsumerGroupHeartBeatResponse>(Execute(params_, req, runtime));
        }

        public async Task<ConsumerGroupHeartBeatResponse> ConsumerGroupHeartBeatWithOptionsAsync(string project, string logstore, string consumerGroup, ConsumerGroupHeartBeatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Consumer))
            {
                query["consumer"] = request.Consumer;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConsumerGroupHeartBeat",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup + "?type=heartbeat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ConsumerGroupHeartBeatResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ConsumerGroupHeartBeatResponse ConsumerGroupHeartBeat(string project, string logstore, string consumerGroup, ConsumerGroupHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConsumerGroupHeartBeatWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        public async Task<ConsumerGroupHeartBeatResponse> ConsumerGroupHeartBeatAsync(string project, string logstore, string consumerGroup, ConsumerGroupHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConsumerGroupHeartBeatWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

        public CreateAnnotationDataSetResponse CreateAnnotationDataSetWithOptions(CreateAnnotationDataSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["datasetId"] = request.DatasetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAnnotationDataSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateAnnotationDataSetResponse> CreateAnnotationDataSetWithOptionsAsync(CreateAnnotationDataSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatasetId))
            {
                query["datasetId"] = request.DatasetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAnnotationDataSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateAnnotationDataSetResponse CreateAnnotationDataSet(CreateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAnnotationDataSetWithOptions(request, headers, runtime);
        }

        public async Task<CreateAnnotationDataSetResponse> CreateAnnotationDataSetAsync(CreateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAnnotationDataSetWithOptionsAsync(request, headers, runtime);
        }

        public CreateAnnotationLabelResponse CreateAnnotationLabelWithOptions(CreateAnnotationLabelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAnnotationLabelResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateAnnotationLabelResponse> CreateAnnotationLabelWithOptionsAsync(CreateAnnotationLabelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAnnotationLabelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateAnnotationLabelResponse CreateAnnotationLabel(CreateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAnnotationLabelWithOptions(request, headers, runtime);
        }

        public async Task<CreateAnnotationLabelResponse> CreateAnnotationLabelAsync(CreateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAnnotationLabelWithOptionsAsync(request, headers, runtime);
        }

        public CreateConfigResponse CreateConfigWithOptions(string project, CreateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateConfigResponse> CreateConfigWithOptionsAsync(string project, CreateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateConfigResponse CreateConfig(string project, CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateConfigResponse> CreateConfigAsync(string project, CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   You can create up to 30 consumer groups for a Logstore.
          * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](~~120035~~) and [Use consumer groups to consume data](~~28998~~).
          *
          * @param request CreateConsumerGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConsumerGroupResponse
         */
        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(string project, string logstore, CreateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroup))
            {
                body["consumerGroup"] = request.ConsumerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   You can create up to 30 consumer groups for a Logstore.
          * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](~~120035~~) and [Use consumer groups to consume data](~~28998~~).
          *
          * @param request CreateConsumerGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConsumerGroupResponse
         */
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(string project, string logstore, CreateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroup))
            {
                body["consumerGroup"] = request.ConsumerGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   You can create up to 30 consumer groups for a Logstore.
          * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](~~120035~~) and [Use consumer groups to consume data](~~28998~~).
          *
          * @param request CreateConsumerGroupRequest
          * @return CreateConsumerGroupResponse
         */
        public CreateConsumerGroupResponse CreateConsumerGroup(string project, string logstore, CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConsumerGroupWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   You can create up to 30 consumer groups for a Logstore.
          * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](~~120035~~) and [Use consumer groups to consume data](~~28998~~).
          *
          * @param request CreateConsumerGroupRequest
          * @return CreateConsumerGroupResponse
         */
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(string project, string logstore, CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConsumerGroupWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        public CreateDashboardResponse CreateDashboardWithOptions(string project, CreateDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDashboardResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateDashboardResponse> CreateDashboardWithOptionsAsync(string project, CreateDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDashboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateDashboardResponse CreateDashboard(string project, CreateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDashboardWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateDashboardResponse> CreateDashboardAsync(string project, CreateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDashboardWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateDomainRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomainWithOptions(string project, CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDomainResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateDomainRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainWithOptionsAsync(string project, CreateDomainRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                body["domainName"] = request.DomainName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDomain",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/domains",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDomainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateDomainRequest
          * @return CreateDomainResponse
         */
        public CreateDomainResponse CreateDomain(string project, CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDomainWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateDomainRequest
          * @return CreateDomainResponse
         */
        public async Task<CreateDomainResponse> CreateDomainAsync(string project, CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDomainWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateIndexResponse
         */
        public CreateIndexResponse CreateIndexWithOptions(string project, string logstore, CreateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                body["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduce))
            {
                body["log_reduce"] = request.LogReduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceBlackList))
            {
                body["log_reduce_black_list"] = request.LogReduceBlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceWhiteList))
            {
                body["log_reduce_white_list"] = request.LogReduceWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTextLen))
            {
                body["max_text_len"] = request.MaxTextLen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateIndexResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateIndexResponse
         */
        public async Task<CreateIndexResponse> CreateIndexWithOptionsAsync(string project, string logstore, CreateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                body["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduce))
            {
                body["log_reduce"] = request.LogReduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceBlackList))
            {
                body["log_reduce_black_list"] = request.LogReduceBlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceWhiteList))
            {
                body["log_reduce_white_list"] = request.LogReduceWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTextLen))
            {
                body["max_text_len"] = request.MaxTextLen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateIndexResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateIndexRequest
          * @return CreateIndexResponse
         */
        public CreateIndexResponse CreateIndex(string project, string logstore, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateIndexRequest
          * @return CreateIndexResponse
         */
        public async Task<CreateIndexResponse> CreateIndexAsync(string project, string logstore, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLogStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateLogStoreResponse
         */
        public CreateLogStoreResponse CreateLogStoreWithOptions(string project, CreateLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendMeta))
            {
                body["appendMeta"] = request.AppendMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSplit))
            {
                body["autoSplit"] = request.AutoSplit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTracking))
            {
                body["enable_tracking"] = request.EnableTracking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf))
            {
                body["encrypt_conf"] = request.EncryptConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTtl))
            {
                body["hot_ttl"] = request.HotTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                body["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSplitShard))
            {
                body["maxSplitShard"] = request.MaxSplitShard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardCount))
            {
                body["shardCount"] = request.ShardCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryType))
            {
                body["telemetryType"] = request.TelemetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateLogStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLogStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateLogStoreResponse
         */
        public async Task<CreateLogStoreResponse> CreateLogStoreWithOptionsAsync(string project, CreateLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendMeta))
            {
                body["appendMeta"] = request.AppendMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSplit))
            {
                body["autoSplit"] = request.AutoSplit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTracking))
            {
                body["enable_tracking"] = request.EnableTracking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf))
            {
                body["encrypt_conf"] = request.EncryptConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTtl))
            {
                body["hot_ttl"] = request.HotTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                body["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSplitShard))
            {
                body["maxSplitShard"] = request.MaxSplitShard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardCount))
            {
                body["shardCount"] = request.ShardCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryType))
            {
                body["telemetryType"] = request.TelemetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateLogStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLogStoreRequest
          * @return CreateLogStoreResponse
         */
        public CreateLogStoreResponse CreateLogStore(string project, CreateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLogStoreWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLogStoreRequest
          * @return CreateLogStoreResponse
         */
        public async Task<CreateLogStoreResponse> CreateLogStoreAsync(string project, CreateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLogStoreWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLoggingRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateLoggingResponse
         */
        public CreateLoggingResponse CreateLoggingWithOptions(string project, CreateLoggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingDetails))
            {
                body["loggingDetails"] = request.LoggingDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingProject))
            {
                body["loggingProject"] = request.LoggingProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateLoggingResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLoggingRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateLoggingResponse
         */
        public async Task<CreateLoggingResponse> CreateLoggingWithOptionsAsync(string project, CreateLoggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingDetails))
            {
                body["loggingDetails"] = request.LoggingDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingProject))
            {
                body["loggingProject"] = request.LoggingProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLoggingRequest
          * @return CreateLoggingResponse
         */
        public CreateLoggingResponse CreateLogging(string project, CreateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLoggingWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateLoggingRequest
          * @return CreateLoggingResponse
         */
        public async Task<CreateLoggingResponse> CreateLoggingAsync(string project, CreateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLoggingWithOptionsAsync(project, request, headers, runtime);
        }

        public CreateLogtailPipelineConfigResponse CreateLogtailPipelineConfigWithOptions(string project, CreateLogtailPipelineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregators))
            {
                body["aggregators"] = request.Aggregators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                body["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flushers))
            {
                body["flushers"] = request.Flushers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Global))
            {
                body["global"] = request.Global;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                body["inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSample))
            {
                body["logSample"] = request.LogSample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateLogtailPipelineConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateLogtailPipelineConfigResponse> CreateLogtailPipelineConfigWithOptionsAsync(string project, CreateLogtailPipelineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregators))
            {
                body["aggregators"] = request.Aggregators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                body["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flushers))
            {
                body["flushers"] = request.Flushers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Global))
            {
                body["global"] = request.Global;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                body["inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSample))
            {
                body["logSample"] = request.LogSample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateLogtailPipelineConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateLogtailPipelineConfigResponse CreateLogtailPipelineConfig(string project, CreateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLogtailPipelineConfigWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateLogtailPipelineConfigResponse> CreateLogtailPipelineConfigAsync(string project, CreateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLogtailPipelineConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateMachineGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMachineGroupResponse
         */
        public CreateMachineGroupResponse CreateMachineGroupWithOptions(string project, CreateMachineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAttribute))
            {
                body["groupAttribute"] = request.GroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineIdentifyType))
            {
                body["machineIdentifyType"] = request.MachineIdentifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineList))
            {
                body["machineList"] = request.MachineList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateMachineGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateMachineGroupResponse
         */
        public async Task<CreateMachineGroupResponse> CreateMachineGroupWithOptionsAsync(string project, CreateMachineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAttribute))
            {
                body["groupAttribute"] = request.GroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineIdentifyType))
            {
                body["machineIdentifyType"] = request.MachineIdentifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineList))
            {
                body["machineList"] = request.MachineList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateMachineGroupRequest
          * @return CreateMachineGroupResponse
         */
        public CreateMachineGroupResponse CreateMachineGroup(string project, CreateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMachineGroupWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateMachineGroupRequest
          * @return CreateMachineGroupResponse
         */
        public async Task<CreateMachineGroupResponse> CreateMachineGroupAsync(string project, CreateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMachineGroupWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateOssExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateOssExternalStoreResponse
         */
        public CreateOssExternalStoreResponse CreateOssExternalStoreWithOptions(string project, CreateOssExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOssExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateOssExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateOssExternalStoreResponse
         */
        public async Task<CreateOssExternalStoreResponse> CreateOssExternalStoreWithOptionsAsync(string project, CreateOssExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOssExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateOssExternalStoreRequest
          * @return CreateOssExternalStoreResponse
         */
        public CreateOssExternalStoreResponse CreateOssExternalStore(string project, CreateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOssExternalStoreWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateOssExternalStoreRequest
          * @return CreateOssExternalStoreResponse
         */
        public async Task<CreateOssExternalStoreResponse> CreateOssExternalStoreAsync(string project, CreateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOssExternalStoreWithOptionsAsync(project, request, headers, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRedundancyType))
            {
                body["dataRedundancyType"] = request.DataRedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateProjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataRedundancyType))
            {
                body["dataRedundancyType"] = request.DataRedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                body["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateRdsExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRdsExternalStoreResponse
         */
        public CreateRdsExternalStoreResponse CreateRdsExternalStoreWithOptions(string project, CreateRdsExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRdsExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateRdsExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateRdsExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRdsExternalStoreResponse
         */
        public async Task<CreateRdsExternalStoreResponse> CreateRdsExternalStoreWithOptionsAsync(string project, CreateRdsExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRdsExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateRdsExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateRdsExternalStoreRequest
          * @return CreateRdsExternalStoreResponse
         */
        public CreateRdsExternalStoreResponse CreateRdsExternalStore(string project, CreateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRdsExternalStoreWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateRdsExternalStoreRequest
          * @return CreateRdsExternalStoreResponse
         */
        public async Task<CreateRdsExternalStoreResponse> CreateRdsExternalStoreAsync(string project, CreateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRdsExternalStoreWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateSavedSearchRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSavedSearchResponse
         */
        public CreateSavedSearchResponse CreateSavedSearchWithOptions(string project, CreateSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                body["logstore"] = request.Logstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SavedsearchName))
            {
                body["savedsearchName"] = request.SavedsearchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateSavedSearchResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateSavedSearchRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateSavedSearchResponse
         */
        public async Task<CreateSavedSearchResponse> CreateSavedSearchWithOptionsAsync(string project, CreateSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                body["logstore"] = request.Logstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SavedsearchName))
            {
                body["savedsearchName"] = request.SavedsearchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateSavedSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateSavedSearchRequest
          * @return CreateSavedSearchResponse
         */
        public CreateSavedSearchResponse CreateSavedSearch(string project, CreateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSavedSearchWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request CreateSavedSearchRequest
          * @return CreateSavedSearchResponse
         */
        public async Task<CreateSavedSearchResponse> CreateSavedSearchAsync(string project, CreateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSavedSearchWithOptionsAsync(project, request, headers, runtime);
        }

        public DeleteAnnotationDataResponse DeleteAnnotationDataWithOptions(string datasetId, string annotationdataId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata/" + annotationdataId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAnnotationDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteAnnotationDataResponse> DeleteAnnotationDataWithOptionsAsync(string datasetId, string annotationdataId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata/" + annotationdataId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAnnotationDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteAnnotationDataResponse DeleteAnnotationData(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAnnotationDataWithOptions(datasetId, annotationdataId, headers, runtime);
        }

        public async Task<DeleteAnnotationDataResponse> DeleteAnnotationDataAsync(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAnnotationDataWithOptionsAsync(datasetId, annotationdataId, headers, runtime);
        }

        public DeleteAnnotationDataSetResponse DeleteAnnotationDataSetWithOptions(string datasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAnnotationDataSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteAnnotationDataSetResponse> DeleteAnnotationDataSetWithOptionsAsync(string datasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAnnotationDataSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteAnnotationDataSetResponse DeleteAnnotationDataSet(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAnnotationDataSetWithOptions(datasetId, headers, runtime);
        }

        public async Task<DeleteAnnotationDataSetResponse> DeleteAnnotationDataSetAsync(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAnnotationDataSetWithOptionsAsync(datasetId, headers, runtime);
        }

        public DeleteAnnotationLabelResponse DeleteAnnotationLabelWithOptions(string labelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel/" + labelId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAnnotationLabelResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteAnnotationLabelResponse> DeleteAnnotationLabelWithOptionsAsync(string labelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel/" + labelId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAnnotationLabelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteAnnotationLabelResponse DeleteAnnotationLabel(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAnnotationLabelWithOptions(labelId, headers, runtime);
        }

        public async Task<DeleteAnnotationLabelResponse> DeleteAnnotationLabelAsync(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAnnotationLabelWithOptionsAsync(labelId, headers, runtime);
        }

        public DeleteCollectionPolicyResponse DeleteCollectionPolicyWithOptions(string policyName, DeleteCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCollectionPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy/" + policyName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCollectionPolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteCollectionPolicyResponse> DeleteCollectionPolicyWithOptionsAsync(string policyName, DeleteCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCollectionPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy/" + policyName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCollectionPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteCollectionPolicyResponse DeleteCollectionPolicy(string policyName, DeleteCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCollectionPolicyWithOptions(policyName, request, headers, runtime);
        }

        public async Task<DeleteCollectionPolicyResponse> DeleteCollectionPolicyAsync(string policyName, DeleteCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCollectionPolicyWithOptionsAsync(policyName, request, headers, runtime);
        }

        public DeleteConfigResponse DeleteConfigWithOptions(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteConfigResponse> DeleteConfigWithOptionsAsync(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteConfigResponse DeleteConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigWithOptions(project, configName, headers, runtime);
        }

        public async Task<DeleteConfigResponse> DeleteConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConsumerGroupResponse
         */
        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(string project, string logstore, string consumerGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(string project, string logstore, string consumerGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteConsumerGroupResponse
         */
        public DeleteConsumerGroupResponse DeleteConsumerGroup(string project, string logstore, string consumerGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConsumerGroupWithOptions(project, logstore, consumerGroup, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(string project, string logstore, string consumerGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerGroupWithOptionsAsync(project, logstore, consumerGroup, headers, runtime);
        }

        public DeleteDashboardResponse DeleteDashboardWithOptions(string project, string dashboardName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards/" + dashboardName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteDashboardResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteDashboardResponse> DeleteDashboardWithOptionsAsync(string project, string dashboardName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards/" + dashboardName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteDashboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteDashboardResponse DeleteDashboard(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDashboardWithOptions(project, dashboardName, headers, runtime);
        }

        public async Task<DeleteDashboardResponse> DeleteDashboardAsync(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDashboardWithOptionsAsync(project, dashboardName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomainWithOptions(string project, string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/domains/" + domainName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainWithOptionsAsync(string project, string domainName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDomain",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/domains/" + domainName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteDomainResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteDomainResponse
         */
        public DeleteDomainResponse DeleteDomain(string project, string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDomainWithOptions(project, domainName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteDomainResponse
         */
        public async Task<DeleteDomainResponse> DeleteDomainAsync(string project, string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDomainWithOptionsAsync(project, domainName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteExternalStoreResponse
         */
        public DeleteExternalStoreResponse DeleteExternalStoreWithOptions(string project, string externalStoreName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteExternalStoreResponse
         */
        public async Task<DeleteExternalStoreResponse> DeleteExternalStoreWithOptionsAsync(string project, string externalStoreName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteExternalStoreResponse
         */
        public DeleteExternalStoreResponse DeleteExternalStore(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExternalStoreWithOptions(project, externalStoreName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteExternalStoreResponse
         */
        public async Task<DeleteExternalStoreResponse> DeleteExternalStoreAsync(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExternalStoreWithOptionsAsync(project, externalStoreName, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteIndexResponse
         */
        public DeleteIndexResponse DeleteIndexWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteIndexResponse
         */
        public async Task<DeleteIndexResponse> DeleteIndexWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteIndexResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteIndexResponse
         */
        public DeleteIndexResponse DeleteIndex(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexWithOptions(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteIndexResponse
         */
        public async Task<DeleteIndexResponse> DeleteIndexAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteLogStoreResponse
         */
        public DeleteLogStoreResponse DeleteLogStoreWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLogStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteLogStoreResponse
         */
        public async Task<DeleteLogStoreResponse> DeleteLogStoreWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLogStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteLogStoreResponse
         */
        public DeleteLogStoreResponse DeleteLogStore(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLogStoreWithOptions(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteLogStoreResponse
         */
        public async Task<DeleteLogStoreResponse> DeleteLogStoreAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLogStoreWithOptionsAsync(project, logstore, headers, runtime);
        }

        public DeleteLoggingResponse DeleteLoggingWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLoggingResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteLoggingResponse> DeleteLoggingWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteLoggingResponse DeleteLogging(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLoggingWithOptions(project, headers, runtime);
        }

        public async Task<DeleteLoggingResponse> DeleteLoggingAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLoggingWithOptionsAsync(project, headers, runtime);
        }

        public DeleteLogtailPipelineConfigResponse DeleteLogtailPipelineConfigWithOptions(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs/" + configName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLogtailPipelineConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteLogtailPipelineConfigResponse> DeleteLogtailPipelineConfigWithOptionsAsync(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs/" + configName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteLogtailPipelineConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteLogtailPipelineConfigResponse DeleteLogtailPipelineConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLogtailPipelineConfigWithOptions(project, configName, headers, runtime);
        }

        public async Task<DeleteLogtailPipelineConfigResponse> DeleteLogtailPipelineConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLogtailPipelineConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMachineGroupResponse
         */
        public DeleteMachineGroupResponse DeleteMachineGroupWithOptions(string project, string machineGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteMachineGroupResponse
         */
        public async Task<DeleteMachineGroupResponse> DeleteMachineGroupWithOptionsAsync(string project, string machineGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteMachineGroupResponse
         */
        public DeleteMachineGroupResponse DeleteMachineGroup(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMachineGroupWithOptions(project, machineGroup, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteMachineGroupResponse
         */
        public async Task<DeleteMachineGroupResponse> DeleteMachineGroupAsync(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMachineGroupWithOptionsAsync(project, machineGroup, headers, runtime);
        }

        public DeleteProjectResponse DeleteProjectWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(Execute(params_, req, runtime));
        }

        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteProjectResponse DeleteProject(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(project, headers, runtime);
        }

        public async Task<DeleteProjectResponse> DeleteProjectAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteProjectPolicyResponse
         */
        public DeleteProjectPolicyResponse DeleteProjectPolicyWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProjectPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/policy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteProjectPolicyResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteProjectPolicyResponse
         */
        public async Task<DeleteProjectPolicyResponse> DeleteProjectPolicyWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProjectPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/policy",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteProjectPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteProjectPolicyResponse
         */
        public DeleteProjectPolicyResponse DeleteProjectPolicy(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectPolicyWithOptions(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteProjectPolicyResponse
         */
        public async Task<DeleteProjectPolicyResponse> DeleteProjectPolicyAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectPolicyWithOptionsAsync(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSavedSearchResponse
         */
        public DeleteSavedSearchResponse DeleteSavedSearchWithOptions(string project, string savedsearchName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches/" + savedsearchName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteSavedSearchResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSavedSearchResponse
         */
        public async Task<DeleteSavedSearchResponse> DeleteSavedSearchWithOptionsAsync(string project, string savedsearchName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches/" + savedsearchName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteSavedSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteSavedSearchResponse
         */
        public DeleteSavedSearchResponse DeleteSavedSearch(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSavedSearchWithOptions(project, savedsearchName, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteSavedSearchResponse
         */
        public async Task<DeleteSavedSearchResponse> DeleteSavedSearchAsync(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSavedSearchWithOptionsAsync(project, savedsearchName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteShipperResponse
         */
        public DeleteShipperResponse DeleteShipperWithOptions(string project, string logstore, string shipperName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteShipperResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteShipperResponse
         */
        public async Task<DeleteShipperResponse> DeleteShipperWithOptionsAsync(string project, string logstore, string shipperName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteShipperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteShipperResponse
         */
        public DeleteShipperResponse DeleteShipper(string project, string logstore, string shipperName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteShipperWithOptions(project, logstore, shipperName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return DeleteShipperResponse
         */
        public async Task<DeleteShipperResponse> DeleteShipperAsync(string project, string logstore, string shipperName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteShipperWithOptionsAsync(project, logstore, shipperName, headers, runtime);
        }

        public GetAnnotationDataResponse GetAnnotationDataWithOptions(string datasetId, string annotationdataId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata/" + annotationdataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetAnnotationDataResponse> GetAnnotationDataWithOptionsAsync(string datasetId, string annotationdataId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata/" + annotationdataId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetAnnotationDataResponse GetAnnotationData(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAnnotationDataWithOptions(datasetId, annotationdataId, headers, runtime);
        }

        public async Task<GetAnnotationDataResponse> GetAnnotationDataAsync(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAnnotationDataWithOptionsAsync(datasetId, annotationdataId, headers, runtime);
        }

        public GetAnnotationDataSetResponse GetAnnotationDataSetWithOptions(string datasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationDataSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetAnnotationDataSetResponse> GetAnnotationDataSetWithOptionsAsync(string datasetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationDataSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetAnnotationDataSetResponse GetAnnotationDataSet(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAnnotationDataSetWithOptions(datasetId, headers, runtime);
        }

        public async Task<GetAnnotationDataSetResponse> GetAnnotationDataSetAsync(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAnnotationDataSetWithOptionsAsync(datasetId, headers, runtime);
        }

        public GetAnnotationLabelResponse GetAnnotationLabelWithOptions(string labelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel/" + labelId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationLabelResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetAnnotationLabelResponse> GetAnnotationLabelWithOptionsAsync(string labelId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel/" + labelId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAnnotationLabelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetAnnotationLabelResponse GetAnnotationLabel(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAnnotationLabelWithOptions(labelId, headers, runtime);
        }

        public async Task<GetAnnotationLabelResponse> GetAnnotationLabelAsync(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAnnotationLabelWithOptionsAsync(labelId, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAppliedConfigsResponse
         */
        public GetAppliedConfigsResponse GetAppliedConfigsWithOptions(string project, string machineGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppliedConfigs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppliedConfigsResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAppliedConfigsResponse
         */
        public async Task<GetAppliedConfigsResponse> GetAppliedConfigsWithOptionsAsync(string project, string machineGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppliedConfigs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppliedConfigsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetAppliedConfigsResponse
         */
        public GetAppliedConfigsResponse GetAppliedConfigs(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppliedConfigsWithOptions(project, machineGroup, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetAppliedConfigsResponse
         */
        public async Task<GetAppliedConfigsResponse> GetAppliedConfigsAsync(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppliedConfigsWithOptionsAsync(project, machineGroup, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAppliedMachineGroupsResponse
         */
        public GetAppliedMachineGroupsResponse GetAppliedMachineGroupsWithOptions(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppliedMachineGroups",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName + "/machinegroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppliedMachineGroupsResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetAppliedMachineGroupsResponse
         */
        public async Task<GetAppliedMachineGroupsResponse> GetAppliedMachineGroupsWithOptionsAsync(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAppliedMachineGroups",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName + "/machinegroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAppliedMachineGroupsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetAppliedMachineGroupsResponse
         */
        public GetAppliedMachineGroupsResponse GetAppliedMachineGroups(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppliedMachineGroupsWithOptions(project, configName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetAppliedMachineGroupsResponse
         */
        public async Task<GetAppliedMachineGroupsResponse> GetAppliedMachineGroupsAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppliedMachineGroupsWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetCheckPointRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCheckPointResponse
         */
        public GetCheckPointResponse GetCheckPointWithOptions(string project, string logstore, string consumerGroup, GetCheckPointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                query["shard"] = request.Shard;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckPoint",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetCheckPointResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetCheckPointRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCheckPointResponse
         */
        public async Task<GetCheckPointResponse> GetCheckPointWithOptionsAsync(string project, string logstore, string consumerGroup, GetCheckPointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                query["shard"] = request.Shard;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCheckPoint",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetCheckPointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetCheckPointRequest
          * @return GetCheckPointResponse
         */
        public GetCheckPointResponse GetCheckPoint(string project, string logstore, string consumerGroup, GetCheckPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCheckPointWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetCheckPointRequest
          * @return GetCheckPointResponse
         */
        public async Task<GetCheckPointResponse> GetCheckPointAsync(string project, string logstore, string consumerGroup, GetCheckPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCheckPointWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

        public GetCollectionPolicyResponse GetCollectionPolicyWithOptions(string policyName, GetCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCollectionPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy/" + policyName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCollectionPolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetCollectionPolicyResponse> GetCollectionPolicyWithOptionsAsync(string policyName, GetCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCollectionPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy/" + policyName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCollectionPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetCollectionPolicyResponse GetCollectionPolicy(string policyName, GetCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCollectionPolicyWithOptions(policyName, request, headers, runtime);
        }

        public async Task<GetCollectionPolicyResponse> GetCollectionPolicyAsync(string policyName, GetCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCollectionPolicyWithOptionsAsync(policyName, request, headers, runtime);
        }

        public GetConfigResponse GetConfigWithOptions(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetConfigResponse> GetConfigWithOptionsAsync(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetConfigResponse GetConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConfigWithOptions(project, configName, headers, runtime);
        }

        public async Task<GetConfigResponse> GetConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
          * *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetContextLogsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetContextLogsResponse
         */
        public GetContextLogsResponse GetContextLogsWithOptions(string project, string logstore, GetContextLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackLines))
            {
                query["back_lines"] = request.BackLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardLines))
            {
                query["forward_lines"] = request.ForwardLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackId))
            {
                query["pack_id"] = request.PackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackMeta))
            {
                query["pack_meta"] = request.PackMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextLogsResponse>(Execute(params_, req, runtime));
        }

        /**
          * *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetContextLogsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetContextLogsResponse
         */
        public async Task<GetContextLogsResponse> GetContextLogsWithOptionsAsync(string project, string logstore, GetContextLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackLines))
            {
                query["back_lines"] = request.BackLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForwardLines))
            {
                query["forward_lines"] = request.ForwardLines;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackId))
            {
                query["pack_id"] = request.PackId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PackMeta))
            {
                query["pack_meta"] = request.PackMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextLogsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetContextLogsRequest
          * @return GetContextLogsResponse
         */
        public GetContextLogsResponse GetContextLogs(string project, string logstore, GetContextLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetContextLogsWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetContextLogsRequest
          * @return GetContextLogsResponse
         */
        public async Task<GetContextLogsResponse> GetContextLogsAsync(string project, string logstore, GetContextLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetContextLogsWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The following content describes the relationships among a cursor, project, Logstore, and shard:
          *     *   A project can have multiple Logstores.
          *     *   A Logstore can have multiple shards.
          *     *   You can use a cursor to obtain a log in a shard.
          *
          * @param request GetCursorRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCursorResponse
         */
        public GetCursorResponse GetCursorWithOptions(string project, string logstore, string shardId, GetCursorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCursor",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId + "?type=cursor",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCursorResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The following content describes the relationships among a cursor, project, Logstore, and shard:
          *     *   A project can have multiple Logstores.
          *     *   A Logstore can have multiple shards.
          *     *   You can use a cursor to obtain a log in a shard.
          *
          * @param request GetCursorRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetCursorResponse
         */
        public async Task<GetCursorResponse> GetCursorWithOptionsAsync(string project, string logstore, string shardId, GetCursorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCursor",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId + "?type=cursor",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCursorResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The following content describes the relationships among a cursor, project, Logstore, and shard:
          *     *   A project can have multiple Logstores.
          *     *   A Logstore can have multiple shards.
          *     *   You can use a cursor to obtain a log in a shard.
          *
          * @param request GetCursorRequest
          * @return GetCursorResponse
         */
        public GetCursorResponse GetCursor(string project, string logstore, string shardId, GetCursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCursorWithOptions(project, logstore, shardId, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The following content describes the relationships among a cursor, project, Logstore, and shard:
          *     *   A project can have multiple Logstores.
          *     *   A Logstore can have multiple shards.
          *     *   You can use a cursor to obtain a log in a shard.
          *
          * @param request GetCursorRequest
          * @return GetCursorResponse
         */
        public async Task<GetCursorResponse> GetCursorAsync(string project, string logstore, string shardId, GetCursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCursorWithOptionsAsync(project, logstore, shardId, request, headers, runtime);
        }

        public GetCursorTimeResponse GetCursorTimeWithOptions(string project, string logstore, string shardId, GetCursorTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCursorTime",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId + "?type=cursor_time",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCursorTimeResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetCursorTimeResponse> GetCursorTimeWithOptionsAsync(string project, string logstore, string shardId, GetCursorTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCursorTime",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId + "?type=cursor_time",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCursorTimeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetCursorTimeResponse GetCursorTime(string project, string logstore, string shardId, GetCursorTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCursorTimeWithOptions(project, logstore, shardId, request, headers, runtime);
        }

        public async Task<GetCursorTimeResponse> GetCursorTimeAsync(string project, string logstore, string shardId, GetCursorTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCursorTimeWithOptionsAsync(project, logstore, shardId, request, headers, runtime);
        }

        public GetDashboardResponse GetDashboardWithOptions(string project, string dashboardName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards/" + dashboardName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDashboardResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetDashboardResponse> GetDashboardWithOptionsAsync(string project, string dashboardName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards/" + dashboardName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDashboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetDashboardResponse GetDashboard(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDashboardWithOptions(project, dashboardName, headers, runtime);
        }

        public async Task<GetDashboardResponse> GetDashboardAsync(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDashboardWithOptionsAsync(project, dashboardName, headers, runtime);
        }

        /**
          * *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetExternalStoreResponse
         */
        public GetExternalStoreResponse GetExternalStoreWithOptions(string project, string externalStoreName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetExternalStoreResponse
         */
        public async Task<GetExternalStoreResponse> GetExternalStoreWithOptionsAsync(string project, string externalStoreName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetExternalStoreResponse
         */
        public GetExternalStoreResponse GetExternalStore(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExternalStoreWithOptions(project, externalStoreName, headers, runtime);
        }

        /**
          * *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetExternalStoreResponse
         */
        public async Task<GetExternalStoreResponse> GetExternalStoreAsync(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExternalStoreWithOptionsAsync(project, externalStoreName, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:\\__receive_time\\_\\_ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](~~462234~~).
          *
          * @param request GetHistogramsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetHistogramsResponse
         */
        public GetHistogramsResponse GetHistogramsWithOptions(string project, string logstore, GetHistogramsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistograms",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index?type=histogram",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetHistogramsResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:\\__receive_time\\_\\_ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](~~462234~~).
          *
          * @param request GetHistogramsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetHistogramsResponse
         */
        public async Task<GetHistogramsResponse> GetHistogramsWithOptionsAsync(string project, string logstore, GetHistogramsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetHistograms",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index?type=histogram",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetHistogramsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:\\__receive_time\\_\\_ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](~~462234~~).
          *
          * @param request GetHistogramsRequest
          * @return GetHistogramsResponse
         */
        public GetHistogramsResponse GetHistograms(string project, string logstore, GetHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHistogramsWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:\\__receive_time\\_\\_ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](~~462234~~).
          *
          * @param request GetHistogramsRequest
          * @return GetHistogramsResponse
         */
        public async Task<GetHistogramsResponse> GetHistogramsAsync(string project, string logstore, GetHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHistogramsWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetIndexResponse
         */
        public GetIndexResponse GetIndexWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetIndexResponse
         */
        public async Task<GetIndexResponse> GetIndexWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetIndexResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetIndexResponse
         */
        public GetIndexResponse GetIndex(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexWithOptions(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetIndexResponse
         */
        public async Task<GetIndexResponse> GetIndexAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLogStoreResponse
         */
        public GetLogStoreResponse GetLogStoreWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLogStoreResponse
         */
        public async Task<GetLogStoreResponse> GetLogStoreWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetLogStoreResponse
         */
        public GetLogStoreResponse GetLogStore(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogStoreWithOptions(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetLogStoreResponse
         */
        public async Task<GetLogStoreResponse> GetLogStoreAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogStoreWithOptionsAsync(project, logstore, headers, runtime);
        }

        public GetLogStoreMeteringModeResponse GetLogStoreMeteringModeWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/meteringmode",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogStoreMeteringModeResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetLogStoreMeteringModeResponse> GetLogStoreMeteringModeWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/meteringmode",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogStoreMeteringModeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetLogStoreMeteringModeResponse GetLogStoreMeteringMode(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogStoreMeteringModeWithOptions(project, logstore, headers, runtime);
        }

        public async Task<GetLogStoreMeteringModeResponse> GetLogStoreMeteringModeAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogStoreMeteringModeWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLoggingResponse
         */
        public GetLoggingResponse GetLoggingWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoggingResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLoggingResponse
         */
        public async Task<GetLoggingResponse> GetLoggingWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetLoggingResponse
         */
        public GetLoggingResponse GetLogging(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLoggingWithOptions(project, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetLoggingResponse
         */
        public async Task<GetLoggingResponse> GetLoggingAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLoggingWithOptionsAsync(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](~~286457~~).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](~~407683~~) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](~~407684~~).
          *
          * @param request GetLogsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLogsResponse
         */
        public GetLogsResponse GetLogsWithOptions(string project, string logstore, GetLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerSql))
            {
                query["powerSql"] = request.PowerSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "?type=log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetLogsResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](~~286457~~).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](~~407683~~) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](~~407684~~).
          *
          * @param request GetLogsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLogsResponse
         */
        public async Task<GetLogsResponse> GetLogsWithOptionsAsync(string project, string logstore, GetLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                query["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerSql))
            {
                query["powerSql"] = request.PowerSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                query["reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "?type=log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetLogsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](~~286457~~).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](~~407683~~) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](~~407684~~).
          *
          * @param request GetLogsRequest
          * @return GetLogsResponse
         */
        public GetLogsResponse GetLogs(string project, string logstore, GetLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogsWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](~~286457~~).
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
          *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
          *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
          *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          * > Simple Log Service calculates the difference between the log time that is specified by the \\__time\\_\\_ field and the receiving time that is specified by the \\__tag\\_\\_:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval \\[-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
          * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](~~407683~~) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](~~407684~~).
          *
          * @param request GetLogsRequest
          * @return GetLogsResponse
         */
        public async Task<GetLogsResponse> GetLogsAsync(string project, string logstore, GetLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogsWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
          * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
          * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          *
          * @param request GetLogsV2Request
          * @param headers GetLogsV2Headers
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLogsV2Response
         */
        public GetLogsV2Response GetLogsV2WithOptions(string project, string logstore, GetLogsV2Request request, GetLogsV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Forward))
            {
                body["forward"] = request.Forward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                body["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerSql))
            {
                body["powerSql"] = request.PowerSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                body["reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Session))
            {
                body["session"] = request.Session;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                body["shard"] = request.Shard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["Accept-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogsV2",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/logs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogsV2Response>(Execute(params_, req, runtime));
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
          * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
          * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          *
          * @param request GetLogsV2Request
          * @param headers GetLogsV2Headers
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetLogsV2Response
         */
        public async Task<GetLogsV2Response> GetLogsV2WithOptionsAsync(string project, string logstore, GetLogsV2Request request, GetLogsV2Headers headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Forward))
            {
                body["forward"] = request.Forward;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                body["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                body["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerSql))
            {
                body["powerSql"] = request.PowerSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reverse))
            {
                body["reverse"] = request.Reverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Session))
            {
                body["session"] = request.Session;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                body["shard"] = request.Shard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.AcceptEncoding))
            {
                realHeaders["Accept-Encoding"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.AcceptEncoding);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogsV2",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/logs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogsV2Response>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
          * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
          * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          *
          * @param request GetLogsV2Request
          * @return GetLogsV2Response
         */
        public GetLogsV2Response GetLogsV2(string project, string logstore, GetLogsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLogsV2Headers headers = new GetLogsV2Headers();
            return GetLogsV2WithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
          * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
          * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
          * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval \\[-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
          *
          * @param request GetLogsV2Request
          * @return GetLogsV2Response
         */
        public async Task<GetLogsV2Response> GetLogsV2Async(string project, string logstore, GetLogsV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetLogsV2Headers headers = new GetLogsV2Headers();
            return await GetLogsV2WithOptionsAsync(project, logstore, request, headers, runtime);
        }

        public GetLogtailPipelineConfigResponse GetLogtailPipelineConfigWithOptions(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs/" + configName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogtailPipelineConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetLogtailPipelineConfigResponse> GetLogtailPipelineConfigWithOptionsAsync(string project, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs/" + configName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetLogtailPipelineConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetLogtailPipelineConfigResponse GetLogtailPipelineConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogtailPipelineConfigWithOptions(project, configName, headers, runtime);
        }

        public async Task<GetLogtailPipelineConfigResponse> GetLogtailPipelineConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogtailPipelineConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        public GetMLServiceResultsResponse GetMLServiceResultsWithOptions(string serviceName, GetMLServiceResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowBuiltin))
            {
                query["allowBuiltin"] = request.AllowBuiltin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMLServiceResults",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/service/" + serviceName + "/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMLServiceResultsResponse>(Execute(params_, req, runtime));
        }

        public async Task<GetMLServiceResultsResponse> GetMLServiceResultsWithOptionsAsync(string serviceName, GetMLServiceResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowBuiltin))
            {
                query["allowBuiltin"] = request.AllowBuiltin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMLServiceResults",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/service/" + serviceName + "/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMLServiceResultsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public GetMLServiceResultsResponse GetMLServiceResults(string serviceName, GetMLServiceResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMLServiceResultsWithOptions(serviceName, request, headers, runtime);
        }

        public async Task<GetMLServiceResultsResponse> GetMLServiceResultsAsync(string serviceName, GetMLServiceResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMLServiceResultsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMachineGroupResponse
         */
        public GetMachineGroupResponse GetMachineGroupWithOptions(string project, string machineGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetMachineGroupResponse
         */
        public async Task<GetMachineGroupResponse> GetMachineGroupWithOptionsAsync(string project, string machineGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetMachineGroupResponse
         */
        public GetMachineGroupResponse GetMachineGroup(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMachineGroupWithOptions(project, machineGroup, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetMachineGroupResponse
         */
        public async Task<GetMachineGroupResponse> GetMachineGroupAsync(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMachineGroupWithOptionsAsync(project, machineGroup, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetProjectResponse
         */
        public GetProjectResponse GetProjectWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetProjectResponse
         */
        public GetProjectResponse GetProject(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetProjectResponse
         */
        public async Task<GetProjectResponse> GetProjectAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   You can use the query parameter to specify a standard SQL statement.
          * *   You must specify a project in the domain name of the request.
          * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
          * *   You must specify a time range in the SQL statement by using the \\__date\\_\\_ parameter or \\__time\\_\\_ parameter. The value of the \\__date\\_\\_ parameter is a timestamp, and the value of the \\__time\\_\\_ parameter is an integer. The unit of the \\__time\\_\\_ parameter is seconds.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetProjectLogsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetProjectLogsResponse
         */
        public GetProjectLogsResponse GetProjectLogsWithOptions(string project, GetProjectLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerSql))
            {
                query["powerSql"] = request.PowerSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetProjectLogsResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   You can use the query parameter to specify a standard SQL statement.
          * *   You must specify a project in the domain name of the request.
          * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
          * *   You must specify a time range in the SQL statement by using the \\__date\\_\\_ parameter or \\__time\\_\\_ parameter. The value of the \\__date\\_\\_ parameter is a timestamp, and the value of the \\__time\\_\\_ parameter is an integer. The unit of the \\__time\\_\\_ parameter is seconds.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetProjectLogsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetProjectLogsResponse
         */
        public async Task<GetProjectLogsResponse> GetProjectLogsWithOptionsAsync(string project, GetProjectLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PowerSql))
            {
                query["powerSql"] = request.PowerSql;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetProjectLogsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   You can use the query parameter to specify a standard SQL statement.
          * *   You must specify a project in the domain name of the request.
          * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
          * *   You must specify a time range in the SQL statement by using the \\__date\\_\\_ parameter or \\__time\\_\\_ parameter. The value of the \\__date\\_\\_ parameter is a timestamp, and the value of the \\__time\\_\\_ parameter is an integer. The unit of the \\__time\\_\\_ parameter is seconds.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetProjectLogsRequest
          * @return GetProjectLogsResponse
         */
        public GetProjectLogsResponse GetProjectLogs(string project, GetProjectLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectLogsWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   You can use the query parameter to specify a standard SQL statement.
          * *   You must specify a project in the domain name of the request.
          * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
          * *   You must specify a time range in the SQL statement by using the \\__date\\_\\_ parameter or \\__time\\_\\_ parameter. The value of the \\__date\\_\\_ parameter is a timestamp, and the value of the \\__time\\_\\_ parameter is an integer. The unit of the \\__time\\_\\_ parameter is seconds.
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetProjectLogsRequest
          * @return GetProjectLogsResponse
         */
        public async Task<GetProjectLogsResponse> GetProjectLogsAsync(string project, GetProjectLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectLogsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetProjectPolicyResponse
         */
        public GetProjectPolicyResponse GetProjectPolicyWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetProjectPolicyResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetProjectPolicyResponse
         */
        public async Task<GetProjectPolicyResponse> GetProjectPolicyWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<GetProjectPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetProjectPolicyResponse
         */
        public GetProjectPolicyResponse GetProjectPolicy(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectPolicyWithOptions(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetProjectPolicyResponse
         */
        public async Task<GetProjectPolicyResponse> GetProjectPolicyAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectPolicyWithOptionsAsync(project, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSavedSearchResponse
         */
        public GetSavedSearchResponse GetSavedSearchWithOptions(string project, string savedsearchName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches/" + savedsearchName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavedSearchResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetSavedSearchResponse
         */
        public async Task<GetSavedSearchResponse> GetSavedSearchWithOptionsAsync(string project, string savedsearchName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches/" + savedsearchName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSavedSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetSavedSearchResponse
         */
        public GetSavedSearchResponse GetSavedSearch(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSavedSearchWithOptions(project, savedsearchName, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return GetSavedSearchResponse
         */
        public async Task<GetSavedSearchResponse> GetSavedSearchAsync(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSavedSearchWithOptionsAsync(project, savedsearchName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetShipperStatusRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetShipperStatusResponse
         */
        public GetShipperStatusResponse GetShipperStatusWithOptions(string project, string logstore, string shipperName, GetShipperStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShipperStatus",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShipperStatusResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetShipperStatusRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetShipperStatusResponse
         */
        public async Task<GetShipperStatusResponse> GetShipperStatusWithOptionsAsync(string project, string logstore, string shipperName, GetShipperStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetShipperStatus",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetShipperStatusResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetShipperStatusRequest
          * @return GetShipperStatusResponse
         */
        public GetShipperStatusResponse GetShipperStatus(string project, string logstore, string shipperName, GetShipperStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetShipperStatusWithOptions(project, logstore, shipperName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request GetShipperStatusRequest
          * @return GetShipperStatusResponse
         */
        public async Task<GetShipperStatusResponse> GetShipperStatusAsync(string project, string logstore, string shipperName, GetShipperStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetShipperStatusWithOptionsAsync(project, logstore, shipperName, request, headers, runtime);
        }

        public ListAnnotationDataResponse ListAnnotationDataWithOptions(string datasetId, ListAnnotationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListAnnotationDataResponse> ListAnnotationDataWithOptionsAsync(string datasetId, ListAnnotationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListAnnotationDataResponse ListAnnotationData(string datasetId, ListAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnnotationDataWithOptions(datasetId, request, headers, runtime);
        }

        public async Task<ListAnnotationDataResponse> ListAnnotationDataAsync(string datasetId, ListAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnnotationDataWithOptionsAsync(datasetId, request, headers, runtime);
        }

        public ListAnnotationDataSetsResponse ListAnnotationDataSetsWithOptions(ListAnnotationDataSetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnnotationDataSets",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationDataSetsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListAnnotationDataSetsResponse> ListAnnotationDataSetsWithOptionsAsync(ListAnnotationDataSetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnnotationDataSets",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationDataSetsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListAnnotationDataSetsResponse ListAnnotationDataSets(ListAnnotationDataSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnnotationDataSetsWithOptions(request, headers, runtime);
        }

        public async Task<ListAnnotationDataSetsResponse> ListAnnotationDataSetsAsync(ListAnnotationDataSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnnotationDataSetsWithOptionsAsync(request, headers, runtime);
        }

        public ListAnnotationLabelsResponse ListAnnotationLabelsWithOptions(ListAnnotationLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnnotationLabels",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationLabelsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListAnnotationLabelsResponse> ListAnnotationLabelsWithOptionsAsync(ListAnnotationLabelsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAnnotationLabels",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAnnotationLabelsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListAnnotationLabelsResponse ListAnnotationLabels(ListAnnotationLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnnotationLabelsWithOptions(request, headers, runtime);
        }

        public async Task<ListAnnotationLabelsResponse> ListAnnotationLabelsAsync(ListAnnotationLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnnotationLabelsWithOptionsAsync(request, headers, runtime);
        }

        public ListCollectionPoliciesResponse ListCollectionPoliciesWithOptions(ListCollectionPoliciesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCollectionPoliciesShrinkRequest request = new ListCollectionPoliciesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attribute))
            {
                request.AttributeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attribute, "attribute", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeShrink))
            {
                query["attribute"] = request.AttributeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCollectionPolicies",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCollectionPoliciesResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListCollectionPoliciesResponse> ListCollectionPoliciesWithOptionsAsync(ListCollectionPoliciesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCollectionPoliciesShrinkRequest request = new ListCollectionPoliciesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Attribute))
            {
                request.AttributeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Attribute, "attribute", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttributeShrink))
            {
                query["attribute"] = request.AttributeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCollectionPolicies",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCollectionPoliciesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListCollectionPoliciesResponse ListCollectionPolicies(ListCollectionPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCollectionPoliciesWithOptions(request, headers, runtime);
        }

        public async Task<ListCollectionPoliciesResponse> ListCollectionPoliciesAsync(ListCollectionPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCollectionPoliciesWithOptionsAsync(request, headers, runtime);
        }

        public ListConfigResponse ListConfigWithOptions(string project, ListConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                query["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListConfigResponse> ListConfigWithOptionsAsync(string project, ListConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                query["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListConfigResponse ListConfig(string project, ListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigWithOptions(project, request, headers, runtime);
        }

        public async Task<ListConfigResponse> ListConfigAsync(string project, ListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConsumerGroupResponse
         */
        public ListConsumerGroupResponse ListConsumerGroupWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListConsumerGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConsumerGroupResponse
         */
        public async Task<ListConsumerGroupResponse> ListConsumerGroupWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListConsumerGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return ListConsumerGroupResponse
         */
        public ListConsumerGroupResponse ListConsumerGroup(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumerGroupWithOptions(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return ListConsumerGroupResponse
         */
        public async Task<ListConsumerGroupResponse> ListConsumerGroupAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumerGroupWithOptionsAsync(project, logstore, headers, runtime);
        }

        public ListDashboardResponse ListDashboardWithOptions(string project, ListDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListDashboardResponse> ListDashboardWithOptionsAsync(string project, ListDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDashboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListDashboardResponse ListDashboard(string project, ListDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardWithOptions(project, request, headers, runtime);
        }

        public async Task<ListDashboardResponse> ListDashboardAsync(string project, ListDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Only one custom domain name can be bound to each project.
          *
          * @param request ListDomainsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomainsWithOptions(string project, ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(Execute(params_, req, runtime));
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Only one custom domain name can be bound to each project.
          *
          * @param request ListDomainsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsWithOptionsAsync(string project, ListDomainsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DomainName))
            {
                query["domainName"] = request.DomainName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDomains",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/domains",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDomainsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Only one custom domain name can be bound to each project.
          *
          * @param request ListDomainsRequest
          * @return ListDomainsResponse
         */
        public ListDomainsResponse ListDomains(string project, ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDomainsWithOptions(project, request, headers, runtime);
        }

        /**
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Only one custom domain name can be bound to each project.
          *
          * @param request ListDomainsRequest
          * @return ListDomainsResponse
         */
        public async Task<ListDomainsResponse> ListDomainsAsync(string project, ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDomainsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListExternalStoreResponse
         */
        public ListExternalStoreResponse ListExternalStoreWithOptions(string project, ListExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                query["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sizs))
            {
                query["sizs"] = request.Sizs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListExternalStoreResponse
         */
        public async Task<ListExternalStoreResponse> ListExternalStoreWithOptionsAsync(string project, ListExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                query["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sizs))
            {
                query["sizs"] = request.Sizs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListExternalStoreRequest
          * @return ListExternalStoreResponse
         */
        public ListExternalStoreResponse ListExternalStore(string project, ListExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExternalStoreWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListExternalStoreRequest
          * @return ListExternalStoreResponse
         */
        public async Task<ListExternalStoreResponse> ListExternalStoreAsync(string project, ListExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExternalStoreWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListLogStoresRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListLogStoresResponse
         */
        public ListLogStoresResponse ListLogStoresWithOptions(string project, ListLogStoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                query["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryType))
            {
                query["telemetryType"] = request.TelemetryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogStores",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogStoresResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListLogStoresRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListLogStoresResponse
         */
        public async Task<ListLogStoresResponse> ListLogStoresWithOptionsAsync(string project, ListLogStoresRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                query["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryType))
            {
                query["telemetryType"] = request.TelemetryType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogStores",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogStoresResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListLogStoresRequest
          * @return ListLogStoresResponse
         */
        public ListLogStoresResponse ListLogStores(string project, ListLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogStoresWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListLogStoresRequest
          * @return ListLogStoresResponse
         */
        public async Task<ListLogStoresResponse> ListLogStoresAsync(string project, ListLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogStoresWithOptionsAsync(project, request, headers, runtime);
        }

        public ListLogtailPipelineConfigResponse ListLogtailPipelineConfigWithOptions(string project, ListLogtailPipelineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                query["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogtailPipelineConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListLogtailPipelineConfigResponse> ListLogtailPipelineConfigWithOptionsAsync(string project, ListLogtailPipelineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                query["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLogtailPipelineConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListLogtailPipelineConfigResponse ListLogtailPipelineConfig(string project, ListLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogtailPipelineConfigWithOptions(project, request, headers, runtime);
        }

        public async Task<ListLogtailPipelineConfigResponse> ListLogtailPipelineConfigAsync(string project, ListLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogtailPipelineConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachineGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListMachineGroupResponse
         */
        public ListMachineGroupResponse ListMachineGroupWithOptions(string project, ListMachineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachineGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListMachineGroupResponse
         */
        public async Task<ListMachineGroupResponse> ListMachineGroupWithOptionsAsync(string project, ListMachineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachineGroupRequest
          * @return ListMachineGroupResponse
         */
        public ListMachineGroupResponse ListMachineGroup(string project, ListMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMachineGroupWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachineGroupRequest
          * @return ListMachineGroupResponse
         */
        public async Task<ListMachineGroupResponse> ListMachineGroupAsync(string project, ListMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMachineGroupWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachinesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListMachinesResponse
         */
        public ListMachinesResponse ListMachinesWithOptions(string project, string machineGroup, ListMachinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMachines",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/machines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMachinesResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachinesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListMachinesResponse
         */
        public async Task<ListMachinesResponse> ListMachinesWithOptionsAsync(string project, string machineGroup, ListMachinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMachines",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/machines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMachinesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachinesRequest
          * @return ListMachinesResponse
         */
        public ListMachinesResponse ListMachines(string project, string machineGroup, ListMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMachinesWithOptions(project, machineGroup, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListMachinesRequest
          * @return ListMachinesResponse
         */
        public async Task<ListMachinesResponse> ListMachinesAsync(string project, string machineGroup, ListMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMachinesWithOptionsAsync(project, machineGroup, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListProjectRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListProjectResponse
         */
        public ListProjectResponse ListProjectWithOptions(ListProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListProjectRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListProjectResponse
         */
        public async Task<ListProjectResponse> ListProjectWithOptionsAsync(ListProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectName))
            {
                query["projectName"] = request.ProjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListProjectRequest
          * @return ListProjectResponse
         */
        public ListProjectResponse ListProject(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectWithOptions(request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListProjectRequest
          * @return ListProjectResponse
         */
        public async Task<ListProjectResponse> ListProjectAsync(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListSavedSearchRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSavedSearchResponse
         */
        public ListSavedSearchResponse ListSavedSearchWithOptions(string project, ListSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavedSearchResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListSavedSearchRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListSavedSearchResponse
         */
        public async Task<ListSavedSearchResponse> ListSavedSearchWithOptionsAsync(string project, ListSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSavedSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListSavedSearchRequest
          * @return ListSavedSearchResponse
         */
        public ListSavedSearchResponse ListSavedSearch(string project, ListSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSavedSearchWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListSavedSearchRequest
          * @return ListSavedSearchResponse
         */
        public async Task<ListSavedSearchResponse> ListSavedSearchAsync(string project, ListSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSavedSearchWithOptionsAsync(project, request, headers, runtime);
        }

        public ListShardsResponse ListShardsWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShards",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListShardsResponse>(Execute(params_, req, runtime));
        }

        public async Task<ListShardsResponse> ListShardsWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShards",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<ListShardsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public ListShardsResponse ListShards(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShardsWithOptions(project, logstore, headers, runtime);
        }

        public async Task<ListShardsResponse> ListShardsAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShardsWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListShipperResponse
         */
        public ListShipperResponse ListShipperWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShipperResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListShipperResponse
         */
        public async Task<ListShipperResponse> ListShipperWithOptionsAsync(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListShipperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return ListShipperResponse
         */
        public ListShipperResponse ListShipper(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShipperWithOptions(project, logstore, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return ListShipperResponse
         */
        public async Task<ListShipperResponse> ListShipperAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShipperWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param tmpReq ListTagResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param tmpReq ListTagResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceId))
            {
                request.ResourceIdShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceId, "resourceId", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdShrink))
            {
                query["resourceId"] = request.ResourceIdShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListTagResourcesRequest
          * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request ListTagResourcesRequest
          * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public PutAnnotationDataResponse PutAnnotationDataWithOptions(string datasetId, PutAnnotationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationdataId))
            {
                query["annotationdataId"] = request.AnnotationdataId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MlDataParam))
            {
                body["mlDataParam"] = request.MlDataParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawLog))
            {
                body["rawLog"] = request.RawLog;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutAnnotationDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutAnnotationDataResponse> PutAnnotationDataWithOptionsAsync(string datasetId, PutAnnotationDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AnnotationdataId))
            {
                query["annotationdataId"] = request.AnnotationdataId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MlDataParam))
            {
                body["mlDataParam"] = request.MlDataParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RawLog))
            {
                body["rawLog"] = request.RawLog;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAnnotationData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId + "/annotationdata",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutAnnotationDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutAnnotationDataResponse PutAnnotationData(string datasetId, PutAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutAnnotationDataWithOptions(datasetId, request, headers, runtime);
        }

        public async Task<PutAnnotationDataResponse> PutAnnotationDataAsync(string datasetId, PutAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutAnnotationDataWithOptionsAsync(datasetId, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
          *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](~~128139~~).
          *     *   If you set the Principal element to an asterisk (\\*) and do not configure the Condition element when you configure a project policy, the policy applies to all users except for the project owner. If you set the Principal element to an asterisk (\\*) and configure the Condition element when you configure a project policy, the policy applies to all users including the project owner.
          *     *   You can configure multiple project policies for a project. The total size of the policies cannot exceed 16 KB.
          *
          * @param request PutProjectPolicyRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutProjectPolicyResponse
         */
        public PutProjectPolicyResponse PutProjectPolicyWithOptions(string project, PutProjectPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProjectPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/policy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutProjectPolicyResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
          *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](~~128139~~).
          *     *   If you set the Principal element to an asterisk (\\*) and do not configure the Condition element when you configure a project policy, the policy applies to all users except for the project owner. If you set the Principal element to an asterisk (\\*) and configure the Condition element when you configure a project policy, the policy applies to all users including the project owner.
          *     *   You can configure multiple project policies for a project. The total size of the policies cannot exceed 16 KB.
          *
          * @param request PutProjectPolicyRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutProjectPolicyResponse
         */
        public async Task<PutProjectPolicyResponse> PutProjectPolicyWithOptionsAsync(string project, PutProjectPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProjectPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/policy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutProjectPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
          *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](~~128139~~).
          *     *   If you set the Principal element to an asterisk (\\*) and do not configure the Condition element when you configure a project policy, the policy applies to all users except for the project owner. If you set the Principal element to an asterisk (\\*) and configure the Condition element when you configure a project policy, the policy applies to all users including the project owner.
          *     *   You can configure multiple project policies for a project. The total size of the policies cannot exceed 16 KB.
          *
          * @param request PutProjectPolicyRequest
          * @return PutProjectPolicyResponse
         */
        public PutProjectPolicyResponse PutProjectPolicy(string project, PutProjectPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProjectPolicyWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
          *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](~~128139~~).
          *     *   If you set the Principal element to an asterisk (\\*) and do not configure the Condition element when you configure a project policy, the policy applies to all users except for the project owner. If you set the Principal element to an asterisk (\\*) and configure the Condition element when you configure a project policy, the policy applies to all users including the project owner.
          *     *   You can configure multiple project policies for a project. The total size of the policies cannot exceed 16 KB.
          *
          * @param request PutProjectPolicyRequest
          * @return PutProjectPolicyResponse
         */
        public async Task<PutProjectPolicyResponse> PutProjectPolicyAsync(string project, PutProjectPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProjectPolicyWithOptionsAsync(project, request, headers, runtime);
        }

        public PutProjectTransferAccelerationResponse PutProjectTransferAccelerationWithOptions(string project, PutProjectTransferAccelerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProjectTransferAcceleration",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/transferacceleration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutProjectTransferAccelerationResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutProjectTransferAccelerationResponse> PutProjectTransferAccelerationWithOptionsAsync(string project, PutProjectTransferAccelerationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutProjectTransferAcceleration",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/transferacceleration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutProjectTransferAccelerationResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutProjectTransferAccelerationResponse PutProjectTransferAcceleration(string project, PutProjectTransferAccelerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProjectTransferAccelerationWithOptions(project, request, headers, runtime);
        }

        public async Task<PutProjectTransferAccelerationResponse> PutProjectTransferAccelerationAsync(string project, PutProjectTransferAccelerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProjectTransferAccelerationWithOptionsAsync(project, request, headers, runtime);
        }

        public PutWebtrackingResponse PutWebtrackingWithOptions(string project, string logstoreName, PutWebtrackingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logs))
            {
                body["__logs__"] = request.Logs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["__source__"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["__tags__"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["__topic__"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutWebtracking",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstoreName + "/track",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutWebtrackingResponse>(Execute(params_, req, runtime));
        }

        public async Task<PutWebtrackingResponse> PutWebtrackingWithOptionsAsync(string project, string logstoreName, PutWebtrackingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logs))
            {
                body["__logs__"] = request.Logs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["__source__"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["__tags__"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["__topic__"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutWebtracking",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstoreName + "/track",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutWebtrackingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutWebtrackingResponse PutWebtracking(string project, string logstoreName, PutWebtrackingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutWebtrackingWithOptions(project, logstoreName, request, headers, runtime);
        }

        public async Task<PutWebtrackingResponse> PutWebtrackingAsync(string project, string logstoreName, PutWebtrackingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutWebtrackingWithOptionsAsync(project, logstoreName, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param request QueryMLServiceResultsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryMLServiceResultsResponse
         */
        // Deprecated
        public QueryMLServiceResultsResponse QueryMLServiceResultsWithOptions(string serviceName, QueryMLServiceResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowBuiltin))
            {
                query["allowBuiltin"] = request.AllowBuiltin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMLServiceResults",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/service/" + serviceName + "/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMLServiceResultsResponse>(Execute(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request QueryMLServiceResultsRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryMLServiceResultsResponse
         */
        // Deprecated
        public async Task<QueryMLServiceResultsResponse> QueryMLServiceResultsWithOptionsAsync(string serviceName, QueryMLServiceResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowBuiltin))
            {
                query["allowBuiltin"] = request.AllowBuiltin;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMLServiceResults",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/service/" + serviceName + "/analysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMLServiceResultsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          *
          * @param request QueryMLServiceResultsRequest
          * @return QueryMLServiceResultsResponse
         */
        // Deprecated
        public QueryMLServiceResultsResponse QueryMLServiceResults(string serviceName, QueryMLServiceResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryMLServiceResultsWithOptions(serviceName, request, headers, runtime);
        }

        /**
          * @deprecated
          *
          * @param request QueryMLServiceResultsRequest
          * @return QueryMLServiceResultsResponse
         */
        // Deprecated
        public async Task<QueryMLServiceResultsResponse> QueryMLServiceResultsAsync(string serviceName, QueryMLServiceResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryMLServiceResultsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return RemoveConfigFromMachineGroupResponse
         */
        public RemoveConfigFromMachineGroupResponse RemoveConfigFromMachineGroupWithOptions(string project, string machineGroup, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveConfigFromMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/configs/" + configName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveConfigFromMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return RemoveConfigFromMachineGroupResponse
         */
        public async Task<RemoveConfigFromMachineGroupResponse> RemoveConfigFromMachineGroupWithOptionsAsync(string project, string machineGroup, string configName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveConfigFromMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/configs/" + configName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveConfigFromMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return RemoveConfigFromMachineGroupResponse
         */
        public RemoveConfigFromMachineGroupResponse RemoveConfigFromMachineGroup(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveConfigFromMachineGroupWithOptions(project, machineGroup, configName, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @return RemoveConfigFromMachineGroupResponse
         */
        public async Task<RemoveConfigFromMachineGroupResponse> RemoveConfigFromMachineGroupAsync(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveConfigFromMachineGroupWithOptionsAsync(project, machineGroup, configName, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](~~28976~~).
          *
          * @param request SplitShardRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return SplitShardResponse
         */
        public SplitShardResponse SplitShardWithOptions(string project, string logstore, string shard, SplitShardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardCount))
            {
                query["shardCount"] = request.ShardCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SplitShard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shard + "?action=split",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<SplitShardResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](~~28976~~).
          *
          * @param request SplitShardRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return SplitShardResponse
         */
        public async Task<SplitShardResponse> SplitShardWithOptionsAsync(string project, string logstore, string shard, SplitShardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["key"] = request.Key;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardCount))
            {
                query["shardCount"] = request.ShardCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SplitShard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shard + "?action=split",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<SplitShardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](~~28976~~).
          *
          * @param request SplitShardRequest
          * @return SplitShardResponse
         */
        public SplitShardResponse SplitShard(string project, string logstore, string shard, SplitShardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitShardWithOptions(project, logstore, shard, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](~~28976~~).
          *
          * @param request SplitShardRequest
          * @return SplitShardResponse
         */
        public async Task<SplitShardResponse> SplitShardAsync(string project, string logstore, string shard, SplitShardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitShardWithOptionsAsync(project, logstore, shard, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request TagResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourcesResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request TagResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/tag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request TagResourcesRequest
          * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request TagResourcesRequest
          * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UntagResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/untag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UntagResourcesRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                body["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/untag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAnnotationDataSetResponse UpdateAnnotationDataSetWithOptions(string datasetId, UpdateAnnotationDataSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateAnnotationDataSetResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateAnnotationDataSetResponse> UpdateAnnotationDataSetWithOptionsAsync(string datasetId, UpdateAnnotationDataSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnnotationDataSet",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationdataset/" + datasetId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateAnnotationDataSetResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateAnnotationDataSetResponse UpdateAnnotationDataSet(string datasetId, UpdateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAnnotationDataSetWithOptions(datasetId, request, headers, runtime);
        }

        public async Task<UpdateAnnotationDataSetResponse> UpdateAnnotationDataSetAsync(string datasetId, UpdateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAnnotationDataSetWithOptionsAsync(datasetId, request, headers, runtime);
        }

        public UpdateAnnotationLabelResponse UpdateAnnotationLabelWithOptions(UpdateAnnotationLabelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateAnnotationLabelResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateAnnotationLabelResponse> UpdateAnnotationLabelWithOptionsAsync(UpdateAnnotationLabelRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAnnotationLabel",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ml/annotationlabel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateAnnotationLabelResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateAnnotationLabelResponse UpdateAnnotationLabel(UpdateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAnnotationLabelWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAnnotationLabelResponse> UpdateAnnotationLabelAsync(UpdateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAnnotationLabelWithOptionsAsync(request, headers, runtime);
        }

        public UpdateConfigResponse UpdateConfigWithOptions(string project, string configName, UpdateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateConfigResponse> UpdateConfigWithOptionsAsync(string project, string configName, UpdateConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/configs/" + configName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateConfigResponse UpdateConfig(string project, string configName, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigWithOptions(project, configName, request, headers, runtime);
        }

        public async Task<UpdateConfigResponse> UpdateConfigAsync(string project, string configName, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigWithOptionsAsync(project, configName, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateConsumerGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConsumerGroupResponse
         */
        public UpdateConsumerGroupResponse UpdateConsumerGroupWithOptions(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateConsumerGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConsumerGroupResponse
         */
        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupWithOptionsAsync(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                body["order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timeout))
            {
                body["timeout"] = request.Timeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateConsumerGroupRequest
          * @return UpdateConsumerGroupResponse
         */
        public UpdateConsumerGroupResponse UpdateConsumerGroup(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConsumerGroupWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateConsumerGroupRequest
          * @return UpdateConsumerGroupResponse
         */
        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupAsync(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConsumerGroupWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

        public UpdateDashboardResponse UpdateDashboardWithOptions(string project, string dashboardName, UpdateDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attribute))
            {
                body["attribute"] = request.Attribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Charts))
            {
                body["charts"] = request.Charts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardName))
            {
                body["dashboardName"] = request.DashboardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards/" + dashboardName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateDashboardResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateDashboardResponse> UpdateDashboardWithOptionsAsync(string project, string dashboardName, UpdateDashboardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attribute))
            {
                body["attribute"] = request.Attribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Charts))
            {
                body["charts"] = request.Charts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardName))
            {
                body["dashboardName"] = request.DashboardName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateDashboard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/dashboards/" + dashboardName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateDashboardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateDashboardResponse UpdateDashboard(string project, string dashboardName, UpdateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDashboardWithOptions(project, dashboardName, request, headers, runtime);
        }

        public async Task<UpdateDashboardResponse> UpdateDashboardAsync(string project, string dashboardName, UpdateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDashboardWithOptionsAsync(project, dashboardName, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateIndexResponse
         */
        public UpdateIndexResponse UpdateIndexWithOptions(string project, string logstore, UpdateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                body["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduce))
            {
                body["log_reduce"] = request.LogReduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceBlackList))
            {
                body["log_reduce_black_list"] = request.LogReduceBlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceWhiteList))
            {
                body["log_reduce_white_list"] = request.LogReduceWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTextLen))
            {
                body["max_text_len"] = request.MaxTextLen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateIndexResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateIndexRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateIndexResponse
         */
        public async Task<UpdateIndexResponse> UpdateIndexWithOptionsAsync(string project, string logstore, UpdateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line))
            {
                body["line"] = request.Line;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduce))
            {
                body["log_reduce"] = request.LogReduce;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceBlackList))
            {
                body["log_reduce_black_list"] = request.LogReduceBlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogReduceWhiteList))
            {
                body["log_reduce_white_list"] = request.LogReduceWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxTextLen))
            {
                body["max_text_len"] = request.MaxTextLen;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateIndexResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateIndexRequest
          * @return UpdateIndexResponse
         */
        public UpdateIndexResponse UpdateIndex(string project, string logstore, UpdateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIndexWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateIndexRequest
          * @return UpdateIndexResponse
         */
        public async Task<UpdateIndexResponse> UpdateIndexAsync(string project, string logstore, UpdateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIndexWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          * *   You can call the UpdateLogStore operation to change only the time-to-live (TTL) attribute.
          *
          * @param request UpdateLogStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateLogStoreResponse
         */
        public UpdateLogStoreResponse UpdateLogStoreWithOptions(string project, string logstore, UpdateLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendMeta))
            {
                body["appendMeta"] = request.AppendMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSplit))
            {
                body["autoSplit"] = request.AutoSplit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTracking))
            {
                body["enable_tracking"] = request.EnableTracking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf))
            {
                body["encrypt_conf"] = request.EncryptConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTtl))
            {
                body["hot_ttl"] = request.HotTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                body["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSplitShard))
            {
                body["maxSplitShard"] = request.MaxSplitShard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardCount))
            {
                body["shardCount"] = request.ShardCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryType))
            {
                body["telemetryType"] = request.TelemetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLogStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          * *   You can call the UpdateLogStore operation to change only the time-to-live (TTL) attribute.
          *
          * @param request UpdateLogStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateLogStoreResponse
         */
        public async Task<UpdateLogStoreResponse> UpdateLogStoreWithOptionsAsync(string project, string logstore, UpdateLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppendMeta))
            {
                body["appendMeta"] = request.AppendMeta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoSplit))
            {
                body["autoSplit"] = request.AutoSplit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTracking))
            {
                body["enable_tracking"] = request.EnableTracking;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf))
            {
                body["encrypt_conf"] = request.EncryptConf;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HotTtl))
            {
                body["hot_ttl"] = request.HotTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogstoreName))
            {
                body["logstoreName"] = request.LogstoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxSplitShard))
            {
                body["maxSplitShard"] = request.MaxSplitShard;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                body["mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShardCount))
            {
                body["shardCount"] = request.ShardCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TelemetryType))
            {
                body["telemetryType"] = request.TelemetryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ttl))
            {
                body["ttl"] = request.Ttl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLogStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          * *   You can call the UpdateLogStore operation to change only the time-to-live (TTL) attribute.
          *
          * @param request UpdateLogStoreRequest
          * @return UpdateLogStoreResponse
         */
        public UpdateLogStoreResponse UpdateLogStore(string project, string logstore, UpdateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogStoreWithOptions(project, logstore, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * *   Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          * *   You can call the UpdateLogStore operation to change only the time-to-live (TTL) attribute.
          *
          * @param request UpdateLogStoreRequest
          * @return UpdateLogStoreResponse
         */
        public async Task<UpdateLogStoreResponse> UpdateLogStoreAsync(string project, string logstore, UpdateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogStoreWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        public UpdateLogStoreMeteringModeResponse UpdateLogStoreMeteringModeWithOptions(string project, string logstore, UpdateLogStoreMeteringModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeteringMode))
            {
                body["meteringMode"] = request.MeteringMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/meteringmode",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLogStoreMeteringModeResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateLogStoreMeteringModeResponse> UpdateLogStoreMeteringModeWithOptionsAsync(string project, string logstore, UpdateLogStoreMeteringModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MeteringMode))
            {
                body["meteringMode"] = request.MeteringMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/meteringmode",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLogStoreMeteringModeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateLogStoreMeteringModeResponse UpdateLogStoreMeteringMode(string project, string logstore, UpdateLogStoreMeteringModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogStoreMeteringModeWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<UpdateLogStoreMeteringModeResponse> UpdateLogStoreMeteringModeAsync(string project, string logstore, UpdateLogStoreMeteringModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogStoreMeteringModeWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateLoggingRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateLoggingResponse
         */
        public UpdateLoggingResponse UpdateLoggingWithOptions(string project, UpdateLoggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingDetails))
            {
                body["loggingDetails"] = request.LoggingDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingProject))
            {
                body["loggingProject"] = request.LoggingProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLoggingResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateLoggingRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateLoggingResponse
         */
        public async Task<UpdateLoggingResponse> UpdateLoggingWithOptionsAsync(string project, UpdateLoggingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingDetails))
            {
                body["loggingDetails"] = request.LoggingDetails;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingProject))
            {
                body["loggingProject"] = request.LoggingProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogging",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logging",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLoggingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateLoggingRequest
          * @return UpdateLoggingResponse
         */
        public UpdateLoggingResponse UpdateLogging(string project, UpdateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLoggingWithOptions(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateLoggingRequest
          * @return UpdateLoggingResponse
         */
        public async Task<UpdateLoggingResponse> UpdateLoggingAsync(string project, UpdateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLoggingWithOptionsAsync(project, request, headers, runtime);
        }

        public UpdateLogtailPipelineConfigResponse UpdateLogtailPipelineConfigWithOptions(string project, string configName, UpdateLogtailPipelineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregators))
            {
                body["aggregators"] = request.Aggregators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                body["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flushers))
            {
                body["flushers"] = request.Flushers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Global))
            {
                body["global"] = request.Global;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                body["inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSample))
            {
                body["logSample"] = request.LogSample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs/" + configName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLogtailPipelineConfigResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateLogtailPipelineConfigResponse> UpdateLogtailPipelineConfigWithOptionsAsync(string project, string configName, UpdateLogtailPipelineConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aggregators))
            {
                body["aggregators"] = request.Aggregators;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                body["configName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flushers))
            {
                body["flushers"] = request.Flushers;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Global))
            {
                body["global"] = request.Global;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Inputs))
            {
                body["inputs"] = request.Inputs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogSample))
            {
                body["logSample"] = request.LogSample;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Processors))
            {
                body["processors"] = request.Processors;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateLogtailPipelineConfig",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/pipelineconfigs/" + configName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateLogtailPipelineConfigResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateLogtailPipelineConfigResponse UpdateLogtailPipelineConfig(string project, string configName, UpdateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogtailPipelineConfigWithOptions(project, configName, request, headers, runtime);
        }

        public async Task<UpdateLogtailPipelineConfigResponse> UpdateLogtailPipelineConfigAsync(string project, string configName, UpdateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogtailPipelineConfigWithOptionsAsync(project, configName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateMachineGroupResponse
         */
        public UpdateMachineGroupResponse UpdateMachineGroupWithOptions(string project, string groupName, UpdateMachineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAttribute))
            {
                body["groupAttribute"] = request.GroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineIdentifyType))
            {
                body["machineIdentifyType"] = request.MachineIdentifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineList))
            {
                body["machineList"] = request.MachineList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + groupName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMachineGroupResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateMachineGroupResponse
         */
        public async Task<UpdateMachineGroupResponse> UpdateMachineGroupWithOptionsAsync(string project, string groupName, UpdateMachineGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupAttribute))
            {
                body["groupAttribute"] = request.GroupAttribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                body["groupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                body["groupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineIdentifyType))
            {
                body["machineIdentifyType"] = request.MachineIdentifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MachineList))
            {
                body["machineList"] = request.MachineList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMachineGroup",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + groupName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMachineGroupResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupRequest
          * @return UpdateMachineGroupResponse
         */
        public UpdateMachineGroupResponse UpdateMachineGroup(string project, string groupName, UpdateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMachineGroupWithOptions(project, groupName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupRequest
          * @return UpdateMachineGroupResponse
         */
        public async Task<UpdateMachineGroupResponse> UpdateMachineGroupAsync(string project, string groupName, UpdateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMachineGroupWithOptionsAsync(project, groupName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupMachineRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateMachineGroupMachineResponse
         */
        public UpdateMachineGroupMachineResponse UpdateMachineGroupMachineWithOptions(string project, string machineGroup, UpdateMachineGroupMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMachineGroupMachine",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/machines",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMachineGroupMachineResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupMachineRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateMachineGroupMachineResponse
         */
        public async Task<UpdateMachineGroupMachineResponse> UpdateMachineGroupMachineWithOptionsAsync(string project, string machineGroup, UpdateMachineGroupMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMachineGroupMachine",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/machinegroups/" + machineGroup + "/machines",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMachineGroupMachineResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupMachineRequest
          * @return UpdateMachineGroupMachineResponse
         */
        public UpdateMachineGroupMachineResponse UpdateMachineGroupMachine(string project, string machineGroup, UpdateMachineGroupMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMachineGroupMachineWithOptions(project, machineGroup, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateMachineGroupMachineRequest
          * @return UpdateMachineGroupMachineResponse
         */
        public async Task<UpdateMachineGroupMachineResponse> UpdateMachineGroupMachineAsync(string project, string machineGroup, UpdateMachineGroupMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMachineGroupMachineWithOptionsAsync(project, machineGroup, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateOssExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateOssExternalStoreResponse
         */
        public UpdateOssExternalStoreResponse UpdateOssExternalStoreWithOptions(string project, string externalStoreName, UpdateOssExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOssExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOssExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateOssExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateOssExternalStoreResponse
         */
        public async Task<UpdateOssExternalStoreResponse> UpdateOssExternalStoreWithOptionsAsync(string project, string externalStoreName, UpdateOssExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOssExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOssExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateOssExternalStoreRequest
          * @return UpdateOssExternalStoreResponse
         */
        public UpdateOssExternalStoreResponse UpdateOssExternalStore(string project, string externalStoreName, UpdateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOssExternalStoreWithOptions(project, externalStoreName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateOssExternalStoreRequest
          * @return UpdateOssExternalStoreResponse
         */
        public async Task<UpdateOssExternalStoreResponse> UpdateOssExternalStoreAsync(string project, string externalStoreName, UpdateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOssExternalStoreWithOptionsAsync(project, externalStoreName, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateProjectRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProjectWithOptions(string project, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(Execute(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateProjectRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(string project, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateProjectRequest
          * @return UpdateProjectResponse
         */
        public UpdateProjectResponse UpdateProject(string project, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(project, request, headers, runtime);
        }

        /**
          * ### Usage notes
          * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateProjectRequest
          * @return UpdateProjectResponse
         */
        public async Task<UpdateProjectResponse> UpdateProjectAsync(string project, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(project, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateRdsExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateRdsExternalStoreResponse
         */
        public UpdateRdsExternalStoreResponse UpdateRdsExternalStoreWithOptions(string project, string externalStoreName, UpdateRdsExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRdsExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateRdsExternalStoreResponse>(Execute(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateRdsExternalStoreRequest
          * @param headers map
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateRdsExternalStoreResponse
         */
        public async Task<UpdateRdsExternalStoreResponse> UpdateRdsExternalStoreWithOptionsAsync(string project, string externalStoreName, UpdateRdsExternalStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExternalStoreName))
            {
                body["externalStoreName"] = request.ExternalStoreName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameter))
            {
                body["parameter"] = request.Parameter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRdsExternalStore",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/externalstores/" + externalStoreName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateRdsExternalStoreResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateRdsExternalStoreRequest
          * @return UpdateRdsExternalStoreResponse
         */
        public UpdateRdsExternalStoreResponse UpdateRdsExternalStore(string project, string externalStoreName, UpdateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRdsExternalStoreWithOptions(project, externalStoreName, request, headers, runtime);
        }

        /**
          * Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
          *
          * @param request UpdateRdsExternalStoreRequest
          * @return UpdateRdsExternalStoreResponse
         */
        public async Task<UpdateRdsExternalStoreResponse> UpdateRdsExternalStoreAsync(string project, string externalStoreName, UpdateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRdsExternalStoreWithOptionsAsync(project, externalStoreName, request, headers, runtime);
        }

        public UpdateSavedSearchResponse UpdateSavedSearchWithOptions(string project, string savedsearchName, UpdateSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                body["logstore"] = request.Logstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SavedsearchName))
            {
                body["savedsearchName"] = request.SavedsearchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches/" + savedsearchName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSavedSearchResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateSavedSearchResponse> UpdateSavedSearchWithOptionsAsync(string project, string savedsearchName, UpdateSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                body["logstore"] = request.Logstore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SavedsearchName))
            {
                body["savedsearchName"] = request.SavedsearchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SearchQuery))
            {
                body["searchQuery"] = request.SearchQuery;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                body["topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSavedSearch",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/savedsearches/" + savedsearchName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSavedSearchResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateSavedSearchResponse UpdateSavedSearch(string project, string savedsearchName, UpdateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSavedSearchWithOptions(project, savedsearchName, request, headers, runtime);
        }

        public async Task<UpdateSavedSearchResponse> UpdateSavedSearchAsync(string project, string savedsearchName, UpdateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSavedSearchWithOptionsAsync(project, savedsearchName, request, headers, runtime);
        }

        public UpsertCollectionPolicyResponse UpsertCollectionPolicyWithOptions(UpsertCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attribute))
            {
                body["attribute"] = request.Attribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CentralizeConfig))
            {
                body["centralizeConfig"] = request.CentralizeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CentralizeEnabled))
            {
                body["centralizeEnabled"] = request.CentralizeEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                body["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyConfig))
            {
                body["policyConfig"] = request.PolicyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertCollectionPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertCollectionPolicyResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpsertCollectionPolicyResponse> UpsertCollectionPolicyWithOptionsAsync(UpsertCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Attribute))
            {
                body["attribute"] = request.Attribute;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CentralizeConfig))
            {
                body["centralizeConfig"] = request.CentralizeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CentralizeEnabled))
            {
                body["centralizeEnabled"] = request.CentralizeEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                body["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                body["enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyConfig))
            {
                body["policyConfig"] = request.PolicyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                body["productCode"] = request.ProductCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpsertCollectionPolicy",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/collectionpolicy",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpsertCollectionPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpsertCollectionPolicyResponse UpsertCollectionPolicy(UpsertCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpsertCollectionPolicyWithOptions(request, headers, runtime);
        }

        public async Task<UpsertCollectionPolicyResponse> UpsertCollectionPolicyAsync(UpsertCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpsertCollectionPolicyWithOptionsAsync(request, headers, runtime);
        }

    }
}
