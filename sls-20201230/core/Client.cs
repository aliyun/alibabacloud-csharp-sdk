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
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "sls.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou", "sls.cn-hangzhou.aliyuncs.com"},
                {"cn-hongkong", "sls.cn-hongkong.aliyuncs.com"},
                {"cn-huhehaote", "sls.cn-huhehaote.aliyuncs.com"},
                {"cn-shanghai", "sls.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "sls.cn-shenzhen.aliyuncs.com"},
                {"cn-zhangjiakou", "sls.cn-zhangjiakou.aliyuncs.com"},
                {"eu-central-1", "sls.eu-central-1.aliyuncs.com"},
            };
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

        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(string project, string logstore, CreateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public CreateIndexResponse CreateIndexWithOptions(string project, string logstore, CreateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line.ToMap()))
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf.ToMap()))
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf.ToMap()))
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

        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(string project, string logstore, string consumerGroup, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            consumerGroup = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroup);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            consumerGroup = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroup);
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

        public DeleteIndexResponse DeleteIndexWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public DeleteLogStoreResponse DeleteLogStoreWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public GetContextLogsResponse GetContextLogsWithOptions(string project, string logstore, GetContextLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public GetCursorResponse GetCursorWithOptions(string project, string logstore, string shardId, GetCursorRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
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
                Action = "GetCursor",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId,
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
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
                Action = "GetCursor",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCursorResponse>(await ExecuteAsync(params_, req, runtime));
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

        public GetCursorTimeResponse GetCursorTimeWithOptions(string project, string logstore, string shardId, GetCursorTimeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
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
                Action = "GetCursorTime",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId,
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardId);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["cursor"] = request.Cursor;
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
                Action = "GetCursorTime",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCursorTimeResponse>(await ExecuteAsync(params_, req, runtime));
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

        public GetHistogramsResponse GetHistogramsWithOptions(string project, string logstore, GetHistogramsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
                Action = "GetHistograms",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
                Action = "GetHistograms",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetHistogramsResponse>(await ExecuteAsync(params_, req, runtime));
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

        public GetIndexResponse GetIndexWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public GetLogStoreResponse GetLogStoreWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public GetLogsResponse GetLogsWithOptions(string project, string logstore, GetLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
                Action = "GetLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
                Action = "GetLogs",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/index",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetLogsResponse>(await ExecuteAsync(params_, req, runtime));
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

        public GetSavedSearchResponse GetSavedSearchWithOptions(string project, string savedsearchName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            savedsearchName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savedsearchName);
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
            savedsearchName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savedsearchName);
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

        public ListConsumerGroupResponse ListConsumerGroupWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public ListProjectResponse ListProject(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectWithOptions(request, headers, runtime);
        }

        public async Task<ListProjectResponse> ListProjectAsync(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectWithOptionsAsync(request, headers, runtime);
        }

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

        public ListShardsResponse ListShardsWithOptions(string project, string logstore, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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

        public MergeShardsResponse MergeShards(string project, string logstore, string shardID, MergeShardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MergeShardsWithOptions(project, logstore, shardID, request, headers, runtime);
        }

        public async Task<MergeShardsResponse> MergeShardsAsync(string project, string logstore, string shardID, MergeShardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MergeShardsWithOptionsAsync(project, logstore, shardID, request, headers, runtime);
        }

        public MergeShardsResponse MergeShardsWithOptions(string project, string logstore, string shardID, MergeShardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardID = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardID);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MergeShards",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardID,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<MergeShardsResponse>(Execute(params_, req, runtime));
        }

        public async Task<MergeShardsResponse> MergeShardsWithOptionsAsync(string project, string logstore, string shardID, MergeShardsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardID = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardID);
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
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MergeShards",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/logstores/" + logstore + "/shards/" + shardID,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<MergeShardsResponse>(await ExecuteAsync(params_, req, runtime));
        }

        public SplitShardResponse SplitShard(string project, string logstore, string shardID, SplitShardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SplitShardWithOptions(project, logstore, shardID, request, headers, runtime);
        }

        public async Task<SplitShardResponse> SplitShardAsync(string project, string logstore, string shardID, SplitShardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SplitShardWithOptionsAsync(project, logstore, shardID, request, headers, runtime);
        }

        public SplitShardResponse SplitShardWithOptions(string project, string logstore, string shardID, SplitShardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardID = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardID);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
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
                Pathname = "/logstores/" + logstore + "/shards/" + shardID,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<SplitShardResponse>(Execute(params_, req, runtime));
        }

        public async Task<SplitShardResponse> SplitShardWithOptionsAsync(string project, string logstore, string shardID, SplitShardRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            shardID = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(shardID);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
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
                Pathname = "/logstores/" + logstore + "/shards/" + shardID,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<SplitShardResponse>(await ExecuteAsync(params_, req, runtime));
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

        public UnTagResourcesResponse UnTagResources(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnTagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<UnTagResourcesResponse> UnTagResourcesAsync(UnTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UnTagResourcesResponse UnTagResourcesWithOptions(UnTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnTagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/untag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(Execute(params_, req, runtime));
        }

        public async Task<UnTagResourcesResponse> UnTagResourcesWithOptionsAsync(UnTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "UnTagResources",
                Version = "2020-12-30",
                Protocol = "HTTPS",
                Pathname = "/untag",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnTagResourcesResponse>(await ExecuteAsync(params_, req, runtime));
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

        public UpdateConsumerGroupResponse UpdateConsumerGroupWithOptions(string project, string logstore, string consumerGroup, UpdateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            consumerGroup = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroup);
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            consumerGroup = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroup);
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

        public UpdateIndexResponse UpdateIndexWithOptions(string project, string logstore, UpdateIndexRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line.ToMap()))
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keys))
            {
                body["keys"] = request.Keys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Line.ToMap()))
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

        public UpdateLogStoreResponse UpdateLogStoreWithOptions(string project, string logstore, UpdateLogStoreRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf.ToMap()))
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
            logstore = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(logstore);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptConf.ToMap()))
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

        public UpdateSavedSearchResponse UpdateSavedSearchWithOptions(string project, string savedsearchName, UpdateSavedSearchRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> hostMap = new Dictionary<string, string>(){};
            hostMap["project"] = project;
            savedsearchName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savedsearchName);
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
            savedsearchName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(savedsearchName);
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

    }
}
