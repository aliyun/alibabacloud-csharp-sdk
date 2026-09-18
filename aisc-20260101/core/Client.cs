// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AISC20260101.Models;

namespace AlibabaCloud.SDK.AISC20260101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-zhangjiakou", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-wulanchabu", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-qingdao", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-nanjing", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-huhehaote", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-guangzhou", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-beijing", "aisc.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-7", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-6", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-2", "aisc.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"eu-central-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "aisc.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou-finance", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-heyuan-acdr-1", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-shanghai-finance-1", "aisc.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "aisc.cn-shanghai.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("aisc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates an AI Red Teaming scan target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an attack target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.
        /// This is a synchronous call. Upon success, the system-generated TargetId is returned in Data. You can use this TargetId as a parameter in subsequent calls such as TestConnectivity and scan task creation.
        /// Metric description:</para>
        /// <list type="bullet">
        /// <item><description>When ConnectionMethod is set to enterprise_relay (access through a corporate internal network agent), the values of Endpoint and ModelName are ignored. The platform uses fixed internal network values. The actual target endpoint and credentials are held by the corporate internal network agent.</description></item>
        /// <item><description>After ApiKey is submitted, it is encrypted and stored. Subsequent queries do not return the plaintext value.</description></item>
        /// <item><description>ConnectionConfig is a JSON character string in JSON format that specifies advanced connection settings. For common provider templates, refer to the metric description of this parameter.
        /// After the target is created, its initial connectivity status is verified. You can call TestConnectivity at any time to re-verify.
        /// Internal network access (enterprise_relay) workflow:</description></item>
        /// <item><description>After the target is created, invoke GenerateRelayPollerScript to obtain an installation script (Linux only) and run it on a machine within the corporate internal network. The actual target endpoint and credentials are entered interactively during installation. The platform does not retain them.</description></item>
        /// <item><description>After installation, the poller automatically registers and enters a polling loop. No manual registration or polling invocations are required.</description></item>
        /// <item><description>After invoking TestConnectivity to authenticate end-to-end connectivity, you can use CreateTargetScanTask to initiate a scan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAttackTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAttackTargetResponse
        /// </returns>
        public CreateAttackTargetResponse CreateAttackTargetWithOptions(CreateAttackTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionConfig))
            {
                query["ConnectionConfig"] = request.ConnectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionMethod))
            {
                query["ConnectionMethod"] = request.ConnectionMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetName))
            {
                query["TargetName"] = request.TargetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAttackTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAttackTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AI Red Teaming scan target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an attack target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.
        /// This is a synchronous call. Upon success, the system-generated TargetId is returned in Data. You can use this TargetId as a parameter in subsequent calls such as TestConnectivity and scan task creation.
        /// Metric description:</para>
        /// <list type="bullet">
        /// <item><description>When ConnectionMethod is set to enterprise_relay (access through a corporate internal network agent), the values of Endpoint and ModelName are ignored. The platform uses fixed internal network values. The actual target endpoint and credentials are held by the corporate internal network agent.</description></item>
        /// <item><description>After ApiKey is submitted, it is encrypted and stored. Subsequent queries do not return the plaintext value.</description></item>
        /// <item><description>ConnectionConfig is a JSON character string in JSON format that specifies advanced connection settings. For common provider templates, refer to the metric description of this parameter.
        /// After the target is created, its initial connectivity status is verified. You can call TestConnectivity at any time to re-verify.
        /// Internal network access (enterprise_relay) workflow:</description></item>
        /// <item><description>After the target is created, invoke GenerateRelayPollerScript to obtain an installation script (Linux only) and run it on a machine within the corporate internal network. The actual target endpoint and credentials are entered interactively during installation. The platform does not retain them.</description></item>
        /// <item><description>After installation, the poller automatically registers and enters a polling loop. No manual registration or polling invocations are required.</description></item>
        /// <item><description>After invoking TestConnectivity to authenticate end-to-end connectivity, you can use CreateTargetScanTask to initiate a scan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAttackTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAttackTargetResponse
        /// </returns>
        public async Task<CreateAttackTargetResponse> CreateAttackTargetWithOptionsAsync(CreateAttackTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionConfig))
            {
                query["ConnectionConfig"] = request.ConnectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionMethod))
            {
                query["ConnectionMethod"] = request.ConnectionMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetName))
            {
                query["TargetName"] = request.TargetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAttackTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAttackTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AI Red Teaming scan target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an attack target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.
        /// This is a synchronous call. Upon success, the system-generated TargetId is returned in Data. You can use this TargetId as a parameter in subsequent calls such as TestConnectivity and scan task creation.
        /// Metric description:</para>
        /// <list type="bullet">
        /// <item><description>When ConnectionMethod is set to enterprise_relay (access through a corporate internal network agent), the values of Endpoint and ModelName are ignored. The platform uses fixed internal network values. The actual target endpoint and credentials are held by the corporate internal network agent.</description></item>
        /// <item><description>After ApiKey is submitted, it is encrypted and stored. Subsequent queries do not return the plaintext value.</description></item>
        /// <item><description>ConnectionConfig is a JSON character string in JSON format that specifies advanced connection settings. For common provider templates, refer to the metric description of this parameter.
        /// After the target is created, its initial connectivity status is verified. You can call TestConnectivity at any time to re-verify.
        /// Internal network access (enterprise_relay) workflow:</description></item>
        /// <item><description>After the target is created, invoke GenerateRelayPollerScript to obtain an installation script (Linux only) and run it on a machine within the corporate internal network. The actual target endpoint and credentials are entered interactively during installation. The platform does not retain them.</description></item>
        /// <item><description>After installation, the poller automatically registers and enters a polling loop. No manual registration or polling invocations are required.</description></item>
        /// <item><description>After invoking TestConnectivity to authenticate end-to-end connectivity, you can use CreateTargetScanTask to initiate a scan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAttackTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAttackTargetResponse
        /// </returns>
        public CreateAttackTargetResponse CreateAttackTarget(CreateAttackTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAttackTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an AI Red Teaming scan target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates an attack target (agent or model) and saves its connection configuration for subsequent connectivity tests and scan tasks.
        /// This is a synchronous call. Upon success, the system-generated TargetId is returned in Data. You can use this TargetId as a parameter in subsequent calls such as TestConnectivity and scan task creation.
        /// Metric description:</para>
        /// <list type="bullet">
        /// <item><description>When ConnectionMethod is set to enterprise_relay (access through a corporate internal network agent), the values of Endpoint and ModelName are ignored. The platform uses fixed internal network values. The actual target endpoint and credentials are held by the corporate internal network agent.</description></item>
        /// <item><description>After ApiKey is submitted, it is encrypted and stored. Subsequent queries do not return the plaintext value.</description></item>
        /// <item><description>ConnectionConfig is a JSON character string in JSON format that specifies advanced connection settings. For common provider templates, refer to the metric description of this parameter.
        /// After the target is created, its initial connectivity status is verified. You can call TestConnectivity at any time to re-verify.
        /// Internal network access (enterprise_relay) workflow:</description></item>
        /// <item><description>After the target is created, invoke GenerateRelayPollerScript to obtain an installation script (Linux only) and run it on a machine within the corporate internal network. The actual target endpoint and credentials are entered interactively during installation. The platform does not retain them.</description></item>
        /// <item><description>After installation, the poller automatically registers and enters a polling loop. No manual registration or polling invocations are required.</description></item>
        /// <item><description>After invoking TestConnectivity to authenticate end-to-end connectivity, you can use CreateTargetScanTask to initiate a scan.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateAttackTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAttackTargetResponse
        /// </returns>
        public async Task<CreateAttackTargetResponse> CreateAttackTargetAsync(CreateAttackTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAttackTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public CreateSkillFileCheckResponse CreateSkillFileCheckWithOptions(CreateSkillFileCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                query["Files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillFileCheck",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillFileCheckResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public async Task<CreateSkillFileCheckResponse> CreateSkillFileCheckWithOptionsAsync(CreateSkillFileCheckRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Files))
            {
                query["Files"] = request.Files;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSkillFileCheck",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSkillFileCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public CreateSkillFileCheckResponse CreateSkillFileCheck(CreateSkillFileCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSkillFileCheckWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates batch detection for user-defined skills.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSkillFileCheckRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSkillFileCheckResponse
        /// </returns>
        public async Task<CreateSkillFileCheckResponse> CreateSkillFileCheckAsync(CreateSkillFileCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSkillFileCheckWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a security scan task against a scan target that has passed connectivity verification. After the task is created, it is asynchronously prepared and executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/asc/user-guide/ai-red-teaming#aefbf9b5b4noh">pricing</a> of AI Red Teaming.</em>*
        /// Initiates a security scan (AI Red Teaming detection) task against a specified scan target.
        /// Before you begin:</para>
        /// <list type="bullet">
        /// <item><description>The account must have a normal subscription status. Otherwise, a 403 error is returned.</description></item>
        /// <item><description>The TargetId must exist and belong to the current tenant.</description></item>
        /// <item><description>The connectivity verification status of the target must be verified. You can call TestConnectivity to verify the target first. Otherwise, a 400 error is returned.</description></item>
        /// <item><description>Available attack samples must exist within the current scan scope. Otherwise, a 400 error is returned.
        /// Execution mode:</description></item>
        /// <item><description>The call synchronously returns a TaskId. The initial task status is PREPARING. Sample preparation and scan execution are performed asynchronously. You can call ListScanTasksByTarget to query the task status and progress.
        /// Sample selection:</description></item>
        /// <item><description>The sample scope is determined based on the target type (agent/model) plus general-purpose samples. SampleLevel determines the detection intensity and derives the technique level. Lang is used to filter samples by language.</description></item>
        /// <item><description>If no sample intent is specified, the system automatically derives all available intents based on the scope described above.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTargetScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTargetScanTaskResponse
        /// </returns>
        public CreateTargetScanTaskResponse CreateTargetScanTaskWithOptions(CreateTargetScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLevel))
            {
                query["SampleLevel"] = request.SampleLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTargetScanTask",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTargetScanTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a security scan task against a scan target that has passed connectivity verification. After the task is created, it is asynchronously prepared and executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/asc/user-guide/ai-red-teaming#aefbf9b5b4noh">pricing</a> of AI Red Teaming.</em>*
        /// Initiates a security scan (AI Red Teaming detection) task against a specified scan target.
        /// Before you begin:</para>
        /// <list type="bullet">
        /// <item><description>The account must have a normal subscription status. Otherwise, a 403 error is returned.</description></item>
        /// <item><description>The TargetId must exist and belong to the current tenant.</description></item>
        /// <item><description>The connectivity verification status of the target must be verified. You can call TestConnectivity to verify the target first. Otherwise, a 400 error is returned.</description></item>
        /// <item><description>Available attack samples must exist within the current scan scope. Otherwise, a 400 error is returned.
        /// Execution mode:</description></item>
        /// <item><description>The call synchronously returns a TaskId. The initial task status is PREPARING. Sample preparation and scan execution are performed asynchronously. You can call ListScanTasksByTarget to query the task status and progress.
        /// Sample selection:</description></item>
        /// <item><description>The sample scope is determined based on the target type (agent/model) plus general-purpose samples. SampleLevel determines the detection intensity and derives the technique level. Lang is used to filter samples by language.</description></item>
        /// <item><description>If no sample intent is specified, the system automatically derives all available intents based on the scope described above.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTargetScanTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTargetScanTaskResponse
        /// </returns>
        public async Task<CreateTargetScanTaskResponse> CreateTargetScanTaskWithOptionsAsync(CreateTargetScanTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLevel))
            {
                query["SampleLevel"] = request.SampleLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTargetScanTask",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTargetScanTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a security scan task against a scan target that has passed connectivity verification. After the task is created, it is asynchronously prepared and executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/asc/user-guide/ai-red-teaming#aefbf9b5b4noh">pricing</a> of AI Red Teaming.</em>*
        /// Initiates a security scan (AI Red Teaming detection) task against a specified scan target.
        /// Before you begin:</para>
        /// <list type="bullet">
        /// <item><description>The account must have a normal subscription status. Otherwise, a 403 error is returned.</description></item>
        /// <item><description>The TargetId must exist and belong to the current tenant.</description></item>
        /// <item><description>The connectivity verification status of the target must be verified. You can call TestConnectivity to verify the target first. Otherwise, a 400 error is returned.</description></item>
        /// <item><description>Available attack samples must exist within the current scan scope. Otherwise, a 400 error is returned.
        /// Execution mode:</description></item>
        /// <item><description>The call synchronously returns a TaskId. The initial task status is PREPARING. Sample preparation and scan execution are performed asynchronously. You can call ListScanTasksByTarget to query the task status and progress.
        /// Sample selection:</description></item>
        /// <item><description>The sample scope is determined based on the target type (agent/model) plus general-purpose samples. SampleLevel determines the detection intensity and derives the technique level. Lang is used to filter samples by language.</description></item>
        /// <item><description>If no sample intent is specified, the system automatically derives all available intents based on the scope described above.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTargetScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTargetScanTaskResponse
        /// </returns>
        public CreateTargetScanTaskResponse CreateTargetScanTask(CreateTargetScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTargetScanTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Initiates a security scan task against a scan target that has passed connectivity verification. After the task is created, it is asynchronously prepared and executed.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para><em>Before you use this operation, make sure that you fully understand the billing method and <a href="https://www.alibabacloud.com/help/en/asc/user-guide/ai-red-teaming#aefbf9b5b4noh">pricing</a> of AI Red Teaming.</em>*
        /// Initiates a security scan (AI Red Teaming detection) task against a specified scan target.
        /// Before you begin:</para>
        /// <list type="bullet">
        /// <item><description>The account must have a normal subscription status. Otherwise, a 403 error is returned.</description></item>
        /// <item><description>The TargetId must exist and belong to the current tenant.</description></item>
        /// <item><description>The connectivity verification status of the target must be verified. You can call TestConnectivity to verify the target first. Otherwise, a 400 error is returned.</description></item>
        /// <item><description>Available attack samples must exist within the current scan scope. Otherwise, a 400 error is returned.
        /// Execution mode:</description></item>
        /// <item><description>The call synchronously returns a TaskId. The initial task status is PREPARING. Sample preparation and scan execution are performed asynchronously. You can call ListScanTasksByTarget to query the task status and progress.
        /// Sample selection:</description></item>
        /// <item><description>The sample scope is determined based on the target type (agent/model) plus general-purpose samples. SampleLevel determines the detection intensity and derives the technique level. Lang is used to filter samples by language.</description></item>
        /// <item><description>If no sample intent is specified, the system automatically derives all available intents based on the scope described above.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTargetScanTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTargetScanTaskResponse
        /// </returns>
        public async Task<CreateTargetScanTaskResponse> CreateTargetScanTaskAsync(CreateTargetScanTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTargetScanTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified scan target by TargetId in AI Red Teaming. The target is physically deleted and cannot be recovered. This operation does not stop scan tasks that are in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified scan target by TargetId. The target is physically deleted.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only targets that belong to the current tenant. If the target does not exist or belongs to another tenant, a 400 error is returned. This prevents exposing whether the resource exists.</description></item>
        /// <item><description>Physical deletion: The target cannot be recovered after deletion. Confirm before you proceed.</description></item>
        /// <item><description>This operation deletes only the target record. It does not stop scan tasks that are in progress for the target or delete historical scan task records. To stop or clean up tasks, call StopScannerTask or DeleteScannerTask first.</description></item>
        /// <item><description>After deletion, the connection configurations of the target, including encrypted credentials and connectivity verification results, are also removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAttackTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAttackTargetResponse
        /// </returns>
        public DeleteAttackTargetResponse DeleteAttackTargetWithOptions(DeleteAttackTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAttackTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAttackTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified scan target by TargetId in AI Red Teaming. The target is physically deleted and cannot be recovered. This operation does not stop scan tasks that are in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified scan target by TargetId. The target is physically deleted.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only targets that belong to the current tenant. If the target does not exist or belongs to another tenant, a 400 error is returned. This prevents exposing whether the resource exists.</description></item>
        /// <item><description>Physical deletion: The target cannot be recovered after deletion. Confirm before you proceed.</description></item>
        /// <item><description>This operation deletes only the target record. It does not stop scan tasks that are in progress for the target or delete historical scan task records. To stop or clean up tasks, call StopScannerTask or DeleteScannerTask first.</description></item>
        /// <item><description>After deletion, the connection configurations of the target, including encrypted credentials and connectivity verification results, are also removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAttackTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAttackTargetResponse
        /// </returns>
        public async Task<DeleteAttackTargetResponse> DeleteAttackTargetWithOptionsAsync(DeleteAttackTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAttackTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAttackTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified scan target by TargetId in AI Red Teaming. The target is physically deleted and cannot be recovered. This operation does not stop scan tasks that are in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified scan target by TargetId. The target is physically deleted.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only targets that belong to the current tenant. If the target does not exist or belongs to another tenant, a 400 error is returned. This prevents exposing whether the resource exists.</description></item>
        /// <item><description>Physical deletion: The target cannot be recovered after deletion. Confirm before you proceed.</description></item>
        /// <item><description>This operation deletes only the target record. It does not stop scan tasks that are in progress for the target or delete historical scan task records. To stop or clean up tasks, call StopScannerTask or DeleteScannerTask first.</description></item>
        /// <item><description>After deletion, the connection configurations of the target, including encrypted credentials and connectivity verification results, are also removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAttackTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAttackTargetResponse
        /// </returns>
        public DeleteAttackTargetResponse DeleteAttackTarget(DeleteAttackTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAttackTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a specified scan target by TargetId in AI Red Teaming. The target is physically deleted and cannot be recovered. This operation does not stop scan tasks that are in progress.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified scan target by TargetId. The target is physically deleted.</para>
        /// <list type="bullet">
        /// <item><description>You can delete only targets that belong to the current tenant. If the target does not exist or belongs to another tenant, a 400 error is returned. This prevents exposing whether the resource exists.</description></item>
        /// <item><description>Physical deletion: The target cannot be recovered after deletion. Confirm before you proceed.</description></item>
        /// <item><description>This operation deletes only the target record. It does not stop scan tasks that are in progress for the target or delete historical scan task records. To stop or clean up tasks, call StopScannerTask or DeleteScannerTask first.</description></item>
        /// <item><description>After deletion, the connection configurations of the target, including encrypted credentials and connectivity verification results, are also removed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteAttackTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAttackTargetResponse
        /// </returns>
        public async Task<DeleteAttackTargetResponse> DeleteAttackTargetAsync(DeleteAttackTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAttackTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Physically deletes a specified scan task by ScannerTaskId in AI Red Teaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Physically deletes a specified scan task by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>Only tasks that belong to the current tenant can be deleted. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>If the task is in progress (sample preparation, waiting, processing, or report generation), the task is automatically canceled before deletion. A cancellation failure does not block the deletion.</description></item>
        /// <item><description>Physical deletion: After deletion, the task record and its status and progress information cannot be queried or recovered. Confirm before you delete.</description></item>
        /// <item><description>Deleting a task record does not affect the scan target itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScannerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScannerTaskResponse
        /// </returns>
        public DeleteScannerTaskResponse DeleteScannerTaskWithOptions(DeleteScannerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScannerTask",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScannerTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Physically deletes a specified scan task by ScannerTaskId in AI Red Teaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Physically deletes a specified scan task by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>Only tasks that belong to the current tenant can be deleted. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>If the task is in progress (sample preparation, waiting, processing, or report generation), the task is automatically canceled before deletion. A cancellation failure does not block the deletion.</description></item>
        /// <item><description>Physical deletion: After deletion, the task record and its status and progress information cannot be queried or recovered. Confirm before you delete.</description></item>
        /// <item><description>Deleting a task record does not affect the scan target itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScannerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteScannerTaskResponse
        /// </returns>
        public async Task<DeleteScannerTaskResponse> DeleteScannerTaskWithOptionsAsync(DeleteScannerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScannerTask",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScannerTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Physically deletes a specified scan task by ScannerTaskId in AI Red Teaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Physically deletes a specified scan task by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>Only tasks that belong to the current tenant can be deleted. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>If the task is in progress (sample preparation, waiting, processing, or report generation), the task is automatically canceled before deletion. A cancellation failure does not block the deletion.</description></item>
        /// <item><description>Physical deletion: After deletion, the task record and its status and progress information cannot be queried or recovered. Confirm before you delete.</description></item>
        /// <item><description>Deleting a task record does not affect the scan target itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScannerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScannerTaskResponse
        /// </returns>
        public DeleteScannerTaskResponse DeleteScannerTask(DeleteScannerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScannerTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Physically deletes a specified scan task by ScannerTaskId in AI Red Teaming.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Physically deletes a specified scan task by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>Only tasks that belong to the current tenant can be deleted. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>If the task is in progress (sample preparation, waiting, processing, or report generation), the task is automatically canceled before deletion. A cancellation failure does not block the deletion.</description></item>
        /// <item><description>Physical deletion: After deletion, the task record and its status and progress information cannot be queried or recovered. Confirm before you delete.</description></item>
        /// <item><description>Deleting a task record does not affect the scan target itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteScannerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteScannerTaskResponse
        /// </returns>
        public async Task<DeleteScannerTaskResponse> DeleteScannerTaskAsync(DeleteScannerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScannerTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a one-time installation script for a scan target of the enterprise_relay type in AI Red Teaming. Only Linux platforms are supported. The script contains a one-time access code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates an installation script for the internal network agent (relay-poller) for a specified scan target.</para>
        /// <list type="bullet">
        /// <item><description>The target must use the enterprise_relay connection method (see CreateAttackTarget). Otherwise, HTTP status code 400 is returned. If the target does not exist or belongs to another tenant, HTTP status code 400 is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only Linux is supported for the platform. The Platform parameter uses the &quot;operating system-architecture&quot; format and accepts only linux-amd64 and linux-arm64. Compatible architecture values include amd64, x86_64, x86, arm64, and aarch64. If only the architecture is specified, the operating system defaults to linux. Other operating systems such as macOS and Windows return HTTP status code 400. If this parameter is not specified, the default value is linux-amd64.</description></item>
        /// <item><description>The script contains a one-time access code. Each call issues a new access code, and the previous code automatically expires. Re-downloading the script generates a new access code. Use the latest generated script for installation.</description></item>
        /// <item><description>The script contains a temporary download link (a signed link valid for 1 hour) and a checksum for the poller binary. The binary is available only for Linux in both architectures.</description></item>
        /// <item><description>The script does not contain the actual endpoint or credentials of the target. The installer interactively enters these values when running the script. The platform does not store them.</description></item>
        /// <item><description>After installation, the poller automatically completes registration and enters a polling cycle. The registration and polling operations are automatically called by the script and do not require manual invocation. You can call TestConnectivity to verify end-to-end connectivity.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateRelayPollerScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateRelayPollerScriptResponse
        /// </returns>
        public GenerateRelayPollerScriptResponse GenerateRelayPollerScriptWithOptions(GenerateRelayPollerScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateRelayPollerScript",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateRelayPollerScriptResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a one-time installation script for a scan target of the enterprise_relay type in AI Red Teaming. Only Linux platforms are supported. The script contains a one-time access code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates an installation script for the internal network agent (relay-poller) for a specified scan target.</para>
        /// <list type="bullet">
        /// <item><description>The target must use the enterprise_relay connection method (see CreateAttackTarget). Otherwise, HTTP status code 400 is returned. If the target does not exist or belongs to another tenant, HTTP status code 400 is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only Linux is supported for the platform. The Platform parameter uses the &quot;operating system-architecture&quot; format and accepts only linux-amd64 and linux-arm64. Compatible architecture values include amd64, x86_64, x86, arm64, and aarch64. If only the architecture is specified, the operating system defaults to linux. Other operating systems such as macOS and Windows return HTTP status code 400. If this parameter is not specified, the default value is linux-amd64.</description></item>
        /// <item><description>The script contains a one-time access code. Each call issues a new access code, and the previous code automatically expires. Re-downloading the script generates a new access code. Use the latest generated script for installation.</description></item>
        /// <item><description>The script contains a temporary download link (a signed link valid for 1 hour) and a checksum for the poller binary. The binary is available only for Linux in both architectures.</description></item>
        /// <item><description>The script does not contain the actual endpoint or credentials of the target. The installer interactively enters these values when running the script. The platform does not store them.</description></item>
        /// <item><description>After installation, the poller automatically completes registration and enters a polling cycle. The registration and polling operations are automatically called by the script and do not require manual invocation. You can call TestConnectivity to verify end-to-end connectivity.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateRelayPollerScriptRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateRelayPollerScriptResponse
        /// </returns>
        public async Task<GenerateRelayPollerScriptResponse> GenerateRelayPollerScriptWithOptionsAsync(GenerateRelayPollerScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                query["Platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateRelayPollerScript",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateRelayPollerScriptResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a one-time installation script for a scan target of the enterprise_relay type in AI Red Teaming. Only Linux platforms are supported. The script contains a one-time access code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates an installation script for the internal network agent (relay-poller) for a specified scan target.</para>
        /// <list type="bullet">
        /// <item><description>The target must use the enterprise_relay connection method (see CreateAttackTarget). Otherwise, HTTP status code 400 is returned. If the target does not exist or belongs to another tenant, HTTP status code 400 is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only Linux is supported for the platform. The Platform parameter uses the &quot;operating system-architecture&quot; format and accepts only linux-amd64 and linux-arm64. Compatible architecture values include amd64, x86_64, x86, arm64, and aarch64. If only the architecture is specified, the operating system defaults to linux. Other operating systems such as macOS and Windows return HTTP status code 400. If this parameter is not specified, the default value is linux-amd64.</description></item>
        /// <item><description>The script contains a one-time access code. Each call issues a new access code, and the previous code automatically expires. Re-downloading the script generates a new access code. Use the latest generated script for installation.</description></item>
        /// <item><description>The script contains a temporary download link (a signed link valid for 1 hour) and a checksum for the poller binary. The binary is available only for Linux in both architectures.</description></item>
        /// <item><description>The script does not contain the actual endpoint or credentials of the target. The installer interactively enters these values when running the script. The platform does not store them.</description></item>
        /// <item><description>After installation, the poller automatically completes registration and enters a polling cycle. The registration and polling operations are automatically called by the script and do not require manual invocation. You can call TestConnectivity to verify end-to-end connectivity.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateRelayPollerScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateRelayPollerScriptResponse
        /// </returns>
        public GenerateRelayPollerScriptResponse GenerateRelayPollerScript(GenerateRelayPollerScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateRelayPollerScriptWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a one-time installation script for a scan target of the enterprise_relay type in AI Red Teaming. Only Linux platforms are supported. The script contains a one-time access code.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Generates an installation script for the internal network agent (relay-poller) for a specified scan target.</para>
        /// <list type="bullet">
        /// <item><description>The target must use the enterprise_relay connection method (see CreateAttackTarget). Otherwise, HTTP status code 400 is returned. If the target does not exist or belongs to another tenant, HTTP status code 400 is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only Linux is supported for the platform. The Platform parameter uses the &quot;operating system-architecture&quot; format and accepts only linux-amd64 and linux-arm64. Compatible architecture values include amd64, x86_64, x86, arm64, and aarch64. If only the architecture is specified, the operating system defaults to linux. Other operating systems such as macOS and Windows return HTTP status code 400. If this parameter is not specified, the default value is linux-amd64.</description></item>
        /// <item><description>The script contains a one-time access code. Each call issues a new access code, and the previous code automatically expires. Re-downloading the script generates a new access code. Use the latest generated script for installation.</description></item>
        /// <item><description>The script contains a temporary download link (a signed link valid for 1 hour) and a checksum for the poller binary. The binary is available only for Linux in both architectures.</description></item>
        /// <item><description>The script does not contain the actual endpoint or credentials of the target. The installer interactively enters these values when running the script. The platform does not store them.</description></item>
        /// <item><description>After installation, the poller automatically completes registration and enters a polling cycle. The registration and polling operations are automatically called by the script and do not require manual invocation. You can call TestConnectivity to verify end-to-end connectivity.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GenerateRelayPollerScriptRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateRelayPollerScriptResponse
        /// </returns>
        public async Task<GenerateRelayPollerScriptResponse> GenerateRelayPollerScriptAsync(GenerateRelayPollerScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateRelayPollerScriptWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a scan target by TargetId for AI Red Teaming, including connection configuration and scan task configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a scan target by TargetId.</para>
        /// <list type="bullet">
        /// <item><description>Only targets that belong to the current tenant can be queried. If the target does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The response includes basic target information, advanced connection configuration (ConnectionConfig), and scan task configuration (ScanTaskConfig).</description></item>
        /// <item><description>The following six aggregate fields are not populated by this operation and return empty values: cumulative scan count (ScanCount), last scan status (LastScanStatus), risk level (RiskLevel), first scan time (FirstScanTime), last scan time (LastScanTime), and last scan failure reason (LastScanFailMessage). Query these fields by calling ListAttackTargets or ListScanTasksByTarget.</description></item>
        /// <item><description>The response does not include sensitive credentials such as ApiKey in plaintext.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAttackTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttackTargetResponse
        /// </returns>
        public GetAttackTargetResponse GetAttackTargetWithOptions(GetAttackTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttackTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttackTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a scan target by TargetId for AI Red Teaming, including connection configuration and scan task configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a scan target by TargetId.</para>
        /// <list type="bullet">
        /// <item><description>Only targets that belong to the current tenant can be queried. If the target does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The response includes basic target information, advanced connection configuration (ConnectionConfig), and scan task configuration (ScanTaskConfig).</description></item>
        /// <item><description>The following six aggregate fields are not populated by this operation and return empty values: cumulative scan count (ScanCount), last scan status (LastScanStatus), risk level (RiskLevel), first scan time (FirstScanTime), last scan time (LastScanTime), and last scan failure reason (LastScanFailMessage). Query these fields by calling ListAttackTargets or ListScanTasksByTarget.</description></item>
        /// <item><description>The response does not include sensitive credentials such as ApiKey in plaintext.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAttackTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAttackTargetResponse
        /// </returns>
        public async Task<GetAttackTargetResponse> GetAttackTargetWithOptionsAsync(GetAttackTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAttackTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAttackTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a scan target by TargetId for AI Red Teaming, including connection configuration and scan task configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a scan target by TargetId.</para>
        /// <list type="bullet">
        /// <item><description>Only targets that belong to the current tenant can be queried. If the target does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The response includes basic target information, advanced connection configuration (ConnectionConfig), and scan task configuration (ScanTaskConfig).</description></item>
        /// <item><description>The following six aggregate fields are not populated by this operation and return empty values: cumulative scan count (ScanCount), last scan status (LastScanStatus), risk level (RiskLevel), first scan time (FirstScanTime), last scan time (LastScanTime), and last scan failure reason (LastScanFailMessage). Query these fields by calling ListAttackTargets or ListScanTasksByTarget.</description></item>
        /// <item><description>The response does not include sensitive credentials such as ApiKey in plaintext.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAttackTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttackTargetResponse
        /// </returns>
        public GetAttackTargetResponse GetAttackTarget(GetAttackTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAttackTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a scan target by TargetId for AI Red Teaming, including connection configuration and scan task configuration.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the details of a scan target by TargetId.</para>
        /// <list type="bullet">
        /// <item><description>Only targets that belong to the current tenant can be queried. If the target does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The response includes basic target information, advanced connection configuration (ConnectionConfig), and scan task configuration (ScanTaskConfig).</description></item>
        /// <item><description>The following six aggregate fields are not populated by this operation and return empty values: cumulative scan count (ScanCount), last scan status (LastScanStatus), risk level (RiskLevel), first scan time (FirstScanTime), last scan time (LastScanTime), and last scan failure reason (LastScanFailMessage). Query these fields by calling ListAttackTargets or ListScanTasksByTarget.</description></item>
        /// <item><description>The response does not include sensitive credentials such as ApiKey in plaintext.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetAttackTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAttackTargetResponse
        /// </returns>
        public async Task<GetAttackTargetResponse> GetAttackTargetAsync(GetAttackTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAttackTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task in AI Red Teaming. The URL is valid for 2 hours. An empty string is returned if the data has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>ScannerTaskId is required in practice. An empty value returns HTTP status code 400.</description></item>
        /// <item><description>You can query only tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, HTTP status code 400 is returned uniformly to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL of Object Storage Service (OSS) that is valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the attack hit data has not been generated (for existing tasks or when the agent execution mode does not produce hit data), the download URL in the response is an empty string. No error is returned.</description></item>
        /// <item><description>This operation is a read-only action (with the Get prefix). A RAM user with read-only permissions can call this operation. The behavior is consistent with the deprecated GenerateScannerTaskHitDataUrl operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskHitDataUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskHitDataUrlResponse
        /// </returns>
        public GetScannerTaskHitDataUrlResponse GetScannerTaskHitDataUrlWithOptions(GetScannerTaskHitDataUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScannerTaskHitDataUrl",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScannerTaskHitDataUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task in AI Red Teaming. The URL is valid for 2 hours. An empty string is returned if the data has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>ScannerTaskId is required in practice. An empty value returns HTTP status code 400.</description></item>
        /// <item><description>You can query only tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, HTTP status code 400 is returned uniformly to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL of Object Storage Service (OSS) that is valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the attack hit data has not been generated (for existing tasks or when the agent execution mode does not produce hit data), the download URL in the response is an empty string. No error is returned.</description></item>
        /// <item><description>This operation is a read-only action (with the Get prefix). A RAM user with read-only permissions can call this operation. The behavior is consistent with the deprecated GenerateScannerTaskHitDataUrl operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskHitDataUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskHitDataUrlResponse
        /// </returns>
        public async Task<GetScannerTaskHitDataUrlResponse> GetScannerTaskHitDataUrlWithOptionsAsync(GetScannerTaskHitDataUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScannerTaskHitDataUrl",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScannerTaskHitDataUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task in AI Red Teaming. The URL is valid for 2 hours. An empty string is returned if the data has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>ScannerTaskId is required in practice. An empty value returns HTTP status code 400.</description></item>
        /// <item><description>You can query only tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, HTTP status code 400 is returned uniformly to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL of Object Storage Service (OSS) that is valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the attack hit data has not been generated (for existing tasks or when the agent execution mode does not produce hit data), the download URL in the response is an empty string. No error is returned.</description></item>
        /// <item><description>This operation is a read-only action (with the Get prefix). A RAM user with read-only permissions can call this operation. The behavior is consistent with the deprecated GenerateScannerTaskHitDataUrl operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskHitDataUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskHitDataUrlResponse
        /// </returns>
        public GetScannerTaskHitDataUrlResponse GetScannerTaskHitDataUrl(GetScannerTaskHitDataUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScannerTaskHitDataUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task in AI Red Teaming. The URL is valid for 2 hours. An empty string is returned if the data has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the attack hit data (hits.csv) of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>ScannerTaskId is required in practice. An empty value returns HTTP status code 400.</description></item>
        /// <item><description>You can query only tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, HTTP status code 400 is returned uniformly to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL of Object Storage Service (OSS) that is valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the attack hit data has not been generated (for existing tasks or when the agent execution mode does not produce hit data), the download URL in the response is an empty string. No error is returned.</description></item>
        /// <item><description>This operation is a read-only action (with the Get prefix). A RAM user with read-only permissions can call this operation. The behavior is consistent with the deprecated GenerateScannerTaskHitDataUrl operation.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskHitDataUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskHitDataUrlResponse
        /// </returns>
        public async Task<GetScannerTaskHitDataUrlResponse> GetScannerTaskHitDataUrlAsync(GetScannerTaskHitDataUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScannerTaskHitDataUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the HTML result report of an AI Red Teaming scan task. The URL is valid for 2 hours. An empty string is returned if the report has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the HTML result report of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>You can only query tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL from object storage, valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the task result report has not been generated (the task is not complete or the report has not been produced), the download URL in the response is an empty string and no error is returned. Call this operation after the task status changes to completed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskResultHtmlUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskResultHtmlUrlResponse
        /// </returns>
        public GetScannerTaskResultHtmlUrlResponse GetScannerTaskResultHtmlUrlWithOptions(GetScannerTaskResultHtmlUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScannerTaskResultHtmlUrl",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScannerTaskResultHtmlUrlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the HTML result report of an AI Red Teaming scan task. The URL is valid for 2 hours. An empty string is returned if the report has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the HTML result report of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>You can only query tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL from object storage, valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the task result report has not been generated (the task is not complete or the report has not been produced), the download URL in the response is an empty string and no error is returned. Call this operation after the task status changes to completed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskResultHtmlUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskResultHtmlUrlResponse
        /// </returns>
        public async Task<GetScannerTaskResultHtmlUrlResponse> GetScannerTaskResultHtmlUrlWithOptionsAsync(GetScannerTaskResultHtmlUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetScannerTaskResultHtmlUrl",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetScannerTaskResultHtmlUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the HTML result report of an AI Red Teaming scan task. The URL is valid for 2 hours. An empty string is returned if the report has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the HTML result report of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>You can only query tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL from object storage, valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the task result report has not been generated (the task is not complete or the report has not been produced), the download URL in the response is an empty string and no error is returned. Call this operation after the task status changes to completed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskResultHtmlUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskResultHtmlUrlResponse
        /// </returns>
        public GetScannerTaskResultHtmlUrlResponse GetScannerTaskResultHtmlUrl(GetScannerTaskResultHtmlUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetScannerTaskResultHtmlUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a temporary download URL for the HTML result report of an AI Red Teaming scan task. The URL is valid for 2 hours. An empty string is returned if the report has not been generated.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Retrieves a temporary download URL for the HTML result report of a specified scan task.</para>
        /// <list type="bullet">
        /// <item><description>You can only query tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned to avoid exposing whether the resource exists.</description></item>
        /// <item><description>The download URL is a signed temporary URL from object storage, valid for 2 hours (7,200 seconds). After the URL expires, call this operation again to obtain a new URL.</description></item>
        /// <item><description>If the task result report has not been generated (the task is not complete or the report has not been produced), the download URL in the response is an empty string and no error is returned. Call this operation after the task status changes to completed.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// GetScannerTaskResultHtmlUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// GetScannerTaskResultHtmlUrlResponse
        /// </returns>
        public async Task<GetScannerTaskResultHtmlUrlResponse> GetScannerTaskResultHtmlUrlAsync(GetScannerTaskResultHtmlUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetScannerTaskResultHtmlUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public ListAIAgentEventResponse ListAIAgentEventWithOptions(ListAIAgentEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                query["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                query["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraInstanceId))
            {
                query["InfraInstanceId"] = request.InfraInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraName))
            {
                query["InfraName"] = request.InfraName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraRegionId))
            {
                query["InfraRegionId"] = request.InfraRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectoryAccountId))
            {
                query["ResourceDirectoryAccountId"] = request.ResourceDirectoryAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskName))
            {
                query["RiskName"] = request.RiskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                query["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAIAgentEvent",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIAgentEventResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public async Task<ListAIAgentEventResponse> ListAIAgentEventWithOptionsAsync(ListAIAgentEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppName))
            {
                query["AppName"] = request.AppName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetName))
            {
                query["AssetName"] = request.AssetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AssetType))
            {
                query["AssetType"] = request.AssetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraInstanceId))
            {
                query["InfraInstanceId"] = request.InfraInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraName))
            {
                query["InfraName"] = request.InfraName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfraRegionId))
            {
                query["InfraRegionId"] = request.InfraRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["Lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceDirectoryAccountId))
            {
                query["ResourceDirectoryAccountId"] = request.ResourceDirectoryAccountId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskName))
            {
                query["RiskName"] = request.RiskName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                query["StatusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vendor))
            {
                query["Vendor"] = request.Vendor;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAIAgentEvent",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAIAgentEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public ListAIAgentEventResponse ListAIAgentEvent(ListAIAgentEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAIAgentEventWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves a list of agent risk events.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAIAgentEventRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAIAgentEventResponse
        /// </returns>
        public async Task<ListAIAgentEventResponse> ListAIAgentEventAsync(ListAIAgentEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAIAgentEventWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of scan targets for AI Red Teaming. This operation supports multi-dimensional filtering and sorting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttackTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAttackTargetsResponse
        /// </returns>
        public ListAttackTargetsResponse ListAttackTargetsWithOptions(ListAttackTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScanTimeEnd))
            {
                query["FirstScanTimeEnd"] = request.FirstScanTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScanTimeStart))
            {
                query["FirstScanTimeStart"] = request.FirstScanTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanStatus))
            {
                query["LastScanStatus"] = request.LastScanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeEnd))
            {
                query["LastScanTimeEnd"] = request.LastScanTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeStart))
            {
                query["LastScanTimeStart"] = request.LastScanTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetName))
            {
                query["TargetName"] = request.TargetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAttackTargets",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttackTargetsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of scan targets for AI Red Teaming. This operation supports multi-dimensional filtering and sorting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttackTargetsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAttackTargetsResponse
        /// </returns>
        public async Task<ListAttackTargetsResponse> ListAttackTargetsWithOptionsAsync(ListAttackTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScanTimeEnd))
            {
                query["FirstScanTimeEnd"] = request.FirstScanTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScanTimeStart))
            {
                query["FirstScanTimeStart"] = request.FirstScanTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanStatus))
            {
                query["LastScanStatus"] = request.LastScanStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeEnd))
            {
                query["LastScanTimeEnd"] = request.LastScanTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastScanTimeStart))
            {
                query["LastScanTimeStart"] = request.LastScanTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Provider))
            {
                query["Provider"] = request.Provider;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RiskLevel))
            {
                query["RiskLevel"] = request.RiskLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortField))
            {
                query["SortField"] = request.SortField;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrder))
            {
                query["SortOrder"] = request.SortOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetName))
            {
                query["TargetName"] = request.TargetName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetType))
            {
                query["TargetType"] = request.TargetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAttackTargets",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAttackTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of scan targets for AI Red Teaming. This operation supports multi-dimensional filtering and sorting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttackTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAttackTargetsResponse
        /// </returns>
        public ListAttackTargetsResponse ListAttackTargets(ListAttackTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAttackTargetsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the list of scan targets for AI Red Teaming. This operation supports multi-dimensional filtering and sorting.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAttackTargetsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAttackTargetsResponse
        /// </returns>
        public async Task<ListAttackTargetsResponse> ListAttackTargetsAsync(ListAttackTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAttackTargetsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of scan tasks under a specified scan target for AI Red Teaming. Supports filtering by detection intensity, task status, and scan mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of the scan task list under a specified scan target. Only tasks belonging to targets owned by the current tenant are returned.
        /// Query scope and sorting:</para>
        /// <list type="bullet">
        /// <item><description>Only tasks created within the last 366 days are returned.</description></item>
        /// <item><description>Results are sorted by creation time in descending order.</description></item>
        /// <item><description>TaskStatus filters by task status. ScanType filters by scan mode. The scan mode is stored in the task execute parameters. Historical tasks without a recorded scan mode are treated as attack.
        /// Paged query rules:</description></item>
        /// <item><description>PageNumber starts from 1. Values less than 1 are normalized to 1.</description></item>
        /// <item><description>PageSize defaults to 10, with a maximum of 100 per page. Values greater than 100 are clamped to 100. Values less than 1 return HTTP status code 400.</description></item>
        /// <item><description>The PageNumber and PageSize values in the response are the normalization values that actually take effect.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanTasksByTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScanTasksByTargetResponse
        /// </returns>
        public ListScanTasksByTargetResponse ListScanTasksByTargetWithOptions(ListScanTasksByTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLevel))
            {
                query["SampleLevel"] = request.SampleLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScanTasksByTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScanTasksByTargetResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of scan tasks under a specified scan target for AI Red Teaming. Supports filtering by detection intensity, task status, and scan mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of the scan task list under a specified scan target. Only tasks belonging to targets owned by the current tenant are returned.
        /// Query scope and sorting:</para>
        /// <list type="bullet">
        /// <item><description>Only tasks created within the last 366 days are returned.</description></item>
        /// <item><description>Results are sorted by creation time in descending order.</description></item>
        /// <item><description>TaskStatus filters by task status. ScanType filters by scan mode. The scan mode is stored in the task execute parameters. Historical tasks without a recorded scan mode are treated as attack.
        /// Paged query rules:</description></item>
        /// <item><description>PageNumber starts from 1. Values less than 1 are normalized to 1.</description></item>
        /// <item><description>PageSize defaults to 10, with a maximum of 100 per page. Values greater than 100 are clamped to 100. Values less than 1 return HTTP status code 400.</description></item>
        /// <item><description>The PageNumber and PageSize values in the response are the normalization values that actually take effect.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanTasksByTargetRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListScanTasksByTargetResponse
        /// </returns>
        public async Task<ListScanTasksByTargetResponse> ListScanTasksByTargetWithOptionsAsync(ListScanTasksByTargetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SampleLevel))
            {
                query["SampleLevel"] = request.SampleLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanType))
            {
                query["ScanType"] = request.ScanType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScanTasksByTarget",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScanTasksByTargetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of scan tasks under a specified scan target for AI Red Teaming. Supports filtering by detection intensity, task status, and scan mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of the scan task list under a specified scan target. Only tasks belonging to targets owned by the current tenant are returned.
        /// Query scope and sorting:</para>
        /// <list type="bullet">
        /// <item><description>Only tasks created within the last 366 days are returned.</description></item>
        /// <item><description>Results are sorted by creation time in descending order.</description></item>
        /// <item><description>TaskStatus filters by task status. ScanType filters by scan mode. The scan mode is stored in the task execute parameters. Historical tasks without a recorded scan mode are treated as attack.
        /// Paged query rules:</description></item>
        /// <item><description>PageNumber starts from 1. Values less than 1 are normalized to 1.</description></item>
        /// <item><description>PageSize defaults to 10, with a maximum of 100 per page. Values greater than 100 are clamped to 100. Values less than 1 return HTTP status code 400.</description></item>
        /// <item><description>The PageNumber and PageSize values in the response are the normalization values that actually take effect.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanTasksByTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScanTasksByTargetResponse
        /// </returns>
        public ListScanTasksByTargetResponse ListScanTasksByTarget(ListScanTasksByTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScanTasksByTargetWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs a paged query of scan tasks under a specified scan target for AI Red Teaming. Supports filtering by detection intensity, task status, and scan mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paged query of the scan task list under a specified scan target. Only tasks belonging to targets owned by the current tenant are returned.
        /// Query scope and sorting:</para>
        /// <list type="bullet">
        /// <item><description>Only tasks created within the last 366 days are returned.</description></item>
        /// <item><description>Results are sorted by creation time in descending order.</description></item>
        /// <item><description>TaskStatus filters by task status. ScanType filters by scan mode. The scan mode is stored in the task execute parameters. Historical tasks without a recorded scan mode are treated as attack.
        /// Paged query rules:</description></item>
        /// <item><description>PageNumber starts from 1. Values less than 1 are normalized to 1.</description></item>
        /// <item><description>PageSize defaults to 10, with a maximum of 100 per page. Values greater than 100 are clamped to 100. Values less than 1 return HTTP status code 400.</description></item>
        /// <item><description>The PageNumber and PageSize values in the response are the normalization values that actually take effect.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ListScanTasksByTargetRequest
        /// </param>
        /// 
        /// <returns>
        /// ListScanTasksByTargetResponse
        /// </returns>
        public async Task<ListScanTasksByTargetResponse> ListScanTasksByTargetAsync(ListScanTasksByTargetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScanTasksByTargetWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public ListSubTasksResponse ListSubTasksWithOptions(ListSubTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootTaskId))
            {
                query["RootTaskId"] = request.RootTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubTasks",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public async Task<ListSubTasksResponse> ListSubTasksWithOptionsAsync(ListSubTasksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RootTaskId))
            {
                query["RootTaskId"] = request.RootTaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                query["TaskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubTasks",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public ListSubTasksResponse ListSubTasks(ListSubTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubTasksWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get subtask information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSubTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSubTasksResponse
        /// </returns>
        public async Task<ListSubTasksResponse> ListSubTasksAsync(ListSubTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubTasksWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops (cancels) an in-progress scan task for AI Red Teaming. Calling this operation on a task that is already in a desired state is idempotent and performs no action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops (cancels) the scan task specified by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>You can only operate on tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only tasks in an in-progress state (sample preparation, waiting, processing, or report generation) are actually canceled. The task status is set to canceled, the end time is recorded, and the underlying execution job is stopped asynchronously.</description></item>
        /// <item><description>Idempotent: If the task is already in a desired state (completed, failed, timed out, or canceled), the call returns success without modifying the task.</description></item>
        /// <item><description>The underlying execution job is stopped asynchronously. A failure to stop the job does not affect the cancellation result of the task itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopScannerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopScannerTaskResponse
        /// </returns>
        public StopScannerTaskResponse StopScannerTaskWithOptions(StopScannerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopScannerTask",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopScannerTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops (cancels) an in-progress scan task for AI Red Teaming. Calling this operation on a task that is already in a desired state is idempotent and performs no action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops (cancels) the scan task specified by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>You can only operate on tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only tasks in an in-progress state (sample preparation, waiting, processing, or report generation) are actually canceled. The task status is set to canceled, the end time is recorded, and the underlying execution job is stopped asynchronously.</description></item>
        /// <item><description>Idempotent: If the task is already in a desired state (completed, failed, timed out, or canceled), the call returns success without modifying the task.</description></item>
        /// <item><description>The underlying execution job is stopped asynchronously. A failure to stop the job does not affect the cancellation result of the task itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopScannerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopScannerTaskResponse
        /// </returns>
        public async Task<StopScannerTaskResponse> StopScannerTaskWithOptionsAsync(StopScannerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScannerTaskId))
            {
                query["ScannerTaskId"] = request.ScannerTaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopScannerTask",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopScannerTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops (cancels) an in-progress scan task for AI Red Teaming. Calling this operation on a task that is already in a desired state is idempotent and performs no action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops (cancels) the scan task specified by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>You can only operate on tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only tasks in an in-progress state (sample preparation, waiting, processing, or report generation) are actually canceled. The task status is set to canceled, the end time is recorded, and the underlying execution job is stopped asynchronously.</description></item>
        /// <item><description>Idempotent: If the task is already in a desired state (completed, failed, timed out, or canceled), the call returns success without modifying the task.</description></item>
        /// <item><description>The underlying execution job is stopped asynchronously. A failure to stop the job does not affect the cancellation result of the task itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopScannerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopScannerTaskResponse
        /// </returns>
        public StopScannerTaskResponse StopScannerTask(StopScannerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopScannerTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops (cancels) an in-progress scan task for AI Red Teaming. Calling this operation on a task that is already in a desired state is idempotent and performs no action.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Stops (cancels) the scan task specified by ScannerTaskId.</para>
        /// <list type="bullet">
        /// <item><description>You can only operate on tasks that belong to the current tenant. If the task does not exist or belongs to another tenant, a 400 error is returned without exposing whether the resource exists.</description></item>
        /// <item><description>Only tasks in an in-progress state (sample preparation, waiting, processing, or report generation) are actually canceled. The task status is set to canceled, the end time is recorded, and the underlying execution job is stopped asynchronously.</description></item>
        /// <item><description>Idempotent: If the task is already in a desired state (completed, failed, timed out, or canceled), the call returns success without modifying the task.</description></item>
        /// <item><description>The underlying execution job is stopped asynchronously. A failure to stop the job does not affect the cancellation result of the task itself.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// StopScannerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// StopScannerTaskResponse
        /// </returns>
        public async Task<StopScannerTaskResponse> StopScannerTaskAsync(StopScannerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopScannerTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests the network connectivity and authentication validity of an AI Red Teaming target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the network connectivity and authentication validity of a specified attack target.
        /// This operation uses an asynchronous polling model:</para>
        /// <list type="bullet">
        /// <item><description>First call (without CheckId): Immediately returns a CheckId with VerifyStatus=checking. The actual test runs asynchronously in the background for up to 60 seconds.</description></item>
        /// <item><description>Subsequent calls (with the CheckId returned from the first call): Queries the latest status of the corresponding CheckId, which may be checking, verified, or failed.</description></item>
        /// <item><description>Poll at 2-second intervals for up to 60 seconds. After the CheckId expires, the operation returns failed with VerifyMessage set to &quot;check expired, please retry&quot;.
        /// Use one of the following two approaches for parameters:</description></item>
        /// <item><description>Approach A: Specify only TargetId. The system reads Endpoint, ApiKey, ModelName, ConnectionMethod, and ConnectionConfig from the saved target configuration and ignores any parameters with the same names in the request.</description></item>
        /// <item><description>Approach B: Do not specify TargetId. Instead, provide the five connection parameters directly in the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestConnectivityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestConnectivityResponse
        /// </returns>
        public TestConnectivityResponse TestConnectivityWithOptions(TestConnectivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionConfig))
            {
                query["ConnectionConfig"] = request.ConnectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionMethod))
            {
                query["ConnectionMethod"] = request.ConnectionMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestConnectivity",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestConnectivityResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests the network connectivity and authentication validity of an AI Red Teaming target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the network connectivity and authentication validity of a specified attack target.
        /// This operation uses an asynchronous polling model:</para>
        /// <list type="bullet">
        /// <item><description>First call (without CheckId): Immediately returns a CheckId with VerifyStatus=checking. The actual test runs asynchronously in the background for up to 60 seconds.</description></item>
        /// <item><description>Subsequent calls (with the CheckId returned from the first call): Queries the latest status of the corresponding CheckId, which may be checking, verified, or failed.</description></item>
        /// <item><description>Poll at 2-second intervals for up to 60 seconds. After the CheckId expires, the operation returns failed with VerifyMessage set to &quot;check expired, please retry&quot;.
        /// Use one of the following two approaches for parameters:</description></item>
        /// <item><description>Approach A: Specify only TargetId. The system reads Endpoint, ApiKey, ModelName, ConnectionMethod, and ConnectionConfig from the saved target configuration and ignores any parameters with the same names in the request.</description></item>
        /// <item><description>Approach B: Do not specify TargetId. Instead, provide the five connection parameters directly in the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestConnectivityRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TestConnectivityResponse
        /// </returns>
        public async Task<TestConnectivityResponse> TestConnectivityWithOptionsAsync(TestConnectivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiKey))
            {
                query["ApiKey"] = request.ApiKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckId))
            {
                query["CheckId"] = request.CheckId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionConfig))
            {
                query["ConnectionConfig"] = request.ConnectionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionMethod))
            {
                query["ConnectionMethod"] = request.ConnectionMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModelName))
            {
                query["ModelName"] = request.ModelName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetId))
            {
                query["TargetId"] = request.TargetId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestConnectivity",
                Version = "2026-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestConnectivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests the network connectivity and authentication validity of an AI Red Teaming target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the network connectivity and authentication validity of a specified attack target.
        /// This operation uses an asynchronous polling model:</para>
        /// <list type="bullet">
        /// <item><description>First call (without CheckId): Immediately returns a CheckId with VerifyStatus=checking. The actual test runs asynchronously in the background for up to 60 seconds.</description></item>
        /// <item><description>Subsequent calls (with the CheckId returned from the first call): Queries the latest status of the corresponding CheckId, which may be checking, verified, or failed.</description></item>
        /// <item><description>Poll at 2-second intervals for up to 60 seconds. After the CheckId expires, the operation returns failed with VerifyMessage set to &quot;check expired, please retry&quot;.
        /// Use one of the following two approaches for parameters:</description></item>
        /// <item><description>Approach A: Specify only TargetId. The system reads Endpoint, ApiKey, ModelName, ConnectionMethod, and ConnectionConfig from the saved target configuration and ignores any parameters with the same names in the request.</description></item>
        /// <item><description>Approach B: Do not specify TargetId. Instead, provide the five connection parameters directly in the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestConnectivityRequest
        /// </param>
        /// 
        /// <returns>
        /// TestConnectivityResponse
        /// </returns>
        public TestConnectivityResponse TestConnectivity(TestConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestConnectivityWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Tests the network connectivity and authentication validity of an AI Red Teaming target.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Tests the network connectivity and authentication validity of a specified attack target.
        /// This operation uses an asynchronous polling model:</para>
        /// <list type="bullet">
        /// <item><description>First call (without CheckId): Immediately returns a CheckId with VerifyStatus=checking. The actual test runs asynchronously in the background for up to 60 seconds.</description></item>
        /// <item><description>Subsequent calls (with the CheckId returned from the first call): Queries the latest status of the corresponding CheckId, which may be checking, verified, or failed.</description></item>
        /// <item><description>Poll at 2-second intervals for up to 60 seconds. After the CheckId expires, the operation returns failed with VerifyMessage set to &quot;check expired, please retry&quot;.
        /// Use one of the following two approaches for parameters:</description></item>
        /// <item><description>Approach A: Specify only TargetId. The system reads Endpoint, ApiKey, ModelName, ConnectionMethod, and ConnectionConfig from the saved target configuration and ignores any parameters with the same names in the request.</description></item>
        /// <item><description>Approach B: Do not specify TargetId. Instead, provide the five connection parameters directly in the request.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// TestConnectivityRequest
        /// </param>
        /// 
        /// <returns>
        /// TestConnectivityResponse
        /// </returns>
        public async Task<TestConnectivityResponse> TestConnectivityAsync(TestConnectivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestConnectivityWithOptionsAsync(request, runtime);
        }

    }
}
