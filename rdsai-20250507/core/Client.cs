// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.RdsAi20250507.Models;

namespace AlibabaCloud.SDK.RdsAi20250507
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-wulanchabu", "rdsai.aliyuncs.com"},
                {"cn-shenzhen", "rdsai.aliyuncs.com"},
                {"cn-beijing", "rdsai.aliyuncs.com"},
                {"cn-shanghai", "rdsai.aliyuncs.com"},
                {"cn-guangzhou", "rdsai.aliyuncs.com"},
                {"cn-hangzhou", "rdsai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("rdsai", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an exclusion item to an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds a job exclusion item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public AddContextDatabaseSyncJobExclusionResponse AddContextDatabaseSyncJobExclusionWithOptions(AddContextDatabaseSyncJobExclusionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddContextDatabaseSyncJobExclusion",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContextDatabaseSyncJobExclusionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an exclusion item to an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds a job exclusion item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public async Task<AddContextDatabaseSyncJobExclusionResponse> AddContextDatabaseSyncJobExclusionWithOptionsAsync(AddContextDatabaseSyncJobExclusionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddContextDatabaseSyncJobExclusion",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContextDatabaseSyncJobExclusionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an exclusion item to an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds a job exclusion item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public AddContextDatabaseSyncJobExclusionResponse AddContextDatabaseSyncJobExclusion(AddContextDatabaseSyncJobExclusionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddContextDatabaseSyncJobExclusionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an exclusion item to an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Adds a job exclusion item.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// AddContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// 
        /// <returns>
        /// AddContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public async Task<AddContextDatabaseSyncJobExclusionResponse> AddContextDatabaseSyncJobExclusionAsync(AddContextDatabaseSyncJobExclusionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddContextDatabaseSyncJobExclusionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an in-progress discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can specify a ClientToken to ensure idempotence for write operations. If you do not specify this parameter, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncDiscoveryResponse
        /// </returns>
        public CancelContextDatabaseSyncDiscoveryResponse CancelContextDatabaseSyncDiscoveryWithOptions(CancelContextDatabaseSyncDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelContextDatabaseSyncDiscovery",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelContextDatabaseSyncDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an in-progress discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can specify a ClientToken to ensure idempotence for write operations. If you do not specify this parameter, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncDiscoveryResponse
        /// </returns>
        public async Task<CancelContextDatabaseSyncDiscoveryResponse> CancelContextDatabaseSyncDiscoveryWithOptionsAsync(CancelContextDatabaseSyncDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelContextDatabaseSyncDiscovery",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelContextDatabaseSyncDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an in-progress discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can specify a ClientToken to ensure idempotence for write operations. If you do not specify this parameter, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncDiscoveryResponse
        /// </returns>
        public CancelContextDatabaseSyncDiscoveryResponse CancelContextDatabaseSyncDiscovery(CancelContextDatabaseSyncDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelContextDatabaseSyncDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an in-progress discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can specify a ClientToken to ensure idempotence for write operations. If you do not specify this parameter, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncDiscoveryResponse
        /// </returns>
        public async Task<CancelContextDatabaseSyncDiscoveryResponse> CancelContextDatabaseSyncDiscoveryAsync(CancelContextDatabaseSyncDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelContextDatabaseSyncDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically. Cancellation is best-effort. Completed RunItems are not affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncRunResponse
        /// </returns>
        public CancelContextDatabaseSyncRunResponse CancelContextDatabaseSyncRunWithOptions(CancelContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelContextDatabaseSyncRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically. Cancellation is best-effort. Completed RunItems are not affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<CancelContextDatabaseSyncRunResponse> CancelContextDatabaseSyncRunWithOptionsAsync(CancelContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelContextDatabaseSyncRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically. Cancellation is best-effort. Completed RunItems are not affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncRunResponse
        /// </returns>
        public CancelContextDatabaseSyncRunResponse CancelContextDatabaseSyncRun(CancelContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelContextDatabaseSyncRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically. Cancellation is best-effort. Completed RunItems are not affected.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<CancelContextDatabaseSyncRunResponse> CancelContextDatabaseSyncRunAsync(CancelContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelContextDatabaseSyncRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a conversation message.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChatMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesResponse
        /// </returns>
        public ChatMessagesResponse ChatMessagesWithOptions(ChatMessagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChatMessagesShrinkRequest request = new ChatMessagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Inputs))
            {
                request.InputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Inputs, "Inputs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMode))
            {
                query["EventMode"] = request.EventMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsShrink))
            {
                query["Inputs"] = request.InputsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentMessageId))
            {
                query["ParentMessageId"] = request.ParentMessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatMessages",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMessagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a conversation message.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ChatMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesResponse
        /// </returns>
        public async Task<ChatMessagesResponse> ChatMessagesWithOptionsAsync(ChatMessagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ChatMessagesShrinkRequest request = new ChatMessagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Files))
            {
                request.FilesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Files, "Files", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Inputs))
            {
                request.InputsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Inputs, "Inputs", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMode))
            {
                query["EventMode"] = request.EventMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilesShrink))
            {
                query["Files"] = request.FilesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputsShrink))
            {
                query["Inputs"] = request.InputsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentMessageId))
            {
                query["ParentMessageId"] = request.ParentMessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatMessages",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a conversation message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesResponse
        /// </returns>
        public ChatMessagesResponse ChatMessages(ChatMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatMessagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a conversation message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesResponse
        /// </returns>
        public async Task<ChatMessagesResponse> ChatMessagesAsync(ChatMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatMessagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a conversation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatMessagesTaskStopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesTaskStopResponse
        /// </returns>
        public ChatMessagesTaskStopResponse ChatMessagesTaskStopWithOptions(ChatMessagesTaskStopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatMessagesTaskStop",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMessagesTaskStopResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a conversation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatMessagesTaskStopRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesTaskStopResponse
        /// </returns>
        public async Task<ChatMessagesTaskStopResponse> ChatMessagesTaskStopWithOptionsAsync(ChatMessagesTaskStopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChatMessagesTaskStop",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChatMessagesTaskStopResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a conversation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatMessagesTaskStopRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesTaskStopResponse
        /// </returns>
        public ChatMessagesTaskStopResponse ChatMessagesTaskStop(ChatMessagesTaskStopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChatMessagesTaskStopWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops a conversation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ChatMessagesTaskStopRequest
        /// </param>
        /// 
        /// <returns>
        /// ChatMessagesTaskStopResponse
        /// </returns>
        public async Task<ChatMessagesTaskStopResponse> ChatMessagesTaskStopAsync(ChatMessagesTaskStopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChatMessagesTaskStopWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public CreateApiKeyResponse CreateApiKeyWithOptions(CreateApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DailyTokenQuota))
            {
                query["DailyTokenQuota"] = request.DailyTokenQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyName))
            {
                query["KeyName"] = request.KeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitRate))
            {
                query["LimitRate"] = request.LimitRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitType))
            {
                query["LimitType"] = request.LimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenQuota))
            {
                query["TokenQuota"] = request.TokenQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public async Task<CreateApiKeyResponse> CreateApiKeyWithOptionsAsync(CreateApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DailyTokenQuota))
            {
                query["DailyTokenQuota"] = request.DailyTokenQuota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyName))
            {
                query["KeyName"] = request.KeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitRate))
            {
                query["LimitRate"] = request.LimitRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitType))
            {
                query["LimitType"] = request.LimitType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quantity))
            {
                query["Quantity"] = request.Quantity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TokenQuota))
            {
                query["TokenQuota"] = request.TokenQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateApiKeyResponse
        /// </returns>
        public async Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceResponse
        /// </returns>
        public CreateAppInstanceResponse CreateAppInstanceWithOptions(CreateAppInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppInstanceShrinkRequest request = new CreateAppInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DBInstanceConfig))
            {
                request.DBInstanceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DBInstanceConfig, "DBInstanceConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                query["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceConfigShrink))
            {
                query["DBInstanceConfig"] = request.DBInstanceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceName))
            {
                query["DBInstanceName"] = request.DBInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardPassword))
            {
                query["DashboardPassword"] = request.DashboardPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardUsername))
            {
                query["DashboardUsername"] = request.DashboardUsername;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePassword))
            {
                query["DatabasePassword"] = request.DatabasePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializeWithExistingData))
            {
                query["InitializeWithExistingData"] = request.InitializeWithExistingData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                query["PublicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicNetworkAccessEnabled))
            {
                query["PublicNetworkAccessEnabled"] = request.PublicNetworkAccessEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RAGEnabled))
            {
                query["RAGEnabled"] = request.RAGEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceResponse
        /// </returns>
        public async Task<CreateAppInstanceResponse> CreateAppInstanceWithOptionsAsync(CreateAppInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAppInstanceShrinkRequest request = new CreateAppInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DBInstanceConfig))
            {
                request.DBInstanceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DBInstanceConfig, "DBInstanceConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                query["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceConfigShrink))
            {
                query["DBInstanceConfig"] = request.DBInstanceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceName))
            {
                query["DBInstanceName"] = request.DBInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardPassword))
            {
                query["DashboardPassword"] = request.DashboardPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardUsername))
            {
                query["DashboardUsername"] = request.DashboardUsername;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Database))
            {
                query["Database"] = request.Database;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePassword))
            {
                query["DatabasePassword"] = request.DatabasePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitializeWithExistingData))
            {
                query["InitializeWithExistingData"] = request.InitializeWithExistingData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicEndpointEnabled))
            {
                query["PublicEndpointEnabled"] = request.PublicEndpointEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicNetworkAccessEnabled))
            {
                query["PublicNetworkAccessEnabled"] = request.PublicNetworkAccessEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RAGEnabled))
            {
                query["RAGEnabled"] = request.RAGEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAppInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAppInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceResponse
        /// </returns>
        public CreateAppInstanceResponse CreateAppInstance(CreateAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAppInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAppInstanceResponse
        /// </returns>
        public async Task<CreateAppInstanceResponse> CreateAppInstanceAsync(CreateAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAppInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a context database API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an API key and returns the plaintext apiKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseApiKeyResponse
        /// </returns>
        public CreateContextDatabaseApiKeyResponse CreateContextDatabaseApiKeyWithOptions(CreateContextDatabaseApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a context database API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an API key and returns the plaintext apiKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseApiKeyResponse
        /// </returns>
        public async Task<CreateContextDatabaseApiKeyResponse> CreateContextDatabaseApiKeyWithOptionsAsync(CreateContextDatabaseApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a context database API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an API key and returns the plaintext apiKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseApiKeyResponse
        /// </returns>
        public CreateContextDatabaseApiKeyResponse CreateContextDatabaseApiKey(CreateContextDatabaseApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContextDatabaseApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a context database API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an API key and returns the plaintext apiKey.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseApiKeyResponse
        /// </returns>
        public async Task<CreateContextDatabaseApiKeyResponse> CreateContextDatabaseApiKeyAsync(CreateContextDatabaseApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContextDatabaseApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a ContextDB member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a member. If GenerateInitialKey is set to true, the first API key is also issued, and the plaintext ApiKey is returned in the response. This is a sensitive field and is returned only once. Store it securely. After the member is created, you can call the List or Get operation to query the member and the metadata of the API keys under the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseMemberResponse
        /// </returns>
        public CreateContextDatabaseMemberResponse CreateContextDatabaseMemberWithOptions(CreateContextDatabaseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateInitialKey))
            {
                query["GenerateInitialKey"] = request.GenerateInitialKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialKeyName))
            {
                query["InitialKeyName"] = request.InitialKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseMember",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a ContextDB member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a member. If GenerateInitialKey is set to true, the first API key is also issued, and the plaintext ApiKey is returned in the response. This is a sensitive field and is returned only once. Store it securely. After the member is created, you can call the List or Get operation to query the member and the metadata of the API keys under the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseMemberResponse
        /// </returns>
        public async Task<CreateContextDatabaseMemberResponse> CreateContextDatabaseMemberWithOptionsAsync(CreateContextDatabaseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateInitialKey))
            {
                query["GenerateInitialKey"] = request.GenerateInitialKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitialKeyName))
            {
                query["InitialKeyName"] = request.InitialKeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseMember",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a ContextDB member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a member. If GenerateInitialKey is set to true, the first API key is also issued, and the plaintext ApiKey is returned in the response. This is a sensitive field and is returned only once. Store it securely. After the member is created, you can call the List or Get operation to query the member and the metadata of the API keys under the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseMemberResponse
        /// </returns>
        public CreateContextDatabaseMemberResponse CreateContextDatabaseMember(CreateContextDatabaseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContextDatabaseMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a ContextDB member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a member. If GenerateInitialKey is set to true, the first API key is also issued, and the plaintext ApiKey is returned in the response. This is a sensitive field and is returned only once. Store it securely. After the member is created, you can call the List or Get operation to query the member and the metadata of the API keys under the member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseMemberResponse
        /// </returns>
        public async Task<CreateContextDatabaseMemberResponse> CreateContextDatabaseMemberAsync(CreateContextDatabaseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContextDatabaseMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a synchronization connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If no ClientToken is provided, the backend automatically generates one. Upon successful creation, the complete information of the created object is returned, including the ID that can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncConnectionResponse
        /// </returns>
        public CreateContextDatabaseSyncConnectionResponse CreateContextDatabaseSyncConnectionWithOptions(CreateContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKind))
            {
                query["AuthKind"] = request.AuthKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["PluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseSyncConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a synchronization connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If no ClientToken is provided, the backend automatically generates one. Upon successful creation, the complete information of the created object is returned, including the ID that can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<CreateContextDatabaseSyncConnectionResponse> CreateContextDatabaseSyncConnectionWithOptionsAsync(CreateContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthKind))
            {
                query["AuthKind"] = request.AuthKind;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["PluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseSyncConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a synchronization connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If no ClientToken is provided, the backend automatically generates one. Upon successful creation, the complete information of the created object is returned, including the ID that can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncConnectionResponse
        /// </returns>
        public CreateContextDatabaseSyncConnectionResponse CreateContextDatabaseSyncConnection(CreateContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContextDatabaseSyncConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a synchronization connection.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If no ClientToken is provided, the backend automatically generates one. Upon successful creation, the complete information of the created object is returned, including the ID that can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<CreateContextDatabaseSyncConnectionResponse> CreateContextDatabaseSyncConnectionAsync(CreateContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContextDatabaseSyncConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically. Target is an implicit concept — you only need to provide KnowledgeBaseId, and the backend automatically creates or matches the Target.
        /// On success, the response returns the complete information of the created object. The Id field is active and can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncJobResponse
        /// </returns>
        public CreateContextDatabaseSyncJobResponse CreateContextDatabaseSyncJobWithOptions(CreateContextDatabaseSyncJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateContextDatabaseSyncJobShrinkRequest request = new CreateContextDatabaseSyncJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filters))
            {
                request.FiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filters, "Filters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiltersShrink))
            {
                query["Filters"] = request.FiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseId))
            {
                query["TargetKnowledgeBaseId"] = request.TargetKnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseName))
            {
                query["TargetKnowledgeBaseName"] = request.TargetKnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseSyncJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically. Target is an implicit concept — you only need to provide KnowledgeBaseId, and the backend automatically creates or matches the Target.
        /// On success, the response returns the complete information of the created object. The Id field is active and can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<CreateContextDatabaseSyncJobResponse> CreateContextDatabaseSyncJobWithOptionsAsync(CreateContextDatabaseSyncJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateContextDatabaseSyncJobShrinkRequest request = new CreateContextDatabaseSyncJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filters))
            {
                request.FiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filters, "Filters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiltersShrink))
            {
                query["Filters"] = request.FiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseId))
            {
                query["TargetKnowledgeBaseId"] = request.TargetKnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseName))
            {
                query["TargetKnowledgeBaseName"] = request.TargetKnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseSyncJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically. Target is an implicit concept — you only need to provide KnowledgeBaseId, and the backend automatically creates or matches the Target.
        /// On success, the response returns the complete information of the created object. The Id field is active and can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncJobResponse
        /// </returns>
        public CreateContextDatabaseSyncJobResponse CreateContextDatabaseSyncJob(CreateContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContextDatabaseSyncJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically. Target is an implicit concept — you only need to provide KnowledgeBaseId, and the backend automatically creates or matches the Target.
        /// On success, the response returns the complete information of the created object. The Id field is active and can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<CreateContextDatabaseSyncJobResponse> CreateContextDatabaseSyncJobAsync(CreateContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContextDatabaseSyncJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no token is provided, the backend generates one automatically. After creating a data selection scope, you typically need to call StartContextDatabaseSyncSourceDiscovery to discover available nodes.
        /// On success, the response returns the complete information of the created object. The Id field can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncSourceResponse
        /// </returns>
        public CreateContextDatabaseSyncSourceResponse CreateContextDatabaseSyncSourceWithOptions(CreateContextDatabaseSyncSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateContextDatabaseSyncSourceShrinkRequest request = new CreateContextDatabaseSyncSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceConfig))
            {
                request.SourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceConfig, "SourceConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceConfigShrink))
            {
                query["SourceConfig"] = request.SourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseSyncSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no token is provided, the backend generates one automatically. After creating a data selection scope, you typically need to call StartContextDatabaseSyncSourceDiscovery to discover available nodes.
        /// On success, the response returns the complete information of the created object. The Id field can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<CreateContextDatabaseSyncSourceResponse> CreateContextDatabaseSyncSourceWithOptionsAsync(CreateContextDatabaseSyncSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateContextDatabaseSyncSourceShrinkRequest request = new CreateContextDatabaseSyncSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceConfig))
            {
                request.SourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceConfig, "SourceConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceConfigShrink))
            {
                query["SourceConfig"] = request.SourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseSyncSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no token is provided, the backend generates one automatically. After creating a data selection scope, you typically need to call StartContextDatabaseSyncSourceDiscovery to discover available nodes.
        /// On success, the response returns the complete information of the created object. The Id field can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncSourceResponse
        /// </returns>
        public CreateContextDatabaseSyncSourceResponse CreateContextDatabaseSyncSource(CreateContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContextDatabaseSyncSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no token is provided, the backend generates one automatically. After creating a data selection scope, you typically need to call StartContextDatabaseSyncSourceDiscovery to discover available nodes.
        /// On success, the response returns the complete information of the created object. The Id field can be used for subsequent queries or updates.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<CreateContextDatabaseSyncSourceResponse> CreateContextDatabaseSyncSourceAsync(CreateContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContextDatabaseSyncSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace, the first member, and the first API key in a one-time onboarding process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace along with the first member and the first API key in a one-time onboarding process. The plaintext API key is returned in the response.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseWorkspaceResponse
        /// </returns>
        public CreateContextDatabaseWorkspaceResponse CreateContextDatabaseWorkspaceWithOptions(CreateContextDatabaseWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseWorkspace",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace, the first member, and the first API key in a one-time onboarding process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace along with the first member and the first API key in a one-time onboarding process. The plaintext API key is returned in the response.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseWorkspaceResponse
        /// </returns>
        public async Task<CreateContextDatabaseWorkspaceResponse> CreateContextDatabaseWorkspaceWithOptionsAsync(CreateContextDatabaseWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberName))
            {
                query["MemberName"] = request.MemberName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContextDatabaseWorkspace",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContextDatabaseWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace, the first member, and the first API key in a one-time onboarding process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace along with the first member and the first API key in a one-time onboarding process. The plaintext API key is returned in the response.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseWorkspaceResponse
        /// </returns>
        public CreateContextDatabaseWorkspaceResponse CreateContextDatabaseWorkspace(CreateContextDatabaseWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContextDatabaseWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a workspace, the first member, and the first API key in a one-time onboarding process.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a workspace along with the first member and the first API key in a one-time onboarding process. The plaintext API key is returned in the response.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContextDatabaseWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContextDatabaseWorkspaceResponse
        /// </returns>
        public async Task<CreateContextDatabaseWorkspaceResponse> CreateContextDatabaseWorkspaceAsync(CreateContextDatabaseWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContextDatabaseWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-specific agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public CreateCustomAgentResponse CreateCustomAgentWithOptions(CreateCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomAgentShrinkRequest request = new CreateCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SkillIds))
            {
                request.SkillIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SkillIds, "SkillIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tools))
            {
                request.ToolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tools, "Tools", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTools))
            {
                query["EnableTools"] = request.EnableTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIdsShrink))
            {
                query["SkillIds"] = request.SkillIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                query["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolsShrink))
            {
                query["Tools"] = request.ToolsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-specific agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public async Task<CreateCustomAgentResponse> CreateCustomAgentWithOptionsAsync(CreateCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCustomAgentShrinkRequest request = new CreateCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SkillIds))
            {
                request.SkillIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SkillIds, "SkillIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tools))
            {
                request.ToolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tools, "Tools", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTools))
            {
                query["EnableTools"] = request.EnableTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIdsShrink))
            {
                query["SkillIds"] = request.SkillIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                query["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolsShrink))
            {
                query["Tools"] = request.ToolsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-specific agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public CreateCustomAgentResponse CreateCustomAgent(CreateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-specific agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateCustomAgentResponse
        /// </returns>
        public async Task<CreateCustomAgentResponse> CreateCustomAgentAsync(CreateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch instance inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInspectionTaskResponse
        /// </returns>
        public CreateInspectionTaskResponse CreateInspectionTaskWithOptions(CreateInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionItems))
            {
                query["InspectionItems"] = request.InspectionItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportLanguage))
            {
                query["ReportLanguage"] = request.ReportLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportRegionId))
            {
                query["ReportRegionId"] = request.ReportRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInspectionTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInspectionTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch instance inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInspectionTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInspectionTaskResponse
        /// </returns>
        public async Task<CreateInspectionTaskResponse> CreateInspectionTaskWithOptionsAsync(CreateInspectionTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionItems))
            {
                query["InspectionItems"] = request.InspectionItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportLanguage))
            {
                query["ReportLanguage"] = request.ReportLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportRegionId))
            {
                query["ReportRegionId"] = request.ReportRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInspectionTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInspectionTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch instance inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInspectionTaskResponse
        /// </returns>
        public CreateInspectionTaskResponse CreateInspectionTask(CreateInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInspectionTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a batch instance inspection task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInspectionTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInspectionTaskResponse
        /// </returns>
        public async Task<CreateInspectionTaskResponse> CreateInspectionTaskAsync(CreateInspectionTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInspectionTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an asynchronous export task for MO usage details in CSV format.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMOUsageDetailExportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMOUsageDetailExportResponse
        /// </returns>
        public CreateMOUsageDetailExportResponse CreateMOUsageDetailExportWithOptions(CreateMOUsageDetailExportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMOUsageDetailExport",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMOUsageDetailExportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an asynchronous export task for MO usage details in CSV format.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMOUsageDetailExportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMOUsageDetailExportResponse
        /// </returns>
        public async Task<CreateMOUsageDetailExportResponse> CreateMOUsageDetailExportWithOptionsAsync(CreateMOUsageDetailExportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMOUsageDetailExport",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMOUsageDetailExportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an asynchronous export task for MO usage details in CSV format.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMOUsageDetailExportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMOUsageDetailExportResponse
        /// </returns>
        public CreateMOUsageDetailExportResponse CreateMOUsageDetailExport(CreateMOUsageDetailExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMOUsageDetailExportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Triggers an asynchronous export task for MO usage details in CSV format.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateMOUsageDetailExportRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMOUsageDetailExportResponse
        /// </returns>
        public async Task<CreateMOUsageDetailExportResponse> CreateMOUsageDetailExportAsync(CreateMOUsageDetailExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMOUsageDetailExportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSandboxTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxTemplateResponse
        /// </returns>
        public CreateSandboxTemplateResponse CreateSandboxTemplateWithOptions(CreateSandboxTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSandboxTemplateShrinkRequest request = new CreateSandboxTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCpu))
            {
                query["DefaultCpu"] = request.DefaultCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMemory))
            {
                query["DefaultMemory"] = request.DefaultMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSandboxTemplate",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSandboxTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateSandboxTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxTemplateResponse
        /// </returns>
        public async Task<CreateSandboxTemplateResponse> CreateSandboxTemplateWithOptionsAsync(CreateSandboxTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSandboxTemplateShrinkRequest request = new CreateSandboxTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCpu))
            {
                query["DefaultCpu"] = request.DefaultCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMemory))
            {
                query["DefaultMemory"] = request.DefaultMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSandboxTemplate",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSandboxTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSandboxTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxTemplateResponse
        /// </returns>
        public CreateSandboxTemplateResponse CreateSandboxTemplate(CreateSandboxTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSandboxTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSandboxTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSandboxTemplateResponse
        /// </returns>
        public async Task<CreateSandboxTemplateResponse> CreateSandboxTemplateAsync(CreateSandboxTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSandboxTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a scheduled inspection configuration for batch instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScheduledTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public CreateScheduledTaskResponse CreateScheduledTaskWithOptions(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                query["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionItems))
            {
                query["InspectionItems"] = request.InspectionItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportLanguage))
            {
                query["ReportLanguage"] = request.ReportLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportRegionId))
            {
                query["ReportRegionId"] = request.ReportRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a scheduled inspection configuration for batch instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScheduledTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskWithOptionsAsync(CreateScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                query["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionItems))
            {
                query["InspectionItems"] = request.InspectionItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportLanguage))
            {
                query["ReportLanguage"] = request.ReportLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportRegionId))
            {
                query["ReportRegionId"] = request.ReportRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a scheduled inspection configuration for batch instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public CreateScheduledTaskResponse CreateScheduledTask(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a scheduled inspection configuration for batch instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateScheduledTaskResponse
        /// </returns>
        public async Task<CreateScheduledTaskResponse> CreateScheduledTaskAsync(CreateScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-defined skill.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public CreateSkillResponse CreateSkillWithOptions(CreateSkillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSkillShrinkRequest request = new CreateSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dbtypes))
            {
                request.DbtypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dbtypes, "Dbtypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbtypesShrink))
            {
                query["Dbtypes"] = request.DbtypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateNote))
            {
                query["UpdateNote"] = request.UpdateNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["UploadId"] = request.UploadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadToken))
            {
                query["UploadToken"] = request.UploadToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-defined skill.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public async Task<CreateSkillResponse> CreateSkillWithOptionsAsync(CreateSkillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateSkillShrinkRequest request = new CreateSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dbtypes))
            {
                request.DbtypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dbtypes, "Dbtypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbtypesShrink))
            {
                query["Dbtypes"] = request.DbtypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateNote))
            {
                query["UpdateNote"] = request.UpdateNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["UploadId"] = request.UploadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadToken))
            {
                query["UploadToken"] = request.UploadToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-defined skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public CreateSkillResponse CreateSkill(CreateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a user-defined skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillResponse
        /// </returns>
        public async Task<CreateSkillResponse> CreateSkillAsync(CreateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public DeleteApiKeyResponse DeleteApiKeyWithOptions(DeleteApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public async Task<DeleteApiKeyResponse> DeleteApiKeyWithOptionsAsync(DeleteApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteApiKeyResponse
        /// </returns>
        public async Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable DPI engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a>
        /// Notice: Deleting an RDS Supabase project does not automatically delete the ApsaraDB RDS for PostgreSQL instance or the Internet NAT gateway that were created along with the project. You must <a href="https://help.aliyun.com/document_detail/96749.html">manual release the instance</a> and delete the <a href="https://help.aliyun.com/document_detail/121139.html">Internet NAT gateway</a> and <a href="https://help.aliyun.com/document_detail/121527.html">EIP</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceResponse
        /// </returns>
        public DeleteAppInstanceResponse DeleteAppInstanceWithOptions(DeleteAppInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteDBInstance))
            {
                query["DeleteDBInstance"] = request.DeleteDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable DPI engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a>
        /// Notice: Deleting an RDS Supabase project does not automatically delete the ApsaraDB RDS for PostgreSQL instance or the Internet NAT gateway that were created along with the project. You must <a href="https://help.aliyun.com/document_detail/96749.html">manual release the instance</a> and delete the <a href="https://help.aliyun.com/document_detail/121139.html">Internet NAT gateway</a> and <a href="https://help.aliyun.com/document_detail/121527.html">EIP</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceResponse
        /// </returns>
        public async Task<DeleteAppInstanceResponse> DeleteAppInstanceWithOptionsAsync(DeleteAppInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteDBInstance))
            {
                query["DeleteDBInstance"] = request.DeleteDBInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAppInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAppInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable DPI engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a>
        /// Notice: Deleting an RDS Supabase project does not automatically delete the ApsaraDB RDS for PostgreSQL instance or the Internet NAT gateway that were created along with the project. You must <a href="https://help.aliyun.com/document_detail/96749.html">manual release the instance</a> and delete the <a href="https://help.aliyun.com/document_detail/121139.html">Internet NAT gateway</a> and <a href="https://help.aliyun.com/document_detail/121527.html">EIP</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceResponse
        /// </returns>
        public DeleteAppInstanceResponse DeleteAppInstance(DeleteAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAppInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable DPI engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <remarks>
        /// <para>Warning: This API operation incurs fees. Read the related feature documentation carefully before you perform this operation.
        /// <a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a>
        /// Notice: Deleting an RDS Supabase project does not automatically delete the ApsaraDB RDS for PostgreSQL instance or the Internet NAT gateway that were created along with the project. You must <a href="https://help.aliyun.com/document_detail/96749.html">manual release the instance</a> and delete the <a href="https://help.aliyun.com/document_detail/121139.html">Internet NAT gateway</a> and <a href="https://help.aliyun.com/document_detail/121527.html">EIP</a>.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAppInstanceResponse
        /// </returns>
        public async Task<DeleteAppInstanceResponse> DeleteAppInstanceAsync(DeleteAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAppInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a member. This is a hard delete and cannot be undone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseMemberResponse
        /// </returns>
        public DeleteContextDatabaseMemberResponse DeleteContextDatabaseMemberWithOptions(DeleteContextDatabaseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseMember",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a member. This is a hard delete and cannot be undone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseMemberResponse
        /// </returns>
        public async Task<DeleteContextDatabaseMemberResponse> DeleteContextDatabaseMemberWithOptionsAsync(DeleteContextDatabaseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseMember",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a member. This is a hard delete and cannot be undone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseMemberResponse
        /// </returns>
        public DeleteContextDatabaseMemberResponse DeleteContextDatabaseMember(DeleteContextDatabaseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContextDatabaseMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a member. This is a hard delete and cannot be undone.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseMemberResponse
        /// </returns>
        public async Task<DeleteContextDatabaseMemberResponse> DeleteContextDatabaseMemberAsync(DeleteContextDatabaseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContextDatabaseMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If you do not specify a ClientToken, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncConnectionResponse
        /// </returns>
        public DeleteContextDatabaseSyncConnectionResponse DeleteContextDatabaseSyncConnectionWithOptions(DeleteContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseSyncConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If you do not specify a ClientToken, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<DeleteContextDatabaseSyncConnectionResponse> DeleteContextDatabaseSyncConnectionWithOptionsAsync(DeleteContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseSyncConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If you do not specify a ClientToken, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncConnectionResponse
        /// </returns>
        public DeleteContextDatabaseSyncConnectionResponse DeleteContextDatabaseSyncConnection(DeleteContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContextDatabaseSyncConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can specify a ClientToken to ensure idempotency. If you do not specify a ClientToken, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<DeleteContextDatabaseSyncConnectionResponse> DeleteContextDatabaseSyncConnectionAsync(DeleteContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContextDatabaseSyncConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can provide a ClientToken to ensure idempotency for write operations. If not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncJobResponse
        /// </returns>
        public DeleteContextDatabaseSyncJobResponse DeleteContextDatabaseSyncJobWithOptions(DeleteContextDatabaseSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseSyncJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can provide a ClientToken to ensure idempotency for write operations. If not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<DeleteContextDatabaseSyncJobResponse> DeleteContextDatabaseSyncJobWithOptionsAsync(DeleteContextDatabaseSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseSyncJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can provide a ClientToken to ensure idempotency for write operations. If not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncJobResponse
        /// </returns>
        public DeleteContextDatabaseSyncJobResponse DeleteContextDatabaseSyncJob(DeleteContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContextDatabaseSyncJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can provide a ClientToken to ensure idempotency for write operations. If not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<DeleteContextDatabaseSyncJobResponse> DeleteContextDatabaseSyncJobAsync(DeleteContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContextDatabaseSyncJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncSourceResponse
        /// </returns>
        public DeleteContextDatabaseSyncSourceResponse DeleteContextDatabaseSyncSourceWithOptions(DeleteContextDatabaseSyncSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseSyncSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<DeleteContextDatabaseSyncSourceResponse> DeleteContextDatabaseSyncSourceWithOptionsAsync(DeleteContextDatabaseSyncSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseSyncSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncSourceResponse
        /// </returns>
        public DeleteContextDatabaseSyncSourceResponse DeleteContextDatabaseSyncSource(DeleteContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContextDatabaseSyncSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence through ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<DeleteContextDatabaseSyncSourceResponse> DeleteContextDatabaseSyncSourceAsync(DeleteContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContextDatabaseSyncSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a workspace. This is a hard delete and cannot be recovered. After the workspace is deleted, the local metadata is soft-deleted synchronously. Deleted workspaces no longer count toward the quota.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseWorkspaceResponse
        /// </returns>
        public DeleteContextDatabaseWorkspaceResponse DeleteContextDatabaseWorkspaceWithOptions(DeleteContextDatabaseWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseWorkspace",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a workspace. This is a hard delete and cannot be recovered. After the workspace is deleted, the local metadata is soft-deleted synchronously. Deleted workspaces no longer count toward the quota.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseWorkspaceResponse
        /// </returns>
        public async Task<DeleteContextDatabaseWorkspaceResponse> DeleteContextDatabaseWorkspaceWithOptionsAsync(DeleteContextDatabaseWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContextDatabaseWorkspace",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContextDatabaseWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a workspace. This is a hard delete and cannot be recovered. After the workspace is deleted, the local metadata is soft-deleted synchronously. Deleted workspaces no longer count toward the quota.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseWorkspaceResponse
        /// </returns>
        public DeleteContextDatabaseWorkspaceResponse DeleteContextDatabaseWorkspace(DeleteContextDatabaseWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContextDatabaseWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a workspace. This is a hard delete and cannot be recovered. After the workspace is deleted, the local metadata is soft-deleted synchronously. Deleted workspaces no longer count toward the quota.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContextDatabaseWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContextDatabaseWorkspaceResponse
        /// </returns>
        public async Task<DeleteContextDatabaseWorkspaceResponse> DeleteContextDatabaseWorkspaceAsync(DeleteContextDatabaseWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContextDatabaseWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public DeleteCustomAgentResponse DeleteCustomAgentWithOptions(DeleteCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public async Task<DeleteCustomAgentResponse> DeleteCustomAgentWithOptionsAsync(DeleteCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public DeleteCustomAgentResponse DeleteCustomAgent(DeleteCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteCustomAgentResponse
        /// </returns>
        public async Task<DeleteCustomAgentResponse> DeleteCustomAgentAsync(DeleteCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxTemplateResponse
        /// </returns>
        public DeleteSandboxTemplateResponse DeleteSandboxTemplateWithOptions(DeleteSandboxTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSandboxTemplate",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxTemplateResponse
        /// </returns>
        public async Task<DeleteSandboxTemplateResponse> DeleteSandboxTemplateWithOptionsAsync(DeleteSandboxTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSandboxTemplate",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSandboxTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxTemplateResponse
        /// </returns>
        public DeleteSandboxTemplateResponse DeleteSandboxTemplate(DeleteSandboxTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSandboxTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSandboxTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSandboxTemplateResponse
        /// </returns>
        public async Task<DeleteSandboxTemplateResponse> DeleteSandboxTemplateAsync(DeleteSandboxTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSandboxTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledTaskResponse
        /// </returns>
        public DeleteScheduledTaskResponse DeleteScheduledTaskWithOptions(DeleteScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledTaskResponse
        /// </returns>
        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskWithOptionsAsync(DeleteScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledTaskResponse
        /// </returns>
        public DeleteScheduledTaskResponse DeleteScheduledTask(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScheduledTaskResponse
        /// </returns>
        public async Task<DeleteScheduledTaskResponse> DeleteScheduledTaskAsync(DeleteScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkillWithOptions(DeleteSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillWithOptionsAsync(DeleteSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public DeleteSkillResponse DeleteSkill(DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSkillResponse
        /// </returns>
        public async Task<DeleteSkillResponse> DeleteSkillAsync(DeleteSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstanceAttributeResponse
        /// </returns>
        public DescribeAppInstanceAttributeResponse DescribeAppInstanceAttributeWithOptions(DescribeAppInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppInstanceAttribute",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppInstanceAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstanceAttributeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstanceAttributeResponse
        /// </returns>
        public async Task<DescribeAppInstanceAttributeResponse> DescribeAppInstanceAttributeWithOptionsAsync(DescribeAppInstanceAttributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppInstanceAttribute",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppInstanceAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstanceAttributeResponse
        /// </returns>
        public DescribeAppInstanceAttributeResponse DescribeAppInstanceAttribute(DescribeAppInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppInstanceAttributeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstanceAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstanceAttributeResponse
        /// </returns>
        public async Task<DescribeAppInstanceAttributeResponse> DescribeAppInstanceAttributeAsync(DescribeAppInstanceAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppInstanceAttributeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstancesResponse
        /// </returns>
        public DescribeAppInstancesResponse DescribeAppInstancesWithOptions(DescribeAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceName))
            {
                query["DBInstanceName"] = request.DBInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppInstances",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstancesResponse
        /// </returns>
        public async Task<DescribeAppInstancesResponse> DescribeAppInstancesWithOptionsAsync(DescribeAppInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppType))
            {
                query["AppType"] = request.AppType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceName))
            {
                query["DBInstanceName"] = request.DBInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAppInstances",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAppInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstancesResponse
        /// </returns>
        public DescribeAppInstancesResponse DescribeAppInstances(DescribeAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAppInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAppInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAppInstancesResponse
        /// </returns>
        public async Task<DescribeAppInstancesResponse> DescribeAppInstancesAsync(DescribeAppInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAppInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported sandbox templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCommonSandboxTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommonSandboxTemplatesResponse
        /// </returns>
        public DescribeCommonSandboxTemplatesResponse DescribeCommonSandboxTemplatesWithOptions(DescribeCommonSandboxTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommonSandboxTemplates",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCommonSandboxTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported sandbox templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCommonSandboxTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommonSandboxTemplatesResponse
        /// </returns>
        public async Task<DescribeCommonSandboxTemplatesResponse> DescribeCommonSandboxTemplatesWithOptionsAsync(DescribeCommonSandboxTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommonSandboxTemplates",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCommonSandboxTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported sandbox templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCommonSandboxTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommonSandboxTemplatesResponse
        /// </returns>
        public DescribeCommonSandboxTemplatesResponse DescribeCommonSandboxTemplates(DescribeCommonSandboxTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommonSandboxTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of supported sandbox templates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCommonSandboxTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommonSandboxTemplatesResponse
        /// </returns>
        public async Task<DescribeCommonSandboxTemplatesResponse> DescribeCommonSandboxTemplatesAsync(DescribeCommonSandboxTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommonSandboxTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsListResponse
        /// </returns>
        public DescribeEventsListResponse DescribeEventsListWithOptions(DescribeEventsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventsList",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsListResponse
        /// </returns>
        public async Task<DescribeEventsListResponse> DescribeEventsListWithOptionsAsync(DescribeEventsListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                query["InstanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEventsList",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsListResponse
        /// </returns>
        public DescribeEventsListResponse DescribeEventsList(DescribeEventsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEventsListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeEventsListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeEventsListResponse
        /// </returns>
        public async Task<DescribeEventsListResponse> DescribeEventsListAsync(DescribeEventsListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEventsListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authentication information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAuthInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAuthInfoResponse
        /// </returns>
        public DescribeInstanceAuthInfoResponse DescribeInstanceAuthInfoWithOptions(DescribeInstanceAuthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAuthInfo",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAuthInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authentication information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAuthInfoRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAuthInfoResponse
        /// </returns>
        public async Task<DescribeInstanceAuthInfoResponse> DescribeInstanceAuthInfoWithOptionsAsync(DescribeInstanceAuthInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceAuthInfo",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceAuthInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authentication information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAuthInfoResponse
        /// </returns>
        public DescribeInstanceAuthInfoResponse DescribeInstanceAuthInfo(DescribeInstanceAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceAuthInfoWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authentication information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceAuthInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceAuthInfoResponse
        /// </returns>
        public async Task<DescribeInstanceAuthInfoResponse> DescribeInstanceAuthInfoAsync(DescribeInstanceAuthInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceAuthInfoWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceEndpointsResponse
        /// </returns>
        public DescribeInstanceEndpointsResponse DescribeInstanceEndpointsWithOptions(DescribeInstanceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceEndpoints",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceEndpointsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceEndpointsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceEndpointsResponse
        /// </returns>
        public async Task<DescribeInstanceEndpointsResponse> DescribeInstanceEndpointsWithOptionsAsync(DescribeInstanceEndpointsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceEndpoints",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceEndpointsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceEndpointsResponse
        /// </returns>
        public DescribeInstanceEndpointsResponse DescribeInstanceEndpoints(DescribeInstanceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceEndpointsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the endpoint information of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceEndpointsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceEndpointsResponse
        /// </returns>
        public async Task<DescribeInstanceEndpointsResponse> DescribeInstanceEndpointsAsync(DescribeInstanceEndpointsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceEndpointsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpWhitelistResponse
        /// </returns>
        public DescribeInstanceIpWhitelistResponse DescribeInstanceIpWhitelistWithOptions(DescribeInstanceIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceIpWhitelist",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpWhitelistResponse
        /// </returns>
        public async Task<DescribeInstanceIpWhitelistResponse> DescribeInstanceIpWhitelistWithOptionsAsync(DescribeInstanceIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceIpWhitelist",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpWhitelistResponse
        /// </returns>
        public DescribeInstanceIpWhitelistResponse DescribeInstanceIpWhitelist(DescribeInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceIpWhitelistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpWhitelistResponse
        /// </returns>
        public async Task<DescribeInstanceIpWhitelistResponse> DescribeInstanceIpWhitelistAsync(DescribeInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceIpWhitelistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRAGConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRAGConfigResponse
        /// </returns>
        public DescribeInstanceRAGConfigResponse DescribeInstanceRAGConfigWithOptions(DescribeInstanceRAGConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceRAGConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceRAGConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRAGConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRAGConfigResponse
        /// </returns>
        public async Task<DescribeInstanceRAGConfigResponse> DescribeInstanceRAGConfigWithOptionsAsync(DescribeInstanceRAGConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceRAGConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceRAGConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRAGConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRAGConfigResponse
        /// </returns>
        public DescribeInstanceRAGConfigResponse DescribeInstanceRAGConfig(DescribeInstanceRAGConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceRAGConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceRAGConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceRAGConfigResponse
        /// </returns>
        public async Task<DescribeInstanceRAGConfigResponse> DescribeInstanceRAGConfigAsync(DescribeInstanceRAGConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceRAGConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceSSLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSSLResponse
        /// </returns>
        public DescribeInstanceSSLResponse DescribeInstanceSSLWithOptions(DescribeInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSSL",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceSSLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSSLResponse
        /// </returns>
        public async Task<DescribeInstanceSSLResponse> DescribeInstanceSSLWithOptionsAsync(DescribeInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceSSL",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceSSLRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSSLResponse
        /// </returns>
        public DescribeInstanceSSLResponse DescribeInstanceSSL(DescribeInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceSSLWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceSSLRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceSSLResponse
        /// </returns>
        public async Task<DescribeInstanceSSLResponse> DescribeInstanceSSLAsync(DescribeInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceSSLWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceStorageConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStorageConfigResponse
        /// </returns>
        public DescribeInstanceStorageConfigResponse DescribeInstanceStorageConfigWithOptions(DescribeInstanceStorageConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceStorageConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceStorageConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceStorageConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStorageConfigResponse
        /// </returns>
        public async Task<DescribeInstanceStorageConfigResponse> DescribeInstanceStorageConfigWithOptionsAsync(DescribeInstanceStorageConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceStorageConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceStorageConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceStorageConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStorageConfigResponse
        /// </returns>
        public DescribeInstanceStorageConfigResponse DescribeInstanceStorageConfig(DescribeInstanceStorageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceStorageConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceStorageConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceStorageConfigResponse
        /// </returns>
        public async Task<DescribeInstanceStorageConfigResponse> DescribeInstanceStorageConfigAsync(DescribeInstanceStorageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceStorageConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage records of RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageDetailResponse
        /// </returns>
        public DescribeMOTokenUsageDetailResponse DescribeMOTokenUsageDetailWithOptions(DescribeMOTokenUsageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerName))
            {
                query["ConsumerName"] = request.ConsumerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMOTokenUsageDetail",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMOTokenUsageDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage records of RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageDetailResponse
        /// </returns>
        public async Task<DescribeMOTokenUsageDetailResponse> DescribeMOTokenUsageDetailWithOptionsAsync(DescribeMOTokenUsageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerName))
            {
                query["ConsumerName"] = request.ConsumerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cursor))
            {
                query["Cursor"] = request.Cursor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMOTokenUsageDetail",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMOTokenUsageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage records of RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageDetailResponse
        /// </returns>
        public DescribeMOTokenUsageDetailResponse DescribeMOTokenUsageDetail(DescribeMOTokenUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMOTokenUsageDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage records of RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageDetailResponse
        /// </returns>
        public async Task<DescribeMOTokenUsageDetailResponse> DescribeMOTokenUsageDetailAsync(DescribeMOTokenUsageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMOTokenUsageDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage summary for a model operator instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageSummaryResponse
        /// </returns>
        public DescribeMOTokenUsageSummaryResponse DescribeMOTokenUsageSummaryWithOptions(DescribeMOTokenUsageSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMOTokenUsageSummary",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMOTokenUsageSummaryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage summary for a model operator instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageSummaryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageSummaryResponse
        /// </returns>
        public async Task<DescribeMOTokenUsageSummaryResponse> DescribeMOTokenUsageSummaryWithOptionsAsync(DescribeMOTokenUsageSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UsageType))
            {
                query["UsageType"] = request.UsageType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMOTokenUsageSummary",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMOTokenUsageSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage summary for a model operator instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageSummaryResponse
        /// </returns>
        public DescribeMOTokenUsageSummaryResponse DescribeMOTokenUsageSummary(DescribeMOTokenUsageSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMOTokenUsageSummaryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the token usage summary for a model operator instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOTokenUsageSummaryRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOTokenUsageSummaryResponse
        /// </returns>
        public async Task<DescribeMOTokenUsageSummaryResponse> DescribeMOTokenUsageSummaryAsync(DescribeMOTokenUsageSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMOTokenUsageSummaryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status or download link of an asynchronous CSV export task for MO usage details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOUsageDetailExportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOUsageDetailExportResponse
        /// </returns>
        public DescribeMOUsageDetailExportResponse DescribeMOUsageDetailExportWithOptions(DescribeMOUsageDetailExportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMOUsageDetailExport",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMOUsageDetailExportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status or download link of an asynchronous CSV export task for MO usage details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOUsageDetailExportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOUsageDetailExportResponse
        /// </returns>
        public async Task<DescribeMOUsageDetailExportResponse> DescribeMOUsageDetailExportWithOptionsAsync(DescribeMOUsageDetailExportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMOUsageDetailExport",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMOUsageDetailExportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status or download link of an asynchronous CSV export task for MO usage details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOUsageDetailExportRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOUsageDetailExportResponse
        /// </returns>
        public DescribeMOUsageDetailExportResponse DescribeMOUsageDetailExport(DescribeMOUsageDetailExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMOUsageDetailExportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status or download link of an asynchronous CSV export task for MO usage details.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMOUsageDetailExportRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMOUsageDetailExportResponse
        /// </returns>
        public async Task<DescribeMOUsageDetailExportResponse> DescribeMOUsageDetailExportAsync(DescribeMOUsageDetailExportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMOUsageDetailExportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information and usage of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelOperatorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelOperatorResponse
        /// </returns>
        public DescribeModelOperatorResponse DescribeModelOperatorWithOptions(DescribeModelOperatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "DescribeModelOperator",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelOperatorResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information and usage of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelOperatorRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelOperatorResponse
        /// </returns>
        public async Task<DescribeModelOperatorResponse> DescribeModelOperatorWithOptionsAsync(DescribeModelOperatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
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
                Action = "DescribeModelOperator",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeModelOperatorResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information and usage of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelOperatorRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelOperatorResponse
        /// </returns>
        public DescribeModelOperatorResponse DescribeModelOperator(DescribeModelOperatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeModelOperatorWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information and usage of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeModelOperatorRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeModelOperatorResponse
        /// </returns>
        public async Task<DescribeModelOperatorResponse> DescribeModelOperatorAsync(DescribeModelOperatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeModelOperatorWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance monitoring data of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeMonitorDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public DescribeMonitorDataResponse DescribeMonitorDataWithOptions(DescribeMonitorDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMonitorDataShrinkRequest request = new DescribeMonitorDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiKeyName))
            {
                request.ApiKeyNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiKeyName, "ApiKeyName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyNameShrink))
            {
                query["ApiKeyName"] = request.ApiKeyNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorData",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance monitoring data of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DescribeMonitorDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public async Task<DescribeMonitorDataResponse> DescribeMonitorDataWithOptionsAsync(DescribeMonitorDataRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeMonitorDataShrinkRequest request = new DescribeMonitorDataShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ApiKeyName))
            {
                request.ApiKeyNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ApiKeyName, "ApiKeyName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKeyNameShrink))
            {
                query["ApiKeyName"] = request.ApiKeyNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                query["Metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMonitorData",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMonitorDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance monitoring data of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMonitorDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public DescribeMonitorDataResponse DescribeMonitorData(DescribeMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMonitorDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries instance monitoring data of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMonitorDataRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMonitorDataResponse
        /// </returns>
        public async Task<DescribeMonitorDataResponse> DescribeMonitorDataAsync(DescribeMonitorDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMonitorDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sandbox templates used to create Supabase sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxTemplatesResponse
        /// </returns>
        public DescribeSandboxTemplatesResponse DescribeSandboxTemplatesWithOptions(DescribeSandboxTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxTemplates",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sandbox templates used to create Supabase sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxTemplatesResponse
        /// </returns>
        public async Task<DescribeSandboxTemplatesResponse> DescribeSandboxTemplatesWithOptionsAsync(DescribeSandboxTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSandboxTemplates",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSandboxTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sandbox templates used to create Supabase sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxTemplatesResponse
        /// </returns>
        public DescribeSandboxTemplatesResponse DescribeSandboxTemplates(DescribeSandboxTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSandboxTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of sandbox templates used to create Supabase sandboxes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeSandboxTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeSandboxTemplatesResponse
        /// </returns>
        public async Task<DescribeSandboxTemplatesResponse> DescribeSandboxTemplatesAsync(DescribeSandboxTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSandboxTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWhitelistIpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhitelistIpsResponse
        /// </returns>
        public DescribeWhitelistIpsResponse DescribeWhitelistIpsWithOptions(DescribeWhitelistIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWhitelistIps",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWhitelistIpsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWhitelistIpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhitelistIpsResponse
        /// </returns>
        public async Task<DescribeWhitelistIpsResponse> DescribeWhitelistIpsWithOptionsAsync(DescribeWhitelistIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWhitelistIps",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWhitelistIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWhitelistIpsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhitelistIpsResponse
        /// </returns>
        public DescribeWhitelistIpsResponse DescribeWhitelistIps(DescribeWhitelistIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeWhitelistIpsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeWhitelistIpsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeWhitelistIpsResponse
        /// </returns>
        public async Task<DescribeWhitelistIpsResponse> DescribeWhitelistIpsAsync(DescribeWhitelistIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeWhitelistIpsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance. Note: This operation deletes all sandboxes and Edge Routines of the instance. Fully assess the business risks before performing this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance.</para>
        /// <remarks>
        /// <para>Notice: This operation deletes all sandboxes and Edge Routines of the Supabase instance. Fully assess the business risks before performing this operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAgentRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAgentRuntimeResponse
        /// </returns>
        public DisableAgentRuntimeResponse DisableAgentRuntimeWithOptions(DisableAgentRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAgentRuntime",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance. Note: This operation deletes all sandboxes and Edge Routines of the instance. Fully assess the business risks before performing this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance.</para>
        /// <remarks>
        /// <para>Notice: This operation deletes all sandboxes and Edge Routines of the Supabase instance. Fully assess the business risks before performing this operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAgentRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableAgentRuntimeResponse
        /// </returns>
        public async Task<DisableAgentRuntimeResponse> DisableAgentRuntimeWithOptionsAsync(DisableAgentRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableAgentRuntime",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance. Note: This operation deletes all sandboxes and Edge Routines of the instance. Fully assess the business risks before performing this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance.</para>
        /// <remarks>
        /// <para>Notice: This operation deletes all sandboxes and Edge Routines of the Supabase instance. Fully assess the business risks before performing this operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAgentRuntimeResponse
        /// </returns>
        public DisableAgentRuntimeResponse DisableAgentRuntime(DisableAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableAgentRuntimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance. Note: This operation deletes all sandboxes and Edge Routines of the instance. Fully assess the business risks before performing this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Disables the sandbox and Edge Routine capabilities of a Supabase instance.</para>
        /// <remarks>
        /// <para>Notice: This operation deletes all sandboxes and Edge Routines of the Supabase instance. Fully assess the business risks before performing this operation.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableAgentRuntimeResponse
        /// </returns>
        public async Task<DisableAgentRuntimeResponse> DisableAgentRuntimeAsync(DisableAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableAgentRuntimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the sandbox and Edge Routine capabilities for a Supabase instance. Read the operation description before you call this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the public preview, the sandbox and Edge Routine features are free of charge.</para>
        /// <h3>Before you begin</h3>
        /// <para>Before you use this feature, <a href="https://api.aliyun.com/api/ResourceManager/2020-03-31/CreateServiceLinkedRole?spm=api-workbench.API%20Document.0.0.4ea75094rJgPzK&RegionId=cn-beijing&tab=DEBUG&params=%7B%2522ServiceName%2522:%2522supabase.rdsai.aliyuncs.com%2522%7D&sdkStyle=old">authorize the service-linked role</a>. The service-linked role used is <a href="https://www.alibabacloud.com/help/en/ram/product-overview/services-that-work-with-service-linked-roles">AliyunServiceRoleForRDSAISupabase</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAgentRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAgentRuntimeResponse
        /// </returns>
        public EnableAgentRuntimeResponse EnableAgentRuntimeWithOptions(EnableAgentRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAgentRuntime",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAgentRuntimeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the sandbox and Edge Routine capabilities for a Supabase instance. Read the operation description before you call this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the public preview, the sandbox and Edge Routine features are free of charge.</para>
        /// <h3>Before you begin</h3>
        /// <para>Before you use this feature, <a href="https://api.aliyun.com/api/ResourceManager/2020-03-31/CreateServiceLinkedRole?spm=api-workbench.API%20Document.0.0.4ea75094rJgPzK&RegionId=cn-beijing&tab=DEBUG&params=%7B%2522ServiceName%2522:%2522supabase.rdsai.aliyuncs.com%2522%7D&sdkStyle=old">authorize the service-linked role</a>. The service-linked role used is <a href="https://www.alibabacloud.com/help/en/ram/product-overview/services-that-work-with-service-linked-roles">AliyunServiceRoleForRDSAISupabase</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAgentRuntimeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableAgentRuntimeResponse
        /// </returns>
        public async Task<EnableAgentRuntimeResponse> EnableAgentRuntimeWithOptionsAsync(EnableAgentRuntimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableAgentRuntime",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAgentRuntimeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the sandbox and Edge Routine capabilities for a Supabase instance. Read the operation description before you call this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the public preview, the sandbox and Edge Routine features are free of charge.</para>
        /// <h3>Before you begin</h3>
        /// <para>Before you use this feature, <a href="https://api.aliyun.com/api/ResourceManager/2020-03-31/CreateServiceLinkedRole?spm=api-workbench.API%20Document.0.0.4ea75094rJgPzK&RegionId=cn-beijing&tab=DEBUG&params=%7B%2522ServiceName%2522:%2522supabase.rdsai.aliyuncs.com%2522%7D&sdkStyle=old">authorize the service-linked role</a>. The service-linked role used is <a href="https://www.alibabacloud.com/help/en/ram/product-overview/services-that-work-with-service-linked-roles">AliyunServiceRoleForRDSAISupabase</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAgentRuntimeResponse
        /// </returns>
        public EnableAgentRuntimeResponse EnableAgentRuntime(EnableAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAgentRuntimeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables the sandbox and Edge Routine capabilities for a Supabase instance. Read the operation description before you call this operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>During the public preview, the sandbox and Edge Routine features are free of charge.</para>
        /// <h3>Before you begin</h3>
        /// <para>Before you use this feature, <a href="https://api.aliyun.com/api/ResourceManager/2020-03-31/CreateServiceLinkedRole?spm=api-workbench.API%20Document.0.0.4ea75094rJgPzK&RegionId=cn-beijing&tab=DEBUG&params=%7B%2522ServiceName%2522:%2522supabase.rdsai.aliyuncs.com%2522%7D&sdkStyle=old">authorize the service-linked role</a>. The service-linked role used is <a href="https://www.alibabacloud.com/help/en/ram/product-overview/services-that-work-with-service-linked-roles">AliyunServiceRoleForRDSAISupabase</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableAgentRuntimeRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableAgentRuntimeResponse
        /// </returns>
        public async Task<EnableAgentRuntimeResponse> EnableAgentRuntimeAsync(EnableAgentRuntimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAgentRuntimeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of large language models supported by the current RDS Supabase AI gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableLLMModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableLLMModelsResponse
        /// </returns>
        public GetAvailableLLMModelsResponse GetAvailableLLMModelsWithOptions(GetAvailableLLMModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailableLLMModels",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailableLLMModelsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of large language models supported by the current RDS Supabase AI gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableLLMModelsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableLLMModelsResponse
        /// </returns>
        public async Task<GetAvailableLLMModelsResponse> GetAvailableLLMModelsWithOptionsAsync(GetAvailableLLMModelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAvailableLLMModels",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAvailableLLMModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of large language models supported by the current RDS Supabase AI gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableLLMModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableLLMModelsResponse
        /// </returns>
        public GetAvailableLLMModelsResponse GetAvailableLLMModels(GetAvailableLLMModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAvailableLLMModelsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the list of large language models supported by the current RDS Supabase AI gateway.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAvailableLLMModelsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAvailableLLMModelsResponse
        /// </returns>
        public async Task<GetAvailableLLMModelsResponse> GetAvailableLLMModelsAsync(GetAvailableLLMModelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAvailableLLMModelsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the available models for a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatModelResponse
        /// </returns>
        public GetChatModelResponse GetChatModelWithOptions(GetChatModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatModel",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatModelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the available models for a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatModelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatModelResponse
        /// </returns>
        public async Task<GetChatModelResponse> GetChatModelWithOptionsAsync(GetChatModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChatModel",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatModelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the available models for a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatModelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatModelResponse
        /// </returns>
        public GetChatModelResponse GetChatModel(GetChatModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetChatModelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the available models for a session.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatModelRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatModelResponse
        /// </returns>
        public async Task<GetChatModelResponse> GetChatModelAsync(GetChatModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetChatModelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a datasource configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionResponse
        /// </returns>
        public GetContextDatabaseSyncConnectionResponse GetContextDatabaseSyncConnectionWithOptions(GetContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a datasource configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncConnectionResponse> GetContextDatabaseSyncConnectionWithOptionsAsync(GetContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a datasource configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionResponse
        /// </returns>
        public GetContextDatabaseSyncConnectionResponse GetContextDatabaseSyncConnection(GetContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a datasource configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncConnectionResponse> GetContextDatabaseSyncConnectionAsync(GetContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization scope of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the authorization scope of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionAuthorizationResponse
        /// </returns>
        public GetContextDatabaseSyncConnectionAuthorizationResponse GetContextDatabaseSyncConnectionAuthorizationWithOptions(GetContextDatabaseSyncConnectionAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncConnectionAuthorization",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncConnectionAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization scope of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the authorization scope of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionAuthorizationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionAuthorizationResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncConnectionAuthorizationResponse> GetContextDatabaseSyncConnectionAuthorizationWithOptionsAsync(GetContextDatabaseSyncConnectionAuthorizationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncConnectionAuthorization",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncConnectionAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization scope of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the authorization scope of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionAuthorizationResponse
        /// </returns>
        public GetContextDatabaseSyncConnectionAuthorizationResponse GetContextDatabaseSyncConnectionAuthorization(GetContextDatabaseSyncConnectionAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncConnectionAuthorizationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the authorization scope of a data source.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the authorization scope of a connection.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncConnectionAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncConnectionAuthorizationResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncConnectionAuthorizationResponse> GetContextDatabaseSyncConnectionAuthorizationAsync(GetContextDatabaseSyncConnectionAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncConnectionAuthorizationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncDiscoveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncDiscoveryTaskResponse
        /// </returns>
        public GetContextDatabaseSyncDiscoveryTaskResponse GetContextDatabaseSyncDiscoveryTaskWithOptions(GetContextDatabaseSyncDiscoveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncDiscoveryTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncDiscoveryTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncDiscoveryTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncDiscoveryTaskResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncDiscoveryTaskResponse> GetContextDatabaseSyncDiscoveryTaskWithOptionsAsync(GetContextDatabaseSyncDiscoveryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncDiscoveryTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncDiscoveryTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncDiscoveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncDiscoveryTaskResponse
        /// </returns>
        public GetContextDatabaseSyncDiscoveryTaskResponse GetContextDatabaseSyncDiscoveryTask(GetContextDatabaseSyncDiscoveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncDiscoveryTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status of a discovery task by task ID.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncDiscoveryTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncDiscoveryTaskResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncDiscoveryTaskResponse> GetContextDatabaseSyncDiscoveryTaskAsync(GetContextDatabaseSyncDiscoveryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncDiscoveryTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobResponse
        /// </returns>
        public GetContextDatabaseSyncJobResponse GetContextDatabaseSyncJobWithOptions(GetContextDatabaseSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncJobResponse> GetContextDatabaseSyncJobWithOptionsAsync(GetContextDatabaseSyncJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobResponse
        /// </returns>
        public GetContextDatabaseSyncJobResponse GetContextDatabaseSyncJob(GetContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncJobResponse> GetContextDatabaseSyncJobAsync(GetContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an import task can be started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries whether a job can be started.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobReadinessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobReadinessResponse
        /// </returns>
        public GetContextDatabaseSyncJobReadinessResponse GetContextDatabaseSyncJobReadinessWithOptions(GetContextDatabaseSyncJobReadinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncJobReadiness",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncJobReadinessResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an import task can be started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries whether a job can be started.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobReadinessRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobReadinessResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncJobReadinessResponse> GetContextDatabaseSyncJobReadinessWithOptionsAsync(GetContextDatabaseSyncJobReadinessRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncJobReadiness",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncJobReadinessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an import task can be started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries whether a job can be started.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobReadinessRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobReadinessResponse
        /// </returns>
        public GetContextDatabaseSyncJobReadinessResponse GetContextDatabaseSyncJobReadiness(GetContextDatabaseSyncJobReadinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncJobReadinessWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries whether an import task can be started.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries whether a job can be started.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobReadinessRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobReadinessResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncJobReadinessResponse> GetContextDatabaseSyncJobReadinessAsync(GetContextDatabaseSyncJobReadinessRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncJobReadinessWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scheduling configuration of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the scheduling configuration of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public GetContextDatabaseSyncJobScheduleResponse GetContextDatabaseSyncJobScheduleWithOptions(GetContextDatabaseSyncJobScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncJobSchedule",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncJobScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scheduling configuration of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the scheduling configuration of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncJobScheduleResponse> GetContextDatabaseSyncJobScheduleWithOptionsAsync(GetContextDatabaseSyncJobScheduleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncJobSchedule",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncJobScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scheduling configuration of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the scheduling configuration of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public GetContextDatabaseSyncJobScheduleResponse GetContextDatabaseSyncJobSchedule(GetContextDatabaseSyncJobScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncJobScheduleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the scheduling configuration of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the scheduling configuration of a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncJobScheduleResponse> GetContextDatabaseSyncJobScheduleAsync(GetContextDatabaseSyncJobScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncJobScheduleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncRunResponse
        /// </returns>
        public GetContextDatabaseSyncRunResponse GetContextDatabaseSyncRunWithOptions(GetContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncRunResponse> GetContextDatabaseSyncRunWithOptionsAsync(GetContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncRunResponse
        /// </returns>
        public GetContextDatabaseSyncRunResponse GetContextDatabaseSyncRun(GetContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncRunResponse> GetContextDatabaseSyncRunAsync(GetContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceResponse
        /// </returns>
        public GetContextDatabaseSyncSourceResponse GetContextDatabaseSyncSourceWithOptions(GetContextDatabaseSyncSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncSourceResponse> GetContextDatabaseSyncSourceWithOptionsAsync(GetContextDatabaseSyncSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceResponse
        /// </returns>
        public GetContextDatabaseSyncSourceResponse GetContextDatabaseSyncSource(GetContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves the details of a source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncSourceResponse> GetContextDatabaseSyncSourceAsync(GetContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current node selection in the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the current node selection of the source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public GetContextDatabaseSyncSourceSelectionResponse GetContextDatabaseSyncSourceSelectionWithOptions(GetContextDatabaseSyncSourceSelectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncSourceSelection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncSourceSelectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current node selection in the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the current node selection of the source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncSourceSelectionResponse> GetContextDatabaseSyncSourceSelectionWithOptionsAsync(GetContextDatabaseSyncSourceSelectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetContextDatabaseSyncSourceSelection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetContextDatabaseSyncSourceSelectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current node selection in the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the current node selection of the source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public GetContextDatabaseSyncSourceSelectionResponse GetContextDatabaseSyncSourceSelection(GetContextDatabaseSyncSourceSelectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetContextDatabaseSyncSourceSelectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current node selection in the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the current node selection of the source.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public async Task<GetContextDatabaseSyncSourceSelectionResponse> GetContextDatabaseSyncSourceSelectionAsync(GetContextDatabaseSyncSourceSelectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetContextDatabaseSyncSourceSelectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical conversations of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationsResponse
        /// </returns>
        public GetConversationsResponse GetConversationsWithOptions(GetConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastId))
            {
                query["LastId"] = request.LastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pinned))
            {
                query["Pinned"] = request.Pinned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConversations",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical conversations of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetConversationsResponse
        /// </returns>
        public async Task<GetConversationsResponse> GetConversationsWithOptionsAsync(GetConversationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastId))
            {
                query["LastId"] = request.LastId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pinned))
            {
                query["Pinned"] = request.Pinned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConversations",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConversationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical conversations of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationsResponse
        /// </returns>
        public GetConversationsResponse GetConversations(GetConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConversationsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the historical conversations of a user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetConversationsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetConversationsResponse
        /// </returns>
        public async Task<GetConversationsResponse> GetConversationsAsync(GetConversationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConversationsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomAgentResponse
        /// </returns>
        public GetCustomAgentResponse GetCustomAgentWithOptions(GetCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCustomAgentResponse
        /// </returns>
        public async Task<GetCustomAgentResponse> GetCustomAgentWithOptionsAsync(GetCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomAgentResponse
        /// </returns>
        public GetCustomAgentResponse GetCustomAgent(GetCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a dedicated agent created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCustomAgentResponse
        /// </returns>
        public async Task<GetCustomAgentResponse> GetCustomAgentAsync(GetCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an inspection report by report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public GetInspectionReportResponse GetInspectionReportWithOptions(GetInspectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
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
                Action = "GetInspectionReport",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInspectionReportResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an inspection report by report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public async Task<GetInspectionReportResponse> GetInspectionReportWithOptionsAsync(GetInspectionReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
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
                Action = "GetInspectionReport",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInspectionReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an inspection report by report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public GetInspectionReportResponse GetInspectionReport(GetInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInspectionReportWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an inspection report by report ID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInspectionReportRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInspectionReportResponse
        /// </returns>
        public async Task<GetInspectionReportResponse> GetInspectionReportAsync(GetInspectionReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInspectionReportWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of specific conversation messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMessagesResponse
        /// </returns>
        public GetMessagesResponse GetMessagesWithOptions(GetMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMode))
            {
                query["EventMode"] = request.EventMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstId))
            {
                query["FirstId"] = request.FirstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessages",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of specific conversation messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMessagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMessagesResponse
        /// </returns>
        public async Task<GetMessagesResponse> GetMessagesWithOptionsAsync(GetMessagesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversationId))
            {
                query["ConversationId"] = request.ConversationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventMode))
            {
                query["EventMode"] = request.EventMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstId))
            {
                query["FirstId"] = request.FirstId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessages",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of specific conversation messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMessagesResponse
        /// </returns>
        public GetMessagesResponse GetMessages(GetMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMessagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of specific conversation messages.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMessagesResponse
        /// </returns>
        public async Task<GetMessagesResponse> GetMessagesAsync(GetMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMessagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves order information for RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelOperatorOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelOperatorOrderResponse
        /// </returns>
        public GetModelOperatorOrderResponse GetModelOperatorOrderWithOptions(GetModelOperatorOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetModelOperatorOrder",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelOperatorOrderResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves order information for RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelOperatorOrderRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModelOperatorOrderResponse
        /// </returns>
        public async Task<GetModelOperatorOrderResponse> GetModelOperatorOrderWithOptionsAsync(GetModelOperatorOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "GetModelOperatorOrder",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModelOperatorOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves order information for RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelOperatorOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelOperatorOrderResponse
        /// </returns>
        public GetModelOperatorOrderResponse GetModelOperatorOrder(GetModelOperatorOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetModelOperatorOrderWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves order information for RDS AI Assistant Ultimate Edition.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetModelOperatorOrderRequest
        /// </param>
        /// 
        /// <returns>
        /// GetModelOperatorOrderResponse
        /// </returns>
        public async Task<GetModelOperatorOrderResponse> GetModelOperatorOrderAsync(GetModelOperatorOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetModelOperatorOrderWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of all instance IDs included in a specified scheduled inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledInstancesResponse
        /// </returns>
        public GetScheduledInstancesResponse GetScheduledInstancesWithOptions(GetScheduledInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledInstances",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledInstancesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of all instance IDs included in a specified scheduled inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledInstancesResponse
        /// </returns>
        public async Task<GetScheduledInstancesResponse> GetScheduledInstancesWithOptionsAsync(GetScheduledInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledInstances",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of all instance IDs included in a specified scheduled inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledInstancesResponse
        /// </returns>
        public GetScheduledInstancesResponse GetScheduledInstances(GetScheduledInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScheduledInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of all instance IDs included in a specified scheduled inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledInstancesResponse
        /// </returns>
        public async Task<GetScheduledInstancesResponse> GetScheduledInstancesAsync(GetScheduledInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScheduledInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all inspection reports under a specified scheduled task, with support for filtering by time range and pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledReportsResponse
        /// </returns>
        public GetScheduledReportsResponse GetScheduledReportsWithOptions(GetScheduledReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledReports",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all inspection reports under a specified scheduled task, with support for filtering by time range and pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledReportsResponse
        /// </returns>
        public async Task<GetScheduledReportsResponse> GetScheduledReportsWithOptionsAsync(GetScheduledReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScheduledReports",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScheduledReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all inspection reports under a specified scheduled task, with support for filtering by time range and pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledReportsResponse
        /// </returns>
        public GetScheduledReportsResponse GetScheduledReports(GetScheduledReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScheduledReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all inspection reports under a specified scheduled task, with support for filtering by time range and pagination.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetScheduledReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScheduledReportsResponse
        /// </returns>
        public async Task<GetScheduledReportsResponse> GetScheduledReportsAsync(GetScheduledReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScheduledReportsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified skill. You can retrieve your own skills or system preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkillWithOptions(GetSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Download))
            {
                query["Download"] = request.Download;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified skill. You can retrieve your own skills or system preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillWithOptionsAsync(GetSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Download))
            {
                query["Download"] = request.Download;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionId))
            {
                query["VersionId"] = request.VersionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified skill. You can retrieve your own skills or system preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public GetSkillResponse GetSkill(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of a specified skill. You can retrieve your own skills or system preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSkillResponse
        /// </returns>
        public async Task<GetSkillResponse> GetSkillAsync(GetSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of individual inspection reports for all non-scheduled tasks under a specified user, with pagination support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStandAloneReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStandAloneReportsResponse
        /// </returns>
        public GetStandAloneReportsResponse GetStandAloneReportsWithOptions(GetStandAloneReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStandAloneReports",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStandAloneReportsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of individual inspection reports for all non-scheduled tasks under a specified user, with pagination support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStandAloneReportsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetStandAloneReportsResponse
        /// </returns>
        public async Task<GetStandAloneReportsResponse> GetStandAloneReportsWithOptionsAsync(GetStandAloneReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportType))
            {
                query["ReportType"] = request.ReportType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetStandAloneReports",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetStandAloneReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of individual inspection reports for all non-scheduled tasks under a specified user, with pagination support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStandAloneReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStandAloneReportsResponse
        /// </returns>
        public GetStandAloneReportsResponse GetStandAloneReports(GetStandAloneReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetStandAloneReportsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of individual inspection reports for all non-scheduled tasks under a specified user, with pagination support.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetStandAloneReportsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetStandAloneReportsResponse
        /// </returns>
        public async Task<GetStandAloneReportsResponse> GetStandAloneReportsAsync(GetStandAloneReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetStandAloneReportsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public ListApiKeysResponse ListApiKeysWithOptions(ListApiKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
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
                Action = "ListApiKeys",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public async Task<ListApiKeysResponse> ListApiKeysWithOptionsAsync(ListApiKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
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
                Action = "ListApiKeys",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public ListApiKeysResponse ListApiKeys(ListApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries custom API keys.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListApiKeysResponse
        /// </returns>
        public async Task<ListApiKeysResponse> ListApiKeysAsync(ListApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the API keys for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the API keys under a specified member. The plaintext key values are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseApiKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseApiKeysResponse
        /// </returns>
        public ListContextDatabaseApiKeysResponse ListContextDatabaseApiKeysWithOptions(ListContextDatabaseApiKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseApiKeys",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseApiKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the API keys for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the API keys under a specified member. The plaintext key values are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseApiKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseApiKeysResponse
        /// </returns>
        public async Task<ListContextDatabaseApiKeysResponse> ListContextDatabaseApiKeysWithOptionsAsync(ListContextDatabaseApiKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseApiKeys",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseApiKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the API keys for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the API keys under a specified member. The plaintext key values are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseApiKeysResponse
        /// </returns>
        public ListContextDatabaseApiKeysResponse ListContextDatabaseApiKeys(ListContextDatabaseApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseApiKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the API keys for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists the API keys under a specified member. The plaintext key values are not returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseApiKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseApiKeysResponse
        /// </returns>
        public async Task<ListContextDatabaseApiKeysResponse> ListContextDatabaseApiKeysAsync(ListContextDatabaseApiKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseApiKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists context database members.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all members in a specified workspace. Each member includes a list of API keys (plaintext values are not returned).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseMembersResponse
        /// </returns>
        public ListContextDatabaseMembersResponse ListContextDatabaseMembersWithOptions(ListContextDatabaseMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseMembers",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseMembersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists context database members.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all members in a specified workspace. Each member includes a list of API keys (plaintext values are not returned).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseMembersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseMembersResponse
        /// </returns>
        public async Task<ListContextDatabaseMembersResponse> ListContextDatabaseMembersWithOptionsAsync(ListContextDatabaseMembersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseMembers",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseMembersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists context database members.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all members in a specified workspace. Each member includes a list of API keys (plaintext values are not returned).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseMembersResponse
        /// </returns>
        public ListContextDatabaseMembersResponse ListContextDatabaseMembers(ListContextDatabaseMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseMembersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists context database members.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists all members in a specified workspace. Each member includes a list of API keys (plaintext values are not returned).</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseMembersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseMembersResponse
        /// </returns>
        public async Task<ListContextDatabaseMembersResponse> ListContextDatabaseMembersAsync(ListContextDatabaseMembersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseMembersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasource configurations in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncConnectionsResponse
        /// </returns>
        public ListContextDatabaseSyncConnectionsResponse ListContextDatabaseSyncConnectionsWithOptions(ListContextDatabaseSyncConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["PluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncConnections",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasource configurations in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncConnectionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncConnectionsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncConnectionsResponse> ListContextDatabaseSyncConnectionsWithOptionsAsync(ListContextDatabaseSyncConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PluginId))
            {
                query["PluginId"] = request.PluginId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncConnections",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasource configurations in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncConnectionsResponse
        /// </returns>
        public ListContextDatabaseSyncConnectionsResponse ListContextDatabaseSyncConnections(ListContextDatabaseSyncConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncConnectionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the datasource configurations in a workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncConnectionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncConnectionsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncConnectionsResponse> ListContextDatabaseSyncConnectionsAsync(ListContextDatabaseSyncConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncConnectionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents associated with an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional. The Data field in the response is returned as an array, and the Total field indicates the total number of matching entries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobDocumentsResponse
        /// </returns>
        public ListContextDatabaseSyncJobDocumentsResponse ListContextDatabaseSyncJobDocumentsWithOptions(ListContextDatabaseSyncJobDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncJobDocuments",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncJobDocumentsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents associated with an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional. The Data field in the response is returned as an array, and the Total field indicates the total number of matching entries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobDocumentsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobDocumentsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncJobDocumentsResponse> ListContextDatabaseSyncJobDocumentsWithOptionsAsync(ListContextDatabaseSyncJobDocumentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncJobDocuments",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncJobDocumentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents associated with an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional. The Data field in the response is returned as an array, and the Total field indicates the total number of matching entries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobDocumentsResponse
        /// </returns>
        public ListContextDatabaseSyncJobDocumentsResponse ListContextDatabaseSyncJobDocuments(ListContextDatabaseSyncJobDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncJobDocumentsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the documents associated with an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional. The Data field in the response is returned as an array, and the Total field indicates the total number of matching entries.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobDocumentsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobDocumentsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncJobDocumentsResponse> ListContextDatabaseSyncJobDocumentsAsync(ListContextDatabaseSyncJobDocumentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncJobDocumentsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the exclusions of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation uses pagination by default. Page and PageSize are optional parameters.
        /// The Data field in the response returns an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobExclusionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobExclusionsResponse
        /// </returns>
        public ListContextDatabaseSyncJobExclusionsResponse ListContextDatabaseSyncJobExclusionsWithOptions(ListContextDatabaseSyncJobExclusionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncJobExclusions",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncJobExclusionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the exclusions of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation uses pagination by default. Page and PageSize are optional parameters.
        /// The Data field in the response returns an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobExclusionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobExclusionsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncJobExclusionsResponse> ListContextDatabaseSyncJobExclusionsWithOptionsAsync(ListContextDatabaseSyncJobExclusionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncJobExclusions",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncJobExclusionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the exclusions of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation uses pagination by default. Page and PageSize are optional parameters.
        /// The Data field in the response returns an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobExclusionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobExclusionsResponse
        /// </returns>
        public ListContextDatabaseSyncJobExclusionsResponse ListContextDatabaseSyncJobExclusions(ListContextDatabaseSyncJobExclusionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncJobExclusionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the exclusions of an import task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation uses pagination by default. Page and PageSize are optional parameters.
        /// The Data field in the response returns an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobExclusionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobExclusionsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncJobExclusionsResponse> ListContextDatabaseSyncJobExclusionsAsync(ListContextDatabaseSyncJobExclusionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncJobExclusionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists import tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobsResponse
        /// </returns>
        public ListContextDatabaseSyncJobsResponse ListContextDatabaseSyncJobsWithOptions(ListContextDatabaseSyncJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncJobs",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists import tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncJobsResponse> ListContextDatabaseSyncJobsWithOptionsAsync(ListContextDatabaseSyncJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseId))
            {
                query["KnowledgeBaseId"] = request.KnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncJobs",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists import tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobsResponse
        /// </returns>
        public ListContextDatabaseSyncJobsResponse ListContextDatabaseSyncJobs(ListContextDatabaseSyncJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists import tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list operation returns paginated results by default. Page and PageSize are optional parameters.
        /// The Data list field in the response is returned as an array. Total indicates the total number of records that match the specified conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncJobsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncJobsResponse> ListContextDatabaseSyncJobsAsync(ListContextDatabaseSyncJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists available synchronization plugins.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns a fixed-length array of available plugins in the workspace and does not support pagination.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncPluginsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncPluginsResponse
        /// </returns>
        public ListContextDatabaseSyncPluginsResponse ListContextDatabaseSyncPluginsWithOptions(ListContextDatabaseSyncPluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncPlugins",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncPluginsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists available synchronization plugins.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns a fixed-length array of available plugins in the workspace and does not support pagination.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncPluginsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncPluginsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncPluginsResponse> ListContextDatabaseSyncPluginsWithOptionsAsync(ListContextDatabaseSyncPluginsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncPlugins",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncPluginsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists available synchronization plugins.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns a fixed-length array of available plugins in the workspace and does not support pagination.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncPluginsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncPluginsResponse
        /// </returns>
        public ListContextDatabaseSyncPluginsResponse ListContextDatabaseSyncPlugins(ListContextDatabaseSyncPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncPluginsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists available synchronization plugins.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation returns a fixed-length array of available plugins in the workspace and does not support pagination.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncPluginsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncPluginsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncPluginsResponse> ListContextDatabaseSyncPluginsAsync(ListContextDatabaseSyncPluginsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncPluginsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the run records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list API returns paginated results by default. The Page and PageSize parameters are optional. Run records are a list of RunItems that show the processing results of each document in each import run.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunItemsResponse
        /// </returns>
        public ListContextDatabaseSyncRunItemsResponse ListContextDatabaseSyncRunItemsWithOptions(ListContextDatabaseSyncRunItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncRunItems",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncRunItemsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the run records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list API returns paginated results by default. The Page and PageSize parameters are optional. Run records are a list of RunItems that show the processing results of each document in each import run.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunItemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunItemsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncRunItemsResponse> ListContextDatabaseSyncRunItemsWithOptionsAsync(ListContextDatabaseSyncRunItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncRunItems",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncRunItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the run records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list API returns paginated results by default. The Page and PageSize parameters are optional. Run records are a list of RunItems that show the processing results of each document in each import run.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunItemsResponse
        /// </returns>
        public ListContextDatabaseSyncRunItemsResponse ListContextDatabaseSyncRunItems(ListContextDatabaseSyncRunItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncRunItemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the run records.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The list API returns paginated results by default. The Page and PageSize parameters are optional. Run records are a list of RunItems that show the processing results of each document in each import run.
        /// The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunItemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunItemsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncRunItemsResponse> ListContextDatabaseSyncRunItemsAsync(ListContextDatabaseSyncRunItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncRunItemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 Run 日志</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列表接口默认分页返回，Page 与 PageSize 为可选参数。
        /// 响应中的 Data 列表字段使用数组返回，Total 表示符合条件的总条数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunLogsResponse
        /// </returns>
        public ListContextDatabaseSyncRunLogsResponse ListContextDatabaseSyncRunLogsWithOptions(ListContextDatabaseSyncRunLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncRunLogs",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncRunLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 Run 日志</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列表接口默认分页返回，Page 与 PageSize 为可选参数。
        /// 响应中的 Data 列表字段使用数组返回，Total 表示符合条件的总条数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunLogsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncRunLogsResponse> ListContextDatabaseSyncRunLogsWithOptionsAsync(ListContextDatabaseSyncRunLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncRunLogs",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncRunLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 Run 日志</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列表接口默认分页返回，Page 与 PageSize 为可选参数。
        /// 响应中的 Data 列表字段使用数组返回，Total 表示符合条件的总条数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunLogsResponse
        /// </returns>
        public ListContextDatabaseSyncRunLogsResponse ListContextDatabaseSyncRunLogs(ListContextDatabaseSyncRunLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncRunLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列出 Run 日志</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>列表接口默认分页返回，Page 与 PageSize 为可选参数。
        /// 响应中的 Data 列表字段使用数组返回，Total 表示符合条件的总条数。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunLogsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncRunLogsResponse> ListContextDatabaseSyncRunLogsAsync(ListContextDatabaseSyncRunLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncRunLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the runs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional.
        /// The Data field in the response is returned as an array, and the Total field indicates the total number of items that meet the query conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunsResponse
        /// </returns>
        public ListContextDatabaseSyncRunsResponse ListContextDatabaseSyncRunsWithOptions(ListContextDatabaseSyncRunsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncRuns",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncRunsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the runs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional.
        /// The Data field in the response is returned as an array, and the Total field indicates the total number of items that meet the query conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncRunsResponse> ListContextDatabaseSyncRunsWithOptionsAsync(ListContextDatabaseSyncRunsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncRuns",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncRunsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the runs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional.
        /// The Data field in the response is returned as an array, and the Total field indicates the total number of items that meet the query conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunsResponse
        /// </returns>
        public ListContextDatabaseSyncRunsResponse ListContextDatabaseSyncRuns(ListContextDatabaseSyncRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncRunsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the runs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, this operation returns paginated results. The Page and PageSize parameters are optional.
        /// The Data field in the response is returned as an array, and the Total field indicates the total number of items that meet the query conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncRunsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncRunsResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncRunsResponse> ListContextDatabaseSyncRunsAsync(ListContextDatabaseSyncRunsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncRunsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the discovered tree nodes for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>List operations return paginated results by default. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourceTreeNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourceTreeNodesResponse
        /// </returns>
        public ListContextDatabaseSyncSourceTreeNodesResponse ListContextDatabaseSyncSourceTreeNodesWithOptions(ListContextDatabaseSyncSourceTreeNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncSourceTreeNodes",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncSourceTreeNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the discovered tree nodes for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>List operations return paginated results by default. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourceTreeNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourceTreeNodesResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncSourceTreeNodesResponse> ListContextDatabaseSyncSourceTreeNodesWithOptionsAsync(ListContextDatabaseSyncSourceTreeNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncSourceTreeNodes",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncSourceTreeNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the discovered tree nodes for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>List operations return paginated results by default. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourceTreeNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourceTreeNodesResponse
        /// </returns>
        public ListContextDatabaseSyncSourceTreeNodesResponse ListContextDatabaseSyncSourceTreeNodes(ListContextDatabaseSyncSourceTreeNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncSourceTreeNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the discovered tree nodes for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>List operations return paginated results by default. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourceTreeNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourceTreeNodesResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncSourceTreeNodesResponse> ListContextDatabaseSyncSourceTreeNodesAsync(ListContextDatabaseSyncSourceTreeNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncSourceTreeNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the data selection scopes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the list operation returns paginated results. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourcesResponse
        /// </returns>
        public ListContextDatabaseSyncSourcesResponse ListContextDatabaseSyncSourcesWithOptions(ListContextDatabaseSyncSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncSources",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the data selection scopes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the list operation returns paginated results. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourcesResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncSourcesResponse> ListContextDatabaseSyncSourcesWithOptionsAsync(ListContextDatabaseSyncSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Page))
            {
                query["Page"] = request.Page;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseSyncSources",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseSyncSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the data selection scopes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the list operation returns paginated results. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourcesResponse
        /// </returns>
        public ListContextDatabaseSyncSourcesResponse ListContextDatabaseSyncSources(ListContextDatabaseSyncSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseSyncSourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the data selection scopes.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>By default, the list operation returns paginated results. Page and PageSize are optional parameters. The Data list field in the response is returned as an array, and Total indicates the total number of entries that meet the conditions.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseSyncSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseSyncSourcesResponse
        /// </returns>
        public async Task<ListContextDatabaseSyncSourcesResponse> ListContextDatabaseSyncSourcesAsync(ListContextDatabaseSyncSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseSyncSourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists ContextDB workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists ContextDB workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseWorkspacesResponse
        /// </returns>
        public ListContextDatabaseWorkspacesResponse ListContextDatabaseWorkspacesWithOptions(ListContextDatabaseWorkspacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseWorkspaces",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseWorkspacesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists ContextDB workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists ContextDB workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseWorkspacesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseWorkspacesResponse
        /// </returns>
        public async Task<ListContextDatabaseWorkspacesResponse> ListContextDatabaseWorkspacesWithOptionsAsync(ListContextDatabaseWorkspacesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListContextDatabaseWorkspaces",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListContextDatabaseWorkspacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists ContextDB workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists ContextDB workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseWorkspacesResponse
        /// </returns>
        public ListContextDatabaseWorkspacesResponse ListContextDatabaseWorkspaces(ListContextDatabaseWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListContextDatabaseWorkspacesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists ContextDB workspaces.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Lists ContextDB workspaces.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListContextDatabaseWorkspacesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListContextDatabaseWorkspacesResponse
        /// </returns>
        public async Task<ListContextDatabaseWorkspacesResponse> ListContextDatabaseWorkspacesAsync(ListContextDatabaseWorkspacesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListContextDatabaseWorkspacesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of dedicated agents created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public ListCustomAgentResponse ListCustomAgentWithOptions(ListCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of dedicated agents created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public async Task<ListCustomAgentResponse> ListCustomAgentWithOptionsAsync(ListCustomAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "ListCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of dedicated agents created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public ListCustomAgentResponse ListCustomAgent(ListCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of dedicated agents created by the user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentResponse
        /// </returns>
        public async Task<ListCustomAgentResponse> ListCustomAgentAsync(ListCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Agent tools for a user.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentToolsResponse
        /// </returns>
        public ListCustomAgentToolsResponse ListCustomAgentToolsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomAgentTools",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomAgentToolsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Agent tools for a user.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCustomAgentToolsResponse
        /// </returns>
        public async Task<ListCustomAgentToolsResponse> ListCustomAgentToolsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCustomAgentTools",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCustomAgentToolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Agent tools for a user.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListCustomAgentToolsResponse
        /// </returns>
        public ListCustomAgentToolsResponse ListCustomAgentTools()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCustomAgentToolsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of Agent tools for a user.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListCustomAgentToolsResponse
        /// </returns>
        public async Task<ListCustomAgentToolsResponse> ListCustomAgentToolsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCustomAgentToolsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the AI gateway token usage for an RDS Supabase instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLLMTokenUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLLMTokenUsageResponse
        /// </returns>
        public ListLLMTokenUsageResponse ListLLMTokenUsageWithOptions(ListLLMTokenUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLLMTokenUsage",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLLMTokenUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the AI gateway token usage for an RDS Supabase instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLLMTokenUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListLLMTokenUsageResponse
        /// </returns>
        public async Task<ListLLMTokenUsageResponse> ListLLMTokenUsageWithOptionsAsync(ListLLMTokenUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["Model"] = request.Model;
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
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListLLMTokenUsage",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListLLMTokenUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the AI gateway token usage for an RDS Supabase instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLLMTokenUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLLMTokenUsageResponse
        /// </returns>
        public ListLLMTokenUsageResponse ListLLMTokenUsage(ListLLMTokenUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLLMTokenUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the AI gateway token usage for an RDS Supabase instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListLLMTokenUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListLLMTokenUsageResponse
        /// </returns>
        public async Task<ListLLMTokenUsageResponse> ListLLMTokenUsageAsync(ListLLMTokenUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLLMTokenUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of basic information about all inspection configurations under a specified user UID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public ListScheduledTasksResponse ListScheduledTasksWithOptions(ListScheduledTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledTasks",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of basic information about all inspection configurations under a specified user UID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public async Task<ListScheduledTasksResponse> ListScheduledTasksWithOptionsAsync(ListScheduledTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScheduledTasks",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScheduledTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of basic information about all inspection configurations under a specified user UID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public ListScheduledTasksResponse ListScheduledTasks(ListScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScheduledTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of basic information about all inspection configurations under a specified user UID.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListScheduledTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScheduledTasksResponse
        /// </returns>
        public async Task<ListScheduledTasksResponse> ListScheduledTasksAsync(ListScheduledTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScheduledTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the custom skills of the current user and all system-preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillResponse
        /// </returns>
        public ListSkillResponse ListSkillWithOptions(ListSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the custom skills of the current user and all system-preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSkillResponse
        /// </returns>
        public async Task<ListSkillResponse> ListSkillWithOptionsAsync(ListSkillRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Language))
            {
                query["Language"] = request.Language;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                query["Query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Scope))
            {
                query["Scope"] = request.Scope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sort))
            {
                query["Sort"] = request.Sort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the custom skills of the current user and all system-preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillResponse
        /// </returns>
        public ListSkillResponse ListSkill(ListSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the custom skills of the current user and all system-preset skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSkillResponse
        /// </returns>
        public async Task<ListSkillResponse> ListSkillAsync(ListSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the modules of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceResponse
        /// </returns>
        public ModifyAppInstanceResponse ModifyAppInstanceWithOptions(ModifyAppInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppInstanceShrinkRequest request = new ModifyAppInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                query["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceName))
            {
                query["DBInstanceName"] = request.DBInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the modules of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyAppInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceResponse
        /// </returns>
        public async Task<ModifyAppInstanceResponse> ModifyAppInstanceWithOptionsAsync(ModifyAppInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyAppInstanceShrinkRequest request = new ModifyAppInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Components))
            {
                request.ComponentsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Components, "Components", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentsShrink))
            {
                query["Components"] = request.ComponentsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DBInstanceName))
            {
                query["DBInstanceName"] = request.DBInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceClass))
            {
                query["InstanceClass"] = request.InstanceClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyAppInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyAppInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the modules of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceResponse
        /// </returns>
        public ModifyAppInstanceResponse ModifyAppInstance(ModifyAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyAppInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the modules of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyAppInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyAppInstanceResponse
        /// </returns>
        public async Task<ModifyAppInstanceResponse> ModifyAppInstanceAsync(ModifyAppInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyAppInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the authentication configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceAuthConfigResponse
        /// </returns>
        public ModifyInstanceAuthConfigResponse ModifyInstanceAuthConfigWithOptions(ModifyInstanceAuthConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceAuthConfigShrinkRequest request = new ModifyInstanceAuthConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigList))
            {
                request.ConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigList, "ConfigList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigListShrink))
            {
                query["ConfigList"] = request.ConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceAuthConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAuthConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the authentication configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceAuthConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceAuthConfigResponse
        /// </returns>
        public async Task<ModifyInstanceAuthConfigResponse> ModifyInstanceAuthConfigWithOptionsAsync(ModifyInstanceAuthConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceAuthConfigShrinkRequest request = new ModifyInstanceAuthConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigList))
            {
                request.ConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigList, "ConfigList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigListShrink))
            {
                query["ConfigList"] = request.ConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceAuthConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceAuthConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the authentication configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceAuthConfigResponse
        /// </returns>
        public ModifyInstanceAuthConfigResponse ModifyInstanceAuthConfig(ModifyInstanceAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceAuthConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the authentication configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceAuthConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceAuthConfigResponse
        /// </returns>
        public async Task<ModifyInstanceAuthConfigResponse> ModifyInstanceAuthConfigAsync(ModifyInstanceAuthConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceAuthConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general configurations of an instance, such as network EIP and NAT configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public ModifyInstanceConfigResponse ModifyInstanceConfigWithOptions(ModifyInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["ConfigName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                query["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general configurations of an instance, such as network EIP and NAT configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfigWithOptionsAsync(ModifyInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigName))
            {
                query["ConfigName"] = request.ConfigName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigValue))
            {
                query["ConfigValue"] = request.ConfigValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general configurations of an instance, such as network EIP and NAT configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public ModifyInstanceConfigResponse ModifyInstanceConfig(ModifyInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the general configurations of an instance, such as network EIP and NAT configurations.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceConfigResponse
        /// </returns>
        public async Task<ModifyInstanceConfigResponse> ModifyInstanceConfigAsync(ModifyInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceIpWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceIpWhitelistResponse
        /// </returns>
        public ModifyInstanceIpWhitelistResponse ModifyInstanceIpWhitelistWithOptions(ModifyInstanceIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["IpWhitelist"] = request.IpWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceIpWhitelist",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceIpWhitelistRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceIpWhitelistResponse
        /// </returns>
        public async Task<ModifyInstanceIpWhitelistResponse> ModifyInstanceIpWhitelistWithOptionsAsync(ModifyInstanceIpWhitelistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupName))
            {
                query["GroupName"] = request.GroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["IpWhitelist"] = request.IpWhitelist;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyMode))
            {
                query["ModifyMode"] = request.ModifyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceIpWhitelist",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceIpWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceIpWhitelistResponse
        /// </returns>
        public ModifyInstanceIpWhitelistResponse ModifyInstanceIpWhitelist(ModifyInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceIpWhitelistWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Supported engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceIpWhitelistRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceIpWhitelistResponse
        /// </returns>
        public async Task<ModifyInstanceIpWhitelistResponse> ModifyInstanceIpWhitelistAsync(ModifyInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceIpWhitelistWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceRAGConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRAGConfigResponse
        /// </returns>
        public ModifyInstanceRAGConfigResponse ModifyInstanceRAGConfigWithOptions(ModifyInstanceRAGConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceRAGConfigShrinkRequest request = new ModifyInstanceRAGConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigList))
            {
                request.ConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigList, "ConfigList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigListShrink))
            {
                query["ConfigList"] = request.ConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceRAGConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceRAGConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceRAGConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRAGConfigResponse
        /// </returns>
        public async Task<ModifyInstanceRAGConfigResponse> ModifyInstanceRAGConfigWithOptionsAsync(ModifyInstanceRAGConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceRAGConfigShrinkRequest request = new ModifyInstanceRAGConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigList))
            {
                request.ConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigList, "ConfigList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigListShrink))
            {
                query["ConfigList"] = request.ConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceRAGConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceRAGConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceRAGConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRAGConfigResponse
        /// </returns>
        public ModifyInstanceRAGConfigResponse ModifyInstanceRAGConfig(ModifyInstanceRAGConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceRAGConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the RAG Agent configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyInstanceRAGConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceRAGConfigResponse
        /// </returns>
        public async Task<ModifyInstanceRAGConfigResponse> ModifyInstanceRAGConfigAsync(ModifyInstanceRAGConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceRAGConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceSSLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSSLResponse
        /// </returns>
        public ModifyInstanceSSLResponse ModifyInstanceSSLWithOptions(ModifyInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CAType))
            {
                query["CAType"] = request.CAType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLEnabled))
            {
                query["SSLEnabled"] = request.SSLEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCert))
            {
                query["ServerCert"] = request.ServerCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerKey))
            {
                query["ServerKey"] = request.ServerKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceSSL",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSSLResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceSSLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSSLResponse
        /// </returns>
        public async Task<ModifyInstanceSSLResponse> ModifyInstanceSSLWithOptionsAsync(ModifyInstanceSSLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CAType))
            {
                query["CAType"] = request.CAType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLEnabled))
            {
                query["SSLEnabled"] = request.SSLEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCert))
            {
                query["ServerCert"] = request.ServerCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerKey))
            {
                query["ServerKey"] = request.ServerKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceSSL",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceSSLRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSSLResponse
        /// </returns>
        public ModifyInstanceSSLResponse ModifyInstanceSSL(ModifyInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceSSLWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the SSL configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceSSLRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceSSLResponse
        /// </returns>
        public async Task<ModifyInstanceSSLResponse> ModifyInstanceSSLAsync(ModifyInstanceSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceSSLWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceStorageConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceStorageConfigResponse
        /// </returns>
        public ModifyInstanceStorageConfigResponse ModifyInstanceStorageConfigWithOptions(ModifyInstanceStorageConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceStorageConfigShrinkRequest request = new ModifyInstanceStorageConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigList))
            {
                request.ConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigList, "ConfigList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigListShrink))
            {
                query["ConfigList"] = request.ConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceStorageConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceStorageConfigResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstanceStorageConfigRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceStorageConfigResponse
        /// </returns>
        public async Task<ModifyInstanceStorageConfigResponse> ModifyInstanceStorageConfigWithOptionsAsync(ModifyInstanceStorageConfigRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstanceStorageConfigShrinkRequest request = new ModifyInstanceStorageConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigList))
            {
                request.ConfigListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigList, "ConfigList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigListShrink))
            {
                query["ConfigList"] = request.ConfigListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstanceStorageConfig",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceStorageConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceStorageConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceStorageConfigResponse
        /// </returns>
        public ModifyInstanceStorageConfigResponse ModifyInstanceStorageConfig(ModifyInstanceStorageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceStorageConfigWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the storage configuration of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only Object Storage Service (OSS) is supported.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstanceStorageConfigRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstanceStorageConfigResponse
        /// </returns>
        public async Task<ModifyInstanceStorageConfigResponse> ModifyInstanceStorageConfigAsync(ModifyInstanceStorageConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceStorageConfigWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch modifies the SSL configurations of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstancesSSLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancesSSLResponse
        /// </returns>
        public ModifyInstancesSSLResponse ModifyInstancesSSLWithOptions(ModifyInstancesSSLRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstancesSSLShrinkRequest request = new ModifyInstancesSSLShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceNames))
            {
                request.InstanceNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceNames, "InstanceNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CAType))
            {
                query["CAType"] = request.CAType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNamesShrink))
            {
                query["InstanceNames"] = request.InstanceNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLEnabled))
            {
                query["SSLEnabled"] = request.SSLEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCert))
            {
                query["ServerCert"] = request.ServerCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerKey))
            {
                query["ServerKey"] = request.ServerKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstancesSSL",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstancesSSLResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch modifies the SSL configurations of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifyInstancesSSLRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancesSSLResponse
        /// </returns>
        public async Task<ModifyInstancesSSLResponse> ModifyInstancesSSLWithOptionsAsync(ModifyInstancesSSLRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifyInstancesSSLShrinkRequest request = new ModifyInstancesSSLShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceNames))
            {
                request.InstanceNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceNames, "InstanceNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CAType))
            {
                query["CAType"] = request.CAType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNamesShrink))
            {
                query["InstanceNames"] = request.InstanceNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SSLEnabled))
            {
                query["SSLEnabled"] = request.SSLEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerCert))
            {
                query["ServerCert"] = request.ServerCert;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerKey))
            {
                query["ServerKey"] = request.ServerKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyInstancesSSL",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstancesSSLResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch modifies the SSL configurations of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstancesSSLRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancesSSLResponse
        /// </returns>
        public ModifyInstancesSSLResponse ModifyInstancesSSL(ModifyInstancesSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstancesSSLWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch modifies the SSL configurations of RDS AI application instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyInstancesSSLRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyInstancesSSLResponse
        /// </returns>
        public async Task<ModifyInstancesSSLResponse> ModifyInstancesSSLAsync(ModifyInstancesSSLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstancesSSLWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies message feedback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMessagesFeedbacksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMessagesFeedbacksResponse
        /// </returns>
        public ModifyMessagesFeedbacksResponse ModifyMessagesFeedbacksWithOptions(ModifyMessagesFeedbacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rating))
            {
                query["Rating"] = request.Rating;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMessagesFeedbacks",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMessagesFeedbacksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies message feedback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMessagesFeedbacksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyMessagesFeedbacksResponse
        /// </returns>
        public async Task<ModifyMessagesFeedbacksResponse> ModifyMessagesFeedbacksWithOptionsAsync(ModifyMessagesFeedbacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rating))
            {
                query["Rating"] = request.Rating;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyMessagesFeedbacks",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyMessagesFeedbacksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies message feedback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMessagesFeedbacksRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMessagesFeedbacksResponse
        /// </returns>
        public ModifyMessagesFeedbacksResponse ModifyMessagesFeedbacks(ModifyMessagesFeedbacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyMessagesFeedbacksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies message feedback.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyMessagesFeedbacksRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyMessagesFeedbacksResponse
        /// </returns>
        public async Task<ModifyMessagesFeedbacksResponse> ModifyMessagesFeedbacksAsync(ModifyMessagesFeedbacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyMessagesFeedbacksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifySandboxTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySandboxTemplateResponse
        /// </returns>
        public ModifySandboxTemplateResponse ModifySandboxTemplateWithOptions(ModifySandboxTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySandboxTemplateShrinkRequest request = new ModifySandboxTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCpu))
            {
                query["DefaultCpu"] = request.DefaultCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMemory))
            {
                query["DefaultMemory"] = request.DefaultMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySandboxTemplate",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySandboxTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// ModifySandboxTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifySandboxTemplateResponse
        /// </returns>
        public async Task<ModifySandboxTemplateResponse> ModifySandboxTemplateWithOptionsAsync(ModifySandboxTemplateRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ModifySandboxTemplateShrinkRequest request = new ModifySandboxTemplateShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultCpu))
            {
                query["DefaultCpu"] = request.DefaultCpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DefaultMemory))
            {
                query["DefaultMemory"] = request.DefaultMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Replicas))
            {
                query["Replicas"] = request.Replicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifySandboxTemplate",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifySandboxTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySandboxTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySandboxTemplateResponse
        /// </returns>
        public ModifySandboxTemplateResponse ModifySandboxTemplate(ModifySandboxTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifySandboxTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a sandbox template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS Supabase</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifySandboxTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifySandboxTemplateResponse
        /// </returns>
        public async Task<ModifySandboxTemplateResponse> ModifySandboxTemplateAsync(ModifySandboxTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifySandboxTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScheduledTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledTaskResponse
        /// </returns>
        public ModifyScheduledTaskResponse ModifyScheduledTaskWithOptions(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                query["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionItems))
            {
                query["InspectionItems"] = request.InspectionItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportLanguage))
            {
                query["ReportLanguage"] = request.ReportLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScheduledTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledTaskResponse
        /// </returns>
        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskWithOptionsAsync(ModifyScheduledTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Frequency))
            {
                query["Frequency"] = request.Frequency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InspectionItems))
            {
                query["InspectionItems"] = request.InspectionItems;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportLanguage))
            {
                query["ReportLanguage"] = request.ReportLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduledId))
            {
                query["ScheduledId"] = request.ScheduledId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeRange))
            {
                query["TimeRange"] = request.TimeRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledTask",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledTaskResponse
        /// </returns>
        public ModifyScheduledTaskResponse ModifyScheduledTask(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduledTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies an existing inspection configuration.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ModifyScheduledTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyScheduledTaskResponse
        /// </returns>
        public async Task<ModifyScheduledTaskResponse> ModifyScheduledTaskAsync(ModifyScheduledTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduledTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyWhitelistIpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyWhitelistIpsResponse
        /// </returns>
        public ModifyWhitelistIpsResponse ModifyWhitelistIpsWithOptions(ModifyWhitelistIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["IpWhitelist"] = request.IpWhitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWhitelistIps",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWhitelistIpsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyWhitelistIpsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyWhitelistIpsResponse
        /// </returns>
        public async Task<ModifyWhitelistIpsResponse> ModifyWhitelistIpsWithOptionsAsync(ModifyWhitelistIpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["IpWhitelist"] = request.IpWhitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyWhitelistIps",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyWhitelistIpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyWhitelistIpsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyWhitelistIpsResponse
        /// </returns>
        public ModifyWhitelistIpsResponse ModifyWhitelistIps(ModifyWhitelistIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyWhitelistIpsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP whitelist of an RDS AI Assistant Ultimate Edition instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyWhitelistIpsRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyWhitelistIpsResponse
        /// </returns>
        public async Task<ModifyWhitelistIpsResponse> ModifyWhitelistIpsAsync(ModifyWhitelistIpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyWhitelistIpsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exclusion item for an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an exclusion item for a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public RemoveContextDatabaseSyncJobExclusionResponse RemoveContextDatabaseSyncJobExclusionWithOptions(RemoveContextDatabaseSyncJobExclusionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveContextDatabaseSyncJobExclusion",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveContextDatabaseSyncJobExclusionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exclusion item for an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an exclusion item for a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public async Task<RemoveContextDatabaseSyncJobExclusionResponse> RemoveContextDatabaseSyncJobExclusionWithOptionsAsync(RemoveContextDatabaseSyncJobExclusionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DocumentId))
            {
                query["DocumentId"] = request.DocumentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveContextDatabaseSyncJobExclusion",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveContextDatabaseSyncJobExclusionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exclusion item for an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an exclusion item for a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public RemoveContextDatabaseSyncJobExclusionResponse RemoveContextDatabaseSyncJobExclusion(RemoveContextDatabaseSyncJobExclusionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveContextDatabaseSyncJobExclusionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exclusion item for an import job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes an exclusion item for a job.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RemoveContextDatabaseSyncJobExclusionRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveContextDatabaseSyncJobExclusionResponse
        /// </returns>
        public async Task<RemoveContextDatabaseSyncJobExclusionResponse> RemoveContextDatabaseSyncJobExclusionAsync(RemoveContextDatabaseSyncJobExclusionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveContextDatabaseSyncJobExclusionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameApiKeyResponse
        /// </returns>
        public RenameApiKeyResponse RenameApiKeyWithOptions(RenameApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyName))
            {
                query["KeyName"] = request.KeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RenameApiKeyResponse
        /// </returns>
        public async Task<RenameApiKeyResponse> RenameApiKeyWithOptionsAsync(RenameApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyName))
            {
                query["KeyName"] = request.KeyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleArn))
            {
                query["RoleArn"] = request.RoleArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RenameApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RenameApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameApiKeyResponse
        /// </returns>
        public RenameApiKeyResponse RenameApiKey(RenameApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RenameApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Renames a custom API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RenameApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// RenameApiKeyResponse
        /// </returns>
        public async Task<RenameApiKeyResponse> RenameApiKeyAsync(RenameApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RenameApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public ResetApiKeyResponse ResetApiKeyWithOptions(ResetApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public async Task<ResetApiKeyResponse> ResetApiKeyWithOptionsAsync(ResetApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public ResetApiKeyResponse ResetApiKey(ResetApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetApiKeyResponse
        /// </returns>
        public async Task<ResetApiKeyResponse> ResetApiKeyAsync(ResetApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the keys of an RDS AI instance, including AnonKey, ServiceKey, and JwtSecret. After the reset, the old keys and secret become invalid immediately. Ensure that your applications are updated accordingly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstanceKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetInstanceKeysResponse
        /// </returns>
        public ResetInstanceKeysResponse ResetInstanceKeysWithOptions(ResetInstanceKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetInstanceKeys",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetInstanceKeysResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the keys of an RDS AI instance, including AnonKey, ServiceKey, and JwtSecret. After the reset, the old keys and secret become invalid immediately. Ensure that your applications are updated accordingly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstanceKeysRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetInstanceKeysResponse
        /// </returns>
        public async Task<ResetInstanceKeysResponse> ResetInstanceKeysWithOptionsAsync(ResetInstanceKeysRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetInstanceKeys",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetInstanceKeysResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the keys of an RDS AI instance, including AnonKey, ServiceKey, and JwtSecret. After the reset, the old keys and secret become invalid immediately. Ensure that your applications are updated accordingly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstanceKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetInstanceKeysResponse
        /// </returns>
        public ResetInstanceKeysResponse ResetInstanceKeys(ResetInstanceKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetInstanceKeysWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the keys of an RDS AI instance, including AnonKey, ServiceKey, and JwtSecret. After the reset, the old keys and secret become invalid immediately. Ensure that your applications are updated accordingly.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstanceKeysRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetInstanceKeysResponse
        /// </returns>
        public async Task<ResetInstanceKeysResponse> ResetInstanceKeysAsync(ResetInstanceKeysRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetInstanceKeysWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password and database access password of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only the password of the RDS Supabase Dashboard user can be modified.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstancePasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetInstancePasswordResponse
        /// </returns>
        public ResetInstancePasswordResponse ResetInstancePasswordWithOptions(ResetInstancePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardPassword))
            {
                query["DashboardPassword"] = request.DashboardPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePassword))
            {
                query["DatabasePassword"] = request.DatabasePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetInstancePassword",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetInstancePasswordResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password and database access password of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only the password of the RDS Supabase Dashboard user can be modified.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstancePasswordRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResetInstancePasswordResponse
        /// </returns>
        public async Task<ResetInstancePasswordResponse> ResetInstancePasswordWithOptionsAsync(ResetInstancePasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DashboardPassword))
            {
                query["DashboardPassword"] = request.DashboardPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabasePassword))
            {
                query["DatabasePassword"] = request.DatabasePassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetInstancePassword",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetInstancePasswordResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password and database access password of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only the password of the RDS Supabase Dashboard user can be modified.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstancePasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetInstancePasswordResponse
        /// </returns>
        public ResetInstancePasswordResponse ResetInstancePassword(ResetInstancePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetInstancePasswordWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Resets the logon password and database access password of an RDS AI application instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// <remarks>
        /// <para>Currently, only the password of the RDS Supabase Dashboard user can be modified.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// ResetInstancePasswordRequest
        /// </param>
        /// 
        /// <returns>
        /// ResetInstancePasswordResponse
        /// </returns>
        public async Task<ResetInstancePasswordResponse> ResetInstancePasswordAsync(ResetInstancePasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetInstancePasswordWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an ApsaraDB RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public RestartInstanceResponse RestartInstanceWithOptions(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an ApsaraDB RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public async Task<RestartInstanceResponse> RestartInstanceWithOptionsAsync(RestartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an ApsaraDB RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public RestartInstanceResponse RestartInstance(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an ApsaraDB RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartInstanceResponse
        /// </returns>
        public async Task<RestartInstanceResponse> RestartInstanceAsync(RestartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于快照重试失败明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 重试会基于失败项生成新的 Run，原 Run 状态保持不变。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryFailedContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryFailedContextDatabaseSyncRunResponse
        /// </returns>
        public RetryFailedContextDatabaseSyncRunResponse RetryFailedContextDatabaseSyncRunWithOptions(RetryFailedContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryFailedContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryFailedContextDatabaseSyncRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于快照重试失败明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 重试会基于失败项生成新的 Run，原 Run 状态保持不变。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryFailedContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryFailedContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<RetryFailedContextDatabaseSyncRunResponse> RetryFailedContextDatabaseSyncRunWithOptionsAsync(RetryFailedContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["RunId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryFailedContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryFailedContextDatabaseSyncRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于快照重试失败明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 重试会基于失败项生成新的 Run，原 Run 状态保持不变。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryFailedContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryFailedContextDatabaseSyncRunResponse
        /// </returns>
        public RetryFailedContextDatabaseSyncRunResponse RetryFailedContextDatabaseSyncRun(RetryFailedContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RetryFailedContextDatabaseSyncRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>基于快照重试失败明细</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 重试会基于失败项生成新的 Run，原 Run 状态保持不变。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RetryFailedContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// RetryFailedContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<RetryFailedContextDatabaseSyncRunResponse> RetryFailedContextDatabaseSyncRunAsync(RetryFailedContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RetryFailedContextDatabaseSyncRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an API key for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Revokes an API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeContextDatabaseApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeContextDatabaseApiKeyResponse
        /// </returns>
        public RevokeContextDatabaseApiKeyResponse RevokeContextDatabaseApiKeyWithOptions(RevokeContextDatabaseApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeContextDatabaseApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeContextDatabaseApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an API key for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Revokes an API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeContextDatabaseApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RevokeContextDatabaseApiKeyResponse
        /// </returns>
        public async Task<RevokeContextDatabaseApiKeyResponse> RevokeContextDatabaseApiKeyWithOptionsAsync(RevokeContextDatabaseApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeContextDatabaseApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeContextDatabaseApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an API key for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Revokes an API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeContextDatabaseApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeContextDatabaseApiKeyResponse
        /// </returns>
        public RevokeContextDatabaseApiKeyResponse RevokeContextDatabaseApiKey(RevokeContextDatabaseApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RevokeContextDatabaseApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Revokes an API key for a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Revokes an API key.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// RevokeContextDatabaseApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// RevokeContextDatabaseApiKeyResponse
        /// </returns>
        public async Task<RevokeContextDatabaseApiKeyResponse> RevokeContextDatabaseApiKeyAsync(RevokeContextDatabaseApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RevokeContextDatabaseApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncRunResponse
        /// </returns>
        public StartContextDatabaseSyncRunResponse StartContextDatabaseSyncRunWithOptions(StartContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartContextDatabaseSyncRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncRunRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<StartContextDatabaseSyncRunResponse> StartContextDatabaseSyncRunWithOptionsAsync(StartContextDatabaseSyncRunRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartContextDatabaseSyncRun",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartContextDatabaseSyncRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncRunResponse
        /// </returns>
        public StartContextDatabaseSyncRunResponse StartContextDatabaseSyncRun(StartContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartContextDatabaseSyncRunWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Manually triggers a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncRunRequest
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncRunResponse
        /// </returns>
        public async Task<StartContextDatabaseSyncRunResponse> StartContextDatabaseSyncRunAsync(StartContextDatabaseSyncRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartContextDatabaseSyncRunWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a snapshot discovery task for data selection scope configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically. Discovery is an asynchronous operation. The operation returns a discovery task identifier. Poll for results to retrieve SelectedNodeKeys.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncSourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncSourceDiscoveryResponse
        /// </returns>
        public StartContextDatabaseSyncSourceDiscoveryResponse StartContextDatabaseSyncSourceDiscoveryWithOptions(StartContextDatabaseSyncSourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartContextDatabaseSyncSourceDiscovery",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartContextDatabaseSyncSourceDiscoveryResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a snapshot discovery task for data selection scope configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically. Discovery is an asynchronous operation. The operation returns a discovery task identifier. Poll for results to retrieve SelectedNodeKeys.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncSourceDiscoveryRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncSourceDiscoveryResponse
        /// </returns>
        public async Task<StartContextDatabaseSyncSourceDiscoveryResponse> StartContextDatabaseSyncSourceDiscoveryWithOptionsAsync(StartContextDatabaseSyncSourceDiscoveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartContextDatabaseSyncSourceDiscovery",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartContextDatabaseSyncSourceDiscoveryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a snapshot discovery task for data selection scope configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically. Discovery is an asynchronous operation. The operation returns a discovery task identifier. Poll for results to retrieve SelectedNodeKeys.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncSourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncSourceDiscoveryResponse
        /// </returns>
        public StartContextDatabaseSyncSourceDiscoveryResponse StartContextDatabaseSyncSourceDiscovery(StartContextDatabaseSyncSourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartContextDatabaseSyncSourceDiscoveryWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a snapshot discovery task for data selection scope configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence by passing a ClientToken. If no ClientToken is provided, the backend generates one automatically. Discovery is an asynchronous operation. The operation returns a discovery task identifier. Poll for results to retrieve SelectedNodeKeys.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartContextDatabaseSyncSourceDiscoveryRequest
        /// </param>
        /// 
        /// <returns>
        /// StartContextDatabaseSyncSourceDiscoveryResponse
        /// </returns>
        public async Task<StartContextDatabaseSyncSourceDiscoveryResponse> StartContextDatabaseSyncSourceDiscoveryAsync(StartContextDatabaseSyncSourceDiscoveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartContextDatabaseSyncSourceDiscoveryWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an RDS AI application instance that is in the Stopped state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an RDS AI application instance that is in the Stopped state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an RDS AI application instance that is in the Stopped state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an RDS AI application instance that is in the Stopped state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StartInstanceResponse
        /// </returns>
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses an RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses an RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BranchName))
            {
                query["BranchName"] = request.BranchName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopInstance",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses an RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Pauses an RDS AI application instance that is in the Running state.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para>RDS PostgreSQL</para>
        /// <h3>Related feature documentation</h3>
        /// <para><a href="https://help.aliyun.com/document_detail/2938735.html">RDS Supabase</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// StopInstanceResponse
        /// </returns>
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quota of an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateApiKeyQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyQuotaResponse
        /// </returns>
        public UpdateApiKeyQuotaResponse UpdateApiKeyQuotaWithOptions(UpdateApiKeyQuotaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApiKeyQuotaShrinkRequest request = new UpdateApiKeyQuotaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiKeyQuota",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiKeyQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quota of an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateApiKeyQuotaRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyQuotaResponse
        /// </returns>
        public async Task<UpdateApiKeyQuotaResponse> UpdateApiKeyQuotaWithOptionsAsync(UpdateApiKeyQuotaRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApiKeyQuotaShrinkRequest request = new UpdateApiKeyQuotaShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Keys))
            {
                request.KeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Keys, "Keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeysShrink))
            {
                query["Keys"] = request.KeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiKeyQuota",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiKeyQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quota of an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApiKeyQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyQuotaResponse
        /// </returns>
        public UpdateApiKeyQuotaResponse UpdateApiKeyQuota(UpdateApiKeyQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApiKeyQuotaWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the quota of an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateApiKeyQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateApiKeyQuotaResponse
        /// </returns>
        public async Task<UpdateApiKeyQuotaResponse> UpdateApiKeyQuotaAsync(UpdateApiKeyQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApiKeyQuotaWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the API key of a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the display metadata of an API key. At least one of Name or Description must be specified. The plaintext key is not reissued.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseApiKeyResponse
        /// </returns>
        public UpdateContextDatabaseApiKeyResponse UpdateContextDatabaseApiKeyWithOptions(UpdateContextDatabaseApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseApiKeyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the API key of a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the display metadata of an API key. At least one of Name or Description must be specified. The plaintext key is not reissued.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseApiKeyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseApiKeyResponse
        /// </returns>
        public async Task<UpdateContextDatabaseApiKeyResponse> UpdateContextDatabaseApiKeyWithOptionsAsync(UpdateContextDatabaseApiKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyId))
            {
                query["KeyId"] = request.KeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseApiKey",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseApiKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the API key of a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the display metadata of an API key. At least one of Name or Description must be specified. The plaintext key is not reissued.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseApiKeyResponse
        /// </returns>
        public UpdateContextDatabaseApiKeyResponse UpdateContextDatabaseApiKey(UpdateContextDatabaseApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseApiKeyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the API key of a context database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the display metadata of an API key. At least one of Name or Description must be specified. The plaintext key is not reissued.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseApiKeyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseApiKeyResponse
        /// </returns>
        public async Task<UpdateContextDatabaseApiKeyResponse> UpdateContextDatabaseApiKeyAsync(UpdateContextDatabaseApiKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseApiKeyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the role or status of a member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseMemberResponse
        /// </returns>
        public UpdateContextDatabaseMemberResponse UpdateContextDatabaseMemberWithOptions(UpdateContextDatabaseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseMember",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseMemberResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the role or status of a member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseMemberRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseMemberResponse
        /// </returns>
        public async Task<UpdateContextDatabaseMemberResponse> UpdateContextDatabaseMemberWithOptionsAsync(UpdateContextDatabaseMemberRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MemberId))
            {
                query["MemberId"] = request.MemberId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Role))
            {
                query["Role"] = request.Role;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseMember",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseMemberResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the role or status of a member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseMemberResponse
        /// </returns>
        public UpdateContextDatabaseMemberResponse UpdateContextDatabaseMember(UpdateContextDatabaseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseMemberWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a context database member.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the role or status of a member.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseMemberRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseMemberResponse
        /// </returns>
        public async Task<UpdateContextDatabaseMemberResponse> UpdateContextDatabaseMemberAsync(UpdateContextDatabaseMemberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseMemberWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionResponse
        /// </returns>
        public UpdateContextDatabaseSyncConnectionResponse UpdateContextDatabaseSyncConnectionWithOptions(UpdateContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncConnectionResponse> UpdateContextDatabaseSyncConnectionWithOptionsAsync(UpdateContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayName))
            {
                query["DisplayName"] = request.DisplayName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionResponse
        /// </returns>
        public UpdateContextDatabaseSyncConnectionResponse UpdateContextDatabaseSyncConnection(UpdateContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseSyncConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新连接元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncConnectionResponse> UpdateContextDatabaseSyncConnectionAsync(UpdateContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseSyncConnectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单独轮换连接凭据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncConnectionCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionCredentialResponse
        /// </returns>
        public UpdateContextDatabaseSyncConnectionCredentialResponse UpdateContextDatabaseSyncConnectionCredentialWithOptions(UpdateContextDatabaseSyncConnectionCredentialRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncConnectionCredentialShrinkRequest request = new UpdateContextDatabaseSyncConnectionCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Credentials))
            {
                request.CredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Credentials, "Credentials", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialsShrink))
            {
                query["Credentials"] = request.CredentialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncConnectionCredential",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncConnectionCredentialResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单独轮换连接凭据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncConnectionCredentialRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionCredentialResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncConnectionCredentialResponse> UpdateContextDatabaseSyncConnectionCredentialWithOptionsAsync(UpdateContextDatabaseSyncConnectionCredentialRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncConnectionCredentialShrinkRequest request = new UpdateContextDatabaseSyncConnectionCredentialShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Credentials))
            {
                request.CredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Credentials, "Credentials", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CredentialsShrink))
            {
                query["Credentials"] = request.CredentialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncConnectionCredential",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncConnectionCredentialResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单独轮换连接凭据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncConnectionCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionCredentialResponse
        /// </returns>
        public UpdateContextDatabaseSyncConnectionCredentialResponse UpdateContextDatabaseSyncConnectionCredential(UpdateContextDatabaseSyncConnectionCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseSyncConnectionCredentialWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>单独轮换连接凭据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncConnectionCredentialRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncConnectionCredentialResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncConnectionCredentialResponse> UpdateContextDatabaseSyncConnectionCredentialAsync(UpdateContextDatabaseSyncConnectionCredentialRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseSyncConnectionCredentialWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 Target 为隐含概念，调用方只需传入 KnowledgeBaseId，后端自动创建/匹配 Target。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobResponse
        /// </returns>
        public UpdateContextDatabaseSyncJobResponse UpdateContextDatabaseSyncJobWithOptions(UpdateContextDatabaseSyncJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncJobShrinkRequest request = new UpdateContextDatabaseSyncJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filters))
            {
                request.FiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filters, "Filters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiltersShrink))
            {
                query["Filters"] = request.FiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseId))
            {
                query["TargetKnowledgeBaseId"] = request.TargetKnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseName))
            {
                query["TargetKnowledgeBaseName"] = request.TargetKnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 Target 为隐含概念，调用方只需传入 KnowledgeBaseId，后端自动创建/匹配 Target。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncJobResponse> UpdateContextDatabaseSyncJobWithOptionsAsync(UpdateContextDatabaseSyncJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncJobShrinkRequest request = new UpdateContextDatabaseSyncJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Filters))
            {
                request.FiltersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Filters, "Filters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enabled))
            {
                query["Enabled"] = request.Enabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FiltersShrink))
            {
                query["Filters"] = request.FiltersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseId))
            {
                query["TargetKnowledgeBaseId"] = request.TargetKnowledgeBaseId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetKnowledgeBaseName))
            {
                query["TargetKnowledgeBaseName"] = request.TargetKnowledgeBaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncJob",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 Target 为隐含概念，调用方只需传入 KnowledgeBaseId，后端自动创建/匹配 Target。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobResponse
        /// </returns>
        public UpdateContextDatabaseSyncJobResponse UpdateContextDatabaseSyncJob(UpdateContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseSyncJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 元数据</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。 Target 为隐含概念，调用方只需传入 KnowledgeBaseId，后端自动创建/匹配 Target。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncJobRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncJobResponse> UpdateContextDatabaseSyncJobAsync(UpdateContextDatabaseSyncJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseSyncJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 调度配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public UpdateContextDatabaseSyncJobScheduleResponse UpdateContextDatabaseSyncJobScheduleWithOptions(UpdateContextDatabaseSyncJobScheduleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncJobScheduleShrinkRequest request = new UpdateContextDatabaseSyncJobScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DailyTimes))
            {
                request.DailyTimesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DailyTimes, "DailyTimes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DailyTimesShrink))
            {
                query["DailyTimes"] = request.DailyTimesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalMinutes))
            {
                query["IntervalMinutes"] = request.IntervalMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissedPolicy))
            {
                query["MissedPolicy"] = request.MissedPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncJobSchedule",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncJobScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 调度配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncJobScheduleResponse> UpdateContextDatabaseSyncJobScheduleWithOptionsAsync(UpdateContextDatabaseSyncJobScheduleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncJobScheduleShrinkRequest request = new UpdateContextDatabaseSyncJobScheduleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DailyTimes))
            {
                request.DailyTimesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DailyTimes, "DailyTimes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DailyTimesShrink))
            {
                query["DailyTimes"] = request.DailyTimesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IntervalMinutes))
            {
                query["IntervalMinutes"] = request.IntervalMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MissedPolicy))
            {
                query["MissedPolicy"] = request.MissedPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncJobSchedule",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncJobScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 调度配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public UpdateContextDatabaseSyncJobScheduleResponse UpdateContextDatabaseSyncJobSchedule(UpdateContextDatabaseSyncJobScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseSyncJobScheduleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新 Job 调度配置</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>写操作可传入 ClientToken 实现幂等；未传时由后端自动生成。</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncJobScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncJobScheduleResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncJobScheduleResponse> UpdateContextDatabaseSyncJobScheduleAsync(UpdateContextDatabaseSyncJobScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseSyncJobScheduleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceResponse
        /// </returns>
        public UpdateContextDatabaseSyncSourceResponse UpdateContextDatabaseSyncSourceWithOptions(UpdateContextDatabaseSyncSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncSourceShrinkRequest request = new UpdateContextDatabaseSyncSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceConfig))
            {
                request.SourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceConfig, "SourceConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceConfigShrink))
            {
                query["SourceConfig"] = request.SourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncSourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncSourceResponse> UpdateContextDatabaseSyncSourceWithOptionsAsync(UpdateContextDatabaseSyncSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncSourceShrinkRequest request = new UpdateContextDatabaseSyncSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceConfig))
            {
                request.SourceConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceConfig, "SourceConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceConfigShrink))
            {
                query["SourceConfig"] = request.SourceConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncSource",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceResponse
        /// </returns>
        public UpdateContextDatabaseSyncSourceResponse UpdateContextDatabaseSyncSource(UpdateContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseSyncSourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the metadata of a data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Write operations support idempotence via ClientToken. If ClientToken is not provided, the backend generates one automatically.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncSourceResponse> UpdateContextDatabaseSyncSourceAsync(UpdateContextDatabaseSyncSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseSyncSourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the explicit node selection for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can pass the ClientToken parameter to ensure idempotency. If this parameter is not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public UpdateContextDatabaseSyncSourceSelectionResponse UpdateContextDatabaseSyncSourceSelectionWithOptions(UpdateContextDatabaseSyncSourceSelectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncSourceSelectionShrinkRequest request = new UpdateContextDatabaseSyncSourceSelectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedNodeKeys))
            {
                request.SelectedNodeKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedNodeKeys, "SelectedNodeKeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedNodeKeysShrink))
            {
                query["SelectedNodeKeys"] = request.SelectedNodeKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionPolicy))
            {
                query["SelectionPolicy"] = request.SelectionPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncSourceSelection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncSourceSelectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the explicit node selection for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can pass the ClientToken parameter to ensure idempotency. If this parameter is not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncSourceSelectionResponse> UpdateContextDatabaseSyncSourceSelectionWithOptionsAsync(UpdateContextDatabaseSyncSourceSelectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateContextDatabaseSyncSourceSelectionShrinkRequest request = new UpdateContextDatabaseSyncSourceSelectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SelectedNodeKeys))
            {
                request.SelectedNodeKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SelectedNodeKeys, "SelectedNodeKeys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedNodeKeysShrink))
            {
                query["SelectedNodeKeys"] = request.SelectedNodeKeysShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectionPolicy))
            {
                query["SelectionPolicy"] = request.SelectionPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                query["SourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseSyncSourceSelection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseSyncSourceSelectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the explicit node selection for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can pass the ClientToken parameter to ensure idempotency. If this parameter is not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public UpdateContextDatabaseSyncSourceSelectionResponse UpdateContextDatabaseSyncSourceSelection(UpdateContextDatabaseSyncSourceSelectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseSyncSourceSelectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the explicit node selection for the data selection scope.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For write operations, you can pass the ClientToken parameter to ensure idempotency. If this parameter is not provided, the backend automatically generates one.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseSyncSourceSelectionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseSyncSourceSelectionResponse
        /// </returns>
        public async Task<UpdateContextDatabaseSyncSourceSelectionResponse> UpdateContextDatabaseSyncSourceSelectionAsync(UpdateContextDatabaseSyncSourceSelectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseSyncSourceSelectionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the name of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseWorkspaceResponse
        /// </returns>
        public UpdateContextDatabaseWorkspaceResponse UpdateContextDatabaseWorkspaceWithOptions(UpdateContextDatabaseWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseWorkspace",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseWorkspaceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the name of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseWorkspaceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseWorkspaceResponse
        /// </returns>
        public async Task<UpdateContextDatabaseWorkspaceResponse> UpdateContextDatabaseWorkspaceWithOptionsAsync(UpdateContextDatabaseWorkspaceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceName))
            {
                query["WorkspaceName"] = request.WorkspaceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContextDatabaseWorkspace",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContextDatabaseWorkspaceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the name of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseWorkspaceResponse
        /// </returns>
        public UpdateContextDatabaseWorkspaceResponse UpdateContextDatabaseWorkspace(UpdateContextDatabaseWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContextDatabaseWorkspaceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a ContextDB workspace.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Modifies the name of a workspace.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContextDatabaseWorkspaceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContextDatabaseWorkspaceResponse
        /// </returns>
        public async Task<UpdateContextDatabaseWorkspaceResponse> UpdateContextDatabaseWorkspaceAsync(UpdateContextDatabaseWorkspaceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContextDatabaseWorkspaceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Custom Agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAgentResponse
        /// </returns>
        public UpdateCustomAgentResponse UpdateCustomAgentWithOptions(UpdateCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCustomAgentShrinkRequest request = new UpdateCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SkillIds))
            {
                request.SkillIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SkillIds, "SkillIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tools))
            {
                request.ToolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tools, "Tools", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTools))
            {
                query["EnableTools"] = request.EnableTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIdsShrink))
            {
                query["SkillIds"] = request.SkillIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                query["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolsShrink))
            {
                query["Tools"] = request.ToolsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Custom Agent.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateCustomAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAgentResponse
        /// </returns>
        public async Task<UpdateCustomAgentResponse> UpdateCustomAgentWithOptionsAsync(UpdateCustomAgentRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCustomAgentShrinkRequest request = new UpdateCustomAgentShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SkillIds))
            {
                request.SkillIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SkillIds, "SkillIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tools))
            {
                request.ToolsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tools, "Tools", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomAgentId))
            {
                query["CustomAgentId"] = request.CustomAgentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableTools))
            {
                query["EnableTools"] = request.EnableTools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillIdsShrink))
            {
                query["SkillIds"] = request.SkillIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemPrompt))
            {
                query["SystemPrompt"] = request.SystemPrompt;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ToolsShrink))
            {
                query["Tools"] = request.ToolsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCustomAgent",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateCustomAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Custom Agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAgentResponse
        /// </returns>
        public UpdateCustomAgentResponse UpdateCustomAgent(UpdateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCustomAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a Custom Agent.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateCustomAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateCustomAgentResponse
        /// </returns>
        public async Task<UpdateCustomAgentResponse> UpdateCustomAgentAsync(UpdateCustomAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCustomAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the alert threshold percentage for an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateMOQuotaAlertThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMOQuotaAlertThresholdResponse
        /// </returns>
        public UpdateMOQuotaAlertThresholdResponse UpdateMOQuotaAlertThresholdWithOptions(UpdateMOQuotaAlertThresholdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMOQuotaAlertThresholdShrinkRequest request = new UpdateMOQuotaAlertThresholdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Apikey))
            {
                request.ApikeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Apikey, "Apikey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApikeyShrink))
            {
                query["Apikey"] = request.ApikeyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMOQuotaAlertThreshold",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMOQuotaAlertThresholdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the alert threshold percentage for an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateMOQuotaAlertThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMOQuotaAlertThresholdResponse
        /// </returns>
        public async Task<UpdateMOQuotaAlertThresholdResponse> UpdateMOQuotaAlertThresholdWithOptionsAsync(UpdateMOQuotaAlertThresholdRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateMOQuotaAlertThresholdShrinkRequest request = new UpdateMOQuotaAlertThresholdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Apikey))
            {
                request.ApikeyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Apikey, "Apikey", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApikeyShrink))
            {
                query["Apikey"] = request.ApikeyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMOQuotaAlertThreshold",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMOQuotaAlertThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the alert threshold percentage for an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMOQuotaAlertThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMOQuotaAlertThresholdResponse
        /// </returns>
        public UpdateMOQuotaAlertThresholdResponse UpdateMOQuotaAlertThreshold(UpdateMOQuotaAlertThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMOQuotaAlertThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the alert threshold percentage for an API key.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Applicable engine</h3>
        /// <para><a href="https://www.alibabacloud.com/help/en/rds/apsaradb-rds-for-mysql/rds-copilot-ultra">RDS AI Assistant Ultimate Edition</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateMOQuotaAlertThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMOQuotaAlertThresholdResponse
        /// </returns>
        public async Task<UpdateMOQuotaAlertThresholdResponse> UpdateMOQuotaAlertThresholdAsync(UpdateMOQuotaAlertThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMOQuotaAlertThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public UpdateSkillResponse UpdateSkillWithOptions(UpdateSkillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillShrinkRequest request = new UpdateSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dbtypes))
            {
                request.DbtypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dbtypes, "Dbtypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbtypesShrink))
            {
                query["Dbtypes"] = request.DbtypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateNote))
            {
                query["UpdateNote"] = request.UpdateNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["UploadId"] = request.UploadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadToken))
            {
                query["UploadToken"] = request.UploadToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateSkillRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public async Task<UpdateSkillResponse> UpdateSkillWithOptionsAsync(UpdateSkillRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateSkillShrinkRequest request = new UpdateSkillShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Content))
            {
                request.ContentShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Content, "Content", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Dbtypes))
            {
                request.DbtypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Dbtypes, "Dbtypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContentShrink))
            {
                query["Content"] = request.ContentShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbtypesShrink))
            {
                query["Dbtypes"] = request.DbtypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkillId))
            {
                query["SkillId"] = request.SkillId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateNote))
            {
                query["UpdateNote"] = request.UpdateNote;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadId))
            {
                query["UploadId"] = request.UploadId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UploadToken))
            {
                query["UploadToken"] = request.UploadToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSkill",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSkillResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public UpdateSkillResponse UpdateSkill(UpdateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSkillWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a specified Skill.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSkillRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSkillResponse
        /// </returns>
        public async Task<UpdateSkillResponse> UpdateSkillAsync(UpdateSkillRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSkillWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates datasource credentials and authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the connection credentials and authorization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyContextDatabaseSyncConnectionResponse
        /// </returns>
        public VerifyContextDatabaseSyncConnectionResponse VerifyContextDatabaseSyncConnectionWithOptions(VerifyContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyContextDatabaseSyncConnectionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates datasource credentials and authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the connection credentials and authorization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyContextDatabaseSyncConnectionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VerifyContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<VerifyContextDatabaseSyncConnectionResponse> VerifyContextDatabaseSyncConnectionWithOptionsAsync(VerifyContextDatabaseSyncConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionId))
            {
                query["ConnectionId"] = request.ConnectionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["WorkspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyContextDatabaseSyncConnection",
                Version = "2025-05-07",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyContextDatabaseSyncConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates datasource credentials and authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the connection credentials and authorization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyContextDatabaseSyncConnectionResponse
        /// </returns>
        public VerifyContextDatabaseSyncConnectionResponse VerifyContextDatabaseSyncConnection(VerifyContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyContextDatabaseSyncConnectionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Validates datasource credentials and authorization.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Validates the connection credentials and authorization.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VerifyContextDatabaseSyncConnectionRequest
        /// </param>
        /// 
        /// <returns>
        /// VerifyContextDatabaseSyncConnectionResponse
        /// </returns>
        public async Task<VerifyContextDatabaseSyncConnectionResponse> VerifyContextDatabaseSyncConnectionAsync(VerifyContextDatabaseSyncConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyContextDatabaseSyncConnectionWithOptionsAsync(request, runtime);
        }

    }
}
