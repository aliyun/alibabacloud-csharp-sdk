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

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            AlibabaCloud.GatewaySls.Client gatewayClient = new AlibabaCloud.GatewaySls.Client();
            this._spi = gatewayClient;
            this._signatureAlgorithm = "v2";
            this._endpointRule = "central";
        }


        /**
         * @summary Applies a Logtail configuration to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Applies a Logtail configuration to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Applies a Logtail configuration to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Applies a Logtail configuration to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @return ApplyConfigToMachineGroupResponse
         */
        public async Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroupAsync(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyConfigToMachineGroupWithOptionsAsync(project, machineGroup, configName, headers, runtime);
        }

        /**
         * @summary Modifies the resource group of a resource.
         *
         * @param request ChangeResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
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

        /**
         * @summary Modifies the resource group of a resource.
         *
         * @param request ChangeResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
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

        /**
         * @summary Modifies the resource group of a resource.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(string project, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Modifies the resource group of a resource.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(string project, ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Sends heartbeats to a server from a consumer.
         *
         * @description ### Usage notes
         * *   Connections between consumers and servers are established by sending heartbeats at regular intervals. If a server does not receive heartbeats from a consumer on schedule, the server deletes the consumer.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request ConsumerGroupHeartBeatRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsumerGroupHeartBeatResponse
         */
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

        /**
         * @summary Sends heartbeats to a server from a consumer.
         *
         * @description ### Usage notes
         * *   Connections between consumers and servers are established by sending heartbeats at regular intervals. If a server does not receive heartbeats from a consumer on schedule, the server deletes the consumer.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request ConsumerGroupHeartBeatRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsumerGroupHeartBeatResponse
         */
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

        /**
         * @summary Sends heartbeats to a server from a consumer.
         *
         * @description ### Usage notes
         * *   Connections between consumers and servers are established by sending heartbeats at regular intervals. If a server does not receive heartbeats from a consumer on schedule, the server deletes the consumer.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request ConsumerGroupHeartBeatRequest
         * @return ConsumerGroupHeartBeatResponse
         */
        public ConsumerGroupHeartBeatResponse ConsumerGroupHeartBeat(string project, string logstore, string consumerGroup, ConsumerGroupHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConsumerGroupHeartBeatWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        /**
         * @summary Sends heartbeats to a server from a consumer.
         *
         * @description ### Usage notes
         * *   Connections between consumers and servers are established by sending heartbeats at regular intervals. If a server does not receive heartbeats from a consumer on schedule, the server deletes the consumer.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request ConsumerGroupHeartBeatRequest
         * @return ConsumerGroupHeartBeatResponse
         */
        public async Task<ConsumerGroupHeartBeatResponse> ConsumerGroupHeartBeatAsync(string project, string logstore, string consumerGroup, ConsumerGroupHeartBeatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConsumerGroupHeartBeatWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

        /**
         * @summary Updates the data consumption progress.
         *
         * @description *   If you do not specify a consumer, you must set **forceSuccess** to **true**. Otherwise, the checkpoint cannot be updated.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ConsumerGroupUpdateCheckPointRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsumerGroupUpdateCheckPointResponse
         */
        public ConsumerGroupUpdateCheckPointResponse ConsumerGroupUpdateCheckPointWithOptions(string project, string logstore, string consumerGroup, ConsumerGroupUpdateCheckPointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Consumer))
            {
                query["consumer"] = request.Consumer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSuccess))
            {
                query["forceSuccess"] = request.ForceSuccess;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                body["checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                body["shard"] = request.Shard;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConsumerGroupUpdateCheckPoint",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup + "?type=checkpoint",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ConsumerGroupUpdateCheckPointResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Updates the data consumption progress.
         *
         * @description *   If you do not specify a consumer, you must set **forceSuccess** to **true**. Otherwise, the checkpoint cannot be updated.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ConsumerGroupUpdateCheckPointRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConsumerGroupUpdateCheckPointResponse
         */
        public async Task<ConsumerGroupUpdateCheckPointResponse> ConsumerGroupUpdateCheckPointWithOptionsAsync(string project, string logstore, string consumerGroup, ConsumerGroupUpdateCheckPointRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Consumer))
            {
                query["consumer"] = request.Consumer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceSuccess))
            {
                query["forceSuccess"] = request.ForceSuccess;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checkpoint))
            {
                body["checkpoint"] = request.Checkpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Shard))
            {
                body["shard"] = request.Shard;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConsumerGroupUpdateCheckPoint",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/consumergroups/" + consumerGroup + "?type=checkpoint",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ConsumerGroupUpdateCheckPointResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the data consumption progress.
         *
         * @description *   If you do not specify a consumer, you must set **forceSuccess** to **true**. Otherwise, the checkpoint cannot be updated.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ConsumerGroupUpdateCheckPointRequest
         * @return ConsumerGroupUpdateCheckPointResponse
         */
        public ConsumerGroupUpdateCheckPointResponse ConsumerGroupUpdateCheckPoint(string project, string logstore, string consumerGroup, ConsumerGroupUpdateCheckPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ConsumerGroupUpdateCheckPointWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        /**
         * @summary Updates the data consumption progress.
         *
         * @description *   If you do not specify a consumer, you must set **forceSuccess** to **true**. Otherwise, the checkpoint cannot be updated.
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         *
         * @param request ConsumerGroupUpdateCheckPointRequest
         * @return ConsumerGroupUpdateCheckPointResponse
         */
        public async Task<ConsumerGroupUpdateCheckPointResponse> ConsumerGroupUpdateCheckPointAsync(string project, string logstore, string consumerGroup, ConsumerGroupUpdateCheckPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ConsumerGroupUpdateCheckPointWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

        /**
         * @summary CreateAlert
         *
         * @param request CreateAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlertResponse
         */
        public CreateAlertResponse CreateAlertWithOptions(string project, CreateAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAlertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary CreateAlert
         *
         * @param request CreateAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAlertResponse
         */
        public async Task<CreateAlertResponse> CreateAlertWithOptionsAsync(string project, CreateAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAlertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary CreateAlert
         *
         * @param request CreateAlertRequest
         * @return CreateAlertResponse
         */
        public CreateAlertResponse CreateAlert(string project, CreateAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAlertWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary CreateAlert
         *
         * @param request CreateAlertRequest
         * @return CreateAlertResponse
         */
        public async Task<CreateAlertResponse> CreateAlertAsync(string project, CreateAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAlertWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Creates a dataset.
         *
         * @param request CreateAnnotationDataSetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAnnotationDataSetResponse
         */
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

        /**
         * @summary Creates a dataset.
         *
         * @param request CreateAnnotationDataSetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAnnotationDataSetResponse
         */
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

        /**
         * @summary Creates a dataset.
         *
         * @param request CreateAnnotationDataSetRequest
         * @return CreateAnnotationDataSetResponse
         */
        public CreateAnnotationDataSetResponse CreateAnnotationDataSet(CreateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAnnotationDataSetWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a dataset.
         *
         * @param request CreateAnnotationDataSetRequest
         * @return CreateAnnotationDataSetResponse
         */
        public async Task<CreateAnnotationDataSetResponse> CreateAnnotationDataSetAsync(CreateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAnnotationDataSetWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a tag table.
         *
         * @param request CreateAnnotationLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAnnotationLabelResponse
         */
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

        /**
         * @summary Creates a tag table.
         *
         * @param request CreateAnnotationLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAnnotationLabelResponse
         */
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

        /**
         * @summary Creates a tag table.
         *
         * @param request CreateAnnotationLabelRequest
         * @return CreateAnnotationLabelResponse
         */
        public CreateAnnotationLabelResponse CreateAnnotationLabel(CreateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAnnotationLabelWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a tag table.
         *
         * @param request CreateAnnotationLabelRequest
         * @return CreateAnnotationLabelResponse
         */
        public async Task<CreateAnnotationLabelResponse> CreateAnnotationLabelAsync(CreateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAnnotationLabelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   You can create up to 100 Logtail configurations in a project.
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request CreateConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigResponse
         */
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

        /**
         * @summary Creates a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   You can create up to 100 Logtail configurations in a project.
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request CreateConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConfigResponse
         */
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

        /**
         * @summary Creates a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   You can create up to 100 Logtail configurations in a project.
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request CreateConfigRequest
         * @return CreateConfigResponse
         */
        public CreateConfigResponse CreateConfig(string project, CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConfigWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Creates a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   You can create up to 100 Logtail configurations in a project.
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request CreateConfigRequest
         * @return CreateConfigResponse
         */
        public async Task<CreateConfigResponse> CreateConfigAsync(string project, CreateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Creates a consumer group for a specified Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   You can create up to 30 consumer groups for a Logstore.
         * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](https://help.aliyun.com/document_detail/120035.html) and [Use consumer groups to consume data](https://help.aliyun.com/document_detail/28998.html).
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
         * @summary Creates a consumer group for a specified Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   You can create up to 30 consumer groups for a Logstore.
         * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](https://help.aliyun.com/document_detail/120035.html) and [Use consumer groups to consume data](https://help.aliyun.com/document_detail/28998.html).
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
         * @summary Creates a consumer group for a specified Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   You can create up to 30 consumer groups for a Logstore.
         * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](https://help.aliyun.com/document_detail/120035.html) and [Use consumer groups to consume data](https://help.aliyun.com/document_detail/28998.html).
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
         * @summary Creates a consumer group for a specified Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   You can create up to 30 consumer groups for a Logstore.
         * *   Simple Log Service provides examples of both regular log consumption and consumer group-based log consumption by using Simple Log Service SDKs for Java. For more information, see [Consume log data](https://help.aliyun.com/document_detail/120035.html) and [Use consumer groups to consume data](https://help.aliyun.com/document_detail/28998.html).
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

        /**
         * @summary Creates a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request CreateDashboardRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDashboardResponse
         */
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

        /**
         * @summary Creates a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request CreateDashboardRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDashboardResponse
         */
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

        /**
         * @summary Creates a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request CreateDashboardRequest
         * @return CreateDashboardResponse
         */
        public CreateDashboardResponse CreateDashboard(string project, CreateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDashboardWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Creates a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request CreateDashboardRequest
         * @return CreateDashboardResponse
         */
        public async Task<CreateDashboardResponse> CreateDashboardAsync(string project, CreateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDashboardWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Binds a new custom domain name to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Binds a new custom domain name to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Binds a new custom domain name to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Binds a new custom domain name to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary 创建下载任务
         *
         * @param request CreateDownloadJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadJobResponse
         */
        public CreateDownloadJobResponse CreateDownloadJobWithOptions(string project, CreateDownloadJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadJob",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDownloadJobResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建下载任务
         *
         * @param request CreateDownloadJobRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDownloadJobResponse
         */
        public async Task<CreateDownloadJobResponse> CreateDownloadJobWithOptionsAsync(string project, CreateDownloadJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDownloadJob",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateDownloadJobResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建下载任务
         *
         * @param request CreateDownloadJobRequest
         * @return CreateDownloadJobResponse
         */
        public CreateDownloadJobResponse CreateDownloadJob(string project, CreateDownloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDownloadJobWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建下载任务
         *
         * @param request CreateDownloadJobRequest
         * @return CreateDownloadJobResponse
         */
        public async Task<CreateDownloadJobResponse> CreateDownloadJobAsync(string project, CreateDownloadJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDownloadJobWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建数据加工任务
         *
         * @param request CreateETLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateETLResponse
         */
        public CreateETLResponse CreateETLWithOptions(string project, CreateETLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateETLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建数据加工任务
         *
         * @param request CreateETLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateETLResponse
         */
        public async Task<CreateETLResponse> CreateETLWithOptionsAsync(string project, CreateETLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateETLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建数据加工任务
         *
         * @param request CreateETLRequest
         * @return CreateETLResponse
         */
        public CreateETLResponse CreateETL(string project, CreateETLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateETLWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建数据加工任务
         *
         * @param request CreateETLRequest
         * @return CreateETLResponse
         */
        public async Task<CreateETLResponse> CreateETLAsync(string project, CreateETLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateETLWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Creates indexes for a Logstore.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates indexes for a Logstore.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates indexes for a Logstore.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates indexes for a Logstore.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Create a Logstore
         *
         * @description ### Usage notes
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfrequentAccessTTL))
            {
                body["infrequentAccessTTL"] = request.InfrequentAccessTTL;
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
         * @summary Create a Logstore
         *
         * @description ### Usage notes
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfrequentAccessTTL))
            {
                body["infrequentAccessTTL"] = request.InfrequentAccessTTL;
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
         * @summary Create a Logstore
         *
         * @description ### Usage notes
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
         * @summary Create a Logstore
         *
         * @description ### Usage notes
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
         * @summary Enables the service log feature for a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Enables the service log feature for a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Enables the service log feature for a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Enables the service log feature for a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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

        /**
         * @summary Creates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request CreateLogtailPipelineConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Creates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request CreateLogtailPipelineConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Creates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request CreateLogtailPipelineConfigRequest
         * @return CreateLogtailPipelineConfigResponse
         */
        public CreateLogtailPipelineConfigResponse CreateLogtailPipelineConfig(string project, CreateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLogtailPipelineConfigWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Creates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request CreateLogtailPipelineConfigRequest
         * @return CreateLogtailPipelineConfigResponse
         */
        public async Task<CreateLogtailPipelineConfigResponse> CreateLogtailPipelineConfigAsync(string project, CreateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLogtailPipelineConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Creates a machine group.
         *
         * @description ### Usage notes
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
         * @summary Creates a machine group.
         *
         * @description ### Usage notes
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
         * @summary Creates a machine group.
         *
         * @description ### Usage notes
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
         * @summary Creates a machine group.
         *
         * @description ### Usage notes
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
         * @summary 创建OSS投递任务
         *
         * @param request CreateOSSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOSSExportResponse
         */
        public CreateOSSExportResponse CreateOSSExportWithOptions(string project, CreateOSSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOSSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建OSS投递任务
         *
         * @param request CreateOSSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOSSExportResponse
         */
        public async Task<CreateOSSExportResponse> CreateOSSExportWithOptionsAsync(string project, CreateOSSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOSSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建OSS投递任务
         *
         * @param request CreateOSSExportRequest
         * @return CreateOSSExportResponse
         */
        public CreateOSSExportResponse CreateOSSExport(string project, CreateOSSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOSSExportWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建OSS投递任务
         *
         * @param request CreateOSSExportRequest
         * @return CreateOSSExportResponse
         */
        public async Task<CreateOSSExportResponse> CreateOSSExportAsync(string project, CreateOSSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOSSExportWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建OSSHDFS投递任务
         *
         * @param request CreateOSSHDFSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOSSHDFSExportResponse
         */
        public CreateOSSHDFSExportResponse CreateOSSHDFSExportWithOptions(string project, CreateOSSHDFSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOSSHDFSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建OSSHDFS投递任务
         *
         * @param request CreateOSSHDFSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOSSHDFSExportResponse
         */
        public async Task<CreateOSSHDFSExportResponse> CreateOSSHDFSExportWithOptionsAsync(string project, CreateOSSHDFSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOSSHDFSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建OSSHDFS投递任务
         *
         * @param request CreateOSSHDFSExportRequest
         * @return CreateOSSHDFSExportResponse
         */
        public CreateOSSHDFSExportResponse CreateOSSHDFSExport(string project, CreateOSSHDFSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOSSHDFSExportWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建OSSHDFS投递任务
         *
         * @param request CreateOSSHDFSExportRequest
         * @return CreateOSSHDFSExportResponse
         */
        public async Task<CreateOSSHDFSExportResponse> CreateOSSHDFSExportAsync(string project, CreateOSSHDFSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOSSHDFSExportWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建OSS导入任务
         *
         * @param request CreateOSSIngestionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOSSIngestionResponse
         */
        public CreateOSSIngestionResponse CreateOSSIngestionWithOptions(string project, CreateOSSIngestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOSSIngestionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建OSS导入任务
         *
         * @param request CreateOSSIngestionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateOSSIngestionResponse
         */
        public async Task<CreateOSSIngestionResponse> CreateOSSIngestionWithOptionsAsync(string project, CreateOSSIngestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOSSIngestionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建OSS导入任务
         *
         * @param request CreateOSSIngestionRequest
         * @return CreateOSSIngestionResponse
         */
        public CreateOSSIngestionResponse CreateOSSIngestion(string project, CreateOSSIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOSSIngestionWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建OSS导入任务
         *
         * @param request CreateOSSIngestionRequest
         * @return CreateOSSIngestionResponse
         */
        public async Task<CreateOSSIngestionResponse> CreateOSSIngestionAsync(string project, CreateOSSIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOSSIngestionWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Creates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Creates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Creates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Creates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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

        /**
         * @summary Creates a project.
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
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

        /**
         * @summary Creates a project.
         *
         * @param request CreateProjectRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateProjectResponse
         */
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

        /**
         * @summary Creates a project.
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates a project.
         *
         * @param request CreateProjectRequest
         * @return CreateProjectResponse
         */
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Creates a saved search.
         *
         * @description ### Usage notes
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
         * @summary Creates a saved search.
         *
         * @description ### Usage notes
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
         * @summary Creates a saved search.
         *
         * @description ### Usage notes
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
         * @summary Creates a saved search.
         *
         * @description ### Usage notes
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

        /**
         * @summary 创建定时SQL任务
         *
         * @param request CreateScheduledSQLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledSQLResponse
         */
        public CreateScheduledSQLResponse CreateScheduledSQLWithOptions(string project, CreateScheduledSQLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateScheduledSQLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建定时SQL任务
         *
         * @param request CreateScheduledSQLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledSQLResponse
         */
        public async Task<CreateScheduledSQLResponse> CreateScheduledSQLWithOptionsAsync(string project, CreateScheduledSQLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateScheduledSQLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建定时SQL任务
         *
         * @param request CreateScheduledSQLRequest
         * @return CreateScheduledSQLResponse
         */
        public CreateScheduledSQLResponse CreateScheduledSQL(string project, CreateScheduledSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateScheduledSQLWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建定时SQL任务
         *
         * @param request CreateScheduledSQLRequest
         * @return CreateScheduledSQLResponse
         */
        public async Task<CreateScheduledSQLResponse> CreateScheduledSQLAsync(string project, CreateScheduledSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateScheduledSQLWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建独享sql实例
         *
         * @param request CreateSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSqlInstanceResponse
         */
        public CreateSqlInstanceResponse CreateSqlInstanceWithOptions(string project, CreateSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                body["cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAsDefault))
            {
                body["useAsDefault"] = request.UseAsDefault;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlInstance",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/sqlinstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateSqlInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建独享sql实例
         *
         * @param request CreateSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSqlInstanceResponse
         */
        public async Task<CreateSqlInstanceResponse> CreateSqlInstanceWithOptionsAsync(string project, CreateSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                body["cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAsDefault))
            {
                body["useAsDefault"] = request.UseAsDefault;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSqlInstance",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/sqlinstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateSqlInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建独享sql实例
         *
         * @param request CreateSqlInstanceRequest
         * @return CreateSqlInstanceResponse
         */
        public CreateSqlInstanceResponse CreateSqlInstance(string project, CreateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSqlInstanceWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建独享sql实例
         *
         * @param request CreateSqlInstanceRequest
         * @return CreateSqlInstanceResponse
         */
        public async Task<CreateSqlInstanceResponse> CreateSqlInstanceAsync(string project, CreateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSqlInstanceWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建StoreView
         *
         * @param request CreateStoreViewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoreViewResponse
         */
        public CreateStoreViewResponse CreateStoreViewWithOptions(string project, CreateStoreViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["stores"] = request.Stores;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateStoreViewResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建StoreView
         *
         * @param request CreateStoreViewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateStoreViewResponse
         */
        public async Task<CreateStoreViewResponse> CreateStoreViewWithOptionsAsync(string project, CreateStoreViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["stores"] = request.Stores;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateStoreViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建StoreView
         *
         * @param request CreateStoreViewRequest
         * @return CreateStoreViewResponse
         */
        public CreateStoreViewResponse CreateStoreView(string project, CreateStoreViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateStoreViewWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 创建StoreView
         *
         * @param request CreateStoreViewRequest
         * @return CreateStoreViewResponse
         */
        public async Task<CreateStoreViewResponse> CreateStoreViewAsync(string project, CreateStoreViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateStoreViewWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 创建Ticket
         *
         * @param request CreateTicketRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicketResponse
         */
        public CreateTicketResponse CreateTicketWithOptions(CreateTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                query["expirationTime"] = request.ExpirationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 创建Ticket
         *
         * @param request CreateTicketRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTicketResponse
         */
        public async Task<CreateTicketResponse> CreateTicketWithOptionsAsync(CreateTicketRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpirationTime))
            {
                query["expirationTime"] = request.ExpirationTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTicket",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/tickets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTicketResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 创建Ticket
         *
         * @param request CreateTicketRequest
         * @return CreateTicketResponse
         */
        public CreateTicketResponse CreateTicket(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTicketWithOptions(request, headers, runtime);
        }

        /**
         * @summary 创建Ticket
         *
         * @param request CreateTicketRequest
         * @return CreateTicketResponse
         */
        public async Task<CreateTicketResponse> CreateTicketAsync(CreateTicketRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTicketWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除告警
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlertResponse
         */
        public DeleteAlertResponse DeleteAlertWithOptions(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAlertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除告警
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlertResponse
         */
        public async Task<DeleteAlertResponse> DeleteAlertWithOptionsAsync(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAlertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除告警
         *
         * @return DeleteAlertResponse
         */
        public DeleteAlertResponse DeleteAlert(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertWithOptions(project, alertName, headers, runtime);
        }

        /**
         * @summary 删除告警
         *
         * @return DeleteAlertResponse
         */
        public async Task<DeleteAlertResponse> DeleteAlertAsync(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertWithOptionsAsync(project, alertName, headers, runtime);
        }

        /**
         * @summary Removes data from a dataset.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAnnotationDataResponse
         */
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

        /**
         * @summary Removes data from a dataset.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAnnotationDataResponse
         */
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

        /**
         * @summary Removes data from a dataset.
         *
         * @return DeleteAnnotationDataResponse
         */
        public DeleteAnnotationDataResponse DeleteAnnotationData(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAnnotationDataWithOptions(datasetId, annotationdataId, headers, runtime);
        }

        /**
         * @summary Removes data from a dataset.
         *
         * @return DeleteAnnotationDataResponse
         */
        public async Task<DeleteAnnotationDataResponse> DeleteAnnotationDataAsync(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAnnotationDataWithOptionsAsync(datasetId, annotationdataId, headers, runtime);
        }

        /**
         * @summary Deletes a dataset.
         *
         * @description You can delete a dataset only if no data exists in the dataset.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAnnotationDataSetResponse
         */
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

        /**
         * @summary Deletes a dataset.
         *
         * @description You can delete a dataset only if no data exists in the dataset.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAnnotationDataSetResponse
         */
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

        /**
         * @summary Deletes a dataset.
         *
         * @description You can delete a dataset only if no data exists in the dataset.
         *
         * @return DeleteAnnotationDataSetResponse
         */
        public DeleteAnnotationDataSetResponse DeleteAnnotationDataSet(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAnnotationDataSetWithOptions(datasetId, headers, runtime);
        }

        /**
         * @summary Deletes a dataset.
         *
         * @description You can delete a dataset only if no data exists in the dataset.
         *
         * @return DeleteAnnotationDataSetResponse
         */
        public async Task<DeleteAnnotationDataSetResponse> DeleteAnnotationDataSetAsync(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAnnotationDataSetWithOptionsAsync(datasetId, headers, runtime);
        }

        /**
         * @summary Deletes a tag table.
         *
         * @description Only non-built-in tags can be deleted.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAnnotationLabelResponse
         */
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

        /**
         * @summary Deletes a tag table.
         *
         * @description Only non-built-in tags can be deleted.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAnnotationLabelResponse
         */
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

        /**
         * @summary Deletes a tag table.
         *
         * @description Only non-built-in tags can be deleted.
         *
         * @return DeleteAnnotationLabelResponse
         */
        public DeleteAnnotationLabelResponse DeleteAnnotationLabel(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAnnotationLabelWithOptions(labelId, headers, runtime);
        }

        /**
         * @summary Deletes a tag table.
         *
         * @description Only non-built-in tags can be deleted.
         *
         * @return DeleteAnnotationLabelResponse
         */
        public async Task<DeleteAnnotationLabelResponse> DeleteAnnotationLabelAsync(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAnnotationLabelWithOptionsAsync(labelId, headers, runtime);
        }

        /**
         * @summary 通过调用DeleteCollectionPolicy删除配置的日志采集规则
         *
         * @description You must use the Simple Log Service endpoint for the China (Shanghai) or Singapore region to call the operation.
         *
         * @param request DeleteCollectionPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCollectionPolicyResponse
         */
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
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteCollectionPolicyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 通过调用DeleteCollectionPolicy删除配置的日志采集规则
         *
         * @description You must use the Simple Log Service endpoint for the China (Shanghai) or Singapore region to call the operation.
         *
         * @param request DeleteCollectionPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteCollectionPolicyResponse
         */
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
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteCollectionPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 通过调用DeleteCollectionPolicy删除配置的日志采集规则
         *
         * @description You must use the Simple Log Service endpoint for the China (Shanghai) or Singapore region to call the operation.
         *
         * @param request DeleteCollectionPolicyRequest
         * @return DeleteCollectionPolicyResponse
         */
        public DeleteCollectionPolicyResponse DeleteCollectionPolicy(string policyName, DeleteCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteCollectionPolicyWithOptions(policyName, request, headers, runtime);
        }

        /**
         * @summary 通过调用DeleteCollectionPolicy删除配置的日志采集规则
         *
         * @description You must use the Simple Log Service endpoint for the China (Shanghai) or Singapore region to call the operation.
         *
         * @param request DeleteCollectionPolicyRequest
         * @return DeleteCollectionPolicyResponse
         */
        public async Task<DeleteCollectionPolicyResponse> DeleteCollectionPolicyAsync(string policyName, DeleteCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteCollectionPolicyWithOptionsAsync(policyName, request, headers, runtime);
        }

        /**
         * @summary Deletes a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If a Logtail configuration is applied to a machine group, you cannot collect data from the machine group after you delete the Logtail configuration.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigResponse
         */
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

        /**
         * @summary Deletes a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If a Logtail configuration is applied to a machine group, you cannot collect data from the machine group after you delete the Logtail configuration.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConfigResponse
         */
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

        /**
         * @summary Deletes a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If a Logtail configuration is applied to a machine group, you cannot collect data from the machine group after you delete the Logtail configuration.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @return DeleteConfigResponse
         */
        public DeleteConfigResponse DeleteConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConfigWithOptions(project, configName, headers, runtime);
        }

        /**
         * @summary Deletes a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If a Logtail configuration is applied to a machine group, you cannot collect data from the machine group after you delete the Logtail configuration.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @return DeleteConfigResponse
         */
        public async Task<DeleteConfigResponse> DeleteConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
         * @summary Deletes a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(string project, string logstore, string consumerGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerGroupWithOptionsAsync(project, logstore, consumerGroup, headers, runtime);
        }

        /**
         * @summary Deletes a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDashboardResponse
         */
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

        /**
         * @summary Deletes a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDashboardResponse
         */
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

        /**
         * @summary Deletes a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @return DeleteDashboardResponse
         */
        public DeleteDashboardResponse DeleteDashboard(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDashboardWithOptions(project, dashboardName, headers, runtime);
        }

        /**
         * @summary Deletes a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @return DeleteDashboardResponse
         */
        public async Task<DeleteDashboardResponse> DeleteDashboardAsync(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDashboardWithOptionsAsync(project, dashboardName, headers, runtime);
        }

        /**
         * @summary Deletes a custom domain name that is bound to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes a custom domain name that is bound to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes a custom domain name that is bound to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes a custom domain name that is bound to a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary 删除下载任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDownloadJobResponse
         */
        public DeleteDownloadJobResponse DeleteDownloadJobWithOptions(string project, string downloadJobName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteDownloadJob",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs/" + downloadJobName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteDownloadJobResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除下载任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDownloadJobResponse
         */
        public async Task<DeleteDownloadJobResponse> DeleteDownloadJobWithOptionsAsync(string project, string downloadJobName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteDownloadJob",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs/" + downloadJobName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteDownloadJobResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除下载任务
         *
         * @return DeleteDownloadJobResponse
         */
        public DeleteDownloadJobResponse DeleteDownloadJob(string project, string downloadJobName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDownloadJobWithOptions(project, downloadJobName, headers, runtime);
        }

        /**
         * @summary 删除下载任务
         *
         * @return DeleteDownloadJobResponse
         */
        public async Task<DeleteDownloadJobResponse> DeleteDownloadJobAsync(string project, string downloadJobName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDownloadJobWithOptionsAsync(project, downloadJobName, headers, runtime);
        }

        /**
         * @summary 删除数据加工任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteETLResponse
         */
        public DeleteETLResponse DeleteETLWithOptions(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteETLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除数据加工任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteETLResponse
         */
        public async Task<DeleteETLResponse> DeleteETLWithOptionsAsync(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteETLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除数据加工任务
         *
         * @return DeleteETLResponse
         */
        public DeleteETLResponse DeleteETL(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteETLWithOptions(project, etlName, headers, runtime);
        }

        /**
         * @summary 删除数据加工任务
         *
         * @return DeleteETLResponse
         */
        public async Task<DeleteETLResponse> DeleteETLAsync(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteETLWithOptionsAsync(project, etlName, headers, runtime);
        }

        /**
         * @summary Deletes an external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes an external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes an external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes an external store.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Deletes an index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes an index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes an index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes an index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes a Logstore, including all shards and indexes in the Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes a Logstore, including all shards and indexes in the Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes a Logstore, including all shards and indexes in the Logstore.
         *
         * @description ### Usage notes
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
         * @summary Deletes a Logstore, including all shards and indexes in the Logstore.
         *
         * @description ### Usage notes
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

        /**
         * @summary 关闭项目的服务日志记录。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoggingResponse
         */
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

        /**
         * @summary 关闭项目的服务日志记录。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLoggingResponse
         */
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

        /**
         * @summary 关闭项目的服务日志记录。
         *
         * @return DeleteLoggingResponse
         */
        public DeleteLoggingResponse DeleteLogging(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLoggingWithOptions(project, headers, runtime);
        }

        /**
         * @summary 关闭项目的服务日志记录。
         *
         * @return DeleteLoggingResponse
         */
        public async Task<DeleteLoggingResponse> DeleteLoggingAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLoggingWithOptionsAsync(project, headers, runtime);
        }

        /**
         * @summary Deletes a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Deletes a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Deletes a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @return DeleteLogtailPipelineConfigResponse
         */
        public DeleteLogtailPipelineConfigResponse DeleteLogtailPipelineConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLogtailPipelineConfigWithOptions(project, configName, headers, runtime);
        }

        /**
         * @summary Deletes a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @return DeleteLogtailPipelineConfigResponse
         */
        public async Task<DeleteLogtailPipelineConfigResponse> DeleteLogtailPipelineConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteLogtailPipelineConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
         * @summary Deletes a machine group. If the Logtail configurations for log collection are applied to a machine group, the configurations are disassociated from the machine group after the machine group is deleted.
         *
         * @description ### Usage notes
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
         * @summary Deletes a machine group. If the Logtail configurations for log collection are applied to a machine group, the configurations are disassociated from the machine group after the machine group is deleted.
         *
         * @description ### Usage notes
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
         * @summary Deletes a machine group. If the Logtail configurations for log collection are applied to a machine group, the configurations are disassociated from the machine group after the machine group is deleted.
         *
         * @description ### Usage notes
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
         * @summary Deletes a machine group. If the Logtail configurations for log collection are applied to a machine group, the configurations are disassociated from the machine group after the machine group is deleted.
         *
         * @description ### Usage notes
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

        /**
         * @summary Deletes an Object Storage Service (OSS) data shipping job.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOSSExportResponse
         */
        public DeleteOSSExportResponse DeleteOSSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOSSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Deletes an Object Storage Service (OSS) data shipping job.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOSSExportResponse
         */
        public async Task<DeleteOSSExportResponse> DeleteOSSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOSSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an Object Storage Service (OSS) data shipping job.
         *
         * @return DeleteOSSExportResponse
         */
        public DeleteOSSExportResponse DeleteOSSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteOSSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary Deletes an Object Storage Service (OSS) data shipping job.
         *
         * @return DeleteOSSExportResponse
         */
        public async Task<DeleteOSSExportResponse> DeleteOSSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteOSSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 删除OSSHDFS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOSSHDFSExportResponse
         */
        public DeleteOSSHDFSExportResponse DeleteOSSHDFSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOSSHDFSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除OSSHDFS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOSSHDFSExportResponse
         */
        public async Task<DeleteOSSHDFSExportResponse> DeleteOSSHDFSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOSSHDFSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除OSSHDFS投递任务
         *
         * @return DeleteOSSHDFSExportResponse
         */
        public DeleteOSSHDFSExportResponse DeleteOSSHDFSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteOSSHDFSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 删除OSSHDFS投递任务
         *
         * @return DeleteOSSHDFSExportResponse
         */
        public async Task<DeleteOSSHDFSExportResponse> DeleteOSSHDFSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteOSSHDFSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 删除OSS导入任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOSSIngestionResponse
         */
        public DeleteOSSIngestionResponse DeleteOSSIngestionWithOptions(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOSSIngestionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除OSS导入任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteOSSIngestionResponse
         */
        public async Task<DeleteOSSIngestionResponse> DeleteOSSIngestionWithOptionsAsync(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteOSSIngestionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除OSS导入任务
         *
         * @return DeleteOSSIngestionResponse
         */
        public DeleteOSSIngestionResponse DeleteOSSIngestion(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteOSSIngestionWithOptions(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary 删除OSS导入任务
         *
         * @return DeleteOSSIngestionResponse
         */
        public async Task<DeleteOSSIngestionResponse> DeleteOSSIngestionAsync(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteOSSIngestionWithOptionsAsync(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary 删除project
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
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

        /**
         * @summary 删除project
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteProjectResponse
         */
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

        /**
         * @summary 删除project
         *
         * @return DeleteProjectResponse
         */
        public DeleteProjectResponse DeleteProject(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(project, headers, runtime);
        }

        /**
         * @summary 删除project
         *
         * @return DeleteProjectResponse
         */
        public async Task<DeleteProjectResponse> DeleteProjectAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(project, headers, runtime);
        }

        /**
         * @summary Deletes a project policy.
         *
         * @description ### Usage notes
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
         * @summary Deletes a project policy.
         *
         * @description ### Usage notes
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
         * @summary Deletes a project policy.
         *
         * @description ### Usage notes
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
         * @summary Deletes a project policy.
         *
         * @description ### Usage notes
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
         * @summary Deletes a saved search.
         *
         * @description ### Usage notes
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
         * @summary Deletes a saved search.
         *
         * @description ### Usage notes
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
         * @summary Deletes a saved search.
         *
         * @description ### Usage notes
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
         * @summary Deletes a saved search.
         *
         * @description ### Usage notes
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
         * @summary 删除定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledSQLResponse
         */
        public DeleteScheduledSQLResponse DeleteScheduledSQLWithOptions(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteScheduledSQLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledSQLResponse
         */
        public async Task<DeleteScheduledSQLResponse> DeleteScheduledSQLWithOptionsAsync(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteScheduledSQLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除定时SQL任务
         *
         * @return DeleteScheduledSQLResponse
         */
        public DeleteScheduledSQLResponse DeleteScheduledSQL(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteScheduledSQLWithOptions(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary 删除定时SQL任务
         *
         * @return DeleteScheduledSQLResponse
         */
        public async Task<DeleteScheduledSQLResponse> DeleteScheduledSQLAsync(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteScheduledSQLWithOptionsAsync(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary 删除StoreView
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoreViewResponse
         */
        public DeleteStoreViewResponse DeleteStoreViewWithOptions(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteStoreViewResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 删除StoreView
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteStoreViewResponse
         */
        public async Task<DeleteStoreViewResponse> DeleteStoreViewWithOptionsAsync(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DeleteStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteStoreViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 删除StoreView
         *
         * @return DeleteStoreViewResponse
         */
        public DeleteStoreViewResponse DeleteStoreView(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteStoreViewWithOptions(project, name, headers, runtime);
        }

        /**
         * @summary 删除StoreView
         *
         * @return DeleteStoreViewResponse
         */
        public async Task<DeleteStoreViewResponse> DeleteStoreViewAsync(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteStoreViewWithOptionsAsync(project, name, headers, runtime);
        }

        /**
         * @summary 禁用告警
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAlertResponse
         */
        public DisableAlertResponse DisableAlertWithOptions(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName + "?action=disable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DisableAlertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 禁用告警
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableAlertResponse
         */
        public async Task<DisableAlertResponse> DisableAlertWithOptionsAsync(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName + "?action=disable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DisableAlertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用告警
         *
         * @return DisableAlertResponse
         */
        public DisableAlertResponse DisableAlert(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableAlertWithOptions(project, alertName, headers, runtime);
        }

        /**
         * @summary 禁用告警
         *
         * @return DisableAlertResponse
         */
        public async Task<DisableAlertResponse> DisableAlertAsync(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableAlertWithOptionsAsync(project, alertName, headers, runtime);
        }

        /**
         * @summary 禁用定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableScheduledSQLResponse
         */
        public DisableScheduledSQLResponse DisableScheduledSQLWithOptions(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName + "?action=disable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DisableScheduledSQLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 禁用定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DisableScheduledSQLResponse
         */
        public async Task<DisableScheduledSQLResponse> DisableScheduledSQLWithOptionsAsync(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "DisableScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName + "?action=disable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DisableScheduledSQLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 禁用定时SQL任务
         *
         * @return DisableScheduledSQLResponse
         */
        public DisableScheduledSQLResponse DisableScheduledSQL(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DisableScheduledSQLWithOptions(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary 禁用定时SQL任务
         *
         * @return DisableScheduledSQLResponse
         */
        public async Task<DisableScheduledSQLResponse> DisableScheduledSQLAsync(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DisableScheduledSQLWithOptionsAsync(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary 启用告警
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAlertResponse
         */
        public EnableAlertResponse EnableAlertWithOptions(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName + "?action=enable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<EnableAlertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 启用告警
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAlertResponse
         */
        public async Task<EnableAlertResponse> EnableAlertWithOptionsAsync(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName + "?action=enable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<EnableAlertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 启用告警
         *
         * @return EnableAlertResponse
         */
        public EnableAlertResponse EnableAlert(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableAlertWithOptions(project, alertName, headers, runtime);
        }

        /**
         * @summary 启用告警
         *
         * @return EnableAlertResponse
         */
        public async Task<EnableAlertResponse> EnableAlertAsync(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableAlertWithOptionsAsync(project, alertName, headers, runtime);
        }

        /**
         * @summary 启用定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableScheduledSQLResponse
         */
        public EnableScheduledSQLResponse EnableScheduledSQLWithOptions(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName + "?action=enable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<EnableScheduledSQLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 启用定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableScheduledSQLResponse
         */
        public async Task<EnableScheduledSQLResponse> EnableScheduledSQLWithOptionsAsync(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "EnableScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName + "?action=enable",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<EnableScheduledSQLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 启用定时SQL任务
         *
         * @return EnableScheduledSQLResponse
         */
        public EnableScheduledSQLResponse EnableScheduledSQL(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EnableScheduledSQLWithOptions(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary 启用定时SQL任务
         *
         * @return EnableScheduledSQLResponse
         */
        public async Task<EnableScheduledSQLResponse> EnableScheduledSQLAsync(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EnableScheduledSQLWithOptionsAsync(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary GetAlert
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAlertResponse
         */
        public GetAlertResponse GetAlertWithOptions(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary GetAlert
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAlertResponse
         */
        public async Task<GetAlertResponse> GetAlertWithOptionsAsync(string project, string alertName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAlertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary GetAlert
         *
         * @return GetAlertResponse
         */
        public GetAlertResponse GetAlert(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAlertWithOptions(project, alertName, headers, runtime);
        }

        /**
         * @summary GetAlert
         *
         * @return GetAlertResponse
         */
        public async Task<GetAlertResponse> GetAlertAsync(string project, string alertName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAlertWithOptionsAsync(project, alertName, headers, runtime);
        }

        /**
         * @summary Queries data in a dataset based on the unique identifier of the data.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnnotationDataResponse
         */
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

        /**
         * @summary Queries data in a dataset based on the unique identifier of the data.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnnotationDataResponse
         */
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

        /**
         * @summary Queries data in a dataset based on the unique identifier of the data.
         *
         * @return GetAnnotationDataResponse
         */
        public GetAnnotationDataResponse GetAnnotationData(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAnnotationDataWithOptions(datasetId, annotationdataId, headers, runtime);
        }

        /**
         * @summary Queries data in a dataset based on the unique identifier of the data.
         *
         * @return GetAnnotationDataResponse
         */
        public async Task<GetAnnotationDataResponse> GetAnnotationDataAsync(string datasetId, string annotationdataId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAnnotationDataWithOptionsAsync(datasetId, annotationdataId, headers, runtime);
        }

        /**
         * @summary Queries a dataset.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnnotationDataSetResponse
         */
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

        /**
         * @summary Queries a dataset.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnnotationDataSetResponse
         */
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

        /**
         * @summary Queries a dataset.
         *
         * @return GetAnnotationDataSetResponse
         */
        public GetAnnotationDataSetResponse GetAnnotationDataSet(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAnnotationDataSetWithOptions(datasetId, headers, runtime);
        }

        /**
         * @summary Queries a dataset.
         *
         * @return GetAnnotationDataSetResponse
         */
        public async Task<GetAnnotationDataSetResponse> GetAnnotationDataSetAsync(string datasetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAnnotationDataSetWithOptionsAsync(datasetId, headers, runtime);
        }

        /**
         * @summary Queries a tag table by using a label ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnnotationLabelResponse
         */
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

        /**
         * @summary Queries a tag table by using a label ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAnnotationLabelResponse
         */
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

        /**
         * @summary Queries a tag table by using a label ID.
         *
         * @return GetAnnotationLabelResponse
         */
        public GetAnnotationLabelResponse GetAnnotationLabel(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAnnotationLabelWithOptions(labelId, headers, runtime);
        }

        /**
         * @summary Queries a tag table by using a label ID.
         *
         * @return GetAnnotationLabelResponse
         */
        public async Task<GetAnnotationLabelResponse> GetAnnotationLabelAsync(string labelId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAnnotationLabelWithOptionsAsync(labelId, headers, runtime);
        }

        /**
         * @summary Queries the Logtail configurations that are applied to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the Logtail configurations that are applied to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the Logtail configurations that are applied to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the Logtail configurations that are applied to a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups to which a Logtail configuration is bound.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups to which a Logtail configuration is bound.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups to which a Logtail configuration is bound.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups to which a Logtail configuration is bound.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the checkpoints of a shard from which data is consumed by a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the checkpoints of a shard from which data is consumed by a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the checkpoints of a shard from which data is consumed by a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the checkpoints of a shard from which data is consumed by a consumer group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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

        /**
         * @summary 调用GetCollectionPolicy获取对应的规则
         *
         * @param request GetCollectionPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCollectionPolicyResponse
         */
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

        /**
         * @summary 调用GetCollectionPolicy获取对应的规则
         *
         * @param request GetCollectionPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCollectionPolicyResponse
         */
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

        /**
         * @summary 调用GetCollectionPolicy获取对应的规则
         *
         * @param request GetCollectionPolicyRequest
         * @return GetCollectionPolicyResponse
         */
        public GetCollectionPolicyResponse GetCollectionPolicy(string policyName, GetCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCollectionPolicyWithOptions(policyName, request, headers, runtime);
        }

        /**
         * @summary 调用GetCollectionPolicy获取对应的规则
         *
         * @param request GetCollectionPolicyRequest
         * @return GetCollectionPolicyResponse
         */
        public async Task<GetCollectionPolicyResponse> GetCollectionPolicyAsync(string policyName, GetCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCollectionPolicyWithOptionsAsync(policyName, request, headers, runtime);
        }

        /**
         * @summary Queries the details of a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfigResponse
         */
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

        /**
         * @summary Queries the details of a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConfigResponse
         */
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

        /**
         * @summary Queries the details of a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @return GetConfigResponse
         */
        public GetConfigResponse GetConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConfigWithOptions(project, configName, headers, runtime);
        }

        /**
         * @summary Queries the details of a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The name of the required Logtail configuration is obtained. For more information, see [ListConfig](https://help.aliyun.com/document_detail/29043.html).
         *
         * @return GetConfigResponse
         */
        public async Task<GetConfigResponse> GetConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
         * @summary Queries the contextual logs of a specified log.
         *
         * @description *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
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
         * @summary Queries the contextual logs of a specified log.
         *
         * @description *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
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
         * @summary Queries the contextual logs of a specified log.
         *
         * @description *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
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
         * @summary Queries the contextual logs of a specified log.
         *
         * @description *   You can specify a log as the start log. The time range of a contextual query is one day before and one day after the generation time of the start log.
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
         * @summary Queries a cursor based on a point in time.
         *
         * @description ### Usage notes
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
         * @summary Queries a cursor based on a point in time.
         *
         * @description ### Usage notes
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
         * @summary Queries a cursor based on a point in time.
         *
         * @description ### Usage notes
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
         * @summary Queries a cursor based on a point in time.
         *
         * @description ### Usage notes
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

        /**
         * @summary Queries the server time of a cursor.
         *
         * @param request GetCursorTimeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCursorTimeResponse
         */
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

        /**
         * @summary Queries the server time of a cursor.
         *
         * @param request GetCursorTimeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCursorTimeResponse
         */
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

        /**
         * @summary Queries the server time of a cursor.
         *
         * @param request GetCursorTimeRequest
         * @return GetCursorTimeResponse
         */
        public GetCursorTimeResponse GetCursorTime(string project, string logstore, string shardId, GetCursorTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCursorTimeWithOptions(project, logstore, shardId, request, headers, runtime);
        }

        /**
         * @summary Queries the server time of a cursor.
         *
         * @param request GetCursorTimeRequest
         * @return GetCursorTimeResponse
         */
        public async Task<GetCursorTimeResponse> GetCursorTimeAsync(string project, string logstore, string shardId, GetCursorTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCursorTimeWithOptionsAsync(project, logstore, shardId, request, headers, runtime);
        }

        /**
         * @summary Queries a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDashboardResponse
         */
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

        /**
         * @summary Queries a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDashboardResponse
         */
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

        /**
         * @summary Queries a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @return GetDashboardResponse
         */
        public GetDashboardResponse GetDashboard(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDashboardWithOptions(project, dashboardName, headers, runtime);
        }

        /**
         * @summary Queries a dashboard.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @return GetDashboardResponse
         */
        public async Task<GetDashboardResponse> GetDashboardAsync(string project, string dashboardName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDashboardWithOptionsAsync(project, dashboardName, headers, runtime);
        }

        /**
         * @summary 获取下载任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDownloadJobResponse
         */
        public GetDownloadJobResponse GetDownloadJobWithOptions(string project, string downloadJobName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDownloadJob",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs/" + downloadJobName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadJobResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取下载任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDownloadJobResponse
         */
        public async Task<GetDownloadJobResponse> GetDownloadJobWithOptionsAsync(string project, string downloadJobName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetDownloadJob",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs/" + downloadJobName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDownloadJobResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取下载任务信息
         *
         * @return GetDownloadJobResponse
         */
        public GetDownloadJobResponse GetDownloadJob(string project, string downloadJobName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetDownloadJobWithOptions(project, downloadJobName, headers, runtime);
        }

        /**
         * @summary 获取下载任务信息
         *
         * @return GetDownloadJobResponse
         */
        public async Task<GetDownloadJobResponse> GetDownloadJobAsync(string project, string downloadJobName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetDownloadJobWithOptionsAsync(project, downloadJobName, headers, runtime);
        }

        /**
         * @summary 获取数据加工任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetETLResponse
         */
        public GetETLResponse GetETLWithOptions(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetETLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取数据加工任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetETLResponse
         */
        public async Task<GetETLResponse> GetETLWithOptionsAsync(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetETLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取数据加工任务信息
         *
         * @return GetETLResponse
         */
        public GetETLResponse GetETL(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetETLWithOptions(project, etlName, headers, runtime);
        }

        /**
         * @summary 获取数据加工任务信息
         *
         * @return GetETLResponse
         */
        public async Task<GetETLResponse> GetETLAsync(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetETLWithOptionsAsync(project, etlName, headers, runtime);
        }

        /**
         * @summary Queries the details of an external store.
         *
         * @description *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
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
         * @summary Queries the details of an external store.
         *
         * @description *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
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
         * @summary Queries the details of an external store.
         *
         * @description *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
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
         * @summary Queries the details of an external store.
         *
         * @description *   The supported data sources of external stores include Object Storage Service (OSS) buckets and ApsaraDB RDS for MySQL databases in a virtual private cloud (VPC).
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
         * @summary Queries the distribution of logs that meet the specified search conditions in a Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:__receive_time__ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](https://help.aliyun.com/document_detail/462234.html).
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
         * @summary Queries the distribution of logs that meet the specified search conditions in a Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:__receive_time__ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](https://help.aliyun.com/document_detail/462234.html).
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
         * @summary Queries the distribution of logs that meet the specified search conditions in a Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:__receive_time__ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](https://help.aliyun.com/document_detail/462234.html).
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
         * @summary Queries the distribution of logs that meet the specified search conditions in a Logstore.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   The time range is evenly divided into subintervals in the responses. If the time range that is specified in the request remains unchanged, the subintervals in the responses also remain unchanged.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *     *   Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds.
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:__receive_time__ field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetHistograms operation by using Simple Log Service SDK for Java. For more information, see [Use GetHistograms to query the distribution of logs](https://help.aliyun.com/document_detail/462234.html).
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
         * @summary Queries the index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the index of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a Logstore.
         *
         * @description ### Usage notes
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

        /**
         * @summary 获取LogStore计量模式
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogStoreMeteringModeResponse
         */
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

        /**
         * @summary 获取LogStore计量模式
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogStoreMeteringModeResponse
         */
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

        /**
         * @summary 获取LogStore计量模式
         *
         * @return GetLogStoreMeteringModeResponse
         */
        public GetLogStoreMeteringModeResponse GetLogStoreMeteringMode(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogStoreMeteringModeWithOptions(project, logstore, headers, runtime);
        }

        /**
         * @summary 获取LogStore计量模式
         *
         * @return GetLogStoreMeteringModeResponse
         */
        public async Task<GetLogStoreMeteringModeResponse> GetLogStoreMeteringModeAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogStoreMeteringModeWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
         * @summary Queries the service log configuration of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the service log configuration of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the service log configuration of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the service log configuration of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the logs of a Logstore in a project.
         *
         * @description ### Usage notes
         * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](https://help.aliyun.com/document_detail/286457.html).
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](https://help.aliyun.com/document_detail/407683.html) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](https://help.aliyun.com/document_detail/407684.html).
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
         * @summary Queries the logs of a Logstore in a project.
         *
         * @description ### Usage notes
         * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](https://help.aliyun.com/document_detail/286457.html).
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](https://help.aliyun.com/document_detail/407683.html) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](https://help.aliyun.com/document_detail/407684.html).
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
         * @summary Queries the logs of a Logstore in a project.
         *
         * @description ### Usage notes
         * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](https://help.aliyun.com/document_detail/286457.html).
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](https://help.aliyun.com/document_detail/407683.html) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](https://help.aliyun.com/document_detail/407684.html).
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
         * @summary Queries the logs of a Logstore in a project.
         *
         * @description ### Usage notes
         * > Simple Log Service allows you to create a Scheduled SQL job. For more information, see [Create a Scheduled SQL job](https://help.aliyun.com/document_detail/286457.html).
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot forecast the number of times that you must call this operation to obtain the complete result. In this case, you must check the value of the x-log-progress parameter in the response of each request and determine whether to call this operation one more time to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log after a short latency. The latency of a query varies based on the type of the log. Simple Log Service classifies logs into the following types based on the log time:
         *         Real-time data: The difference between the time record in a log and the current time on Simple Log Service is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as real-time data. This type of log is usually generated in common scenarios. 
         *     *   Historical data: The difference between the time record in a log and the current time on Simple Log Service is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and Simple Log Service received the log at 12:05:00, September 25, 2014 (UTC), Simple Log Service processes the log as historical data. This type of log is usually generated in data backfill scenarios.
         *     After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
         * > Simple Log Service calculates the difference between the log time that is specified by the __time__ field and the receiving time that is specified by the __tag__:**receive_time** field for each log. The receiving time indicates the time at which Simple Log Service receives the log. If the difference is within the interval (-180 seconds,900 seconds], Simple Log Service processes the log as real-time data. If the difference is within the interval [-604,800 seconds,-180 seconds), Simple Log Service processes the log as historical data.
         * *   Simple Log Service provides examples on how to call the GetLogs operation by using Simple Log Service SDK for Java and Simple Log Service SDK for Python. For more information, see [Examples of calling the GetLogs operation by using Simple Log Service SDK for Java](https://help.aliyun.com/document_detail/407683.html) and [Examples of calling the GetLogs operation by using Simple Log Service SDK for Python](https://help.aliyun.com/document_detail/407684.html).
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
         * @summary Queries the raw log data in a Logstore of a project. The returned result shows the raw log data in a specific time range. The returned results are compressed and transmitted.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
         * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
         * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Highlight))
            {
                body["highlight"] = request.Highlight;
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
         * @summary Queries the raw log data in a Logstore of a project. The returned result shows the raw log data in a specific time range. The returned results are compressed and transmitted.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
         * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
         * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Highlight))
            {
                body["highlight"] = request.Highlight;
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
         * @summary Queries the raw log data in a Logstore of a project. The returned result shows the raw log data in a specific time range. The returned results are compressed and transmitted.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
         * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
         * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
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
         * @summary Queries the raw log data in a Logstore of a project. The returned result shows the raw log data in a specific time range. The returned results are compressed and transmitted.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   If the number of logs in a Logstore significantly changes, Simple Log Service cannot predict the number of times you must call this API operation to obtain a complete result. In this case, you must check the value of the progress parameter in the response of each request and determine whether to call this operation again to obtain the complete result. Each time you call this operation, the same number of charge units (CUs) are consumed.
         * *   After a log is written to a Logstore, you can call the GetHistograms or GetLogs operation to query the log. The latency of the query varies based on the type of the log. Simple Log Service classifies logs into the following types based on log timestamps:
         * 1.  1.  Real-time data: The difference between the time record in the log and the current server time is within the interval (-180 seconds,900 seconds]. For example, if a log was generated at 12:03:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as real-time data. This type of log is usually generated in common scenarios.
         * 2.  2.  Historical data: The difference between the time record in the log and the current server time is within the interval [-604,800 seconds,-180 seconds). For example, if a log was generated at 12:00:00, September 25, 2014 (UTC) and the server received the log at 12:05:00, September 25, 2014 (UTC), the server processes the log as historical data. This type of log is usually generated in data backfill scenarios. After real-time data is written to a Logstore, the data can be queried with a maximum latency of 3 seconds. For 99.9% of queries, the latency is no more than 1 second.
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

        /**
         * @summary Queries the details of a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Queries the details of a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Queries the details of a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @return GetLogtailPipelineConfigResponse
         */
        public GetLogtailPipelineConfigResponse GetLogtailPipelineConfig(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogtailPipelineConfigWithOptions(project, configName, headers, runtime);
        }

        /**
         * @summary Queries the details of a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @return GetLogtailPipelineConfigResponse
         */
        public async Task<GetLogtailPipelineConfigResponse> GetLogtailPipelineConfigAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogtailPipelineConfigWithOptionsAsync(project, configName, headers, runtime);
        }

        /**
         * @summary GetMLServiceResults
         *
         * @param request GetMLServiceResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMLServiceResultsResponse
         */
        public GetMLServiceResultsResponse GetMLServiceResultsWithOptions(string serviceName, GetMLServiceResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowBuiltin))
            {
                query["allowBuiltin"] = request.AllowBuiltin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
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

        /**
         * @summary GetMLServiceResults
         *
         * @param request GetMLServiceResultsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMLServiceResultsResponse
         */
        public async Task<GetMLServiceResultsResponse> GetMLServiceResultsWithOptionsAsync(string serviceName, GetMLServiceResultsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowBuiltin))
            {
                query["allowBuiltin"] = request.AllowBuiltin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
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

        /**
         * @summary GetMLServiceResults
         *
         * @param request GetMLServiceResultsRequest
         * @return GetMLServiceResultsResponse
         */
        public GetMLServiceResultsResponse GetMLServiceResults(string serviceName, GetMLServiceResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMLServiceResultsWithOptions(serviceName, request, headers, runtime);
        }

        /**
         * @summary GetMLServiceResults
         *
         * @param request GetMLServiceResultsRequest
         * @return GetMLServiceResultsResponse
         */
        public async Task<GetMLServiceResultsResponse> GetMLServiceResultsAsync(string serviceName, GetMLServiceResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMLServiceResultsWithOptionsAsync(serviceName, request, headers, runtime);
        }

        /**
         * @summary Queries the details of a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the details of a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the details of a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the details of a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary 获取 MetricStore 计量模式
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricStoreMeteringModeResponse
         */
        public GetMetricStoreMeteringModeResponse GetMetricStoreMeteringModeWithOptions(string project, string metricStore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMetricStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/metricstores/" + metricStore + "/meteringmode",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricStoreMeteringModeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取 MetricStore 计量模式
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetricStoreMeteringModeResponse
         */
        public async Task<GetMetricStoreMeteringModeResponse> GetMetricStoreMeteringModeWithOptionsAsync(string project, string metricStore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetMetricStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/metricstores/" + metricStore + "/meteringmode",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetricStoreMeteringModeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取 MetricStore 计量模式
         *
         * @return GetMetricStoreMeteringModeResponse
         */
        public GetMetricStoreMeteringModeResponse GetMetricStoreMeteringMode(string project, string metricStore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMetricStoreMeteringModeWithOptions(project, metricStore, headers, runtime);
        }

        /**
         * @summary 获取 MetricStore 计量模式
         *
         * @return GetMetricStoreMeteringModeResponse
         */
        public async Task<GetMetricStoreMeteringModeResponse> GetMetricStoreMeteringModeAsync(string project, string metricStore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMetricStoreMeteringModeWithOptionsAsync(project, metricStore, headers, runtime);
        }

        /**
         * @summary 获取OSS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSExportResponse
         */
        public GetOSSExportResponse GetOSSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取OSS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSExportResponse
         */
        public async Task<GetOSSExportResponse> GetOSSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取OSS投递任务
         *
         * @return GetOSSExportResponse
         */
        public GetOSSExportResponse GetOSSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOSSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 获取OSS投递任务
         *
         * @return GetOSSExportResponse
         */
        public async Task<GetOSSExportResponse> GetOSSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOSSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary Get OSSHDFS Exports
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSHDFSExportResponse
         */
        public GetOSSHDFSExportResponse GetOSSHDFSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSHDFSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Get OSSHDFS Exports
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSHDFSExportResponse
         */
        public async Task<GetOSSHDFSExportResponse> GetOSSHDFSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSHDFSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Get OSSHDFS Exports
         *
         * @return GetOSSHDFSExportResponse
         */
        public GetOSSHDFSExportResponse GetOSSHDFSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOSSHDFSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary Get OSSHDFS Exports
         *
         * @return GetOSSHDFSExportResponse
         */
        public async Task<GetOSSHDFSExportResponse> GetOSSHDFSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOSSHDFSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 获取oss导入任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSIngestionResponse
         */
        public GetOSSIngestionResponse GetOSSIngestionWithOptions(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSIngestionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 获取oss导入任务信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOSSIngestionResponse
         */
        public async Task<GetOSSIngestionResponse> GetOSSIngestionWithOptionsAsync(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOSSIngestionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 获取oss导入任务信息
         *
         * @return GetOSSIngestionResponse
         */
        public GetOSSIngestionResponse GetOSSIngestion(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetOSSIngestionWithOptions(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary 获取oss导入任务信息
         *
         * @return GetOSSIngestionResponse
         */
        public async Task<GetOSSIngestionResponse> GetOSSIngestionAsync(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetOSSIngestionWithOptionsAsync(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary Queries the details of a project.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a project.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a project.
         *
         * @description ### Usage notes
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
         * @summary Queries the details of a project.
         *
         * @description ### Usage notes
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
         * @summary Queries logs in a project. You can use this operation to query logs at the project level.
         *
         * @description ### Usage notes
         * *   You can use the query parameter to specify a standard SQL statement.
         * *   You must specify a project in the domain name of the request.
         * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
         * *   You must specify a time range in the SQL statement by using the __date__ parameter or __time__ parameter. The value of the __date__ parameter is a timestamp, and the value of the __time__ parameter is an integer. The unit of the __time__ parameter is seconds.
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
         * @summary Queries logs in a project. You can use this operation to query logs at the project level.
         *
         * @description ### Usage notes
         * *   You can use the query parameter to specify a standard SQL statement.
         * *   You must specify a project in the domain name of the request.
         * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
         * *   You must specify a time range in the SQL statement by using the __date__ parameter or __time__ parameter. The value of the __date__ parameter is a timestamp, and the value of the __time__ parameter is an integer. The unit of the __time__ parameter is seconds.
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
         * @summary Queries logs in a project. You can use this operation to query logs at the project level.
         *
         * @description ### Usage notes
         * *   You can use the query parameter to specify a standard SQL statement.
         * *   You must specify a project in the domain name of the request.
         * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
         * *   You must specify a time range in the SQL statement by using the __date__ parameter or __time__ parameter. The value of the __date__ parameter is a timestamp, and the value of the __time__ parameter is an integer. The unit of the __time__ parameter is seconds.
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
         * @summary Queries logs in a project. You can use this operation to query logs at the project level.
         *
         * @description ### Usage notes
         * *   You can use the query parameter to specify a standard SQL statement.
         * *   You must specify a project in the domain name of the request.
         * *   You must specify a Logstore in the FROM clause of the SQL statement. A Logstore can be used as an SQL table.
         * *   You must specify a time range in the SQL statement by using the __date__ parameter or __time__ parameter. The value of the __date__ parameter is a timestamp, and the value of the __time__ parameter is an integer. The unit of the __time__ parameter is seconds.
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
         * @summary Queries a project policy.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
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
         * @summary Queries a project policy.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
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
         * @summary Queries a project policy.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
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
         * @summary Queries a project policy.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
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
         * @summary Queries a saved search.
         *
         * @description ### Usage notes
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
         * @summary Queries a saved search.
         *
         * @description ### Usage notes
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
         * @summary Queries a saved search.
         *
         * @description ### Usage notes
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
         * @summary Queries a saved search.
         *
         * @description ### Usage notes
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
         * @summary 查看定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScheduledSQLResponse
         */
        public GetScheduledSQLResponse GetScheduledSQLWithOptions(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledSQLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查看定时SQL任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetScheduledSQLResponse
         */
        public async Task<GetScheduledSQLResponse> GetScheduledSQLWithOptionsAsync(string project, string scheduledSQLName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledSQLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查看定时SQL任务
         *
         * @return GetScheduledSQLResponse
         */
        public GetScheduledSQLResponse GetScheduledSQL(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetScheduledSQLWithOptions(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary 查看定时SQL任务
         *
         * @return GetScheduledSQLResponse
         */
        public async Task<GetScheduledSQLResponse> GetScheduledSQLAsync(string project, string scheduledSQLName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetScheduledSQLWithOptionsAsync(project, scheduledSQLName, headers, runtime);
        }

        /**
         * @summary getSlsService
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSlsServiceResponse
         */
        public GetSlsServiceResponse GetSlsServiceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSlsService",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/slsservice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSlsServiceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary getSlsService
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSlsServiceResponse
         */
        public async Task<GetSlsServiceResponse> GetSlsServiceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSlsService",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/slsservice",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSlsServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary getSlsService
         *
         * @return GetSlsServiceResponse
         */
        public GetSlsServiceResponse GetSlsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSlsServiceWithOptions(headers, runtime);
        }

        /**
         * @summary getSlsService
         *
         * @return GetSlsServiceResponse
         */
        public async Task<GetSlsServiceResponse> GetSlsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSlsServiceWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询独享sql实例
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSqlInstanceResponse
         */
        public GetSqlInstanceResponse GetSqlInstanceWithOptions(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSqlInstance",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/sqlinstance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetSqlInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询独享sql实例
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSqlInstanceResponse
         */
        public async Task<GetSqlInstanceResponse> GetSqlInstanceWithOptionsAsync(string project, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetSqlInstance",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/sqlinstance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetSqlInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询独享sql实例
         *
         * @return GetSqlInstanceResponse
         */
        public GetSqlInstanceResponse GetSqlInstance(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSqlInstanceWithOptions(project, headers, runtime);
        }

        /**
         * @summary 查询独享sql实例
         *
         * @return GetSqlInstanceResponse
         */
        public async Task<GetSqlInstanceResponse> GetSqlInstanceAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSqlInstanceWithOptionsAsync(project, headers, runtime);
        }

        /**
         * @summary 查询StoreView
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoreViewResponse
         */
        public GetStoreViewResponse GetStoreViewWithOptions(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoreViewResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询StoreView
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoreViewResponse
         */
        public async Task<GetStoreViewResponse> GetStoreViewWithOptionsAsync(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoreViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询StoreView
         *
         * @return GetStoreViewResponse
         */
        public GetStoreViewResponse GetStoreView(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetStoreViewWithOptions(project, name, headers, runtime);
        }

        /**
         * @summary 查询StoreView
         *
         * @return GetStoreViewResponse
         */
        public async Task<GetStoreViewResponse> GetStoreViewAsync(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetStoreViewWithOptionsAsync(project, name, headers, runtime);
        }

        /**
         * @summary 查询StoreView索引
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoreViewIndexResponse
         */
        public GetStoreViewIndexResponse GetStoreViewIndexWithOptions(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetStoreViewIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name + "/index",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoreViewIndexResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询StoreView索引
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetStoreViewIndexResponse
         */
        public async Task<GetStoreViewIndexResponse> GetStoreViewIndexWithOptionsAsync(string project, string name, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetStoreViewIndex",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name + "/index",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStoreViewIndexResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询StoreView索引
         *
         * @return GetStoreViewIndexResponse
         */
        public GetStoreViewIndexResponse GetStoreViewIndex(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetStoreViewIndexWithOptions(project, name, headers, runtime);
        }

        /**
         * @summary 查询StoreView索引
         *
         * @return GetStoreViewIndexResponse
         */
        public async Task<GetStoreViewIndexResponse> GetStoreViewIndexAsync(string project, string name)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetStoreViewIndexWithOptionsAsync(project, name, headers, runtime);
        }

        /**
         * @summary 查询告警列表
         *
         * @param request ListAlertsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlertsResponse
         */
        public ListAlertsResponse ListAlertsWithOptions(string project, ListAlertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListAlerts",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询告警列表
         *
         * @param request ListAlertsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAlertsResponse
         */
        public async Task<ListAlertsResponse> ListAlertsWithOptionsAsync(string project, ListAlertsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListAlerts",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAlertsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询告警列表
         *
         * @param request ListAlertsRequest
         * @return ListAlertsResponse
         */
        public ListAlertsResponse ListAlerts(string project, ListAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAlertsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 查询告警列表
         *
         * @param request ListAlertsRequest
         * @return ListAlertsResponse
         */
        public async Task<ListAlertsResponse> ListAlertsAsync(string project, ListAlertsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAlertsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries data in datasets.
         *
         * @param request ListAnnotationDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnnotationDataResponse
         */
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

        /**
         * @summary Queries data in datasets.
         *
         * @param request ListAnnotationDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnnotationDataResponse
         */
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

        /**
         * @summary Queries data in datasets.
         *
         * @param request ListAnnotationDataRequest
         * @return ListAnnotationDataResponse
         */
        public ListAnnotationDataResponse ListAnnotationData(string datasetId, ListAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnnotationDataWithOptions(datasetId, request, headers, runtime);
        }

        /**
         * @summary Queries data in datasets.
         *
         * @param request ListAnnotationDataRequest
         * @return ListAnnotationDataResponse
         */
        public async Task<ListAnnotationDataResponse> ListAnnotationDataAsync(string datasetId, ListAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnnotationDataWithOptionsAsync(datasetId, request, headers, runtime);
        }

        /**
         * @summary Queries a list of datasets.
         *
         * @param request ListAnnotationDataSetsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnnotationDataSetsResponse
         */
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

        /**
         * @summary Queries a list of datasets.
         *
         * @param request ListAnnotationDataSetsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnnotationDataSetsResponse
         */
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

        /**
         * @summary Queries a list of datasets.
         *
         * @param request ListAnnotationDataSetsRequest
         * @return ListAnnotationDataSetsResponse
         */
        public ListAnnotationDataSetsResponse ListAnnotationDataSets(ListAnnotationDataSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnnotationDataSetsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of datasets.
         *
         * @param request ListAnnotationDataSetsRequest
         * @return ListAnnotationDataSetsResponse
         */
        public async Task<ListAnnotationDataSetsResponse> ListAnnotationDataSetsAsync(ListAnnotationDataSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnnotationDataSetsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries a list of tag tables.
         *
         * @param request ListAnnotationLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnnotationLabelsResponse
         */
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

        /**
         * @summary Queries a list of tag tables.
         *
         * @param request ListAnnotationLabelsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAnnotationLabelsResponse
         */
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

        /**
         * @summary Queries a list of tag tables.
         *
         * @param request ListAnnotationLabelsRequest
         * @return ListAnnotationLabelsResponse
         */
        public ListAnnotationLabelsResponse ListAnnotationLabels(ListAnnotationLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAnnotationLabelsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries a list of tag tables.
         *
         * @param request ListAnnotationLabelsRequest
         * @return ListAnnotationLabelsResponse
         */
        public async Task<ListAnnotationLabelsResponse> ListAnnotationLabelsAsync(ListAnnotationLabelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAnnotationLabelsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 通过调用ListCollectionPolicies接口查看配置的日志采集规则
         *
         * @param request ListCollectionPoliciesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCollectionPoliciesResponse
         */
        public ListCollectionPoliciesResponse ListCollectionPoliciesWithOptions(ListCollectionPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CentralProject))
            {
                query["centralProject"] = request.CentralProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
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

        /**
         * @summary 通过调用ListCollectionPolicies接口查看配置的日志采集规则
         *
         * @param request ListCollectionPoliciesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCollectionPoliciesResponse
         */
        public async Task<ListCollectionPoliciesResponse> ListCollectionPoliciesWithOptionsAsync(ListCollectionPoliciesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CentralProject))
            {
                query["centralProject"] = request.CentralProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCode))
            {
                query["dataCode"] = request.DataCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductCode))
            {
                query["productCode"] = request.ProductCode;
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

        /**
         * @summary 通过调用ListCollectionPolicies接口查看配置的日志采集规则
         *
         * @param request ListCollectionPoliciesRequest
         * @return ListCollectionPoliciesResponse
         */
        public ListCollectionPoliciesResponse ListCollectionPolicies(ListCollectionPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListCollectionPoliciesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 通过调用ListCollectionPolicies接口查看配置的日志采集规则
         *
         * @param request ListCollectionPoliciesRequest
         * @return ListCollectionPoliciesResponse
         */
        public async Task<ListCollectionPoliciesResponse> ListCollectionPoliciesAsync(ListCollectionPoliciesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListCollectionPoliciesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries all Logtail configurations in a project.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConfigResponse
         */
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

        /**
         * @summary Queries all Logtail configurations in a project.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConfigResponse
         */
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

        /**
         * @summary Queries all Logtail configurations in a project.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListConfigRequest
         * @return ListConfigResponse
         */
        public ListConfigResponse ListConfig(string project, ListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConfigWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Queries all Logtail configurations in a project.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListConfigRequest
         * @return ListConfigResponse
         */
        public async Task<ListConfigResponse> ListConfigAsync(string project, ListConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries all consumer groups of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries all consumer groups of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries all consumer groups of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Queries all consumer groups of a Logstore.
         *
         * @description ### Usage notes
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

        /**
         * @summary Queries a list of dashboards.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListDashboardRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDashboardResponse
         */
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

        /**
         * @summary Queries a list of dashboards.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListDashboardRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDashboardResponse
         */
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

        /**
         * @summary Queries a list of dashboards.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListDashboardRequest
         * @return ListDashboardResponse
         */
        public ListDashboardResponse ListDashboard(string project, ListDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDashboardWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Queries a list of dashboards.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         *
         * @param request ListDashboardRequest
         * @return ListDashboardResponse
         */
        public async Task<ListDashboardResponse> ListDashboardAsync(string project, ListDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDashboardWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries the custom domain names that are bound to projects.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the custom domain names that are bound to projects.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the custom domain names that are bound to projects.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the custom domain names that are bound to projects.
         *
         * @description *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary 列举下载任务
         *
         * @param request ListDownloadJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDownloadJobsResponse
         */
        public ListDownloadJobsResponse ListDownloadJobsWithOptions(string project, ListDownloadJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListDownloadJobs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownloadJobsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列举下载任务
         *
         * @param request ListDownloadJobsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDownloadJobsResponse
         */
        public async Task<ListDownloadJobsResponse> ListDownloadJobsWithOptionsAsync(string project, ListDownloadJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListDownloadJobs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/downloadjobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownloadJobsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列举下载任务
         *
         * @param request ListDownloadJobsRequest
         * @return ListDownloadJobsResponse
         */
        public ListDownloadJobsResponse ListDownloadJobs(string project, ListDownloadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDownloadJobsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 列举下载任务
         *
         * @param request ListDownloadJobsRequest
         * @return ListDownloadJobsResponse
         */
        public async Task<ListDownloadJobsResponse> ListDownloadJobsAsync(string project, ListDownloadJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDownloadJobsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 列出数据加工任务
         *
         * @param request ListETLsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListETLsResponse
         */
        public ListETLsResponse ListETLsWithOptions(string project, ListETLsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListETLs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListETLsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列出数据加工任务
         *
         * @param request ListETLsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListETLsResponse
         */
        public async Task<ListETLsResponse> ListETLsWithOptionsAsync(string project, ListETLsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListETLs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListETLsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列出数据加工任务
         *
         * @param request ListETLsRequest
         * @return ListETLsResponse
         */
        public ListETLsResponse ListETLs(string project, ListETLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListETLsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 列出数据加工任务
         *
         * @param request ListETLsRequest
         * @return ListETLsResponse
         */
        public async Task<ListETLsResponse> ListETLsAsync(string project, ListETLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListETLsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries all Logstores or Logstores that match specific conditions in a project.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListLogStores`|`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}/logstore/*`|
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
         * @summary Queries all Logstores or Logstores that match specific conditions in a project.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListLogStores`|`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}/logstore/*`|
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
         * @summary Queries all Logstores or Logstores that match specific conditions in a project.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListLogStores`|`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}/logstore/*`|
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
         * @summary Queries all Logstores or Logstores that match specific conditions in a project.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListLogStores`|`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}/logstore/*`|
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

        /**
         * @summary Queries a list of Logtail pipeline configurations that meet the specified conditions.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request ListLogtailPipelineConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Queries a list of Logtail pipeline configurations that meet the specified conditions.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request ListLogtailPipelineConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Queries a list of Logtail pipeline configurations that meet the specified conditions.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request ListLogtailPipelineConfigRequest
         * @return ListLogtailPipelineConfigResponse
         */
        public ListLogtailPipelineConfigResponse ListLogtailPipelineConfig(string project, ListLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogtailPipelineConfigWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary Queries a list of Logtail pipeline configurations that meet the specified conditions.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request ListLogtailPipelineConfigRequest
         * @return ListLogtailPipelineConfigResponse
         */
        public async Task<ListLogtailPipelineConfigResponse> ListLogtailPipelineConfigAsync(string project, ListLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogtailPipelineConfigWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries the machine groups of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries the machine groups of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries a list of machines that are connected to Simple Log Service in a specified machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries a list of machines that are connected to Simple Log Service in a specified machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries a list of machines that are connected to Simple Log Service in a specified machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Queries a list of machines that are connected to Simple Log Service in a specified machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary 列出OSS投递任务
         *
         * @param request ListOSSExportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOSSExportsResponse
         */
        public ListOSSExportsResponse ListOSSExportsWithOptions(string project, ListOSSExportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListOSSExports",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOSSExportsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列出OSS投递任务
         *
         * @param request ListOSSExportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOSSExportsResponse
         */
        public async Task<ListOSSExportsResponse> ListOSSExportsWithOptionsAsync(string project, ListOSSExportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListOSSExports",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOSSExportsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列出OSS投递任务
         *
         * @param request ListOSSExportsRequest
         * @return ListOSSExportsResponse
         */
        public ListOSSExportsResponse ListOSSExports(string project, ListOSSExportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOSSExportsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 列出OSS投递任务
         *
         * @param request ListOSSExportsRequest
         * @return ListOSSExportsResponse
         */
        public async Task<ListOSSExportsResponse> ListOSSExportsAsync(string project, ListOSSExportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOSSExportsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 列举OSSHDFS投递任务
         *
         * @param request ListOSSHDFSExportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOSSHDFSExportsResponse
         */
        public ListOSSHDFSExportsResponse ListOSSHDFSExportsWithOptions(string project, ListOSSHDFSExportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListOSSHDFSExports",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOSSHDFSExportsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列举OSSHDFS投递任务
         *
         * @param request ListOSSHDFSExportsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOSSHDFSExportsResponse
         */
        public async Task<ListOSSHDFSExportsResponse> ListOSSHDFSExportsWithOptionsAsync(string project, ListOSSHDFSExportsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListOSSHDFSExports",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOSSHDFSExportsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列举OSSHDFS投递任务
         *
         * @param request ListOSSHDFSExportsRequest
         * @return ListOSSHDFSExportsResponse
         */
        public ListOSSHDFSExportsResponse ListOSSHDFSExports(string project, ListOSSHDFSExportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOSSHDFSExportsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 列举OSSHDFS投递任务
         *
         * @param request ListOSSHDFSExportsRequest
         * @return ListOSSHDFSExportsResponse
         */
        public async Task<ListOSSHDFSExportsResponse> ListOSSHDFSExportsAsync(string project, ListOSSHDFSExportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOSSHDFSExportsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 列出oss导入任务
         *
         * @param request ListOSSIngestionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOSSIngestionsResponse
         */
        public ListOSSIngestionsResponse ListOSSIngestionsWithOptions(string project, ListOSSIngestionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListOSSIngestions",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOSSIngestionsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列出oss导入任务
         *
         * @param request ListOSSIngestionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOSSIngestionsResponse
         */
        public async Task<ListOSSIngestionsResponse> ListOSSIngestionsWithOptionsAsync(string project, ListOSSIngestionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListOSSIngestions",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOSSIngestionsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列出oss导入任务
         *
         * @param request ListOSSIngestionsRequest
         * @return ListOSSIngestionsResponse
         */
        public ListOSSIngestionsResponse ListOSSIngestions(string project, ListOSSIngestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOSSIngestionsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 列出oss导入任务
         *
         * @param request ListOSSIngestionsRequest
         * @return ListOSSIngestionsResponse
         */
        public async Task<ListOSSIngestionsResponse> ListOSSIngestionsAsync(string project, ListOSSIngestionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOSSIngestionsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries the projects that meet specified conditions.
         *
         * @description ### [](#)Usage notes
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchQuota))
            {
                query["fetchQuota"] = request.FetchQuota;
            }
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
         * @summary Queries the projects that meet specified conditions.
         *
         * @description ### [](#)Usage notes
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FetchQuota))
            {
                query["fetchQuota"] = request.FetchQuota;
            }
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
         * @summary Queries the projects that meet specified conditions.
         *
         * @description ### [](#)Usage notes
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
         * @summary Queries the projects that meet specified conditions.
         *
         * @description ### [](#)Usage notes
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
         * @summary Queries a list of saved searches.
         *
         * @description ### Usage notes
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
         * @summary Queries a list of saved searches.
         *
         * @description ### Usage notes
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
         * @summary Queries a list of saved searches.
         *
         * @description ### Usage notes
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
         * @summary Queries a list of saved searches.
         *
         * @description ### Usage notes
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

        /**
         * @summary 列举定时SQL任务
         *
         * @param request ListScheduledSQLsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListScheduledSQLsResponse
         */
        public ListScheduledSQLsResponse ListScheduledSQLsWithOptions(string project, ListScheduledSQLsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListScheduledSQLs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledSQLsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 列举定时SQL任务
         *
         * @param request ListScheduledSQLsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListScheduledSQLsResponse
         */
        public async Task<ListScheduledSQLsResponse> ListScheduledSQLsWithOptionsAsync(string project, ListScheduledSQLsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Logstore))
            {
                query["logstore"] = request.Logstore;
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
                Action = "ListScheduledSQLs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledSQLsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 列举定时SQL任务
         *
         * @param request ListScheduledSQLsRequest
         * @return ListScheduledSQLsResponse
         */
        public ListScheduledSQLsResponse ListScheduledSQLs(string project, ListScheduledSQLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListScheduledSQLsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 列举定时SQL任务
         *
         * @param request ListScheduledSQLsRequest
         * @return ListScheduledSQLsResponse
         */
        public async Task<ListScheduledSQLsResponse> ListScheduledSQLsAsync(string project, ListScheduledSQLsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListScheduledSQLsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries a list of shards in a Logstore.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListShardsResponse
         */
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

        /**
         * @summary Queries a list of shards in a Logstore.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListShardsResponse
         */
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

        /**
         * @summary Queries a list of shards in a Logstore.
         *
         * @return ListShardsResponse
         */
        public ListShardsResponse ListShards(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShardsWithOptions(project, logstore, headers, runtime);
        }

        /**
         * @summary Queries a list of shards in a Logstore.
         *
         * @return ListShardsResponse
         */
        public async Task<ListShardsResponse> ListShardsAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShardsWithOptionsAsync(project, logstore, headers, runtime);
        }

        /**
         * @summary 查询StoreView列表
         *
         * @param request ListStoreViewsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListStoreViewsResponse
         */
        public ListStoreViewsResponse ListStoreViewsWithOptions(string project, ListStoreViewsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                query["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStoreViews",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStoreViewsResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 查询StoreView列表
         *
         * @param request ListStoreViewsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListStoreViewsResponse
         */
        public async Task<ListStoreViewsResponse> ListStoreViewsWithOptionsAsync(string project, ListStoreViewsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                query["storeType"] = request.StoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStoreViews",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStoreViewsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 查询StoreView列表
         *
         * @param request ListStoreViewsRequest
         * @return ListStoreViewsResponse
         */
        public ListStoreViewsResponse ListStoreViews(string project, ListStoreViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStoreViewsWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 查询StoreView列表
         *
         * @param request ListStoreViewsRequest
         * @return ListStoreViewsResponse
         */
        public async Task<ListStoreViewsResponse> ListStoreViewsAsync(string project, ListStoreViewsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStoreViewsWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Queries a list of tags for one or more resources. You can query tags for resources by resource type or filter resources by tag. Each tag is a key-value pair.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListTagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Queries a list of tags for one or more resources. You can query tags for resources by resource type or filter resources by tag. Each tag is a key-value pair.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListTagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Queries a list of tags for one or more resources. You can query tags for resources by resource type or filter resources by tag. Each tag is a key-value pair.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListTagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Queries a list of tags for one or more resources. You can query tags for resources by resource type or filter resources by tag. Each tag is a key-value pair.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:ListTagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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

        /**
         * @summary 合并两个相邻的readwrite状态的Shards。在参数中指定一个shardID，服务端自动找相邻的下一个Shard进行合并。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return MergeShardResponse
         */
        public MergeShardResponse MergeShardWithOptions(string project, string logstore, string shard, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "MergeShard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shard + "?action=merge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<MergeShardResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 合并两个相邻的readwrite状态的Shards。在参数中指定一个shardID，服务端自动找相邻的下一个Shard进行合并。
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return MergeShardResponse
         */
        public async Task<MergeShardResponse> MergeShardWithOptionsAsync(string project, string logstore, string shard, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "MergeShard",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shard + "?action=merge",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<MergeShardResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 合并两个相邻的readwrite状态的Shards。在参数中指定一个shardID，服务端自动找相邻的下一个Shard进行合并。
         *
         * @return MergeShardResponse
         */
        public MergeShardResponse MergeShard(string project, string logstore, string shard)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MergeShardWithOptions(project, logstore, shard, headers, runtime);
        }

        /**
         * @summary 合并两个相邻的readwrite状态的Shards。在参数中指定一个shardID，服务端自动找相邻的下一个Shard进行合并。
         *
         * @return MergeShardResponse
         */
        public async Task<MergeShardResponse> MergeShardAsync(string project, string logstore, string shard)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MergeShardWithOptionsAsync(project, logstore, shard, headers, runtime);
        }

        /**
         * @summary openSlsService
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenSlsServiceResponse
         */
        public OpenSlsServiceResponse OpenSlsServiceWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSlsService",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/slsservice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<OpenSlsServiceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary openSlsService
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenSlsServiceResponse
         */
        public async Task<OpenSlsServiceResponse> OpenSlsServiceWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenSlsService",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/slsservice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<OpenSlsServiceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary openSlsService
         *
         * @return OpenSlsServiceResponse
         */
        public OpenSlsServiceResponse OpenSlsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenSlsServiceWithOptions(headers, runtime);
        }

        /**
         * @summary openSlsService
         *
         * @return OpenSlsServiceResponse
         */
        public async Task<OpenSlsServiceResponse> OpenSlsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenSlsServiceWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Adds data to a dataset for storage.
         *
         * @param request PutAnnotationDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutAnnotationDataResponse
         */
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

        /**
         * @summary Adds data to a dataset for storage.
         *
         * @param request PutAnnotationDataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutAnnotationDataResponse
         */
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

        /**
         * @summary Adds data to a dataset for storage.
         *
         * @param request PutAnnotationDataRequest
         * @return PutAnnotationDataResponse
         */
        public PutAnnotationDataResponse PutAnnotationData(string datasetId, PutAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutAnnotationDataWithOptions(datasetId, request, headers, runtime);
        }

        /**
         * @summary Adds data to a dataset for storage.
         *
         * @param request PutAnnotationDataRequest
         * @return PutAnnotationDataResponse
         */
        public async Task<PutAnnotationDataResponse> PutAnnotationDataAsync(string datasetId, PutAnnotationDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutAnnotationDataWithOptionsAsync(datasetId, request, headers, runtime);
        }

        /**
         * @summary Creates a project policy.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
         *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](https://help.aliyun.com/document_detail/128139.html).
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
         * @summary Creates a project policy.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
         *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](https://help.aliyun.com/document_detail/128139.html).
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
         * @summary Creates a project policy.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
         *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](https://help.aliyun.com/document_detail/128139.html).
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
         * @summary Creates a project policy.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Alibaba Cloud Simple Log Service allows you to configure a project policy to authorize other users to access the specified Log Service resources.
         *     *   You must configure a project policy based on policy syntax. Before you configure a project policy, you must be familiar with the Action, Resource, and Condition parameters. For more information, see [RAM](https://help.aliyun.com/document_detail/128139.html).
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

        /**
         * @summary 设置project传输加速状态
         *
         * @param request PutProjectTransferAccelerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutProjectTransferAccelerationResponse
         */
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

        /**
         * @summary 设置project传输加速状态
         *
         * @param request PutProjectTransferAccelerationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutProjectTransferAccelerationResponse
         */
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

        /**
         * @summary 设置project传输加速状态
         *
         * @param request PutProjectTransferAccelerationRequest
         * @return PutProjectTransferAccelerationResponse
         */
        public PutProjectTransferAccelerationResponse PutProjectTransferAcceleration(string project, PutProjectTransferAccelerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProjectTransferAccelerationWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 设置project传输加速状态
         *
         * @param request PutProjectTransferAccelerationRequest
         * @return PutProjectTransferAccelerationResponse
         */
        public async Task<PutProjectTransferAccelerationResponse> PutProjectTransferAccelerationAsync(string project, PutProjectTransferAccelerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProjectTransferAccelerationWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary Sends multiple logs to Simple Log Service in one request.
         *
         * @description ### [](#)Usage notes
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         * *   You can call this operation to collect logs from web pages or clients.
         * *   If you use web tracking to collect logs and you do not call this operation, you can send only one log to Simple Log Service in a request. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   If you want to collect a large amount of log data, you can call this operation to send multiple logs to Simple Log Service in one request.
         * *   Before you can call this operation to send logs to a Logstore, you must enable web tracking for the Logstore. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   You cannot call this operation to send the logs of multiple topics to Simple Log Service at a time.
         * *   If you call this operation, anonymous users from the Internet are granted the write permissions on the Logstore. This may generate dirty data because AccessKey pair-based authentication is not performed.
         *
         * @param request PutWebtrackingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutWebtrackingResponse
         */
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
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutWebtrackingResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary Sends multiple logs to Simple Log Service in one request.
         *
         * @description ### [](#)Usage notes
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         * *   You can call this operation to collect logs from web pages or clients.
         * *   If you use web tracking to collect logs and you do not call this operation, you can send only one log to Simple Log Service in a request. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   If you want to collect a large amount of log data, you can call this operation to send multiple logs to Simple Log Service in one request.
         * *   Before you can call this operation to send logs to a Logstore, you must enable web tracking for the Logstore. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   You cannot call this operation to send the logs of multiple topics to Simple Log Service at a time.
         * *   If you call this operation, anonymous users from the Internet are granted the write permissions on the Logstore. This may generate dirty data because AccessKey pair-based authentication is not performed.
         *
         * @param request PutWebtrackingRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutWebtrackingResponse
         */
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
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PutWebtrackingResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary Sends multiple logs to Simple Log Service in one request.
         *
         * @description ### [](#)Usage notes
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         * *   You can call this operation to collect logs from web pages or clients.
         * *   If you use web tracking to collect logs and you do not call this operation, you can send only one log to Simple Log Service in a request. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   If you want to collect a large amount of log data, you can call this operation to send multiple logs to Simple Log Service in one request.
         * *   Before you can call this operation to send logs to a Logstore, you must enable web tracking for the Logstore. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   You cannot call this operation to send the logs of multiple topics to Simple Log Service at a time.
         * *   If you call this operation, anonymous users from the Internet are granted the write permissions on the Logstore. This may generate dirty data because AccessKey pair-based authentication is not performed.
         *
         * @param request PutWebtrackingRequest
         * @return PutWebtrackingResponse
         */
        public PutWebtrackingResponse PutWebtracking(string project, string logstoreName, PutWebtrackingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutWebtrackingWithOptions(project, logstoreName, request, headers, runtime);
        }

        /**
         * @summary Sends multiple logs to Simple Log Service in one request.
         *
         * @description ### [](#)Usage notes
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong, the region of the project, and the name of the Logstore to which the logs belong. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) and [Manage a Logstore](https://help.aliyun.com/document_detail/48990.html).
         * *   You can call this operation to collect logs from web pages or clients.
         * *   If you use web tracking to collect logs and you do not call this operation, you can send only one log to Simple Log Service in a request. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   If you want to collect a large amount of log data, you can call this operation to send multiple logs to Simple Log Service in one request.
         * *   Before you can call this operation to send logs to a Logstore, you must enable web tracking for the Logstore. For more information, see [Use web tracking to collect logs](https://help.aliyun.com/document_detail/31752.html).
         * *   You cannot call this operation to send the logs of multiple topics to Simple Log Service at a time.
         * *   If you call this operation, anonymous users from the Internet are granted the write permissions on the Logstore. This may generate dirty data because AccessKey pair-based authentication is not performed.
         *
         * @param request PutWebtrackingRequest
         * @return PutWebtrackingResponse
         */
        public async Task<PutWebtrackingResponse> PutWebtrackingAsync(string project, string logstoreName, PutWebtrackingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutWebtrackingWithOptionsAsync(project, logstoreName, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI QueryMLServiceResults is deprecated
         *
         * @summary queryMLServiceResults
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
         * @deprecated OpenAPI QueryMLServiceResults is deprecated
         *
         * @summary queryMLServiceResults
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
         * @deprecated OpenAPI QueryMLServiceResults is deprecated
         *
         * @summary queryMLServiceResults
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
         * @deprecated OpenAPI QueryMLServiceResults is deprecated
         *
         * @summary queryMLServiceResults
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
         * @summary 刷新token
         *
         * @param request RefreshTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshTokenResponse
         */
        public RefreshTokenResponse RefreshTokenWithOptions(RefreshTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshToken",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/token/refresh",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshTokenResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 刷新token
         *
         * @param request RefreshTokenRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RefreshTokenResponse
         */
        public async Task<RefreshTokenResponse> RefreshTokenWithOptionsAsync(RefreshTokenRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessTokenExpirationTime))
            {
                query["accessTokenExpirationTime"] = request.AccessTokenExpirationTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ticket))
            {
                query["ticket"] = request.Ticket;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RefreshToken",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/token/refresh",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RefreshTokenResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 刷新token
         *
         * @param request RefreshTokenRequest
         * @return RefreshTokenResponse
         */
        public RefreshTokenResponse RefreshToken(RefreshTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RefreshTokenWithOptions(request, headers, runtime);
        }

        /**
         * @summary 刷新token
         *
         * @param request RefreshTokenRequest
         * @return RefreshTokenResponse
         */
        public async Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RefreshTokenWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Removes a Logtail configuration from a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Removes a Logtail configuration from a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Removes a Logtail configuration from a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Removes a Logtail configuration from a machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Splits a shard in the readwrite state.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](https://help.aliyun.com/document_detail/28976.html).
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
         * @summary Splits a shard in the readwrite state.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](https://help.aliyun.com/document_detail/28976.html).
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
         * @summary Splits a shard in the readwrite state.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](https://help.aliyun.com/document_detail/28976.html).
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
         * @summary Splits a shard in the readwrite state.
         *
         * @description ### Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   Each shard has an MD5 hash range, and each range is a left-closed, right-open interval. The interval is in the `[BeginKey,EndKey)` format. A shard can be in the readwrite or readonly state. You can split a shard and merge shards. For more information, see [Shard](https://help.aliyun.com/document_detail/28976.html).
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
         * @summary 启动数据加工任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartETLResponse
         */
        public StartETLResponse StartETLWithOptions(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartETLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 启动数据加工任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartETLResponse
         */
        public async Task<StartETLResponse> StartETLWithOptionsAsync(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartETLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 启动数据加工任务
         *
         * @return StartETLResponse
         */
        public StartETLResponse StartETL(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartETLWithOptions(project, etlName, headers, runtime);
        }

        /**
         * @summary 启动数据加工任务
         *
         * @return StartETLResponse
         */
        public async Task<StartETLResponse> StartETLAsync(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartETLWithOptionsAsync(project, etlName, headers, runtime);
        }

        /**
         * @summary 启动OSS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartOSSExportResponse
         */
        public StartOSSExportResponse StartOSSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartOSSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 启动OSS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartOSSExportResponse
         */
        public async Task<StartOSSExportResponse> StartOSSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartOSSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 启动OSS投递任务
         *
         * @return StartOSSExportResponse
         */
        public StartOSSExportResponse StartOSSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartOSSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 启动OSS投递任务
         *
         * @return StartOSSExportResponse
         */
        public async Task<StartOSSExportResponse> StartOSSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartOSSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 启动OSSHDFS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartOSSHDFSExportResponse
         */
        public StartOSSHDFSExportResponse StartOSSHDFSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartOSSHDFSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 启动OSSHDFS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartOSSHDFSExportResponse
         */
        public async Task<StartOSSHDFSExportResponse> StartOSSHDFSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartOSSHDFSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 启动OSSHDFS投递任务
         *
         * @return StartOSSHDFSExportResponse
         */
        public StartOSSHDFSExportResponse StartOSSHDFSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartOSSHDFSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 启动OSSHDFS投递任务
         *
         * @return StartOSSHDFSExportResponse
         */
        public async Task<StartOSSHDFSExportResponse> StartOSSHDFSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartOSSHDFSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 启动OSS导入任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartOSSIngestionResponse
         */
        public StartOSSIngestionResponse StartOSSIngestionWithOptions(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartOSSIngestionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 启动OSS导入任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartOSSIngestionResponse
         */
        public async Task<StartOSSIngestionResponse> StartOSSIngestionWithOptionsAsync(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StartOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName + "?action=START",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartOSSIngestionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 启动OSS导入任务
         *
         * @return StartOSSIngestionResponse
         */
        public StartOSSIngestionResponse StartOSSIngestion(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartOSSIngestionWithOptions(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary 启动OSS导入任务
         *
         * @return StartOSSIngestionResponse
         */
        public async Task<StartOSSIngestionResponse> StartOSSIngestionAsync(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartOSSIngestionWithOptionsAsync(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary 停止数据加工任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopETLResponse
         */
        public StopETLResponse StopETLWithOptions(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopETLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 停止数据加工任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopETLResponse
         */
        public async Task<StopETLResponse> StopETLWithOptionsAsync(string project, string etlName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopETLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 停止数据加工任务
         *
         * @return StopETLResponse
         */
        public StopETLResponse StopETL(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopETLWithOptions(project, etlName, headers, runtime);
        }

        /**
         * @summary 停止数据加工任务
         *
         * @return StopETLResponse
         */
        public async Task<StopETLResponse> StopETLAsync(string project, string etlName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopETLWithOptionsAsync(project, etlName, headers, runtime);
        }

        /**
         * @summary 停止OSS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopOSSExportResponse
         */
        public StopOSSExportResponse StopOSSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopOSSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 停止OSS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopOSSExportResponse
         */
        public async Task<StopOSSExportResponse> StopOSSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopOSSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 停止OSS投递任务
         *
         * @return StopOSSExportResponse
         */
        public StopOSSExportResponse StopOSSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopOSSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 停止OSS投递任务
         *
         * @return StopOSSExportResponse
         */
        public async Task<StopOSSExportResponse> StopOSSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopOSSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 停止OSSHDFS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopOSSHDFSExportResponse
         */
        public StopOSSHDFSExportResponse StopOSSHDFSExportWithOptions(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopOSSHDFSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 停止OSSHDFS投递任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopOSSHDFSExportResponse
         */
        public async Task<StopOSSHDFSExportResponse> StopOSSHDFSExportWithOptionsAsync(string project, string ossExportName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopOSSHDFSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 停止OSSHDFS投递任务
         *
         * @return StopOSSHDFSExportResponse
         */
        public StopOSSHDFSExportResponse StopOSSHDFSExport(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopOSSHDFSExportWithOptions(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 停止OSSHDFS投递任务
         *
         * @return StopOSSHDFSExportResponse
         */
        public async Task<StopOSSHDFSExportResponse> StopOSSHDFSExportAsync(string project, string ossExportName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopOSSHDFSExportWithOptionsAsync(project, ossExportName, headers, runtime);
        }

        /**
         * @summary 停止OSS导入任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopOSSIngestionResponse
         */
        public StopOSSIngestionResponse StopOSSIngestionWithOptions(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopOSSIngestionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 停止OSS导入任务
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopOSSIngestionResponse
         */
        public async Task<StopOSSIngestionResponse> StopOSSIngestionWithOptionsAsync(string project, string ossIngestionName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "StopOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName + "?action=STOP",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopOSSIngestionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 停止OSS导入任务
         *
         * @return StopOSSIngestionResponse
         */
        public StopOSSIngestionResponse StopOSSIngestion(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopOSSIngestionWithOptions(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary 停止OSS导入任务
         *
         * @return StopOSSIngestionResponse
         */
        public async Task<StopOSSIngestionResponse> StopOSSIngestionAsync(string project, string ossIngestionName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopOSSIngestionWithOptionsAsync(project, ossIngestionName, headers, runtime);
        }

        /**
         * @summary Creates and adds tags to a resource. You can add tags only to projects.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:TagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Creates and adds tags to a resource. You can add tags only to projects.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:TagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Creates and adds tags to a resource. You can add tags only to projects.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:TagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Creates and adds tags to a resource. You can add tags only to projects.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html)
         * * For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:TagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Detaches one or more tags from a resource. You can detach tags only from Simple Log Service projects. You can detach multiple or all tags from a Simple Log Service project at a time.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:UntagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Detaches one or more tags from a resource. You can detach tags only from Simple Log Service projects. You can detach multiple or all tags from a Simple Log Service project at a time.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:UntagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Detaches one or more tags from a resource. You can detach tags only from Simple Log Service projects. You can detach multiple or all tags from a Simple Log Service project at a time.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:UntagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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
         * @summary Detaches one or more tags from a resource. You can detach tags only from Simple Log Service projects. You can detach multiple or all tags from a Simple Log Service project at a time.
         *
         * @description ### Usage notes
         * * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * * An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a Resource Access Management (RAM) user to call API operations or perform routine O&#x26;M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * * The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html) For more information, see [Authorization rules](https://help.aliyun.com/document_detail/29049.html). The following types of resources are supported: project, Logstore, dashboard, machine group, and Logtail configuration.
         * ### Authentication resources
         * The following table describes the authorization information that is required for this operation. You can add the information to the Action element of a RAM policy statement to grant a RAM user or a RAM role the permissions to call this operation.
         * |Action|Resource|
         * |:---|:---|
         * |`log:UntagResources`|The resource format varies based on the resource type.\\-`acs:log:{#regionId}:{#accountId}:project/{#ProjectName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logstore/${logstoreName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/dashboard/${dashboardName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/machinegroup/${machineGroupName}`\\-`acs:log:${regionName}:${accountId}:project/${projectName}/logtailconfig/${logtailConfigName}`|
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

        /**
         * @summary 更新告警
         *
         * @param request UpdateAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAlertResponse
         */
        public UpdateAlertResponse UpdateAlertWithOptions(string project, string alertName, UpdateAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateAlertResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新告警
         *
         * @param request UpdateAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAlertResponse
         */
        public async Task<UpdateAlertResponse> UpdateAlertWithOptionsAsync(string project, string alertName, UpdateAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAlert",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/alerts/" + alertName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateAlertResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新告警
         *
         * @param request UpdateAlertRequest
         * @return UpdateAlertResponse
         */
        public UpdateAlertResponse UpdateAlert(string project, string alertName, UpdateAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAlertWithOptions(project, alertName, request, headers, runtime);
        }

        /**
         * @summary 更新告警
         *
         * @param request UpdateAlertRequest
         * @return UpdateAlertResponse
         */
        public async Task<UpdateAlertResponse> UpdateAlertAsync(string project, string alertName, UpdateAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAlertWithOptionsAsync(project, alertName, request, headers, runtime);
        }

        /**
         * @summary Updates a dataset.
         *
         * @param request UpdateAnnotationDataSetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAnnotationDataSetResponse
         */
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

        /**
         * @summary Updates a dataset.
         *
         * @param request UpdateAnnotationDataSetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAnnotationDataSetResponse
         */
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

        /**
         * @summary Updates a dataset.
         *
         * @param request UpdateAnnotationDataSetRequest
         * @return UpdateAnnotationDataSetResponse
         */
        public UpdateAnnotationDataSetResponse UpdateAnnotationDataSet(string datasetId, UpdateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAnnotationDataSetWithOptions(datasetId, request, headers, runtime);
        }

        /**
         * @summary Updates a dataset.
         *
         * @param request UpdateAnnotationDataSetRequest
         * @return UpdateAnnotationDataSetResponse
         */
        public async Task<UpdateAnnotationDataSetResponse> UpdateAnnotationDataSetAsync(string datasetId, UpdateAnnotationDataSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAnnotationDataSetWithOptionsAsync(datasetId, request, headers, runtime);
        }

        /**
         * @summary Updates a tag table.
         *
         * @description You can update only the names of the tags in a tag set.
         *
         * @param request UpdateAnnotationLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAnnotationLabelResponse
         */
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

        /**
         * @summary Updates a tag table.
         *
         * @description You can update only the names of the tags in a tag set.
         *
         * @param request UpdateAnnotationLabelRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAnnotationLabelResponse
         */
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

        /**
         * @summary Updates a tag table.
         *
         * @description You can update only the names of the tags in a tag set.
         *
         * @param request UpdateAnnotationLabelRequest
         * @return UpdateAnnotationLabelResponse
         */
        public UpdateAnnotationLabelResponse UpdateAnnotationLabel(UpdateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAnnotationLabelWithOptions(request, headers, runtime);
        }

        /**
         * @summary Updates a tag table.
         *
         * @description You can update only the names of the tags in a tag set.
         *
         * @param request UpdateAnnotationLabelRequest
         * @return UpdateAnnotationLabelResponse
         */
        public async Task<UpdateAnnotationLabelResponse> UpdateAnnotationLabelAsync(UpdateAnnotationLabelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAnnotationLabelWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Modifies a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   After you update a Logtail configuration that is applied to a machine group, the new configuration immediately takes effect.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request UpdateConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConfigResponse
         */
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

        /**
         * @summary Modifies a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   After you update a Logtail configuration that is applied to a machine group, the new configuration immediately takes effect.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request UpdateConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConfigResponse
         */
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

        /**
         * @summary Modifies a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   After you update a Logtail configuration that is applied to a machine group, the new configuration immediately takes effect.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request UpdateConfigRequest
         * @return UpdateConfigResponse
         */
        public UpdateConfigResponse UpdateConfig(string project, string configName, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConfigWithOptions(project, configName, request, headers, runtime);
        }

        /**
         * @summary Modifies a Logtail configuration.
         *
         * @description ### [](#)Usage notes
         * *   Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         * *   After you update a Logtail configuration that is applied to a machine group, the new configuration immediately takes effect.
         * *   An AccessKey pair is created and obtained. For more information, see [AccessKey pair](https://help.aliyun.com/document_detail/29009.html).
         * The AccessKey pair of an Alibaba Cloud account has permissions on all API operations. Using these credentials to perform operations in Simple Log Service is a high-risk operation. We recommend that you use a RAM user to call API operations or perform routine O\\&M. To create a RAM user, log on to the RAM console. Make sure that the RAM user has the management permissions on Simple Log Service resources. For more information, see [Create a RAM user and authorize the RAM user to access Simple Log Service](https://help.aliyun.com/document_detail/47664.html).
         * *   The information that is required to query logs is obtained. The information includes the name of the project to which the logs belong and the region of the project. For more information, see [Manage a project](https://help.aliyun.com/document_detail/48984.html).
         * *   The Logtail configuration is planned out. For more information, see [Logtail configurations](https://help.aliyun.com/document_detail/29058.html).
         *
         * @param request UpdateConfigRequest
         * @return UpdateConfigResponse
         */
        public async Task<UpdateConfigResponse> UpdateConfigAsync(string project, string configName, UpdateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConfigWithOptionsAsync(project, configName, request, headers, runtime);
        }

        /**
         * @summary Updates the attributes of a consumer group.
         *
         * @description ### Usage notes
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
         * @summary Updates the attributes of a consumer group.
         *
         * @description ### Usage notes
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
         * @summary Updates the attributes of a consumer group.
         *
         * @description ### Usage notes
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
         * @summary Updates the attributes of a consumer group.
         *
         * @description ### Usage notes
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

        /**
         * @summary Updates a dashboard.
         *
         * @description ### [](#)Usage notes
         * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request UpdateDashboardRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDashboardResponse
         */
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

        /**
         * @summary Updates a dashboard.
         *
         * @description ### [](#)Usage notes
         * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request UpdateDashboardRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDashboardResponse
         */
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

        /**
         * @summary Updates a dashboard.
         *
         * @description ### [](#)Usage notes
         * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request UpdateDashboardRequest
         * @return UpdateDashboardResponse
         */
        public UpdateDashboardResponse UpdateDashboard(string project, string dashboardName, UpdateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateDashboardWithOptions(project, dashboardName, request, headers, runtime);
        }

        /**
         * @summary Updates a dashboard.
         *
         * @description ### [](#)Usage notes
         * Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
         *
         * @param request UpdateDashboardRequest
         * @return UpdateDashboardResponse
         */
        public async Task<UpdateDashboardResponse> UpdateDashboardAsync(string project, string dashboardName, UpdateDashboardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateDashboardWithOptionsAsync(project, dashboardName, request, headers, runtime);
        }

        /**
         * @summary 更新数据加工任务
         *
         * @param request UpdateETLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateETLResponse
         */
        public UpdateETLResponse UpdateETLWithOptions(string project, string etlName, UpdateETLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
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
                Action = "UpdateETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateETLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新数据加工任务
         *
         * @param request UpdateETLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateETLResponse
         */
        public async Task<UpdateETLResponse> UpdateETLWithOptionsAsync(string project, string etlName, UpdateETLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
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
                Action = "UpdateETL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/etls/" + etlName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateETLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新数据加工任务
         *
         * @param request UpdateETLRequest
         * @return UpdateETLResponse
         */
        public UpdateETLResponse UpdateETL(string project, string etlName, UpdateETLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateETLWithOptions(project, etlName, request, headers, runtime);
        }

        /**
         * @summary 更新数据加工任务
         *
         * @param request UpdateETLRequest
         * @return UpdateETLResponse
         */
        public async Task<UpdateETLResponse> UpdateETLAsync(string project, string etlName, UpdateETLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateETLWithOptionsAsync(project, etlName, request, headers, runtime);
        }

        /**
         * @summary Updates the indexes of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Updates the indexes of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Updates the indexes of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Updates the indexes of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Updates the attributes of a Logstore.
         *
         * @description ### Usage notes
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfrequentAccessTTL))
            {
                body["infrequentAccessTTL"] = request.InfrequentAccessTTL;
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
         * @summary Updates the attributes of a Logstore.
         *
         * @description ### Usage notes
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfrequentAccessTTL))
            {
                body["infrequentAccessTTL"] = request.InfrequentAccessTTL;
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
         * @summary Updates the attributes of a Logstore.
         *
         * @description ### Usage notes
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
         * @summary Updates the attributes of a Logstore.
         *
         * @description ### Usage notes
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

        /**
         * @summary Changes the billing mode of a Logstore.
         *
         * @param request UpdateLogStoreMeteringModeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLogStoreMeteringModeResponse
         */
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

        /**
         * @summary Changes the billing mode of a Logstore.
         *
         * @param request UpdateLogStoreMeteringModeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLogStoreMeteringModeResponse
         */
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

        /**
         * @summary Changes the billing mode of a Logstore.
         *
         * @param request UpdateLogStoreMeteringModeRequest
         * @return UpdateLogStoreMeteringModeResponse
         */
        public UpdateLogStoreMeteringModeResponse UpdateLogStoreMeteringMode(string project, string logstore, UpdateLogStoreMeteringModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogStoreMeteringModeWithOptions(project, logstore, request, headers, runtime);
        }

        /**
         * @summary Changes the billing mode of a Logstore.
         *
         * @param request UpdateLogStoreMeteringModeRequest
         * @return UpdateLogStoreMeteringModeResponse
         */
        public async Task<UpdateLogStoreMeteringModeResponse> UpdateLogStoreMeteringModeAsync(string project, string logstore, UpdateLogStoreMeteringModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogStoreMeteringModeWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        /**
         * @summary Updates the service log configurations of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Updates the service log configurations of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Updates the service log configurations of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Updates the service log configurations of a project.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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

        /**
         * @summary Updates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request UpdateLogtailPipelineConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Updates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request UpdateLogtailPipelineConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateLogtailPipelineConfigResponse
         */
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

        /**
         * @summary Updates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request UpdateLogtailPipelineConfigRequest
         * @return UpdateLogtailPipelineConfigResponse
         */
        public UpdateLogtailPipelineConfigResponse UpdateLogtailPipelineConfig(string project, string configName, UpdateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogtailPipelineConfigWithOptions(project, configName, request, headers, runtime);
        }

        /**
         * @summary Updates a Logtail pipeline configuration.
         *
         * @description The UK (London) region is supported. Supported regions are constantly updated.
         *
         * @param request UpdateLogtailPipelineConfigRequest
         * @return UpdateLogtailPipelineConfigResponse
         */
        public async Task<UpdateLogtailPipelineConfigResponse> UpdateLogtailPipelineConfigAsync(string project, string configName, UpdateLogtailPipelineConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogtailPipelineConfigWithOptionsAsync(project, configName, request, headers, runtime);
        }

        /**
         * @summary Modifies the configuration of a machine group.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the configuration of a machine group.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the configuration of a machine group.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the configuration of a machine group.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the machines in a machine group. You can add machine to or remove machines from the machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the machines in a machine group. You can add machine to or remove machines from the machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the machines in a machine group. You can add machine to or remove machines from the machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary Modifies the machines in a machine group. You can add machine to or remove machines from the machine group.
         *
         * @description Host consists of a project name and a Simple Log Service endpoint. You must specify a project in Host.
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
         * @summary 更新 MetricStore 计量模式
         *
         * @param request UpdateMetricStoreMeteringModeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMetricStoreMeteringModeResponse
         */
        public UpdateMetricStoreMeteringModeResponse UpdateMetricStoreMeteringModeWithOptions(string project, string metricStore, UpdateMetricStoreMeteringModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateMetricStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/metricstores/" + metricStore + "/meteringmode",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMetricStoreMeteringModeResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新 MetricStore 计量模式
         *
         * @param request UpdateMetricStoreMeteringModeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateMetricStoreMeteringModeResponse
         */
        public async Task<UpdateMetricStoreMeteringModeResponse> UpdateMetricStoreMeteringModeWithOptionsAsync(string project, string metricStore, UpdateMetricStoreMeteringModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UpdateMetricStoreMeteringMode",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/metricstores/" + metricStore + "/meteringmode",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateMetricStoreMeteringModeResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新 MetricStore 计量模式
         *
         * @param request UpdateMetricStoreMeteringModeRequest
         * @return UpdateMetricStoreMeteringModeResponse
         */
        public UpdateMetricStoreMeteringModeResponse UpdateMetricStoreMeteringMode(string project, string metricStore, UpdateMetricStoreMeteringModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMetricStoreMeteringModeWithOptions(project, metricStore, request, headers, runtime);
        }

        /**
         * @summary 更新 MetricStore 计量模式
         *
         * @param request UpdateMetricStoreMeteringModeRequest
         * @return UpdateMetricStoreMeteringModeResponse
         */
        public async Task<UpdateMetricStoreMeteringModeResponse> UpdateMetricStoreMeteringModeAsync(string project, string metricStore, UpdateMetricStoreMeteringModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMetricStoreMeteringModeWithOptionsAsync(project, metricStore, request, headers, runtime);
        }

        /**
         * @summary 更新OSS投递任务
         *
         * @param request UpdateOSSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOSSExportResponse
         */
        public UpdateOSSExportResponse UpdateOSSExportWithOptions(string project, string ossExportName, UpdateOSSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
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
                Action = "UpdateOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOSSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新OSS投递任务
         *
         * @param request UpdateOSSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOSSExportResponse
         */
        public async Task<UpdateOSSExportResponse> UpdateOSSExportWithOptionsAsync(string project, string ossExportName, UpdateOSSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
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
                Action = "UpdateOSSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossexports/" + ossExportName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOSSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新OSS投递任务
         *
         * @param request UpdateOSSExportRequest
         * @return UpdateOSSExportResponse
         */
        public UpdateOSSExportResponse UpdateOSSExport(string project, string ossExportName, UpdateOSSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOSSExportWithOptions(project, ossExportName, request, headers, runtime);
        }

        /**
         * @summary 更新OSS投递任务
         *
         * @param request UpdateOSSExportRequest
         * @return UpdateOSSExportResponse
         */
        public async Task<UpdateOSSExportResponse> UpdateOSSExportAsync(string project, string ossExportName, UpdateOSSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOSSExportWithOptionsAsync(project, ossExportName, request, headers, runtime);
        }

        /**
         * @summary 更新OSSHDFS投递任务
         *
         * @param request UpdateOSSHDFSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOSSHDFSExportResponse
         */
        public UpdateOSSHDFSExportResponse UpdateOSSHDFSExportWithOptions(string project, string ossExportName, UpdateOSSHDFSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
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
                Action = "UpdateOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOSSHDFSExportResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新OSSHDFS投递任务
         *
         * @param request UpdateOSSHDFSExportRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOSSHDFSExportResponse
         */
        public async Task<UpdateOSSHDFSExportResponse> UpdateOSSHDFSExportWithOptionsAsync(string project, string ossExportName, UpdateOSSHDFSExportRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
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
                Action = "UpdateOSSHDFSExport",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/osshdfsexports/" + ossExportName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOSSHDFSExportResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新OSSHDFS投递任务
         *
         * @param request UpdateOSSHDFSExportRequest
         * @return UpdateOSSHDFSExportResponse
         */
        public UpdateOSSHDFSExportResponse UpdateOSSHDFSExport(string project, string ossExportName, UpdateOSSHDFSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOSSHDFSExportWithOptions(project, ossExportName, request, headers, runtime);
        }

        /**
         * @summary 更新OSSHDFS投递任务
         *
         * @param request UpdateOSSHDFSExportRequest
         * @return UpdateOSSHDFSExportResponse
         */
        public async Task<UpdateOSSHDFSExportResponse> UpdateOSSHDFSExportAsync(string project, string ossExportName, UpdateOSSHDFSExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOSSHDFSExportWithOptionsAsync(project, ossExportName, request, headers, runtime);
        }

        /**
         * @summary 更新oss导入任务
         *
         * @param request UpdateOSSIngestionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOSSIngestionResponse
         */
        public UpdateOSSIngestionResponse UpdateOSSIngestionWithOptions(string project, string ossIngestionName, UpdateOSSIngestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOSSIngestionResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新oss导入任务
         *
         * @param request UpdateOSSIngestionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateOSSIngestionResponse
         */
        public async Task<UpdateOSSIngestionResponse> UpdateOSSIngestionWithOptionsAsync(string project, string ossIngestionName, UpdateOSSIngestionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOSSIngestion",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/ossingestions/" + ossIngestionName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOSSIngestionResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新oss导入任务
         *
         * @param request UpdateOSSIngestionRequest
         * @return UpdateOSSIngestionResponse
         */
        public UpdateOSSIngestionResponse UpdateOSSIngestion(string project, string ossIngestionName, UpdateOSSIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOSSIngestionWithOptions(project, ossIngestionName, request, headers, runtime);
        }

        /**
         * @summary 更新oss导入任务
         *
         * @param request UpdateOSSIngestionRequest
         * @return UpdateOSSIngestionResponse
         */
        public async Task<UpdateOSSIngestionResponse> UpdateOSSIngestionAsync(string project, string ossIngestionName, UpdateOSSIngestionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOSSIngestionWithOptionsAsync(project, ossIngestionName, request, headers, runtime);
        }

        /**
         * @summary Updates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Updates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Updates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Updates an Object Storage Service (OSS) external store.
         *
         * @description ### [](#)Usage notes
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
         * @summary Updates a project.
         *
         * @description ### Usage notes
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
         * @summary Updates a project.
         *
         * @description ### Usage notes
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
         * @summary Updates a project.
         *
         * @description ### Usage notes
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
         * @summary Updates a project.
         *
         * @description ### Usage notes
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
         * @summary Updates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Updates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Updates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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
         * @summary Updates an ApsaraDB RDS external store.
         *
         * @description Host consists of a project name and a Log Service endpoint. You must specify a project in Host.
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

        /**
         * @summary Updates a saved search.
         *
         * @param request UpdateSavedSearchRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSavedSearchResponse
         */
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

        /**
         * @summary Updates a saved search.
         *
         * @param request UpdateSavedSearchRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSavedSearchResponse
         */
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

        /**
         * @summary Updates a saved search.
         *
         * @param request UpdateSavedSearchRequest
         * @return UpdateSavedSearchResponse
         */
        public UpdateSavedSearchResponse UpdateSavedSearch(string project, string savedsearchName, UpdateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSavedSearchWithOptions(project, savedsearchName, request, headers, runtime);
        }

        /**
         * @summary Updates a saved search.
         *
         * @param request UpdateSavedSearchRequest
         * @return UpdateSavedSearchResponse
         */
        public async Task<UpdateSavedSearchResponse> UpdateSavedSearchAsync(string project, string savedsearchName, UpdateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSavedSearchWithOptionsAsync(project, savedsearchName, request, headers, runtime);
        }

        /**
         * @summary 更新定时SQL任务
         *
         * @param request UpdateScheduledSQLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduledSQLResponse
         */
        public UpdateScheduledSQLResponse UpdateScheduledSQLWithOptions(string project, string scheduledSQLName, UpdateScheduledSQLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateScheduledSQLResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新定时SQL任务
         *
         * @param request UpdateScheduledSQLRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateScheduledSQLResponse
         */
        public async Task<UpdateScheduledSQLResponse> UpdateScheduledSQLWithOptionsAsync(string project, string scheduledSQLName, UpdateScheduledSQLRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configuration))
            {
                body["configuration"] = request.Configuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                body["displayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                body["schedule"] = request.Schedule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateScheduledSQL",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/scheduledsqls/" + scheduledSQLName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateScheduledSQLResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新定时SQL任务
         *
         * @param request UpdateScheduledSQLRequest
         * @return UpdateScheduledSQLResponse
         */
        public UpdateScheduledSQLResponse UpdateScheduledSQL(string project, string scheduledSQLName, UpdateScheduledSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateScheduledSQLWithOptions(project, scheduledSQLName, request, headers, runtime);
        }

        /**
         * @summary 更新定时SQL任务
         *
         * @param request UpdateScheduledSQLRequest
         * @return UpdateScheduledSQLResponse
         */
        public async Task<UpdateScheduledSQLResponse> UpdateScheduledSQLAsync(string project, string scheduledSQLName, UpdateScheduledSQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateScheduledSQLWithOptionsAsync(project, scheduledSQLName, request, headers, runtime);
        }

        /**
         * @summary 更新独享sql实例
         *
         * @param request UpdateSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceResponse
         */
        public UpdateSqlInstanceResponse UpdateSqlInstanceWithOptions(string project, UpdateSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                body["cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAsDefault))
            {
                body["useAsDefault"] = request.UseAsDefault;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSqlInstance",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/sqlinstance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSqlInstanceResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新独享sql实例
         *
         * @param request UpdateSqlInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateSqlInstanceResponse
         */
        public async Task<UpdateSqlInstanceResponse> UpdateSqlInstanceWithOptionsAsync(string project, UpdateSqlInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cu))
            {
                body["cu"] = request.Cu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseAsDefault))
            {
                body["useAsDefault"] = request.UseAsDefault;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSqlInstance",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/sqlinstance",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateSqlInstanceResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新独享sql实例
         *
         * @param request UpdateSqlInstanceRequest
         * @return UpdateSqlInstanceResponse
         */
        public UpdateSqlInstanceResponse UpdateSqlInstance(string project, UpdateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSqlInstanceWithOptions(project, request, headers, runtime);
        }

        /**
         * @summary 更新独享sql实例
         *
         * @param request UpdateSqlInstanceRequest
         * @return UpdateSqlInstanceResponse
         */
        public async Task<UpdateSqlInstanceResponse> UpdateSqlInstanceAsync(string project, UpdateSqlInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSqlInstanceWithOptionsAsync(project, request, headers, runtime);
        }

        /**
         * @summary 更新StoreView
         *
         * @param request UpdateStoreViewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoreViewResponse
         */
        public UpdateStoreViewResponse UpdateStoreViewWithOptions(string project, string name, UpdateStoreViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["stores"] = request.Stores;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateStoreViewResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 更新StoreView
         *
         * @param request UpdateStoreViewRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateStoreViewResponse
         */
        public async Task<UpdateStoreViewResponse> UpdateStoreViewWithOptionsAsync(string project, string name, UpdateStoreViewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StoreType))
            {
                body["storeType"] = request.StoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stores))
            {
                body["stores"] = request.Stores;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateStoreView",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/storeviews/" + name,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateStoreViewResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 更新StoreView
         *
         * @param request UpdateStoreViewRequest
         * @return UpdateStoreViewResponse
         */
        public UpdateStoreViewResponse UpdateStoreView(string project, string name, UpdateStoreViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateStoreViewWithOptions(project, name, request, headers, runtime);
        }

        /**
         * @summary 更新StoreView
         *
         * @param request UpdateStoreViewRequest
         * @return UpdateStoreViewResponse
         */
        public async Task<UpdateStoreViewResponse> UpdateStoreViewAsync(string project, string name, UpdateStoreViewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateStoreViewWithOptionsAsync(project, name, request, headers, runtime);
        }

        /**
         * @summary 调用UpsertCollectionPolicy接口创建或更新日志采集规则
         *
         * @param request UpsertCollectionPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpsertCollectionPolicyResponse
         */
        public UpsertCollectionPolicyResponse UpsertCollectionPolicyWithOptions(UpsertCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataConfig))
            {
                body["dataConfig"] = request.DataConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectory))
            {
                body["resourceDirectory"] = request.ResourceDirectory;
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
                BodyType = "none",
            };
            return TeaModel.ToObject<UpsertCollectionPolicyResponse>(Execute(params_, req, runtime));
        }

        /**
         * @summary 调用UpsertCollectionPolicy接口创建或更新日志采集规则
         *
         * @param request UpsertCollectionPolicyRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpsertCollectionPolicyResponse
         */
        public async Task<UpsertCollectionPolicyResponse> UpsertCollectionPolicyWithOptionsAsync(UpsertCollectionPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataConfig))
            {
                body["dataConfig"] = request.DataConfig;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectory))
            {
                body["resourceDirectory"] = request.ResourceDirectory;
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
                BodyType = "none",
            };
            return TeaModel.ToObject<UpsertCollectionPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        /**
         * @summary 调用UpsertCollectionPolicy接口创建或更新日志采集规则
         *
         * @param request UpsertCollectionPolicyRequest
         * @return UpsertCollectionPolicyResponse
         */
        public UpsertCollectionPolicyResponse UpsertCollectionPolicy(UpsertCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpsertCollectionPolicyWithOptions(request, headers, runtime);
        }

        /**
         * @summary 调用UpsertCollectionPolicy接口创建或更新日志采集规则
         *
         * @param request UpsertCollectionPolicyRequest
         * @return UpsertCollectionPolicyResponse
         */
        public async Task<UpsertCollectionPolicyResponse> UpsertCollectionPolicyAsync(UpsertCollectionPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpsertCollectionPolicyWithOptionsAsync(request, headers, runtime);
        }

    }
}
