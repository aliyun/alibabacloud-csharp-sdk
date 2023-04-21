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

        public ApplyConfigToMachineGroupResponse ApplyConfigToMachineGroup(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyConfigToMachineGroupWithOptions(project, machineGroup, configName, headers, runtime);
        }

        public async Task<ApplyConfigToMachineGroupResponse> ApplyConfigToMachineGroupAsync(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyConfigToMachineGroupWithOptionsAsync(project, machineGroup, configName, headers, runtime);
        }

        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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

        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(request, headers, runtime);
        }

        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(request, headers, runtime);
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

        public CreateConsumerGroupResponse CreateConsumerGroup(string project, string logstore, CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConsumerGroupWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(string project, string logstore, CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConsumerGroupWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public CreateDomainResponse CreateDomain(string project, CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDomainWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateDomainResponse> CreateDomainAsync(string project, CreateDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDomainWithOptionsAsync(project, request, headers, runtime);
        }

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

        public CreateIndexResponse CreateIndex(string project, string logstore, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateIndexWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<CreateIndexResponse> CreateIndexAsync(string project, string logstore, CreateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateIndexWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public CreateLogStoreResponse CreateLogStore(string project, CreateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLogStoreWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateLogStoreResponse> CreateLogStoreAsync(string project, CreateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLogStoreWithOptionsAsync(project, request, headers, runtime);
        }

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

        public CreateLoggingResponse CreateLogging(string project, CreateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateLoggingWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateLoggingResponse> CreateLoggingAsync(string project, CreateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateLoggingWithOptionsAsync(project, request, headers, runtime);
        }

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

        public CreateMachineGroupResponse CreateMachineGroup(string project, CreateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMachineGroupWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateMachineGroupResponse> CreateMachineGroupAsync(string project, CreateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMachineGroupWithOptionsAsync(project, request, headers, runtime);
        }

        public CreateOdpsShipperResponse CreateOdpsShipperWithOptions(string project, string logstore, CreateOdpsShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOdpsShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOdpsShipperResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateOdpsShipperResponse> CreateOdpsShipperWithOptionsAsync(string project, string logstore, CreateOdpsShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOdpsShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOdpsShipperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateOdpsShipperResponse CreateOdpsShipper(string project, string logstore, CreateOdpsShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOdpsShipperWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<CreateOdpsShipperResponse> CreateOdpsShipperAsync(string project, string logstore, CreateOdpsShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOdpsShipperWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public CreateOssExternalStoreResponse CreateOssExternalStore(string project, CreateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOssExternalStoreWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateOssExternalStoreResponse> CreateOssExternalStoreAsync(string project, CreateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOssExternalStoreWithOptionsAsync(project, request, headers, runtime);
        }

        public CreateOssShipperResponse CreateOssShipperWithOptions(string project, string logstore, CreateOssShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOssShipperResponse>(Execute(params_, req, runtime));
        }

        public async Task<CreateOssShipperResponse> CreateOssShipperWithOptionsAsync(string project, string logstore, CreateOssShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOssShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateOssShipperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public CreateOssShipperResponse CreateOssShipper(string project, string logstore, CreateOssShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateOssShipperWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<CreateOssShipperResponse> CreateOssShipperAsync(string project, string logstore, CreateOssShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateOssShipperWithOptionsAsync(project, logstore, request, headers, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
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

        public CreateRdsExternalStoreResponse CreateRdsExternalStore(string project, CreateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRdsExternalStoreWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateRdsExternalStoreResponse> CreateRdsExternalStoreAsync(string project, CreateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRdsExternalStoreWithOptionsAsync(project, request, headers, runtime);
        }

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

        public CreateSavedSearchResponse CreateSavedSearch(string project, CreateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSavedSearchWithOptions(project, request, headers, runtime);
        }

        public async Task<CreateSavedSearchResponse> CreateSavedSearchAsync(string project, CreateSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSavedSearchWithOptionsAsync(project, request, headers, runtime);
        }

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

        public DeleteConsumerGroupResponse DeleteConsumerGroup(string project, string logstore, string consumerGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConsumerGroupWithOptions(project, logstore, consumerGroup, headers, runtime);
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(string project, string logstore, string consumerGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerGroupWithOptionsAsync(project, logstore, consumerGroup, headers, runtime);
        }

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

        public DeleteDomainResponse DeleteDomain(string project, string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteDomainWithOptions(project, domainName, headers, runtime);
        }

        public async Task<DeleteDomainResponse> DeleteDomainAsync(string project, string domainName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteDomainWithOptionsAsync(project, domainName, headers, runtime);
        }

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

        public DeleteExternalStoreResponse DeleteExternalStore(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteExternalStoreWithOptions(project, externalStoreName, headers, runtime);
        }

        public async Task<DeleteExternalStoreResponse> DeleteExternalStoreAsync(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteExternalStoreWithOptionsAsync(project, externalStoreName, headers, runtime);
        }

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

        public DeleteIndexResponse DeleteIndex(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteIndexWithOptions(project, logstore, headers, runtime);
        }

        public async Task<DeleteIndexResponse> DeleteIndexAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteIndexWithOptionsAsync(project, logstore, headers, runtime);
        }

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

        public DeleteLogStoreResponse DeleteLogStore(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteLogStoreWithOptions(project, logstore, headers, runtime);
        }

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

        public DeleteMachineGroupResponse DeleteMachineGroup(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMachineGroupWithOptions(project, machineGroup, headers, runtime);
        }

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
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectPolicyResponse>(Execute(params_, req, runtime));
        }

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
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public DeleteProjectPolicyResponse DeleteProjectPolicy(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectPolicyWithOptions(project, headers, runtime);
        }

        public async Task<DeleteProjectPolicyResponse> DeleteProjectPolicyAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectPolicyWithOptionsAsync(project, headers, runtime);
        }

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

        public DeleteSavedSearchResponse DeleteSavedSearch(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSavedSearchWithOptions(project, savedsearchName, headers, runtime);
        }

        public async Task<DeleteSavedSearchResponse> DeleteSavedSearchAsync(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSavedSearchWithOptionsAsync(project, savedsearchName, headers, runtime);
        }

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

        public DeleteShipperResponse DeleteShipper(string project, string logstore, string shipperName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteShipperWithOptions(project, logstore, shipperName, headers, runtime);
        }

        public async Task<DeleteShipperResponse> DeleteShipperAsync(string project, string logstore, string shipperName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteShipperWithOptionsAsync(project, logstore, shipperName, headers, runtime);
        }

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

        public GetAppliedConfigsResponse GetAppliedConfigs(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppliedConfigsWithOptions(project, machineGroup, headers, runtime);
        }

        public async Task<GetAppliedConfigsResponse> GetAppliedConfigsAsync(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppliedConfigsWithOptionsAsync(project, machineGroup, headers, runtime);
        }

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

        public GetAppliedMachineGroupsResponse GetAppliedMachineGroups(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetAppliedMachineGroupsWithOptions(project, configName, headers, runtime);
        }

        public async Task<GetAppliedMachineGroupsResponse> GetAppliedMachineGroupsAsync(string project, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetAppliedMachineGroupsWithOptionsAsync(project, configName, headers, runtime);
        }

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

        public GetCheckPointResponse GetCheckPoint(string project, string logstore, string consumerGroup, GetCheckPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCheckPointWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        public async Task<GetCheckPointResponse> GetCheckPointAsync(string project, string logstore, string consumerGroup, GetCheckPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetCheckPointWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

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

        public GetContextLogsResponse GetContextLogs(string project, string logstore, GetContextLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetContextLogsWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<GetContextLogsResponse> GetContextLogsAsync(string project, string logstore, GetContextLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetContextLogsWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public GetCursorResponse GetCursor(string project, string logstore, string shardId, GetCursorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetCursorWithOptions(project, logstore, shardId, request, headers, runtime);
        }

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

        public GetExternalStoreResponse GetExternalStore(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExternalStoreWithOptions(project, externalStoreName, headers, runtime);
        }

        public async Task<GetExternalStoreResponse> GetExternalStoreAsync(string project, string externalStoreName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExternalStoreWithOptionsAsync(project, externalStoreName, headers, runtime);
        }

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

        public GetHistogramsResponse GetHistograms(string project, string logstore, GetHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetHistogramsWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<GetHistogramsResponse> GetHistogramsAsync(string project, string logstore, GetHistogramsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetHistogramsWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public GetIndexResponse GetIndex(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetIndexWithOptions(project, logstore, headers, runtime);
        }

        public async Task<GetIndexResponse> GetIndexAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetIndexWithOptionsAsync(project, logstore, headers, runtime);
        }

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

        public GetLogStoreResponse GetLogStore(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogStoreWithOptions(project, logstore, headers, runtime);
        }

        public async Task<GetLogStoreResponse> GetLogStoreAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogStoreWithOptionsAsync(project, logstore, headers, runtime);
        }

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

        public GetLoggingResponse GetLogging(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLoggingWithOptions(project, headers, runtime);
        }

        public async Task<GetLoggingResponse> GetLoggingAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLoggingWithOptionsAsync(project, headers, runtime);
        }

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

        public GetLogsResponse GetLogs(string project, string logstore, GetLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetLogsWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<GetLogsResponse> GetLogsAsync(string project, string logstore, GetLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetLogsWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public GetMachineGroupResponse GetMachineGroup(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMachineGroupWithOptions(project, machineGroup, headers, runtime);
        }

        public async Task<GetMachineGroupResponse> GetMachineGroupAsync(string project, string machineGroup)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMachineGroupWithOptionsAsync(project, machineGroup, headers, runtime);
        }

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

        public GetProjectResponse GetProject(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(project, headers, runtime);
        }

        public async Task<GetProjectResponse> GetProjectAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(project, headers, runtime);
        }

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

        public GetProjectLogsResponse GetProjectLogs(string project, GetProjectLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectLogsWithOptions(project, request, headers, runtime);
        }

        public async Task<GetProjectLogsResponse> GetProjectLogsAsync(string project, GetProjectLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectLogsWithOptionsAsync(project, request, headers, runtime);
        }

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

        public GetProjectPolicyResponse GetProjectPolicy(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectPolicyWithOptions(project, headers, runtime);
        }

        public async Task<GetProjectPolicyResponse> GetProjectPolicyAsync(string project)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectPolicyWithOptionsAsync(project, headers, runtime);
        }

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

        public GetSavedSearchResponse GetSavedSearch(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSavedSearchWithOptions(project, savedsearchName, headers, runtime);
        }

        public async Task<GetSavedSearchResponse> GetSavedSearchAsync(string project, string savedsearchName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSavedSearchWithOptionsAsync(project, savedsearchName, headers, runtime);
        }

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

        public GetShipperStatusResponse GetShipperStatus(string project, string logstore, string shipperName, GetShipperStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetShipperStatusWithOptions(project, logstore, shipperName, request, headers, runtime);
        }

        public async Task<GetShipperStatusResponse> GetShipperStatusAsync(string project, string logstore, string shipperName, GetShipperStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetShipperStatusWithOptionsAsync(project, logstore, shipperName, request, headers, runtime);
        }

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

        public ListConsumerGroupResponse ListConsumerGroup(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumerGroupWithOptions(project, logstore, headers, runtime);
        }

        public async Task<ListConsumerGroupResponse> ListConsumerGroupAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumerGroupWithOptionsAsync(project, logstore, headers, runtime);
        }

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

        public ListDomainsResponse ListDomains(string project, ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListDomainsWithOptions(project, request, headers, runtime);
        }

        public async Task<ListDomainsResponse> ListDomainsAsync(string project, ListDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListDomainsWithOptionsAsync(project, request, headers, runtime);
        }

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

        public ListExternalStoreResponse ListExternalStore(string project, ListExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExternalStoreWithOptions(project, request, headers, runtime);
        }

        public async Task<ListExternalStoreResponse> ListExternalStoreAsync(string project, ListExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExternalStoreWithOptionsAsync(project, request, headers, runtime);
        }

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

        public ListLogStoresResponse ListLogStores(string project, ListLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListLogStoresWithOptions(project, request, headers, runtime);
        }

        public async Task<ListLogStoresResponse> ListLogStoresAsync(string project, ListLogStoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListLogStoresWithOptionsAsync(project, request, headers, runtime);
        }

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

        public ListMachineGroupResponse ListMachineGroup(string project, ListMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMachineGroupWithOptions(project, request, headers, runtime);
        }

        public async Task<ListMachineGroupResponse> ListMachineGroupAsync(string project, ListMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMachineGroupWithOptionsAsync(project, request, headers, runtime);
        }

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

        public ListMachinesResponse ListMachines(string project, string machineGroup, ListMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMachinesWithOptions(project, machineGroup, request, headers, runtime);
        }

        public async Task<ListMachinesResponse> ListMachinesAsync(string project, string machineGroup, ListMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMachinesWithOptionsAsync(project, machineGroup, request, headers, runtime);
        }

        public ListProjectResponse ListProjectWithOptions(string resourceGroupId, ListProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public async Task<ListProjectResponse> ListProjectWithOptionsAsync(string resourceGroupId, ListProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        public ListProjectResponse ListProject(string resourceGroupId, ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectWithOptions(resourceGroupId, request, headers, runtime);
        }

        public async Task<ListProjectResponse> ListProjectAsync(string resourceGroupId, ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectWithOptionsAsync(resourceGroupId, request, headers, runtime);
        }

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

        public ListSavedSearchResponse ListSavedSearch(string project, ListSavedSearchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSavedSearchWithOptions(project, request, headers, runtime);
        }

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

        public ListShipperResponse ListShipper(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListShipperWithOptions(project, logstore, headers, runtime);
        }

        public async Task<ListShipperResponse> ListShipperAsync(string project, string logstore)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListShipperWithOptionsAsync(project, logstore, headers, runtime);
        }

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

        public PullDataResponse PullDataWithOptions(string project, string logstore, string shard, PullDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCursor))
            {
                query["endCursor"] = request.EndCursor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shard + "?type=log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDataResponse>(Execute(params_, req, runtime));
        }

        public async Task<PullDataResponse> PullDataWithOptionsAsync(string project, string logstore, string shard, PullDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndCursor))
            {
                query["endCursor"] = request.EndCursor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullData",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shard + "?type=log",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullDataResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PullDataResponse PullData(string project, string logstore, string shard, PullDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PullDataWithOptions(project, logstore, shard, request, headers, runtime);
        }

        public async Task<PullDataResponse> PullDataAsync(string project, string logstore, string shard, PullDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PullDataWithOptionsAsync(project, logstore, shard, request, headers, runtime);
        }

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
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProjectPolicyResponse>(Execute(params_, req, runtime));
        }

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
                BodyType = "json",
            };
            return TeaModel.ToObject<PutProjectPolicyResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public PutProjectPolicyResponse PutProjectPolicy(string project, PutProjectPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PutProjectPolicyWithOptions(project, request, headers, runtime);
        }

        public async Task<PutProjectPolicyResponse> PutProjectPolicyAsync(string project, PutProjectPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PutProjectPolicyWithOptionsAsync(project, request, headers, runtime);
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

        public RemoveConfigFromMachineGroupResponse RemoveConfigFromMachineGroup(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveConfigFromMachineGroupWithOptions(project, machineGroup, configName, headers, runtime);
        }

        public async Task<RemoveConfigFromMachineGroupResponse> RemoveConfigFromMachineGroupAsync(string project, string machineGroup, string configName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveConfigFromMachineGroupWithOptionsAsync(project, machineGroup, configName, headers, runtime);
        }

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

        public SplitShardResponse SplitShard(string project, string logstore, string shard, SplitShardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitShardWithOptions(project, logstore, shard, request, headers, runtime);
        }

        public async Task<SplitShardResponse> SplitShardAsync(string project, string logstore, string shard, SplitShardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitShardWithOptionsAsync(project, logstore, shard, request, headers, runtime);
        }

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
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(Execute(params_, req, runtime));
        }

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
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
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

        public UpdateConsumerGroupResponse UpdateConsumerGroup(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConsumerGroupWithOptions(project, logstore, consumerGroup, request, headers, runtime);
        }

        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupAsync(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConsumerGroupWithOptionsAsync(project, logstore, consumerGroup, request, headers, runtime);
        }

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

        public UpdateIndexResponse UpdateIndex(string project, string logstore, UpdateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateIndexWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<UpdateIndexResponse> UpdateIndexAsync(string project, string logstore, UpdateIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateIndexWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public UpdateLogStoreResponse UpdateLogStore(string project, string logstore, UpdateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLogStoreWithOptions(project, logstore, request, headers, runtime);
        }

        public async Task<UpdateLogStoreResponse> UpdateLogStoreAsync(string project, string logstore, UpdateLogStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLogStoreWithOptionsAsync(project, logstore, request, headers, runtime);
        }

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

        public UpdateLoggingResponse UpdateLogging(string project, UpdateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateLoggingWithOptions(project, request, headers, runtime);
        }

        public async Task<UpdateLoggingResponse> UpdateLoggingAsync(string project, UpdateLoggingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateLoggingWithOptionsAsync(project, request, headers, runtime);
        }

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

        public UpdateMachineGroupResponse UpdateMachineGroup(string project, string groupName, UpdateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMachineGroupWithOptions(project, groupName, request, headers, runtime);
        }

        public async Task<UpdateMachineGroupResponse> UpdateMachineGroupAsync(string project, string groupName, UpdateMachineGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMachineGroupWithOptionsAsync(project, groupName, request, headers, runtime);
        }

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

        public UpdateMachineGroupMachineResponse UpdateMachineGroupMachine(string project, string machineGroup, UpdateMachineGroupMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMachineGroupMachineWithOptions(project, machineGroup, request, headers, runtime);
        }

        public async Task<UpdateMachineGroupMachineResponse> UpdateMachineGroupMachineAsync(string project, string machineGroup, UpdateMachineGroupMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMachineGroupMachineWithOptionsAsync(project, machineGroup, request, headers, runtime);
        }

        public UpdateOdpsShipperResponse UpdateOdpsShipperWithOptions(string project, string logstore, string shipperName, UpdateOdpsShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOdpsShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOdpsShipperResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateOdpsShipperResponse> UpdateOdpsShipperWithOptionsAsync(string project, string logstore, string shipperName, UpdateOdpsShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOdpsShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOdpsShipperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateOdpsShipperResponse UpdateOdpsShipper(string project, string logstore, string shipperName, UpdateOdpsShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOdpsShipperWithOptions(project, logstore, shipperName, request, headers, runtime);
        }

        public async Task<UpdateOdpsShipperResponse> UpdateOdpsShipperAsync(string project, string logstore, string shipperName, UpdateOdpsShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOdpsShipperWithOptionsAsync(project, logstore, shipperName, request, headers, runtime);
        }

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

        public UpdateOssExternalStoreResponse UpdateOssExternalStore(string project, string externalStoreName, UpdateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOssExternalStoreWithOptions(project, externalStoreName, request, headers, runtime);
        }

        public async Task<UpdateOssExternalStoreResponse> UpdateOssExternalStoreAsync(string project, string externalStoreName, UpdateOssExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOssExternalStoreWithOptionsAsync(project, externalStoreName, request, headers, runtime);
        }

        public UpdateOssShipperResponse UpdateOssShipperWithOptions(string project, string logstore, string shipperName, UpdateOssShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOssShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOssShipperResponse>(Execute(params_, req, runtime));
        }

        public async Task<UpdateOssShipperResponse> UpdateOssShipperWithOptionsAsync(string project, string logstore, string shipperName, UpdateOssShipperRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShipperName))
            {
                body["shipperName"] = request.ShipperName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetConfiguration))
            {
                body["targetConfiguration"] = request.TargetConfiguration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                body["targetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                HostMap = hostMap,
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOssShipper",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shipper/" + shipperName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateOssShipperResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public UpdateOssShipperResponse UpdateOssShipper(string project, string logstore, string shipperName, UpdateOssShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateOssShipperWithOptions(project, logstore, shipperName, request, headers, runtime);
        }

        public async Task<UpdateOssShipperResponse> UpdateOssShipperAsync(string project, string logstore, string shipperName, UpdateOssShipperRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateOssShipperWithOptionsAsync(project, logstore, shipperName, request, headers, runtime);
        }

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

        public UpdateProjectResponse UpdateProject(string project, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(project, request, headers, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(string project, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(project, request, headers, runtime);
        }

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

        public UpdateRdsExternalStoreResponse UpdateRdsExternalStore(string project, string externalStoreName, UpdateRdsExternalStoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRdsExternalStoreWithOptions(project, externalStoreName, request, headers, runtime);
        }

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

    }
}
