// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.IaCService20210806.Models;

namespace AlibabaCloud.SDK.IaCService20210806
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("iacservice", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>分组关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateGroupResponse
        /// </returns>
        public AssociateGroupResponse AssociateGroupWithOptions(string groupId, AssociateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
                Action = "AssociateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/associate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分组关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateGroupResponse
        /// </returns>
        public async Task<AssociateGroupResponse> AssociateGroupWithOptionsAsync(string groupId, AssociateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
                Action = "AssociateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/associate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分组关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateGroupResponse
        /// </returns>
        public AssociateGroupResponse AssociateGroup(string groupId, AssociateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AssociateGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>分组关联</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateGroupResponse
        /// </returns>
        public async Task<AssociateGroupResponse> AssociateGroupAsync(string groupId, AssociateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AssociateGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将参数集关联资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateParameterSetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateParameterSetResponse
        /// </returns>
        public AssociateParameterSetResponse AssociateParameterSetWithOptions(AssociateParameterSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterSetIds))
            {
                body["parameterSetIds"] = request.ParameterSetIds;
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
                Action = "AssociateParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/operations/associate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateParameterSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将参数集关联资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateParameterSetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AssociateParameterSetResponse
        /// </returns>
        public async Task<AssociateParameterSetResponse> AssociateParameterSetWithOptionsAsync(AssociateParameterSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterSetIds))
            {
                body["parameterSetIds"] = request.ParameterSetIds;
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
                Action = "AssociateParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/operations/associate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AssociateParameterSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将参数集关联资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateParameterSetRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateParameterSetResponse
        /// </returns>
        public AssociateParameterSetResponse AssociateParameterSet(AssociateParameterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AssociateParameterSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将参数集关联资源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AssociateParameterSetRequest
        /// </param>
        /// 
        /// <returns>
        /// AssociateParameterSetResponse
        /// </returns>
        public async Task<AssociateParameterSetResponse> AssociateParameterSetAsync(AssociateParameterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AssociateParameterSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者挂载到任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachRabbitmqPublisherRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachRabbitmqPublisherResponse
        /// </returns>
        public AttachRabbitmqPublisherResponse AttachRabbitmqPublisherWithOptions(string publisherId, AttachRabbitmqPublisherRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId) + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachRabbitmqPublisherResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者挂载到任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachRabbitmqPublisherRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachRabbitmqPublisherResponse
        /// </returns>
        public async Task<AttachRabbitmqPublisherResponse> AttachRabbitmqPublisherWithOptionsAsync(string publisherId, AttachRabbitmqPublisherRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId) + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachRabbitmqPublisherResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者挂载到任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachRabbitmqPublisherRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachRabbitmqPublisherResponse
        /// </returns>
        public AttachRabbitmqPublisherResponse AttachRabbitmqPublisher(string publisherId, AttachRabbitmqPublisherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachRabbitmqPublisherWithOptions(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者挂载到任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AttachRabbitmqPublisherRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachRabbitmqPublisherResponse
        /// </returns>
        public async Task<AttachRabbitmqPublisherResponse> AttachRabbitmqPublisherAsync(string publisherId, AttachRabbitmqPublisherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachRabbitmqPublisherWithOptionsAsync(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消执行</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelProjectBuildResponse
        /// </returns>
        public CancelProjectBuildResponse CancelProjectBuildWithOptions(string projectId, string projectBuildId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelProjectBuild",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectBuildId) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProjectBuildResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消执行</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelProjectBuildResponse
        /// </returns>
        public async Task<CancelProjectBuildResponse> CancelProjectBuildWithOptionsAsync(string projectId, string projectBuildId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelProjectBuild",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectBuildId) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelProjectBuildResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消执行</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelProjectBuildResponse
        /// </returns>
        public CancelProjectBuildResponse CancelProjectBuild(string projectId, string projectBuildId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelProjectBuildWithOptions(projectId, projectBuildId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消执行</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelProjectBuildResponse
        /// </returns>
        public async Task<CancelProjectBuildResponse> CancelProjectBuildAsync(string projectId, string projectBuildId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelProjectBuildWithOptionsAsync(projectId, projectBuildId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRamPolicyExportTaskResponse
        /// </returns>
        public CancelRamPolicyExportTaskResponse CancelRamPolicyExportTaskWithOptions(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRamPolicyExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRamPolicyExportTaskResponse
        /// </returns>
        public async Task<CancelRamPolicyExportTaskResponse> CancelRamPolicyExportTaskWithOptionsAsync(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/cancel",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRamPolicyExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelRamPolicyExportTaskResponse
        /// </returns>
        public CancelRamPolicyExportTaskResponse CancelRamPolicyExportTask(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelRamPolicyExportTaskWithOptions(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// CancelRamPolicyExportTaskResponse
        /// </returns>
        public async Task<CancelRamPolicyExportTaskResponse> CancelRamPolicyExportTaskAsync(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelRamPolicyExportTaskWithOptionsAsync(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelResourceExportTaskResponse
        /// </returns>
        public CancelResourceExportTaskResponse CancelResourceExportTaskWithOptions(string exportTaskId, CancelResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/cancel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelResourceExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelResourceExportTaskResponse
        /// </returns>
        public async Task<CancelResourceExportTaskResponse> CancelResourceExportTaskWithOptionsAsync(string exportTaskId, CancelResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/cancel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelResourceExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelResourceExportTaskResponse
        /// </returns>
        public CancelResourceExportTaskResponse CancelResourceExportTask(string exportTaskId, CancelResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelResourceExportTaskWithOptions(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelResourceExportTaskResponse
        /// </returns>
        public async Task<CancelResourceExportTaskResponse> CancelResourceExportTaskAsync(string exportTaskId, CancelResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelResourceExportTaskWithOptionsAsync(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验资源名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceNameResponse
        /// </returns>
        public CheckResourceNameResponse CheckResourceNameWithOptions(CheckResourceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResourceName",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/check/name",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourceNameResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验资源名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceNameRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceNameResponse
        /// </returns>
        public async Task<CheckResourceNameResponse> CheckResourceNameWithOptionsAsync(CheckResourceNameRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Id))
            {
                query["id"] = request.Id;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentId))
            {
                query["parentId"] = request.ParentId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckResourceName",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/check/name",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckResourceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验资源名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceNameResponse
        /// </returns>
        public CheckResourceNameResponse CheckResourceName(CheckResourceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckResourceNameWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>校验资源名称</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckResourceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckResourceNameResponse
        /// </returns>
        public async Task<CheckResourceNameResponse> CheckResourceNameAsync(CheckResourceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckResourceNameWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneGroupResponse
        /// </returns>
        public CloneGroupResponse CloneGroupWithOptions(string groupId, CloneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                body["resourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneGroupResponse
        /// </returns>
        public async Task<CloneGroupResponse> CloneGroupWithOptionsAsync(string groupId, CloneGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceTypes))
            {
                body["resourceTypes"] = request.ResourceTypes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/clone",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneGroupResponse
        /// </returns>
        public CloneGroupResponse CloneGroup(string groupId, CloneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneGroupResponse
        /// </returns>
        public async Task<CloneGroupResponse> CloneGroupAsync(string groupId, CloneGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneModuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneModuleResponse
        /// </returns>
        public CloneModuleResponse CloneModuleWithOptions(CloneModuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleSource))
            {
                body["moduleSource"] = request.ModuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/operations/clone",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneModuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneModuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CloneModuleResponse
        /// </returns>
        public async Task<CloneModuleResponse> CloneModuleWithOptionsAsync(CloneModuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleSource))
            {
                body["moduleSource"] = request.ModuleSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CloneModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/operations/clone",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CloneModuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneModuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneModuleResponse
        /// </returns>
        public CloneModuleResponse CloneModule(CloneModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CloneModuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>克隆模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CloneModuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CloneModuleResponse
        /// </returns>
        public async Task<CloneModuleResponse> CloneModuleAsync(CloneModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CloneModuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthorizationResponse
        /// </returns>
        public CreateAuthorizationResponse CreateAuthorizationWithOptions(CreateAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthorization",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthorizationResponse
        /// </returns>
        public async Task<CreateAuthorizationResponse> CreateAuthorizationWithOptionsAsync(CreateAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                body["uid"] = request.Uid;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAuthorization",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthorizationResponse
        /// </returns>
        public CreateAuthorizationResponse CreateAuthorization(CreateAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAuthorizationResponse
        /// </returns>
        public async Task<CreateAuthorizationResponse> CreateAuthorizationAsync(CreateAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExplorerTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExplorerTaskResponse
        /// </returns>
        public CreateExplorerTaskResponse CreateExplorerTaskWithOptions(CreateExplorerTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["InitModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["TerraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["initModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPropertyValidation))
            {
                body["skipPropertyValidation"] = request.SkipPropertyValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerValue))
            {
                body["triggerValue"] = request.TriggerValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExplorerTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExplorerTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExplorerTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExplorerTaskResponse
        /// </returns>
        public async Task<CreateExplorerTaskResponse> CreateExplorerTaskWithOptionsAsync(CreateExplorerTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["InitModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["TerraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["initModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPropertyValidation))
            {
                body["skipPropertyValidation"] = request.SkipPropertyValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerValue))
            {
                body["triggerValue"] = request.TriggerValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExplorerTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExplorerTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExplorerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExplorerTaskResponse
        /// </returns>
        public CreateExplorerTaskResponse CreateExplorerTask(CreateExplorerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateExplorerTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExplorerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExplorerTaskResponse
        /// </returns>
        public async Task<CreateExplorerTaskResponse> CreateExplorerTaskAsync(CreateExplorerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateExplorerTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroupWithOptions(CreateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTrigger))
            {
                body["autoTrigger"] = request.AutoTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForcedSetting))
            {
                body["forcedSetting"] = request.ForcedSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfig))
            {
                body["notifyConfig"] = request.NotifyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyOperationTypes))
            {
                body["notifyOperationTypes"] = request.NotifyOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportField))
            {
                body["reportExportField"] = request.ReportExportField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportPath))
            {
                body["reportExportPath"] = request.ReportExportPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerResourceType))
            {
                body["triggerResourceType"] = request.TriggerResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupWithOptionsAsync(CreateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTrigger))
            {
                body["autoTrigger"] = request.AutoTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForcedSetting))
            {
                body["forcedSetting"] = request.ForcedSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfig))
            {
                body["notifyConfig"] = request.NotifyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyOperationTypes))
            {
                body["notifyOperationTypes"] = request.NotifyOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportField))
            {
                body["reportExportField"] = request.ReportExportField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportPath))
            {
                body["reportExportPath"] = request.ReportExportPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerResourceType))
            {
                body["triggerResourceType"] = request.TriggerResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public CreateGroupResponse CreateGroup(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateGroupResponse
        /// </returns>
        public async Task<CreateGroupResponse> CreateGroupAsync(CreateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJobWithOptions(string taskId, CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteType))
            {
                body["executeType"] = request.ExecuteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCommand))
            {
                body["subCommand"] = request.SubCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(string taskId, CreateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteType))
            {
                body["executeType"] = request.ExecuteType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubCommand))
            {
                body["subCommand"] = request.SubCommand;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateJob",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJob(string taskId, CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateJobWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobAsync(string taskId, CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateJobWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleResponse
        /// </returns>
        public CreateModuleResponse CreateModuleWithOptions(CreateModuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePath))
            {
                body["sourcePath"] = request.SourcePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatePath))
            {
                body["statePath"] = request.StatePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStrategy))
            {
                body["versionStrategy"] = request.VersionStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleResponse
        /// </returns>
        public async Task<CreateModuleResponse> CreateModuleWithOptionsAsync(CreateModuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePath))
            {
                body["sourcePath"] = request.SourcePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatePath))
            {
                body["statePath"] = request.StatePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStrategy))
            {
                body["versionStrategy"] = request.VersionStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleResponse
        /// </returns>
        public CreateModuleResponse CreateModule(CreateModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModuleWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleResponse
        /// </returns>
        public async Task<CreateModuleResponse> CreateModuleAsync(CreateModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModuleWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleVersionResponse
        /// </returns>
        public CreateModuleVersionResponse CreateModuleVersionWithOptions(string moduleId, CreateModuleVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModuleVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModuleVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleVersionResponse
        /// </returns>
        public async Task<CreateModuleVersionResponse> CreateModuleVersionWithOptionsAsync(string moduleId, CreateModuleVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateModuleVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId) + "/versions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateModuleVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleVersionResponse
        /// </returns>
        public CreateModuleVersionResponse CreateModuleVersion(string moduleId, CreateModuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateModuleVersionWithOptions(moduleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建模版版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateModuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateModuleVersionResponse
        /// </returns>
        public async Task<CreateModuleVersionResponse> CreateModuleVersionAsync(string moduleId, CreateModuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateModuleVersionWithOptionsAsync(moduleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParameterSetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterSetResponse
        /// </returns>
        public CreateParameterSetResponse CreateParameterSetWithOptions(CreateParameterSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParameterSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParameterSetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterSetResponse
        /// </returns>
        public async Task<CreateParameterSetResponse> CreateParameterSetWithOptionsAsync(CreateParameterSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateParameterSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParameterSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterSetResponse
        /// </returns>
        public CreateParameterSetResponse CreateParameterSet(CreateParameterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateParameterSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateParameterSetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateParameterSetResponse
        /// </returns>
        public async Task<CreateParameterSetResponse> CreateParameterSetAsync(CreateParameterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateParameterSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建项目批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectBuildRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectBuildResponse
        /// </returns>
        public CreateProjectBuildResponse CreateProjectBuildWithOptions(string projectId, CreateProjectBuildRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectBuildAction))
            {
                body["projectBuildAction"] = request.ProjectBuildAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPolicies))
            {
                body["taskPolicies"] = request.TaskPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProjectBuild",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectBuildResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建项目批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectBuildRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectBuildResponse
        /// </returns>
        public async Task<CreateProjectBuildResponse> CreateProjectBuildWithOptionsAsync(string projectId, CreateProjectBuildRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                body["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectBuildAction))
            {
                body["projectBuildAction"] = request.ProjectBuildAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskIds))
            {
                body["taskIds"] = request.TaskIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPolicies))
            {
                body["taskPolicies"] = request.TaskPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProjectBuild",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectBuildResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建项目批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectBuildRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectBuildResponse
        /// </returns>
        public CreateProjectBuildResponse CreateProjectBuild(string projectId, CreateProjectBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectBuildWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>构建项目批次</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectBuildRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectBuildResponse
        /// </returns>
        public async Task<CreateProjectBuildResponse> CreateProjectBuildAsync(string projectId, CreateProjectBuildRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectBuildWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRabbitmqPublisherRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRabbitmqPublisherResponse
        /// </returns>
        public CreateRabbitmqPublisherResponse CreateRabbitmqPublisherWithOptions(CreateRabbitmqPublisherRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["exchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeType))
            {
                body["exchangeType"] = request.ExchangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                body["hostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["virtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRabbitmqPublisherResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRabbitmqPublisherRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRabbitmqPublisherResponse
        /// </returns>
        public async Task<CreateRabbitmqPublisherResponse> CreateRabbitmqPublisherWithOptionsAsync(CreateRabbitmqPublisherRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["exchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeType))
            {
                body["exchangeType"] = request.ExchangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                body["hostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Port))
            {
                body["port"] = request.Port;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["virtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRabbitmqPublisherResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRabbitmqPublisherRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRabbitmqPublisherResponse
        /// </returns>
        public CreateRabbitmqPublisherResponse CreateRabbitmqPublisher(CreateRabbitmqPublisherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRabbitmqPublisherWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRabbitmqPublisherRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRabbitmqPublisherResponse
        /// </returns>
        public async Task<CreateRabbitmqPublisherResponse> CreateRabbitmqPublisherAsync(CreateRabbitmqPublisherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRabbitmqPublisherWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRamPolicyExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRamPolicyExportTaskResponse
        /// </returns>
        public CreateRamPolicyExportTaskResponse CreateRamPolicyExportTaskWithOptions(CreateRamPolicyExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationAccountIds))
            {
                body["authorizationAccountIds"] = request.AuthorizationAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationActions))
            {
                body["authorizationActions"] = request.AuthorizationActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRegionIds))
            {
                body["authorizationRegionIds"] = request.AuthorizationRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRamPolicyExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRamPolicyExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRamPolicyExportTaskResponse
        /// </returns>
        public async Task<CreateRamPolicyExportTaskResponse> CreateRamPolicyExportTaskWithOptionsAsync(CreateRamPolicyExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationAccountIds))
            {
                body["authorizationAccountIds"] = request.AuthorizationAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationActions))
            {
                body["authorizationActions"] = request.AuthorizationActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRegionIds))
            {
                body["authorizationRegionIds"] = request.AuthorizationRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRamPolicyExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRamPolicyExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRamPolicyExportTaskResponse
        /// </returns>
        public CreateRamPolicyExportTaskResponse CreateRamPolicyExportTask(CreateRamPolicyExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRamPolicyExportTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRamPolicyExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRamPolicyExportTaskResponse
        /// </returns>
        public async Task<CreateRamPolicyExportTaskResponse> CreateRamPolicyExportTaskAsync(CreateRamPolicyExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRamPolicyExportTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceExportTaskResponse
        /// </returns>
        public CreateResourceExportTaskResponse CreateResourceExportTaskWithOptions(CreateResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigPath))
            {
                body["configPath"] = request.ConfigPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeRules))
            {
                body["excludeRules"] = request.ExcludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportToModule))
            {
                body["exportToModule"] = request.ExportToModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRules))
            {
                body["includeRules"] = request.IncludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceExportTaskResponse
        /// </returns>
        public async Task<CreateResourceExportTaskResponse> CreateResourceExportTaskWithOptionsAsync(CreateResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigPath))
            {
                body["configPath"] = request.ConfigPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeRules))
            {
                body["excludeRules"] = request.ExcludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportToModule))
            {
                body["exportToModule"] = request.ExportToModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRules))
            {
                body["includeRules"] = request.IncludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateResourceExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceExportTaskResponse
        /// </returns>
        public CreateResourceExportTaskResponse CreateResourceExportTask(CreateResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateResourceExportTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateResourceExportTaskResponse
        /// </returns>
        public async Task<CreateResourceExportTaskResponse> CreateResourceExportTaskAsync(CreateResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateResourceExportTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTaskWithOptions(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["initModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionStrategy))
            {
                body["protectionStrategy"] = request.ProtectionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPropertyValidation))
            {
                body["skipPropertyValidation"] = request.SkipPropertyValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBackend))
            {
                body["taskBackend"] = request.TaskBackend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerValue))
            {
                body["triggerValue"] = request.TriggerValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskWithOptionsAsync(CreateTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["initModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionStrategy))
            {
                body["protectionStrategy"] = request.ProtectionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPropertyValidation))
            {
                body["skipPropertyValidation"] = request.SkipPropertyValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskBackend))
            {
                body["taskBackend"] = request.TaskBackend;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerValue))
            {
                body["triggerValue"] = request.TriggerValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public CreateTaskResponse CreateTask(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTaskWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTaskResponse
        /// </returns>
        public async Task<CreateTaskResponse> CreateTaskAsync(CreateTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTaskWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAuthorizationResponse
        /// </returns>
        public DeleteAuthorizationResponse DeleteAuthorizationWithOptions(string authorizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAuthorization",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(authorizationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAuthorizationResponse
        /// </returns>
        public async Task<DeleteAuthorizationResponse> DeleteAuthorizationWithOptionsAsync(string authorizationId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAuthorization",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(authorizationId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAuthorizationResponse
        /// </returns>
        public DeleteAuthorizationResponse DeleteAuthorization(string authorizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAuthorizationWithOptions(authorizationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除共享</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteAuthorizationResponse
        /// </returns>
        public async Task<DeleteAuthorizationResponse> DeleteAuthorizationAsync(string authorizationId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAuthorizationWithOptionsAsync(authorizationId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public DeleteGroupResponse DeleteGroupWithOptions(string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public async Task<DeleteGroupResponse> DeleteGroupWithOptionsAsync(string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public DeleteGroupResponse DeleteGroup(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteGroupWithOptions(groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除分组</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteGroupResponse
        /// </returns>
        public async Task<DeleteGroupResponse> DeleteGroupAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteGroupWithOptionsAsync(groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModuleResponse
        /// </returns>
        public DeleteModuleResponse DeleteModuleWithOptions(string moduleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteModuleResponse
        /// </returns>
        public async Task<DeleteModuleResponse> DeleteModuleWithOptionsAsync(string moduleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteModuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModuleResponse
        /// </returns>
        public DeleteModuleResponse DeleteModule(string moduleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteModuleWithOptions(moduleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除模版</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteModuleResponse
        /// </returns>
        public async Task<DeleteModuleResponse> DeleteModuleAsync(string moduleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteModuleWithOptionsAsync(moduleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除参数集</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteParameterSetResponse
        /// </returns>
        public DeleteParameterSetResponse DeleteParameterSetWithOptions(string parameterSetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parameterSetId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParameterSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除参数集</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteParameterSetResponse
        /// </returns>
        public async Task<DeleteParameterSetResponse> DeleteParameterSetWithOptionsAsync(string parameterSetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parameterSetId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteParameterSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除参数集</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteParameterSetResponse
        /// </returns>
        public DeleteParameterSetResponse DeleteParameterSet(string parameterSetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteParameterSetWithOptions(parameterSetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除参数集</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteParameterSetResponse
        /// </returns>
        public async Task<DeleteParameterSetResponse> DeleteParameterSetAsync(string parameterSetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteParameterSetWithOptionsAsync(parameterSetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public DeleteProjectResponse DeleteProjectWithOptions(string projectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public async Task<DeleteProjectResponse> DeleteProjectWithOptionsAsync(string projectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public DeleteProjectResponse DeleteProject(string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteProjectWithOptions(projectId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteProjectResponse
        /// </returns>
        public async Task<DeleteProjectResponse> DeleteProjectAsync(string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteProjectWithOptionsAsync(projectId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息发布者</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRabbitmqPublisherResponse
        /// </returns>
        public DeleteRabbitmqPublisherResponse DeleteRabbitmqPublisherWithOptions(string publisherId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRabbitmqPublisherResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息发布者</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRabbitmqPublisherResponse
        /// </returns>
        public async Task<DeleteRabbitmqPublisherResponse> DeleteRabbitmqPublisherWithOptionsAsync(string publisherId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRabbitmqPublisherResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息发布者</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRabbitmqPublisherResponse
        /// </returns>
        public DeleteRabbitmqPublisherResponse DeleteRabbitmqPublisher(string publisherId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRabbitmqPublisherWithOptions(publisherId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除消息发布者</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRabbitmqPublisherResponse
        /// </returns>
        public async Task<DeleteRabbitmqPublisherResponse> DeleteRabbitmqPublisherAsync(string publisherId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRabbitmqPublisherWithOptionsAsync(publisherId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskResponse
        /// </returns>
        public DeleteRamPolicyExportTaskResponse DeleteRamPolicyExportTaskWithOptions(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRamPolicyExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskResponse
        /// </returns>
        public async Task<DeleteRamPolicyExportTaskResponse> DeleteRamPolicyExportTaskWithOptionsAsync(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRamPolicyExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskResponse
        /// </returns>
        public DeleteRamPolicyExportTaskResponse DeleteRamPolicyExportTask(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRamPolicyExportTaskWithOptions(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskResponse
        /// </returns>
        public async Task<DeleteRamPolicyExportTaskResponse> DeleteRamPolicyExportTaskAsync(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRamPolicyExportTaskWithOptionsAsync(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务版本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskVersionResponse
        /// </returns>
        public DeleteRamPolicyExportTaskVersionResponse DeleteRamPolicyExportTaskVersionWithOptions(string ramPolicyExportTaskId, string exportVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRamPolicyExportTaskVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRamPolicyExportTaskVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务版本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskVersionResponse
        /// </returns>
        public async Task<DeleteRamPolicyExportTaskVersionResponse> DeleteRamPolicyExportTaskVersionWithOptionsAsync(string ramPolicyExportTaskId, string exportVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteRamPolicyExportTaskVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRamPolicyExportTaskVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务版本</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskVersionResponse
        /// </returns>
        public DeleteRamPolicyExportTaskVersionResponse DeleteRamPolicyExportTaskVersion(string ramPolicyExportTaskId, string exportVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteRamPolicyExportTaskVersionWithOptions(ramPolicyExportTaskId, exportVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除RAM策略导出任务版本</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteRamPolicyExportTaskVersionResponse
        /// </returns>
        public async Task<DeleteRamPolicyExportTaskVersionResponse> DeleteRamPolicyExportTaskVersionAsync(string ramPolicyExportTaskId, string exportVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteRamPolicyExportTaskVersionWithOptionsAsync(ramPolicyExportTaskId, exportVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceExportTaskResponse
        /// </returns>
        public DeleteResourceExportTaskResponse DeleteResourceExportTaskWithOptions(string exportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteResourceExportTaskResponse
        /// </returns>
        public async Task<DeleteResourceExportTaskResponse> DeleteResourceExportTaskWithOptionsAsync(string exportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteResourceExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceExportTaskResponse
        /// </returns>
        public DeleteResourceExportTaskResponse DeleteResourceExportTask(string exportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteResourceExportTaskWithOptions(exportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteResourceExportTaskResponse
        /// </returns>
        public async Task<DeleteResourceExportTaskResponse> DeleteResourceExportTaskAsync(string exportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteResourceExportTaskWithOptionsAsync(exportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景化测试任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneTestingTaskResponse
        /// </returns>
        public DeleteSceneTestingTaskResponse DeleteSceneTestingTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSceneTestingTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/sceneTestingTask/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSceneTestingTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景化测试任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSceneTestingTaskResponse
        /// </returns>
        public async Task<DeleteSceneTestingTaskResponse> DeleteSceneTestingTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSceneTestingTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/sceneTestingTask/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSceneTestingTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景化测试任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSceneTestingTaskResponse
        /// </returns>
        public DeleteSceneTestingTaskResponse DeleteSceneTestingTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSceneTestingTaskWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除场景化测试任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteSceneTestingTaskResponse
        /// </returns>
        public async Task<DeleteSceneTestingTaskResponse> DeleteSceneTestingTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSceneTestingTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTaskResponse
        /// </returns>
        public DeleteTaskResponse DeleteTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteTaskResponse
        /// </returns>
        public async Task<DeleteTaskResponse> DeleteTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteTaskResponse
        /// </returns>
        public DeleteTaskResponse DeleteTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTaskWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteTaskResponse
        /// </returns>
        public async Task<DeleteTaskResponse> DeleteTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者从任务上卸载</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachRabbitmqPublisherRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachRabbitmqPublisherResponse
        /// </returns>
        public DetachRabbitmqPublisherResponse DetachRabbitmqPublisherWithOptions(string publisherId, DetachRabbitmqPublisherRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId) + "/detach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachRabbitmqPublisherResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者从任务上卸载</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachRabbitmqPublisherRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachRabbitmqPublisherResponse
        /// </returns>
        public async Task<DetachRabbitmqPublisherResponse> DetachRabbitmqPublisherWithOptionsAsync(string publisherId, DetachRabbitmqPublisherRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                body["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId) + "/detach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachRabbitmqPublisherResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者从任务上卸载</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachRabbitmqPublisherRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachRabbitmqPublisherResponse
        /// </returns>
        public DetachRabbitmqPublisherResponse DetachRabbitmqPublisher(string publisherId, DetachRabbitmqPublisherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DetachRabbitmqPublisherWithOptions(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将消息发布者从任务上卸载</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachRabbitmqPublisherRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachRabbitmqPublisherResponse
        /// </returns>
        public async Task<DetachRabbitmqPublisherResponse> DetachRabbitmqPublisherAsync(string publisherId, DetachRabbitmqPublisherRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DetachRabbitmqPublisherWithOptionsAsync(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateGroupResponse
        /// </returns>
        public DissociateGroupResponse DissociateGroupWithOptions(string projectId, string groupId, DissociateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
                Action = "DissociateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/dissociate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateGroupResponse
        /// </returns>
        public async Task<DissociateGroupResponse> DissociateGroupWithOptionsAsync(string projectId, string groupId, DissociateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
                Action = "DissociateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId) + "/dissociate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateGroupResponse
        /// </returns>
        public DissociateGroupResponse DissociateGroup(string projectId, string groupId, DissociateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DissociateGroupWithOptions(projectId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateGroupResponse
        /// </returns>
        public async Task<DissociateGroupResponse> DissociateGroupAsync(string projectId, string groupId, DissociateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DissociateGroupWithOptionsAsync(projectId, groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除参数集关联资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateParameterSetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateParameterSetResponse
        /// </returns>
        public DissociateParameterSetResponse DissociateParameterSetWithOptions(DissociateParameterSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterSetIds))
            {
                body["parameterSetIds"] = request.ParameterSetIds;
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
                Action = "DissociateParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/operations/dissociate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateParameterSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除参数集关联资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateParameterSetRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DissociateParameterSetResponse
        /// </returns>
        public async Task<DissociateParameterSetResponse> DissociateParameterSetWithOptionsAsync(DissociateParameterSetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParameterSetIds))
            {
                body["parameterSetIds"] = request.ParameterSetIds;
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
                Action = "DissociateParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/operations/dissociate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DissociateParameterSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除参数集关联资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateParameterSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateParameterSetResponse
        /// </returns>
        public DissociateParameterSetResponse DissociateParameterSet(DissociateParameterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DissociateParameterSetWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>解除参数集关联资源关系</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DissociateParameterSetRequest
        /// </param>
        /// 
        /// <returns>
        /// DissociateParameterSetResponse
        /// </returns>
        public async Task<DissociateParameterSetResponse> DissociateParameterSetAsync(DissociateParameterSetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DissociateParameterSetWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteRamPolicyExportTaskResponse
        /// </returns>
        public ExecuteRamPolicyExportTaskResponse ExecuteRamPolicyExportTaskWithOptions(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/execute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteRamPolicyExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteRamPolicyExportTaskResponse
        /// </returns>
        public async Task<ExecuteRamPolicyExportTaskResponse> ExecuteRamPolicyExportTaskWithOptionsAsync(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/execute",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteRamPolicyExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// ExecuteRamPolicyExportTaskResponse
        /// </returns>
        public ExecuteRamPolicyExportTaskResponse ExecuteRamPolicyExportTask(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteRamPolicyExportTaskWithOptions(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <returns>
        /// ExecuteRamPolicyExportTaskResponse
        /// </returns>
        public async Task<ExecuteRamPolicyExportTaskResponse> ExecuteRamPolicyExportTaskAsync(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteRamPolicyExportTaskWithOptionsAsync(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteResourceExportTaskResponse
        /// </returns>
        public ExecuteResourceExportTaskResponse ExecuteResourceExportTaskWithOptions(string exportTaskId, ExecuteResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/execute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteResourceExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteResourceExportTaskResponse
        /// </returns>
        public async Task<ExecuteResourceExportTaskResponse> ExecuteResourceExportTaskWithOptionsAsync(string exportTaskId, ExecuteResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/execute/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteResourceExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteResourceExportTaskResponse
        /// </returns>
        public ExecuteResourceExportTaskResponse ExecuteResourceExportTask(string exportTaskId, ExecuteResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ExecuteResourceExportTaskWithOptions(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>执行资源导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteResourceExportTaskResponse
        /// </returns>
        public async Task<ExecuteResourceExportTaskResponse> ExecuteResourceExportTaskAsync(string exportTaskId, ExecuteResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ExecuteResourceExportTaskWithOptionsAsync(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Explorer任务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExplorerTaskResponse
        /// </returns>
        public GetExplorerTaskResponse GetExplorerTaskWithOptions(string explorerTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExplorerTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(explorerTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExplorerTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Explorer任务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetExplorerTaskResponse
        /// </returns>
        public async Task<GetExplorerTaskResponse> GetExplorerTaskWithOptionsAsync(string explorerTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetExplorerTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(explorerTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetExplorerTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Explorer任务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExplorerTaskResponse
        /// </returns>
        public GetExplorerTaskResponse GetExplorerTask(string explorerTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetExplorerTaskWithOptions(explorerTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询Explorer任务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetExplorerTaskResponse
        /// </returns>
        public async Task<GetExplorerTaskResponse> GetExplorerTaskAsync(string explorerTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetExplorerTaskWithOptionsAsync(explorerTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public GetGroupResponse GetGroupWithOptions(string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public async Task<GetGroupResponse> GetGroupWithOptionsAsync(string groupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public GetGroupResponse GetGroup(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetGroupWithOptions(groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetGroupResponse
        /// </returns>
        public async Task<GetGroupResponse> GetGroupAsync(string groupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetGroupWithOptionsAsync(groupId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJobWithOptions(string taskId, string jobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobWithOptionsAsync(string taskId, string jobId, GetJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJob(string taskId, string jobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobWithOptions(taskId, jobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobAsync(string taskId, string jobId, GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobWithOptionsAsync(taskId, jobId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModuleResponse
        /// </returns>
        public GetModuleResponse GetModuleWithOptions(string moduleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModuleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModuleResponse
        /// </returns>
        public async Task<GetModuleResponse> GetModuleWithOptionsAsync(string moduleId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModule",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModuleResponse
        /// </returns>
        public GetModuleResponse GetModule(string moduleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModuleWithOptions(moduleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取模版详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModuleResponse
        /// </returns>
        public async Task<GetModuleResponse> GetModuleAsync(string moduleId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModuleWithOptionsAsync(moduleId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModuleVersionResponse
        /// </returns>
        public GetModuleVersionResponse GetModuleVersionWithOptions(string moduleId, string moduleVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModuleVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModuleVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetModuleVersionResponse
        /// </returns>
        public async Task<GetModuleVersionResponse> GetModuleVersionWithOptionsAsync(string moduleId, string moduleVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetModuleVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetModuleVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModuleVersionResponse
        /// </returns>
        public GetModuleVersionResponse GetModuleVersion(string moduleId, string moduleVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetModuleVersionWithOptions(moduleId, moduleVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetModuleVersionResponse
        /// </returns>
        public async Task<GetModuleVersionResponse> GetModuleVersionAsync(string moduleId, string moduleVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetModuleVersionWithOptionsAsync(moduleId, moduleVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParameterSetResponse
        /// </returns>
        public GetParameterSetResponse GetParameterSetWithOptions(string parameterSetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parameterSetId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParameterSetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetParameterSetResponse
        /// </returns>
        public async Task<GetParameterSetResponse> GetParameterSetWithOptionsAsync(string parameterSetId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetParameterSet",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parameterSetId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetParameterSetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetParameterSetResponse
        /// </returns>
        public GetParameterSetResponse GetParameterSet(string parameterSetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetParameterSetWithOptions(parameterSetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetParameterSetResponse
        /// </returns>
        public async Task<GetParameterSetResponse> GetParameterSetAsync(string parameterSetId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetParameterSetWithOptionsAsync(parameterSetId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProjectWithOptions(string projectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string projectId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProject(string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(projectId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectAsync(string projectId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(projectId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectBuildContextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectBuildContextResponse
        /// </returns>
        public GetProjectBuildContextResponse GetProjectBuildContextWithOptions(string projectId, string projectBuildId, GetProjectBuildContextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPassAssertCheck))
            {
                query["isPassAssertCheck"] = request.IsPassAssertCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectBuildContext",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectBuildId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectBuildContextResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectBuildContextRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectBuildContextResponse
        /// </returns>
        public async Task<GetProjectBuildContextResponse> GetProjectBuildContextWithOptionsAsync(string projectId, string projectBuildId, GetProjectBuildContextRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsPassAssertCheck))
            {
                query["isPassAssertCheck"] = request.IsPassAssertCheck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProjectBuildContext",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectBuildId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectBuildContextResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectBuildContextRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectBuildContextResponse
        /// </returns>
        public GetProjectBuildContextResponse GetProjectBuildContext(string projectId, string projectBuildId, GetProjectBuildContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectBuildContextWithOptions(projectId, projectBuildId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次概览</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectBuildContextRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectBuildContextResponse
        /// </returns>
        public async Task<GetProjectBuildContextResponse> GetProjectBuildContextAsync(string projectId, string projectBuildId, GetProjectBuildContextRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectBuildContextWithOptionsAsync(projectId, projectBuildId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRabbitmqPublisherResponse
        /// </returns>
        public GetRabbitmqPublisherResponse GetRabbitmqPublisherWithOptions(string publisherId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRabbitmqPublisherResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRabbitmqPublisherResponse
        /// </returns>
        public async Task<GetRabbitmqPublisherResponse> GetRabbitmqPublisherWithOptionsAsync(string publisherId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRabbitmqPublisher",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRabbitmqPublisherResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRabbitmqPublisherResponse
        /// </returns>
        public GetRabbitmqPublisherResponse GetRabbitmqPublisher(string publisherId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRabbitmqPublisherWithOptions(publisherId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRabbitmqPublisherResponse
        /// </returns>
        public async Task<GetRabbitmqPublisherResponse> GetRabbitmqPublisherAsync(string publisherId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRabbitmqPublisherWithOptionsAsync(publisherId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskResponse
        /// </returns>
        public GetRamPolicyExportTaskResponse GetRamPolicyExportTaskWithOptions(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRamPolicyExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskResponse
        /// </returns>
        public async Task<GetRamPolicyExportTaskResponse> GetRamPolicyExportTaskWithOptionsAsync(string ramPolicyExportTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRamPolicyExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRamPolicyExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskResponse
        /// </returns>
        public GetRamPolicyExportTaskResponse GetRamPolicyExportTask(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRamPolicyExportTaskWithOptions(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskResponse
        /// </returns>
        public async Task<GetRamPolicyExportTaskResponse> GetRamPolicyExportTaskAsync(string ramPolicyExportTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRamPolicyExportTaskWithOptionsAsync(ramPolicyExportTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskVersionResponse
        /// </returns>
        public GetRamPolicyExportTaskVersionResponse GetRamPolicyExportTaskVersionWithOptions(string ramPolicyExportTaskId, string exportVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRamPolicyExportTaskVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRamPolicyExportTaskVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskVersionResponse
        /// </returns>
        public async Task<GetRamPolicyExportTaskVersionResponse> GetRamPolicyExportTaskVersionWithOptionsAsync(string ramPolicyExportTaskId, string exportVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRamPolicyExportTaskVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/versions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportVersion),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRamPolicyExportTaskVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskVersionResponse
        /// </returns>
        public GetRamPolicyExportTaskVersionResponse GetRamPolicyExportTaskVersion(string ramPolicyExportTaskId, string exportVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRamPolicyExportTaskVersionWithOptions(ramPolicyExportTaskId, exportVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRamPolicyExportTaskVersionResponse
        /// </returns>
        public async Task<GetRamPolicyExportTaskVersionResponse> GetRamPolicyExportTaskVersionAsync(string ramPolicyExportTaskId, string exportVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRamPolicyExportTaskVersionWithOptionsAsync(ramPolicyExportTaskId, exportVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceExportTaskResponse
        /// </returns>
        public GetResourceExportTaskResponse GetResourceExportTaskWithOptions(string exportTaskId, GetResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportVersion))
            {
                query["exportVersion"] = request.ExportVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceExportTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceExportTaskRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetResourceExportTaskResponse
        /// </returns>
        public async Task<GetResourceExportTaskResponse> GetResourceExportTaskWithOptionsAsync(string exportTaskId, GetResourceExportTaskRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportVersion))
            {
                query["exportVersion"] = request.ExportVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetResourceExportTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetResourceExportTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceExportTaskResponse
        /// </returns>
        public GetResourceExportTaskResponse GetResourceExportTask(string exportTaskId, GetResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetResourceExportTaskWithOptions(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetResourceExportTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// GetResourceExportTaskResponse
        /// </returns>
        public async Task<GetResourceExportTaskResponse> GetResourceExportTaskAsync(string exportTaskId, GetResourceExportTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetResourceExportTaskWithOptionsAsync(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTask",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public GetTaskResponse GetTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskWithOptions(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询任务详情</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTaskResponse
        /// </returns>
        public async Task<GetTaskResponse> GetTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组优先级详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskPolicyResponse
        /// </returns>
        public GetTaskPolicyResponse GetTaskPolicyWithOptions(string groupId, GetTaskPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskPolicy",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/task/policy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组优先级详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTaskPolicyResponse
        /// </returns>
        public async Task<GetTaskPolicyResponse> GetTaskPolicyWithOptionsAsync(string groupId, GetTaskPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTaskPolicy",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/task/policy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTaskPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组优先级详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskPolicyResponse
        /// </returns>
        public GetTaskPolicyResponse GetTaskPolicy(string groupId, GetTaskPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTaskPolicyWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组优先级详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTaskPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTaskPolicyResponse
        /// </returns>
        public async Task<GetTaskPolicyResponse> GetTaskPolicyAsync(string groupId, GetTaskPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTaskPolicyWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizationsResponse
        /// </returns>
        public ListAuthorizationsResponse ListAuthorizationsWithOptions(ListAuthorizationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationId))
            {
                query["authorizationId"] = request.AuthorizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                query["authorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizations",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizationsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizationsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizationsResponse
        /// </returns>
        public async Task<ListAuthorizationsResponse> ListAuthorizationsWithOptionsAsync(ListAuthorizationsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationId))
            {
                query["authorizationId"] = request.AuthorizationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationType))
            {
                query["authorizationType"] = request.AuthorizationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAuthorizations",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAuthorizationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizationsResponse
        /// </returns>
        public ListAuthorizationsResponse ListAuthorizations(ListAuthorizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAuthorizationsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取共享列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAuthorizationsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAuthorizationsResponse
        /// </returns>
        public async Task<ListAuthorizationsResponse> ListAuthorizationsAsync(ListAuthorizationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAuthorizationsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraform版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableTerraformVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableTerraformVersionsResponse
        /// </returns>
        public ListAvailableTerraformVersionsResponse ListAvailableTerraformVersionsWithOptions(ListAvailableTerraformVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["keyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableTerraformVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/version/terraform",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableTerraformVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraform版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableTerraformVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableTerraformVersionsResponse
        /// </returns>
        public async Task<ListAvailableTerraformVersionsResponse> ListAvailableTerraformVersionsWithOptionsAsync(ListAvailableTerraformVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyWord))
            {
                query["keyWord"] = request.KeyWord;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableTerraformVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/version/terraform",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableTerraformVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraform版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableTerraformVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableTerraformVersionsResponse
        /// </returns>
        public ListAvailableTerraformVersionsResponse ListAvailableTerraformVersions(ListAvailableTerraformVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAvailableTerraformVersionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraform版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableTerraformVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableTerraformVersionsResponse
        /// </returns>
        public async Task<ListAvailableTerraformVersionsResponse> ListAvailableTerraformVersionsAsync(ListAvailableTerraformVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAvailableTerraformVersionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExplorerTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExplorerTasksResponse
        /// </returns>
        public ListExplorerTasksResponse ListExplorerTasksWithOptions(string explorerTaskId, ListExplorerTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["maxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                query["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExplorerTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExplorerTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExplorerTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExplorerTasksResponse
        /// </returns>
        public async Task<ListExplorerTasksResponse> ListExplorerTasksWithOptionsAsync(string explorerTaskId, ListExplorerTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResult))
            {
                query["maxResult"] = request.MaxResult;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                query["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExplorerTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExplorerTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExplorerTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExplorerTasksResponse
        /// </returns>
        public ListExplorerTasksResponse ListExplorerTasks(string explorerTaskId, ListExplorerTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListExplorerTasksWithOptions(explorerTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExplorerTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExplorerTasksResponse
        /// </returns>
        public async Task<ListExplorerTasksResponse> ListExplorerTasksAsync(string explorerTaskId, ListExplorerTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListExplorerTasksWithOptionsAsync(explorerTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupResponse
        /// </returns>
        public ListGroupResponse ListGroupWithOptions(ListGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGroupShrinkRequest request = new ListGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListGroupResponse
        /// </returns>
        public async Task<ListGroupResponse> ListGroupWithOptionsAsync(ListGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListGroupShrinkRequest request = new ListGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupResponse
        /// </returns>
        public ListGroupResponse ListGroup(ListGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListGroupWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询分组列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ListGroupResponse
        /// </returns>
        public async Task<ListGroupResponse> ListGroupAsync(ListGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListGroupWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(string taskId, ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(string taskId, ListJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobs",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(string taskId, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobsWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>作业列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(string taskId, ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobsWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModuleVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModuleVersionResponse
        /// </returns>
        public ListModuleVersionResponse ListModuleVersionWithOptions(string moduleId, ListModuleVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModuleVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModuleVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModuleVersionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModuleVersionResponse
        /// </returns>
        public async Task<ListModuleVersionResponse> ListModuleVersionWithOptionsAsync(string moduleId, ListModuleVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModuleVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModuleVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModuleVersionResponse
        /// </returns>
        public ListModuleVersionResponse ListModuleVersion(string moduleId, ListModuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModuleVersionWithOptions(moduleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>模版版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModuleVersionRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModuleVersionResponse
        /// </returns>
        public async Task<ListModuleVersionResponse> ListModuleVersionAsync(string moduleId, ListModuleVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModuleVersionWithOptionsAsync(moduleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModulesResponse
        /// </returns>
        public ListModulesResponse ListModulesWithOptions(ListModulesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModulesShrinkRequest request = new ListModulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeModuleIds))
            {
                request.ExcludeModuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeModuleIds, "excludeModuleIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeModuleIdsShrink))
            {
                query["excludeModuleIds"] = request.ExcludeModuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModules",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModulesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举模版</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListModulesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListModulesResponse
        /// </returns>
        public async Task<ListModulesResponse> ListModulesWithOptionsAsync(ListModulesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListModulesShrinkRequest request = new ListModulesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeModuleIds))
            {
                request.ExcludeModuleIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeModuleIds, "excludeModuleIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeModuleIdsShrink))
            {
                query["excludeModuleIds"] = request.ExcludeModuleIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListModules",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListModulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModulesResponse
        /// </returns>
        public ListModulesResponse ListModules(ListModulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListModulesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>列举模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListModulesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListModulesResponse
        /// </returns>
        public async Task<ListModulesResponse> ListModulesAsync(ListModulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListModulesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联到资源的参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetRelationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetRelationResponse
        /// </returns>
        public ListParameterSetRelationResponse ListParameterSetRelationWithOptions(ListParameterSetRelationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameterSetRelation",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/operations/relation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParameterSetRelationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联到资源的参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetRelationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetRelationResponse
        /// </returns>
        public async Task<ListParameterSetRelationResponse> ListParameterSetRelationWithOptionsAsync(ListParameterSetRelationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameterSetRelation",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/operations/relation",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParameterSetRelationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联到资源的参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetRelationResponse
        /// </returns>
        public ListParameterSetRelationResponse ListParameterSetRelation(ListParameterSetRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListParameterSetRelationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>关联到资源的参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetRelationRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetRelationResponse
        /// </returns>
        public async Task<ListParameterSetRelationResponse> ListParameterSetRelationAsync(ListParameterSetRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListParameterSetRelationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetsResponse
        /// </returns>
        public ListParameterSetsResponse ListParameterSetsWithOptions(ListParameterSetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameterSets",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParameterSetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetsResponse
        /// </returns>
        public async Task<ListParameterSetsResponse> ListParameterSetsWithOptionsAsync(ListParameterSetsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListParameterSets",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListParameterSetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetsResponse
        /// </returns>
        public ListParameterSetsResponse ListParameterSets(ListParameterSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListParameterSetsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>参数集列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListParameterSetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListParameterSetsResponse
        /// </returns>
        public async Task<ListParameterSetsResponse> ListParameterSetsAsync(ListParameterSetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListParameterSetsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectResponse
        /// </returns>
        public ListProjectResponse ListProjectWithOptions(ListProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectShrinkRequest request = new ListProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectResponse
        /// </returns>
        public async Task<ListProjectResponse> ListProjectWithOptionsAsync(ListProjectRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListProjectShrinkRequest request = new ListProjectShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectResponse
        /// </returns>
        public ListProjectResponse ListProject(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询项目列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectResponse
        /// </returns>
        public async Task<ListProjectResponse> ListProjectAsync(ListProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectBuildsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectBuildsResponse
        /// </returns>
        public ListProjectBuildsResponse ListProjectBuildsWithOptions(string projectId, ListProjectBuildsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectBuildAction))
            {
                query["projectBuildAction"] = request.ProjectBuildAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectBuilds",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectBuildsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectBuildsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectBuildsResponse
        /// </returns>
        public async Task<ListProjectBuildsResponse> ListProjectBuildsWithOptionsAsync(string projectId, ListProjectBuildsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectBuildAction))
            {
                query["projectBuildAction"] = request.ProjectBuildAction;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectBuilds",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId) + "/build",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectBuildsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectBuildsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectBuildsResponse
        /// </returns>
        public ListProjectBuildsResponse ListProjectBuilds(string projectId, ListProjectBuildsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectBuildsWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>项目批次列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectBuildsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectBuildsResponse
        /// </returns>
        public async Task<ListProjectBuildsResponse> ListProjectBuildsAsync(string projectId, ListProjectBuildsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectBuildsWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRabbitmqPublishersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRabbitmqPublishersResponse
        /// </returns>
        public ListRabbitmqPublishersResponse ListRabbitmqPublishersWithOptions(ListRabbitmqPublishersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRabbitmqPublishers",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRabbitmqPublishersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRabbitmqPublishersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRabbitmqPublishersResponse
        /// </returns>
        public async Task<ListRabbitmqPublishersResponse> ListRabbitmqPublishersWithOptionsAsync(ListRabbitmqPublishersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRabbitmqPublishers",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRabbitmqPublishersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRabbitmqPublishersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRabbitmqPublishersResponse
        /// </returns>
        public ListRabbitmqPublishersResponse ListRabbitmqPublishers(ListRabbitmqPublishersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRabbitmqPublishersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取消息发布者列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRabbitmqPublishersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRabbitmqPublishersResponse
        /// </returns>
        public async Task<ListRabbitmqPublishersResponse> ListRabbitmqPublishersAsync(ListRabbitmqPublishersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRabbitmqPublishersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTaskVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTaskVersionsResponse
        /// </returns>
        public ListRamPolicyExportTaskVersionsResponse ListRamPolicyExportTaskVersionsWithOptions(string ramPolicyExportTaskId, ListRamPolicyExportTaskVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamPolicyExportTaskVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamPolicyExportTaskVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTaskVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTaskVersionsResponse
        /// </returns>
        public async Task<ListRamPolicyExportTaskVersionsResponse> ListRamPolicyExportTaskVersionsWithOptionsAsync(string ramPolicyExportTaskId, ListRamPolicyExportTaskVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamPolicyExportTaskVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId) + "/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamPolicyExportTaskVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTaskVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTaskVersionsResponse
        /// </returns>
        public ListRamPolicyExportTaskVersionsResponse ListRamPolicyExportTaskVersions(string ramPolicyExportTaskId, ListRamPolicyExportTaskVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRamPolicyExportTaskVersionsWithOptions(ramPolicyExportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTaskVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTaskVersionsResponse
        /// </returns>
        public async Task<ListRamPolicyExportTaskVersionsResponse> ListRamPolicyExportTaskVersionsAsync(string ramPolicyExportTaskId, ListRamPolicyExportTaskVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRamPolicyExportTaskVersionsWithOptionsAsync(ramPolicyExportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTasksResponse
        /// </returns>
        public ListRamPolicyExportTasksResponse ListRamPolicyExportTasksWithOptions(ListRamPolicyExportTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                query["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                query["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamPolicyExportTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamPolicyExportTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTasksResponse
        /// </returns>
        public async Task<ListRamPolicyExportTasksResponse> ListRamPolicyExportTasksWithOptionsAsync(ListRamPolicyExportTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                query["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                query["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRamPolicyExportTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRamPolicyExportTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTasksResponse
        /// </returns>
        public ListRamPolicyExportTasksResponse ListRamPolicyExportTasks(ListRamPolicyExportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRamPolicyExportTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取RAM策略导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRamPolicyExportTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRamPolicyExportTasksResponse
        /// </returns>
        public async Task<ListRamPolicyExportTasksResponse> ListRamPolicyExportTasksAsync(ListRamPolicyExportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRamPolicyExportTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTaskVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTaskVersionsResponse
        /// </returns>
        public ListResourceExportTaskVersionsResponse ListResourceExportTaskVersionsWithOptions(string exportTaskId, ListResourceExportTaskVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportVersion))
            {
                query["exportVersion"] = request.ExportVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceExportTaskVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId) + "/exportVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceExportTaskVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTaskVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTaskVersionsResponse
        /// </returns>
        public async Task<ListResourceExportTaskVersionsResponse> ListResourceExportTaskVersionsWithOptionsAsync(string exportTaskId, ListResourceExportTaskVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportVersion))
            {
                query["exportVersion"] = request.ExportVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceExportTaskVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId) + "/exportVersions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceExportTaskVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTaskVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTaskVersionsResponse
        /// </returns>
        public ListResourceExportTaskVersionsResponse ListResourceExportTaskVersions(string exportTaskId, ListResourceExportTaskVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceExportTaskVersionsWithOptions(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取任务版本列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTaskVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTaskVersionsResponse
        /// </returns>
        public async Task<ListResourceExportTaskVersionsResponse> ListResourceExportTaskVersionsAsync(string exportTaskId, ListResourceExportTaskVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceExportTaskVersionsWithOptionsAsync(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTasksResponse
        /// </returns>
        public ListResourceExportTasksResponse ListResourceExportTasksWithOptions(ListResourceExportTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportTaskId))
            {
                query["exportTaskId"] = request.ExportTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceExportTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceExportTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTasksResponse
        /// </returns>
        public async Task<ListResourceExportTasksResponse> ListResourceExportTasksWithOptionsAsync(ListResourceExportTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportTaskId))
            {
                query["exportTaskId"] = request.ExportTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceExportTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceExportTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTasksResponse
        /// </returns>
        public ListResourceExportTasksResponse ListResourceExportTasks(ListResourceExportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourceExportTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询导出任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourceExportTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourceExportTasksResponse
        /// </returns>
        public async Task<ListResourceExportTasksResponse> ListResourceExportTasksAsync(ListResourceExportTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourceExportTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public ListResourcesResponse ListResourcesWithOptions(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceValue))
            {
                query["sourceValue"] = request.SourceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["specType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/resources/stateparser",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["sourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceValue))
            {
                query["sourceValue"] = request.SourceValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["specType"] = request.SpecType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/resources/stateparser",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public ListResourcesResponse ListResources(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>资源列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public async Task<ListResourcesResponse> ListResourcesAsync(ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasksWithOptions(ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeTaskIds))
            {
                request.ExcludeTaskIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeTaskIds, "excludeTaskIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTaskIdsShrink))
            {
                query["excludeTaskIds"] = request.ExcludeTaskIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                query["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksWithOptionsAsync(ListTasksRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTasksShrinkRequest request = new ListTasksShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExcludeTaskIds))
            {
                request.ExcludeTaskIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExcludeTaskIds, "excludeTaskIds", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeTaskIdsShrink))
            {
                query["excludeTaskIds"] = request.ExcludeTaskIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["groupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                query["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                query["projectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["tag"] = request.TagShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTasks",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public ListTasksResponse ListTasks(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTasksWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>任务列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTasksResponse
        /// </returns>
        public async Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTasksWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraformProvider版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerraformProviderVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTerraformProviderVersionsResponse
        /// </returns>
        public ListTerraformProviderVersionsResponse ListTerraformProviderVersionsWithOptions(ListTerraformProviderVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Usage))
            {
                query["usage"] = request.Usage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerraformProviderVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/version/terraform/provider",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerraformProviderVersionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraformProvider版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerraformProviderVersionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTerraformProviderVersionsResponse
        /// </returns>
        public async Task<ListTerraformProviderVersionsResponse> ListTerraformProviderVersionsWithOptionsAsync(ListTerraformProviderVersionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Keyword))
            {
                query["keyword"] = request.Keyword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Usage))
            {
                query["usage"] = request.Usage;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTerraformProviderVersions",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/version/terraform/provider",
                Method = "GET",
                AuthType = "Anonymous",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTerraformProviderVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraformProvider版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerraformProviderVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTerraformProviderVersionsResponse
        /// </returns>
        public ListTerraformProviderVersionsResponse ListTerraformProviderVersions(ListTerraformProviderVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTerraformProviderVersionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>terraformProvider版本</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTerraformProviderVersionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTerraformProviderVersionsResponse
        /// </returns>
        public async Task<ListTerraformProviderVersionsResponse> ListTerraformProviderVersionsAsync(ListTerraformProviderVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTerraformProviderVersionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateJobResponse
        /// </returns>
        public OperateJobResponse OperateJobWithOptions(string taskId, string jobId, string operationType, OperateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateJob",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/operation/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationType),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OperateJobResponse
        /// </returns>
        public async Task<OperateJobResponse> OperateJobWithOptionsAsync(string taskId, string jobId, string operationType, OperateJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                query["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OperateJob",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/operation/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(operationType),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OperateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateJobResponse
        /// </returns>
        public OperateJobResponse OperateJob(string taskId, string jobId, string operationType, OperateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OperateJobWithOptions(taskId, jobId, operationType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>控制作业</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OperateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// OperateJobResponse
        /// </returns>
        public async Task<OperateJobResponse> OperateJobAsync(string taskId, string jobId, string operationType, OperateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OperateJobWithOptionsAsync(taskId, jobId, operationType, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除导出任务版本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResourceExportTaskVersionResponse
        /// </returns>
        public RemoveResourceExportTaskVersionResponse RemoveResourceExportTaskVersionWithOptions(string exportTaskId, string exportVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveResourceExportTaskVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResourceExportTaskVersionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除导出任务版本</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveResourceExportTaskVersionResponse
        /// </returns>
        public async Task<RemoveResourceExportTaskVersionResponse> RemoveResourceExportTaskVersionWithOptionsAsync(string exportTaskId, string exportVersion, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveResourceExportTaskVersion",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId) + "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportVersion),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveResourceExportTaskVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除导出任务版本</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveResourceExportTaskVersionResponse
        /// </returns>
        public RemoveResourceExportTaskVersionResponse RemoveResourceExportTaskVersion(string exportTaskId, string exportVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveResourceExportTaskVersionWithOptions(exportTaskId, exportVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>移除导出任务版本</para>
        /// </summary>
        /// 
        /// <returns>
        /// RemoveResourceExportTaskVersionResponse
        /// </returns>
        public async Task<RemoveResourceExportTaskVersionResponse> RemoveResourceExportTaskVersionAsync(string exportTaskId, string exportVersion)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveResourceExportTaskVersionWithOptionsAsync(exportTaskId, exportVersion, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resourceIds"] = request.ResourceIds;
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
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>打标签接口</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuthorizationAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuthorizationAttributeResponse
        /// </returns>
        public UpdateAuthorizationAttributeResponse UpdateAuthorizationAttributeWithOptions(string authorizationId, UpdateAuthorizationAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAuthorizationAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(authorizationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthorizationAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuthorizationAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuthorizationAttributeResponse
        /// </returns>
        public async Task<UpdateAuthorizationAttributeResponse> UpdateAuthorizationAttributeWithOptionsAsync(string authorizationId, UpdateAuthorizationAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DueTime))
            {
                body["dueTime"] = request.DueTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAuthorizationAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/authorizations/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(authorizationId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAuthorizationAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuthorizationAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuthorizationAttributeResponse
        /// </returns>
        public UpdateAuthorizationAttributeResponse UpdateAuthorizationAttribute(string authorizationId, UpdateAuthorizationAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAuthorizationAttributeWithOptions(authorizationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新共享</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateAuthorizationAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateAuthorizationAttributeResponse
        /// </returns>
        public async Task<UpdateAuthorizationAttributeResponse> UpdateAuthorizationAttributeAsync(string authorizationId, UpdateAuthorizationAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAuthorizationAttributeWithOptionsAsync(authorizationId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExplorerTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExplorerTaskAttributeResponse
        /// </returns>
        public UpdateExplorerTaskAttributeResponse UpdateExplorerTaskAttributeWithOptions(string explorerTaskId, UpdateExplorerTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExplorerTaskName))
            {
                body["explorerTaskName"] = request.ExplorerTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExplorerTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(explorerTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExplorerTaskAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExplorerTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateExplorerTaskAttributeResponse
        /// </returns>
        public async Task<UpdateExplorerTaskAttributeResponse> UpdateExplorerTaskAttributeWithOptionsAsync(string explorerTaskId, UpdateExplorerTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExplorerTaskName))
            {
                body["explorerTaskName"] = request.ExplorerTaskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateExplorerTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/explorerTask/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(explorerTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateExplorerTaskAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExplorerTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExplorerTaskAttributeResponse
        /// </returns>
        public UpdateExplorerTaskAttributeResponse UpdateExplorerTaskAttribute(string explorerTaskId, UpdateExplorerTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateExplorerTaskAttributeWithOptions(explorerTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改Explorer任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateExplorerTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateExplorerTaskAttributeResponse
        /// </returns>
        public async Task<UpdateExplorerTaskAttributeResponse> UpdateExplorerTaskAttributeAsync(string explorerTaskId, UpdateExplorerTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateExplorerTaskAttributeWithOptionsAsync(explorerTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public UpdateGroupResponse UpdateGroupWithOptions(string groupId, UpdateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTrigger))
            {
                body["autoTrigger"] = request.AutoTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForcedSetting))
            {
                body["forcedSetting"] = request.ForcedSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfig))
            {
                body["notifyConfig"] = request.NotifyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyOperationTypes))
            {
                body["notifyOperationTypes"] = request.NotifyOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportField))
            {
                body["reportExportField"] = request.ReportExportField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportPath))
            {
                body["reportExportPath"] = request.ReportExportPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerResourceType))
            {
                body["triggerResourceType"] = request.TriggerResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public async Task<UpdateGroupResponse> UpdateGroupWithOptionsAsync(string groupId, UpdateGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoTrigger))
            {
                body["autoTrigger"] = request.AutoTrigger;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForcedSetting))
            {
                body["forcedSetting"] = request.ForcedSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyConfig))
            {
                body["notifyConfig"] = request.NotifyConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyOperationTypes))
            {
                body["notifyOperationTypes"] = request.NotifyOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportField))
            {
                body["reportExportField"] = request.ReportExportField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportExportPath))
            {
                body["reportExportPath"] = request.ReportExportPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerConfig))
            {
                body["triggerConfig"] = request.TriggerConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerResourceType))
            {
                body["triggerResourceType"] = request.TriggerResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateGroup",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public UpdateGroupResponse UpdateGroup(string groupId, UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateGroupWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateGroupResponse
        /// </returns>
        public async Task<UpdateGroupResponse> UpdateGroupAsync(string groupId, UpdateGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateGroupWithOptionsAsync(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleAttributeResponse
        /// </returns>
        public UpdateModuleAttributeResponse UpdateModuleAttributeWithOptions(string moduleId, UpdateModuleAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePath))
            {
                body["sourcePath"] = request.SourcePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatePath))
            {
                body["statePath"] = request.StatePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStrategy))
            {
                body["versionStrategy"] = request.VersionStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModuleAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModuleAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleAttributeResponse
        /// </returns>
        public async Task<UpdateModuleAttributeResponse> UpdateModuleAttributeWithOptionsAsync(string moduleId, UpdateModuleAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                body["source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourcePath))
            {
                body["sourcePath"] = request.SourcePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatePath))
            {
                body["statePath"] = request.StatePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VersionStrategy))
            {
                body["versionStrategy"] = request.VersionStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateModuleAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/modules/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(moduleId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateModuleAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleAttributeResponse
        /// </returns>
        public UpdateModuleAttributeResponse UpdateModuleAttribute(string moduleId, UpdateModuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateModuleAttributeWithOptions(moduleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新模版</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateModuleAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateModuleAttributeResponse
        /// </returns>
        public async Task<UpdateModuleAttributeResponse> UpdateModuleAttributeAsync(string moduleId, UpdateModuleAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateModuleAttributeWithOptionsAsync(moduleId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterSetAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterSetAttributeResponse
        /// </returns>
        public UpdateParameterSetAttributeResponse UpdateParameterSetAttributeWithOptions(string parameterSetId, UpdateParameterSetAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateParameterSetAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parameterSetId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateParameterSetAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterSetAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterSetAttributeResponse
        /// </returns>
        public async Task<UpdateParameterSetAttributeResponse> UpdateParameterSetAttributeWithOptionsAsync(string parameterSetId, UpdateParameterSetAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateParameterSetAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/parameterSets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(parameterSetId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateParameterSetAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterSetAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterSetAttributeResponse
        /// </returns>
        public UpdateParameterSetAttributeResponse UpdateParameterSetAttribute(string parameterSetId, UpdateParameterSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateParameterSetAttributeWithOptions(parameterSetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新参数集</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateParameterSetAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateParameterSetAttributeResponse
        /// </returns>
        public async Task<UpdateParameterSetAttributeResponse> UpdateParameterSetAttributeAsync(string parameterSetId, UpdateParameterSetAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateParameterSetAttributeWithOptionsAsync(parameterSetId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProjectWithOptions(string projectId, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(string projectId, UpdateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProject",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/project/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public UpdateProjectResponse UpdateProject(string projectId, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectWithOptions(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改项目</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectResponse
        /// </returns>
        public async Task<UpdateProjectResponse> UpdateProjectAsync(string projectId, UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectWithOptionsAsync(projectId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRabbitmqPublisherAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRabbitmqPublisherAttributeResponse
        /// </returns>
        public UpdateRabbitmqPublisherAttributeResponse UpdateRabbitmqPublisherAttributeWithOptions(string publisherId, UpdateRabbitmqPublisherAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["exchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeType))
            {
                body["exchangeType"] = request.ExchangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRabbitmqPublisherAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRabbitmqPublisherAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRabbitmqPublisherAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRabbitmqPublisherAttributeResponse
        /// </returns>
        public async Task<UpdateRabbitmqPublisherAttributeResponse> UpdateRabbitmqPublisherAttributeWithOptionsAsync(string publisherId, UpdateRabbitmqPublisherAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["exchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeType))
            {
                body["exchangeType"] = request.ExchangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRabbitmqPublisherAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/publishers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(publisherId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRabbitmqPublisherAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRabbitmqPublisherAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRabbitmqPublisherAttributeResponse
        /// </returns>
        public UpdateRabbitmqPublisherAttributeResponse UpdateRabbitmqPublisherAttribute(string publisherId, UpdateRabbitmqPublisherAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRabbitmqPublisherAttributeWithOptions(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新消息发布者</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRabbitmqPublisherAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRabbitmqPublisherAttributeResponse
        /// </returns>
        public async Task<UpdateRabbitmqPublisherAttributeResponse> UpdateRabbitmqPublisherAttributeAsync(string publisherId, UpdateRabbitmqPublisherAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRabbitmqPublisherAttributeWithOptionsAsync(publisherId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRamPolicyExportTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRamPolicyExportTaskAttributeResponse
        /// </returns>
        public UpdateRamPolicyExportTaskAttributeResponse UpdateRamPolicyExportTaskAttributeWithOptions(string ramPolicyExportTaskId, UpdateRamPolicyExportTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationAccountIds))
            {
                body["authorizationAccountIds"] = request.AuthorizationAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationActions))
            {
                body["authorizationActions"] = request.AuthorizationActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRegionIds))
            {
                body["authorizationRegionIds"] = request.AuthorizationRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRamPolicyExportTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRamPolicyExportTaskAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRamPolicyExportTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateRamPolicyExportTaskAttributeResponse
        /// </returns>
        public async Task<UpdateRamPolicyExportTaskAttributeResponse> UpdateRamPolicyExportTaskAttributeWithOptionsAsync(string ramPolicyExportTaskId, UpdateRamPolicyExportTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationAccountIds))
            {
                body["authorizationAccountIds"] = request.AuthorizationAccountIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationActions))
            {
                body["authorizationActions"] = request.AuthorizationActions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthorizationRegionIds))
            {
                body["authorizationRegionIds"] = request.AuthorizationRegionIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRamPolicyExportTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/ramPolicyExportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ramPolicyExportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRamPolicyExportTaskAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRamPolicyExportTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRamPolicyExportTaskAttributeResponse
        /// </returns>
        public UpdateRamPolicyExportTaskAttributeResponse UpdateRamPolicyExportTaskAttribute(string ramPolicyExportTaskId, UpdateRamPolicyExportTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateRamPolicyExportTaskAttributeWithOptions(ramPolicyExportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改RAM策略导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateRamPolicyExportTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateRamPolicyExportTaskAttributeResponse
        /// </returns>
        public async Task<UpdateRamPolicyExportTaskAttributeResponse> UpdateRamPolicyExportTaskAttributeAsync(string ramPolicyExportTaskId, UpdateRamPolicyExportTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateRamPolicyExportTaskAttributeWithOptionsAsync(ramPolicyExportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceExportTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceExportTaskAttributeResponse
        /// </returns>
        public UpdateResourceExportTaskAttributeResponse UpdateResourceExportTaskAttributeWithOptions(string exportTaskId, UpdateResourceExportTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigPath))
            {
                body["configPath"] = request.ConfigPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeRules))
            {
                body["excludeRules"] = request.ExcludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportToModule))
            {
                body["exportToModule"] = request.ExportToModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRules))
            {
                body["includeRules"] = request.IncludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceExportTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceExportTaskAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceExportTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceExportTaskAttributeResponse
        /// </returns>
        public async Task<UpdateResourceExportTaskAttributeResponse> UpdateResourceExportTaskAttributeWithOptionsAsync(string exportTaskId, UpdateResourceExportTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigPath))
            {
                body["configPath"] = request.ConfigPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExcludeRules))
            {
                body["excludeRules"] = request.ExcludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExportToModule))
            {
                body["exportToModule"] = request.ExportToModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeRules))
            {
                body["includeRules"] = request.IncludeRules;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformProviderVersion))
            {
                body["terraformProviderVersion"] = request.TerraformProviderVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Variables))
            {
                body["variables"] = request.Variables;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourceExportTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/exportTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(exportTaskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourceExportTaskAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceExportTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceExportTaskAttributeResponse
        /// </returns>
        public UpdateResourceExportTaskAttributeResponse UpdateResourceExportTaskAttribute(string exportTaskId, UpdateResourceExportTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourceExportTaskAttributeWithOptions(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新导出任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateResourceExportTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateResourceExportTaskAttributeResponse
        /// </returns>
        public async Task<UpdateResourceExportTaskAttributeResponse> UpdateResourceExportTaskAttributeAsync(string exportTaskId, UpdateResourceExportTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourceExportTaskAttributeWithOptionsAsync(exportTaskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAttributeResponse
        /// </returns>
        public UpdateTaskAttributeResponse UpdateTaskAttributeWithOptions(string taskId, UpdateTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["initModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionStrategy))
            {
                body["protectionStrategy"] = request.ProtectionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPropertyValidation))
            {
                body["skipPropertyValidation"] = request.SkipPropertyValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerValue))
            {
                body["triggerValue"] = request.TriggerValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskAttributeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskAttributeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAttributeResponse
        /// </returns>
        public async Task<UpdateTaskAttributeResponse> UpdateTaskAttributeWithOptionsAsync(string taskId, UpdateTaskAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoApply))
            {
                body["autoApply"] = request.AutoApply;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDestroy))
            {
                body["autoDestroy"] = request.AutoDestroy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupInfo))
            {
                body["groupInfo"] = request.GroupInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitModuleState))
            {
                body["initModuleState"] = request.InitModuleState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleId))
            {
                body["moduleId"] = request.ModuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModuleVersion))
            {
                body["moduleVersion"] = request.ModuleVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProtectionStrategy))
            {
                body["protectionStrategy"] = request.ProtectionStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                body["ramRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipPropertyValidation))
            {
                body["skipPropertyValidation"] = request.SkipPropertyValidation;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerraformVersion))
            {
                body["terraformVersion"] = request.TerraformVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerStrategy))
            {
                body["triggerStrategy"] = request.TriggerStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TriggerValue))
            {
                body["triggerValue"] = request.TriggerValue;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskAttribute",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAttributeResponse
        /// </returns>
        public UpdateTaskAttributeResponse UpdateTaskAttribute(string taskId, UpdateTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTaskAttributeWithOptions(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskAttributeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskAttributeResponse
        /// </returns>
        public async Task<UpdateTaskAttributeResponse> UpdateTaskAttributeAsync(string taskId, UpdateTaskAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTaskAttributeWithOptionsAsync(taskId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组优先级配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskPolicyResponse
        /// </returns>
        public UpdateTaskPolicyResponse UpdateTaskPolicyWithOptions(string groupId, UpdateTaskPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPolicies))
            {
                body["taskPolicies"] = request.TaskPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskPolicy",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/task/policy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskPolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组优先级配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskPolicyRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskPolicyResponse
        /// </returns>
        public async Task<UpdateTaskPolicyResponse> UpdateTaskPolicyWithOptionsAsync(string groupId, UpdateTaskPolicyRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                body["clientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskPolicies))
            {
                body["taskPolicies"] = request.TaskPolicies;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTaskPolicy",
                Version = "2021-08-06",
                Protocol = "HTTPS",
                Pathname = "/group/task/policy/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(groupId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTaskPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组优先级配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskPolicyResponse
        /// </returns>
        public UpdateTaskPolicyResponse UpdateTaskPolicy(string groupId, UpdateTaskPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTaskPolicyWithOptions(groupId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改分组优先级配置</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTaskPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTaskPolicyResponse
        /// </returns>
        public async Task<UpdateTaskPolicyResponse> UpdateTaskPolicyAsync(string groupId, UpdateTaskPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTaskPolicyWithOptionsAsync(groupId, request, headers, runtime);
        }

    }
}
